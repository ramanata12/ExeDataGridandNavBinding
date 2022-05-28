using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.GreenYellow;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.DarkGreen;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.DarkRed;

            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;
            dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;

            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form2 V = new Form2();
            V.Show();
        }
    }
}
