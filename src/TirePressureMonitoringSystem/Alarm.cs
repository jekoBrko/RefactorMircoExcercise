using TDDMicroExercises.Interfaces;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm : IAlarm
    {
        private readonly ISensor _sensor;
        private readonly IAlarmPressureTreshold _tresholds;
        private bool _alarmOn = false;

        public Alarm()
        {
            _sensor = new Sensor();
            _tresholds = new DefaultAlarmPressureTreshold();
        }

        public Alarm(ISensor sensor, IAlarmPressureTreshold tresholds)
        {
            _sensor = sensor;
            _tresholds = tresholds;
        }

        public void Check()
        {
            double psiPressureValue = _sensor.PopNextPressurePsiValue();

            if (psiPressureValue < _tresholds.LowPressureThreshold || _tresholds.HighPressureThreshold < psiPressureValue)
            {
                _alarmOn = true;
            }
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }

    }
}
