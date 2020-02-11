using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_FT_FB
{
    public partial class Form1 : Form
    {

        List<Chat> listaChat = new List<Chat>();
        ConectarBD cnx = new ConectarBD();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearFT_Click(object sender, EventArgs e)
        {
            listaChat = cnx.mostrarMensajes();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaChat;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Copia de seguridad en " + openFileDialog1.FileName.ToString());
                String nombreFichero = openFileDialog1.FileName.ToString();
                volcarLista_FicheroT(nombreFichero);
            }
        }

        private void volcarLista_FicheroT(string nombreFichero)
        {
            System.IO.StreamWriter wr = new System.IO.StreamWriter(nombreFichero);

            for(int i=0; i<listaChat.Count; i++)
            {
                String cadena = listaChat[i].NMensaje + "\t" + listaChat[i].Mensaje + "\t" 
                    + listaChat[i].Nombre + "\t" + listaChat[i].Fecha;
                wr.WriteLine(cadena);
            }
            wr.Close();
        }

        private void btnInsertBDFT_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String nombreFichero = openFileDialog1.FileName.ToString();
                System.IO.StreamReader sr = new System.IO.StreamReader(nombreFichero);

                while (sr.Peek()!=-1)
                {
                    String cadena = sr.ReadLine();
                    String[] tramos = cadena.Split('\t');
                    cnx.insertarBD(tramos[1], tramos[2], tramos[3]);
                }
            }
            
        }

        
        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ConectarBD cnx = new ConectarBD(txbServer.Text, txbBD.Text, txbUser.Text, txbPass.Text);
            List<String> listaTablas = new List<String>();
            String[,] arrayContenido;
            listaTablas = cnx.mostrarTablas();

            //Limpiar los flowlayout antes de rellenarlos
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();

            for(int i=0; i < listaTablas.Count; i++)
            {

                arrayContenido = cnx.mostrarContenido(listaTablas[i]);
                //Se crean dinamicamente listbox y datagridview
                ListBox listX = new ListBox();
                listX.HorizontalScrollbar = true;
                flowLayoutPanel1.Controls.Add(listX);
                DataGridView DGx = new DataGridView();
                flowLayoutPanel2.Controls.Add(DGx);
                //Descomponer la lista de contenidos
                //Obtener de la primera linea de listaContenidos los
                // nombres de los campos de la tabla


                for (int l = 0; l < arrayContenido.GetLength(1); l++)
                {
                    DGx.Columns.Add(arrayContenido[0, l], arrayContenido[0, l]);
                }

                for (int j = 0; j < arrayContenido.GetLength(0); j++)
                {
                    for (int k = 0; k < arrayContenido.GetLength(1); k++)
                    {
                        listX.Items.Add(arrayContenido[j, k]);
                        DGx.Rows.Add();
                        DGx.Rows[j].Cells[k].Value = arrayContenido[j, k];
                    }
                }
                //Quitar la primera fila para que no se repitan las cabeceras de las columnas
                DGx.Rows.RemoveAt(0);


                /*
                String[] tramos = listaContenidos[0].Split(';');
                for(int k=0; k < tramos.Length-1; k++)
                {
                    DGx.Columns.Add(tramos[k], tramos[k]);
                }

                for(int j=0; j<listaContenidos.Count; j++)
                {
                    //Para los listbox
                    listX.Items.Add(listaContenidos[j]);
                    //Para la tabla
                    String[] tramosContenidos = listaContenidos[j].Split(';');
                    //Crear en una tabla un row vacío con todos los campos
                    DGx.Rows.Add();
                    for (int k=0; k < tramosContenidos.Length - 1; k++)
                    {
                        DGx.Rows[j].Cells[k].Value = tramosContenidos[k];
                    }
                }
                DGx.Rows.RemoveAt(0);
                */
            }
            
        }

        private void btnCargarBD_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog abrirFichero = new OpenFileDialog();

            abrirFichero.Title = "Selecciona fichero de copia de seguridad";
            abrirFichero.Filter = "SQL fichero|*.sql";
            abrirFichero.InitialDirectory = @"C:\David\avanza\Desktop";

            String cadenaConexion = "Server=" + textBox1.Text + ";DataBase=" + textBox2.Text + ";Usuario=" + textBox3.Text + ";Pwd=" + textBox4.Text;


            if (abrirFichero.ShowDialog() == DialogResult.OK)
            {
                String nombreFichero = abrirFichero.FileName;


                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    using (MySqlCommand comando = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(comando))
                        {
                            comando.Connection = conexion;
                            conexion.Open();
                            mb.ImportFromFile(nombreFichero);
                            conexion.Close();

                            MessageBox.Show("Se ha importado la BD correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            
            
        }

        private void btnLanzarSql_Click(object sender, EventArgs e)
        {
            ConectarBD cnx = new ConectarBD(txbServer.Text, txbBD.Text, txbUser.Text, txbPass.Text);
            String cadenaSql = txbLanzarSql.Text;


            cnx.conexion.Open();
            cnx.comando = new MySqlCommand(cadenaSql, cnx.conexion);
            String tipoSql = cadenaSql.Substring(0, 6);

            if (tipoSql.Equals("select"))
            {
                cnx.resultadoConsulta = cnx.comando.ExecuteReader();
                int nColumnas = cnx.resultadoConsulta.FieldCount;
                int nFilas = 0;

                while (cnx.resultadoConsulta.Read())
                {
                    nFilas++;
                }

                cnx.conexion.Close();

                cnx.conexion.Open();
                cnx.comando = new MySqlCommand(cadenaSql, cnx.conexion);
                cnx.resultadoConsulta = cnx.comando.ExecuteReader();

                String[,] matrizTabla = new String[nFilas, nColumnas];

                int indiceFila = 0;
                while (cnx.resultadoConsulta.Read())
                {
                    for (int i = 0; i < nColumnas; i++)
                    {
                        if (indiceFila == 0)
                        {
                            matrizTabla[indiceFila, i] = Convert.ToString(cnx.resultadoConsulta.GetName(i));
                        }
                        else
                        {
                            matrizTabla[indiceFila, i] = Convert.ToString(cnx.resultadoConsulta.GetString(i));
                        }
                    }
                    indiceFila++;
                }

                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel2.Controls.Clear();
                ListBox listX = new ListBox();
                listX.HorizontalScrollbar = true;
                flowLayoutPanel1.Controls.Add(listX);
                DataGridView DGx = new DataGridView();
                flowLayoutPanel2.Controls.Add(DGx);
                
                
                for(int l=0; l<matrizTabla.GetLength(1); l++)
                {
                    DGx.Columns.Add(matrizTabla[0, l], matrizTabla[0, l]);
                }
                
                for (int j = 0; j < matrizTabla.GetLength(0); j++)
                {
                    for (int k = 0; k < matrizTabla.GetLength(1); k++)
                    {
                        listX.Items.Add(matrizTabla[j, k]);
                        DGx.Rows.Add();
                        DGx.Rows[j].Cells[k].Value = matrizTabla[j, k];
                    }
                }

                DGx.Rows.RemoveAt(0);

            }
            else
            {
                cnx.comando.ExecuteNonQuery();
            }

            cnx.conexion.Close();

        }
    }
}
