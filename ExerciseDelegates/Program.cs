namespace ExerciseDelegates
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var emailTask = new EmailTask()
            {
                Message = "Hello, I am a Message",
                Recipient = "I am a email"


            };



            var reportTask = new ReportTask()
            {
                ReportName = " AnualReport"
                
            };


            var emailProcessor = new TaskProcessor<EmailTask, string>(emailTask);
            var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);


            Console.WriteLine( emailProcessor.Execute());
            Console.WriteLine( reportProcessor.Execute());
        }


    }
}
