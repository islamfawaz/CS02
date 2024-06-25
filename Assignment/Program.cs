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
            //2 Write C# program that Convert a string to an integer,
            //but the string contains non-numeric characters.And mention what will happen 
            #region question2
            //String input = "2as2dsd43";
            //int.TryParse(input, out int result);
            //if (result==0)
            //{
            //    Console.WriteLine("cant be convert");
            //}
            //else
            //{
            //    Console.WriteLine(result);
            //}
            #endregion

            // 3 Write C# program that Perform a simple arithmetic operation with floating-point numbers
            // And mention what will happen
            #region question3
            //float num1=0.3f;
            //float num2=0.7f;
            //float result = num1 + num2;
            //Console.WriteLine(result);
            #endregion


            //4 Write C# program that Extract a substring from a given string.
            #region question4
            //String inputString = "islam fawaz";
            //int length = 6;
            //int startIndex = 5;
            //string subString = inputString.Substring(startIndex, length);
            //Console.WriteLine(subString);                                                                  
            #endregion



        }
    }
}
