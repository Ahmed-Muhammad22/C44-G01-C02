using System;

namespace C_Lec2Demo
{
    // class, struct, enum, interface
    internal class Program
    {
        /// <summary>
        /// This function can sum 2 int numbers.
        /// </summary>
        /// <param name="num1">This is the first number</param>
        /// <param name="num2">This is the second number</param>
        /// <returns>The result will be the sum of num1 + num2</returns>
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// This function prints an integer to the console.
        /// </summary>
        /// <param name="x">The integer to print</param>
        static void Print(int x)
        {
            //Int y = 10;
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.ReadLine();

            #region Comments and Regions
            // This is my first comment [Single line comment]
            // int x = 5;
            // int y = 5;

            /*
             * This is my first multiple line comment 
             * int x = 5;
             * int y = 5;
             */
            #endregion

            #region Question 01
            //int x = 10;
            //int y = 20;
            //Console.WriteLine(x + y);
            //Console.WriteLine("Hello");
            #endregion

            #region Variables Declaration and Naming Convention
            int studentAge = 20; // 4 bytes in stack
            Console.WriteLine(studentAge);

            // DataType   Name (camelCase)      Value
            // int 9number;         // Invalid
            /*int _number = 20; */      // Valid
                                        //int @class = 200;
                                        //int @struct = 300;
                                        //Console.WriteLine(@class);
                                        //Console.WriteLine(@struct);

            // PascalCase => MyName (used in class names)
            // camelCase  => myName (used in variable names)
            // snake_case => my_name (rare in C#)
            // kebab-case => my-name (invalid in C#)

            //int number = 20, number02 = 200;
            //Console.WriteLine(number);
            //Console.WriteLine(number02);

            //string myName = "Mariam";
            //Console.WriteLine(myName);
            #endregion

            #region Naming Convention Summary
            // PascalCase [C#]         => MariamShindyRoute
            // camelCase [JavaScript]  => mariamShindyRoute
            // Kebab-Case [Angular]    => mariam-shindy-route
            // Snake_Case              => Mariam_Shindy_Route
            #endregion
            //Int32 X = 29;
            //int X = 29; // alias [C# keyword]
            //Int16 S = 19;
            //String name = "Mariam";
            //string Name = "Mariam";
            #region Value type & Reference type 
            #region Value type
            #endregion
            /*int X;*/ //CLR Will Allocate 4 uninitialzed bytes in stack
                       // int --> C# KeyWord
                       //X = 5;
                       //Console.WriteLine(X);
                       //Int32 Y = 10;
                       //Console.WriteLine(Y);
                       //Y = X;
                       //Console.WriteLine(Y);
                       //X++;
                       //Console.WriteLine(X);
                       //Console.WriteLine(Y);
            #region Reference type
            Point P1;
            //Clr will allocate 4 bytes in stack 
            //Clr will allocate 0 bytes in heap
            //P1 refer to null [default value for reference type]
            P1 = new Point();
            //new 
            //1] clr will Allocate required bytes in heap [8 bytes]
            //2] clr will Initialize each field with the default value based on database 
            //3] clr will Call user defined constructor [if exists] 
            //4] Assign reference to object in the heap 
           Point P2 = new Point(); // Unreachable object
            P2 = P1;
            P2.x = 10;
            Console.WriteLine(P1.x); //10
            Console.WriteLine(P2.x);  //10
            P1.y = 15;
            Console.WriteLine(P2.y);//15


            #endregion
         #endregion
            #region Values types
            //string name = "Mariam"; // alias [C# KEYWORD]
            //String myName = "Mariam"; //[BCL]

            //Single number = 10;
            //float number = 10;
            //int x;
            //allocate 4 bytes in stack [Uninitialized]
            //x = 5;
            //Assign value into variable 
            //Console.WriteLine(x);
            //int y = 10;
            //Console.WriteLine(y);
            //Console.WriteLine();
            /*y = x;*/ // y=x=5
                       //Console.WriteLine(x);
                       //Console.WriteLine(y);

            //y++;//y = y + 1
            //Console.WriteLine();
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //int x = 10;
            //string name = " Mariam";
            //Console.Write(x);
            //Console.WriteLine(name);
            #endregion
            #region Reference types
            //Point P1;
            //Allocate 4 bytes in stack 
            //Allocate 0 bytes in heap
            //P1 = new Point();
            //new 
            //1] Allocate required bytes in heap [8 bytes]
            //2] Initialize each field with the default value based on database 
            //3] Call user defined constructor if exist 
            //4] Assign reference to object in the heap 
            //Console.WriteLine(P1.x);
            //Console.WriteLine(P1.y);
            //Console.WriteLine();
            //Point P2 = new Point() {x=5 , y=10 };
            //Console.WriteLine(P2.x);
            //Console.WriteLine(P2.y);
            //Console.WriteLine();

            //P1 = P2; // X=5 , Y =10
            //Console.WriteLine(P1.x);
            //Console.WriteLine(P1.y);
            //Console.WriteLine(P2.x);
            //Console.WriteLine(P2.y);

            //P1.x = 30;
            //Console.WriteLine();
            //Console.WriteLine(P1.x);
            //Console.WriteLine(P2.x);
            #endregion

        }

    }
}
