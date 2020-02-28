using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Фурнитура_1_ : Form
    {
        Model1 db = new Model1();
        public Фурнитура_1_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Фурнитура_1__Load(object sender, EventArgs e)
        {
            складфурнитурыBindingSource.DataSource = db.Склад_фурнитуры.ToList();
        }
    }
}
