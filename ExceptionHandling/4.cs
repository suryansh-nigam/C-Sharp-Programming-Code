using System;

class Program
{
    static void Main()
    {
        string name = null;

        try
        {
            Console.WriteLine(name.Length);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("NullReferenceException handled: " + ex.Message);
        }
    }
}
