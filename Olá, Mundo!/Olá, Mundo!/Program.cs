using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olá__Mundo_
{
    class Program
    {
        enum EnumCor //ENUM define parametros pré-estabelecidos para serem usados na variável, nesse caso, COR
        {
            Azul = 10, Verde, Amarelo, VermelhoDels //ao colocar Azul=10, os próximos atributos começam a ser contados a partir do valor 10
        }
        static void Main(string[] args)
        {
              //HELLO, WORLD

                        Console.Write("Hello, World!\n"); //Todo comando em C# precisa de ';' no final || \n - quebra de linha
                        Console.WriteLine("Meu nome é Diego!"); //Console.WriteLine escreve uma nova linha sem necessidade do \n
                        Console.Write("Hello again");
                        Console.ReadLine(); //Comando que lê dado no console

              //VARIÁVEIS

                        Console.WriteLine("digite o ano do final da WW2");
                    int DatadaGuerra = int.Parse(Console.ReadLine()); //int.Parse converte STRING para INT
                        Console.WriteLine(DatadaGuerra);

                    float velocidade_media = 70.5f; //Números float precisam do 'f' minúsculo ao final
                        Console.WriteLine(velocidade_media);

                    bool esta_seMovendo = true; //Variáveis podem ter Underline no nome
                        Console.WriteLine(esta_seMovendo);

                    for (int i = 0; i < 4; i++) //FOR irá rodar a função no número de vezes determinado, nesse caso, 4 vezes
                            {
                                NomeDaFuncao();
                            }
                        Console.WriteLine();

                    foreach (int i in "iiii") //FOREACH nesse contexto está rodando a função na mesma qtd de vezes q a letra "i" aparece na string
                        {
                            NomeDaFuncao();
                        }
                        Console.WriteLine( "Digite o Preço: ");
                        float preco = float.Parse(Console.ReadLine()); //Pode-se usar tanto INT como FLOAT com Parse (converter string em número)
                        Console.WriteLine("Digite o ID do produto: ");
                        string id = Console.ReadLine();
                        GerarPreco(preco, id);
                        Console.WriteLine("1 numero: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("2 numero: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("3 numero: ");
                        int c = int.Parse(Console.ReadLine());
                        int soma1 = Somar(a, b, c); //Neste caso, estou usando a função para RETORNAR um valor dentro dela e chamando o mesmo para o resultado da var SOMA1
                        Console.WriteLine(soma1);
                        
              //ARRAYS
                    string[] produtos = new string[4] //ARRAY completo, definindo o tipo (string) e o número de componentes, nessa caso 4
                    {
                    "Tesseract", //0
                    "Novelists", //1
                    "Unprocessed", //2
                    "Alborosie" //3
                    };

                    Console.WriteLine(produtos[1]);

                    produtos[3] = "Polyphia";
                    Console.WriteLine(produtos[3]);

                    int[] numerosAleat = { 10, 20, 30 }; //Método rápido para criar ARRAY, o C# já entende o tipo e o número de componentes do array
                    Console.WriteLine(numerosAleat[2]);
                                                                                                            
                    Console.ReadLine();

            //SWITCH & ENUM

                    EnumCor cores = ((EnumCor)13); //como a variável está escrita errada ela irá para o DEFAULT
                    switch ((int)cores) //SWITCH só trabalha com IGUALDADES e não com comparações, o valor deve ser exato ao da comparação
                    {
                    case 11: //por ter utilizado o '(int)' antes da var CORES, eu extraio o número relacionado ao ENUM (10 = azul, 11 = verde, etc)    
                        Console.WriteLine("a cor é Verde");
                            break;
                    case 10:
                        Console.WriteLine("a cor é Azul");
                            break;
                    case 12:
                    Console.WriteLine("a cor é Amarelo");
                            break;
                    case 13:
                    Console.WriteLine((EnumCor)13); //quando coloco o nome q defini no enum (nesse caso, EnumCor) entre parenteses, posso chamar pelo seu número
                            break;
                    default: //em caso de nenhuma ocorrência, cairá aqui
                    Console.WriteLine("deu bug");
                            break;
                    }
                      
              

                    } ////////////////////////////////////////////////AQUI ACABA O MAIN////////////////////////////////////////////////////////////

              //FUNÇÕES
                    static void NomeDaFuncao() //Funções são declaradas fora do MAIN ou em arquivo separado
                    {
                        Console.WriteLine("Teste de função");
                        Console.WriteLine("Testando ainda");
                    }
                    static void GerarPreco(float preco, string Id) //VOID ao lado da função não exige obrigação de uso da função, porém ao tipar ela (string, bool, etc),
                                                                   //ela OBRIGATORIAMENTE precisa retornar (RETURN) algum valor do tipo especificado
                    {
                        float precoAbsoluto = Math.Abs(preco); //MATH.ABS retorna o valor absoluto que não seja negativo, mesmo digitando negativo no console
                        Console.WriteLine("o preco é " + precoAbsoluto + " e o ID do produto é " + Id);
                    }
                    static int Somar(int a, int b, int c)
                    {
                        int Soma = a + b + c;
                        return Soma; //Tudo q estiver digitado abaixo de RETURN no bloco, não será executado
                        Console.WriteLine("Essa linha não será executada pois a função entende que foi finalizada quando encontra o RETURN");
                    }
            

               //ENUM 
                    
        }
    }

















