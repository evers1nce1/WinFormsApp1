using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
            tabtoshow.SelectedIndexChanged += tabtoshow_SelectedIndexChanged;
            this.FormClosed += on_close;
            button1.Click += button1_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
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
        private void button1_Click(object sender, EventArgs e)
        {
            Routine func = new Routine();
            var L = func.ParseOrders();
            var D = func.ParseComponents();
            var Dk = func.ParseStorage();
            try
            {

                var result = L.Where(p => p.ID == int.Parse(textBox1.Text)).FirstOrDefault();
                var resultl = Dk.Where(p => p.id == int.Parse(textBox2.Text)).FirstOrDefault();
                if (result != null)
                {
                    if (resultl != null && resultl.count >= int.Parse(textBox3.Text))
                    {

                        int index = Array.IndexOf(L.ToArray(), result);
                        int index2 = Array.IndexOf(Dk.ToArray(), resultl);
                        string[] arr = File.ReadAllLines("../../../data/заказы.txt");
                        arr[index] = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + (comboBox1.SelectedIndex + 1).ToString() + " " + (int.Parse(textBox3.Text) * resultl.price).ToString();
                        var result2 = D.Select(p => p.id);
                        string[] arr2 = File.ReadAllLines("../../../data/склад.txt");
                        arr2[index2] = resultl.id.ToString() + " " + (resultl.count - int.Parse(textBox3.Text)).ToString() + " " + resultl.price.ToString();
                        if (result2.Contains(int.Parse(textBox2.Text)))
                        {
                            File.WriteAllLines("../../../data/заказы.txt", arr);
                            File.WriteAllLines("../../../data/склад.txt", arr2);
                        }
                        else
                        {
                            MessageBox.Show("Такого ID нет в базе", "Ошибка");
                        }

                        dataGridView1.DataSource = func.GetOrderTable().ToList();
                        dataGridView1.Update();
                    }
                    else
                    {
                        MessageBox.Show("Вы пытаетесь заказать больше чем есть на складе", "Ошибка");
                    }

                }
                else
                {
                    var result2 = D.Select(p => p.id);
                    if (!(resultl != null && resultl.count >= int.Parse(textBox3.Text)))
                    {
                        MessageBox.Show("Вы пытаетесь заказать больше чем есть на складе", "Ошибка");
                    }
                    else if (result2.Contains(int.Parse(textBox2.Text)))
                    {
                        File.AppendAllLines("../../../data/заказы.txt", new[] { textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + (comboBox1.SelectedIndex + 1).ToString() + " " + (int.Parse(textBox3.Text) * resultl.price).ToString() });
                    }
                    else
                    {
                        MessageBox.Show("Такого ID нет в базе", "Ошибка");
                    }
                    dataGridView1.DataSource = func.GetOrderTable().ToList();
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
            if (tabtoshow.SelectedIndex == 2)
            {
                textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                comboBox1.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Routine func = new Routine();

            var L = func.ParseOrders();
            try
            {

                var result = L.Where(p => p.ID == int.Parse(textBox1.Text)).FirstOrDefault();
                if (result != null)
                {

                    int ind = Array.IndexOf(L.ToArray(), result);

                    string[] arr = File.ReadAllLines("../../../data/заказы.txt");
                    arr = arr.Where((line, index) => index != ind).ToArray();

                    File.WriteAllLines("../../../data/заказы.txt", arr);

                    dataGridView1.DataSource = func.GetOrderTable().ToList();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Routine func = new Routine();
            var L = func.ParseOrders();
            try
            {

                var result = L.Where(p => p.ID == int.Parse(textBox1.Text)).FirstOrDefault();
                if (result != null)
                {
                    int index = Array.IndexOf(L.ToArray(), result);
                    string[] arr = File.ReadAllLines("../../../data/заказы.txt");
                    arr[index] = result.ID.ToString() + " " + result.component.ToString() + " " + result.count.ToString() + " " + (comboBox1.SelectedIndex + 1).ToString() + " " + result.price.ToString();
                    File.WriteAllLines("../../../data/заказы.txt", arr);

                    dataGridView1.DataSource = func.GetOrderTable().ToList();
                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("Вы пытаетесь заказать больше чем есть на складе", "Ошибка");
                }

            }
            catch
            {
                MessageBox.Show("Неверный формат ввода", "Ошибка");
            }

        }
    }
}
