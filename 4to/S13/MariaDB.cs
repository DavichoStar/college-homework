using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Administrador_de_Encuestas
{
    public class MariaDB
    {
        

        public static MySqlConnection ObtenerConexion()
        {
            string connectionString = "datasource = 127.0.0.1; port = 3306; database = encuestasdb; username = root; password =;";

            MySqlConnection conectar = new MySqlConnection(connectionString);

            conectar.Open();

            return conectar;
        }

        public static int AgregarPregunta(Encuesta pEncuesta)
        {
            string Format = "Insert into  encuestas(Id, FInicio, FFin, Pregunta) values(null, '{0}', '{1}', '{2}')";
            
            MySqlCommand comando = new MySqlCommand(string.Format(Format, pEncuesta.FInicio, pEncuesta.FFin, pEncuesta.Pregunta), ObtenerConexion());

            int retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static DataTable ObtenerPreguntas()
        {
            string Format = "SELECT * FROM encuestas";

            var comando = new MySqlCommand(Format, ObtenerConexion());
            var sqlda = new MySqlDataAdapter(comando);
            var dt = new DataTable();

            sqlda.Fill(dt);

            return dt;
        }

        public static List<Encuesta> Buscar(int pId = -1, string pFecha = "", string pPregunta = "")
        {
            List<Encuesta> _lista = new List<Encuesta>();

            string Format = "SELECT * FROM encuestas WHERE Id = '{0}' or FInicio ='{1}' or FFin ='{1}' or Pregunta = '{2}'";
            MySqlCommand _comando = new MySqlCommand(string.Format(Format, pId, pFecha, pPregunta), ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Encuesta pEncuesta = new Encuesta
                {
                    Id = _reader.GetInt32(0),
                    FInicio = _reader.GetString(1),
                    FFin = _reader.GetString(2),
                    Pregunta = _reader.GetString(3)
                };

                _lista.Add(pEncuesta);
            }

            return _lista;
        }
    }

    public class Encuesta
    {
        public int Id { get; set; }
        public string FInicio { get; set; }
        public string FFin { get; set; }
        public string Pregunta { get; set; }

        public Encuesta() { }

        public Encuesta(string pFInicio, string pFFin, string pPregunta)
        {
            this.FInicio= pFInicio;
            this.FFin = pFFin;
            this.Pregunta = pPregunta;

        }
    }
}
