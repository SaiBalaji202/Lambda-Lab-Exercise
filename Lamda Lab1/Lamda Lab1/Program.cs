using System;
using System.Collections.Generic;

namespace Lamda_Lab1
{
    delegate int MathDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter the Value of X and Y: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            MathDelegate objAdd = (a, b) => a + b;
            MathDelegate objSub = (a, b) => a - b;
            MathDelegate objMul = delegate (int a, int b)
            {
                return a * b;
            };

            //Calling Add
            Console.WriteLine("Result of Adding {0} and {1} is {2}", x, y, objAdd.Invoke(x, y));
            //Calling Sub
            Console.WriteLine("Result of Subracting {0} and {1} is {2}", x, y, objSub(x, y));
            //Calling Mul
            Console.WriteLine("Result of Multiplying {0} and {1} is {2}", x, y, objMul.Invoke(x, y));

            Console.Write("Enter the n value: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int tempVal;
            List<int> valuesList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                tempVal = Convert.ToInt32(Console.ReadLine());
                valuesList.Add(tempVal);
            }

            Coll coll = new Coll(valuesList);

            //Fetch All Even Numbers
            Console.WriteLine(string.Join(", ", coll.FetchEven()));

            //Greater then the Specified Value
            Console.Write("Enter the Value to fetch the value from the List that is greater then you entered: ");
            tempVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(string.Join(", ", coll.FetchGreaterThen(tempVal)));

            //Access Outer Variable
            Console.Write("Enter the Value you want to Search: ");
            tempVal = Convert.ToInt32(Console.ReadLine());
            if (coll.Find(tempVal) > 0)
            {
                Console.WriteLine("Value {0} is found in the index of {1} within the List {2}", tempVal, valuesList.IndexOf(tempVal), string.Join(", ", valuesList));
            }
            else
            {
                Console.WriteLine("Value {0} is not found in the List {1}", tempVal, string.Join(", ", valuesList));
            }


            //Access Outer Variable
            Console.Write("Enter the Value you want to Search(Find All): ");
            tempVal = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(string.Join(", ", coll.MatchWithValue(tempVal)));
            Console.WriteLine("There are totally {0} no of {1} in the List {2}", coll.MatchWithValue(tempVal).Count, tempVal, string.Join(", ", valuesList));

        }

    }
}
