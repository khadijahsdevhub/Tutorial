namespace Tutorial.OOP_Concept.Collections
{
    internal class Generics
    {
        public bool Compare(int a, int b)
        {
            if (a == b)
                return true;
            return false;
        }
        public bool GeneralCompare<T>(T a, T b)
        {
            if (a.Equals(b)) 
                return true;
            return false;
        }
        static void Main()
        {
            Generics obj = new Generics();
            bool result = obj.Compare(10, 20);
            Console.WriteLine(result);
            bool genobj = obj.GeneralCompare<float>(10.45f, 10.45f);  
            Console.WriteLine(genobj);
        }
    }
}
