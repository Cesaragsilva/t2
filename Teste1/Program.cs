using System;
using System.Collections.Generic;
using System.Text;

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
            String avaliacao = "abbcbbb";
            Console.WriteLine(RemoveDuplicidadeImediataString(avaliacao));
        }

        public static String RemoveDuplicidadeImediataString (string entrada)
        {
            StringBuilder stringTratada = new StringBuilder();

            for (int i = 0; i < entrada.Length; i++)
            {
                if(entrada.Length <= i + 1)
                {
                    stringTratada.Append(entrada[i]);
                    break;
                }
                else
                {
                    if (entrada[i + 1] != entrada[i])
                    {
                        stringTratada.Append(entrada[i]);
                    }
                }
                
            }
            return stringTratada.ToString();
        }

    }
}
