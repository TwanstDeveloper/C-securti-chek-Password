using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chekpassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwords;
            Console.WriteLine("Enter Password Cheke");
            passwords = Console.ReadLine();
            Console.WriteLine("The password Chake");
            Program obj = new Program();
            obj.chekpassword(passwords);
            Console.ReadKey();
        }
        void chekpassword(string password)
        {
            int capital = 0;
            int smol = 0;
            int digit = 0;
            int  spectionl= 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 65 && password[i] <= 90)
                {
                    capital = 1;
                }
                else if (password[i] >= 97 && password[i] <= 122)
                {
                    smol = 1;
                }
                else if (password[i] >= 47 && password[i] <= 58)
                {
                    digit = 1;
                }
                else
                {
                    spectionl = 1;
                }
            }
            if (capital==1 && smol==1 && digit==1 && spectionl==1)
                {
                    Console.WriteLine(" Very Strong ");
                }
            else if ((capital == 1 || smol == 1) && digit == 1 && spectionl == 1){
                    Console.WriteLine("Strong ");
                }
            else if ((capital == 1 || smol == 1) && (digit == 1)){
                    Console.WriteLine("mediam ");
                }
            else{
                    Console.WriteLine("Weak");
                 }
            
           
        }
    }
}
