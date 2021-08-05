using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Password ");
            string str = Console.ReadLine();
            PassWordStrength ps;
            try 
            { 
                ps = PasswordCheck.GetPasswordStrength(str);
                Console.WriteLine(ps);
            }
            catch (PasswordIsEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(MinimumLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            
            

            Console.ReadLine();
        }
    }
}
