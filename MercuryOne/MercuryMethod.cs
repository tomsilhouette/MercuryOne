namespace MercuryOne
{
    public class MercuryMethod
    {
        static void Main(string[] args)
        {
            // Your application logic here
        }
        public MercuryMethod() { }

        public int AddNumbers(int a, int b)
        {
            var c = a + b;
            Console.WriteLine(c);
            return c; // Return the result
        }
    }
}