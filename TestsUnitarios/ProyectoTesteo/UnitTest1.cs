using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace ProyectoTesteo
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Estacionamiento e = new Estacionamiento(5);
      Assert.IsNotNull(e.Autos);
    }

    [TestMethod]
    public void EspacioEstacionamientoIncorrecto()
    {
      Estacionamiento e = new Estacionamiento(101);
      if(e.EspacioDisponible != 101)
      {
        Assert.Fail("Espacio incorrecto", e.EspacioDisponible);
      }

      Estacionamiento e2 = new Estacionamiento(0);
      Assert.AreNotEqual(e2.EspacioDisponible, 1);
      if(e2.EspacioDisponible != 0)
      {
        Assert.Fail("Mal indicado el limite inferior", e2.EspacioDisponible);
      }
    }

    [TestMethod]
    public void AgregarAutos()
    {
      Estacionamiento e = new Estacionamiento(2);
      Auto a1 = new Auto("ppp 531", ConsoleColor.Black);
      Auto a2 = new Auto("omp 021", ConsoleColor.Red);
      Auto a3 = new Auto("irp 588", ConsoleColor.Yellow);
      try
      {
        e += a1;
        e += a2;
        e += a3;
        Assert.Fail("Ingreso mas autos de lo devido", e);
      }
      catch(Exception a)
      {
        Assert.IsInstanceOfType(a,typeof(EstacionamientoLlenoException));
      }
    }

    [TestMethod]
    public void AgregarAutoEspacioDisponible()
    {
      Estacionamiento e = new Estacionamiento(2);
      Auto a1 = new Auto("ppp 531", ConsoleColor.Black);
      Auto a2 = new Auto("omp 021", ConsoleColor.Red);
      e += a1;
      Assert.AreEqual(e.EspacioDisponible, 1);
      e += a2;
      Assert.AreEqual(e.EspacioDisponible, 0);
    }
  }
}

