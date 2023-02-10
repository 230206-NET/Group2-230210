internal class Program
{
    static double budget = double.NaN;
    static List<(double,string)> expenses = new List<(double,string)>();
    private static void Main(string[] args)
    {
        int menuoption = 0;
        while(true){
            Console.WriteLine("Please Choose from the following:\n1. Set budget\n2. Add expense\n3. Display current budget\n4. Exit");
            try{
                menuoption = int.Parse(Console.ReadLine());
            }
            catch(Exception e){
                Console.WriteLine("Please Pick from the provided options");
            }
            switch(menuoption)
            {
                case 1:
                    userSetBudget();
                    break;
                case 2:
                    userAddExpense();
                    break;
                case 3:
                    if(budget!=double.NaN) displayBudget();
                    else Console.WriteLine("Input a budget first");
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please Pick from the provided options");
                    break;
            }

        }
        

    }

    static void userSetBudget(){
        Console.WriteLine("Enter value to set budget to: ");
        try
        {
            budget = double.Parse(Console.ReadLine());
        }
        catch(FormatException e){
            Console.WriteLine("Please enter a valid number");
        }
    }

    static void userAddExpense(){
        double temp;
        string tempstr;
        Console.WriteLine("Enter value for expense: ");
        try
        {
            temp = double.Parse(Console.ReadLine());
        }
        catch(FormatException e){
            Console.WriteLine("Please enter a valid number");
            return;
        }

        Console.WriteLine("Enter description for expense: ");
        tempstr = Console.ReadLine();
        expenses.Add((temp, tempstr));

    }

    static void displayBudget(){
        Console.Clear();
        Console.WriteLine("Value     Description");
        double total = 0;
        foreach (var expense in expenses)
        {
            string num = expense.Item1.ToString();
            Console.WriteLine(num + new string(' ', 10 - num.Length) + expense.Item2);
            total += expense.Item1;
        }
        Console.WriteLine("\nTotal: {0}\nRemaining funds: {1}\n\n", total, budget - total);
    }
}