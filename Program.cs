namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicExceptionHandling();
            MultipleExceptionTypes();
            FinalyBlockUsage();
            CustomExceptionClass();
            ExceptionPropagation();
            UsingThrowAndCatch();
        }

        static void BasicExceptionHandling()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Convert the input to an integer using int.Parse().
            // Use a try-catch block to handle FormatException if the user enters a non-numeric value.
            // Display an error message in case of an exception.
            // Output the input if correct
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered " + input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a numeric value");
            }


        }

        static void MultipleExceptionTypes()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Include a catch block for OverflowException to handle cases where the number is too large or small for an int.
            // Display appropriate error messages for different exceptions.
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered " + input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large or too small for an integer.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void FinalyBlockUsage()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Add a finally block to the program.
            // Use the finally block to display a message whether an exception was caught or not.
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered " + input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large or too small for an integer.");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }

        }

        // Class for custom exception type
        class NegativeNumberException : ApplicationException
        {
            public NegativeNumberException(string message) : base(message) { }
        }

        static void CustomExceptionClass()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Modify your number input program to throw NegativeNumberException if the user enters a negative number.
            // Handle this exception in a separate catch block and display an appropriate message.
            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered " + input);
                if (input < 0)
                {
                    throw new NegativeNumberException("Negative numbers are not allowed.");
                }

            }
            catch (NegativeNumberException)
            {
                Console.WriteLine("You are not supposed to write negative number.");
            }

        }

            static void ExceptionPropagation()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumber that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // In this function, call CheckNumber inside a try block and handle the exception.
            try
            {
                CheckNumber(int.Parse(Console.ReadLine()));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You are not supposed to write number less than 100.");
            }

        }

        private static void CheckNumber(int v)
        {
            throw new NotImplementedException();
        }

        // NOTE: You can implement the CheckNumber here

        static void UsingThrowAndCatch()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumberWithLogging that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // Modify the CheckNumberWithLogging function to log the exception message before throwing it.
            // In this function, catch the exception in the main program and display the logged message.
            try
            {
                
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception logged: " + ex.Message);
            }

        }

        private static void CheckNumberWithLogging1(int v)
        {
            throw new NotImplementedException();
        }
          // NOTE: You can implement the CheckNumberWithLogging here
        static void CheckNumberWithLogging(int number)
        {
            if (number > 100)
            {
                Console.WriteLine("Logging: Number is greater than 100.");
                throw new ArgumentOutOfRangeException("Number should not be greater than 100.");
            }
            else
            {
                Console.WriteLine("You entered " + number);
            }
        }
    }
}
        
