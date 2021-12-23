using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Проверка пароля");
            string password = "";
            string[] pass_decode = { "password123", "admin", "admin1" };
            string pass_possible = "01110000 01100001 01110011 01110011 01110111 01101111 01110010 01100100 00110001 00110010 00110011";
            foreach (string pass in pass_decode)
            {
                string str = "";
                byte[] pass_bytes = Encoding.Unicode.GetBytes(pass);
                foreach (byte bytes in pass_bytes)
                {
                    str += (bytes == 0) ? " " : Convert.ToString(bytes, 2).PadLeft(8, '0');
                }
                if (str[str.Length - 1] == ' ') str = str.Substring(0, str.Length - 1);
                if (Equals(str, pass_possible))
                {
                    password = pass;
                    break;
                }
                Console.WriteLine(pass_possible.Length);
                Console.WriteLine(str.Length);
            }
            Console.WriteLine(!(password == "") ? password : "false");
        }
    }
}
