using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace All_project
{
    internal class projects
    {
        static void Main(string[] args)
        {
           
            char choice = 'y';
            string exit = "";
            try
            {
                do
                {

                    choice = ' ';
                    int ch = 0;
                    Console.WriteLine("\n\t\tMANU\t\t\n");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("select 0 for exit\n" +
                    "select 1. for cross_pattern\n" +
                    "select 2 . for diamond pattern\n" +
                    "select 3. for fectorial\n " +
                    "select 4. for left_triangle\n" +
                    "select 5. for pyramid_pattern\n" +
                    "select 6. for pyramid2_pattern\n" +
                    "select 7. for right2_triangle\n" +
                    "select 8. for right_triangle\n" +
                    "select 9. for hellow_right_triangle\n" +
                    "select 10. for hellow_pyramid\n" +
                    "select 11. for square_pattern\n" +
                    "select 12. for userinput\n" +
                    "select 13. for palindrome\n" +
                    "select 14. for calculator\n" +
                    "select 15. for Hellow_pyramid2\n" +
                    "select 16. for evenodd\n" +
                    "select 17. for Hellow_diamond\n");
                    // "select 18. exit\n");

                    try
                    {
                        Console.WriteLine("enter your choice ");
                        ch = Convert.ToInt32(Console.ReadLine());


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter valid input");

                    }

                    switch (ch)
                    {
                        case 1:
                            Cross_pattern();
                            break;
                        case 2:
                            Diamond_pattern();
                            break;
                        case 3:
                            Factorial();
                            break;
                        case 4:
                            Left_triangle();
                            break;
                        case 5:
                            Pyramid_pattern();
                            break;
                        case 6:
                            Pyramid2_pattern();
                            break;
                        case 7:
                            Right2_triangle();
                            break;
                        case 8:
                            Right_triangle();
                            break;
                        case 9:
                            Hellow_right_triangle();
                            break;
                        case 10:
                            Hellow_pyramid();
                            break;
                        case 11:
                            Square_pattern();
                            break;
                        case 12:
                            Userinput();
                            break;
                        case 13:
                            Palindrome();
                            break;
                        case 14:
                            Calculator();
                            break;
                        case 15:
                            Hellow_pyramid2();
                            break;
                        case 16:
                            Evenodd();
                            break;
                        case 17:
                            Hellow_diamond();
                            break; 
                        default:
                            //Console.WriteLine("plz enter valid choice");
                            break;
                    }
                    Console.WriteLine("do you want to continue then press y otherwise n");
                    choice = Convert.ToChar(Console.ReadLine());
                    if (choice != 'y' || choice != 'n')
                    {
                        Console.WriteLine("please enter valid choice");
                    }
                    Console.Clear();

                } while (!choice.Equals('n'));
            }
            catch (Exception e)
            {
                Console.WriteLine("please enter right choice");

            }
            Console.WriteLine("Exit");
            Console.ReadLine();
        }

        private static void Hellow_diamond()
        {
            int row, col, size, count = 1;
            Console.WriteLine("enter the rows");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            row = 1;
            while (row <= size)
            {
                for (col = 1; col <= size - row; col++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <= 2 * row - 1; col++)
                {

                    if (col == 1 || col == (2 * row - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                row++;
                Console.WriteLine(" ");
            }

            row = size - 1;

            while (row >= 1)
            {
                for (col = 1; col <= size - row; col++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <= 2 * row - 1; col++)
                {

                    if (col == 1 || col == (2 * row - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                row--;
                Console.WriteLine(" ");
            }
        }

        private static void Evenodd()
        {
            int n;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("it is a even number");
            }
            else
            {
                Console.WriteLine("it is a odd number");
            }
        }
        private static void Hellow_pyramid2()
        {
            int size, col, row;
            Console.WriteLine("enter the number of rows:");
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            row = size - 1;
            while (row >= 1)
            {
                col = 1;
                while (col <= size - row)
                {
                    Console.Write(" ");
                    col++;
                }
                col = 1;
                while (col <= (2 * row - 1))
                {
                    if (row < size)
                    {
                        if (col == 1 || col == (2 * row - 1))

                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    col++;
                }
                row--;
                Console.WriteLine(" ");
            }
            // Console.ReadLine();
        }
        private static void Calculator()
        {
            int a, b;
            int res = -1;
            try
            {
                Console.WriteLine("enter the first no");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the second no");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1. add 2. subtract 3. multiplication 4. division");
                Console.WriteLine("enter yur choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        res = a + b; break;
                    case 2:
                        res = a - b; break;
                    case 3:
                        res = a * b; break;
                    case 4:
                        res = a / b; break;
                    default:
                        Console.WriteLine("wrong choice... enter choice from 1 to 4:");
                        break;
                }
                Console.WriteLine("the ans is: " + res);
                Console.Read();
            }
            catch(Exception e) 
            {
                Console.WriteLine("please enter valid input");
            }
        }
        private static void Palindrome()
        {
            int r, sum = 0, temp;
            try
            {
                Console.WriteLine("enter the number:");
                int n = Convert.ToInt32(Console.ReadLine());
                temp = n;
                while (n > 0)
                {
                    r = n % 10;
                    sum = (sum * 10) + r;
                    n = n / 10;
                }
                if (temp == sum)
                {

                    Console.WriteLine("number is palindrome");
                }
                else
                {
                    Console.WriteLine("number is not palindrome");
                }
            }catch(Exception e)
            {
                Console.WriteLine("please enter valid input");
            }
        }
        private static void Userinput()
        {
            try
            {
                //console.ResdLine() is read a string
                Console.WriteLine("enter string:");
                String str = Console.ReadLine();
                Console.WriteLine("you entered : \"" + str + "\"in the console");
                //for int
                Console.WriteLine("enter number:");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("you entered:\"" + row + "\" in the console");
            }
            catch(Exception e)
            {             
                Console.WriteLine("please enter valid input");
            }
        }
        private static void Square_pattern()
        {
            try
            {
                int size, row = 0;
                Console.WriteLine("enter the number of rows:");
                size = Convert.ToInt32(Console.ReadLine());

                while (row < size)
                {
                    int col = 0;
                    while (col < size)
                    {
                        Console.Write("*" + " ");
                        col++;
                    }
                    Console.WriteLine();
                    row++;
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine("please enter valid input");
            }
        }
        private static void Hellow_pyramid()
        {
            int row, i = 1, j;
            try
            {
                Console.WriteLine("enter the number of rows:");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                while (i <= row)
                {
                    j = 1;
                    while (j <= row - i)
                    {
                        Console.Write(" ");
                        j++;
                    }
                    j = 1;
                    while (j <= (2 * i - 1))
                    {
                        if (i < row)
                        {
                            if (j == 1 || j == (2 * i - 1))

                                Console.Write("*");
                            else
                                Console.Write(" ");

                        }
                        else
                        {
                            Console.Write("*");
                        }
                        j++;
                    }
                    Console.WriteLine(" ");
                    i++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("please enter valid input");
            }
            //   Console.ReadLine();
        }
        private static void Hellow_right_triangle()
        {
            try 
            {
                Console.WriteLine("enter number of rows");
                 int rows = Convert.ToInt32(Console.ReadLine());
                 int i = 1;

                 while (i <= rows)
                 {
                    int j = 1;
                    while (j <= i)
                    {
                        if (j == 1 || i == j || i == rows)

                            Console.Write("*");
                        else
                            Console.Write(" ");
                         j++;

                     }
                     Console.WriteLine();
                      i++;
                 }
            }
            catch(Exception e)
            {
                Console.WriteLine("please enter valid input");
            }
    // Console.ReadLine();
}
        private static void Right_triangle()
        {
            int i = 1, j, row;
            try 
            { 
                Console.WriteLine(" enter a number of rows");
                 row = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine();
                 while (i <= row)
                 {
                     j = 1;
                     while (j <= i)
                     {
                         Console.Write("*");
                         j++;
                     }
                     i++;
                    Console.WriteLine();
                 }
            }
            catch (Exception e)
            {
                Console.WriteLine("please enter valid input");
            }
            // Console.ReadLine();
        }
        private static void Right2_triangle()
        {
            int i = 1, j, row;
            Console.WriteLine(" enter a number of rows");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (i <= row)
            {
                j = 1;
                while (j <= row - i)
                {
                    Console.Write("*");
                    j++;
                }
                i++;
                Console.WriteLine(" ");
            }
            // Console.ReadLine();
        }
        private static void Pyramid2_pattern()
        {
            int row, col, size;
            Console.WriteLine("enter the rows");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            row = size - 1;

            while (row >= 1)
            {
                for (col = 1; col <= size - row; col++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <= 2 * row - 1; col++)
                {
                    Console.Write("*");
                }
                row--;
                Console.WriteLine(" ");
            }
        }
        private static void Factorial()
        {
            int fact = 1;
            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());

            int i = number;
            while (i >= 1)
            {
                fact = fact * i;
                i--;
            }
            Console.WriteLine("the factorial of given number is:{0} ", fact);
            
        }
        private static void Diamond_pattern()
        {
            int row, col, size;
            Console.WriteLine("enter the rows");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            row = 1;
            while (row <= size)
            {
                for (col = 1; col <= size - row; col++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <= 2 * row - 1; col++)
                {
                    Console.Write("*");
                }
                row++;
                Console.WriteLine(" ");
            }
            row = size - 1;

            while (row >= 1)
            {
                for (col = 1; col <= size - row; col++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <= 2 * row - 1; col++)
                {
                    Console.Write("*");
                }
                row--;
                Console.WriteLine(" ");
            }
        }
        private static void Cross_pattern()

        {
            int row, i = 1, j;
            Console.WriteLine("enter a number of rows");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (i <= row)
            {
                j = 1;
                while (j <= row)
                {

                    if (i == j || i + j == row + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
        private static void Left_triangle()
        {
            int i, j, k, row;
            Console.WriteLine("enter the rows");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            i = 1;
            while (i <= row)
            {
                for (j = 1; j <= row - i; j++)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                    Console.Write("*");

                i++;
                Console.WriteLine(" ");

            }
        }
        private static void Pyramid_pattern()
        {
            int row, col, size;
            Console.WriteLine("enter the rows");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            row = 1;

            while (row <= size)
            {
                for (col = 1; col <= size - row; col++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <= 2 * row - 1; col++)
                {
                    Console.Write("*");
                }
                row++;
                Console.WriteLine(" ");
            }
        }
    }
}



