using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class AdministrareAsociatieForm : Form
    {
        public AdministrareAsociatieForm()
        {
            InitializeComponent();
        }

        private void dateGeneraleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateGenerale dg = new DateGenerale();

            dg.Show();

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void scariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scari scari = new Scari();

            scari.Show();


        }

        private void apartamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apartamente apartamente = new Apartamente();

            apartamente.Show();

        }

        private void conturiBancareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConturiBancare conturiBancare = new ConturiBancare();

            conturiBancare.Show();

        }

        private void fonduriSpecialeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FonduriSpeciale fonduriSpeciale = new FonduriSpeciale();

            fonduriSpeciale.Show();

        }

        private void persoaneFiziceJuridiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersoaneFiziceJuridice persoaneFiziceJuridice = new PersoaneFiziceJuridice();

            persoaneFiziceJuridice.Show();

        }

        private void listaDePlataLunaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListedePlataLunare listedePlataLunare = new ListedePlataLunare();

            listedePlataLunare.Show();

        }

        private void incasariPlatiRegistruDeCasaBancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncasariPlatiRegistruDeCasaBanca incasariPlatiRegistruDeCasaBanca = new IncasariPlatiRegistruDeCasaBanca();

            incasariPlatiRegistruDeCasaBanca.Show();

        }

        private void operatiiDiverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatiiDiverse operatiiDiverse = new OperatiiDiverse();

            operatiiDiverse.Show();

        }

        private void SituatieClientifurnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SituatieFurnizoriClienti situatieFurnizoriClienti = new SituatieFurnizoriClienti();

            situatieFurnizoriClienti.Show();

        }

        private void fiseApartamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiseApartament fiseApartament = new FiseApartament();

            fiseApartament.Show();

        }
    }
}
