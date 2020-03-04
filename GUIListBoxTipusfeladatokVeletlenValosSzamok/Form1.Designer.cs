namespace GUIListBoxTipusfeladatokVeletlenSzamok
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVeletlenSzamokSzama = new System.Windows.Forms.ComboBox();
            this.listBoxValosSzamok = new System.Windows.Forms.ListBox();
            this.buttonFeltolt = new System.Windows.Forms.Button();
            this.buttonSzamolas = new System.Windows.Forms.Button();
            this.labelOsszeg = new System.Windows.Forms.Label();
            this.textBoxOsszeg = new System.Windows.Forms.TextBox();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.labelAtlag = new System.Windows.Forms.Label();
            this.textBoxAtlag = new System.Windows.Forms.TextBox();
            this.labelLegkisebb = new System.Windows.Forms.Label();
            this.textBoxLegnagyobbSzam = new System.Windows.Forms.TextBox();
            this.labelLegnagyobbSzam = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPozitvSzamokKozolLegkisebb = new System.Windows.Forms.Label();
            this.textBoxPozitivSzamokKozulLegkisebb = new System.Windows.Forms.TextBox();
            this.labelNegativSzamokKozulLegnagyobb = new System.Windows.Forms.Label();
            this.textBoxNegativSzamokKozulLegnagyobb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Véletlen számok száma:";
            // 
            // comboBoxVeletlenSzamokSzama
            // 
            this.comboBoxVeletlenSzamokSzama.FormattingEnabled = true;
            this.comboBoxVeletlenSzamokSzama.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.comboBoxVeletlenSzamokSzama.Location = new System.Drawing.Point(156, 13);
            this.comboBoxVeletlenSzamokSzama.Name = "comboBoxVeletlenSzamokSzama";
            this.comboBoxVeletlenSzamokSzama.Size = new System.Drawing.Size(82, 21);
            this.comboBoxVeletlenSzamokSzama.TabIndex = 1;
            // 
            // listBoxValosSzamok
            // 
            this.listBoxValosSzamok.FormattingEnabled = true;
            this.listBoxValosSzamok.Location = new System.Drawing.Point(460, 12);
            this.listBoxValosSzamok.Name = "listBoxValosSzamok";
            this.listBoxValosSzamok.Size = new System.Drawing.Size(244, 420);
            this.listBoxValosSzamok.TabIndex = 2;
            // 
            // buttonFeltolt
            // 
            this.buttonFeltolt.Location = new System.Drawing.Point(258, 12);
            this.buttonFeltolt.Name = "buttonFeltolt";
            this.buttonFeltolt.Size = new System.Drawing.Size(196, 23);
            this.buttonFeltolt.TabIndex = 3;
            this.buttonFeltolt.Text = "Feltölt véletlen valós számokkal";
            this.buttonFeltolt.UseVisualStyleBackColor = true;
            // 
            // buttonSzamolas
            // 
            this.buttonSzamolas.Location = new System.Drawing.Point(16, 59);
            this.buttonSzamolas.Name = "buttonSzamolas";
            this.buttonSzamolas.Size = new System.Drawing.Size(144, 23);
            this.buttonSzamolas.TabIndex = 4;
            this.buttonSzamolas.Text = "Számolás";
            this.buttonSzamolas.UseVisualStyleBackColor = true;
            // 
            // labelOsszeg
            // 
            this.labelOsszeg.AutoSize = true;
            this.labelOsszeg.Location = new System.Drawing.Point(13, 104);
            this.labelOsszeg.Name = "labelOsszeg";
            this.labelOsszeg.Size = new System.Drawing.Size(45, 13);
            this.labelOsszeg.TabIndex = 5;
            this.labelOsszeg.Text = "Összeg:";
            // 
            // textBoxOsszeg
            // 
            this.textBoxOsszeg.Location = new System.Drawing.Point(75, 104);
            this.textBoxOsszeg.Name = "textBoxOsszeg";
            this.textBoxOsszeg.ReadOnly = true;
            this.textBoxOsszeg.Size = new System.Drawing.Size(121, 20);
            this.textBoxOsszeg.TabIndex = 6;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Location = new System.Drawing.Point(560, 466);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(144, 23);
            this.buttonKilepes.TabIndex = 7;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            // 
            // labelAtlag
            // 
            this.labelAtlag.AutoSize = true;
            this.labelAtlag.Location = new System.Drawing.Point(12, 144);
            this.labelAtlag.Name = "labelAtlag";
            this.labelAtlag.Size = new System.Drawing.Size(31, 13);
            this.labelAtlag.TabIndex = 8;
            this.labelAtlag.Text = "Átlag";
            // 
            // textBoxAtlag
            // 
            this.textBoxAtlag.Location = new System.Drawing.Point(75, 144);
            this.textBoxAtlag.Name = "textBoxAtlag";
            this.textBoxAtlag.ReadOnly = true;
            this.textBoxAtlag.Size = new System.Drawing.Size(121, 20);
            this.textBoxAtlag.TabIndex = 9;
            // 
            // labelLegkisebb
            // 
            this.labelLegkisebb.AutoSize = true;
            this.labelLegkisebb.Location = new System.Drawing.Point(12, 188);
            this.labelLegkisebb.Name = "labelLegkisebb";
            this.labelLegkisebb.Size = new System.Drawing.Size(86, 13);
            this.labelLegkisebb.TabIndex = 10;
            this.labelLegkisebb.Text = "Legkisebb szám:";
            // 
            // textBoxLegnagyobbSzam
            // 
            this.textBoxLegnagyobbSzam.Location = new System.Drawing.Point(114, 181);
            this.textBoxLegnagyobbSzam.Name = "textBoxLegnagyobbSzam";
            this.textBoxLegnagyobbSzam.ReadOnly = true;
            this.textBoxLegnagyobbSzam.Size = new System.Drawing.Size(82, 20);
            this.textBoxLegnagyobbSzam.TabIndex = 11;
            // 
            // labelLegnagyobbSzam
            // 
            this.labelLegnagyobbSzam.AutoSize = true;
            this.labelLegnagyobbSzam.Location = new System.Drawing.Point(12, 220);
            this.labelLegnagyobbSzam.Name = "labelLegnagyobbSzam";
            this.labelLegnagyobbSzam.Size = new System.Drawing.Size(96, 13);
            this.labelLegnagyobbSzam.TabIndex = 12;
            this.labelLegnagyobbSzam.Text = "Legnagyobb szám:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 13;
            // 
            // labelPozitvSzamokKozolLegkisebb
            // 
            this.labelPozitvSzamokKozolLegkisebb.AutoSize = true;
            this.labelPozitvSzamokKozolLegkisebb.Location = new System.Drawing.Point(13, 270);
            this.labelPozitvSzamokKozolLegkisebb.Name = "labelPozitvSzamokKozolLegkisebb";
            this.labelPozitvSzamokKozolLegkisebb.Size = new System.Drawing.Size(167, 13);
            this.labelPozitvSzamokKozolLegkisebb.TabIndex = 14;
            this.labelPozitvSzamokKozolLegkisebb.Text = "Pozitív számok közül a legkisebb:";
            // 
            // textBoxPozitivSzamokKozulLegkisebb
            // 
            this.textBoxPozitivSzamokKozulLegkisebb.Location = new System.Drawing.Point(219, 263);
            this.textBoxPozitivSzamokKozulLegkisebb.Name = "textBoxPozitivSzamokKozulLegkisebb";
            this.textBoxPozitivSzamokKozulLegkisebb.ReadOnly = true;
            this.textBoxPozitivSzamokKozulLegkisebb.Size = new System.Drawing.Size(96, 20);
            this.textBoxPozitivSzamokKozulLegkisebb.TabIndex = 15;
            // 
            // labelNegativSzamokKozulLegnagyobb
            // 
            this.labelNegativSzamokKozulLegnagyobb.AutoSize = true;
            this.labelNegativSzamokKozulLegnagyobb.Location = new System.Drawing.Point(13, 304);
            this.labelNegativSzamokKozulLegnagyobb.Name = "labelNegativSzamokKozulLegnagyobb";
            this.labelNegativSzamokKozulLegnagyobb.Size = new System.Drawing.Size(183, 13);
            this.labelNegativSzamokKozulLegnagyobb.TabIndex = 16;
            this.labelNegativSzamokKozulLegnagyobb.Text = "Negatív számok közül a legnagyobb:";
            // 
            // textBoxNegativSzamokKozulLegnagyobb
            // 
            this.textBoxNegativSzamokKozulLegnagyobb.Location = new System.Drawing.Point(219, 301);
            this.textBoxNegativSzamokKozulLegnagyobb.Name = "textBoxNegativSzamokKozulLegnagyobb";
            this.textBoxNegativSzamokKozulLegnagyobb.ReadOnly = true;
            this.textBoxNegativSzamokKozulLegnagyobb.Size = new System.Drawing.Size(96, 20);
            this.textBoxNegativSzamokKozulLegnagyobb.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 519);
            this.Controls.Add(this.textBoxNegativSzamokKozulLegnagyobb);
            this.Controls.Add(this.labelNegativSzamokKozulLegnagyobb);
            this.Controls.Add(this.textBoxPozitivSzamokKozulLegkisebb);
            this.Controls.Add(this.labelPozitvSzamokKozolLegkisebb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelLegnagyobbSzam);
            this.Controls.Add(this.textBoxLegnagyobbSzam);
            this.Controls.Add(this.labelLegkisebb);
            this.Controls.Add(this.textBoxAtlag);
            this.Controls.Add(this.labelAtlag);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.textBoxOsszeg);
            this.Controls.Add(this.labelOsszeg);
            this.Controls.Add(this.buttonSzamolas);
            this.Controls.Add(this.buttonFeltolt);
            this.Controls.Add(this.listBoxValosSzamok);
            this.Controls.Add(this.comboBoxVeletlenSzamokSzama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVeletlenSzamokSzama;
        private System.Windows.Forms.ListBox listBoxValosSzamok;
        private System.Windows.Forms.Button buttonFeltolt;
        private System.Windows.Forms.Button buttonSzamolas;
        private System.Windows.Forms.Label labelOsszeg;
        private System.Windows.Forms.TextBox textBoxOsszeg;
        private System.Windows.Forms.Button buttonKilepes;
        private System.Windows.Forms.Label labelAtlag;
        private System.Windows.Forms.TextBox textBoxAtlag;
        private System.Windows.Forms.Label labelLegkisebb;
        private System.Windows.Forms.TextBox textBoxLegnagyobbSzam;
        private System.Windows.Forms.Label labelLegnagyobbSzam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPozitvSzamokKozolLegkisebb;
        private System.Windows.Forms.TextBox textBoxPozitivSzamokKozulLegkisebb;
        private System.Windows.Forms.Label labelNegativSzamokKozulLegnagyobb;
        private System.Windows.Forms.TextBox textBoxNegativSzamokKozulLegnagyobb;
    }
}

