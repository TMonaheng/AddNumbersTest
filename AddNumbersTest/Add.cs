using System;

namespace AddNumbersTest
{
    internal class Add
    {
        private int Num1;
        private int Num2;

        public Add(int numb1, int numb2)
        {
            this.Num1 = numb1;
            this.Num2 = numb2;
        }

        internal object AddTwoNumbers()
        {
            int sum = 0;
            sum += Num1 + Num2;
            return sum;
        }
    }
}