using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prezzoequi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            private (double Quantita, double Prezzo) TrovaEquilibrio(
            double domandaInt, double domandaCoeff,
            double offertaInt, double offertaCoeff, double offertaEsp)
        {
            double qMin = 0;
            double qMax = 20;
            double tolleranza = 0.001;
            int maxIterazioni = 1000;

            for (int i = 0; i < maxIterazioni; i++)
            {
                double qMedio = (qMin + qMax) / 2;
                double differenza = CalcolaDifferenza(qMedio, domandaInt, domandaCoeff, offertaInt, offertaCoeff, offertaEsp);

                if (Math.Abs(differenza) < tolleranza)
                {
                    double prezzo = domandaInt - domandaCoeff * qMedio;
                    return (qMedio, prezzo);
                }

                double diffMin = CalcolaDifferenza(qMin, domandaInt, domandaCoeff, offertaInt, offertaCoeff, offertaEsp);

                if (diffMin * differenza < 0)
                    qMax = qMedio;
                else
                    qMin = qMedio;
            }

            double qFinale = (qMin + qMax) / 2;
            double pFinale = domandaInt - domandaCoeff * qFinale;
            return (qFinale, pFinale);
        }

        private double CalcolaDifferenza(double q, double domandaInt, double domandaCoeff,
                                 double offertaInt, double offertaCoeff, double offertaEsp)
        {
            double prezzoDomanda = domandaInt - domandaCoeff * q;
            double prezzoOfferta = offertaInt + offertaCoeff * Math.Pow(q, offertaEsp);
            return prezzoDomanda - prezzoOfferta;
        }
    

    }
}
    

