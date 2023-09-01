Console.WriteLine("Hello, World!");
Thread.Sleep(1000);
Console.WriteLine("Tell me somthing");
string input = Console.ReadLine();

Console.WriteLine("Processing");
Thread.Sleep(2000);

Console.WriteLine($"You said {(input == String.Empty ? "nothing" : input)}");

