using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleLuanApp
{
    class Program
    {

        #region Requisito 01 [OK]
        //A calculadora deve ter a possibilidade de somar dois números
        #endregion

        #region Requisito 02 [OK]
        //A calculadora deve ter a possibilidade fazer várias operações de soma
        #endregion

        #region Requisito 03 [OK]
        //A calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
        #endregion

        #region Requisito 04 [OK]
        //A calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
        #endregion

        #region Requisito 05 [OK]
        //A calculadora deve validar a opções do menu [OK]
        #endregion

        #region BUG 01 [OK]
        //A calculadora deve realizar as operações com "0"
        #endregion

        #region Requisito 06
        /** A calculadora deve permitir visualizar as operações já realizadas
         *  Critérios:
         *      1 - A descrição da operação realizada deve aparecer assim, exemplo:
         *          2 + 2 = 4
         *          10 - 5 = 5
         */
        #endregion


        static void Main(string[] args)
        {
            String simboloOperacao = "";
            String[] operacoesRealizadas = new string[100];
            String opcao = "";/*Declaração da variavel opcao*/
            int contadorOperacoesRealizadas = 0;

            while (true)
            {
                Console.WriteLine("Calculadora 1.5");
                Console.WriteLine("Pressione 1 para realizar operações de Adição");
                Console.WriteLine("Pressione 2 para realizar operações de subtração");
                Console.WriteLine("Pressione 3 para realizar operações de Multiplicação");
                Console.WriteLine("Pressione 4 para realizar operações de Divisão");
                Console.WriteLine("Pressione 5 Exibir o histórico de Operações realizadas");
                Console.WriteLine("Pressione S ou s para sair");

                opcao = Console.ReadLine();/*Imprime as informações do menu*/

                /*Valida as opções do menu*/
                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s")
                {
                    Console.ForegroundColor = ConsoleColor.Red;/*Muda a cor da mensagem para vermelho*/

                    Console.WriteLine("Opção inválida! Tente novamente");/*Imprime a mensagem de erro*/

                    Console.ResetColor();/*Reseta a cor vermelha de volta para a original*/

                    Console.ReadLine();/*Imprime as informações na tela*/

                    Console.Clear();/*Limpa as informações anteriores da tela*/

                    continue;/*Continua a aplicação após a correção do erro*/
                }

                if (opcao == "5")
                {
                    Console.WriteLine();

                    for (int i = 0; i < operacoesRealizadas.Length; i++)
                    {
                        if (operacoesRealizadas[i] != null)

                            Console.WriteLine(operacoesRealizadas[i]);
                    }

                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                /*Ignora a diferença de maiusculo e minusculo*/
                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))/*"s é a condição de parada da app"*/
                {
                    break;/*Para a aplicação*/
                }

                double pNumero, sNumero; /*Declaração das variaveis primeiro numero e segundo numero*/

                Console.WriteLine("Digite o primeiro Número:");/*Imprime o texto*/
                pNumero = Convert.ToDouble(Console.ReadLine());/*le a informação inserida pelo usuário*/

                do/*Faça*/
                {

                    Console.WriteLine("Digite o Segundo Número:");/*Imprime o texto*/
                    sNumero = Convert.ToDouble(Console.ReadLine());/*le a informação inserida pelo usuário*/

                    if (opcao == "4" && sNumero == 0)/*Se o segundo número for zero aparece a mensagem de erro*/
                    {
                        Console.ForegroundColor = ConsoleColor.Red;/*Muda a cor do texto para vermelho*/

                        Console.WriteLine("Segundo número inválido! Tente novamente");/*Imprime a mensagem de erro na tela*/

                        Console.ResetColor();/*Reseta a cor vermelha de volta para a original*/

                        Console.ReadLine();/*Le as informações*/
                    }


                } while (opcao == "4" && sNumero == 0);/*Enquanto*/

                double resultado = 0;/*Declaração da variavel resultado*/

                /*Funciona melhor que if na hora de escolher a operação a ser realizada na calculadora*/
                switch (opcao)
                {
                    case "1": resultado = pNumero + sNumero;
                        simboloOperacao = "+";
                        break;
                    case "2":
                        resultado = pNumero - sNumero;
                        simboloOperacao = "-";
                        break;
                    case "3":
                        resultado = pNumero * sNumero;
                        simboloOperacao = "*";
                        break;
                    case "4":
                        resultado = pNumero / sNumero;
                        simboloOperacao = "/";
                        break;

                    default:
                        break;
                }

                string operacaoRealizada = pNumero.ToString() + " " + simboloOperacao + " " +sNumero.ToString() + " = " + resultado.ToString();

                operacoesRealizadas[contadorOperacoesRealizadas] = operacaoRealizada;

                Console.WriteLine(resultado);/*Mostra o resultado da operação*/
                Console.WriteLine(operacaoRealizada);
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
