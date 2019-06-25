using System;
using System.Threading.Tasks;

namespace QuartzTutorial
{
    public interface IEmailSender : IDisposable
    {
        Task Send(string msg);
    }
    public class EmailSender : IEmailSender
    {
        private IClock _clock;
        public EmailSender(IClock clock)
        {
            _clock = clock ?? throw new ArgumentNullException(nameof(clock));
        }

        public void Dispose()
        {
            Console.Out.WriteLine("Dispose EmailSender");
        }

        public async Task Send(string msg)
        {
            await Console.Out.WriteLineAsync($"Sending email: {msg} at {_clock.Now()}");
        }
    }
}