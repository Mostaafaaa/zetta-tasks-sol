using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SolOfZettaTasks

{
    public static class ValidatInput
    {
        public static bool IsNumber (string input)
        {
            Regex regex = new Regex(@"^-?\d+(\.\d+)?$");
            return regex.IsMatch(input);
        }
        public static bool IsOperation(string input)
        {
            Regex regex = new Regex(@"^[\+\-\*/]$");
            return regex.IsMatch(input);
        }
       
    }

}
