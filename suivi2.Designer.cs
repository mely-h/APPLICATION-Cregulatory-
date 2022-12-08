namespace Licence
{
    partial class suivi2
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
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.categorie = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.type_de_reglment = new System.Windows.Forms.Label();
            this.m_typereg = new System.Windows.Forms.ComboBox();
            this.objet = new System.Windows.Forms.Label();
            this.pd_objet = new System.Windows.Forms.TextBox();
            this.nature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nature5 = new System.Windows.Forms.TextBox();
            this.repon = new System.Windows.Forms.TextBox();
            this.recom = new System.Windows.Forms.TextBox();
            this.constat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.typev = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pointh = new System.Windows.Forms.TextBox();
            this.pn_conf = new System.Windows.Forms.ComboBox();
            this.scorea = new System.Windows.Forms.ComboBox();
            this.structureg = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.scordimpact2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.penalite2 = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.impact2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.niveau = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.datesuivi2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.impacth = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.OrangeRed;
            this.label16.Location = new System.Drawing.Point(22, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(210, 37);
            this.label16.TabIndex = 174;
            this.label16.Text = "Parametrage";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.OrangeRed;
            this.label14.Location = new System.Drawing.Point(26, 429);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(250, 37);
            this.label14.TabIndex = 172;
            this.label14.Text = "Point de Control";
            // 
            // categorie
            // 
            this.categorie.FormattingEnabled = true;
            this.categorie.Items.AddRange(new object[] {
            "financement",
            "comptabilité",
            "commercial",
            "commerce exterieur",
            "logistique",
            "autre (ajouter)"});
            this.categorie.Location = new System.Drawing.Point(347, 243);
            this.categorie.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(242, 40);
            this.categorie.TabIndex = 158;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.type_de_reglment);
            this.panel2.Controls.Add(this.m_typereg);
            this.panel2.Controls.Add(this.objet);
            this.panel2.Controls.Add(this.pd_objet);
            this.panel2.Controls.Add(this.nature);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nature5);
            this.panel2.Controls.Add(this.categorie);
            this.panel2.Location = new System.Drawing.Point(32, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 331);
            this.panel2.TabIndex = 175;
            // 
            // type_de_reglment
            // 
            this.type_de_reglment.AutoSize = true;
            this.type_de_reglment.BackColor = System.Drawing.Color.Transparent;
            this.type_de_reglment.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.type_de_reglment.ForeColor = System.Drawing.Color.White;
            this.type_de_reglment.Location = new System.Drawing.Point(98, 47);
            this.type_de_reglment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type_de_reglment.Name = "type_de_reglment";
            this.type_de_reglment.Size = new System.Drawing.Size(224, 32);
            this.type_de_reglment.TabIndex = 1;
            this.type_de_reglment.Text = "Type de reglement ";
            this.type_de_reglment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_typereg
            // 
            this.m_typereg.FormattingEnabled = true;
            this.m_typereg.Items.AddRange(new object[] {
            "a-procédure",
            "b-circulaire",
            "c-lettre circulaire",
            "d-instruction"});
            this.m_typereg.Location = new System.Drawing.Point(347, 41);
            this.m_typereg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.m_typereg.Name = "m_typereg";
            this.m_typereg.Size = new System.Drawing.Size(242, 40);
            this.m_typereg.TabIndex = 2;
            // 
            // objet
            // 
            this.objet.AutoSize = true;
            this.objet.BackColor = System.Drawing.Color.Transparent;
            this.objet.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.objet.ForeColor = System.Drawing.Color.White;
            this.objet.Location = new System.Drawing.Point(234, 109);
            this.objet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objet.Name = "objet";
            this.objet.Size = new System.Drawing.Size(73, 32);
            this.objet.TabIndex = 3;
            this.objet.Text = "Objet";
            this.objet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pd_objet
            // 
            this.pd_objet.Location = new System.Drawing.Point(347, 109);
            this.pd_objet.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pd_objet.Multiline = true;
            this.pd_objet.Name = "pd_objet";
            this.pd_objet.Size = new System.Drawing.Size(242, 38);
            this.pd_objet.TabIndex = 140;
            this.pd_objet.TextChanged += new System.EventHandler(this.pd_objet_TextChanged);
            // 
            // nature
            // 
            this.nature.AutoSize = true;
            this.nature.BackColor = System.Drawing.Color.Transparent;
            this.nature.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.nature.ForeColor = System.Drawing.Color.White;
            this.nature.Location = new System.Drawing.Point(215, 186);
            this.nature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nature.Name = "nature";
            this.nature.Size = new System.Drawing.Size(92, 32);
            this.nature.TabIndex = 141;
            this.nature.Text = "Nature";
            this.nature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 32);
            this.label3.TabIndex = 144;
            this.label3.Text = "Catégorie et sous-categorie ";
            // 
            // nature5
            // 
            this.nature5.Location = new System.Drawing.Point(347, 181);
            this.nature5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nature5.Name = "nature5";
            this.nature5.Size = new System.Drawing.Size(242, 39);
            this.nature5.TabIndex = 154;
            // 
            // repon
            // 
            this.repon.Location = new System.Drawing.Point(1205, 345);
            this.repon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.repon.Multiline = true;
            this.repon.Name = "repon";
            this.repon.Size = new System.Drawing.Size(562, 115);
            this.repon.TabIndex = 164;
            this.repon.TextChanged += new System.EventHandler(this.repon_TextChanged);
            // 
            // recom
            // 
            this.recom.Location = new System.Drawing.Point(1153, 226);
            this.recom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.recom.Multiline = true;
            this.recom.Name = "recom";
            this.recom.Size = new System.Drawing.Size(562, 115);
            this.recom.TabIndex = 163;
            // 
            // constat
            // 
            this.constat.Location = new System.Drawing.Point(1127, 107);
            this.constat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.constat.Multiline = true;
            this.constat.Name = "constat";
            this.constat.Size = new System.Drawing.Size(562, 115);
            this.constat.TabIndex = 162;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(938, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 32);
            this.label4.TabIndex = 161;
            this.label4.Text = "recommandation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(923, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 160;
            this.label2.Text = "reponse de la structure ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(962, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 159;
            this.label1.Text = "Constat";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.OrangeRed;
            this.label13.Location = new System.Drawing.Point(48, 13);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(304, 37);
            this.label13.TabIndex = 171;
            this.label13.Text = "Text Reglementaire ";
            // 
            // typev
            // 
            this.typev.FormattingEnabled = true;
            this.typev.Items.AddRange(new object[] {
            "self control",
            "compliance control"});
            this.typev.Location = new System.Drawing.Point(286, 695);
            this.typev.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.typev.Name = "typev";
            this.typev.Size = new System.Drawing.Size(242, 40);
            this.typev.TabIndex = 167;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 702);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 32);
            this.label9.TabIndex = 166;
            this.label9.Text = "Type de controle";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pointh
            // 
            this.pointh.Location = new System.Drawing.Point(286, 506);
            this.pointh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pointh.Multiline = true;
            this.pointh.Name = "pointh";
            this.pointh.Size = new System.Drawing.Size(459, 158);
            this.pointh.TabIndex = 164;
            // 
            // pn_conf
            // 
            this.pn_conf.FormattingEnabled = true;
            this.pn_conf.Items.AddRange(new object[] {
            "Administratif",
            "juridique",
            "perte financiére",
            "réputation"});
            this.pn_conf.Location = new System.Drawing.Point(385, 509);
            this.pn_conf.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pn_conf.Name = "pn_conf";
            this.pn_conf.Size = new System.Drawing.Size(242, 40);
            this.pn_conf.TabIndex = 162;
            this.pn_conf.SelectedIndexChanged += new System.EventHandler(this.pn_conf_SelectedIndexChanged);
            // 
            // scorea
            // 
            this.scorea.FormattingEnabled = true;
            this.scorea.Items.AddRange(new object[] {
            "Faible",
            "moyen",
            "élevée"});
            this.scorea.Location = new System.Drawing.Point(385, 569);
            this.scorea.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.scorea.Name = "scorea";
            this.scorea.Size = new System.Drawing.Size(242, 40);
            this.scorea.TabIndex = 161;
            // 
            // structureg
            // 
            this.structureg.FormattingEnabled = true;
            this.structureg.Location = new System.Drawing.Point(286, 762);
            this.structureg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.structureg.Name = "structureg";
            this.structureg.Size = new System.Drawing.Size(242, 40);
            this.structureg.TabIndex = 160;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(51, 575);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 32);
            this.label11.TabIndex = 152;
            this.label11.Text = "Score d\'impact";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(51, 517);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 32);
            this.label10.TabIndex = 151;
            this.label10.Text = "Penalité de non_conformité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 768);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 32);
            this.label6.TabIndex = 147;
            this.label6.Text = "Structure concernée";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 506);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 32);
            this.label5.TabIndex = 146;
            this.label5.Text = "Point de control";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 1508);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(2090, 51);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.BackColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(195, 45);
            this.toolStripLabel1.Text = "Enregistrer";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2090, 1559);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 853F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 853F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2086, 1555);
            this.tableLayoutPanel1.TabIndex = 178;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2078, 849);
            this.panel3.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::Licence.Properties.Resources.Artboard_61;
            this.panel8.Controls.Add(this.label26);
            this.panel8.Controls.Add(this.textBox3);
            this.panel8.Controls.Add(this.label21);
            this.panel8.Controls.Add(this.scordimpact2);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.impact2);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.penalite2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(890, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1188, 849);
            this.panel8.TabIndex = 180;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.Color.OrangeRed;
            this.label26.Location = new System.Drawing.Point(33, 350);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(146, 37);
            this.label26.TabIndex = 185;
            this.label26.Text = "Decision ";
            // 
            // textBox3
            // 
            this.textBox3.FormattingEnabled = true;
            this.textBox3.Items.AddRange(new object[] {
            "conforme",
            "partiellement conforme",
            "non-conforme"});
            this.textBox3.Location = new System.Drawing.Point(290, 94);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 40);
            this.textBox3.TabIndex = 178;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(134, 494);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(180, 32);
            this.label21.TabIndex = 180;
            this.label21.Text = "Score d\'impact";
            // 
            // scordimpact2
            // 
            this.scordimpact2.FormattingEnabled = true;
            this.scordimpact2.Items.AddRange(new object[] {
            "Faible",
            "moyen",
            "élevée"});
            this.scordimpact2.Location = new System.Drawing.Point(348, 488);
            this.scordimpact2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.scordimpact2.Name = "scordimpact2";
            this.scordimpact2.Size = new System.Drawing.Size(242, 40);
            this.scordimpact2.TabIndex = 183;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 32);
            this.label8.TabIndex = 177;
            this.label8.Text = "Niveau de conformité";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(13, 439);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(317, 32);
            this.label19.TabIndex = 179;
            this.label19.Text = "Penalité de non_conformité";
            // 
            // penalite2
            // 
            this.penalite2.FormattingEnabled = true;
            this.penalite2.Items.AddRange(new object[] {
            "Administratif",
            "juridique",
            "perte financiére",
            "réputation"});
            this.penalite2.Location = new System.Drawing.Point(348, 430);
            this.penalite2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.penalite2.Name = "penalite2";
            this.penalite2.Size = new System.Drawing.Size(242, 40);
            this.penalite2.TabIndex = 184;
            this.penalite2.SelectedIndexChanged += new System.EventHandler(this.penalite2_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Location = new System.Drawing.Point(897, 4);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(19, 2014);
            this.panel7.TabIndex = 179;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Licence.Properties.Resources.Artboard_61;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.structureg);
            this.panel6.Controls.Add(this.pointh);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.typev);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(890, 849);
            this.panel6.TabIndex = 179;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 855);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2078, 849);
            this.panel4.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::Licence.Properties.Resources.Artboard_61;
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.label24);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.recom);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.constat);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.repon);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(2078, 849);
            this.panel10.TabIndex = 190;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.impacth);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.pn_conf);
            this.panel5.Controls.Add(this.scorea);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.niveau);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.datesuivi2);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Location = new System.Drawing.Point(-6, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(896, 643);
            this.panel5.TabIndex = 179;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.OrangeRed;
            this.label25.Location = new System.Drawing.Point(60, 30);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(210, 37);
            this.label25.TabIndex = 191;
            this.label25.Text = "Parametrage";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.OrangeRed;
            this.label15.Location = new System.Drawing.Point(56, 443);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 37);
            this.label15.TabIndex = 173;
            this.label15.Text = "Decision ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 32);
            this.label7.TabIndex = 190;
            this.label7.Text = "impact";
            // 
            // impact2
            // 
            this.impact2.Location = new System.Drawing.Point(290, 147);
            this.impact2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.impact2.Multiline = true;
            this.impact2.Name = "impact2";
            this.impact2.Size = new System.Drawing.Size(345, 117);
            this.impact2.TabIndex = 182;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.OrangeRed;
            this.label20.Location = new System.Drawing.Point(-214, -62);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(210, 37);
            this.label20.TabIndex = 187;
            this.label20.Text = "Parametrage";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(82, 361);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(300, 39);
            this.label18.TabIndex = 178;
            this.label18.Text = "Date du prochain control";
            this.label18.UseCompatibleTextRendering = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.Color.OrangeRed;
            this.label22.Location = new System.Drawing.Point(-214, 288);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 37);
            this.label22.TabIndex = 186;
            this.label22.Text = "Decision ";
            // 
            // niveau
            // 
            this.niveau.FormattingEnabled = true;
            this.niveau.Items.AddRange(new object[] {
            "conforme",
            "partiellement conforme",
            "non-conforme"});
            this.niveau.Location = new System.Drawing.Point(385, 132);
            this.niveau.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.niveau.Name = "niveau";
            this.niveau.Size = new System.Drawing.Size(242, 40);
            this.niveau.TabIndex = 176;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(-214, 68);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 32);
            this.label23.TabIndex = 181;
            this.label23.Text = "Impact";
            // 
            // datesuivi2
            // 
            this.datesuivi2.Location = new System.Drawing.Point(385, 354);
            this.datesuivi2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.datesuivi2.Name = "datesuivi2";
            this.datesuivi2.Size = new System.Drawing.Size(212, 39);
            this.datesuivi2.TabIndex = 185;
            this.datesuivi2.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(125, 132);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(252, 32);
            this.label17.TabIndex = 189;
            this.label17.Text = "Niveau de conformité";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Location = new System.Drawing.Point(897, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(19, 1534);
            this.panel11.TabIndex = 191;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.Color.OrangeRed;
            this.label24.Location = new System.Drawing.Point(945, 35);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(244, 37);
            this.label24.TabIndex = 190;
            this.label24.Text = "Constat de suivi";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.Location = new System.Drawing.Point(897, -491);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(19, 2003);
            this.panel9.TabIndex = 191;
            // 
            // impacth
            // 
            this.impacth.Location = new System.Drawing.Point(385, 199);
            this.impacth.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.impacth.Multiline = true;
            this.impacth.Name = "impacth";
            this.impacth.Size = new System.Drawing.Size(440, 112);
            this.impacth.TabIndex = 193;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(176, 236);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 32);
            this.label12.TabIndex = 192;
            this.label12.Text = "Impact";
            // 
            // suivi2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Licence.Properties.Resources.Artboard_6;
            this.ClientSize = new System.Drawing.Size(2090, 1559);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "suivi2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.suivi2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label16;
        private Label label14;
        private ComboBox categorie;
        private Panel panel2;
        private Label type_de_reglment;
        private ComboBox m_typereg;
        private Label objet;
        private TextBox pd_objet;
        private Label nature;
        private Label label3;
        private TextBox nature5;
        private Label label13;
        private ComboBox typev;
        private Label label9;
        private TextBox pointh;
        private ComboBox pn_conf;
        private ComboBox scorea;
        private ComboBox structureg;
        private Label label11;
        private Label label10;
        private Label label6;
        private Label label5;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private Panel panel1;
        private TextBox repon;
        private TextBox recom;
        private TextBox constat;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label15;
        private ComboBox niveau;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox impact2;
        private TextBox datesuivi2;
        private ComboBox scordimpact2;
        private ComboBox penalite2;
        private Label label24;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private ComboBox textBox3;
        private Panel panel10;
        private Panel panel11;
        private Panel panel5;
        private Label label25;
        private Label label7;
        private Label label26;
        private TextBox impacth;
        private Label label12;
    }
}