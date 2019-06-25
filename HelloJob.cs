using System;
using System.Threading.Tasks;
using Quartz;

namespace QuartzTutorial
{
    [DisallowConcurrentExecution]
    class HelloJob : IJob
    {
        public static int Count = 0;
        private readonly IEmailSender _emailSender;
        private readonly string _jobName;
        public HelloJob(IEmailSender emailSender)
        {
            _emailSender = emailSender ?? throw new ArgumentNullException(nameof(emailSender));
            _jobName = $"JobNumber{Count++}";
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await _emailSender.Send(_jobName); 
        }
    }
}