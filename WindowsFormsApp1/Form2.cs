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
    public partial class Авторизация : Form
    {
        public static Авторизация FORMA { get; set; }
        public static Пользователь USER { get; set; }
        public Авторизация()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль");
                return;
            }
            Пользователь usr = db.Пользователь.Find(textBox1.Text);
            if ((usr != null) && (usr.Пароль == textBox2.Text))
            {
                USER = usr;
                FORMA = this;
                if ((usr.Роль == "Директор") || (usr.Роль == "директор"))
                {
                    Директор frm = new Директор();
                    frm.Show();
                    this.Hide();
                }
                else if ((usr.Роль == "Заказчик") || (usr.Роль == "заказчик"))
                {
                    Заказчик frm = new Заказчик();
                    frm.Show();
                    this.Hide();
                }
                else if ((usr.Роль == "Менеджер") || (usr.Роль == "менеджер"))
                {
                    Менеджер frm = new Менеджер();
                    frm.Show();
                    this.Hide();
                }
                else if ((usr.Роль == "Кладовщик") || (usr.Роль == "кладовщик"))
                {
                    Кладовщик frm = new Кладовщик();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем нет");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация f = new Регистрация();
            FORMA = this;
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {

        }
    }
}
