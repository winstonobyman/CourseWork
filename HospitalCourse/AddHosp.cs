using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCourse
{
    public partial class AddHosp : Form
    {
        public Form1 form1;

        public AddHosp()
        {
            InitializeComponent();
        }

        private void AddHosp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox2.Text == null || textBox1.Text == null 
                || dateTimePicker1.Value == null)
            {
                MessageBox.Show("Не должно быть пустых полей!");
                return;
            }
            else
            { 
            form1.listH.Add(new Hospital { Name = textBox1.Text,
                Address = textBox2.Text, Foundation = dateTimePicker1.Value,
                HospHead = textBox3.Text, List = new List<Department>() });
            }
        }
    }
}
