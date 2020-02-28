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
    public partial class Кладовщик : Form
    {
        public Кладовщик()
        {
            InitializeComponent();
        }

        private void Кладовщик_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Авторизация.FORMA.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ткани ткани = new Ткани();
            ткани.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Фурнитура_1_ фурнитура_1 = new Фурнитура_1_();
            фурнитура_1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Факт_поступления_материала ФакПостМат = new Факт_поступления_материала();
            ФакПостМат.Show();
        }
    }
}
