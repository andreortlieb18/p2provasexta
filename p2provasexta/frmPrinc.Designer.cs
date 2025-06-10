namespace p2provasexta
{
    partial class frmPrinc
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 44);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "PRINCIPAL";
            // 
            // button1
            // 
            button1.Location = new Point(104, 175);
            button1.Name = "button1";
            button1.Size = new Size(181, 29);
            button1.TabIndex = 1;
            button1.Text = "Cadastro de Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(104, 210);
            button2.Name = "button2";
            button2.Size = new Size(181, 29);
            button2.TabIndex = 2;
            button2.Text = "Cadastro de Produtos ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(104, 245);
            button3.Name = "button3";
            button3.Size = new Size(181, 29);
            button3.TabIndex = 3;
            button3.Text = "Cadastro de Pedidos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(104, 280);
            button4.Name = "button4";
            button4.Size = new Size(181, 29);
            button4.TabIndex = 4;
            button4.Text = "Cadastro de Usuários";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 125);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 5;
            label2.Text = "Opções:";
            // 
            // frmPrinc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "frmPrinc";
            Text = "frmPrinc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
    }
}