using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var rand = new Random();
        var num = rand.Next(1,20);
        var found = false;
        int input;
        Console.WriteLine("Enter a number between 1 and 20 inclusive");
        while(!found){
            input = int.Parse(Console.ReadLine());
            if(input>num) Console.WriteLine("too high");
            else if(input<num) Console.WriteLine("too low");
            else found=true;
        }
        Console.WriteLine("Good job!");
    }
   
   


}