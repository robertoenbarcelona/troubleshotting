
namespace ConsoleHost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert operation please");
            var input = Console.ReadLine();
            Program.InterpretComand(input);
        }

        private static void InterpretComand(string input)
        {
            switch (input)
            {
                case "s":
                    Console.WriteLine("Insert end of the sentence");
                    var mode = Console.ReadLine();
                    var composer = new SentecesComposer(mode);
                    string sentece = null;
                    composer.GenerateResponse(sentece);
                    Console.WriteLine(sentece);
                    break;
                case "b":
                    Console.WriteLine("Insert divisor value, max 99");
                    var divisor = int.Parse(Console.ReadLine());
                    var calc = new BreakpointTester(Program.CreateOperandumList());
                    Console.WriteLine(calc.TestExcactDivision(divisor));
                    break;
                case "a":
                    Console.WriteLine("Write a sentece");
                    var assertTester = new AssertTester(Console.ReadLine());
                    Console.WriteLine("Wanna offset? true:false");
                    var offset = bool.Parse(Console.ReadLine());
                    Console.WriteLine(assertTester.TestCryptMessage(offset));
                    break;
                case "e":
                    Console.WriteLine("Insert steps, max 9");
                    var steps = int.Parse(Console.ReadLine());
                    var exTester = new ExceptionTester(steps);
                    Console.WriteLine(exTester.CallingMethod());
                    break;
                case "o":
                    Console.WriteLine("Insert steps, max 9");
                    var stepss = int.Parse(Console.ReadLine());
                    var uTester = new UnitTester(stepss);
                    Console.WriteLine(uTester.BuildPhrase());
                    break;
                case "l":
                    EventLogWriter.WriteLog("Este es un mensaje para el log de eventos de windows", EventLogWriter.LogEvent.AppError);
                    break;
                default:
                    break;
            }
        }

        private static List<Tuple<int, int>> CreateOperandumList()
        {
            var testData = new List<Tuple<int, int>>();
            var randNum = new Random();
            for (var x = 0; x < 10000; x++)
            {
                var oper = new Tuple<int, int>(randNum.Next(), randNum.Next(-1000, 0));
                testData.Add(oper);
            }
            return testData;
        }
    }
}
