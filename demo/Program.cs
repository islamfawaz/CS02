using System.Drawing;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Type
            int X;
            //// CLR Will Allocate 4 UnInitialized Bytes at STACK
            // int : C# Keyword
            X = 5;
            Int32 Y = 10;
            //// CLR Will Allocate 4 Initialized Bytes at STACK = 10
            //// Int32 : BCL
            Y = X; // 5
            X++; // 6
            Console.WriteLine(Y);

            #endregion        }




            #region ReferenceTypeExample
            Point P1 = new Point(); // Instantiate Point P1
            Point P2; // Declare Point P2
            P2 = new Point(); // Instantiate Point P2
            P2 = P1; // Assign P1 to P2 (now both reference the same object)
            P2.X = 10; // Modify X through P2
            Console.WriteLine(P1.X); // Output: 10
            #endregion

            #region CastingExample
            int x= 8;
            long y = (long)X; // Explicit casting from int to long
            Console.WriteLine(Y); // Output: 8

            long X_long = 4354546576567;
            checked
            {
                int Y_int = X_long.GetType() == typeof(int) ? (int)X_long : 0; // Explicit casting with type check
                unchecked
                {
                    Console.WriteLine(Y_int); // Output: 0 (since X_long is not of type int)
                }
            }
            #endregion

            #region InputOutputExample
            Console.WriteLine("Please enter your name:");
            string Name = Console.ReadLine() ?? "NA";
            Console.WriteLine("Please enter your age:");
            int Age = Convert.ToInt32(Console.ReadLine() ?? "0");
            Console.WriteLine("Please enter your salary:");
            decimal Salary = Convert.ToDecimal(Console.ReadLine() ?? "0");
            Console.Clear();
            Console.WriteLine("Your Name is " + Name);
            Console.WriteLine("Your Age is " + Age);
            Console.WriteLine("Your Salary is " + Salary);
            #endregion

            #region ParsingExample
            Console.WriteLine("Please enter your name:");
            string NameParsed = Console.ReadLine() ?? "NA";
            Console.WriteLine("Please enter your age:");
            int AgeParsed = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Please enter your salary:");
            decimal SalaryParsed = decimal.Parse(Console.ReadLine() ?? "0");
            Console.Clear();
            Console.WriteLine("Your Name is " + NameParsed);
            Console.WriteLine("Your Age is " + AgeParsed);
            Console.WriteLine("Your Salary is " + SalaryParsed);
            #endregion

            #region UnaryOperatorsExample
            int X_unary = 10;
            Console.WriteLine(++X_unary); // Output: 11 (pre-increment)
            Console.WriteLine(X_unary++); // Output: 11 (post-increment, X_unary becomes 12 after this line)
            Console.WriteLine(--X_unary); // Output: 11 (pre-decrement)
            Console.WriteLine(X_unary--); // Output: 11 (post-decrement, X_unary becomes 10 after this line)
            #endregion

            #region AssignmentOperatorExample
            int X_assign = 4;
            X_assign += 2; // X_assign = X_assign + 2
            X_assign -= 2; // X_assign = X_assign - 2
            X_assign *= 2; // X_assign = X_assign * 2
            X_assign /= 2; // X_assign = X_assign / 2
            X_assign %= 2; // X_assign = X_assign % 2
            #endregion

            #region RelationalOperatorsExample
            int X_relational = 6, Y_relational = 5;
            Console.WriteLine(X_relational == Y_relational); // Equal
            Console.WriteLine(X_relational != Y_relational); // Not Equal
            Console.WriteLine(X_relational > Y_relational); // Greater Than
            Console.WriteLine(X_relational >= Y_relational); // Greater Than Or Equal
            Console.WriteLine(X_relational < Y_relational); // Less Than
            Console.WriteLine(X_relational <= Y_relational); // Less Than Or Equal
            #endregion

            #region LogicalOperatorsExample
            Console.WriteLine(!false); // Logical NOT
            Console.WriteLine(false && true); // Logical AND
            Console.WriteLine(true || false); // Logical OR
            #endregion

            #region BitwiseOperatorsExample
            Console.WriteLine(!false); // Bitwise NOT
            Console.WriteLine(false & true); // Bitwise AND
            Console.WriteLine(true | false); // Bitwise OR
            #endregion

            #region TernaryOperatorExample
            int X_ternary = 10, Y_ternary = 5;
            string Message = X_ternary > Y_ternary ? "X is more than Y" : "X is less than or equal to Y";
            Console.WriteLine(Message);
            #endregion

            #region TryParseExample
            string input = "123";
            int Y_try;
            bool flag = int.TryParse(input, out Y_try); // TryParse example
            Console.WriteLine(flag); // Output: true
            Console.WriteLine(Y_try); // Output: 123
            #endregion

            #region EquationExample
            int a = 20;
            int b = 10;
            int c = 15;
            int d = 5;
            int equation;
            equation = (a + b) * c / d; // Result: 60
            equation = ((a + b) * c) / d; // Result: 60
            equation = (a + b) * (c / d); // Result: 90
            equation = a + (b * c) / d; // Result: 50
            #endregion

            #region StringFormatExample
            int X_format = 3, Y_format = 4;
            string Message_format = $"Equation: {X_format} + {Y_format} = {X_format + Y_format}";
            Console.WriteLine(Message_format);
            #endregion

        }
    }
}
