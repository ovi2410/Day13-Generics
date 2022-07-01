// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using MaxGenerics;

Console.WriteLine("---- Find max ---- ");

MaximumNumberCheck<int> Output1 = new MaximumNumberCheck<int>(11, 22, 33);
Console.WriteLine("Max Int type Value :- " + Output1.MaxMethod());

MaximumNumberCheck<float> Output2 = new MaximumNumberCheck<float>(45.5f, 98.54f, 56.21f);
Console.WriteLine("Max Float type Value :- " + Output2.MaxMethod());

MaximumNumberCheck<string> Output3 = new MaximumNumberCheck<string>("Peach", "Banana", "Apple");
Console.WriteLine("Max String type Value :- " + Output3.MaxMethod());


