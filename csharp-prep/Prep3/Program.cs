using System;

class Program
{
    static void Main(string[] args)
    {
       // Part 1 and 2
    //   Console.Write("What is the magic number? ");
      Random randomNum = new Random();
      int magicNumber = randomNum.Next(1,101);

      int guess = -1;

      while (guess != magicNumber)
      {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else{
            Console.WriteLine("You guessed it!");
        }
      }



    //    Random randomGen = new Random();
    //    int magicNumber = Console.ReadLine()
    }
}