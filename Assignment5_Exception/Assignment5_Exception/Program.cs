// See https://aka.ms/new-console-template for more information
using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static int Division(int top, int bottom) => top / bottom;

        static void DivisionNoHandling()
        {
            int result = Division(1, 0);
            Console.WriteLine("Result: " + result);
        }

        static void DivisionWithExceptionHandling()
        {
            try
            {
                int result = Division(1, 0);
                Console.WriteLine("Result: " + result);
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        static void DivisionWithExceptionHandlingMoreInfo()
        {
            try
            {
                int result = Division(1, 0);
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        static void DivisionWithExceptionHandlingThrow()
        {
            try
            {
                int result = Division(1, 0);
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                throw new Exception("New Exception");
            }
        }

        static void GeneratingException()
        {
            throw new Exception("Generated Exception");
        }

        static void HandlingRandomException()
        {
            try
            {
                GeneratingRandomException();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("InvalidOperationException: " + ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("ArithmeticException: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException: " + ex.Message);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("InvalidCastException: " + ex.Message);
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine("OutOfMemoryException: " + ex.Message);
            }
        }

        static void GeneratingRandomException()
        {
            int exceptionType = new Random().Next() % 7;
            switch (exceptionType)
            {
                case 0:
                    throw new IndexOutOfRangeException("Index out of range");
                case 1:
                    throw new NullReferenceException("Null reference");
                case 2:
                    throw new InvalidOperationException("Invalid operation");
                case 3:
                    throw new ArithmeticException("Arithmetic error");
                case 4:
                    throw new FormatException("Invalid format");
                case 5:
                    throw new InvalidCastException("Invalid cast");
                case 6:
                    throw new OutOfMemoryException("Out of memory");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("DivisionNoHandling:");
            try
            {
                DivisionNoHandling();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.WriteLine();

            Console.WriteLine("DivisionWithExceptionHandling:");
            try
            {
                DivisionWithExceptionHandling();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.WriteLine();

            Console.WriteLine("DivisionWithExceptionHandlingMoreInfo:");
            try
            {
                DivisionWithExceptionHandlingMoreInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.WriteLine();
        }
    }
}




