namespace GUIOOPListBoxHibakezeles
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
            this.groupBoxAdatbevitel = new System.Windows.Forms.GroupBox();
            this.comboBoxOperaciosRendszer = new System.Windows.Forms.ComboBox();
            this.labelOperaciosRendszer = new System.Windows.Forms.Label();
            this.labelHibaTipus = new System.Windows.Forms.Label();
            this.comboBoxHibaTipusa = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelHibaSzoveg = new System.Windows.Forms.Label();
            this.listBoxHibauzenetek = new System.Windows.Forms.ListBox();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.buttonTorol = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.groupBoxSzamitasok = new System.Windows.Forms.GroupBox();
            this.labelDebianHibakSzama = new System.Windows.Forms.Label();
            this.labelWindows = new System.Windows.Forms.Label();
            this.labelMacOS = new System.Windows.Forms.Label();
            this.labelUSER = new System.Windows.Forms.Label();
            this.labelNemUserHibakSzama = new System.Windows.Forms.Label();
            this.groupBoxAdatbevitel.SuspendLayout();
            this.groupBoxSzamitasok.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAdatbevitel
            // 
            this.groupBoxAdatbevitel.Controls.Add(this.labelHibaSzoveg);
            this.groupBoxAdatbevitel.Controls.Add(this.textBox1);
            this.groupBoxAdatbevitel.Controls.Add(this.labelHibaTipus);
            this.groupBoxAdatbevitel.Controls.Add(this.comboBoxHibaTipusa);
            this.groupBoxAdatbevitel.Controls.Add(this.labelOperaciosRendszer);
            this.groupBoxAdatbevitel.Controls.Add(this.comboBoxOperaciosRendszer);
            this.groupBoxAdatbevitel.Location = new System.Drawing.Point(40, 26);
            this.groupBoxAdatbevitel.Name = "groupBoxAdatbevitel";
            this.groupBoxAdatbevitel.Size = new System.Drawing.Size(333, 180);
            this.groupBoxAdatbevitel.TabIndex = 0;
            this.groupBoxAdatbevitel.TabStop = false;
            this.groupBoxAdatbevitel.Text = "Adatbevitel";
            // 
            // comboBoxOperaciosRendszer
            // 
            this.comboBoxOperaciosRendszer.FormattingEnabled = true;
            this.comboBoxOperaciosRendszer.Items.AddRange(new object[] {
            "Debian",
            "Windows",
            "MacOs"});
            this.comboBoxOperaciosRendszer.Location = new System.Drawing.Point(140, 53);
            this.comboBoxOperaciosRendszer.Name = "comboBoxOperaciosRendszer";
            this.comboBoxOperaciosRendszer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOperaciosRendszer.TabIndex = 0;
            // 
            // labelOperaciosRendszer
            // 
            this.labelOperaciosRendszer.AutoSize = true;
            this.labelOperaciosRendszer.Location = new System.Drawing.Point(17, 53);
            this.labelOperaciosRendszer.Name = "labelOperaciosRendszer";
            this.labelOperaciosRendszer.Size = new System.Drawing.Size(98, 13);
            this.labelOperaciosRendszer.TabIndex = 1;
            this.labelOperaciosRendszer.Text = "Operációs rendszer";
            // 
            // labelHibaTipus
            // 
            this.labelHibaTipus.AutoSize = true;
            this.labelHibaTipus.Location = new System.Drawing.Point(17, 95);
            this.labelHibaTipus.Name = "labelHibaTipus";
            this.labelHibaTipus.Size = new System.Drawing.Size(60, 13);
            this.labelHibaTipus.TabIndex = 3;
            this.labelHibaTipus.Text = "Hiba tipusa";
            // 
            // comboBoxHibaTipusa
            // 
            this.comboBoxHibaTipusa.FormattingEnabled = true;
            this.comboBoxHibaTipusa.Items.AddRange(new object[] {
            "ERROR",
            "WARNING",
            "NOTICE",
            "USER ERROR",
            "USER WARNING",
            "USER NOTICE"});
            this.comboBoxHibaTipusa.Location = new System.Drawing.Point(140, 95);
            this.comboBoxHibaTipusa.Name = "comboBoxHibaTipusa";
            this.comboBoxHibaTipusa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHibaTipusa.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // labelHibaSzoveg
            // 
            this.labelHibaSzoveg.AutoSize = true;
            this.labelHibaSzoveg.Location = new System.Drawing.Point(17, 139);
            this.labelHibaSzoveg.Name = "labelHibaSzoveg";
            this.labelHibaSzoveg.Size = new System.Drawing.Size(72, 13);
            this.labelHibaSzoveg.TabIndex = 5;
            this.labelHibaSzoveg.Text = "Hiba szövege";
            // 
            // listBoxHibauzenetek
            // 
            this.listBoxHibauzenetek.FormattingEnabled = true;
            this.listBoxHibauzenetek.Location = new System.Drawing.Point(40, 233);
            this.listBoxHibauzenetek.Name = "listBoxHibauzenetek";
            this.listBoxHibauzenetek.Size = new System.Drawing.Size(333, 212);
            this.listBoxHibauzenetek.TabIndex = 1;
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(399, 262);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaad.TabIndex = 2;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            // 
            // buttonTorol
            // 
            this.buttonTorol.Location = new System.Drawing.Point(399, 314);
            this.buttonTorol.Name = "buttonTorol";
            this.buttonTorol.Size = new System.Drawing.Size(75, 23);
            this.buttonTorol.TabIndex = 3;
            this.buttonTorol.Text = "Töröl";
            this.buttonTorol.UseVisualStyleBackColor = true;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Location = new System.Drawing.Point(696, 415);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepes.TabIndex = 4;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            // 
            // groupBoxSzamitasok
            // 
            this.groupBoxSzamitasok.Controls.Add(this.labelNemUserHibakSzama);
            this.groupBoxSzamitasok.Controls.Add(this.labelUSER);
            this.groupBoxSzamitasok.Controls.Add(this.labelMacOS);
            this.groupBoxSzamitasok.Controls.Add(this.labelWindows);
            this.groupBoxSzamitasok.Controls.Add(this.labelDebianHibakSzama);
            this.groupBoxSzamitasok.Location = new System.Drawing.Point(497, 46);
            this.groupBoxSzamitasok.Name = "groupBoxSzamitasok";
            this.groupBoxSzamitasok.Size = new System.Drawing.Size(274, 291);
            this.groupBoxSzamitasok.TabIndex = 5;
            this.groupBoxSzamitasok.TabStop = false;
            this.groupBoxSzamitasok.Text = "Számítások";
            // 
            // labelDebianHibakSzama
            // 
            this.labelDebianHibakSzama.AutoSize = true;
            this.labelDebianHibakSzama.Location = new System.Drawing.Point(18, 33);
            this.labelDebianHibakSzama.Name = "labelDebianHibakSzama";
            this.labelDebianHibakSzama.Size = new System.Drawing.Size(106, 13);
            this.labelDebianHibakSzama.TabIndex = 0;
            this.labelDebianHibakSzama.Text = "Debián hibák száma:";
            // 
            // labelWindows
            // 
            this.labelWindows.AutoSize = true;
            this.labelWindows.Location = new System.Drawing.Point(18, 78);
            this.labelWindows.Name = "labelWindows";
            this.labelWindows.Size = new System.Drawing.Size(116, 13);
            this.labelWindows.TabIndex = 1;
            this.labelWindows.Text = "Windows hibák száma:";
            // 
            // labelMacOS
            // 
            this.labelMacOS.AutoSize = true;
            this.labelMacOS.Location = new System.Drawing.Point(18, 116);
            this.labelMacOS.Name = "labelMacOS";
            this.labelMacOS.Size = new System.Drawing.Size(108, 13);
            this.labelMacOS.TabIndex = 2;
            this.labelMacOS.Text = "MacOS hibák száma:";
            // 
            // labelUSER
            // 
            this.labelUSER.AutoSize = true;
            this.labelUSER.Location = new System.Drawing.Point(18, 198);
            this.labelUSER.Name = "labelUSER";
            this.labelUSER.Size = new System.Drawing.Size(102, 13);
            this.labelUSER.TabIndex = 3;
            this.labelUSER.Text = "USER hibák száma:";
            // 
            // labelNemUserHibakSzama
            // 
            this.labelNemUserHibakSzama.AutoSize = true;
            this.labelNemUserHibakSzama.Location = new System.Drawing.Point(18, 245);
            this.labelNemUserHibakSzama.Name = "labelNemUserHibakSzama";
            this.labelNemUserHibakSzama.Size = new System.Drawing.Size(127, 13);
            this.labelNemUserHibakSzama.TabIndex = 4;
            this.labelNemUserHibakSzama.Text = "Nem USER hibák száma:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxSzamitasok);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.buttonTorol);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.listBoxHibauzenetek);
            this.Controls.Add(this.groupBoxAdatbevitel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAdatbevitel.ResumeLayout(false);
            this.groupBoxAdatbevitel.PerformLayout();
            this.groupBoxSzamitasok.ResumeLayout(false);
            this.groupBoxSzamitasok.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdatbevitel;
        private System.Windows.Forms.Label labelHibaSzoveg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelHibaTipus;
        private System.Windows.Forms.ComboBox comboBoxHibaTipusa;
        private System.Windows.Forms.Label labelOperaciosRendszer;
        private System.Windows.Forms.ComboBox comboBoxOperaciosRendszer;
        private System.Windows.Forms.ListBox listBoxHibauzenetek;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Button buttonTorol;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonKilepes;
        private System.Windows.Forms.GroupBox groupBoxSzamitasok;
        private System.Windows.Forms.Label labelNemUserHibakSzama;
        private System.Windows.Forms.Label labelUSER;
        private System.Windows.Forms.Label labelMacOS;
        private System.Windows.Forms.Label labelWindows;
        private System.Windows.Forms.Label labelDebianHibakSzama;
    }
}

