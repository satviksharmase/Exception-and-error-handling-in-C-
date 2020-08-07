using System;
using System.Collections.Generic;
using System.Text;

namespace exceptiontask
{
    enum exceptionoption
    {
        NullReferenceException,
        IndexOutOfRangeException,
        StackOverflowException,
        OutOfMemoryException,
        InvalidCastException,
        DivideByZeroException,
        ArgumentException,
        ArgumentOutOfRangeException,
        SystemException,
        quit
    }
    class Program
    {
        static exceptionoption ReadUserInput()
        {
            int result;
            do
            {
                Console.WriteLine("choose the type of exception to run");
                Console.WriteLine("1:null reference exception");
                Console.WriteLine("2:index out of range exception");
                Console.WriteLine("3:stack overflow exception");
                Console.WriteLine("4:out of memory exception");
                Console.WriteLine("5:invalid cast exception");
                Console.WriteLine("6:divide by zero exception");
                Console.WriteLine("7:argument exception");
                Console.WriteLine("8:argument out of range exception");
                Console.WriteLine("9:system exception");
                Console.WriteLine("10:quit the program");
                result = Convert.ToInt32(Console.ReadLine());
            }
            while (result > 10 || result < 1);
            return (exceptionoption)(result-1);
        }
        static void nullreference()
        {
            int[] values = null;
            Console.WriteLine("for this exception i have made 2 for loops  one loop give the values to the array and the second loop pronts the array" +
                "but in second array i hav not terminated the loop");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("after execution:");

            try
            {
                for (int i = 0; i <= 9; i++)
                {
                    values[i] = i * 2;

                }

                foreach (var value in values)
                {
                    Console.WriteLine(value);
                }

            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.GetType().ToString()+" was detected "+"\nwith message: "+exception.Message);
                Console.WriteLine();
            }
        }
        static void indexoutofrange()
        {
            Console.WriteLine("for this exception i have made an array of 5 object and printed the array for 6 times instead of 5 which means there was no 6 option" +
                "and the index for the array got out of range");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("after execution:");
            try
            {
                int[] values = { 1, 2, 3, 4, 5 };
                for (int i = 0; i <= values.Length; i++)
                {
                    Console.WriteLine(values[i]);
                }
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.GetType().ToString() + " was detected " + "\nwith message: " + exception.Message);
                Console.WriteLine();
            }
        }
       static void stackoverflow(int value)
        {
            Console.WriteLine("in this exception, we have a special case where it is impossible to stop it with a catch and will just keep on going");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("after execution:");
            Console.WriteLine(value);
            stackoverflow(++value);
            try
            {
                
                //stackoverflow(0);
            }
            catch(StackOverflowException exception)
            {
                Console.WriteLine(exception.GetType().ToString() + " was detected " + "\nwith message: " + exception.Message);
                Console.WriteLine();
            }
        }
        static void outofmemory()
        {
            Console.WriteLine("in this exception i have made a code using string builder such that the string 2 is inserted into string 1, but we have an exception over here");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("after execution:");
            StringBuilder values = new StringBuilder(15, 15);
            values.Append("humpty dumpty ");
            try
            {
                values.Insert(0, "sat on a wall", 1);
            }
            catch (OutOfMemoryException exception)
            {
                Console.WriteLine(exception.GetType().ToString() + " was detected " + "\nwith message: " + exception.Message);
                Console.WriteLine();
            }
        }
        static void invalidcast()
        {
            Console.WriteLine("in this task i have used a boolean value and tried to cast it as a character value, which is going to throw the exception");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("after execution:");
            bool value = true;
            try
            {
                IConvertible conv = value;
                Char ch = conv.ToChar(null);
                Console.WriteLine("Conversion succeeded.");
            }
            catch (InvalidCastException exception)
            {
                Console.WriteLine(exception.GetType().ToString() + " was detected " + "\nwith message: " + exception.Message);
                Console.WriteLine();
            }

        }
        static void dividebyzero()
        {
            Console.WriteLine("for this task i have declared 2 values, where one is not zero and the other one is zero. " +
                "since anything divided by zero is undefined, in programming it throws an exception");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("after execution:");
            int value1 = 123456789;
            int value2 = 0;
            try
            {
                Console.WriteLine(value1 / value2);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.GetType().ToString() + " was detected " + "\nwith message: " + exception.Message);
                Console.WriteLine();
            }
        }
        static void argument()
        {
            Console.WriteLine("in this exception, i have made a simple code, which will throw argument exception if the value is positive");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("after execution");
            int value =  7;
            try
            {
                if (value <= 0)
                {
                    Console.WriteLine("it is negative");
                }
                else
                {
                    throw new ArgumentException("the value was positive instead of negative");
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.GetType().ToString() + " was detected " + "\nwith message: " + exception.Message);
                Console.WriteLine();
            }
            Console.WriteLine();    
        }
        
        static void argumentoutofrange()
        {
            Console.WriteLine("this type of exception is subset of argument exception,and for this i have made a list with string and inserted an item in the list which gives out the exception");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("after execution:");
            var list = new List<String>();
            Console.WriteLine("Number of items: {0}", list.Count);
            try
            {
                Console.WriteLine("The first item: '{0}'", list[0]);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine(exception.GetType().ToString() + " was detected " + "\nwith message: " + exception.Message);
                Console.WriteLine();
            }

        }
        static void system()
        {
            Console.WriteLine("system exception is basically, superset of all other exceptions, so i have used an index out of range exceptions to justify this one");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("after execution:");
            try
            {
                int[] values = new int[5];
                values[10] = 25;
            }
            catch (SystemException exception)
            {
                Console.WriteLine(exception.GetType().ToString() + " was detected " + "\nwith message: " + exception.Message);
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++ExceptionTask++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("in this task i have made simple programs for each exception");
            Console.WriteLine("choose the type of exception and ther would be some explanation regarding the code");
            Console.WriteLine();
            exceptionoption user;
            do
            {
                user = ReadUserInput();
                switch (user)
                {
                    case exceptionoption.NullReferenceException:
                        nullreference();
                        break;

                    case exceptionoption.IndexOutOfRangeException:
                        indexoutofrange();
                        break;

                    case exceptionoption.StackOverflowException:
                        stackoverflow(0);
                        break;

                    case exceptionoption.OutOfMemoryException:
                        outofmemory();
                        break;

                    case exceptionoption.InvalidCastException:
                        invalidcast();
                        break;

                    case exceptionoption.DivideByZeroException:
                        dividebyzero();
                        break;
                    case exceptionoption.ArgumentException:
                        argument();
                        break;

                    case exceptionoption.ArgumentOutOfRangeException:
                        argumentoutofrange();
                        break;

                    case exceptionoption.SystemException:
                        system();
                        break;

                    case exceptionoption.quit:
                        Console.WriteLine("thanks for using this application");
                        break;

                    default :
                        Console.WriteLine("enter a valid option");
                        break;

                }
            }
            while (user != exceptionoption.quit);   
        }
    }
}
