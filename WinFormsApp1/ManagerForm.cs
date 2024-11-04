using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            tabtoshow.SelectedIndexChanged += tabtoshow_SelectedIndexChanged;
            FormClosed += on_close;
            dataGridView1.CellClick += dataGridView1_CellClick;
            
        }

        private void tabtoshow_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabtoshow.SelectedIndex;
            Routine func = new Routine();

            List<Components> L = func.ParseComponents();
            switch (tabtoshow.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = func.GetComponentsTable().ToList();
                    dataGridView1.Update();
                    break;
                case 1:
                    dataGridView1.DataSource = func.GetStorageTable().ToList();
                    dataGridView1.Update();
                    break;
                case 2:
                    dataGridView1.DataSource = func.GetOrderTable().ToList();
                    dataGridView1.Update();
                    break;

            }

        }
        private void on_close(object sender, EventArgs e)
        {
            Routine s = new Routine();
            s.OpenLoginForm();

        }

        private void tabtoshow_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Routine func = new Routine();

            var L = func.ParseStorage();
            var D = func.ParseComponents();
            try
            {

                var result = L.Where(p => p.id == int.Parse(textBox1.Text)).FirstOrDefault();
                if (result != null)
                {
                    var upd = new Storage(int.Parse(textBox1.Text), int.Parse(textBox2.Text), decimal.Parse(textBox3.Text));

                    int index = Array.IndexOf(L.ToArray(), result);

                    string[] arr = File.ReadAllLines("../../../data/склад.txt");
                    arr[index] = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                    File.WriteAllLines("../../../data/склад.txt", arr);
                    dataGridView1.DataSource = func.GetStorageTable().ToList();
                    dataGridView1.Update();

                }
                else
                {
                    var result2 = D.Select(p => p.id);
                    if (result2.Contains(int.Parse(textBox1.Text)))
                        File.AppendAllLines("../../../data/склад.txt", new[] { textBox1.Text + " " + textBox2.Text + " " + textBox3.Text });
                    else
                        MessageBox.Show("Такого ID нет в базе", "Ошибка");
                    dataGridView1.DataSource = func.GetStorageTable().ToList();
                    dataGridView1.Update();
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода", "Ошибка");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //получаем данные строки таблицы
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (tabtoshow.SelectedIndex == 1)
            {
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Routine func = new Routine();

            var L = func.ParseStorage();
            try
            {

                var result = L.Where(p => p.id == int.Parse(textBox1.Text)).FirstOrDefault();
                if (result != null)
                {

                    int ind = Array.IndexOf(L.ToArray(), result);

                    string[] arr = File.ReadAllLines("../../../data/склад.txt");
                    arr = arr.Where((line, index) => index != ind).ToArray();

                    File.WriteAllLines("../../../data/склад.txt", arr);

                    dataGridView1.DataSource = func.GetStorageTable().ToList();
                    dataGridView1.Update();

                }
                else
                {
                    MessageBox.Show("Такого ID заказа нет в базе", "Ошибка");
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода", "Ошибка");
            }
        }
    }
}
