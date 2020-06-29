using System;
using System.IO;

namespace CriarDadosExel_27
{
    class Program
    {

        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.codigo = 1;
            p.nome = "2077";
            p.preco = 299 ;
            p.inserir(p);


            string path = @"Database";

        try
        {
            // Determine whether the directory exists.
            if (Directory.Exists(path))
            {
                Console.WriteLine("That path exists already.");
                return;
            }

            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

           
            
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
        finally {}

        }
            
    }
}

