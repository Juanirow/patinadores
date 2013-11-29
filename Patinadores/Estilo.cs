using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patinadores
{
    [Serializable]
    class Estilo
    {
        protected List<Categoria> categoriasF;
        protected List<Categoria> categoriasV;
        public Estilo()
        {
            categoriasF = new List<Categoria>();
            categoriasV = new List<Categoria>();
        }

        public int getNumCategoriaFemenil()
        {
            return categoriasF.Count;
        }

        public Categoria getCategoriaFemenilAt(int index)
        {
            return categoriasF[index];
        }

        public int getNumCategoriaVaronil()
        {
            return categoriasV.Count;
        }

        public Categoria getCategoriaVaronilAt(int index)
        {
            return categoriasV[index];
        }

        /// <summary>
        /// Insertar un A la categoria que pertenece
        /// </summary>
        /// <param name="nombre">Nombre del patinador</param>
        /// <param name="escuela">Escuela de la que proviene</param>
        /// <param name="estado">estado ak que representa</param>
        /// <param name="edad">edad del patinador</param>
        /// <param name="categoria">categoria en la que concursara</param>
        /// <param name="rama">rama varonil/femenil</param>
        public void instertaPatinador(string nombre,string apellidos, string escuela, string estado, int edad, string categoria, string rama,bool combinado,bool libre)
        {
            int numCategoria = getPosCategoria(categoria);
            if (numCategoria != -1)
            {
                if (rama == "Femenil")
                    categoriasF[numCategoria].insertaPatinador(nombre,apellidos, escuela, estado, edad,libre,combinado);
                else if (rama == "Varonil")
                    categoriasV[numCategoria].insertaPatinador(nombre, apellidos, escuela, estado, edad, libre, combinado);
            }
        }

        /// <summary>
        /// regresa la posicion de la categoria en la lista
        /// </summary>
        /// <param name="categoria">nombre de la categoria</param>
        /// <returns>-1 si la categoria no existe si no regresa
        /// la posicion de la categoria en la lista</returns>
        public virtual int getPosCategoria(string categoria)
        {
            return -1;
        }

        /// <summary>
        /// regresa los patinadores de una categoria y rama en espicifico
        /// </summary>
        /// <param name="ramaFemenil">true si la rama es femenil</param>
        /// <param name="categoria">categoria de la cual se busca</param>
        /// <returns>una lista de patinadores de la categoria y rama deseada</returns>
        public List<Patinador> getPatinadores(bool ramaFemenil, string categoria,bool libre)
        {
            int numCategoria = getPosCategoria(categoria);
            if (numCategoria != -1)
            {
                if (ramaFemenil)
                    return categoriasF[numCategoria].getPatinadores(libre);
                else
                    return categoriasV[numCategoria].getPatinadores(libre);
            }
            return null;
        }

        /// <summary>
        /// elimina un patinador de la rama y categoria especificada
        /// </summary>
        /// <param name="ramaFemenil">true si pertenece a la rama femenil</param>
        /// <param name="categoria">categoria en la que participa </param>
        /// <param name="pos">posicion en a lista</param>
        public void eliminaPatinador(bool ramaFemenil,string categoria,int pos,bool libre)
        {
            int numCategoria = getPosCategoria(categoria);
            if (numCategoria != -1)
            {
                if (ramaFemenil)
                    categoriasF[numCategoria].eliminaPatinador(pos,libre);
                else
                    categoriasV[numCategoria].eliminaPatinador(pos,libre);
            }
        }

        /// <summary>
        /// elimina un patinador de la rama y categoria especificada
        /// </summary>
        /// <param name="ramaFemenil">true si pertenece a la rama femenil</param>
        /// <param name="categoria">categoria en la que participa </param>
        /// <param name="p">objeto patinador a eliminar</param>
        public void eliminaPatinador(bool ramaFemenil, string categoria, Patinador p,bool libre)
        {
            int numCategoria = getPosCategoria(categoria);
            if (numCategoria != -1)
            {
                if (ramaFemenil)
                    categoriasF[numCategoria].eliminaPatinador(p,libre);
                else
                    categoriasV[numCategoria].eliminaPatinador(p,libre);
            }
        }

        public Patinador getPatinadoraAt(bool ramaFemenil, string categoria, int pos,bool libre)
        {
            int numCategoria = getPosCategoria(categoria);
            if (numCategoria != -1)
            {
                if (ramaFemenil)
                    return categoriasF[numCategoria].getPatinadorAt(pos,libre);
                else
                    return categoriasV[numCategoria].getPatinadorAt(pos, libre);
            }
            return null;
        }

        public virtual void sortPatinadores(bool ramaFemenil, string categoria, bool libre)
        {
            int numCategoria = getPosCategoria(categoria);
            if(ramaFemenil)
                categoriasF[numCategoria].sortPatinadores(libre);
            else
                categoriasV[numCategoria].sortPatinadores(libre);
        }
    }
}
