// exception = errors that occur during execution

//      try     = try some code that is considered "dangerous"
//      catch   = catches and handles exceptions when they occur
//      finally = always executes regardless if exception is caught or not

try
{
    double x;
    double y;
    double result;

    Console.Write("Enter number 1: ");
    x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter number 2: ");
    y = Convert.ToInt32(Console.ReadLine());

    result = x / y;

    Console.WriteLine("Result: " + result);
}
catch (FormatException e)
{
    Console.WriteLine("Enter ONLY numbers.");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("You can't divide by zero.");
}
catch (Exception e)
{
    Console.WriteLine("Something went wrong.");
}
finally
{
    Console.WriteLine("Thanks for visiting.");
}