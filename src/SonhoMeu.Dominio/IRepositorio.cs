namespace SonhomeMeu.Dominio
{
    public interface IRepositorio<TEntity>
    {
        TEntity Recuperar(int id);
        void Cadastrar(TEntity entidade);
    }
}