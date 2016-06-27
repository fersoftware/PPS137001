using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS137001
{
    /*
     * Abra o Visual Studio.
     * Crie um namespace chamado PPS1xxxxx, sendo xxxxx o seu número de RA.
     * Na classe Program:
     * Escreva o código em C# do método Main, que solicita que o usuário digite o valor de número máximos de produtos maxProd que serão cadastrados no sistema. Esse valor deverá ser um número maior ou igual a 4 e menor ou igual a 15.
     * Depois, o Main, deverá criar:
     * - o vetor Produto, de string, com maxProd posições
     * - a matriz Precos, de float, com maxProd linhas e 3 colunas, uma coluna para o preço de cada mês (março, abril, maio)
     * - o vetor Media, com 3 posições
     * Solicite que o usuário digite os nomes dos produtos até preencher todo o vetor Produto.
     * Solicite que o usuário digite, para cada produto cadastrado, os 3 preços de cada mês, que devem ser inseridos na matriz Precos. Cada linha da matriz Precos conterá os preços de um produto.
     * Chame o método CalculaMedia, passando a matriz Precos e o vetor Media. Esse método deverá calcular a média dos preços de cada mês e colocar a média no vetor Media. Os preços do mês de março estão na coluna zero da matriz. A média dos preços do mês de março deverá ser colocada na posição zero do vetor Media e assim sucessivamente.
     * Exiba todos os dados, em forma de tabela, apresentando na primeira coluna os nomes dos produtos, na segunda coluna, os preços do mês de março, na terceira coluna, os preços do mês de abril e assim sucessivamente. Não se esqueça de exibir os títulos das colunas.
     * Chame o método IndiceMenor, passando o vetor Media. Esse método devolverá o índice de onde se encontra a menor média no vetor Media.
     * O Main deverá exibir de qual mês é a menor média e o valor da menor média.
     * - Escreva os códigos dos métodos conforme descrito no enunciado.
     */


    class Program
    {
        static void Main(string[] args)
        {
            int maxProd = 0;
           
            do
            {
                try
                {
                    Console.Write("Digite o valor de número máximo de produtos:");
                    maxProd = int.Parse(Console.ReadLine());

                    if(maxProd < 4 || maxProd > 15)
                    {
                        Console.WriteLine("Digite acima de 3 e menor que 14");
                        maxProd = 0;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor digitado Inválido");
                    maxProd = 0;
                }

            } while (maxProd < 4 || maxProd > 15);

            string[] produto = new string[maxProd];
            float[,] precos = new float[maxProd, 3];
            float[] media = new float[3];

            for (int i = 0; i < maxProd; i++)
            {
                Console.Write("Digite o nome do produto:");
                produto[i] = Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Digite o preço: ");
                    precos[i, j] = float.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("{0,0} {1,10} {2,10} {3,10}", "Produto", "Março", "Abril", "Maio");
            for (int i = 0; i < maxProd; i++)
            {
                Console.WriteLine("{0,0} {1,10} {2,10} {3,10}", produto[i], precos[i, 0], precos[i, 1], precos[i, 2]);
            }


          

            CalculaMedia(precos, media);

            string mes = "";
            int ind =IndiceMenor(media);

            switch (ind)
            {
                case 0:
                    mes = "Março";
                    break;
                case 1:
                    mes = "Abril";
                    break;
                case 2:
                    mes = "Maio";
                    break;
            }
            Console.WriteLine("A menor média é {0} e é do Mês {1}", media[IndiceMenor(media)], mes);
            Console.ReadKey();
        }

        static void CalculaMedia(float[,] precos, float[] media)
        {            
            float a = 0 , b = 0, c = 0;
            for (int i = 0; i < precos.GetLength(0); i++)
            {                
                a += precos[i, 0];
                b += precos[i, 1];
                c += precos[i, 2];
            }
            media[0] = a / 3;
            media[1] = b / 3;
            media[2] = c / 3;
        }

        static int IndiceMenor(float[] media)
        {
            float menor = 0;
            int ind = 0;

            for (int i = 0; i < media.Length; i++)
            {
                if (i == 0)
                {
                    menor = media[i];
                    ind = i;
                }
              
                if (media[i] <= menor)
                {
                    menor = media[i];
                    ind = i;
                }
            }
            return ind;
        }
    }
}
