// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using MaxGenerics;

Console.WriteLine("---- Find max String ---- ");

string output1 = MaximumNumberCheck.MaximumStringNumber("Peach", "Banana", "Apple");
Console.WriteLine("Maximum String [TC.1]:- " + output1);

string output2 = MaximumNumberCheck.MaximumStringNumber("Apple", "Peach", "Banana");
Console.WriteLine("Maximum String [TC.2]:- " + output2);


string output3 = MaximumNumberCheck.MaximumStringNumber("Banana", "Apple", "Peach");
Console.WriteLine("Maximum String [TC.3]:- " + output3);


