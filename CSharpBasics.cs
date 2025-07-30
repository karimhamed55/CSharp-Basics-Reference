using System;
using System.Linq;

namespace myfirstapp
{
    internal class Program
    {
        // enums
        enum weekdays : short
        {
            saturday = 1,
            sunday,     // 2
            monday,     // 3
            tuesday,    // 4
            wednesday,  // 5
            thursday,   // 6
            friday      // 7
        }

        // structs
        struct student
        {
            public string firstname;
            public string lastname;
        }

        // method making
        static void saymyname() // static to call the method without having object.
        {
            Console.WriteLine("hello c# ");
        }

        // parameterized method with default values
        static void saymyinfo(string s = "mounayri", int i = 59)
        {
            Console.WriteLine("your name is {0} and your age is {1}", s, i);
        }

        // returns type
        static int sums(int a, int b)
        {
            return a + b;
        }

        // method overloading
        static int sums(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("hello kimo");

            Console.WriteLine("the result of 10 + 20 is " + (10 + 20));

            Console.Write("hello kimo");
            Console.Write(" son of {0}", "hamed"); // fixed formatting issue
            Console.Write("hello this is \"karim hamed\" from c#\n"); // escape chars

            int x = 90, y = 8;
            Console.WriteLine(x + y); // calculate

            var age = 5;
            var playerName = "messi";
            var height = 78.8f;
            Console.WriteLine("a={0}, b={1}, c={2}", age, playerName, height); // var usage

            // to know min and max values of any datatype
            Console.WriteLine("min = {0}, max = {1}", Int32.MinValue, Int32.MaxValue);

            int defaultValue = default; // default of most types = 0 and false in bool
            Console.WriteLine(defaultValue);

            weekdays exampleDay = weekdays.wednesday; // enum name
            Console.WriteLine(exampleDay);
            Console.WriteLine((int)exampleDay); // enum number

            Nullable<int> nullableInt = null;  // null
            Console.WriteLine(nullableInt);

            var anonymous = new { o = 7, vx = "student" }; // anonymous property
            // o = 9; is wrong because it's read-only
            Console.WriteLine(anonymous);

            student student1; // struct
            student1.firstname = "mahmoud";
            student1.lastname = "wagdy";
            Console.WriteLine("the student name is {0} {1}", student1.firstname, student1.lastname);

            // Use dynamic only when you ex (working with JSON, COM objects, reflection, or duck typing).
            // Avoid dynamic in most code unless you really need runtime flexibility.

            dynamic MyDynamicVar = 100; // dynamic assigns the datatype at runtime
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            Console.WriteLine("*******DATE AND TIME*******");

            // (year , month , day , hour , min , sec )
            DateTime datey = new DateTime(2025, 07, 28, 18, 15, 30);
            Console.WriteLine(datey);

            // date and time functions
            DateTime ahora = DateTime.Now;
            Console.WriteLine(ahora); // date and time of now
            Console.WriteLine("currentDateTimeUTC: " + DateTime.UtcNow); // same as ahora but with utc
            Console.WriteLine("minDateTimeValue: " + DateTime.MinValue); // min date time
            Console.WriteLine("maxDateTimeValue: " + DateTime.MaxValue); // max date time

            // using timespan to get time difference between two dates or add/subtract timespan for dates
            DateTime day1 = DateTime.Now;
            DateTime day2 = day1.AddYears(1).AddHours(3);
            TimeSpan ts = day2 - day1;
            Console.WriteLine(ts); // day hour minute second

            // link for timespan additionals
            // https://chatgpt.com/share/68879d6a-8758-8006-a06b-63408a6cc800

            // we can get timespan like this too
            DateTime dt1 = new DateTime(2025, 6, 21);
            DateTime dt2 = new DateTime(2023, 2, 25);
            Console.WriteLine(dt1 - dt2); // returns TimeSpan
            TimeSpan result = dt1.Subtract(dt2);
            Console.WriteLine(result.Days); // days only

            // you can use operators with datetime
            Console.WriteLine(dt1 == dt2);

            // using try parse to convert strings to datetime
            var str2 = "6/65/2023"; // invalid
            DateTime dt3;
            var isValidDate2 = DateTime.TryParse(str2, out dt3);
            if (isValidDate2)
                Console.WriteLine(dt3);
            else
                Console.WriteLine("{0} is not a valid date string", str2);

            // Ticks is a date and time expressed in the number of 100-nanosecond intervals 
            // that have elapsed since January 1, 0001, at 00:00:00.000 in the Gregorian calendar.
            // A single tick represents one hundred nanoseconds or one ten-millionth of a second
            Console.WriteLine(DateTime.MinValue.Ticks);  // min value of ticks
            Console.WriteLine(DateTime.MaxValue.Ticks);  // max value of ticks

            Console.WriteLine("************");
            Console.WriteLine(" strings  ");
            string fullName = "Mohammed Abu-katkot";
            Console.WriteLine(fullName.Length);
            Console.WriteLine(fullName.Substring(2, 5));  // takes 5 characters starting at position 2
            Console.WriteLine(fullName.ToLower());
            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(fullName[2]);
            Console.WriteLine(fullName.Insert(3, "KKKK"));
            Console.WriteLine(fullName.Replace("m", "*"));
            Console.WriteLine(fullName.IndexOf("m"));
            Console.WriteLine(fullName.Contains("m"));
            Console.WriteLine(fullName.Contains("x"));
            Console.WriteLine(fullName.LastIndexOf("m"));

            // INTERPOLATION OF STRINGS
            string code = "999";
            string fname = "mazen";
            string lname = "gasser";
            Console.WriteLine($"{code}-{fname} {lname}");

            Console.WriteLine("&&&&&&&&&&&");

            // type casting
            // (1) implicit: from smaller to larger data type , automatic 
            // (2) explicit: from larger to smaller , manual
            int intVal = 4;
            float floatVal = intVal; // implicit
            short shortVal = (short)intVal; // explicit

            // methods for casting
            Console.WriteLine(Convert.ToString(intVal));
            var enumConverted = (weekdays)intVal;  //enum conversion
            Console.WriteLine(enumConverted);

            // input from user
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            Console.Write("Enter your age: ");
            int ager = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + ager);

