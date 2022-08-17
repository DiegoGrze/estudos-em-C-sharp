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
        }
    }
}
