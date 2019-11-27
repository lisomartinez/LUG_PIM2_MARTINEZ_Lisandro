using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Repositorio
{
    public class SqlAdaptador
    {
        private static SqlAdaptador _instance;
        private string connectionString = "Data Source=DESKTOP-6DRD56B;Initial Catalog=biblioteca;Integrated Security=True";
        private SqlConnection _connection;
        private SqlTransaction _transaction;

        public static SqlAdaptador Instance => _instance ?? (_instance = new SqlAdaptador());

        private SqlAdaptador()
        {
        }

        private void Abrir()
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();

        }

        private void Cerrar()
        {
            _connection.Close();
            _connection.Dispose();
            _connection = null;
        }


        public DataTable Leer(string query, Dictionary<string, object> parametros = null)
        {
            var table = new DataTable();
            try
            {
                Abrir();
                _transaction = _connection.BeginTransaction();
                var adapter = new SqlDataAdapter( crearComando(query, parametros));
                adapter.Fill(table);
                _transaction.Commit();
            }
            catch (Exception e)
            {
                _transaction.Rollback();
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Cerrar();
            }

            return table;
        }

        private SqlCommand crearComando(string query, Dictionary<string, object> parametros)
        {
            var cmd = _connection.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Transaction = _transaction;
            parametros?.Keys
                .ToList()
                .ForEach(nombre => 
                    cmd.Parameters.AddWithValue(nombre, parametros[nombre]));
            return cmd;
        }

        public bool Escribir(string query, Dictionary<string, object> parametros)
        {
            try
            {
                Abrir();
                _transaction = _connection.BeginTransaction();
                var cmd = crearComando(query, parametros);
                var escrito = cmd.ExecuteNonQuery();
                _transaction.Commit();
                return escrito != -1;
            }
            catch (Exception e)
            {
                _transaction.Rollback();
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                Cerrar();
            }
            
        }
    }
}