using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace BD_FT_FB
{
    class ConectarBD
    {
        public MySqlConnection conexion;
        public MySqlCommand comando;
        public MySqlDataReader resultadoConsulta;
        List<Chat> listaChat = new List<Chat>();
       

        public ConectarBD()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "server=remotemysql.com;Database=Pr1mdxAdrh;Uid=Pr1mdxAdrh;Pwd=fNBUrxid1O";
        }

        public ConectarBD(String server, String bd, String user, String pass)
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=" + server + ";Port=3306;DataBase=" + bd + ";Uid=" + user + ";Pwd=" + pass;
        }

        public List<Chat> mostrarMensajes()
        {
            conexion.Open();
            String cadenaSql = "select * from chat order by 4 desc";
            listaChat.Clear();
            comando = new MySqlCommand(cadenaSql, conexion);
            resultadoConsulta = comando.ExecuteReader();

            while (resultadoConsulta.Read())
            {
                Chat ch = new Chat();
                ch.NMensaje = Convert.ToInt16(resultadoConsulta["NMensaje"]);
                ch.Nombre = Convert.ToString(resultadoConsulta["usuario"]);
                ch.Mensaje = Convert.ToString(resultadoConsulta["texto"]);
                ch.Fecha = Convert.ToDateTime(resultadoConsulta["fecha"]);
                listaChat.Add(ch);
            }
            conexion.Close();
            return listaChat;
        }

        internal void insertarBD(string v1, string v2, string v3)
        {
            String cadenaSql = "insert into chat value(nMensaje, ?texto, ?usuario, ?fecha)";
            conexion.Open();
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.Parameters.Add("?texto", MySqlDbType.String).Value = v1;
            comando.Parameters.Add("?usuario", MySqlDbType.String).Value = v2;
            comando.Parameters.Add("?fecha", MySqlDbType.DateTime).Value = Convert.ToDateTime(v3);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        internal void truncar()
        {
            String cadenaSql = "truncate chat";
            conexion.Open();
            comando = new MySqlCommand(cadenaSql, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public List<string> mostrarTodo()
        {
            List<String> listaTotal = new List<String>();
            List<String> listaTablas = new List<String>();
            conexion.Open();
            String cadenaSql = "show tables";
            comando = new MySqlCommand(cadenaSql, conexion);
            MySqlDataReader tablas = comando.ExecuteReader();
            while (tablas.Read())
            {
                String nombreTabla = Convert.ToString(tablas[0]);
                listaTablas.Add(nombreTabla);
            }
            conexion.Close();

            
            for(int i=0; i<listaTablas.Count; i++)
            {
                conexion.Open();
                String cadenaSql2 = "select * from " + listaTablas[i];
                comando = new MySqlCommand(cadenaSql2, conexion);
                MySqlDataReader contenido = comando.ExecuteReader();
                listaTotal.Add("******************");
                listaTotal.Add(listaTablas[i]);
                listaTotal.Add("__________________");

                String nombreCampos = "";
                for (int k = 0; k < contenido.FieldCount; k++)
                {
                    nombreCampos += contenido.GetName(k) + "\t";
                }
                listaTotal.Add(nombreCampos);

                while (contenido.Read())
                {
                    

                    String cadena = "";
                    for(int j=0; j<contenido.FieldCount; j++)
                    {
                        cadena += contenido[j].ToString() + "\t";
                        
                    }
                    listaTotal.Add(cadena);
                }
                conexion.Close();
            }
            
            return listaTotal;
        }

        public List<string> mostrarTablas()
        {
            //Obtener tablas de la BD
            List<String> listaTablas = new List<String>();

            conexion.Open();
            comando = new MySqlCommand("show tables", conexion);
            resultadoConsulta = comando.ExecuteReader();
            

            while (resultadoConsulta.Read())
            {
                listaTablas.Add(resultadoConsulta.GetString(0));
            }
            conexion.Close();
            return listaTablas;
        }

        public String[,] mostrarContenido(String tablaX)
        {
            //Obtener numero de filas
            conexion.Open();
            String cadenaSql = "select count(*) from " + tablaX + ";";
            comando = new MySqlCommand(cadenaSql, conexion);
            int nFilas = Convert.ToInt32(comando.ExecuteScalar());
            conexion.Close();


            //Obtener campos y registros de cada tabla
            conexion.Open();
            cadenaSql = "select * from " + tablaX + ";" ;
            comando = new MySqlCommand(cadenaSql, conexion);
            resultadoConsulta = comando.ExecuteReader();
            int nColumnas = resultadoConsulta.FieldCount;


            String[,] matrizTabla = new String[nFilas, nColumnas];

            int indiceFila = 0;
            while(resultadoConsulta.Read())
            {
                for(int i=0; i<nColumnas; i++)
                {
                    if (indiceFila == 0)
                    {
                        matrizTabla[indiceFila, i] = Convert.ToString(resultadoConsulta.GetName(i));
                    }
                    else
                    {
                        matrizTabla[indiceFila, i] = Convert.ToString(resultadoConsulta.GetString(i));
                    }
                }
                indiceFila++;
            }

            /*
            String cadena = null;
            //Componer la cabecera con los nombre de los campos
            for(int j=0; j < ncolumnas; j++)
            {
                cadena += Convert.ToString(resultadoConsulta.GetName(j)) + ";";
            }
            lista.Add(cadena);
            //Resto de la información, datos de la tabla
            while (resultadoConsulta.Read())
            {
                cadena = null;
                for(int i=0; i < ncolumnas; i++)
                {
                    cadena += Convert.ToString(resultadoConsulta[i]) + ";";
                    lista.Add(cadena);
                }
            }
            */
            conexion.Close();
            return matrizTabla;
        }
        
    }
}
