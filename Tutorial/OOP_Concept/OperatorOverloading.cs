namespace Tutorial.OOP_Concept
{
    internal class OperatorOverloading
    {
        string str;

        public OperatorOverloading()
        {
            str = "Hello how are you";
        }


        static void Main(string[] args)
        {
            OperatorOverloading operatorOverloading = new OperatorOverloading();

            Console.WriteLine(operatorOverloading.str.Substring(10));

            operatorOverloading.str.Substring(14);

        }
    }

    public class Matrix
    {
        int a, b, c, d;
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override string ToString()
        {
            return a +" " + b +"\n" + c +" " + d +"\n";
        }

        public static Matrix operator +(Matrix obj1, Matrix obj2) {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d); 
            return obj;
        }
        public static Matrix operator -(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }

    }

    class TestMatrrix
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(20, 13, 10, 30);
            Matrix m2 = new Matrix(12, 7, 1, 13);
            Matrix m3 = m1 + m2;
            Matrix m4 = m1 - m2;

            Console.WriteLine("The first matrix");
            Console.WriteLine(m1);
            Console.WriteLine("The first matrix");
            Console.WriteLine(m2);  
            Console.WriteLine("The sum of the first and second matrices");
            Console.WriteLine(m3);
            Console.WriteLine("The difference of the first and second matrices");
            Console.WriteLine(m4);

        }
    }
}
