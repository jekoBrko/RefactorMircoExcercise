using NUnit.Framework;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace NUnitTests
{
    [TestFixture]
    public class AlarmTests
    {
        [Test]
        public void Check_AlarmOn_DefaultValue_ShouldBeFalse()
        {
            // Arrange & Act
            var alarm = new Alarm();

            //Assert
            Assert.IsFalse(alarm.AlarmOn);
        }
    }
}
