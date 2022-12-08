namespace Licence
{
    partial class register
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prenom1 = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.username1 = new System.Windows.Forms.TextBox();
            this.email1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nom1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(593, 676);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "enregistrer ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(542, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(532, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(494, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(500, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // prenom1
            // 
            this.prenom1.BackColor = System.Drawing.Color.Black;
            this.prenom1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenom1.ForeColor = System.Drawing.Color.White;
            this.prenom1.Location = new System.Drawing.Point(641, 193);
            this.prenom1.Name = "prenom1";
            this.prenom1.Size = new System.Drawing.Size(219, 32);
            this.prenom1.TabIndex = 6;
            // 
            // password1
            // 
            this.password1.BackColor = System.Drawing.SystemColors.InfoText;
            this.password1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password1.ForeColor = System.Drawing.Color.White;
            this.password1.Location = new System.Drawing.Point(641, 538);
            this.password1.Name = "password1";
            this.password1.PasswordChar = '*';
            this.password1.Size = new System.Drawing.Size(219, 32);
            this.password1.TabIndex = 7;
            // 
            // username1
            // 
            this.username1.BackColor = System.Drawing.Color.Black;
            this.username1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username1.ForeColor = System.Drawing.Color.White;
            this.username1.Location = new System.Drawing.Point(641, 408);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(219, 32);
            this.username1.TabIndex = 8;
            // 
            // email1
            // 
            this.email1.BackColor = System.Drawing.Color.Black;
            this.email1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email1.ForeColor = System.Drawing.Color.White;
            this.email1.Location = new System.Drawing.Point(641, 306);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(219, 32);
            this.email1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(522, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenom";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // nom1
            // 
            this.nom1.BackColor = System.Drawing.Color.Black;
            this.nom1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nom1.ForeColor = System.Drawing.Color.White;
            this.nom1.Location = new System.Drawing.Point(641, 90);
            this.nom1.Name = "nom1";
            this.nom1.Size = new System.Drawing.Size(219, 32);
            this.nom1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(866, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "*";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(866, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "*";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(628, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 1);
            this.panel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(628, 348);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 1);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(628, 450);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 1);
            this.panel4.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(628, 583);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(257, 1);
            this.panel5.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(628, 235);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(257, 1);
            this.panel6.TabIndex = 20;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licence.Properties.Resources.DESIGN1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 949);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nom1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.prenom1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "register";
            this.Load += new System.EventHandler(this.register_Load_2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox prenom1;
        private TextBox password1;
        private TextBox username1;
        private TextBox email1;
        private Label label2;
        private TextBox nom1;
        private Label label7;
        private Label label8;
        private EventHandler register_Load;
        private EventHandler register_Load_1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private ColorDialog colorDialog1;
    }
}