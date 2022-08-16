using Moq;
using NUnit.Framework;
using TDDMicroExercises.Interfaces;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace NUnitTests
{
    [TestFixture]
    public class AlarmTests
    {
        private readonly Mock<ISensor> _mockSensor = new Mock<ISensor>();
        private readonly Mock<IAlarmPressureTreshold> _mockPressureTreshold = new Mock<IAlarmPressureTreshold>();

        [Test]
        public void Check_AlarmOn_DefaultValue_ShouldBeFalse()
        {
            // Arrange & Act
            var alarm = new Alarm();

            //Assert
            Assert.IsFalse(alarm.AlarmOn);
        }

        [Test]
        public void Check_ExpectedValues()
        {
            // Arrange
            double sensorValue = 5;
            double highPressure = 1;
            double lowPressure = 1;

            _mockSensor.Setup( sensor => sensor.PopNextPressurePsiValue()).Returns(sensorValue);

            _mockPressureTreshold.Setup( pressure => pressure.HighPressureThreshold).Returns(highPressure);
            _mockPressureTreshold.Setup( pressure => pressure.LowPressureThreshold).Returns(lowPressure);

            IAlarm alarm = new Alarm(_mockSensor.Object, _mockPressureTreshold.Object);

            // Act
            alarm.Check();

            //Assert
            Assert.IsTrue(alarm.AlarmOn);
        }
    }
}
