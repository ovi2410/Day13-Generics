// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using MaxGenerics;

Console.WriteLine("---- Find max Number ---- ");

int output1 = MaximumNumberCheck.MaximumIntegerNumber(300, 200, 100);
Console.WriteLine("Maximum Number [TC.1]:- " + output1);

int output2 = MaximumNumberCheck.MaximumIntegerNumber(200, 300, 100);
Console.WriteLine("Maximum Number [TC.1]:- " + output2);


int output3 = MaximumNumberCheck.MaximumIntegerNumber(100, 200, 300);
Console.WriteLine("Maximum Number [TC.1]:- " + output3);

