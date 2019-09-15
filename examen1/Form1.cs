using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtnota1.Text);
            double nota2 = double.Parse(txtnota2.Text);
            double nota3 = double.Parse(txtnota3.Text);
                double nota4 = double.Parse(txtnota4.Text);
            double nota5 = double.Parse(txtnota5.Text);
            double total = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            if (total <=1) {
                MessageBox.Show("Reprueba la materia sin lograr realizar proceso de recuperación.");
                lblnota.Text = total.ToString();
            }

            else {
                if (total<=2.9) {
                    MessageBox.Show("Reprueba la materia y puede hacer la habilitación");
                    lblnota.Text = total.ToString();
                }
                else {
                    if (total<=3.9) {
                        MessageBox.Show("Aprueba la materia con plan de mejora");
                        lblnota.Text = total.ToString();
                    }
                    else {
                        if (total <=4.5) {
                            MessageBox.Show("Buen rendimiento");
                            lblnota.Text = total.ToString();
                        }
                        else {
                            if (total<=4.9) {
                                MessageBox.Show("Excelente");
                                lblnota.Text = total.ToString();
                            }
                            else {
                                if (total==5)
                                {
                                    MessageBox.Show("Graduado con honores!");
                                    lblnota.Text = total.ToString();

                                }
                            }
                        }
                    }
                }

            }


        }
    }
}
