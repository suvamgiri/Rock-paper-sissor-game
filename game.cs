using System;

class Program
{
    public static void Main(string[] args)
    {
        Random playing = new Random();
        Console.Write("How many time do you want to play: ");
        int time = Convert.ToInt32(Console.ReadLine());
        int winrate = 0;
        Console.WriteLine("1 = Rock");
        Console.WriteLine("2 = Paper");
        Console.WriteLine("3 = sissors");

        string[] choices = { "", "rock", "paper", "scissors" };

        for (int i = 0; i < time; i++)
        {
            int user1 = 0;
            bool invalid = false;

            while (!invalid)
            {
                Console.Write("Enter your choice : ");

                int user = Convert.ToInt32(Console.ReadLine()); ;

                if (user < 4 )
                {
                    user1 = user;
                    invalid = true;
                }
                else
                {

                    Console.WriteLine("enter the correct number");

                }
            }

            Console.WriteLine("user : " + choices[user1]);

            int num = playing.Next(1, 4);
            Console.WriteLine("computer : " + choices[num]);

            if (user1 == 1 && num == 2)
            {
                Console.WriteLine("You lose");
            }
            else if (user1 == 2 && num == 3)
            {
                Console.WriteLine("You lose");
            }
            else if (user1 == 3 && num == 1)
            {
                Console.WriteLine("You lose");

            }
            else if (user1 == 2 && num == 1)
            {

                Console.WriteLine("You win");
                winrate++;
            }
            else if (user1 == 3 && num == 2)
            {
                Console.WriteLine("You win");
                winrate++;
            }
            else if (user1 == 1 && num == 3)
            {
                Console.WriteLine("You lose");
                winrate++;
            }


            else
            {
                Console.WriteLine("It's a tie");
            }



        }

        Console.WriteLine("You won " + winrate + " times out of " + time + " games.");

    }
}
