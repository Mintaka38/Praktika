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
    public partial class Факт_поступления : Form
    {
        Model2 db = new Model2();
        public Факт_поступления()
        {
            InitializeComponent();
        }

        private void Факт_поступления_Load(object sender, EventArgs e)
        {
            фактпоступленияматериалаBindingSource.DataSource = db.Факт_поступления_материала.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            фактпоступленияматериалаBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            фактпоступленияматериалаBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Заданы не все данные");
                return;
            }
            Факт_поступления_материала материал = new Факт_поступления_материала();
            материал.Номер_поставки = textBox1.Text;
            материал.Закупаемый_материал = textBox2.Text;
            материал.Количество = textBox3.Text;
            материал.Закупочная_цена = textBox4.Text;
            материал.Сумма = textBox5.Text;
            db.Факт_поступления_материала.Add(материал);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Успешно!");
                фактпоступленияматериалаBindingSource.DataSource = db.Факт_поступления_материала.ToList();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox3.Text); // количество
                double b = Convert.ToDouble(textBox4.Text); // закупочная цена
                double g = a * b;
                textBox5.Text = g.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Изменить изм = new Изменить();
            Факт_поступления_материала rg = (Факт_поступления_материала)фактпоступленияматериалаBindingSource.Current;
            изм.db = db;
            изм.rg = rg;
            DialogResult dr = изм.ShowDialog();
            if (dr == DialogResult.OK)
            {
                фактпоступленияматериалаBindingSource.DataSource = db.Факт_поступления_материала.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Факт_поступления_материала rl = (Факт_поступления_материала)фактпоступленияматериалаBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить поставку №" + rl.Номер_поставки.ToString() + "?",
                "Удаление поставки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Факт_поступления_материала.Remove(rl);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Поставка успешно удалена");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                фактпоступленияматериалаBindingSource.DataSource = db.Факт_поступления_материала.ToList();
            }
        }
    }
}
