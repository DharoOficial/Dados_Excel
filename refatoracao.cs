using System.Collections.Generic;

namespace CriarDadosExel_27
{
    public interface refatoracao
    {
        
        List<Produto> Ler();
        void Cadastrar();

        void Remover();

        void Alterar();

        void ReescreverCSV();

        string PrepararLinha();

    }
}