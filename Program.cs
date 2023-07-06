using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ip_Validator_Implementation.FunctionCheckIPv4;

namespace Ip_Validator_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ipAddress = "192.168.0.01";
            (bool isValid, string message) = IsValidIPv4Address(ipAddress);
            Console.WriteLine($"Is {ipAddress} a valid IPv4 address?");
            Console.WriteLine($"Isvalid : {isValid} \nMessage : {message}");
            
        }
    }
}
