using System;
using Entidades.Autores;

namespace UI.Autores
{
    public class AutorDuplicadoException : Exception
    {
        public override string Message { get; }

        public AutorDuplicadoException(Autor autor)
        {
            Message = $"El autor se encuentra duplicado. Autor nro: {autor.Numero}";
        }
    }
}