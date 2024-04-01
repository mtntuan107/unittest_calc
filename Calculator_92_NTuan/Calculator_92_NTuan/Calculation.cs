using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_92_NTuan
{
    public class Calculation
    {
        private int a, b;
        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Execute(string CS)
        {
            int result = 0;
            switch (CS)
            {
                case "+":
                    result = this.a + this.b;
                    break;
                case "-":
                    result = this.a - this.b;
                    break;
                case "*":
                    result = this.a * this.b;
                    break;
                case "/":
                    result = this.a / this.b;
                    break;
            }
            return result;
        }
    }
}
