namespace Tutorial
{
    internal class ParamConDemo
    {
        int x;
        bool y;
        public ParamConDemo(int a, bool c)
        {
            x = a;
            y = c;
            Console.WriteLine("Parameterized Constructor Called: " + a + " ," + c);
        }

        public void Display()
        {
            Console.WriteLine("x: " + x + ", y: " + y);
        }
        static void Main(string[] args)
        {
            ParamConDemo demo2 = new ParamConDemo(10, false);
            ParamConDemo demo1 = new ParamConDemo(35, true);
            demo1.Display();
            demo2.Display();
            
        }
    }
}
