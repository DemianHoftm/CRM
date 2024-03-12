namespace CRM
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Encuesta_Genero = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Encuesta_Genero)).BeginInit();
            this.SuspendLayout();
            // 
            // Encuesta_Genero
            // 
            this.Encuesta_Genero.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.Encuesta_Genero.ChartAreas.Add(chartArea1);
            this.Encuesta_Genero.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Title = "Edad:";
            this.Encuesta_Genero.Legends.Add(legend1);
            this.Encuesta_Genero.Location = new System.Drawing.Point(0, 0);
            this.Encuesta_Genero.Name = "Encuesta_Genero";
            this.Encuesta_Genero.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Encuesta_Genero.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(166)))), ((int)(((byte)(213))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(62)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(194))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(58)))), ((int)(((byte)(85)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.LegendText = "Auto";
            series1.Name = "Menor_24";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Legend = "Legend1";
            series2.LegendText = "Moto";
            series2.Name = "edad_2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Legend = "Legend1";
            series3.LegendText = "MiniVan";
            series3.Name = "edad_3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Legend = "Legend1";
            series4.LegendText = "Bus";
            series4.Name = "edad4";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.LegendText = "RV";
            series5.Name = "Series5";
            this.Encuesta_Genero.Series.Add(series1);
            this.Encuesta_Genero.Series.Add(series2);
            this.Encuesta_Genero.Series.Add(series3);
            this.Encuesta_Genero.Series.Add(series4);
            this.Encuesta_Genero.Series.Add(series5);
            this.Encuesta_Genero.Size = new System.Drawing.Size(800, 450);
            this.Encuesta_Genero.TabIndex = 14;
            this.Encuesta_Genero.Text = "encuesta_edad";
            title1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.RoyalBlue;
            title1.Name = "Title1";
            title1.Text = "Composición segun género";
            this.Encuesta_Genero.Titles.Add(title1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Encuesta_Genero);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.Encuesta_Genero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart Encuesta_Genero;
    }
}