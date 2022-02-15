using System;

namespace ConsoleApp3ArraysEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepGoing = true;
            while (keepGoing)
            {
                int selection = 0;
                printmenu();
                selection = UserInputNum("Select a menu: ");
 
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("ARRAY 1:" + CreatArray1().Length);
                        Console.WriteLine(string.Join(",", CreatArray1()));
                        break;
                    case 2:
                        CreateArray3();
                        Console.WriteLine("ARRAY 3:" + CreateArray3().Length);
                        break;
                    case 3:
                        CreateArray4();
                        Console.WriteLine("ARRAY 4:" + CreateArray4().Length);
                        break;
                    case 4:
                        CreateArray3();
                        string first = CreateArray3()[0];
                        string last = CreateArray3()[CreateArray3().Length - 1];
                        Console.WriteLine($"First animal is {first} and last animal is {last}");
                        break;
                    case 5:
                        CreateArray2D();
                        break;
                    case 99:
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                } // End of Switch
                Console.Write("Hit anykey to continue!!!");
                Console.ReadKey();
            }
            // End of While
        }

        private static void CreateArray2D()
        {
            // Part A: create 2D array of strings.
            string[,] array = new string[,]
            {
            {"cat", "dog"},
            {"bird", "fish"},
            {"wolf", "lion"},
            };
            // Part B: access (and print) values.
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    Console.Write($"i={i} and x={x} and element is {array.GetValue(i, x)}\n");
                    
                }
            }
        }

            private static void printmenu()
        {
            Console.Clear();
            Console.WriteLine("----- Arrays Menu -----\n");
            Console.WriteLine("1: Create Array 1");
            Console.WriteLine("2: Create Array 3");
            Console.WriteLine("3: Create Array 4");
            Console.WriteLine("4: Find out First and Last in array");
            Console.WriteLine("5. Create 2D Array (hardcode element)");
            Console.WriteLine("99: Exit program");
            Console.WriteLine("\nEnter you choice: ");
        }

        private static int UserInputNum(string v)
        {
            bool isitnumber = false;
            int userSelInt = 0;
            Console.Write(v);
            isitnumber = int.TryParse(Console.ReadLine(), out userSelInt);
            if (!isitnumber)
            {
                Console.WriteLine("You are NOT entering a number!");
                Console.ReadLine();
                Console.Clear();
            }
            return userSelInt;
        }
        // End of UserInputNum
        static string[] CreateArray4()
        {
            string[] animal4 = new[] { "deer", "moose", "boars", "wolf" };
            return animal4;
        }

        static string[] CreateArray3()
        {
            string[] animal3 = { "deer", "moose", "boars", "wolf" };
            return animal3;

        }

        static string[] CreatArray1()
        {
            string[] animal = new string[4];
            animal[0] = "deer";
            animal[1] = "moose";
            animal[2] = "boars";
            animal[3] = "wolf";
            return animal;
        }
    }
}
