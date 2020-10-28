using System;
using MitsukuApi;
using MitsukuApi.Models;

namespace Example
{
	class Program
	{
		private static void Main()
		{
			MitsukuChatBot mitsuku = new MitsukuChatBot();
			while (true)
			{
				Console.Write("|>>>");
				MitsukuResponse response = mitsuku.SendMessage(Console.ReadLine());
				Console.WriteLine();

				foreach (string msg in response.Responses)
				{
					Console.WriteLine(msg);
				}
				Console.WriteLine();
			}
		}
	}
}