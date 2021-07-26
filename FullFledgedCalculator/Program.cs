using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullFledgedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("\t\t\tFULL FLEDGED CALCULATOR");
            Console.WriteLine("***********************************************************************\n");
            Console.WriteLine("Select the Correct Option:\n");
            Console.WriteLine("1. Add \n2. Subtract\n3. Multiply\n4. Divide\n5. Percentage\n6. Power\n" +
                "7. Square Root\n8. Log\n9. Natural Log x\n10. Sin\n" +
                "11. Cos\n12. Tan\n13. Close the Calculator");

            while (true)
            {
            
                Console.WriteLine("Enter Your Choice:");
                int choice = Int32.Parse(Console.ReadLine());
                if (choice == 1 || choice == 2 || choice == 3 || choice == 4 )
                {
                    Console.WriteLine("Enter the First Number:");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Second Number:");
                    num2 = double.Parse(Console.ReadLine());
                    Calculator calculator = new Calculator(num1, num2);
                    switch (choice)
                    {
                        case 1:
                            calculator.Add();
                            break;
                        case 2:
                            calculator.Subtract();
                            break;
                        case 3:
                            calculator.Multiply();
                            break;
                        case 4:
                            calculator.Divide();
                            break;
                        
                    }
                    continue;
                }
                else if(choice == 5)
                {
                    Console.WriteLine("Enter the Number: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter maximum value:");
                    num2 = double.Parse(Console.ReadLine());
                    Calculator calculator = new Calculator(num1, num2);
                    calculator.Percentage();
                    continue;
                }
                else if(choice == 6)
                {
                    Console.WriteLine("Enter the Number: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter power to be calculated:");
                    num2 = double.Parse(Console.ReadLine());
                    Calculator calculator = new Calculator(num1, num2);
                    calculator.Power();
                    continue;
                }
                else if(choice == 7||choice == 8||choice == 9||choice == 10||choice == 11||choice == 12)
                {
                    Console.WriteLine("Enter the number:");
                    num1 = double.Parse(Console.ReadLine());
                    Calculator calculator = new Calculator(num1);
                    switch (choice)
                    {
                        case 7:
                            calculator.SquareRoot();
                            break;
                        case 8:
                            calculator.Log();
                            break;
                        case 9:
                            calculator.NaturalLog();
                            break;
                        case 10:
                            calculator.Sin();
                            break;
                        case 11:
                            calculator.Cos();
                            break;
                        case 12:
                            calculator.Tan();
                            break;
                        
                    }
                    continue;
                }
                else if(choice == 13)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please Enter a Correct Choice");
                    continue;
                }
                Console.Read();
            }
            
            
           
        }
    }
}
