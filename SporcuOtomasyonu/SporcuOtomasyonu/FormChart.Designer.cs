namespace SporcuOtomasyonu
{
    partial class FormChart
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
            this.barChart1 = new MindFusion.Charting.WinForms.BarChart();
            this.SuspendLayout();
            // 
            // barChart1
            // 
            this.barChart1.BarSpacingRatio = 2D;
            this.barChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barChart1.LegendTitle = "Legend";
            this.barChart1.Location = new System.Drawing.Point(0, 0);
            this.barChart1.Name = "barChart1";
            this.barChart1.Padding = new System.Windows.Forms.Padding(5);
            this.barChart1.ShowLegend = true;
            this.barChart1.Size = new System.Drawing.Size(1163, 474);
            this.barChart1.SubtitleFontName = null;
            this.barChart1.SubtitleFontSize = null;
            this.barChart1.SubtitleFontStyle = null;
            this.barChart1.TabIndex = 1;
            this.barChart1.Text = "barChart1";
            this.barChart1.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
            this.barChart1.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.barChart1.Theme.UniformSeriesStrokeThickness = 2D;
            this.barChart1.TitleFontName = null;
            this.barChart1.TitleFontSize = null;
            this.barChart1.TitleFontStyle = null;
            this.barChart1.DataItemClicked += new System.EventHandler<MindFusion.Charting.HitResult>(this.barChart1_DataItemClicked);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 474);
            this.Controls.Add(this.barChart1);
            this.Name = "FormChart";
            this.Text = "FormChart";
            this.Load += new System.EventHandler(this.FormChart_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MindFusion.Charting.WinForms.BarChart barChart1;
    }
}