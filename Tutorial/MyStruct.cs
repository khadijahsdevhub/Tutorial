
namespace Tutorial
{
    struct MyStruct
    {
        public int x;

        public MyStruct(int x)
        {
            this.x = x;
        }
        public void Display()
        {
            Console.WriteLine($"Struct method: {x} ");
        }

        static void Main(string[] args)
        {
            //sample 1
            MyStruct s1;
            s1.x = 10;
            s1.Display();

            //sample 2
            MyStruct s2 = new MyStruct();
            s2.Display();

            //sample 3
            MyStruct s3 = new MyStruct(30);
            s3.Display();


        }
    }



    // Think of this as a "Paper Drawing"
    public struct Drawing
    {
        public string Color;


        static void Main(string[] args)
        {
            // 1. You make your drawing
            Drawing myDrawing = new Drawing();
            myDrawing.Color = "Red";

            // 2. You give a copy to your friend
            Drawing friendDrawing = myDrawing;

            // 3. Your friend colors theirs Blue
            friendDrawing.Color = "Blue";

            // Result: Your drawing is still Red! 
            // They only changed their own piece of paper.
        }
    }

    // Think of this as a "Shared Toy Car"
    public class ToyCar
    {
        public string Color;

        public static void Main(string[] args)
        {
            // 1. You buy a car
            ToyCar myCar = new ToyCar();
            myCar.Color = "Red";

            // 2. You let your friend play with it
            ToyCar friendCar = myCar;

            // 3. Your friend paints it Blue
            friendCar.Color = "Blue";

            // Result: Your car is now Blue! 
            // Since you both share the same car, you both see the change.

        }
    }



}
