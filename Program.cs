using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo ");
            Console.WriteLine("M = Minuto ");
            Console.WriteLine("0 = Sair ");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multplier = 1;

            if (time == 0)
                System.Environment.Exit(0);
            if (type == 'm')
                multplier = 60;
            PreStart(time * multplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar.....");
            Thread.Sleep(500);
            Console.WriteLine("Apontar.....");
            Thread.Sleep(300);
            Console.WriteLine("Fogo.....");
            Thread.Sleep(200);
            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizada");
            Thread.Sleep(1800);
            Menu();
        }
    }
}