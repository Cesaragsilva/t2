using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste1
{
    class Program
    {
        //TODO
        /* 
         * Desenvolva um método que receba a string "abbcbbb". O retorno desse método deverá ser "abcb", 
         * logo o próximo caracter não deverá ser igual ao anterior, o método deve ser capaz de tratar qualquer string.
        */

        static void Main(string[] args)
        {
            //String avaliacao = "";
            String avaliacao = "abbcbbb";

            Console.Write(RemoveRepetitions(avaliacao));

            Console.ReadKey();
        }

        private static string RemoveRepetitions(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                var caracteres = message.ToCharArray().ToArray();
                List<string> word = new List<string>();

                Char current = new Char();
                foreach (var c in caracteres)
                {
                    if (!c.Equals(current))
                    {
                        word.Add(c.ToString());
                        current = c;
                    }
                }
                return string.Join("", word);


            }
            return message;
        }
    }
}