using System;

namespace QuartzTutorial
{
    public interface IClock : IDisposable
    {
        DateTimeOffset Now();
    }

    public class Clock : IClock
    {
        public void Dispose()
        {
            Console.Out.WriteLine("Dispose Clock");
        }

        public DateTimeOffset Now()
        {
            return DateTimeOffset.Now;
        }
    }
}