// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("---- Find max ---- ");

//>> THis class is For only Three Parameters

//MaximumNumberCheck<int> Output1= new MaximumNumberCheck<int>(11,22,33);
//Console.WriteLine("Max Int type Value :- "+Output1.MaxMethod());

//MaximumNumberCheck<float> Output2 = new MaximumNumberCheck<float>(45.5f, 98.54f, 56.21f);
//Console.WriteLine("Max Float type Value :- "+Output2.MaxMethod());

//MaximumNumberCheck<string> Output3 = new MaximumNumberCheck<string>("Peach", "Banana", "Apple");
//Console.WriteLine("Max String type Value :- "+Output3.MaxMethod());


//This Below Class is For passing multiple Parameters in the form of Array

int[] intArray = { 154, 541, 821, 321, 651 };
GenericMaximum<int> genericInt = new GenericMaximum<int>(intArray);
Console.WriteLine("Maximum Int type Value :- " + genericInt.PrintMaxValue());

double[] doubleArray = { 45.54, 70.00, 10.64, 90.45, 66.66 };
GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
Console.WriteLine("Maximum Double type Value :- " + genericDouble.PrintMaxValue());

string[] stringArray = { "555", "66", "3", "444", "999" };
GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
Console.WriteLine("Maximum String type Value :- " + genericString.PrintMaxValue());
Console.ReadKey();
