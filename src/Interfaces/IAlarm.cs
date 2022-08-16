namespace TDDMicroExercises.Interfaces
{
    public interface IAlarm
    {
        void Check();
        bool AlarmOn { get; }
    }
}
