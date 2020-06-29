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

            Produto p1 = new Produto();
            p1.codigo = 2;
            p1.nome = "Lamborga";
            p1.preco = 3000000 ;
            p1.inserir(p1);


            
        }
            
    }
}

