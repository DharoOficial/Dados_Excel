using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CriarDadosExel_27
{
    public class Produto
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public float preco { get; set; }

        

        public Produto()
        {   
            string pasta = @"C:\Users\mercatudo\Documents\site\CriarDadosExel_27\produto.csv".Split('/')[0];
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(@"C:\Users\mercatudo\Documents\site\CriarDadosExel_27\produto.csv"))
            {
                File.Create(@"C:\Users\mercatudo\Documents\site\CriarDadosExel_27\produto.csv").Close();
            }

        }

        public void inserir(Produto p)
        {
            string[] linha = new string[]{p.PrepararLinhaCSV(p) };
            File.AppendAllLines(@"C:\Users\mercatudo\Documents\site\CriarDadosExel_27\produto.csv", linha);

            
        }
        private string PrepararLinhaCSV ( Produto prod )
        {
            return $"codigo= {prod.codigo}; nome= {prod.nome}; preço= R${prod.preco}.";
        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            string[] linhas  = File.ReadAllLines(@"C:\Users\mercatudo\Documents\site\CriarDadosExel_27\produto.csv");
        
            foreach(var linha in linhas)
            {
                string[] dados = linha.Split(";");
                Produto prod = new Produto();

                prod.codigo = Int32.Parse((dados[0]));
                prod.nome = (dados[1]); 
                prod.preco = float.Parse(dados[2] );
                produtos.Add(prod);
            }
            return produtos;
        }
        

        public void Remove(string _termo)
        {
            List<string> lines = new List<string>();
            using(StreamReader file = new StreamReader(@"C:\Users\mercatudo\Documents\site\CriarDadosExel_27\produto.csv"))
            {
                string line;
                while((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                lines.RemoveAll(l => l.Contains(_termo));
            }
        }
    
       



            
        
    }
}