using System;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{
   
    
    public static void Main(string[] args)
    {
        Thread threada = new Thread(CountUpThreadA);
        Thread threadb = new Thread(CountDownThreadB);

        threada.Start();
        threadb.Start();

        threada.Join();
        threadb.Join();

        Console.WriteLine("Übung 1: Zwei Threads – Zählen & Winner");
        
        
    }
    
    private static void CountUpThreadA()
    {
        for (int i = 1; i < 100; i++)
        {
            Thread.Sleep(100);
        }
    }
    
    private static void CountDownThreadB()
    {
        for (int i = 100; i > 1; i--)
        {
            Thread.Sleep(100);
        }
        
    }
}
