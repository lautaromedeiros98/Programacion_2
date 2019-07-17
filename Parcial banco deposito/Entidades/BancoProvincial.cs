using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BancoProvincial:BancoNacional
    {
        public string provincia;

        public BancoProvincial(BancoNacional b,string provincia):base(b.nombre,b.pais)
        {
            this.provincia = provincia;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BancoProvincia");
            return sb.ToString();
        }
    }
}
