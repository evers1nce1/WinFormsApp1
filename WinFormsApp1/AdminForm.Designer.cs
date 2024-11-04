namespace WinFormsApp1
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabtoshow = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            button2 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            comboBox2 = new ComboBox();
            button3 = new Button();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 14);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 8;
            label1.Text = "Таблица для отображеня";
            // 
            // tabtoshow
            // 
            tabtoshow.FormattingEnabled = true;
            tabtoshow.Items.AddRange(new object[] { "Детали", "Склад", "Сотрудники", "Заказы" });
            tabtoshow.Location = new Point(346, 11);
            tabtoshow.Name = "tabtoshow";
            tabtoshow.Size = new Size(157, 23);
            tabtoshow.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(346, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(442, 244);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 157);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 24;
            button1.Text = "Внести в базу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 122);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 23;
            label6.Text = "Стоимость товара";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 84);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 22;
            label5.Text = "Количество товара";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 84);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 46);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 20;
            label3.Text = "ID детали";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 16;
            label2.Text = "Меню управления менеджера:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "На складе", "В пути", "Ждет выдачи", "Выдано" });
            comboBox1.Location = new Point(346, 392);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 23);
            comboBox1.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(478, 395);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 40;
            label7.Text = "Статус";
            // 
            // button2
            // 
            button2.Location = new Point(574, 305);
            button2.Name = "button2";
            button2.Size = new Size(110, 40);
            button2.TabIndex = 38;
            button2.Text = "Внести в базу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(478, 366);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 37;
            label9.Text = "Количество";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(478, 337);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 36;
            label10.Text = "ID детали";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(139, 281);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 35;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(478, 308);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 34;
            label12.Text = "ID заказа";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(346, 363);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 33;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(346, 334);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(110, 23);
            textBox6.TabIndex = 32;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(346, 305);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(110, 23);
            textBox7.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(346, 287);
            label13.Name = "label13";
            label13.Size = new Size(167, 15);
            label13.TabIndex = 30;
            label13.Text = "Меню управления продавца:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 209);
            label14.Name = "label14";
            label14.Size = new Size(206, 15);
            label14.TabIndex = 43;
            label14.Text = "Меню управления администратора:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(12, 236);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(110, 23);
            textBox8.TabIndex = 44;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(12, 273);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(110, 23);
            textBox9.TabIndex = 45;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Продавец", "Менеджер", "Администратор" });
            comboBox2.Location = new Point(12, 308);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(110, 23);
            comboBox2.TabIndex = 46;
            // 
            // button3
            // 
            button3.Location = new Point(12, 346);
            button3.Name = "button3";
            button3.Size = new Size(110, 40);
            button3.TabIndex = 47;
            button3.Text = "Добавить сотрудника";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(139, 239);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 48;
            label15.Text = "Имя";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(139, 276);
            label16.Name = "label16";
            label16.Size = new Size(49, 15);
            label16.TabIndex = 49;
            label16.Text = "Пароль";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(139, 313);
            label17.Name = "label17";
            label17.Size = new Size(69, 15);
            label17.TabIndex = 50;
            label17.Text = "Должность";
            // 
            // button4
            // 
            button4.Location = new Point(574, 346);
            button4.Name = "button4";
            button4.Size = new Size(109, 40);
            button4.TabIndex = 51;
            button4.Text = "Удалить заказ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(142, 346);
            button5.Name = "button5";
            button5.Size = new Size(109, 40);
            button5.TabIndex = 52;
            button5.Text = "Удалить работника";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(141, 157);
            button6.Name = "button6";
            button6.Size = new Size(110, 40);
            button6.TabIndex = 53;
            button6.Text = "Удалить товар";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(574, 390);
            button7.Name = "button7";
            button7.Size = new Size(109, 20);
            button7.TabIndex = 54;
            button7.Text = "Изменить статус";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(label14);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(textBox4);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tabtoshow);
            Controls.Add(dataGridView1);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox tabtoshow;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label7;
        private Button button2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label13;
        private Label label14;
        private TextBox textBox8;
        private TextBox textBox9;
        private ComboBox comboBox2;
        private Button button3;
        private Label label15;
        private Label label16;
        private Label label17;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}