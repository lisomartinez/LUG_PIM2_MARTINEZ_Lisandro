using System.Collections.Generic;
using System.Data;

namespace Repositorio
{
    public class SqlAdaptador
    {
        public DataTable Leer(string query, Dictionary<string, object> parametros)
        {
            var table = new DataTable();
            return table;
        }

        public bool Escribir(string query, Dictionary<string, object> parametros)
        {
            return false;
        }
    }
}