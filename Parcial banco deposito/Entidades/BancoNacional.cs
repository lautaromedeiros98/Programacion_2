using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BancoNacional:Banco
    {
        public string pais;

        public BancoNacional(string nombre, string pais):base(nombre)
        {
            this.pais = pais;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BancoNacional");
            return sb.ToString();
        }

        public override string Mostrar(Banco e)
        {
            StringBuilder sb = new StringBuilder();
            if (e is BancoMunicipal)
            {
                sb.AppendLine("Nombre" + ((BancoMunicipal)e).nombre);
                sb.AppendLine("Pais" + ((BancoMunicipal)e).pais);
                sb.AppendLine("Provincia" + ((BancoMunicipal)e).provincia);
                sb.AppendLine("Municipio" + ((BancoMunicipal)e).municipio);
            }
            else if(e is BancoProvincial)
            {
                sb.AppendLine("Nombre" + ((BancoProvincial)e).nombre);
                sb.AppendLine("Pais" + ((BancoProvincial)e).pais);
                sb.AppendLine("Provincia" + ((BancoProvincial)e).provincia);
            }
            else if(e is BancoNacional)
            {
                sb.AppendLine("Nombre" + ((BancoNacional)e).nombre);
                sb.AppendLine("Pais :" + ((BancoNacional)e).pais);
            }
           return sb.ToString();
        }
    }
}
