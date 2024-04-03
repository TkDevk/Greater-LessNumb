namespace exercises
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numOne = new TextBox();
            numTwo = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // numOne
            // 
            numOne.Location = new Point(96, 165);
            numOne.Name = "numOne";
            numOne.Size = new Size(100, 23);
            numOne.TabIndex = 0;
            // 
            // numTwo
            // 
            numTwo.Location = new Point(96, 224);
            numTwo.Name = "numTwo";
            numTwo.Size = new Size(100, 23);
            numTwo.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(242, 214);
            button1.Name = "button1";
            button1.Size = new Size(90, 41);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 227);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 3;
            label1.Text = "Numero Dos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 168);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Numero Uno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 112);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 5;
            label3.Text = "Mayor de Dos numeros";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 112);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 6;
            label4.Text = "Mayor de Tres numeros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 171);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 10;
            label5.Text = "Numero Uno";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 230);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 9;
            label6.Text = "Numero Dos";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(512, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(512, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(433, 283);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 12;
            label7.Text = "Numero Tres";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(512, 280);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(661, 265);
            button2.Name = "button2";
            button2.Size = new Size(85, 50);
            button2.TabIndex = 13;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(numTwo);
            Controls.Add(numOne);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numOne;
        private TextBox numTwo;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox3;
        private Button button2;
    }
}
