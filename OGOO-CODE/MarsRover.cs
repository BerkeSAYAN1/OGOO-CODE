using System;

namespace OGOO_CODE
{
    class MarsRover
    {
        private static Position position;
        private static Build build;
        public void executeCommand(char command)
        {
            
            char updateDirection = position.getUpdateDirection(command, position.dir, build);
            int[] updatePosition;
            if (command == 'M')
            {
                position.getUpdateLocation(position.r, position.s, updateDirection);
            }
            position.dir = updateDirection;
        }
        static void Main(string[] args)
        {
            MarsRover m = new MarsRover();
            // Type your length of space
            Console.WriteLine("Enter xpath: like 5 5 or 10 10");
            int[,] space;
            while (true)
            {
                // Create a string variable and get user input from the keyboard and store it in the variable
                string xpath = Console.ReadLine();
                if(!xpath.Contains(" "))
                {
                    Console.WriteLine("Boşluk bırakarak giriniz");
                    continue;
                }
                string[] array = xpath.Split(" ");
                int number = 0;
                bool t = int.TryParse(array[0], out number);
                int number2;
                bool t1 = int.TryParse(array[1], out number2);
                if (t.Equals(false) || t1.Equals(false))
                {
                    Console.WriteLine("Tekrar giriniz");
                }
                else
                {
                    break;
                }
                space = new int[number, number2];
            }
            
            build = new Build();
            build.populateDirections();
            build.populateMoves();
            build.buildDirectionMatrix(3 ,4);
            Console.WriteLine("Enter row: ");
            int row = 0;
            int.TryParse(Console.ReadLine(),out row);
            Console.WriteLine("Enter Column: ");
            int column = 0;
            int.TryParse(Console.ReadLine(), out column);
            char[] directions;
            while (true) {
                Console.WriteLine("Enter direction: (N, S, E, W)");
                directions = Console.ReadLine().ToCharArray();
                if (directions.Length > 1)
                    Console.WriteLine("Write Again");
                else
                {
                    if(!(directions[0].Equals('N') || directions[0].Equals('S') || directions[0].Equals('E') || directions[0].Equals('W')))
                    {
                        Console.WriteLine("Write Again");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            position = new Position(row, column, directions[0]);
            Console.WriteLine("Enter movings");
            char[] commands = Console.ReadLine().ToCharArray(); 
            foreach (char c in commands)
            {
                m.executeCommand(c);
            }
            Console.WriteLine(position.r);
            Console.WriteLine(position.s);
            Console.WriteLine(position.dir);
            
        }
        public void commandsTest()
        {
            
        }
    }
}
