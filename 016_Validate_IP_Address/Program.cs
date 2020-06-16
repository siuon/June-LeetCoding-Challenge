using System;
using System.Text.RegularExpressions;

namespace _016_Validate_IP_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Write a function to check whether an input string is a valid IPv4 address or IPv6 address or neither.
               
               IPv4 addresses are canonically represented in dot-decimal notation, which consists of four decimal numbers, 
               each ranging from 0 to 255, separated by dots ("."), e.g.,172.16.254.1;
               
               Besides, leading zeros in the IPv4 is invalid. For example, the address 172.16.254.01 is invalid.
               
               IPv6 addresses are represented as eight groups of four hexadecimal digits, each group representing 16 bits. 
               The groups are separated by colons (":"). For example, the address 2001:0db8:85a3:0000:0000:8a2e:0370:7334 is a valid one. 
               Also, we could omit some leading zeros among four hexadecimal digits and some low-case characters in the address to upper-case ones, 
               so 2001:db8:85a3:0:0:8A2E:0370:7334 is also a valid IPv6 address(Omit leading zeros and using upper cases).

               However, we don't replace a consecutive group of zero value with a single empty group using two consecutive colons (::) to pursue simplicity. 
               For example, 2001:0db8:85a3::8A2E:0370:7334 is an invalid IPv6 address.
               
               Besides, extra leading zeros in the IPv6 is also invalid. For example, the address 02001:0db8:85a3:0000:0000:8a2e:0370:7334 is invalid.

               Note: You may assume there is no extra space or special characters in the input string.
   
               Example 1:
                 Input: "172.16.254.1"
                 Output: "IPv4"
                 Explanation: This is a valid IPv4 address, return "IPv4".
            */

            var ip = "172.16.254.1";
            var solution = new Solution();

            Console.WriteLine(solution.ValidIPAddress(ip) == "IPv4");
        }
    }

    public class Solution
    {
        public string ValidIPAddress(string IP)
        {
            if (IP.Contains(":"))
            {
                if (IP.Contains("::") ||
                    IP[IP.Length - 1] == ':')
                {
                    return "Neither";
                }
                else
                {
                    var temp = IP.Split(":");

                    if (temp.Length != 8)
                    {
                        return "Neither";
                    }

                    foreach (var temp2 in temp)
                    {
                        if (temp2.Length > 4)
                        {
                            return "Neither";
                        }

                        if (temp2.Length > 2 && temp2[0] == '0')
                        {
                            return "Neither";
                        }

                        foreach (var cha in temp2)
                        {
                            if ((cha >= 'a' && cha <= 'f') ||
                                (cha >= 'A' && cha <= 'F'))
                                {}
                                else 
                                {
                                    int temp3;

                                    if (!int.TryParse(cha.ToString(), out temp3))
                                    {
                                        return "Neither";
                                    }
                                }
                        }
                    }

                    return "IPv6";
                }
            }
            else
            {
                var temp = IP.Split(".");
                var isIPv4 = true;

                if (temp.Length != 4)
                {
                    return "Neither";
                }

                foreach (var num in temp)
                {
                    int temp3;

                    foreach (var temp4 in num)
                    {
                        if (temp4 >= '0' && temp4 <= '9')
                        {

                        }
                        else
                        {
                            return "Neither";
                        }
                    }

                    if (!int.TryParse(num, out temp3))
                    {
                        return "Neither";
                    }
                    else if (num.Length > 1 && num[0] == '0')
                    {
                        return "Neither";
                    }

                    var temp2 = Convert.ToInt32(num);

                    if (!(temp2 >= 0 && temp2 <= 255))
                    {
                        isIPv4 = false;
                        break;
                    }
                }

                return isIPv4 ? "IPv4" : "Neither";
            }
        }
    }
}
