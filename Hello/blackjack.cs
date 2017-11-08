//using System;
///// <summary>
///// A simple example of Blackjack card game
///// </summary>
//namespace Hello
//{
//   public class blackjack
//    {
//        public static void mustapekka()
//        {
//            int myNumber = 17;
//            int theirNumber;
//            string i = "";
//            Console.WriteLine("DO you wanna play a game?y/n");
//            i = Console.ReadLine();
//            do
//            {
//                System.Console.WriteLine("*** BlackJack! ***");
//                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
//                //reading and converting 

//                theirNumber = System.Convert.ToInt32(System.Console.ReadLine());

//                //comparing that given umber is valid

//                do
//                {
//                    Console.WriteLine("The given number is out of limits, try again.");
//                    System.Console.Write("The number was not between 1-21. Enter any number between 1-21: ");
//                    theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
//                } while (theirNumber < 1 || theirNumber > 21);

//                //comparing
//                if (theirNumber >= myNumber && theirNumber <= 21)
//                {
//                    System.Console.WriteLine("You win.");
//                }
//                else
//                {
//                    System.Console.WriteLine("You lose.");
//                }
//            } while (i );
//        }
//    } 
//}