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
    public partial class Ткани : Form
    {
        Model1 db = new Model1();
        public Ткани()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ткани_Load(object sender, EventArgs e)
        {
            складтканиBindingSource.DataSource = db.Склад_ткани.ToList();
        }
    }
}
