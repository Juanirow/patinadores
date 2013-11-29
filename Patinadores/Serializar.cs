using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Patinadores
{
    static class Serializar
    {
        public static string ruta = @"C:\Patinaje";

        public static bool crearDirectorio(string nombreDirectorio)
        {
            string directorio = Serializar.ruta + @"\" + nombreDirectorio;
            try
            {
                if (!System.IO.Directory.Exists(directorio))
                {
                    System.IO.Directory.CreateDirectory(directorio);
                    Torneo t = new Torneo(nombreDirectorio);
                    serializaTorneo(t);
                }
                else
                    return false;
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }


        public static bool crearDirectorioInicial()
        {
            string directorio = Serializar.ruta;
            try
            {
                if (!System.IO.Directory.Exists(directorio))
                {
                    System.IO.Directory.CreateDirectory(directorio);
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public static void  eliminaDirectorio(string nombreDirectorio){
            string directorio = Serializar.ruta + @"\" + nombreDirectorio;
            System.IO.Directory.Delete(directorio, true);
        }

        public static bool existeDirectorio(string nombreDirectorio)
        {
            string directorio = Serializar.ruta + @"\" + nombreDirectorio;
            try
            {
                return System.IO.Directory.Exists(directorio);
               
            }
            catch (Exception e)
            {
                return true;
            }
        }

        public static void serializaTorneo(Torneo t)
        {
            string nombreArchivo;
            IFormatter formater = new BinaryFormatter();
            nombreArchivo = ruta + @"\" + t.getNombreTorneo() + @"\" + t.getNombreTorneo() + ".pt";
            Stream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None);
            formater.Serialize(stream, t);
            stream.Close();
        }

        public static Torneo desealizaTorneo(string nombreArchivo)
        {
            Torneo t = null ;
            IFormatter formater = new BinaryFormatter();
            Stream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read, FileShare.Read);
            try {
                t = (Torneo)formater.Deserialize(stream);
            }
            catch { }
            stream.Close();
            return t;

        }

    }
}
