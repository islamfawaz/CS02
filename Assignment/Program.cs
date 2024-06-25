namespace Assignment
{
    class point
    {
        public int x;
        public int y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Write a program that allows the user to enter a number then print it.
            #region question1
             int number = int.Parse(Console.ReadLine());
            
            Console.WriteLine(number);
            #endregion
        }
    }
}
