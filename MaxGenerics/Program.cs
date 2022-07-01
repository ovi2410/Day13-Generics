// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using MaxGenerics;

Console.WriteLine("---- Find max ---- ");

int output1 = MaximumNumberCheck<int>.MaximumStringNumber(15, 32, 64);
Console.WriteLine("Maximum int [TC.1]:- " + output1);

float output2 = MaximumNumberCheck<float>.MaximumStringNumber(45.5f, 98.54f, 56.21f);
Console.WriteLine("Maximum float [TC.1]:- " + output2);

string output3 = MaximumNumberCheck<string>.MaximumStringNumber("Peach", "Banana", "Apple");
Console.WriteLine("Maximum String [TC.1]:- " + output3);

