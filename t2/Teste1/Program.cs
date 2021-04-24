using System;

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

           string resultadoFinal = NaoRetornaCaracteresIgualAnterior(avaliacao);
        }

        //Verifica se a letra atual é igual a letra anterior dentro de uma string
        private static string NaoRetornaCaracteresIgualAnterior(string textoAvaliacao)
        {
            string resultadoAvaliacao = string.Empty;
            char letra;
            
            char letraAnterior = textoAvaliacao[0];
            //Inicializa o resultadoAvaliacao com a primeira letra do textoAvaliacao
            resultadoAvaliacao = resultadoAvaliacao.Insert(0, letraAnterior.ToString());
            int contCaracteres = 0;
            try
            {
                //Percorre todo o texto a começar pela segunda letra
                for (int cont = 1; cont <= textoAvaliacao.Length-1; cont++ )
                {
                    letra = textoAvaliacao[cont];
                    //Verifica se a letra atual é diferente a anterior
                    if (letraAnterior != letra)
                    {
                        contCaracteres = contCaracteres + 1;
                        //Insere no resultadoAvaliacao a letraAtual
                        resultadoAvaliacao = resultadoAvaliacao.Insert(contCaracteres, letra.ToString());
                    }

                    //Atribui a letra anterior o valor da letra atual, para a proxima rodada
                    letraAnterior = letra;
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

            //Retorna o resultado Avaliacao.
            return resultadoAvaliacao;
        }

    }
}
