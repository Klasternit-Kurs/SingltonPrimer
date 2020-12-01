using System;

namespace ConsoleApp19
{
	class Program
	{
		static void Main(string[] args)
		{
			SingletonTest st = SingletonTest.Instanciraj();
			SingletonTest st2 = SingletonTest.Instanciraj();
			NestoTamo ne = new NestoTamo();
			if (st == ne.st)
				Console.WriteLine("Isto :) ");
			Console.ReadKey();
		}
	}

	public class NestoTamo
	{
		public SingletonTest st;
		public NestoTamo()
		{
			st = SingletonTest.Instanciraj();
		}
	}

	public class SingletonTest
	{
		protected SingletonTest() { }

		private static SingletonTest _singl;

		private static object _bzvz = new object();

		public static SingletonTest Instanciraj()
		{
			if (_singl != null)
				lock (_bzvz)
				{
					if (_singl != null)
						_singl = new SingletonTest();
				}

			return _singl;
		}
	}
}
