﻿namespace MultiQueueSimulation
{
    partial class Graph
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
            this.serverChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serverChart)).BeginInit();
            this.SuspendLayout();
            // 
            // serverChart
            // 
            chartArea1.Name = "ChartArea1";
            this.serverChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.serverChart.Legends.Add(legend1);
            this.serverChart.Location = new System.Drawing.Point(2, 88);
            this.serverChart.Name = "serverChart";
            this.serverChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.serverChart.Series.Add(series1);
            this.serverChart.Size = new System.Drawing.Size(923, 373);
            this.serverChart.TabIndex = 0;
            this.serverChart.Text = "Busy Time Chart";
            this.serverChart.Click += new System.EventHandler(this.serverChart_Click);
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.serverNameLabel.Location = new System.Drawing.Point(469, 10);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(0, 19);
            this.serverNameLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F);
            this.label1.Location = new System.Drawing.Point(329, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "server graph";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(928, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.serverChart);
            this.Name = "Graph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serverChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart serverChart;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label label1;
    }
}