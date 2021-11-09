using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioSwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar(object sender, EventArgs e)
        {
            switch (textBoxDia.Text)
            {
                case "1":
                    labelResultado.Text = "Domingo";
                    break;
                case "2":
                    labelResultado.Text = "Segunda-Feira";
                    break;
                case "3":
                    labelResultado.Text = "Terça-Feira";
                    break;
                case "4":
                    labelResultado.Text = "Quarta-Feira";
                    break;
                case "5":
                    labelResultado.Text = "Quinta-Feira";
                    break;
                case "6":
                    labelResultado.Text = "Sexta-Feira";
                    break;
                case "7":
                    labelResultado.Text = "Sábado";
                    break;
                default:
                    labelResultado.Text = "Dia Inválido";
                    break;

            }
            /*if(textBoxDia.Text.Equals("1")){
                labelResultado.Text = "Domingo";

            }else if (textBoxDia.Text.Equals("2")){
                labelResultado.Text = "Segunda-Feira";
            }else if (textBoxDia.Text.Equals("3")){
                labelResultado.Text = "Terça-Feira";
            }else if (textBoxDia.Text.Equals("4")) {
                labelResultado.Text = "Quarta-Feira";
            }else if (textBoxDia.Text.Equals("5")) {
                labelResultado.Text = "Quinta-Feira";
            }else if (textBoxDia.Text.Equals("6")) {
                labelResultado.Text = "Sexta-Feira";
            }else if (textBoxDia.Text.Equals("7")) {
                labelResultado.Text = "Sábado";
            }else {
                labelResultado.Text = "Dia Inválido";
             }*/
        }
    }
}
