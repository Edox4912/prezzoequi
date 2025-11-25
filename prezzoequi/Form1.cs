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

namespace prezzoequi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupChart();
            SetupDataGrid();
        }
        private double domandaIntercetta = 90;
        private double domandaPendenza = 4;
        private double offertaTermineCostante = 10;
        private double offertaCoefficiente = 0.01;
        private double offertaEsponente = 3;

        public void btn_insert_Click(object sender, EventArgs e)
        {
            CalculateData();
        }
        public void SetupChart()
        {
            ChartArea chartArea = new ChartArea();
            chart_eq.ChartAreas.Add(chartArea);

            Series seriesDomanda = new Series("Domanda");
            seriesDomanda.ChartType = SeriesChartType.Line;
            seriesDomanda.Color = Color.Red;
            chart_eq.Series.Add(seriesDomanda);

            Series seriesOfferta = new Series("Offerta");
            seriesOfferta.ChartType = SeriesChartType.Line;
            seriesOfferta.Color = Color.Blue;
            chart_eq.Series.Add(seriesOfferta);

            chartArea.AxisX.Title = "Quantità (q)";
            chartArea.AxisY.Title = "Prezzo (p)";
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 20;
        }
        public void SetupDataGrid()
        {
            dgv_dati.Columns.Clear();
            dgv_dati.Columns.Add("Qta", "Quantità");
            dgv_dati.Columns.Add("Domanda", "Prezzo Domanda");
            dgv_dati.Columns.Add("Offerta", "Prezzo Offerta");
        }

        public void CalculateData()
        {
            if (!double.TryParse(tb_q.Text, out double maxQta))
            {
                MessageBox.Show("Inserire una quantità valida");
                return;
            }

            dgv_dati.Rows.Clear();
            chart_eq.Series["Domanda"].Points.Clear();
            chart_eq.Series["Offerta"].Points.Clear();

            double equilibrioQta = 0;
            double equilibrioPrezzo = 0;
            double minDiff = double.MaxValue;

            for (double q = 0; q <= maxQta; q += 0.5)
            {
                double prezzoDomanda = domandaIntercetta - (domandaPendenza * q);
                double prezzoOfferta = offertaTermineCostante + offertaCoefficiente * Math.Pow(q, offertaEsponente);

                // Aggiungi punti al grafico
                chart_eq.Series["Domanda"].Points.AddXY(q, prezzoDomanda);
                chart_eq.Series["Offerta"].Points.AddXY(q, prezzoOfferta);

                // Aggiungi riga alla griglia
                dgv_dati.Rows.Add(
                    Math.Round(q, 1),
                    Math.Round(prezzoDomanda, 2),
                    Math.Round(prezzoOfferta, 2)
                );

                // Calcola punto di equilibrio
                double diff = Math.Abs(prezzoDomanda - prezzoOfferta);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    equilibrioQta = q;
                    equilibrioPrezzo = (prezzoDomanda + prezzoOfferta) / 2;
                }
            }

            // Mostra equilibrio
            dgv_dati.Rows.Add(
                 ($"Punto di equilibrio:"),
                 ($"Quantità: {Math.Round(equilibrioQta, 2)} "),
                 ($"Prezzo: {Math.Round(equilibrioPrezzo, 2)}"));
        }



    }
}


