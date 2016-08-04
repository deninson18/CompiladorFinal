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
        public PortadaForm()
        {
            InitializeComponent();
        }

        const string Multiplicar = "#mul";
        const string Dividir = "#div";
        const string Sumar = "#sum";
        const string Restar = "#res";
        const string Porcentaje = "#por";
        const string RaizCuadrada = "#rac";
        const string Concatenar = "#con";
        const string Imprimir = "#imp";
        string Codigo;
        List<string> Var = new List<string>();
        List<string> Val = new List<string>();
        
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Este es un compilador como proyecto final de la materia Lenguaje de Programacion";
            MessageBox.Show(mensaje);
        }

        private void acercaDeNosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Compilador Version: 1.0.0";
            MessageBox.Show(mensaje);
        }

        public bool Variables()
        {
            bool retorno = false;
            int menor = 0;
            int mayor = 0;
            int indice = 0;
            string aux, aux2; ;
            string variables;
            menor = Codigo.IndexOf('<');
            mayor = Codigo.IndexOf('>');
            if (menor != -1 || mayor != -1)
            {
                variables = Codigo.Substring(menor + 1, mayor - 1);
                
                do
                {
                    indice = variables.IndexOf(";");
                    aux = variables.Substring(0, indice);
                    variables = variables.Substring(indice);
                    menor = aux.IndexOf('=');
                    mayor = aux.Length;
                    aux2 = aux.Substring(menor + 1);
                    menor -= 4;
                    aux = aux.Substring(4, menor);
                    Var.Add(aux);
                    Val.Add(aux2);
                    retorno = true;
                } while (variables.Length != variables.Length);
            }
            return retorno;
        }



        void Compilar()
        {
            bool varia = false;
            Codigo = CompiladortextBox.Text;
            int menor;
            int mayor;
            menor = Codigo.IndexOf('<');
            mayor = Codigo.IndexOf('>');
            if (menor + 1 != mayor)
                varia = Variables();

            Codigo = Codigo.Substring(Codigo.IndexOf("#"));
            string Funcion = Codigo.Substring(0, 4);
            string Ejecucion = Codigo.Substring(4);

            if (Funcion == Sumar)
            {
                int Ap = Ejecucion.IndexOf("(");
                int CP = Ejecucion.IndexOf(")");
                int C = Ejecucion.IndexOf(",");
                double Num, Num1;
                int num1 = C;
                int num2 = CP - C;
                if (varia == true)
                {

                    Ejecucion = Ejecucion.Replace(Var[0].ToString(), Val[0].ToString());
                    Var = new List<string>();
                    Val = new List<string>();
                    Ap = Ejecucion.IndexOf("(");
                    CP = Ejecucion.IndexOf(")");
                    C = Ejecucion.IndexOf(",");
                    num1 = C;
                    num2 = CP - C;
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num + Num1).ToString());
                }
                else
                {
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num + Num1).ToString());
                }
            }
            else if (Funcion == Restar)
            {
                int Ap = Ejecucion.IndexOf("(");
                int CP = Ejecucion.IndexOf(")");
                int C = Ejecucion.IndexOf(",");
                double Num, Num1;
                int num1 = C;
                int num2 = CP - C;
                if (varia == true)
                {

                    Ejecucion = Ejecucion.Replace(Var[0].ToString(), Val[0].ToString());
                    Var = new List<string>();
                    Val = new List<string>();
                    Ap = Ejecucion.IndexOf("(");
                    CP = Ejecucion.IndexOf(")");
                    C = Ejecucion.IndexOf(",");
                    num1 = C;
                    num2 = CP - C;
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num - Num1).ToString());
                }
                else
                {
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num - Num1).ToString());
                }
            }
            else if (Funcion == Multiplicar)
            {
                int Ap = Ejecucion.IndexOf("(");
                int CP = Ejecucion.IndexOf(")");
                int C = Ejecucion.IndexOf(",");
                double Num, Num1;
                int num1 = C;
                int num2 = CP - C;
                if (varia == true)
                {

                    Ejecucion = Ejecucion.Replace(Var[0].ToString(), Val[0].ToString());
                    Var = new List<string>();
                    Val = new List<string>();
                    Ap = Ejecucion.IndexOf("(");
                    CP = Ejecucion.IndexOf(")");
                    C = Ejecucion.IndexOf(",");
                    num1 = C;
                    num2 = CP - C;
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num * Num1).ToString());
                }
                else
                {
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num * Num1).ToString());
                }
            }
            else if (Funcion == Dividir)
            {
                int Ap = Ejecucion.IndexOf("(");
                int CP = Ejecucion.IndexOf(")");
                int C = Ejecucion.IndexOf(",");
                double Num, Num1;
                int num1 = C;
                int num2 = CP - C;
                if (varia == true)
                {

                    Ejecucion = Ejecucion.Replace(Var[0].ToString(), Val[0].ToString());
                    Var = new List<string>();
                    Val = new List<string>();
                    Ap = Ejecucion.IndexOf("(");
                    CP = Ejecucion.IndexOf(")");
                    C = Ejecucion.IndexOf(",");
                    num1 = C;
                    num2 = CP - C;
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num / Num1).ToString());
                }
                else
                {
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num / Num1).ToString());
                }
            }
            else if (Funcion == Porcentaje)
            {
                int Ap = Ejecucion.IndexOf("(");
                int CP = Ejecucion.IndexOf(")");
                int C = Ejecucion.IndexOf(",");
                double Num;
                int num1 = C;
                int num2 = CP - C;
                double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                int.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out num2);
                MessageBox.Show(((Num * num2) / 100).ToString());
            }
            else if (Funcion == RaizCuadrada)
            {
                int Ap = Ejecucion.IndexOf("(");
                int CP = Ejecucion.IndexOf(")");
                double Num;
                int num1 = CP;
                double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                MessageBox.Show((Math.Sqrt(Num)).ToString());

            }
            else if (Funcion == Concatenar)
            {
                int Ap = Ejecucion.IndexOf("(");
                int CP = Ejecucion.IndexOf(")");
                int C = Ejecucion.IndexOf(",");
                int num1 = C;
                int num2 = CP - C;
                string s1 = Ejecucion.Substring(1, (num1 - 1));
                string s2 = Ejecucion.Substring((C + 1), (num2 - 1));
                MessageBox.Show(string.Concat(s1, s2));
            }
            else if (Funcion == Imprimir)
            {
                int Ap = Ejecucion.IndexOf("(");
                int CP = Ejecucion.IndexOf(")");
                MessageBox.Show(Ejecucion.Substring(1, (CP - 1)));
            }
            else
            {
                MessageBox.Show("El formato no es Correcto!! \n Verifique el codigo.");
            }

        }

        private void compilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compilar();
        }

        private void correrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compilar();
        }

        private void compilarYCorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compilar();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompiladortextBox.Text = @"|";
        }

        private void PortadaForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Compilar();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AcercaDeForm acer = new AcercaDeForm();
            acer.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaForm ayuda = new AyudaForm();
            ayuda.Show();
        }
    }
}
