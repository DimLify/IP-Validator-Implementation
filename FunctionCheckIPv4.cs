using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ip_Validator_Implementation
{
    internal class FunctionCheckIPv4
    {
        public static (bool, string) IsValidIPv4Address(string ipAddress)
        {
            // Split the IP address into octets
            string[] octets = ipAddress.Split('.');

            // Check if the IP address has exactly 4 octets
            if (octets.Length != 4)
            {
                return (false, "Invalid IP address. IP address must consist of four octets.");
            }

            // Check each octet for validity
            foreach (string octet in octets)
            {
                // Check if the octet is empty or starts with '0'
                if (string.IsNullOrEmpty(octet) || (octet.Length > 1 && octet[0] == '0'))
                {
                    return (false, $"Invalid IP address. Octet '{octet}' is not valid.");
                }

                // Parse the octet as an integer
                if (!int.TryParse(octet, out int value))
                {
                    return (false, $"Invalid IP address. Octet '{octet}' is not a valid integer.");
                }

                // Check if the octet is within the valid range (0-255)
                if (value < 0 || value > 255)
                {
                    return (false, $"Invalid IP address. Octet '{octet}' is not within the valid range (0-255).");
                }
            }

            // If all checks pass, the IP address is valid
            return (true, "Valid IP address.");
        }
    }
}
