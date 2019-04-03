using GUIOOPComboBoxListBox.adattar;
using GUIOOPComboBoxListBox.modell;
using System;
using System.Windows.Forms;

namespace GUIOOPComboBoxListBox
{
    public partial class Form1 : Form
    {
        private GyumolcsokAdattar adattar;

        public Form1()
        {
            adattar = new GyumolcsokAdattar();
            InitializeComponent();
            frissitFormot();
        }

        private void buttonHozzaad_Click(object sender, EventArgs e)
        {
            string gyumolcsNev = comboBoxGyumolcsok.Text;
            int gyumolcsMennyiseg = Convert.ToInt32(numericUpDownMennyiseg.Value);
            Gyumolcs gyumolcs = new Gyumolcs(gyumolcsNev, gyumolcsMennyiseg);
            adattar.hozzaad(gyumolcs);

            frissitFormot();
        }

        private void buttonTorol_Click(object sender, EventArgs e)
        {
            int index = listBoxVasaroltGyumolcsMennyisegek.SelectedIndex;
            if (index < 0)
                return;
            adattar.torol(index);

            frissitFormot();
        }

        private void frissitFormot()
        {
            textBoxOsszmennyiseg.Text = adattar.kiszamolOsszMennyiseget().ToString()+" kg";
            listBoxVasaroltGyumolcsMennyisegek.DataSource = null;
            listBoxVasaroltGyumolcsMennyisegek.DataSource = adattar.getGyumolcsok();
        }

        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
