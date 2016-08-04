using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compilador
{
    public class CompiladorClass
    {
        const string Multiplicacion = "&Mlt";
        const string Divicion = "&Div";
        const string Sumar = "&Sum";
        const string Resta = "&Res";
        const string RaizCuadrada = "&Rac";
        const string Concatenar = "&Con";
        const string Imprimir = "&Pri";
        string Codigo;
        List<string> Variante = new List<string>();
        List<string> Valor = new List<string>();

        public CompiladorClass()
        {

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
                    Variante.Add(aux);
                    Valor.Add(aux2);
                    retorno = true;
                } while (variables.Length != variables.Length);
            }
            return retorno;
        }
         public void Compilacion(string texto)
        {
            bool varia = false;
            Codigo = texto;
            int menor;
            int mayor;
            menor = Codigo.IndexOf('<');
            mayor = Codigo.IndexOf('>');
            if (menor + 1 != mayor)
                varia = Variables();

            Codigo = Codigo.Substring(Codigo.IndexOf("&"));
            string Funcion = Codigo.Substring(0, 4);
            string Ejecucion = Codigo.Substring(4);

            if (Funcion == Sumar)
            {
                int Ap = Ejecucion.IndexOf("[");
                int CP = Ejecucion.IndexOf("]");
                int C = Ejecucion.IndexOf(",");
                double Num, Num1;
                int num1 = C;
                int num2 = CP - C;
                if (varia == true)
                {

                    Ejecucion = Ejecucion.Replace(Variante[0].ToString(), Valor[0].ToString());
                    Variante = new List<string>();
                    Valor = new List<string>();
                    Ap = Ejecucion.IndexOf("[");
                    CP = Ejecucion.IndexOf("]");
                    C = Ejecucion.IndexOf(",");
                    num1 = C;
                    num2 = CP - C;
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num + Num1).ToString(), "Compilador JAD");
                }
                else
                {
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num + Num1).ToString(), "Compilador JAD");
                }
            }
            else if (Funcion.Equals(Resta))
            {
                int Ap = Ejecucion.IndexOf("[");
                int CP = Ejecucion.IndexOf("]");
                int C = Ejecucion.IndexOf(",");
                double Num, Num1;
                int num1 = C;
                int num2 = CP - C;
                if (varia == true)
                {

                    Ejecucion = Ejecucion.Replace(Variante[0].ToString(), Valor[0].ToString());
                    Variante = new List<string>();
                    Valor = new List<string>();
                    Ap = Ejecucion.IndexOf("[");
                    CP = Ejecucion.IndexOf("]");
                    C = Ejecucion.IndexOf(",");
                    num1 = C;
                    num2 = CP - C;
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num - Num1).ToString(), "Compilador JAD");
                }
                else
                {
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num - Num1).ToString());
                }
            }
            else if (Funcion.Equals(Multiplicacion))
            {
                int Ap = Ejecucion.IndexOf("[");
                int CP = Ejecucion.IndexOf("]");
                int C = Ejecucion.IndexOf(",");
                double Num, Num1;
                int num1 = C;
                int num2 = CP - C;
                if (varia == true)
                {

                    Ejecucion = Ejecucion.Replace(Variante[0].ToString(), Valor[0].ToString());
                    Variante = new List<string>();
                    Valor = new List<string>();
                    Ap = Ejecucion.IndexOf("[");
                    CP = Ejecucion.IndexOf("]");
                    C = Ejecucion.IndexOf(",");
                    num1 = C;
                    num2 = CP - C;
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num * Num1).ToString(), "Compilador JAD");
                }
                else
                {
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num * Num1).ToString(), "Compilador JAD");
                }
            }
            else if (Funcion.Equals(Divicion))
            {
                int Ap = Ejecucion.IndexOf("[");
                int CP = Ejecucion.IndexOf("]");
                int C = Ejecucion.IndexOf(",");
                double Num, Num1;
                int num1 = C;
                int num2 = CP - C;
                if (varia == true)
                {

                    Ejecucion = Ejecucion.Replace(Variante[0].ToString(), Valor[0].ToString());
                    Variante = new List<string>();
                    Valor = new List<string>();
                    Ap = Ejecucion.IndexOf("[");
                    CP = Ejecucion.IndexOf("]");
                    C = Ejecucion.IndexOf(",");
                    num1 = C;
                    num2 = CP - C;
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num / Num1).ToString(), "Compilador JAD");
                }
                else
                {
                    double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                    double.TryParse((Ejecucion.Substring((C + 1), (num2 - 1))), out Num1);
                    MessageBox.Show((Num / Num1).ToString(), "Compilador JAD");
                }
            }
            else if (Funcion.Equals(RaizCuadrada))
            {
                int Ap = Ejecucion.IndexOf("[");
                int CP = Ejecucion.IndexOf("]");
                double Num;
                int num1 = CP;
                double.TryParse((Ejecucion.Substring(1, (num1 - 1))), out Num);
                MessageBox.Show((Math.Sqrt(Num)).ToString(), "Compilador JAD");

            }
            else if (Funcion.Equals(Concatenar))
            {
                int Ap = Ejecucion.IndexOf("[");
                int CP = Ejecucion.IndexOf("]");
                int C = Ejecucion.IndexOf(",");
                int num1 = C;
                int num2 = CP - C;
                string s1 = Ejecucion.Substring(1, (num1 - 1));
                string s2 = Ejecucion.Substring((C + 1), (num2 - 1));
                MessageBox.Show(string.Concat(s1, s2));
            }
            else if (Funcion.Equals(Imprimir))
            {
                int Ap = Ejecucion.IndexOf("[");
                int CP = Ejecucion.IndexOf("]");
                MessageBox.Show(Ejecucion.Substring(1, (CP - 1)), "Compilador JAD");
            }
            else
            {
                MessageBox.Show("Error de Compilacion \n Verifique el codigo.", "Compilador JAD",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
