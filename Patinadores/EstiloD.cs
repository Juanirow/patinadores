using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patinadores
{
    [Serializable]
    class EstiloD : Estilo
    {
        public EstiloD()
        {
            categoriasF.Add(new Categoria("Micro", "Femenil"));
            categoriasF.Add(new Categoria("Mini", "Femenil"));
            categoriasF.Add(new Categoria("Infantil Menor", "Femenil"));
            categoriasF.Add(new Categoria("Infantil Mayor", "Femenil"));
            categoriasF.Add(new Categoria("Juvenil", "Femenil"));
            categoriasF.Add(new Categoria("Open", "Femenil"));

            categoriasV.Add(new Categoria("Micro", "Varonil"));
            categoriasV.Add(new Categoria("Mini", "Varonil"));
            categoriasV.Add(new Categoria("Infantil Menor", "Varonil"));
            categoriasV.Add(new Categoria("Infantil Mayor", "Varonil"));
            categoriasV.Add(new Categoria("Juvenil", "Varonil"));
            categoriasV.Add(new Categoria("Open", "Varonil"));

        }

        /// <summary>
        /// regresa la posicion de la categoria en la lista
        /// </summary>
        /// <param name="categoria">nombre de la categoria</param>
        /// <returns>-1 si la categoria no existe si no regresa 
        /// la posicion de la categoria en la lista</returns>
        public override int getPosCategoria(string categoria)
        {
            int numCategoria = -1;
            switch (categoria)
            {
                case "Micro": numCategoria = 0; break;
                case "Mini": numCategoria = 1; break;
                case "Infantil Menor": numCategoria = 2; break;
                case "Infantil Mayor": numCategoria = 3; break;
                case "Juvenil": numCategoria = 4; break;
                case "Open": numCategoria = 5; break;
            }
            return numCategoria;
        }

      
    }
}
