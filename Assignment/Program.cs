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
             //int number = int.Parse(Console.ReadLine());
            
            //Console.WriteLine(number);
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


            //5 Write C# program that Assigning one value type variable to another
            //and modifying the value of one variable and mention what will happen
            #region question5
            //int x=6;//clr will allocate 4 bytes at stack by 6
            //int y = 7; //clr will allocate 4 bytes at stack by 7
            //y = x;
            //x++;
            //Console.WriteLine(y);
            #endregion


            //6 Write C# program that Assigning one reference type variable to another
            //and modifying the object through one variable and mention what will happen

            #region question6
            //point p1; //declare reference type point refer to null 
            //          //this reference p1 refer object from type point
            //          //clr allocate 4 bytes in refer at stack
            //          //clr allocate 0 bytes in refer at heap

            //p1 = new point(); //allocate no of bytes in heap
            //                  //iniialize with defult value
            //                  //call constructor if exist
            //                  //assign reference to allocated object
            //point p2;
            //p2 = new point();
            //p2 = p1;
            //p2.x = 10;
            //Console.WriteLine(p1.x);    
            #endregion

            //7 Write C# program that take two string variables and print them as one variable 
            #region question7
            //String str1 = "islam ";
            //String str2 = "fawaz";
            //String str3 = $"{str1}{str2}";
            //Console.WriteLine($"combined string is {str3}");
            #endregion

            //8 Write a program that calculates the simple interest given the principal amount, rate of interest,
            //and time.The formula for simple interest is  Interest = (principal * rate * time) / 100.

            #region question8
            //double principal;
            //double rate;
            //double time;

            //Console.Write("Input the principal amount: ");
            //principal = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input the rate of interest ");
            //rate = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input the time period (in years): ");
            //time = Convert.ToDouble(Console.ReadLine());
            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine($"Interest is: {interest}");

            #endregion

            //9 Write a program that calculates the Body Mass Index (BMI) given
            //a person's weight in kilograms and height in meters The formula for BMI is
            //BMI = (Weight) / (Height * Height)

            #region question9
            //decimal weight;
            //decimal height;


            //Console.WriteLine("input weight in kilograms:");
            //weight = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("input height in meters:");
            //height = Convert.ToDecimal(Console.ReadLine());

            //decimal bmi = weight / (height * height);

            //Console.WriteLine($"BMI: {bmi}");

            #endregion



















        }
    }
}
