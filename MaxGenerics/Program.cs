// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using uc2_findmaxof3float;

Console.WriteLine("---- Find max Number ---- ");

float output1 = MaximumNumberCheck.MaximumIntegerNumber(30.55f, 20.54f, 10.65f);
Console.WriteLine("Maximum Number [TC.1]:- " + output1);

float output2 = MaximumNumberCheck.MaximumIntegerNumber(20.54f, 30.55f, 10.65f);
Console.WriteLine("Maximum Number [TC.2]:- " + output2);


float output3 = MaximumNumberCheck.MaximumIntegerNumber(10.65f, 20.54f, 30.55f);
Console.WriteLine("Maximum Number [TC.3]:- " + output3);

