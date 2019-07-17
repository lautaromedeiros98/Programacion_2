using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(archivo, true))
            {
                foreach (Patente item in datos)
                {
                    file.WriteLine(item);
                }
            }
        }
        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            using (System.IO.StreamReader file = new System.IO.StreamReader(archivo))
            {
                while(!file.EndOfStream)
                {
                    try
                    {
                        datos.Enqueue(file.ReadLine().ValidarPatente());
                    }
                    catch (PatenteInvalidaException e)
                    { }
                }
            }
        }
    }
}
