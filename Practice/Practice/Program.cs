using Practice;
class Program
{
    public static void Main(string[] args)
    { 
        room master = CreateRectangle(5,5);
        Console.WriteLine($"{master.width}+{master.length}");
    }
    static room CreateRectangle(int length,int width)
    {
        room bedRoom = new room();

        bedRoom.width = width;
        bedRoom.length = length;

        return bedRoom;
    }

    static void room calculatearea()
    {

    }
}
