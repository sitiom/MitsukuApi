# MitsukuApi
An unofficial API for Mitsuku (Kuki) bot in C#.

## Basic Usage

```cs
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
```
