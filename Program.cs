public class Program
{
    public static void Main(String[] args)
    {
        RomanConverter converter = new RomanConverter();

        Boolean exit;
        do
        {
            Console.Clear();
            Console.WriteLine("Please, enter any integer in range 1..3999\n");
            Console.Write("Integer: ");
            String? line = Console.ReadLine();

            try
            {
                int origin = int.Parse(line);
                if ((origin < 1) || (origin > 3999))
                {
                    Console.WriteLine("\nERROR: Input value must be within range 1..3999!");
                }
                else
                {
                    String roman = converter.IntToRoman(origin);
                    Console.WriteLine("Roman:   " + roman);
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("\nERROR: Input value must be a numeric!");
            }
            Console.WriteLine("\nPress 'ESC' to exit and any other key to try again...");
            ConsoleKey key = Console.ReadKey(false).Key;
            exit = (key == ConsoleKey.Escape);
        } while (!exit);
    }
}
