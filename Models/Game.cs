using System;
using System.Collections.Generic;

namespace rock_paper_scissors_csharp  
{

public class Game
{
            string rock = (@"
        
    **  
  ****  
 ****** 
      ");

            string paper = (@"
        
 ******  
 ****** 
 ****** 
      ");

            string scissors = (@"
  * * 
   *   
  * * 
 *   * 
      ");

      public void Play(){


        Random random = new Random();
        int rnd = random.Next(1, 4);

            Console.Clear();
            Console.WriteLine("Would you like to play Rock Paper Scissors? (y/n)");
            var choice = Console.ReadKey().KeyChar;
            if (choice == 'n')
            {
              Console.WriteLine("\nOkay, well I don't understand why you came here. Goodbye");
            }
            else
            {
              Console.WriteLine("Let's Play!");
              Console.WriteLine("\nChoose your weapon...  (Rock = r, Paper = p, Scissors = s");
              var weapon = Console.ReadKey().KeyChar;
              if ((weapon == 'r' && rnd == 3) || (weapon == 'p' && rnd == 1) || (weapon == 's' && rnd ==2))
              {
              Console.WriteLine("Computer chose: " + rnd);
              Console.WriteLine("You chose: " + weapon);
              Console.WriteLine("You Win!");
              }
              else if ((weapon == 'r' && rnd == 1) || (weapon == 'p' && rnd == 2) || (weapon == 's' && rnd ==3))
               {
              Console.WriteLine("Computer chose: " + rnd);
              Console.WriteLine("You chose: " + weapon);
              Console.WriteLine("Draw!");
              }
              else 
              {
              Console.WriteLine("Computer chose: " + rnd);
              Console.WriteLine("You chose: " + weapon);
              Console.WriteLine("You Lose!");
              }
            }
      }
} 


}

