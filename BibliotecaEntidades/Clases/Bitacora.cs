using BibliotecaEntidades.AdministradoresSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ElementosDeBitacora
    {
        private string _vehiculo;
        private string _horarioSalida;
        private string _chofer;
        private int _dni;
        private string _horarioLlegada;
        private int _kmAnterior;
        private int _kmNuevo;

        public string Dominio { get { return _vehiculo; } private set { _vehiculo = value; } }

        public string HorarioSalida { get { return _horarioSalida; } private set { _horarioSalida = value; } }

        public string Chofer { get { return _chofer; } private set { _chofer = value; } }

        public int DNI { get { return _dni; } private set { _dni = value; } }

        public string HorarioLlegada { get { return _horarioLlegada; } private set { _horarioLlegada = value; } }

        public int KmAnterior { get { return _kmAnterior; } private set { _kmAnterior = value; } }

        public int KmNuevo { get { return _kmAnterior; } private set { _kmAnterior = value; } }


        public ElementosDeBitacora(string dominio, string salida, string nombreChofer, int dniChofer, string llegada, int kmAnterior, int kmNuevo)
        {
            Dominio = dominio;
            HorarioSalida = salida;
            Chofer = nombreChofer;
            DNI = dniChofer;
            HorarioLlegada = llegada;
            KmAnterior = kmAnterior;
            KmNuevo = kmNuevo;
        }
    }
}
