using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patinadores
{
    [Serializable]
    class EstiloC : Estilo
    {
        

        public EstiloC()
        {
            categoriasF.Add(new Categoria("Infantil Menor", "Femenil"));
            categoriasF.Add(new Categoria("Infantil Mayor", "Femenil"));
            categoriasF.Add(new Categoria("Juvenil B", "Femenil"));
            categoriasF.Add(new Categoria("Juvenil", "Femenil"));
            categoriasF.Add(new Categoria("Libre", "Femenil"));

            categoriasV.Add(new Categoria("Infantil Menor", "Varonil"));
            categoriasV.Add(new Categoria("Infantil Mayor", "Varonil"));
            categoriasV.Add(new Categoria("Juvenil B", "Varonil"));
            categoriasV.Add(new Categoria("Juvenil", "Varonil"));
            categoriasV.Add(new Categoria("Libre", "Varonil"));
        }

        public override int getPosCategoria(string categoria)
        {
            int numCategoria = -1;
            switch (categoria)
            {
                case "Infantil Menor": numCategoria = 0; break;
                case "Infantil Mayor": numCategoria = 1; break;
                case "Juvenil B": numCategoria = 2; break;
                case "Juvenil": numCategoria = 3; break;
                case "Libre": numCategoria = 4; break;
            }
            return numCategoria;
        }

  
       
    }
}
