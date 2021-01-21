using System;
using System.Threading;

namespace ServerApplication
{
    class Program
    {
        private static Thread threadConsole;
        private static bool consoleRunning;

        static void Main(string[] args)
        {
            threadConsole = new Thread(new ThreadStart(consoleThread));
            threadConsole.Start();
        }

        private static void consoleThread()
        {
            string line;
            consoleRunning = true;

            while(consoleRunning)
            {
                line = Console.ReadLine();
                
                if(String.IsNullOrWhiteSpace(line))
                {
                    consoleRunning = false;
                    return;
                }
                else
                {

                }


            }
        }

    }

}
