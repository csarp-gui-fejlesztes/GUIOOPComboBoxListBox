namespace GUIOOPComboBoxListBox
{
    partial class FormGyumolcs
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
            this.labelGyumolcs = new System.Windows.Forms.Label();
            this.comboBoxGyumolcsok = new System.Windows.Forms.ComboBox();
            this.labelMennyiseg = new System.Windows.Forms.Label();
            this.numericUpDownMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.buttonTorol = new System.Windows.Forms.Button();
            this.listBoxVasaroltGyumolcsMennyisegek = new System.Windows.Forms.ListBox();
            this.labelOsszmennyiseg = new System.Windows.Forms.Label();
            this.textBoxOsszmennyiseg = new System.Windows.Forms.TextBox();
            this.buttonKilepes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGyumolcs
            // 
            this.labelGyumolcs.AutoSize = true;
            this.labelGyumolcs.Location = new System.Drawing.Point(13, 23);
            this.labelGyumolcs.Name = "labelGyumolcs";
            this.labelGyumolcs.Size = new System.Drawing.Size(125, 13);
            this.labelGyumolcs.TabIndex = 0;
            this.labelGyumolcs.Text = "Válassza ki a gyümölcsöt";
            // 
            // comboBoxGyumolcsok
            // 
            this.comboBoxGyumolcsok.FormattingEnabled = true;
            this.comboBoxGyumolcsok.Items.AddRange(new object[] {
            "alma",
            "eper",
            "áfonya",
            "banán",
            "szőlő ",
            "körte",
            "narancs",
            "kivi",
            "mandarin"});
            this.comboBoxGyumolcsok.Location = new System.Drawing.Point(164, 14);
            this.comboBoxGyumolcsok.Name = "comboBoxGyumolcsok";
            this.comboBoxGyumolcsok.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGyumolcsok.TabIndex = 1;
            // 
            // labelMennyiseg
            // 
            this.labelMennyiseg.AutoSize = true;
            this.labelMennyiseg.Location = new System.Drawing.Point(13, 69);
            this.labelMennyiseg.Name = "labelMennyiseg";
            this.labelMennyiseg.Size = new System.Drawing.Size(87, 13);
            this.labelMennyiseg.TabIndex = 2;
            this.labelMennyiseg.Text = "Mennyit vásárol?";
            // 
            // numericUpDownMennyiseg
            // 
            this.numericUpDownMennyiseg.Location = new System.Drawing.Point(164, 61);
            this.numericUpDownMennyiseg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMennyiseg.Name = "numericUpDownMennyiseg";
            this.numericUpDownMennyiseg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMennyiseg.TabIndex = 3;
            this.numericUpDownMennyiseg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(16, 109);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaad.TabIndex = 4;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            // 
            // buttonTorol
            // 
            this.buttonTorol.Location = new System.Drawing.Point(152, 109);
            this.buttonTorol.Name = "buttonTorol";
            this.buttonTorol.Size = new System.Drawing.Size(75, 23);
            this.buttonTorol.TabIndex = 5;
            this.buttonTorol.Text = "Töröl";
            this.buttonTorol.UseVisualStyleBackColor = true;
            // 
            // listBoxVasaroltGyumolcsMennyisegek
            // 
            this.listBoxVasaroltGyumolcsMennyisegek.FormattingEnabled = true;
            this.listBoxVasaroltGyumolcsMennyisegek.Location = new System.Drawing.Point(16, 153);
            this.listBoxVasaroltGyumolcsMennyisegek.Name = "listBoxVasaroltGyumolcsMennyisegek";
            this.listBoxVasaroltGyumolcsMennyisegek.Size = new System.Drawing.Size(279, 95);
            this.listBoxVasaroltGyumolcsMennyisegek.TabIndex = 6;
            // 
            // labelOsszmennyiseg
            // 
            this.labelOsszmennyiseg.AutoSize = true;
            this.labelOsszmennyiseg.Location = new System.Drawing.Point(13, 269);
            this.labelOsszmennyiseg.Name = "labelOsszmennyiseg";
            this.labelOsszmennyiseg.Size = new System.Drawing.Size(80, 13);
            this.labelOsszmennyiseg.TabIndex = 7;
            this.labelOsszmennyiseg.Text = "Összmennyiseg";
            // 
            // textBoxOsszmennyiseg
            // 
            this.textBoxOsszmennyiseg.Location = new System.Drawing.Point(195, 269);
            this.textBoxOsszmennyiseg.Name = "textBoxOsszmennyiseg";
            this.textBoxOsszmennyiseg.ReadOnly = true;
            this.textBoxOsszmennyiseg.Size = new System.Drawing.Size(100, 20);
            this.textBoxOsszmennyiseg.TabIndex = 8;
            this.textBoxOsszmennyiseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Location = new System.Drawing.Point(220, 316);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepes.TabIndex = 9;
            this.buttonKilepes.Text = "Kilepes";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 351);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.textBoxOsszmennyiseg);
            this.Controls.Add(this.labelOsszmennyiseg);
            this.Controls.Add(this.listBoxVasaroltGyumolcsMennyisegek);
            this.Controls.Add(this.buttonTorol);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.numericUpDownMennyiseg);
            this.Controls.Add(this.labelMennyiseg);
            this.Controls.Add(this.comboBoxGyumolcsok);
            this.Controls.Add(this.labelGyumolcs);
            this.Name = "Form1";
            this.Text = "Gyümölcs mennyiség";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGyumolcs;
        private System.Windows.Forms.ComboBox comboBoxGyumolcsok;
        private System.Windows.Forms.Label labelMennyiseg;
        private System.Windows.Forms.NumericUpDown numericUpDownMennyiseg;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Button buttonTorol;
        private System.Windows.Forms.ListBox listBoxVasaroltGyumolcsMennyisegek;
        private System.Windows.Forms.Label labelOsszmennyiseg;
        private System.Windows.Forms.TextBox textBoxOsszmennyiseg;
        private System.Windows.Forms.Button buttonKilepes;
    }
}

