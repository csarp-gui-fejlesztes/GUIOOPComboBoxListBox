namespace AutokProjekt
{
    partial class FormAutok
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
            this.labelMarka = new System.Windows.Forms.Label();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.numericUpDownEvjarat = new System.Windows.Forms.NumericUpDown();
            this.labelEvjarat = new System.Windows.Forms.Label();
            this.groupBoxUzemanyag = new System.Windows.Forms.GroupBox();
            this.radioButtonElektormos = new System.Windows.Forms.RadioButton();
            this.radioButtonDizel = new System.Windows.Forms.RadioButton();
            this.radioButtonBenzin = new System.Windows.Forms.RadioButton();
            this.radioButtonGaz = new System.Windows.Forms.RadioButton();
            this.listBoxAutok = new System.Windows.Forms.ListBox();
            this.buttonHozzadas = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.labelGaz = new System.Windows.Forms.Label();
            this.labelBenzin = new System.Windows.Forms.Label();
            this.textBoxGazDb = new System.Windows.Forms.TextBox();
            this.textBoxBenzinDb = new System.Windows.Forms.TextBox();
            this.textBoxDiselDb = new System.Windows.Forms.TextBox();
            this.textBoxElektromosDb = new System.Windows.Forms.TextBox();
            this.labelDiesel = new System.Windows.Forms.Label();
            this.labelElektromosDb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEvjarat)).BeginInit();
            this.groupBoxUzemanyag.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Location = new System.Drawing.Point(32, 26);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(61, 13);
            this.labelMarka.TabIndex = 0;
            this.labelMarka.Text = "Autó márka";
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Items.AddRange(new object[] {
            "lada",
            "bmw",
            "audi",
            "toyota",
            "mercedes"});
            this.comboBoxMarka.Location = new System.Drawing.Point(196, 17);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(185, 21);
            this.comboBoxMarka.TabIndex = 1;
            // 
            // numericUpDownEvjarat
            // 
            this.numericUpDownEvjarat.Location = new System.Drawing.Point(261, 62);
            this.numericUpDownEvjarat.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDownEvjarat.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numericUpDownEvjarat.Name = "numericUpDownEvjarat";
            this.numericUpDownEvjarat.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEvjarat.TabIndex = 2;
            this.numericUpDownEvjarat.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // labelEvjarat
            // 
            this.labelEvjarat.AutoSize = true;
            this.labelEvjarat.Location = new System.Drawing.Point(32, 64);
            this.labelEvjarat.Name = "labelEvjarat";
            this.labelEvjarat.Size = new System.Drawing.Size(40, 13);
            this.labelEvjarat.TabIndex = 3;
            this.labelEvjarat.Text = "Évjárat";
            // 
            // groupBoxUzemanyag
            // 
            this.groupBoxUzemanyag.Controls.Add(this.radioButtonElektormos);
            this.groupBoxUzemanyag.Controls.Add(this.radioButtonDizel);
            this.groupBoxUzemanyag.Controls.Add(this.radioButtonBenzin);
            this.groupBoxUzemanyag.Controls.Add(this.radioButtonGaz);
            this.groupBoxUzemanyag.Location = new System.Drawing.Point(35, 105);
            this.groupBoxUzemanyag.Name = "groupBoxUzemanyag";
            this.groupBoxUzemanyag.Size = new System.Drawing.Size(346, 42);
            this.groupBoxUzemanyag.TabIndex = 4;
            this.groupBoxUzemanyag.TabStop = false;
            this.groupBoxUzemanyag.Text = "Üzemanyag";
            // 
            // radioButtonElektormos
            // 
            this.radioButtonElektormos.AutoSize = true;
            this.radioButtonElektormos.Location = new System.Drawing.Point(226, 19);
            this.radioButtonElektormos.Name = "radioButtonElektormos";
            this.radioButtonElektormos.Size = new System.Drawing.Size(77, 17);
            this.radioButtonElektormos.TabIndex = 3;
            this.radioButtonElektormos.TabStop = true;
            this.radioButtonElektormos.Text = "Elektromos";
            this.radioButtonElektormos.UseVisualStyleBackColor = true;
            // 
            // radioButtonDizel
            // 
            this.radioButtonDizel.AutoSize = true;
            this.radioButtonDizel.Location = new System.Drawing.Point(161, 19);
            this.radioButtonDizel.Name = "radioButtonDizel";
            this.radioButtonDizel.Size = new System.Drawing.Size(54, 17);
            this.radioButtonDizel.TabIndex = 2;
            this.radioButtonDizel.TabStop = true;
            this.radioButtonDizel.Text = "Diesel";
            this.radioButtonDizel.UseVisualStyleBackColor = true;
            // 
            // radioButtonBenzin
            // 
            this.radioButtonBenzin.AutoSize = true;
            this.radioButtonBenzin.Location = new System.Drawing.Point(80, 19);
            this.radioButtonBenzin.Name = "radioButtonBenzin";
            this.radioButtonBenzin.Size = new System.Drawing.Size(57, 17);
            this.radioButtonBenzin.TabIndex = 1;
            this.radioButtonBenzin.TabStop = true;
            this.radioButtonBenzin.Text = "Benzin";
            this.radioButtonBenzin.UseVisualStyleBackColor = true;
            // 
            // radioButtonGaz
            // 
            this.radioButtonGaz.AutoSize = true;
            this.radioButtonGaz.Location = new System.Drawing.Point(6, 19);
            this.radioButtonGaz.Name = "radioButtonGaz";
            this.radioButtonGaz.Size = new System.Drawing.Size(44, 17);
            this.radioButtonGaz.TabIndex = 0;
            this.radioButtonGaz.TabStop = true;
            this.radioButtonGaz.Text = "Gáz";
            this.radioButtonGaz.UseVisualStyleBackColor = true;
            // 
            // listBoxAutok
            // 
            this.listBoxAutok.FormattingEnabled = true;
            this.listBoxAutok.Location = new System.Drawing.Point(35, 164);
            this.listBoxAutok.Name = "listBoxAutok";
            this.listBoxAutok.Size = new System.Drawing.Size(336, 238);
            this.listBoxAutok.TabIndex = 5;
            // 
            // buttonHozzadas
            // 
            this.buttonHozzadas.Location = new System.Drawing.Point(410, 164);
            this.buttonHozzadas.Name = "buttonHozzadas";
            this.buttonHozzadas.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzadas.TabIndex = 6;
            this.buttonHozzadas.Text = "Hozzáadás";
            this.buttonHozzadas.UseVisualStyleBackColor = true;
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(410, 212);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonTorles.TabIndex = 7;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.Location = new System.Drawing.Point(410, 379);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepes.TabIndex = 8;
            this.buttonKilepes.Text = "Kilépés";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            // 
            // labelGaz
            // 
            this.labelGaz.AutoSize = true;
            this.labelGaz.Location = new System.Drawing.Point(38, 409);
            this.labelGaz.Name = "labelGaz";
            this.labelGaz.Size = new System.Drawing.Size(155, 13);
            this.labelGaz.TabIndex = 9;
            this.labelGaz.Text = "Gáz üzemanyagú autók száma:";
            // 
            // labelBenzin
            // 
            this.labelBenzin.AutoSize = true;
            this.labelBenzin.Location = new System.Drawing.Point(38, 434);
            this.labelBenzin.Name = "labelBenzin";
            this.labelBenzin.Size = new System.Drawing.Size(168, 13);
            this.labelBenzin.TabIndex = 10;
            this.labelBenzin.Text = "Benzin üzemanyagú autók száma:";
            // 
            // textBoxGazDb
            // 
            this.textBoxGazDb.Location = new System.Drawing.Point(271, 409);
            this.textBoxGazDb.Name = "textBoxGazDb";
            this.textBoxGazDb.ReadOnly = true;
            this.textBoxGazDb.Size = new System.Drawing.Size(100, 20);
            this.textBoxGazDb.TabIndex = 11;
            // 
            // textBoxBenzinDb
            // 
            this.textBoxBenzinDb.Location = new System.Drawing.Point(271, 434);
            this.textBoxBenzinDb.Name = "textBoxBenzinDb";
            this.textBoxBenzinDb.ReadOnly = true;
            this.textBoxBenzinDb.Size = new System.Drawing.Size(100, 20);
            this.textBoxBenzinDb.TabIndex = 12;
            // 
            // textBoxDiselDb
            // 
            this.textBoxDiselDb.Location = new System.Drawing.Point(271, 457);
            this.textBoxDiselDb.Name = "textBoxDiselDb";
            this.textBoxDiselDb.ReadOnly = true;
            this.textBoxDiselDb.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiselDb.TabIndex = 13;
            // 
            // textBoxElektromosDb
            // 
            this.textBoxElektromosDb.Location = new System.Drawing.Point(271, 483);
            this.textBoxElektromosDb.Name = "textBoxElektromosDb";
            this.textBoxElektromosDb.ReadOnly = true;
            this.textBoxElektromosDb.Size = new System.Drawing.Size(100, 20);
            this.textBoxElektromosDb.TabIndex = 14;
            // 
            // labelDiesel
            // 
            this.labelDiesel.AutoSize = true;
            this.labelDiesel.Location = new System.Drawing.Point(38, 460);
            this.labelDiesel.Name = "labelDiesel";
            this.labelDiesel.Size = new System.Drawing.Size(165, 13);
            this.labelDiesel.TabIndex = 15;
            this.labelDiesel.Text = "Diesel üzemanyagú autók száma:";
            // 
            // labelElektromosDb
            // 
            this.labelElektromosDb.AutoSize = true;
            this.labelElektromosDb.Location = new System.Drawing.Point(38, 483);
            this.labelElektromosDb.Name = "labelElektromosDb";
            this.labelElektromosDb.Size = new System.Drawing.Size(182, 13);
            this.labelElektromosDb.TabIndex = 16;
            this.labelElektromosDb.Text = "Elektromos meghajtású autók száma:";
            // 
            // FormAutok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 517);
            this.Controls.Add(this.labelElektromosDb);
            this.Controls.Add(this.labelDiesel);
            this.Controls.Add(this.textBoxElektromosDb);
            this.Controls.Add(this.textBoxDiselDb);
            this.Controls.Add(this.textBoxBenzinDb);
            this.Controls.Add(this.textBoxGazDb);
            this.Controls.Add(this.labelBenzin);
            this.Controls.Add(this.labelGaz);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonHozzadas);
            this.Controls.Add(this.listBoxAutok);
            this.Controls.Add(this.groupBoxUzemanyag);
            this.Controls.Add(this.labelEvjarat);
            this.Controls.Add(this.numericUpDownEvjarat);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.labelMarka);
            this.Name = "FormAutok";
            this.Text = "Autók nyilvántartása";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEvjarat)).EndInit();
            this.groupBoxUzemanyag.ResumeLayout(false);
            this.groupBoxUzemanyag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.NumericUpDown numericUpDownEvjarat;
        private System.Windows.Forms.Label labelEvjarat;
        private System.Windows.Forms.GroupBox groupBoxUzemanyag;
        private System.Windows.Forms.RadioButton radioButtonElektormos;
        private System.Windows.Forms.RadioButton radioButtonDizel;
        private System.Windows.Forms.RadioButton radioButtonBenzin;
        private System.Windows.Forms.RadioButton radioButtonGaz;
        private System.Windows.Forms.ListBox listBoxAutok;
        private System.Windows.Forms.Button buttonHozzadas;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Button buttonKilepes;
        private System.Windows.Forms.Label labelGaz;
        private System.Windows.Forms.Label labelBenzin;
        private System.Windows.Forms.TextBox textBoxGazDb;
        private System.Windows.Forms.TextBox textBoxBenzinDb;
        private System.Windows.Forms.TextBox textBoxDiselDb;
        private System.Windows.Forms.TextBox textBoxElektromosDb;
        private System.Windows.Forms.Label labelDiesel;
        private System.Windows.Forms.Label labelElektromosDb;
    }
}

