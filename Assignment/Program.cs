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

            //Write a program that uses the ternary operator to check if the temperature is too hot,
            //too cold, or just good. Assign the result in variable then display the result.
            //Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot",
            //and anything else is "Just Good".
            #region question10

            //int temperature;

            //Console.WriteLine("Enter the temperature in degrees Celsius:");
            //temperature = Convert.ToInt32(Console.ReadLine());
            //string tempertaureCateg = (temperature > 30) ? "Just Hot" : (temperature < 10) ? "Just Cold" : "Just Good";
            //Console.WriteLine($"The temperature {temperature}°C is {tempertaureCateg}.");

            #endregion

            //11Write a program that takes the date from user and displays it in various formats using string interpolation.
            // Ex:
            //   Today’s date : 20 , 11 , 2001
            //  Today's date : 20 / 11 / 2001
            // Today's date : 20 – 11 – 2001



            #region question11
            //Console.WriteLine("Enter a date (format: DD MM YYYY):");
            //string input = Console.ReadLine();
            //string[] cuts = input.Split(' ');
            //int day = int.Parse(cuts[0]);
            //int month = int.Parse(cuts[1]);
            //int year = int.Parse(cuts[2]);

            //Console.WriteLine($"Today's date: {day} , {month} , {year}");
            //Console.WriteLine($"Today's date: {day} / {month} / {year}");
            //Console.WriteLine($"Today's date: {day} - {month} - {year}");

            #endregion

            //12  What is the output of the following C# code?
            //DateTime date = new DateTime(2024, 6, 14); 
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");// The event is on 06/14/2024

           




















        }
    }
}
