using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_AutoResetEvent_Example
	{
	class Program
		{
		static AutoResetEvent[] events = new AutoResetEvent[2] { new AutoResetEvent(false), new AutoResetEvent(false) };
		static void Main(string[] args)
			{
			Thread thread1 = new Thread(Function1);
			thread1.IsBackground = true;
			thread1.Start();
			Thread.Sleep(100);
			Thread thread2 = new Thread(Function2);
			thread2.IsBackground = true;
			thread2.Start();
			for(int i = 0; i < 10; i++)
				{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write(i);
				events[0].Set();
				Thread.Sleep(100);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("-");
				events[1].Set();
				Thread.Sleep(300);
				}
			Console.ForegroundColor = ConsoleColor.Yellow;
			}
		static void Function1()
			{
			for(int i = 0; i < 10; i++)
				{
				events[0].WaitOne();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("Tik");
				
				}
			}
		static void Function2()
			{
			for(int i = 0; i < 10; i++)
				{
				events[1].WaitOne();
				Console.ForegroundColor = ConsoleColor.Red;
				
				Console.WriteLine("tak");				
				}
			}
		}
	}
