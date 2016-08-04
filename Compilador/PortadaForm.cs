using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compilador
{
    public partial class PortadaForm : Form
    {
        CompiladorClass compilador = new CompiladorClass();
        public PortadaForm()
        {
            InitializeComponent();
        }

        const string Multiplicar = "#mul";
        const string Sumar = "#sum";
        const string Dividir = "#div";
        const string Restar = "#res";
        const string Porcentaje = "#por";
        const string RaizCuadrada = "#rac";
        const string Concatenar = "#con";
        const string Imprimir = "#imp";
        string Codigo;
        List<string> Varia = new List<string>();
        List<string> Valor = new List<string>();

       

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = " Este compilador fue creado con fines educativos, por:\n \r Jose M. Chavez Ortiz [2013-0747], \r Denninson Liriano Adino[2013-0707], \r Adolfo Sanches[2013-0302].";
            MessageBox.Show(mensaje, "Compilador JAD");
        }

       

        private void compilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            compilador.Compilacion(CompiladortextBox.Text);
        }

        private void correrToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            compilador.Compilacion(CompiladortextBox.Text);
        }

        private void compilarYCorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PortadaForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            compilador.Compilacion(CompiladortextBox.Text);
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            AyudaForm ayuda = new AyudaForm();
            ayuda.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompiladortextBox.Clear();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Compilar();
            compilador.Compilacion(CompiladortextBox.Text);
        }

        private void acercaDeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AcercaDeForm acer = new AcercaDeForm();
            acer.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
