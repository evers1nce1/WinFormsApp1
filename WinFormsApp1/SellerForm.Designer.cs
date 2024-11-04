namespace WinFormsApp1
{
    partial class SellerForm
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
            dataGridView1 = new DataGridView();
            tabtoshow = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(346, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(442, 244);
            dataGridView1.TabIndex = 0;
            // 
            // tabtoshow
            // 
            tabtoshow.FormattingEnabled = true;
            tabtoshow.Items.AddRange(new object[] { "Детали", "Склад", "Заказы" });
            tabtoshow.Location = new Point(346, 11);
            tabtoshow.Name = "tabtoshow";
            tabtoshow.Size = new Size(157, 23);
            tabtoshow.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 14);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 2;
            label1.Text = "Таблица для отображеня";
            // 
            // button1
            // 
            button1.Location = new Point(12, 196);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 24;
            button1.Text = "Внести в базу";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 122);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 23;
            label6.Text = "Количество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 84);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 22;
            label5.Text = "ID детали";
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
            label3.Size = new Size(55, 15);
            label3.TabIndex = 20;
            label3.Text = "ID заказа";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 19;
            textBox3.TextChanged += textBox3_TextChanged;
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
            label2.Size = new Size(167, 15);
            label2.TabIndex = 16;
            label2.Text = "Меню управления продавца:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(139, 160);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 27;
            label7.Text = "Статус";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "На складе", "В пути", "Ждет выдачи", "Выдано" });
            comboBox1.Location = new Point(12, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 23);
            comboBox1.TabIndex = 29;
            // 
            // button2
            // 
            button2.Location = new Point(139, 196);
            button2.Name = "button2";
            button2.Size = new Size(110, 40);
            button2.TabIndex = 30;
            button2.Text = "Удалить заказ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(201, 157);
            button3.Name = "button3";
            button3.Size = new Size(116, 21);
            button3.TabIndex = 31;
            button3.Text = "Изменить статус";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
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
            Name = "SellerForm";
            Text = "SellerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox tabtoshow;
        private Label label1;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label7;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
    }
}