using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Utils
{
    public static class Utilities
    {
        public static string GetRandomString()
        {
            return $"TA_{new Random().Next()}";
        }
    }
}