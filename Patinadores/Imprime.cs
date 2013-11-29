using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace Patinadores
{
    class Imprime
    {
        Graphics g;
        DateTime date;
        static float anchoGeneral = 205;
        Font fuenteTitulo = new Font("Arial", 16);
        Font fuenteLetras = new Font("Arial", 12);
        Font fuenteSubtitulo = new Font("Arial", 14);
        Font fuenteTexto = new Font("Arial", 13);
        Brush brochaNegra = new SolidBrush(Color.Black);
        Brush brochaGris = new SolidBrush(Color.Gray);
        Categoria c;
        string nombreTorneo;
        static int altoGeneral = 255;
        bool stilo;
        string modalidad;

        public Imprime(System.Drawing.Printing.PrintPageEventArgs e, string nombreTorneo,Categoria c,DateTime date,bool libre,string modalidad)
        {
            g = e.Graphics;
            this.date = date;
            g.PageUnit = GraphicsUnit.Millimeter;
            this.c = c;
            this.nombreTorneo = nombreTorneo;
            stilo = libre;
            this.modalidad = modalidad;
        }

        public void ImprimeTorneo()
        {
            ImprimeFecha();
            imprimeTitulo();
            imprimePatinadores();

        }

        #region Imprecion de Fecha
            private void ImprimeFecha()
            {
                string fecha = obtenFecha();
                float posAncho, posAlto;
                PointF p;
                posAncho = anchoGeneral-anchoCadena(fuenteSubtitulo, fecha);
                posAlto = 5;
                p=new PointF(posAncho,posAlto);
                g.DrawString(fecha, fuenteSubtitulo, brochaNegra,p);
                
            }

            private string obtenFecha()
            {
                string cadema = "";
                
                cadema = date.Day.ToString() + "/" + getMes(date.Month) + "/" + date.Year +"  "+ date.Hour+":"+date.Minute+":"+date.Second;
                return 
                    cadema;
            }

            private string getMes(int valor)
            {
                string ret = valor.ToString();

                switch (valor)
                {
                    case 1:
                        ret = "Enero";
                        break;
                    case 2:
                        ret = "Febrero";
                        break;
                    case 3:
                        ret = "Marzo";
                        break;
                    case 4:
                        ret = "Abril";
                        break;
                    case 5:
                        ret = "Mayo";
                        break;
                    case 6:
                        ret = "Junio";
                        break;
                    case 7:
                        ret = "Julio";
                        break;
                    case 8:
                        ret = "Agosto";
                        break;
                    case 9:
                        ret = "Septiembre";
                        break;
                    case 10:
                        ret = "Octubre";
                        break;
                    case 11:
                        ret = "Noviembre";
                        break;
                    case 12:
                        ret = "Diciembre";
                        break;
                }
                return ret;
            }
        #endregion

        private void imprimeTitulo()
        {
            PointF p;
            string cadena;
            //nombre del torneo
            cadena = "Torneo: " + nombreTorneo;
            float xf = anchoGeneral / 2-(anchoCadena(fuenteTitulo,cadena)/2);
            float yf = 7;
            float alto = altoCadena(fuenteTitulo, cadena);
            p = new PointF(xf, yf);
            g.DrawString(cadena,fuenteTitulo,brochaNegra,p);

            //categoria
            p.Y += (alto+5);
            cadena=c.Nombre + " / " + modalidad;
            p.X = anchoGeneral / 2 - (anchoCadena(fuenteSubtitulo, cadena ) / 2);
            alto = altoCadena(fuenteSubtitulo, cadena);
            g.DrawString(cadena, fuenteSubtitulo, brochaNegra, p);

            //rama
            p.Y += (alto + 5);
            if (stilo)
                cadena = "Estilo Libre";
            else
                cadena = "Estilo Combinado";
            cadena = "Rama: " + c.Rama +" / " +cadena;
            p.X = anchoGeneral / 2 - (anchoCadena(fuenteSubtitulo, cadena) / 2);
            alto = altoCadena(fuenteSubtitulo, cadena);
            g.DrawString(cadena, fuenteSubtitulo, brochaNegra, p);
        }

        private void imprimePatinadores()
        {
            float posy=50;
            float inc=altoCadena(fuenteLetras, "hola") + 5;
            PointF p = new PointF();

            p.Y = posy;
            p.X = 5;
            g.DrawString("#", fuenteLetras, brochaGris, p);
            p.X = 20;
            g.DrawString("Nombre ", fuenteLetras, brochaGris, p);
            p.X = 70;
            g.DrawString("Apellidos ", fuenteLetras, brochaGris, p);
            p.X = 120;
            g.DrawString("Escuela ", fuenteLetras, brochaGris, p);
            p.X = 170;
            g.DrawString("Estado ", fuenteLetras, brochaGris, p);
            posy += inc;
            for (int i = 0; i < c.getNumPatinadores(stilo); i++)
            {
                g.DrawString((i+1).ToString(),fuenteLetras,brochaNegra,new PointF(5,posy));
                imprimePatinador(20, posy,c.getPatinadorAt(i,stilo).Nombre,65);
                imprimePatinador(70, posy, c.getPatinadorAt(i, stilo).Apellidos, 115);
                imprimePatinador(120, posy, c.getPatinadorAt(i, stilo).Escuela,165);
                imprimePatinador(170,  posy, c.getPatinadorAt(i, stilo).Estado, 220);
                posy += inc;
            }
        }

        private void imprimePatinador(float x, float y, string cadena,int limit)
        {
            float tam;
            tam = anchoCadena(fuenteLetras, cadena);
            while (tam+x >= limit)
            {
                cadena = cadena.Remove(cadena.Length - 5)+"...";
                tam = anchoCadena(fuenteLetras, cadena);
            }
            g.DrawString(cadena, fuenteLetras, brochaNegra, new PointF(x, y));
           
        }

       

        #region tamaños de Cadena
        private float anchoCadena(Font fuente, string texto)
        {
            return (float)g.MeasureString(texto, fuente).Width;
        }

            private float altoCadena(Font fuente, string texto)
        {
            return (float)g.MeasureString(texto, fuente).Height;
        }
        #endregion


    }
}
