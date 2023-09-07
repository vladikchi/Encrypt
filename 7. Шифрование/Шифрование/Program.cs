using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шифрование
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encrypt encrypt = new Encrypt();

            while (true)
            {
                encrypt.password = "Шифрование";

                Console.Write("Введите сообщение: ");
                encrypt.readmessaege = Console.ReadLine();

                Console.Write("Введите пароль: ");
                encrypt.readpassword = Console.ReadLine();

                encrypt.Password1();

            }
        }
    }
}