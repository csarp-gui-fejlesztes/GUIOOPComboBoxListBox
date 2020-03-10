namespace DiakHianyzasok
{
    partial class Form1
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
            this.comboBoxOsztaly = new System.Windows.Forms.ComboBox();
            this.labelOsztaly = new System.Windows.Forms.Label();
            this.labelHianyzasokSzama = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxHonap = new System.Windows.Forms.ComboBox();
            this.labelHonap = new System.Windows.Forms.Label();
            this.groupBoxOsztalyokHaviHianyzasai = new System.Windows.Forms.GroupBox();
            this.listBoxOsszesito = new System.Windows.Forms.ListBox();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.buttonTorol = new System.Windows.Forms.Button();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.groupBoxOsztalyiStatisztika = new System.Windows.Forms.GroupBox();
            this.label9a = new System.Windows.Forms.Label();
            this.label9b = new System.Windows.Forms.Label();
            this.label9c = new System.Windows.Forms.Label();
            this.buttonSzamolOsztalyStatisztika = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelValasztottHonap = new System.Windows.Forms.Label();
            this.labelOsszhianyzas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxOsztalyokHaviHianyzasai.SuspendLayout();
            this.groupBoxOsztalyiStatisztika.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxOsztaly
            // 
            this.comboBoxOsztaly.FormattingEnabled = true;
            this.comboBoxOsztaly.Items.AddRange(new object[] {
            "9.a",
            "9.b",
            "9.c"});
            this.comboBoxOsztaly.Location = new System.Drawing.Point(157, 79);
            this.comboBoxOsztaly.Name = "comboBoxOsztaly";
            this.comboBoxOsztaly.Size = new System.Drawing.Size(120, 21);
            this.comboBoxOsztaly.TabIndex = 2;
            // 
            // labelOsztaly
            // 
            this.labelOsztaly.AutoSize = true;
            this.labelOsztaly.Location = new System.Drawing.Point(31, 87);
            this.labelOsztaly.Name = "labelOsztaly";
            this.labelOsztaly.Size = new System.Drawing.Size(41, 13);
            this.labelOsztaly.TabIndex = 3;
            this.labelOsztaly.Text = "Osztály";
            // 
            // labelHianyzasokSzama
            // 
            this.labelHianyzasokSzama.AutoSize = true;
            this.labelHianyzasokSzama.Location = new System.Drawing.Point(31, 127);
            this.labelHianyzasokSzama.Name = "labelHianyzasokSzama";
            this.labelHianyzasokSzama.Size = new System.Drawing.Size(98, 13);
            this.labelHianyzasokSzama.TabIndex = 4;
            this.labelHianyzasokSzama.Text = "Hiányzások száma:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(157, 125);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // comboBoxHonap
            // 
            this.comboBoxHonap.FormattingEnabled = true;
            this.comboBoxHonap.Items.AddRange(new object[] {
            "szeptember",
            "október",
            "november",
            "december",
            "január",
            "február",
            "március",
            "április",
            "május",
            "június"});
            this.comboBoxHonap.Location = new System.Drawing.Point(157, 35);
            this.comboBoxHonap.Name = "comboBoxHonap";
            this.comboBoxHonap.Size = new System.Drawing.Size(120, 21);
            this.comboBoxHonap.TabIndex = 7;
            // 
            // labelHonap
            // 
            this.labelHonap.AutoSize = true;
            this.labelHonap.Location = new System.Drawing.Point(31, 38);
            this.labelHonap.Name = "labelHonap";
            this.labelHonap.Size = new System.Drawing.Size(42, 13);
            this.labelHonap.TabIndex = 8;
            this.labelHonap.Text = "Hónap:";
            // 
            // groupBoxOsztalyokHaviHianyzasai
            // 
            this.groupBoxOsztalyokHaviHianyzasai.Controls.Add(this.labelHonap);
            this.groupBoxOsztalyokHaviHianyzasai.Controls.Add(this.labelOsztaly);
            this.groupBoxOsztalyokHaviHianyzasai.Controls.Add(this.comboBoxHonap);
            this.groupBoxOsztalyokHaviHianyzasai.Controls.Add(this.comboBoxOsztaly);
            this.groupBoxOsztalyokHaviHianyzasai.Controls.Add(this.labelHianyzasokSzama);
            this.groupBoxOsztalyokHaviHianyzasai.Controls.Add(this.numericUpDown1);
            this.groupBoxOsztalyokHaviHianyzasai.Location = new System.Drawing.Point(21, 12);
            this.groupBoxOsztalyokHaviHianyzasai.Name = "groupBoxOsztalyokHaviHianyzasai";
            this.groupBoxOsztalyokHaviHianyzasai.Size = new System.Drawing.Size(341, 166);
            this.groupBoxOsztalyokHaviHianyzasai.TabIndex = 6;
            this.groupBoxOsztalyokHaviHianyzasai.TabStop = false;
            this.groupBoxOsztalyokHaviHianyzasai.Text = "Osztályok havi hiányzásai:";
            // 
            // listBoxOsszesito
            // 
            this.listBoxOsszesito.FormattingEnabled = true;
            this.listBoxOsszesito.Location = new System.Drawing.Point(21, 245);
            this.listBoxOsszesito.Name = "listBoxOsszesito";
            this.listBoxOsszesito.Size = new System.Drawing.Size(341, 264);
            this.listBoxOsszesito.TabIndex = 7;
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(21, 200);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaad.TabIndex = 8;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            // 
            // buttonTorol
            // 
            this.buttonTorol.Location = new System.Drawing.Point(150, 200);
            this.buttonTorol.Name = "buttonTorol";
            this.buttonTorol.Size = new System.Drawing.Size(75, 23);
            this.buttonTorol.TabIndex = 9;
            this.buttonTorol.Text = "Töröl";
            this.buttonTorol.UseVisualStyleBackColor = true;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Location = new System.Drawing.Point(507, 444);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepes.TabIndex = 10;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            // 
            // groupBoxOsztalyiStatisztika
            // 
            this.groupBoxOsztalyiStatisztika.Controls.Add(this.buttonSzamolOsztalyStatisztika);
            this.groupBoxOsztalyiStatisztika.Controls.Add(this.label9c);
            this.groupBoxOsztalyiStatisztika.Controls.Add(this.label9b);
            this.groupBoxOsztalyiStatisztika.Controls.Add(this.label9a);
            this.groupBoxOsztalyiStatisztika.Location = new System.Drawing.Point(432, 22);
            this.groupBoxOsztalyiStatisztika.Name = "groupBoxOsztalyiStatisztika";
            this.groupBoxOsztalyiStatisztika.Size = new System.Drawing.Size(266, 156);
            this.groupBoxOsztalyiStatisztika.TabIndex = 11;
            this.groupBoxOsztalyiStatisztika.TabStop = false;
            this.groupBoxOsztalyiStatisztika.Text = "Osztály statisztika";
            // 
            // label9a
            // 
            this.label9a.AutoSize = true;
            this.label9a.Location = new System.Drawing.Point(7, 32);
            this.label9a.Name = "label9a";
            this.label9a.Size = new System.Drawing.Size(131, 13);
            this.label9a.TabIndex = 0;
            this.label9a.Text = "9.a osztály összhiányzása:";
            // 
            // label9b
            // 
            this.label9b.AutoSize = true;
            this.label9b.Location = new System.Drawing.Point(7, 69);
            this.label9b.Name = "label9b";
            this.label9b.Size = new System.Drawing.Size(131, 13);
            this.label9b.TabIndex = 1;
            this.label9b.Text = "9.b osztály összhiányzása:";
            // 
            // label9c
            // 
            this.label9c.AutoSize = true;
            this.label9c.Location = new System.Drawing.Point(7, 104);
            this.label9c.Name = "label9c";
            this.label9c.Size = new System.Drawing.Size(131, 13);
            this.label9c.TabIndex = 2;
            this.label9c.Text = "9.c osztály összhiányzása:";
            // 
            // buttonSzamolOsztalyStatisztika
            // 
            this.buttonSzamolOsztalyStatisztika.Location = new System.Drawing.Point(6, 127);
            this.buttonSzamolOsztalyStatisztika.Name = "buttonSzamolOsztalyStatisztika";
            this.buttonSzamolOsztalyStatisztika.Size = new System.Drawing.Size(244, 23);
            this.buttonSzamolOsztalyStatisztika.TabIndex = 12;
            this.buttonSzamolOsztalyStatisztika.Text = "Számol osztály statisztikát";
            this.buttonSzamolOsztalyStatisztika.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelOsszhianyzas);
            this.groupBox.Controls.Add(this.labelValasztottHonap);
            this.groupBox.Controls.Add(this.comboBox1);
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Location = new System.Drawing.Point(432, 216);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(266, 156);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Havi statisztika";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Számol havi statisztikát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "szeptember",
            "október",
            "november",
            "december",
            "január",
            "február",
            "március",
            "április",
            "május",
            "június"});
            this.comboBox1.Location = new System.Drawing.Point(130, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // labelValasztottHonap
            // 
            this.labelValasztottHonap.AutoSize = true;
            this.labelValasztottHonap.Location = new System.Drawing.Point(7, 38);
            this.labelValasztottHonap.Name = "labelValasztottHonap";
            this.labelValasztottHonap.Size = new System.Drawing.Size(89, 13);
            this.labelValasztottHonap.TabIndex = 9;
            this.labelValasztottHonap.Text = "Választott hónap:";
            // 
            // labelOsszhianyzas
            // 
            this.labelOsszhianyzas.AutoSize = true;
            this.labelOsszhianyzas.Location = new System.Drawing.Point(7, 94);
            this.labelOsszhianyzas.Name = "labelOsszhianyzas";
            this.labelOsszhianyzas.Size = new System.Drawing.Size(97, 13);
            this.labelOsszhianyzas.TabIndex = 13;
            this.labelOsszhianyzas.Text = "Havi összhiányzás:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBoxOsztalyiStatisztika);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.buttonTorol);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.listBoxOsszesito);
            this.Controls.Add(this.groupBoxOsztalyokHaviHianyzasai);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxOsztalyokHaviHianyzasai.ResumeLayout(false);
            this.groupBoxOsztalyokHaviHianyzasai.PerformLayout();
            this.groupBoxOsztalyiStatisztika.ResumeLayout(false);
            this.groupBoxOsztalyiStatisztika.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOsztaly;
        private System.Windows.Forms.Label labelOsztaly;
        private System.Windows.Forms.Label labelHianyzasokSzama;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBoxHonap;
        private System.Windows.Forms.Label labelHonap;
        private System.Windows.Forms.GroupBox groupBoxOsztalyokHaviHianyzasai;
        private System.Windows.Forms.ListBox listBoxOsszesito;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Button buttonTorol;
        private System.Windows.Forms.Button buttonKilepes;
        private System.Windows.Forms.GroupBox groupBoxOsztalyiStatisztika;
        private System.Windows.Forms.Button buttonSzamolOsztalyStatisztika;
        private System.Windows.Forms.Label label9c;
        private System.Windows.Forms.Label label9b;
        private System.Windows.Forms.Label label9a;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelOsszhianyzas;
        private System.Windows.Forms.Label labelValasztottHonap;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

