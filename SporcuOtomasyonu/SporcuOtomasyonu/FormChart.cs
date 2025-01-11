using MindFusion.Charting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporcuOtomasyonu
{
    public partial class FormChart : Form
    {
        public delegate void Mydelegate(string table_name,BarChart barChart);
        public event Mydelegate EventAddChart;
        public User user;
        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            edit();
            EventAddChart?.Invoke(user.username,barChart1);
        }

        private void edit()
        {
            barChart1.YAxis.Interval = 100;
            barChart1.YAxis.MaxValue = 3500;
            barChart1.YAxis.MinValue = 0;
            barChart1.YAxis.Title = "Kalori";


            barChart1.XAxis.Interval = 1;
            barChart1.XAxis.MaxValue = 31;
            barChart1.XAxis.MinValue = -1;
            barChart1.XAxis.Title = "Gün";

            barChart1.ShowXCoordinates = false;
            barChart1.ShowLegendTitle = false;

            barChart1.Theme.DataLabelsFontSize = 12;
        }

        private void barChart1_DataItemClicked(object sender, MindFusion.Charting.HitResult e)
        {

        }
    }
}
