namespace PRGProject.PresentationLayer
{
    partial class CreateStudent
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "StudentNumber";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Surname";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(114, 230);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "Image";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(114, 278);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(244, 23);
            textBox5.TabIndex = 4;
            textBox5.Text = "Date of birth";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(114, 323);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(244, 23);
            textBox6.TabIndex = 5;
            textBox6.Text = "Gender";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(114, 366);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(244, 23);
            textBox7.TabIndex = 6;
            textBox7.Text = "Phone";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(463, 98);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(223, 23);
            textBox8.TabIndex = 7;
            textBox8.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(303, 28);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 9;
            label1.Text = "Create Student ";
            // 
            // button1
            // 
            button1.Location = new Point(463, 278);
            button1.Name = "button1";
            button1.Size = new Size(223, 56);
            button1.TabIndex = 10;
            button1.Text = "Create Student";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(463, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Select Module";
            // 
            // CreateStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "CreateStudent";
            Text = "CreateStudent";
            Load += CreateStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
    }
}