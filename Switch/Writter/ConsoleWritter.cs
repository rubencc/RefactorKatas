using System;

namespace Switch.Writter
{
    public class ConsoleWritter : IOutputWritter
    {
        private static readonly IOutputWritter instance = new ConsoleWritter();

        private ConsoleWritter()
        {
            
        }

        public void WriteLine(object input)
        {
            Console.WriteLine(input.ToString());
        }

        public void Write(object input)
        {
            Console.Write(input.ToString());
        }

        public static IOutputWritter Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
