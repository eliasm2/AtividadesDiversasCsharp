using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fib
    {
        public int cFib(int n) {
            return (n == 0 || n == 1) ? 1 : cFib(n - 1) + cFib(n - 2);
        }
    }
}
