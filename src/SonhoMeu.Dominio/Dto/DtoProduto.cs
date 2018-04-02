
using SonhoMeu.Comum;

namespace SonhomeMeu.Dominio.Produtos
{
    public class DtoProduto : Entidade
    {
        public string Nome { get; private set; }
        public Categoria Categoria { get; private set; }
        public decimal Preco { get; private set; }
    }
}