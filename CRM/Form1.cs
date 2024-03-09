using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Combo_TipoGRaf.SelectedIndex = 0;
            articulo.SelectedIndex = 0;
            foreach (DataPoint actual in Maldita_Encuesta.Series[0].Points) {
                actual.AxisLabel = "#PERCENT";
            }
            encuesta_tipo.Series[0].Points.AddXY("Vehiculo", 9);
            encuesta_tipo.Series[1].Points.AddXY("Vehiculo", 10);
            encuesta_tipo.Series[2].Points.AddXY("Vehiculo", 5);
            encuesta_tipo.Series[3].Points.AddXY("Vehiculo", 13);

            encuesta_tipo.Series[0].Points.AddXY("Moto", 4);
            encuesta_tipo.Series[1].Points.AddXY("Moto", 3);
            encuesta_tipo.Series[2].Points.AddXY("Moto", 2);
            encuesta_tipo.Series[3].Points.AddXY("Moto", 0);

            encuesta_tipo.Series[0].Points.AddXY("Bus", 0);
            encuesta_tipo.Series[1].Points.AddXY("Bus", 1);
            encuesta_tipo.Series[2].Points.AddXY("Bus", 0);
            encuesta_tipo.Series[3].Points.AddXY("Bus", 0);

            encuesta_tipo.Series[0].Points.AddXY("Minivan", 0);
            encuesta_tipo.Series[1].Points.AddXY("Minivan", 2);
            encuesta_tipo.Series[2].Points.AddXY("Minivan", 8);
            encuesta_tipo.Series[3].Points.AddXY("Minivan", 1);

            encuesta_tipo.Series[0].Points.AddXY("RV", 0);
            encuesta_tipo.Series[1].Points.AddXY("RV", 0);
            encuesta_tipo.Series[2].Points.AddXY("RV", 7);
            encuesta_tipo.Series[3].Points.AddXY("RV", 2);

           



        }


        private void EndResponsive() { 
        
        
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }else this.WindowState= FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            centro.Controls.Clear();
            Form2 pais = new Form2();

            centro.Controls.Add(pais.pais_relleno);
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.centro.Controls.Clear();
            Form1 aux = new Form1();
            this.centro.Controls.Add(aux.centro);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            if(Combo_TipoGRaf.SelectedIndex == 1)
            {
                encuesta_tipo.Visible= true;
            }
            else
            {
                encuesta_tipo.Visible = false;
                Maldita_Encuesta.Titles[0].Text = "Composición de personas interesadas en adquirir un " + articulo.SelectedItem.ToString();
                Random rand = new Random();

                foreach (DataPoint actual in Maldita_Encuesta.Series[0].Points) {
                    actual.YValues[0] = rand.Next(0, 100);
                    actual.AxisLabel = "#PERCENT";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            centro.Controls.Clear();
            Form3 pais = new Form3();

            centro.Controls.Add(pais.Encuesta_Genero);
        }
    }
}
