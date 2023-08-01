using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexs
{
    internal class PinCode
    {
       
            string UC1_Regex = "^[0-9]{6}$";
            public void Validate(string input)
            {
                bool result=Regex.IsMatch(input, UC1_Regex);
            if (result)
                Console.WriteLine("Validation successful!");
            else
                Console.WriteLine("Validation Unsuccessful!");
        } 
    }
}