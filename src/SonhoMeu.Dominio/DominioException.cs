using System;

namespace SonhomeMeu.Dominio
{
    public class DominioException : Exception
    {
        public DominioException(string erro) : base(erro)
        {

        }
        public static void When(bool hasError, string erro)
        {
            if(hasError)
                throw new DominioException(erro);
        }
    }
}