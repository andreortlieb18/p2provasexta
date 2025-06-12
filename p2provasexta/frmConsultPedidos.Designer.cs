namespace p2provasexta
{
    partial class frmConsultPedidos
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
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listView1 = new ListView();
            listView2 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 78);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "CPF:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 18);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 2;
            label2.Text = "Consulta de Pedidos";
            // 
            // button1
            // 
            button1.Location = new Point(37, 110);
            button1.Name = "button1";
            button1.Size = new Size(167, 29);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 152);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 188);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 5;
            label4.Text = "Valor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 226);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 6;
            label5.Text = "Pedidos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(521, 78);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 7;
            label6.Text = "Itens do Pedido:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(616, 273);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 8;
            label7.Text = "total do Pedido:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(616, 304);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 9;
            label8.Text = "Valor Total:";
            // 
            // listView1
            // 
            listView1.Location = new Point(37, 261);
            listView1.Name = "listView1";
            listView1.Size = new Size(280, 121);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(521, 110);
            listView2.Name = "listView2";
            listView2.Size = new Size(242, 121);
            listView2.TabIndex = 11;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // frmConsultPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmConsultPedidos";
            Text = "frmConsultPedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListView listView1;
        private ListView listView2;
    }
}