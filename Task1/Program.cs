class Program
{
    static void Main()
    {
        Book myBook = new Book("Агар ҷавонӣ медонист…", "Башир Усмон", 2019);
        Console.WriteLine(myBook.GetInfo());
        Console.WriteLine("" + myBook.IsPublishedRecently());
    }
}