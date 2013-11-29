using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patinadores
{
    [Serializable]
    class Categoria
    {
        string nombre;//nombre de la categoria
        string rama;//varonil o Juvenil
        List<Patinador> patinadoresL;
        List<Patinador> patinadoresC;

        /// <summary>
        /// Constructor de la Clase Categoria
        /// </summary>
        /// <param name="nombre">nombre de la categoria </param>
        /// <param name="rama">rama de la categoria (Varonil/Femenil)</param>
        public Categoria(string nombre,string rama)
        {
            this.nombre = nombre;
            this.rama=rama;
            patinadoresL = new List<Patinador>();
            patinadoresC = new List<Patinador>();
        }

        /// <summary>
        /// Get y Set de Nombre
        /// </summary>
        public string Nombre { get { return nombre; } set { nombre = value; } }

        /// <summary>
        /// Get y Set de Rama
        /// </summary>
        public string Rama { get { return rama; } set { rama = value; } }

        /// <summary>
        /// Regresa el numero de Patinadores en esta Categoria 
        /// </summary>
        /// <returns>numero de patinadores</returns>
        public int getNumPatinadores(bool libre)
        {
            if (libre)
                return patinadoresL.Count;
            else
                return patinadoresC.Count;
        }

        /// <summary>
        /// inserta el patinador en la lista de patinadores
        /// </summary>
        /// <param name="nombre">nomrbe del patinador</param>
        /// <param name="escuela">escuela de la que proviene</param>
        /// <param name="estado">estado al que pertenece</param>
        /// <param name="edad">edad del patinador</param>
        public void insertaPatinador(string nombre,string apellidos, string escuela, string estado, int edad,bool libre,bool combinado)
        {
            Patinador p = new Patinador(nombre,apellidos, escuela, estado, edad,libre,combinado);
            if (libre)
                patinadoresL.Add(p);
            if(combinado)
                patinadoresC.Add(p);
        }

        /// <summary>
        /// obtiene la lista de patinadores 
        /// </summary>
        /// <returns>regresa una lista de la clase patinador</returns>
        public List<Patinador> getPatinadores(bool libre) 
        {
            if (libre)
                return patinadoresL;
            else
                return patinadoresC;
        }

        /// <summary>
        /// Elimina un patinador de la lista
        /// </summary>
        /// <param name="id">posicion en la lista del patinador a eliminar</param>
        public void eliminaPatinador(int id, bool libre)
        {
            if (libre)
                patinadoresL.RemoveAt(id);
            else
                patinadoresC.RemoveAt(id);
        }

        /// <summary>
        /// elimina un patinador de la lista
        /// </summary>
        /// <param name="p">objeto patinador a eliminar</param>
        public void eliminaPatinador(Patinador p,bool libre)
        {
            if (libre)
                patinadoresL.Remove(p);
            else
                patinadoresC.Remove(p);
        }

        public Patinador getPatinadorAt(int pos,bool libre)
        {
            if (libre)
                return patinadoresL[pos];
            else
                return patinadoresC[pos];

        }

        public void sortPatinadores(bool libre)
        {
            if (libre)
            {
                int numPatinadores = patinadoresL.Count;
                List<Patinador> aux = new List<Patinador>();
                Random r = new Random();
                int pos;
                while (numPatinadores > 0)
                {
                    pos = r.Next(0, numPatinadores);
                    aux.Add(patinadoresL[pos]);
                    patinadoresL.RemoveAt(pos);
                    numPatinadores = patinadoresL.Count;
                }
                patinadoresL = aux;
            }
            else
            {
                int numPatinadores = patinadoresC.Count;
                List<Patinador> aux = new List<Patinador>();
                Random r = new Random();
                int pos;
                while (numPatinadores > 0)
                {
                    pos = r.Next(0, numPatinadores);
                    aux.Add(patinadoresC[pos]);
                    patinadoresC.RemoveAt(pos);
                    numPatinadores = patinadoresC.Count;
                }
                patinadoresC = aux;
            }
        }
    }
}