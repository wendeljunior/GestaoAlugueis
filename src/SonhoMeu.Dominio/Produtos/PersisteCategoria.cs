using SonhomeMeu.Dominio.Dto;
using SonhomeMeu.Dominio.Produtos;

namespace SonhomeMeu.Dominio
{
    public class PersisteCategoria 
    {
        private readonly IRepositorio<Categoria> _repositorioCategoria;

        public PersisteCategoria(IRepositorio<Categoria> repositorioCategoria)
        {
            _repositorioCategoria = repositorioCategoria;
        }

        public void Persistir(DtoCategoria dto)
        {
            var categoria = _repositorioCategoria.Recuperar(dto.Id);

            if(categoria == null)
            {
                categoria = new Categoria(dto.Nome);
                _repositorioCategoria.Cadastrar(categoria);
            }
            else   
            {
                categoria.Atualizar(dto.Nome);
            }
        }
    }
}