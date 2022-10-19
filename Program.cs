using System.Windows;

namespace TicTacToe
{
    internal class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 0;
        static string playername1;
        static string playername2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Would you like to play?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("Great!");
                StartGame();
            }
            else if (answer == "no")
            {
                Console.WriteLine("Well...that is disappointing :(");
                Console.WriteLine();
                Thread.Sleep(2000);
                Main(args);
            }
            else
            {
                Console.WriteLine("Please answer 'yes' or 'no'.");
                Console.WriteLine();
                Thread.Sleep(2000);
                Main(args);
            }
        }

        private static void StartGame()
        {
            Console.WriteLine("Who is player 1?");
            playername1 = Console.ReadLine();
            Console.WriteLine($"Welcome {playername1}!");
            Thread.Sleep(1000);
            Console.WriteLine("Who is player 2?");
            playername2 = Console.ReadLine();
            Console.WriteLine($"Welcome {playername2}!");
            Thread.Sleep(1000);
            Console.WriteLine($"{playername1} is X's and {playername2} is O's");
            Thread.Sleep(1000);
            do
            {
                Console.Clear();
                if (player % 2 == 0)
                {
                    Console.WriteLine($"{playername2}'s turn!");
                }
                else
                {
                    Console.WriteLine($"{playername1}'s turn!");
                }
                Board();
                choice = int.Parse(Console.ReadLine());
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine($"Sorry, spot {choice} is already marked with {arr[choice]}...try again.");
                    Thread.Sleep(3000);
                }
                flag = CheckWin();

            }
            while (flag != 1 && flag != -1);
            Console.Clear();
            Board();
            if (flag == 1)
            {
                if ((player % 2) + 1 == 0)
                {
                    Console.WriteLine($"{playername2} wins!");
                }
                else
                {
                    Console.WriteLine($"{playername1} wins!");
                }
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            Console.ReadLine();
        }

        //private static void PlayAgain()
        //{
        //    Console.WriteLine("Would you like to restart?");
        //    string answer = Console.ReadLine();
        //    if (answer == "yes")
        //    {
        //        app
        //    }
        //    else if (answer == "Yes")
        //    {
        //        StartGame();
        //    }
        //    else if (answer == "no")
        //    {
        //        Console.WriteLine("Okay! Thanks for playing!");
        //        return;
        //    }
        //    else if (answer == "No")
        //    {
        //        Console.WriteLine("Okay! Thanks for playing!");
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please answer 'yes' or 'no'.");
        //        PlayAgain();
        //    };
        //}

        private static int CheckWin()
        {
            //horizontal win patterns
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }
            //vertical win patterns
            else if (arr[7] == arr[4] && arr[4] == arr[1])
            {
                return 1;
            }
            else if (arr[8] == arr[5] && arr[5] == arr[2])
            {
                return 1;
            }
            else if (arr[9] == arr[6] && arr[6] == arr[3])
            {
                return 1;
            }
            //diagonal win patterns
            else if (arr[7] == arr[5] && arr[5] == arr[3])
            {
                return 1;
            }
            else if (arr[9] == arr[5] && arr[5] == arr[1])
            {
                return 1;
            }
            //draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {arr[7]}  |  {arr[8]}  |  {arr[9]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {arr[4]}  |  {arr[5]}  |  {arr[6]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {arr[1]}  |  {arr[2]}  |  {arr[3]}");
            Console.WriteLine("     |     |      ");
        }
    }
}