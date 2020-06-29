using System.IO;
using System;

namespace CriarDadosExel_27
{
    public class Produto
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public int preco { get; set; }

        private const string PATH = "Database/produto.csv";

        public Produto()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }

        }

        public void inserir(Produto p)
        {
            string[] linha = new string[]{p.PrepararLinhaCSV(p) };
            File.AppendAllLines(PATH, linha);
        }

        private string PrepararLinhaCSV ( Produto prod )
        {
            return $"codigo= {prod.codigo}; nome= {prod.nome}; preco{prod.preco}";
        }
        
        
    }
}