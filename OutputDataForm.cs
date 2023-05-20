using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallisticTask
{
    public partial class OutputDataForm : Form
    {
        Form1 Fm1 { get; set; }

        public OutputDataForm(Form1 fm1)
        {
            InitializeComponent();
            Fm1 = fm1;
        }

        private void FillingDGW()
        {
            List<double> x = new List<double>();
            x = Fm1.Xcoordinate;

            List<double> y = new List<double>();
            y = Fm1.Ycoordinate;

            List<double> t = new List<double>();
            t = Fm1.Time;

            //      List<List<double>>


            // dataGridView1.DataSource = x.ConvertAll(a => new { Value = a });


            //for (int i = 0; i < fm1.l.Count; i++)
            //{
            //    for (int j = 0; j < fm1.l[i].; j++)
            //    {
            //        dataGridView1.Rows[i].Cells[j].Value = CarArray[i][j];
            //        dataGridView1.Rows[i].Cells[j].Value = arr[i, j];

            //    }
            //}
        }

        private void OutputData_Load(object sender, EventArgs e)
        {
            FillingDGW();
        }
    }
}
