using SonhoMeu.Comum;

namespace SonhomeMeu.Dominio.Produtos
{
    public class Categoria : Entidade
    {
        public string  Nome { get; private set; }

        public Categoria(string nome)
        {
            Validar(nome);
            Set(nome);
        }

        private void Set(string nome)
        {
            Nome = nome;
        }

        private static void Validar(string nome)
        {
            DominioException.When(string.IsNullOrEmpty(nome), "Nome não pode ser vazio");
        }

        public void Atualizar(string nome)
        {
            Validar(nome);
            Set(nome);
        }
    }
}