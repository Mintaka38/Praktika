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
    public partial class Заказчик : Form
    {
        Model1 db = new Model1();
        public Заказчик()
        {
            InitializeComponent();
        }

        private void Заказчик_Load(object sender, EventArgs e)
        {
            заказBindingSource.DataSource = db.Заказ.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Авторизация.FORMA.Show();
        }
    }
}
