using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patinadores
{
    [Serializable]
    class Torneo
    {
        List<Estilo> estilos;
        string nombreTorneo;
        public Torneo(string nombreTorneo)
        {
            this.nombreTorneo = nombreTorneo;
            estilos = new List<Estilo>();
            estilos.Add(new EstiloC());
            estilos.Add(new EstiloD());
        }

        public List<Patinador> getPatinadores(bool estiloClasificados,string categoria,bool ramaFemenil,bool libre){
            int estilo=1;
            if (estiloClasificados)
                estilo = 0;
            return estilos[estilo].getPatinadores(ramaFemenil, categoria,libre);
        }

        public void InsertaPatinador(string nombre,string apellidos,string escuela,string estado,string categoria,int edad, bool estiloClasificados, bool ramaFemenil,bool libre,bool combinado)
        {
            int estilo = 1;
            if (estiloClasificados)
                estilo = 0;
            string rama="Varonil";
            if(ramaFemenil)
                rama="Femenil";
            estilos[estilo].instertaPatinador(nombre, apellidos, escuela, estado, edad, categoria, rama,combinado,libre);
        }


        public void eliminaPatinador(bool ramaFemenil, string categoria, int id,bool estiloClasificados,bool libre)
        {
            int estilo = 1;
            if (estiloClasificados)
                estilo = 0;
            estilos[estilo].eliminaPatinador(ramaFemenil, categoria, id,libre);
        }

        public void eliminaPatinador(bool ramaFemenil, string categoria, Patinador p, bool estiloClasificados,bool libre)
        {
            int estilo = 1;
            if (estiloClasificados)
                estilo = 0;
            estilos[estilo].eliminaPatinador(ramaFemenil, categoria, p,libre);
        }

        public Patinador getPatinadorAt(bool ramaFemenil, string categoria, int id, bool estiloClasificados,bool libre)
        {
            int estilo = 1;
            if (estiloClasificados)
                estilo = 0;
            return estilos[estilo].getPatinadoraAt(ramaFemenil, categoria, id,libre);
        }

        public string getNombreTorneo()
        {
            return nombreTorneo;
        }

        public void generaRandom(bool ramaFemenil, string categoria, bool estiloClasificados, bool libre)
        {
            int estilo = 1;
            if (estiloClasificados)
                estilo = 0;
            estilos[estilo].sortPatinadores(ramaFemenil,categoria,libre);
        }

        public int getNumCategoriasAtEstilo(bool isFemenil,int numEstilo)
        {
            if (isFemenil)
                return estilos[numEstilo].getNumCategoriaFemenil();
            else
                return estilos[numEstilo].getNumCategoriaVaronil();
        }

        public Categoria getCategoriasAtEstilo(int index, bool isFemenil, int numEstilo)
        {
            if (isFemenil)
                return estilos[numEstilo].getCategoriaFemenilAt(index);
            else
                return estilos[numEstilo].getCategoriaVaronilAt(index);
        }

        public int getPosCategoria(string categoria, bool estiloClasificados)
        {
            int estilo = 1;
            if (estiloClasificados)
                estilo = 0;
            return estilos[estilo].getPosCategoria(categoria);
        }
    }
}
