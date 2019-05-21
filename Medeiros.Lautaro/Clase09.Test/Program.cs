using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;
using Libreria;

namespace Clase09.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Lavadero lavadero = new Lavadero(100, 50, 70);

      Auto auto = new Auto("ABC 123", Emarca.Fiat, 4,4);
      Moto moto = new Moto("PPD 222", Emarca.Honda, 2, 2);
      Camion camion = new Camion("AQA 391", Emarca.Iveco, 4, 4);
      Auto auto2 = new Auto("QBC 123", Emarca.Ford , 4, 4);
      Moto moto2 = new Moto("WPP 222", Emarca.Zanella , 2, 2);
      Camion camion2 = new Camion("EAA 4321", Emarca.Iveco, 4, 4);

      lavadero += auto;
      lavadero += camion;
      lavadero += moto;
      lavadero += auto2;
      lavadero += camion2;
      lavadero += moto2;

      Console.WriteLine(lavadero.MiLavadero);
      Console.WriteLine("TOTAL FACTURADO");
      Console.WriteLine(lavadero.MostrarTotalFacturado());
      Console.WriteLine("TOTAL FACTURADO POR AUTOS");
      Console.WriteLine(lavadero.MostrarTotalFacturado(EVehiculo.Auto));
      Console.WriteLine("\n \n");
      Console.ReadKey();
      Console.Clear();

      Console.WriteLine("**ORDENO POR PATENTE**");
      lavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
      Console.WriteLine(lavadero.MiLavadero);
      Console.ReadKey();
      Console.Clear();

      Console.WriteLine("**ORDENO POR MARCAS**");
      lavadero.Vehiculos.Sort(lavadero.OrdenarVehiculosPorMarca);
      Console.WriteLine(lavadero.MiLavadero);
      Console.ReadKey();
      Console.Clear();


      Console.WriteLine("**QUITO VEHICULOS**");
      lavadero -= auto;
      lavadero -= auto2;
      Console.WriteLine(lavadero.MiLavadero);
      Console.ReadKey();
      Console.Clear();
    }
  }
}
