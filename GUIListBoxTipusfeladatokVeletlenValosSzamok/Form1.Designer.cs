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
            this.listBoxSzamok = new System.Windows.Forms.ListBox();
            this.buttonFeltolt = new System.Windows.Forms.Button();
            this.buttonSzamolas = new System.Windows.Forms.Button();
            this.labelOsszeg = new System.Windows.Forms.Label();
            this.textBoxOsszeg = new System.Windows.Forms.TextBox();
            this.buttonKilepes = new System.Windows.Forms.Button();
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
            this.comboBoxVeletlenSzamokSzama.Size = new System.Drawing.Size(138, 21);
            this.comboBoxVeletlenSzamokSzama.TabIndex = 1;
            // 
            // listBoxSzamok
            // 
            this.listBoxSzamok.FormattingEnabled = true;
            this.listBoxSzamok.Location = new System.Drawing.Point(460, 12);
            this.listBoxSzamok.Name = "listBoxSzamok";
            this.listBoxSzamok.Size = new System.Drawing.Size(244, 420);
            this.listBoxSzamok.TabIndex = 2;
            // 
            // buttonFeltolt
            // 
            this.buttonFeltolt.Location = new System.Drawing.Point(310, 12);
            this.buttonFeltolt.Name = "buttonFeltolt";
            this.buttonFeltolt.Size = new System.Drawing.Size(144, 23);
            this.buttonFeltolt.TabIndex = 3;
            this.buttonFeltolt.Text = "Feltölt véletlen számokkal";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 519);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.textBoxOsszeg);
            this.Controls.Add(this.labelOsszeg);
            this.Controls.Add(this.buttonSzamolas);
            this.Controls.Add(this.buttonFeltolt);
            this.Controls.Add(this.listBoxSzamok);
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
        private System.Windows.Forms.ListBox listBoxSzamok;
        private System.Windows.Forms.Button buttonFeltolt;
        private System.Windows.Forms.Button buttonSzamolas;
        private System.Windows.Forms.Label labelOsszeg;
        private System.Windows.Forms.TextBox textBoxOsszeg;
        private System.Windows.Forms.Button buttonKilepes;
    }
}

