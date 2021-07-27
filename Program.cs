using System;

namespace testfolder
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true){           
                Console.WriteLine("Enter 1 for addition\t 2 for subtraction\t 3 for multiplication\t 4 for division\t 5 to Exit");
                int choice = int.Parse(Console.ReadLine());
                
                if(choice==5)
                    break;
                         
                Console.WriteLine("Enter two numbers");
                string[] numbers = Console.ReadLine().Split(' ');
                int x = int.Parse(numbers[0]);
                int y = int.Parse(numbers[1]);
                
                switch(choice)
                {
                    case 1:
                        Console.WriteLine($"Addition of {x} and {y} is {x+y}");
                        break;
                    case 2:
                        Console.WriteLine($"Subtraction of {x} and {y} is {x-y}");
                        break;
                    case 3:
                        Console.WriteLine($"Multiplication of {x} and {y} is {x*y}");
                        break;
                    case 4:
                        if(y==0)
                            Console.WriteLine("Cannot divide a number by zero");
                        else
                            Console.WriteLine($"Division of {x} and {y} is {x/y}");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
