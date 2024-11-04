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
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
            tabtoshow.SelectedIndexChanged += tabtoshow_SelectedIndexChanged;
            this.FormClosed += on_close;
            dataGridView1.CellClick += dataGridView1_CellClick;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        private void tabtoshow_SelectedIndexChanged(object sender, EventArgs e) //обновление таблицы
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
                    dataGridView1.DataSource = func.GetUserTable().ToList();
                    dataGridView1.Update();
                    break;

                case 3:
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
        private void button2_Click_1(object sender, EventArgs e)
        {
            Routine func = new Routine();
            var L = func.ParseOrders();
            var D = func.ParseComponents();
            var Dk = func.ParseStorage();
            try
            {

                var result = L.Where(p => p.ID == int.Parse(textBox7.Text)).FirstOrDefault();
                var resultl = Dk.Where(p => p.id == int.Parse(textBox6.Text)).FirstOrDefault();
                if (result != null)
                {
                    if (resultl != null && resultl.count >= int.Parse(textBox4.Text))
                    {

                        int index = Array.IndexOf(L.ToArray(), result);
                        int index2 = Array.IndexOf(Dk.ToArray(), resultl);
                        string[] arr = File.ReadAllLines("../../../data/заказы.txt");
                        arr[index] = textBox7.Text + " " + textBox6.Text + " " + textBox4.Text + " " + (comboBox1.SelectedIndex + 1).ToString() + " " + (int.Parse(textBox4.Text) * resultl.price).ToString();
                        var result2 = D.Select(p => p.id);
                        string[] arr2 = File.ReadAllLines("../../../data/склад.txt");
                        arr2[index2] = resultl.id.ToString() + " " + (resultl.count - int.Parse(textBox4.Text)).ToString() + " " + resultl.price.ToString();
                        if (result2.Contains(int.Parse(textBox6.Text)))
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
                    if (!(resultl != null && resultl.count >= int.Parse(textBox4.Text)))
                    {
                        MessageBox.Show("Вы пытаетесь заказать больше чем есть на складе", "Ошибка");
                    }
                    else if (result2.Contains(int.Parse(textBox6.Text)))
                    {
                        File.AppendAllLines("../../../data/заказы.txt", new[] { textBox7.Text + " " + textBox6.Text + " " + textBox4.Text + " " + (comboBox1.SelectedIndex + 1).ToString() + " " + (int.Parse(textBox4.Text) * resultl.price).ToString() });
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

        private void button1_Click_1(object sender, EventArgs e)
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
            else if (tabtoshow.SelectedIndex == 3)
            {
                textBox7.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                textBox6.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                comboBox1.SelectedItem = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Routine func = new Routine();

            var L = func.ParseUsers();

            var result2 = L.Select(p => p.name);
            if (!result2.Contains(textBox8.Text))
                File.AppendAllLines("../../../data/пользователи.txt", new[] { textBox8.Text.Replace(' ','_') + " " + textBox9.Text.Replace(' ', '_') + " " + (comboBox2.SelectedIndex + 1).ToString() });
            else
                MessageBox.Show("Пользователь уже в базе", "Ошибка");
            dataGridView1.DataSource = func.GetUserTable().ToList();
            dataGridView1.Update();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Routine func = new Routine();

            var L = func.ParseOrders();
            try
            {

                var result = L.Where(p => p.ID == int.Parse(textBox7.Text)).FirstOrDefault();
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

        private void button6_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Routine func = new Routine();

            var L = func.ParseUsers();
            try
            {

                var result = L.Where(p => p.name == textBox8.Text).FirstOrDefault();
                if (result != null)
                {

                    int ind = Array.IndexOf(L.ToArray(), result);

                    string[] arr = File.ReadAllLines("../../../data/пользователи.txt");
                    arr = arr.Where((line, index) => index != ind).ToArray();

                    File.WriteAllLines("../../../data/пользователи.txt", arr);

                    dataGridView1.DataSource = func.GetUserTable().ToList();
                    dataGridView1.Update();

                }
                else
                {
                    MessageBox.Show("Такого пользователя нет в базе", "Ошибка");
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода", "Ошибка");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Routine func = new Routine();
            var L = func.ParseOrders();
            try
            {

                var result = L.Where(p => p.ID == int.Parse(textBox7.Text)).FirstOrDefault();
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
