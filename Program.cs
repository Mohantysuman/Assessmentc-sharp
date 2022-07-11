//Question 1
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SM_Assessment_01
//{
//     class Program
//    {
//        static void Main(string[] args)
//        {
//            //C program to count total number of even and odd elements in an array

//            int size, even, odd;
//            int[] arr;

//            //Input size of the array
//            Console.Write("Enter size of the array: ");
//            size = Convert.ToInt32(Console.ReadLine());

//            //Input array elements
//            Console.WriteLine("Enter {0} elements in array:", size);

//            arr = new int[size];
//            for (int i = 0; i < size; i++)
//            {
//                Console.Write("Number({0}) :", i + 1);
//                arr[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            //Assuming that there are 0 even and odd elements 
//            even = 0;
//            odd = 0;
//            for (int i = 0; i < size; i++)
//            {
//                //If the current element of array is even then increment even count 
//                if (arr[i] % 2 == 0)
//                {
//                    even++;
//                }
//                else
//                {
//                    odd++;
//                }
//            }

//            Console.Write("Total even elements: {0}\n", even);
//            Console.Write("Total odd elements: {0}", odd);

//            Console.ReadLine();
//        }
//    }
//}



//Question 2
// The Unboxing
using System;
class Unboxing
{
    static public void Main()
    {
        int num = 22;

        // boxing
        object obj = num;

        // unboxing
        int i = (int)obj;

        // Display result
        Console.WriteLine("Value of ob object is : " + obj);
        Console.WriteLine("Value of i is : " + i);
    }
}


// The Boxing
//using System;
//class Boxing
//{

//    // Main Method
//    static public void Main()
//    {
//        int num = 7978;

//        // boxing
//        object obj = num;

//        // value of num to be change
//        num = 200;

//        System.Console.WriteLine
//        ("Value - type value of num is : {0}", num);
//        System.Console.WriteLine
//        ("Object - type value of obj is : {0}", obj);
//    }
//}





//Question 3
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//namespace SM_Assessment_01
//{
//    class MyApplication
//    {
//        static void Main(string[] args)
//        {
//            int num1, num2, num3;
//            // set the value of the three numbers
//            num1 = 325;
//            num2 = 750;
//            num3 = 478;
//            if (num1 > num2)
//            {
//                if (num1 > num3)
//                {
//                    Console.Write("Number one is the largest!\n");
//                }
//                else
//                {
//                    Console.Write("Number three is the largest!\n");
//                }
//            }
//            else if (num2 > num3)
//                Console.Write("Number two is the largest!\n");
//            else
//                Console.Write("Number three is the largest!\n");
//        }
//    }
//}






//Question 4
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleApplication1
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 0;

//            Console.WriteLine("Even Numbers :");
//            for (i = 1; i <= 10; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.Write(i + " ");
//                }
//            }

//            Console.WriteLine("\nOdd Numbers :");
//            for (i = 1; i <= 10; i++)
//            {
//                if (i % 2 != 0)
//                {
//                    Console.Write(i + " ");
//                }
//            }

//            Console.WriteLine();
//        }
//    }
//}




//Question 5
//using System;

//namespace MethodOverload
//{

//    class Program
//    {

//        // method with one parameter
//        void display(int a)
//        {
//            Console.WriteLine("Arguments: " + a);
//        }

//        // method with two parameters
//        void display(int a, int b)
//        {
//            Console.WriteLine("Arguments: " + a + " and " + b);
//        }
//        static void Main(string[] args)
//        {

//            Program p1 = new Program();
//            p1.display(500);
//            p1.display(500, 200);
//            Console.ReadLine();
//        }
//    }
//}






//Question 6
//using System;
//using System.Collections;

//class program
//{

//	// Main method
//	public static void Main()
//	{

//		// create and initialize new ArrayList
//		ArrayList mylist = new ArrayList();
//		mylist.Add("Chennai");
//		mylist.Add("Delhi");
//		mylist.Add("Kolkata");
//		mylist.Add("Mumbai");
//		Console.WriteLine("ArrayList before sort:");
//		foreach (string i in mylist)
//		{
//			Console.WriteLine(i);
//		}
//		Console.WriteLine();


//		Console.WriteLine("ArrayList after sort:");

//		// using Sort() method
//		mylist.Sort();

//		// ArrayList after sort
//		foreach (string i in mylist)
//		{
//			Console.WriteLine(i);
//		}
//	}
//}






//Question 7
using System;
class ADD
{

    int A, B;
    double f;
    string s;

    public ADD(int a, double b)
    {
        A = a;
        f = b;
    }

    public ADD(int a, string b)
    {
        B = a;
        s = b;
    }

    public void show()
    {
        Console.WriteLine("1st constructor (int + float): {0} ",
                                                    (A + f));
    }

    public void show1()
    {
        Console.WriteLine("2nd constructor (int + string): {0}",
                                                    (s + B));
    }
}

class program
{
    static void Main()
    {

        ADD g = new ADD(20, 70.2);
        g.show();
        ADD q = new ADD(10, "Roll No. is:");
        q.show1();
    }
}





//Question 8
//using System;
//public class Program
//{
//    public static void Main()
//    {
//        Console.Write("Enter a number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter another number: ");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
//        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
//        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
//        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
//        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
//    }
//}





//Question 10
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Student
//{

//	// Declare 3 variables - id, age and name
//	int id;
//	int age;
//	string name;

//	// Get the to string method that returns
//	// id , name and age
//	public override string ToString()
//	{
//		return id + " " + name + " " + age;
//	}

//	// Driver code
//	static void Main(string[] args)
//	{

//		// Declare a list variable
//		List<Student> student = new List<Student>()
//	{

//		// Create 5 Student details
//		new Student{ id = 101, name = "Akash", age = 24 },
//		new Student{ id = 102, name = "sahil", age = 23 },
//		new Student{ id = 103, name = "Deepu", age = 13 },
//		new Student{ id = 104, name = "Hemant", age = 26 },
//		new Student{ id = 105, name = "Juned", age = 22 }

//	};

//		// Iterate the Student by selecting Student
//		// name starts with S
//		// Using Where() function
//		IEnumerable<Student> Query = student.Where(s => s.name[0] == 'S');

//		// Display employee details
//		Console.WriteLine("ID Name Age");
//		Console.WriteLine("+++++++++++++");
//		foreach (Student e in Query)
//		{

//			// Call the to string method
//			Console.WriteLine(e.ToString());
//		}
//	}
//}

