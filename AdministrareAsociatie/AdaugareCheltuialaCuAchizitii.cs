using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class AdaugareCheltuialaCuAchizitii : Form
    {
        public AdaugareCheltuialaCuAchizitii()
        {
            InitializeComponent();
        }

        
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void deschidenomencl(object sender, EventArgs e)
        {

        }

        private void DeschideNomAsocButton_Click(object sender, EventArgs e)
        {
            PersoaneJuridiceFizice persoaneJuridiceFizice = new PersoaneJuridiceFizice();

            persoaneJuridiceFizice.Show();

        }

        private void RevocareButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FacturaFiscalaCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
