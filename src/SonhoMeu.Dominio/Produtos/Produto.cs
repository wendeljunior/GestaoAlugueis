
using SonhoMeu.Comum;

namespace SonhomeMeu.Dominio.Produtos
{
    public class Produto : Entidade
    {
        public string Nome { get; private set; }
        public Categoria Categoria { get; private set; }
        public decimal Preco { get; private set; }
        public Produto(string nome, Categoria categoria, decimal preco)
        {
            Validar(nome, categoria, preco);
            Set(nome, categoria, preco);
        }

        private void Set(string nome, Categoria categoria, decimal preco)
        {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }

        private static void Validar(string nome, Categoria categoria, decimal preco)
        {
            DominioException.When(string.IsNullOrEmpty(nome), "Nome não pode ser vazio");
            DominioException.When(categoria == null, "Categoria não pode ser vazio");
            DominioException.When(preco < 0, "Preco não pode ser menor do que 0");
        }

        public void Atualizar(string nome, Categoria categoria, decimal preco)
        {
            Validar(nome, categoria, preco);
            Set(nome, categoria, preco);
        }
    }
}