namespace WinFormsApp1
{
    partial class ManagerForm
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 14);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 5;
            label1.Text = "Таблица для отображеня";
            // 
            // tabtoshow
            // 
            tabtoshow.FormattingEnabled = true;
            tabtoshow.Items.AddRange(new object[] { "Детали", "Склад", "Заказы" });
            tabtoshow.Location = new Point(346, 11);
            tabtoshow.Name = "tabtoshow";
            tabtoshow.Size = new Size(157, 23);
            tabtoshow.TabIndex = 4;
            tabtoshow.SelectedIndexChanged += tabtoshow_SelectedIndexChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(346, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(442, 244);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 6;
            label2.Text = "Меню управления менеджера:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 43);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 11;
            label3.Text = "ID детали";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 81);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 81);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 13;
            label5.Text = "Количество товара";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 119);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 14;
            label6.Text = "Стоимость товара";
            // 
            // button1
            // 
            button1.Location = new Point(12, 154);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 15;
            button1.Text = "Внести в базу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(141, 154);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(110, 40);
            button2.TabIndex = 16;
            button2.Text = "Удалить товар";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
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
            Name = "ManagerForm";
            Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox tabtoshow;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}