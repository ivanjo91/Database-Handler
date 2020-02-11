using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_FT_FB
{
    class Chat
    {
        int nMensaje;
        string nombre;
        string mensaje;
        DateTime fecha;

        public int NMensaje
        {
            get
            {
                return nMensaje;
            }

            set
            {
                nMensaje = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Mensaje
        {
            get
            {
                return mensaje;
            }

            set
            {
                mensaje = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public Chat(int nMensaje, string nombre, string mensaje, DateTime fecha)
        {
            this.NMensaje = nMensaje;
            this.Nombre = nombre;
            this.Mensaje = mensaje;
            this.Fecha = fecha;
        }

        public Chat()
        {

        }
    }
}
