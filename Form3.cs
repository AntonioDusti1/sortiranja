using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortiranjaj
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila;

        public Form1()
        {
            InitializeComponent();
            vozila = new List<Vozilo>();
            cmbSortirajPo.Items.AddRange(new string[] { "Marka", "Model", "GodinaProizvodnje", "Kilometraza" });
            cmbSortirajPo.SelectedIndex = 0; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarka.Text) || string.IsNullOrEmpty(txtModel.Text))
            {
                MessageBox.Show("Marka i Model su obavezna.");
                return;
            }

            if (!int.TryParse(txtGodinaProizvodnje.Text, out int godinaProizvodnje) || godinaProizvodnje <= 0)
            {
                MessageBox.Show("Godina proizvodnje mora biti pozitivan broj.");
                return;
            }

            if (!int.TryParse(txtKilometraza.Text, out int kilometraza) || kilometraza < 0)
            {
                MessageBox.Show("Kilometraža mora biti pozitivan broj.");
                return;
            }

            
            Vozilo novoVozilo = new Vozilo(txtMarka.Text, txtModel.Text, godinaProizvodnje, kilometraza);
            vozila.Add(novoVozilo);

            OsvjeziListu();
        }
        private void OsvjeziListu()
        {
            lstVozila.Items.Clear();
            foreach (var vozilo in vozila)
            {
                lstVozila.Items.Add(vozilo);
            }
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            string kriterij = cmbSortirajPo.SelectedItem.ToString();
            bool uzlazno = rbUzlazno.Checked;

            var sortiranaVozila = kriterij switch
            {
                "Marka" => (uzlazno) ? vozila.OrderBy(v => v.Marka).ToList() : vozila.OrderByDescending(v => v.Marka).ToList(),
                "Model" => (uzlazno) ? vozila.OrderBy(v => v.Model).ToList() : vozila.OrderByDescending(v => v.Model).ToList(),
                "GodinaProizvodnje" => (uzlazno) ? vozila.OrderBy(v => v.GodinaProizvodnje).ToList() : vozila.OrderByDescending(v => v.GodinaProizvodnje).ToList(),
                "Kilometraza" => (uzlazno) ? vozila.OrderBy(v => v.Kilometraza).ToList() : vozila.OrderByDescending(v => v.Kilometraza).ToList(),
                _ => vozila
            };

            txtSortiraniVozila.Clear();
            foreach (var vozilo in sortiranaVozila)
            {
                txtSortiraniVozila.AppendText(vozilo + Environment.NewLine);
            }
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (lstVozila.SelectedItem != null)
            {
                Vozilo voziloZaBrisanje = (Vozilo)lstVozila.SelectedItem;
                vozila.Remove(voziloZaBrisanje);
                OsvjeziListu();
            }
            else
            {
                MessageBox.Show("Odaberite vozilo za brisanje.");
            }
        }
    }
}
