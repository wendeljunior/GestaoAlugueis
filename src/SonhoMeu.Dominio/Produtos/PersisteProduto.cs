namespace SonhomeMeu.Dominio.Produtos
{
    public class  PersisteProduto   
    {
        private readonly IRepositorio<Produto> _repositorioProduto;
        private readonly IRepositorio<Categoria> _repositorioCategoria;
        
        public PersisteProduto(IRepositorio<Produto> repositorioProduto, IRepositorio<Categoria> repositorioCategoria)
        {
            _repositorioProduto = repositorioProduto;
            _repositorioCategoria = repositorioCategoria;
        }
        public void Persistir(DtoProduto dto)
        {
            var categoria = _repositorioCategoria.Recuperar(dto.Categoria.Id);
            DominioException.When(categoria == null, "Categoria inválida");

            var produto = _repositorioProduto.Recuperar(dto.Id);
            if(produto == null)
            {
                produto = new Produto(dto.Nome, categoria, dto.Preco);
                _repositorioProduto.Cadastrar(produto);
            }
            else
            {
                produto.Atualizar(dto.Nome, categoria, dto.Preco);  
            }
        }
    }
}