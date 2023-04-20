using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Sawyer_Moira
{
    class Calculate
    {

        public static float result = 0.0f;

        static Calculate()
        {
            result = 0.0f;
        }

        //INTEGERS

        // A method that is Adding two integer numbers together and returns the result.
         public static int Add(int x, int y)
        {
            return x + y;
        }


        // a method that is Subtracting two integer numbers together and returns the result.
        public static int Sub(int x, int y)
        {
            return x - y;
        }

        // A method that is Multiplying two integer numbers together and returns the result.
        public static int Mult(int x, int y)
        {
            return x * y;
        }

        // A method that is Deviding two integer numbers together numbers and returns the result.
        public static int Div(int x, int y)
        {
            return x / y;
        }

        // FLOATERS

        // A method that is Adding two floating pints numbers together and returns the result.
        public static float Add(float x, float y)
        {
            return x + y;
        }

        // A method that is Subtrating two floating pints numbers together and returns the result.
        public static float Sub(float x, float y)
        {
            return x - y;
        }

        // A method that is Multiplying two floating pints numbers together and returns the result.
        public static float Mult(float x, float y)
        {
            return x * y;
        }

        // A method that is Dividing two floating pints numbers together and returns the result.
        public static float Div(float x, float y)
        {
            return x / y;
        }
    }
}
