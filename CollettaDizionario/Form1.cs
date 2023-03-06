using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollettaDizionario
{
    public partial class Form1 : Form
    {
        Dictionary<string, float> colletta = new Dictionary<string, float>();
        float totale = 0;
        float totaleDaVersare = 0;
        public Form1()
        {
            InitializeComponent();
            listView1.Clear();
            listView1.Columns.Add("Nome");
            listView1.Columns.Add("Importo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTotale_Click(object sender, EventArgs e)
        {
            totale = float.Parse(textBoxTotale.Text);
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
                try
                {
                    colletta.Add(textBoxNome.Text, float.Parse(textBoxImporto.Text));
                    string[] row = { textBoxNome.Text, textBoxImporto.Text };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    listViewRefresh(colletta);
                }
                catch
                {
                    MessageBox.Show("Valori non validi!");
                }

            }
            textBoxNome.Text = "Nome";
            textBoxImporto.Text = "Importo";

        }

        private void buttonCancella_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "Nome" || textBoxNome.Text != null)
            {
                try
                {
                    colletta.Remove(textBoxNome.Text);
                    listViewRefresh(colletta);
                    refreshTotal(colletta);
                }
                catch
                {
                    MessageBox.Show("Persone inesistente!");
                }
            }
            textBoxNome.Text = "Nome";
            textBoxImporto.Text = "Importo";
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "Nome" || textBoxNome.Text != null || textBoxImporto.Text != "Importo" || textBoxImporto.Text != null)
            {
                try
                {
                    string nome = textBoxNome.Text;
                    colletta.Remove(nome);
                    colletta.Add(textBoxNome.Text, float.Parse(textBoxImporto.Text));
                    string[] row = { textBoxNome.Text, textBoxImporto.Text };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    listViewRefresh(colletta);
                }
                catch
                {
                    MessageBox.Show("Persona inesistente.");
                }
            }
            else
            {
                MessageBox.Show("Inserire il nome e il nuovo importo.");
            }
        }

        public void listViewRefresh(Dictionary<string, float> dict)
        {
            listView1.Clear();
            listView1.Columns.Add("Nome");
            listView1.Columns.Add("Importo");

            foreach (KeyValuePair<string, float> kvp in dict)
            {
                ListViewItem item = new ListViewItem(kvp.Key);
                item.SubItems.Add(kvp.Value.ToString());
                listView1.Items.Add(item);
            }
            refreshTotal(colletta);
        }

        public void refreshTotal(Dictionary<string,float> dict)
        {
            totaleDaVersare = 0;
            foreach (KeyValuePair<string, float> kvp in dict)
            {
                totaleDaVersare += kvp.Value;
            }
            labelTotaleVersato.Text = "Totale versato: "+totaleDaVersare;
        }
    }
}