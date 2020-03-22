using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Singleton_Implement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FxFunction fx = FxFunction.GetInstance();
            dataGridView.DataSource = fx.GetData("Select * from Categories");
        }

        private void button_get_products_Click(object sender, EventArgs e)
        {
            FxFunction fx = FxFunction.GetInstance();
            dataGridView.DataSource = fx.GetData("Select * from Products");
        }
    }
}
