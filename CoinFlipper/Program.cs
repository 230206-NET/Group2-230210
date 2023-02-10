using System;
namespace CoinFlipper{
    internal class CoinFlipper
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