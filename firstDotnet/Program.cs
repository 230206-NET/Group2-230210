// See https://aka.ms/new-console-template for more information
// //exercise 1
// Console.WriteLine("Hello: \nNick Wentzel");

// //exercise 2
// Console.WriteLine(10+20);

// //exercise 3
// Console.WriteLine(10/2);

// //exercise 4
// Console.WriteLine(-1+4*6);
// Console.WriteLine((35+5)%7);
// Console.WriteLine(14+(-4)*6/11);
// Console.WriteLine(2+15/6*1-7%2);

// //exercise 5
// Console.Write("Input first number:");
// var num1 = int.Parse(Console.ReadLine());
// Console.Write("Input second number:");
// var num2 = int.Parse(Console.ReadLine());
// var temp = num2;
// num2 = num1;
// num1 = temp;
// Console.WriteLine("After swapping");
// Console.WriteLine("First Number: {0}", num1);
// Console.WriteLine("Second Number: {0}", num2);

Console.WriteLine("Enter number:");
var num = int.Parse(Console.ReadLine());
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("{0} * {1} = {2}", num, i, num*i);
}