namespace WindowsFormsApplication1
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
            this.listBoxNapok = new System.Windows.Forms.ListBox();
            this.labelEredmeny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxNapok
            // 
            this.listBoxNapok.FormattingEnabled = true;
            this.listBoxNapok.Items.AddRange(new object[] {
            "Hétfő",
            "Kedd",
            "Szerda",
            "Csütörtök",
            "Péntek"});
            this.listBoxNapok.Location = new System.Drawing.Point(13, 13);
            this.listBoxNapok.Name = "listBoxNapok";
            this.listBoxNapok.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxNapok.Size = new System.Drawing.Size(120, 69);
            this.listBoxNapok.TabIndex = 0;
            this.listBoxNapok.SelectedIndexChanged += new System.EventHandler(this.listBoxNapok_SelectedIndexChanged);
            // 
            // labelEredmeny
            // 
            this.labelEredmeny.AutoSize = true;
            this.labelEredmeny.Location = new System.Drawing.Point(13, 131);
            this.labelEredmeny.Name = "labelEredmeny";
            this.labelEredmeny.Size = new System.Drawing.Size(0, 13);
            this.labelEredmeny.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.labelEredmeny);
            this.Controls.Add(this.listBoxNapok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNapok;
        private System.Windows.Forms.Label labelEredmeny;
    }
}

