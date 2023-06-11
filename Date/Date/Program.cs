public class Program
{
    public static void Main(string[] args)
    {
        Date date = new Date(2023, 6, 5);
        Console.WriteLine(date.ToString());

        date.Add(10);
        Console.WriteLine(date.ToString());

        date.Add(1, 5);
        Console.WriteLine(date.ToString());

        Date otherDate = new Date(1, 1, 1);
        date.Add(otherDate);
        Console.WriteLine(date.ToString());
    }
}
