using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int first, int second, int third)
        {
            return first + second + third;
        }

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend
            public int Subtract(int first, int second)
        {
            int minuiend = first;
            int subtrahend = second;
            return minuiend - subtrahend;
        }

        // Create a Multiply method that passes 2 integers
        public int Multiply(int first, int second)
        {
            return first * second;
        }

        // Create a Divide method that passes 2 integers
        public int Divide(int first, int second)
        {
            return first / second;
        }



        // Create 2 methods that will utilize the [Fact] tests you wrote
        public bool IsEven(int number)
        {
            if (number%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsOdd(int number)
        {
            if (number%2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
