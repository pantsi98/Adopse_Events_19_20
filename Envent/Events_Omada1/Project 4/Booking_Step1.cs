using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_4
{
    public partial class Booking_Step1 : UserControl
    {
        public Booking_Step1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.playTableAdapter.FillBy4(this.enventDataSet.play);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            string id = selectedRow.Cells[0].Value.ToString();
            string date = selectedRow.Cells[1].Value.ToString();

            //label2.Text = id;
            //label3.Text = date;
        }

        public int GetMyPhone(object Sender, DataGridViewCellEventArgs e)
        {
            int x;
            x = 5;
            return x;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Book_Click(object sender, EventArgs e)
        {
            Booking_Steps.Controls.Clear();
            BookingStep2 bs2 = new BookingStep2();
            Booking_Steps.Controls.Add(bs2);
        }
    }

}

