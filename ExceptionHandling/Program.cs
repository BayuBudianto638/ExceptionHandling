using ExceptionHandling;
using System.Text;

namespace ErrorHandling
{
    class Program
    {
        static void Main()
        {
            // outer try
            try
            {
                // inner try
                try
                {
                    int a, b, c;
                    Console.Write("Nilai A : ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Nilai B : ");
                    b = int.Parse(Console.ReadLine());

                    if (b % 2 > 0)
                    {
                        throw new OddNumberException("Odd Number occured inside static main method");
                    }

                    c = a / b;
                    Console.WriteLine($"Result : {c}");
                }
                catch (OddNumberException one)
                {
                    Console.WriteLine($"Message : {one.Message}");
                    Console.WriteLine($"Helplink : {one.HelpLink}");
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Error\error.txt";
                    if (File.Exists(filePath))
                    {
                        StringBuilder sbr = new StringBuilder();
                        sbr.Append($"Message : {ex.Message}");
                        sbr.Append($"Source : {ex.Source}");

                        StreamWriter stw = new StreamWriter(filePath);
                        stw.Write(sbr.ToString());
                        stw.Close();
                        Console.WriteLine("An Error has occured! Please try again later");
                    }
                    else
                    {
                        string Message = filePath + " Does not exist!";
                        throw new FileNotFoundException(Message, ex);
                    } 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error details!");
                Console.WriteLine($"Inner exception Message : {ex.InnerException.Message}");
                Console.WriteLine($"Inner exception Source : {ex.InnerException.Source}");
            }
        }
    }
}