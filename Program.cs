using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MenuList
{
    internal class Program
    {
        static void SortList(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("the list is empty");
            }
            else
            {
                Console.WriteLine("Original list:");
                foreach (int number in list)

                {
                    Console.WriteLine(number);
                }

                
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = 0; j < list.Count - i - 1; j++)
                    {
                        if (list[j] > list[j + 1]) 
                        {
                            int temp = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Sorted list:");
                foreach (int number in list)
                {
                    Console.WriteLine(number);
                }

            }
        }
        static void FindNumber(List<int> list)
        {
            Console.WriteLine("Enter a number to search in the list");
            int findNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i] == findNumber)
                {
                    Console.WriteLine($"number {findNumber} found at index{i}. ");

                }
                else
                {
                    Console.WriteLine($"number{findNumber} in not in the list");
                }
            }
        }
        static void Emptylist(List<int> list)
        {
            list.Clear();
            Console.WriteLine("now the list is empty!!");
        }
        static void Largest(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Unable to determine the largest number - the list is empty!!");

            }
            else
            {
                int largest = list[0];
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] > largest)
                        largest = list[i];
                }
                Console.WriteLine($"the largest number in list is{largest}");
            }
        }
        static void Smallest(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Unable to determine the smallest number - the list is empty!!");

            }
            else
            {
                int smallest = list[0];
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < smallest)
                        smallest = list[i];
                }
                Console.WriteLine($"the smallest number in list is{smallest}");
            }
        }
        static void AddNumbers(List<int> list)
        {
            Console.WriteLine("enter a new number:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                bool exist = false;
                foreach (int n in list)
                {
                    if (n == number)
                    {
                        exist = true;
                        break;
                    }
                }
                if (exist)
                {
                    Console.WriteLine($"number {number} is already in the list, please enter another number");
                }
                else
                {
                    list.Add(number);
                    Console.WriteLine($"{number} is added");
                }
            }
        }
        static void PrintMumbers(List<int> list)
        {
            if (list.Count < 0)
            {
                Console.WriteLine("[] - the list is empty!!");


            }
            else
            {
                string formattedlist = "[" + string.Join(" ", list) + "]";
                Console.WriteLine(formattedlist);
            }
        }
        static void AvgNumbers(List<int> list)
        {
            if (list.Count > 0)
            {
                int sum = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }
                ;
                Console.WriteLine($"the average of the list = {sum / list.Count}");

            }
            else
            {
                Console.WriteLine("[] - the list is empty!!");
            }
        }
        static void Main(string[] args)
        {

            List<int> myList = new List<int>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("P- Print numbers");
                Console.WriteLine("A- Add a number");
                Console.WriteLine("M- Display mean of the numbers");
                Console.WriteLine("S- Display the smallest number");
                Console.WriteLine("L- Display the largest number");
                Console.WriteLine("C- Clear the list");
                Console.WriteLine("B- Sort the numbers");
                Console.WriteLine("F- Search the list");
                Console.WriteLine("Q- Quit");



                Console.WriteLine("Enter your option:");
                char option = char.Parse(Console.ReadLine());





                switch (option)
                {
                    case 'P':
                    case 'p':

                        PrintMumbers(myList);

                        break;

                    case 'A':
                    case 'a':

                        AddNumbers(myList);

                        break;

                    case 'M':
                    case 'm':

                        AvgNumbers(myList);

                        break;

                    case 'S':
                    case 's':

                        Smallest(myList);

                        break;

                    case 'L':
                    case 'l':

                        Largest(myList);

                        break;

                    case 'C':
                    case 'c':

                        Emptylist(myList);

                        break;

                    case 'B':
                    case 'b':

                        SortList(myList);

                        break;

                    case 'F':
                    case 'f':


                        FindNumber(myList);

                        break;

                    case 'Q':
                    case 'q':

                        Console.WriteLine("Goodbye...");
                        exit = true;



                        break;

                    default:
                        Console.WriteLine("invalid choice, please choose valid option.");
                        break;

                }


            }
        }

    }
}
