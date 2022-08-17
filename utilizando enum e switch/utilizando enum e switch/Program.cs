using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilizando_enum_e_switch
{
    class Program
    {
        enum color { blue, yellow, green, red }
        enum options {create=1, delete, edit, update}

        static void Main(string[] args)
        {

            Console.WriteLine("Select from bellow:\n1.Create\n2.Delete\n3.Edit\n4.Update");
            int option = int.Parse(Console.ReadLine());
            options selectedOption = (options)option; //SEMPRE LEMBRAR de fazer o cast do enum para converter para um dos valores do enum!!

            switch (selectedOption)
            {
                case options.create:
                    Console.WriteLine("Criado com sucesso");
                    break;
                case options.delete:
                    Console.WriteLine("Deletado com sucesso");
                    break;
                case options.edit:
                    Console.WriteLine("Editado com sucesso");
                    break;
                case options.update:
                    Console.WriteLine("Atualizado com sucesso");
                    break;
                default:
                    Console.WriteLine("Tá tirando um pêlo com sucesso");
                    break;
            }
            string[] nomes = {"Diego", "Diana", "Marlene", "Domingos", "Kaua", "Valentina"};

            foreach (string nome in nomes) //FOREACH, como o nome diz, para cada nome no ARRAY 'nomes' o bloco irá exibir o valor correspondente
            {
                Console.WriteLine(nome);
                Console.WriteLine();
            }

            for (int i = 0; i < nomes.Length; i++) //buscando valores do ARRAY com os mesmos resultados acima, porém usando FOR
            {
                Console.WriteLine(nomes[i]);
                Console.WriteLine();
            }

            for (int i = 5; i > 0 ; i--)
            {
                Console.WriteLine(nomes[i]);
                Console.WriteLine();
            }
        }
    }
}
