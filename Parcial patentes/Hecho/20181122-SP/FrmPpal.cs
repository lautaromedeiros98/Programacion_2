using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        List<Thread> hilos;
        //List<Patente> lista; // = new List<Patente>();
        Queue<Patente> cola = new Queue<Patente>();

        public FrmPpal()
        {
            InitializeComponent();

            this.hilos = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.vistaPatente1.finExposicion += ProximaPatente;
            this.vistaPatente2.finExposicion += ProximaPatente;
            //lista.Add("ASD123".ValidarPatente());
            //lista.Add("AS123GH".ValidarPatente());
            //lista.Add("FUT952".ValidarPatente());
            //lista.Add("GAG005".ValidarPatente());
            //lista.Add("DIB009".ValidarPatente());
            //lista.Add("CP709WA".ValidarPatente());
            //lista.Add("TEV032".ValidarPatente());
            //lista.Add("RV003BJ".ValidarPatente());
            //lista.Add("PP805FG".ValidarPatente());
            //lista.Add("MUT315".ValidarPatente());
            //try
            //{
            //    Xml<List<Patente>> xml = new Xml<List<Patente>>();
            //    xml.Guardar("patentes.xml", lista);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                List<Patente> lista;
                Xml<List<Patente>> xml = new Xml<List<Patente>>();
                xml.Leer("patentes.xml", out lista);
                this.cola = new Queue<Patente>(lista.AsEnumerable().Reverse());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.IniciarSimulacion();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Texto txt = new Texto();
                txt.Leer("patentes.txt", out this.cola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.IniciarSimulacion();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            try
            {
                Sql sql = new Sql();
                sql.Leer("Patentes", out this.cola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.IniciarSimulacion();
        }

        private void IniciarSimulacion()
        {
            this.FinalizarSimulacion();
            this.ProximaPatente(this.vistaPatente1);
            this.ProximaPatente(this.vistaPatente2);
        }

        private void FinalizarSimulacion()
        {
            if (this.hilos != null)
            {
                foreach (Thread item in this.hilos)
                {
                    if (item.IsAlive)
                        item.Abort();
                }
            }
        }

        private void ProximaPatente(Patentes.VistaPatente vp)
        {
            if(this.cola.Count > 0)
            { 
                Thread t = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
                t.Start(this.cola.Dequeue());
                this.hilos.Add(t);
            }
        }
    }
}
