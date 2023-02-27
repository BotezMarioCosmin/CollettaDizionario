using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollettaDizionario
{
    public partial class Form1 : Form
    {
        Dictionary<string, float> colletta = new Dictionary<string, float>();
        float totale = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTotale_Click(object sender, EventArgs e)
        {
            totale = int.Parse(labelTotal.Text);
            labelTotal.Text = "Totale: " + textBoxTotale.Text;
            textBoxTotale.Text = null;
        }

        private void textBoxAggiungiNome_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = null;
        }

        private void textBoxAggiungiImporto_Click(object sender, EventArgs e)
        {
            textBoxImporto.Text = null;
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "Nome" || textBoxNome.Text != null || textBoxImporto.Text != "Importo" || textBoxImporto.Text != null)
            {
                colletta.Add(textBoxNome.Text, int.Parse(textBoxImporto.Text));
                string[] row = { textBoxNome.Text, textBoxImporto.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }

        }

        private void buttonCancella_Click(object sender, EventArgs e)
        {

        }
    }

}