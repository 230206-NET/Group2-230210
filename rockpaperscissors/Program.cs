
internal class Program
{
    private static void Main(string[] args)
    {
        rockPaperScissors rps = new rockPaperScissors();
        rps.gameLoop();
    }
}


public class rockPaperScissors
{
    Random rand = new Random();
    int cpuChoice;
    string[] strs = {"rock", "paper", "scissors"};


    private void cpuMakeChoice(){
        cpuChoice = rand.Next(1, 4);
    }

    private void playerMakeChoice(){
        Console.WriteLine("Enter your choice, rock paper or scissors");
        string input = Console.ReadLine().ToLower();
        Console.WriteLine("Cpu picked {0}", strs[cpuChoice-1]);
        switch (input){
            case "rock":
                switch(cpuChoice){
                    case 1:
                        Console.WriteLine("Tie!");
                        break;
                    case 2:
                        Console.WriteLine("You lose!");
                        break;
                    case 3:
                        Console.WriteLine("You Win!");
                        break;
                }
                break;
            case "paper":
                switch(cpuChoice){
                    case 1:
                        Console.WriteLine("You Win!");
                        break;
                    case 2:
                        Console.WriteLine("Tie!");
                        break;
                    case 3:
                        Console.WriteLine("You Lose!");
                        break;
                }
                break;
            case "scissors":
                switch(cpuChoice){
                    case 1:
                        Console.WriteLine("You Lose!");
                        break;
                    case 2:
                        Console.WriteLine("You Win!");
                        break;
                    case 3:
                        Console.WriteLine("Tie!");
                        break;
                }
                break;
            default:
                Console.WriteLine("it appears you did not pick rock paper or scissors\ncpu wins on a technicality");
                break;
        }
    }

    public void gameLoop(){
        while (true)
        {
            cpuMakeChoice();
            playerMakeChoice();
        }
    }

    
}