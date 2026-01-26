
class Program
{
    int i;
    bool b;

    public Program()
    {
        i = 2;
        b = true;
    }
    static void Main (string[] args)
    {
        Program p = new Program();
        Console.WriteLine(p.i);
        Console.WriteLine(p.b);
    }
}   