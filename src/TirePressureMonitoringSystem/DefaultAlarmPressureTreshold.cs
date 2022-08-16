using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDMicroExercises.Interfaces;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class DefaultAlarmPressureTreshold : IAlarmPressureTreshold
    {
        public double LowPressureThreshold { get; set; } = 17;
        public double HighPressureThreshold { get; set; } = 21;
    }
}
