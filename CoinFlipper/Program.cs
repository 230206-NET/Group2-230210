using System;
namespace CoinFlipper{
    public class MainMenu
    {
        public void Start()
        {
            var rand = new Random();
            var coin = rand.Next()%2==1;
            if(coin){
                Console.WriteLine("Coin came up tails");
            }
            else{
                Console.WriteLine("Coin came up heads");
            }
        }
    }
}