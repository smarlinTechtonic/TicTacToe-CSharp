using System;

namespace TicTacToe
{
    class TicTacToeGame
    {
        static char[,] board = {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
        };

        private static int turns;

        public static void Main(string[] args)
        {
            int player = 1;
            int input = 0;
            bool correctInput = true;
            setBoard();

            do
            {
                char[] playerChars = { 'X', 'O' };
                foreach (char playerChar in playerChars)
                {
                    if (((board[0, 0] == playerChar) && (board[0, 1] == playerChar) && (board[0, 2] == playerChar))
                        || ((board[1, 0] == playerChar) && (board[1, 1] == playerChar) && (board[1, 2] == playerChar))
                        || ((board[2, 0] == playerChar) && (board[2, 1] == playerChar) && (board[2, 2] == playerChar))
                        || ((board[0, 0] == playerChar) && (board[1, 1] == playerChar) && (board[2, 2] == playerChar))
                        || ((board[0, 2] == playerChar) && (board[1, 1] == playerChar) && (board[2, 0] == playerChar))
                        || ((board[0, 0] == playerChar) && (board[1, 0] == playerChar) && (board[2, 0] == playerChar))
                        || ((board[0, 1] == playerChar) && (board[1, 1] == playerChar) && (board[2, 1] == playerChar))
                        || ((board[0, 2] == playerChar) && (board[1, 2] == playerChar) && (board[2, 2] == playerChar))
                        )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("Player {0} has won!! Good Job Player 1", playerChar);
                        }
                        else
                        {
                            Console.WriteLine("Player {0} has won!! Good Job Player 2.", playerChar);
                        }
                            

                        Console.WriteLine("Enter any key to reset game");
                        Console.ReadKey();

                        resetBoard();
                        break;
                    } else if (turns == 9)
                    {
                        Console.WriteLine("The game ended in a draw");
                        Console.WriteLine("Enter any key to reset game");
                        Console.ReadKey();
                        resetBoard();
                        break;
                    }
                }

                do
                {
                    Console.WriteLine("Player {0}'s turn!", player);
                    Console.WriteLine("Player {0}: Pick a number", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                        if ((input == 1) && (board[0, 0] == '1')) correctInput = true;
                        else if ((input == 2) && (board[0, 1] == '2')) correctInput = true;
                        else if ((input == 3) && (board[0, 2] == '3')) correctInput = true;
                        else if ((input == 4) && (board[1, 0] == '4')) correctInput = true;
                        else if ((input == 5) && (board[1, 1] == '5')) correctInput = true;
                        else if ((input == 6) && (board[1, 2] == '6')) correctInput = true;
                        else if ((input == 7) && (board[2, 0] == '7')) correctInput = true;
                        else if ((input == 8) && (board[2, 1] == '8')) correctInput = true;
                        else if ((input == 9) && (board[2, 2] == '9')) correctInput = true;
                        else
                        {
                            correctInput = false;
                            Console.WriteLine("That number is not available. Pick a different one!");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number");
                    }
                    
                } while (!correctInput);

                changeBoard(player, input);
                if (player == 1) player = 2;
                else player = 1;
                setBoard();
            } while (true);
        }

        public static void resetBoard()
        {
            char[,] initialBoard = {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
        };
            board = initialBoard;
            setBoard();
            turns = 0;
        }

        public static void setBoard()
        {
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("   |   |   ");
            turns++;
        }

        public static void changeBoard(int player, int input)
        {
            char playerChar;
            if (player == 1) playerChar = 'X';
            else playerChar = 'O';

            switch (input)
            {
                case 1:
                    board[0, 0] = playerChar; break;
                case 2:               
                    board[0, 1] = playerChar; break;
                case 3:               
                    board[0, 2] = playerChar; break;
                case 4:               
                    board[1, 0] = playerChar; break;
                case 5:               
                    board[1, 1] = playerChar; break;
                case 6:               
                    board[1, 2] = playerChar; break;
                case 7:               
                    board[2, 0] = playerChar; break;
                case 8:               
                    board[2, 1] = playerChar; break;
                case 9:               
                    board[2, 2] = playerChar; break;
            }
        }
    }
}
