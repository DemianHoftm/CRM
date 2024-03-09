using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Encuesta_Genero.Series[0].Points.AddXY("Hombre", 9);
            Encuesta_Genero.Series[0].Points.AddXY("Mujer", 13);

            Encuesta_Genero.Series[1].Points.AddXY("Hombre", 13);
            Encuesta_Genero.Series[1].Points.AddXY("Mujer", 3);

            Encuesta_Genero.Series[2].Points.AddXY("Hombre", 2);
            Encuesta_Genero.Series[2].Points.AddXY("Mujer", 19);

            Encuesta_Genero.Series[3].Points.AddXY("Hombre", 4);
            Encuesta_Genero.Series[3].Points.AddXY("Mujer", 0);

            Encuesta_Genero.Series[4].Points.AddXY("Hombre", 7);
            Encuesta_Genero.Series[4].Points.AddXY("Mujer", 5);
        }
    }
}
