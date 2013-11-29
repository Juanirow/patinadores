using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patinadores
{
    [Serializable]
    class Patinador
    {
        string nombre, escuela,estado,apellidos;
        int edad,numCompetidor;
        bool libre, combinado;

        public Patinador()
        {
            nombre = "";
            escuela = "";
            estado = "";
            edad = 0;
            apellidos = "";
            numCompetidor = 0;
            libre = false;
            combinado = false;
        }

        public Patinador(string nombre,string apellidos,string escuela,string estado,int edad,bool libre,bool combinado)
        {
            this.nombre = nombre;
            this.escuela = escuela;
            this.estado = estado;
            this.edad = edad;
            this.apellidos = apellidos;
            this.numCompetidor = 0;
            this.libre = libre;
            this.combinado = combinado;
        }

        /// <summary>
        /// Get y Set de Nombre
        /// </summary>
        public string Nombre{get{return nombre;}set{nombre=value;}}

        /// <summary>
        /// Get y Set de Apellidos
        /// </summary>
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }

        /// <summary>
        /// Get y Set de Escuela
        /// </summary>
        public string Escuela{get{return escuela;}set{escuela=value;}}

        /// <summary>
        /// Get y Set de Estado
        /// </summary>
        public string Estado{get{return estado;}set{estado=value;}}

        /// <summary>
        /// Get y Set de Edad
        /// </summary>
        public int Edad { get { return edad; } set { edad = value; } }

        /// <summary>
        /// Get y Set de Numero De Competidor
        /// </summary>
        public int Numero { get { return numCompetidor; } set { numCompetidor = value; } }

        public bool EstiloLibre { get { return libre; } set { libre = value; } }

        public bool EstiloCombinado { get { return combinado; } set { combinado = value; } }

    }
}
