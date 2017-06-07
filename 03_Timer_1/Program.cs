using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_Timer_1
	{
	class Program
		{
		static int param = 20;

		static void Main(string[] args)
			{
			TimerCallback timerCallback = new TimerCallback(TimerTik);
			Timer timer = new Timer(timerCallback);
			timer.Change(700, 300); //ЗАпуск таймера
			Console.ReadKey();
			}

		private static void TimerTik(object state)
			{
			
			Console.WriteLine($"{param--}");
			if(param<0)
				{
				Timer timer = state as Timer;
				timer.Dispose();
				}
			}
		}
	}
