using System;

namespace Шифрование
{
    internal class Encrypt
    {
        public string readmessaege;
        public string readpassword;

        public string encryten;
        public string lenghtpassword;

        //Шифрование сообщения
        public void Encrypttxt()
        {
            lenghtpassword = readpassword;

            //Дополняем пароль до длины сообщения
            while (readmessaege.Length > lenghtpassword.Length)
            {
                lenghtpassword = lenghtpassword + lenghtpassword;
            }

            char[] enacrypmessage = readmessaege.ToCharArray();
            char[] enacrypassword = lenghtpassword.ToCharArray();

            string encr = "";

            //Шифруем символы сообщения с помощью пароля
            for (int i = 0; i < enacrypmessage.Length; i++)
            {
                int crypt = enacrypmessage[i] + enacrypassword[i];
                char result1 = Convert.ToChar(crypt);
                encr = encr + result1;
            }

            //Выводим зашифрованое сообщение 
            Console.WriteLine("Зашифрованное сообщение: " + encr);

            encryten = encr;

            Decoding();
        }

        public string decoding;
        public string decodingmess;

        //Расшифровка сообщения
        public void Decoding()
        {
            Console.Write("Введите пароль: ");
            decodingmess = Console.ReadLine();

            // Дополняем пароль до длины сообщения
            while (readmessaege.Length > decodingmess.Length)
            {
                decodingmess = decodingmess + decodingmess;
            }

            char[] enacrypmessage = encryten.ToCharArray();
            char[] enacrypassword = decodingmess.ToCharArray();

            // Расшифровываем символы сообщения с помощью пароля
            for (int i = 0; i < enacrypmessage.Length; i++)
            {
                int crypt = enacrypmessage[i] - enacrypassword[i];
                char simv1 = (char)crypt;
                string result2 = simv1.ToString();
                decoding = decoding + result2;
            }

            // Выводим расшифрованное сообщение на экран
            Console.WriteLine("Сообщение успешно расшифрованно: " + decoding);

            decoding = null;
        }

    }
}
