
class Progra
{
    static void Main()
    {
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
        Date Mydate = new Date(a,b,c);
Mydate.SetDate(a, b, c);
System.Console.WriteLine(" " + Mydate.GetDay());
System.Console.WriteLine("" + Mydate.GetMonth());
System.Console.WriteLine("" + Mydate.GetYear());
System.Console.WriteLine(" " + Mydate.ToString());
    }
}











