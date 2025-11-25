namespace prezzoequi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_eq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tb_q = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.dgv_dati = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart_eq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dati)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_eq
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_eq.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_eq.Legends.Add(legend1);
            this.chart_eq.Location = new System.Drawing.Point(459, 12);
            this.chart_eq.Name = "chart_eq";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_eq.Series.Add(series1);
            this.chart_eq.Size = new System.Drawing.Size(442, 209);
            this.chart_eq.TabIndex = 0;
            this.chart_eq.Text = "chart1";
            // 
            // tb_q
            // 
            this.tb_q.Location = new System.Drawing.Point(263, 69);
            this.tb_q.Name = "tb_q";
            this.tb_q.Size = new System.Drawing.Size(101, 20);
            this.tb_q.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "inserisci q";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(109, 110);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(255, 74);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "inserisci";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // dgv_dati
            // 
            this.dgv_dati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dati.Location = new System.Drawing.Point(12, 233);
            this.dgv_dati.Name = "dgv_dati";
            this.dgv_dati.Size = new System.Drawing.Size(401, 266);
            this.dgv_dati.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 528);
            this.Controls.Add(this.dgv_dati);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_q);
            this.Controls.Add(this.chart_eq);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_eq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_eq;
        private System.Windows.Forms.TextBox tb_q;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView dgv_dati;
    }
}

