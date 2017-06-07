using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace _01_AutoResetEvent
	{
	class Program
		{
		//static AutoResetEvent events = new AutoResetEvent(false);
		static ManualResetEvent events = new ManualResetEvent(false);
		static void Main(string[] args)
			{
			Thread thread = new Thread(Function1);
			thread.Start();
			Console.WriteLine("click");
			Console.ReadKey();
			Console.WriteLine();
			events.Set();
			Console.WriteLine("click");
			Console.ReadKey();
			Console.WriteLine();
			events.Set();
			}
		static void Function1()
			{
			Console.WriteLine("Червоний");
			events.WaitOne();////перехід в несигнальний стан

			Console.WriteLine("Жовтий");
			events.WaitOne();////перехід в несигнальний стан
			Console.WriteLine("Зелений");
			}
		}
	}