            // ternary operator
            string resultg = (8 % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(resultg);

            //unary operator
            int number = 9;
            int negative = -number;
            bool flag = true;
            Console.WriteLine("-number = " + negative);
            Console.WriteLine("!flag = " + (!flag));

            // selection statements
            if (number < 5)
                Console.WriteLine("{0} is less than 5", number);
            else if (number > 5)
                Console.WriteLine("{0} is greater than 5", number);
            else
                Console.WriteLine("{0} is equal to 5", number);

            // switch with string
            string sname = "omar";
            switch (sname)
            {
                case "mohammed":
                    Console.WriteLine("Yes Mohammed");
                    break;
                case "ali":
                    Console.WriteLine("Yes Ali");
                    break;
                default:
                    Console.WriteLine("No Name Matched!");
                    break;
            }

            // loops
            for (int i2 = 1; i2 <= 5; i2++)
            {
                if (i2 == 2)
                    continue;
                Console.WriteLine(i2);
            }

            int i3 = 0;
            while (i3 <= 3)
            {
                i3++;
                Console.WriteLine("C# while Loop: Iteration {0}", i3);
                if (i3 == 2)
                    break;
            }

            Console.WriteLine("the do while loop ");
            do
            {
                Console.WriteLine("C# do-while Loop: Iteration {0}", i3);
                i3++;
            } while (i3 <= 2);

            // arrays
            int[] arr = new int[5]; // declaration
            int[] arr2 = { 1, 2, 3, 4 };
            Console.WriteLine(arr2[3]); // 4

            // 2d arrays
            int[,] arr2d = new int[,] { { 1, 2, 3 }, { 5, 6, 7 } };
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                    Console.Write(arr2d[row, col] + "\t");
                Console.WriteLine();
            }

            // foreach
            char[] myArray = { 'H', 'i', 'l', 'l', 'o' };
            foreach (char ch in myArray)
            {
                if (ch == 'l')
                    break;
                Console.WriteLine(ch);
            }

            // LINQ functions
            Console.WriteLine(arr2.Max());
            Console.WriteLine(arr2.Sum());

            // math library
            Console.WriteLine("Square Root of 64 is: {0}", Math.Sqrt(64));

            // random number generator
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(10, 20)); // returns random integers >= 10 and < 20

            // exception handling
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // e.message = description message
            }

            // using self-made methods
            saymyname();
            saymyinfo("elgayar", 40);
            saymyinfo();
            int resulty = sums(55, 56);
            Console.WriteLine(resulty);
            saymyinfo(i: 78, s: "the rock");
            int resultyy = sums(55, 56, 111);
            Console.WriteLine(resultyy);
        }
    }
}
