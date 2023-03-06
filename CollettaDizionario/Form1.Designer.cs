namespace CollettaDizionario
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonTotale = new System.Windows.Forms.Button();
            this.textBoxTotale = new System.Windows.Forms.TextBox();
            this.textBoxImporto = new System.Windows.Forms.TextBox();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonCancella = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.labelTotaleVersato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(13, 13);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(109, 32);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total: 0";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(305, 452);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // buttonTotale
            // 
            this.buttonTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTotale.Location = new System.Drawing.Point(823, 3);
            this.buttonTotale.Name = "buttonTotale";
            this.buttonTotale.Size = new System.Drawing.Size(143, 53);
            this.buttonTotale.TabIndex = 5;
            this.buttonTotale.Text = "Imposta";
            this.buttonTotale.UseVisualStyleBackColor = true;
            this.buttonTotale.Click += new System.EventHandler(this.buttonTotale_Click);
            // 
            // textBoxTotale
            // 
            this.textBoxTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotale.Location = new System.Drawing.Point(676, 10);
            this.textBoxTotale.Name = "textBoxTotale";
            this.textBoxTotale.Size = new System.Drawing.Size(141, 39);
            this.textBoxTotale.TabIndex = 6;
            // 
            // textBoxImporto
            // 
            this.textBoxImporto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImporto.Location = new System.Drawing.Point(681, 87);
            this.textBoxImporto.Name = "textBoxImporto";
            this.textBoxImporto.Size = new System.Drawing.Size(285, 39);
            this.textBoxImporto.TabIndex = 8;
            this.textBoxImporto.Text = "Importo";
            this.textBoxImporto.Click += new System.EventHandler(this.textBoxAggiungiImporto_Click);
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggiungi.Location = new System.Drawing.Point(368, 150);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(196, 53);
            this.buttonAggiungi.TabIndex = 7;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(370, 87);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(305, 39);
            this.textBoxNome.TabIndex = 9;
            this.textBoxNome.Text = "Nome";
            this.textBoxNome.Click += new System.EventHandler(this.textBoxAggiungiNome_Click);
            // 
            // buttonCancella
            // 
            this.buttonCancella.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancella.Location = new System.Drawing.Point(570, 150);
            this.buttonCancella.Name = "buttonCancella";
            this.buttonCancella.Size = new System.Drawing.Size(196, 53);
            this.buttonCancella.TabIndex = 10;
            this.buttonCancella.Text = "Cancella";
            this.buttonCancella.UseVisualStyleBackColor = true;
            this.buttonCancella.Click += new System.EventHandler(this.buttonCancella_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifica.Location = new System.Drawing.Point(770, 150);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(196, 53);
            this.buttonModifica.TabIndex = 11;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // labelTotaleVersato
            // 
            this.labelTotaleVersato.AutoSize = true;
            this.labelTotaleVersato.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotaleVersato.Location = new System.Drawing.Point(363, 232);
            this.labelTotaleVersato.Name = "labelTotaleVersato";
            this.labelTotaleVersato.Size = new System.Drawing.Size(255, 37);
            this.labelTotaleVersato.TabIndex = 12;
            this.labelTotaleVersato.Text = "Totale versato: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.labelTotaleVersato);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonCancella);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxImporto);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.textBoxTotale);
            this.Controls.Add(this.buttonTotale);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonTotale;
        private System.Windows.Forms.TextBox textBoxTotale;
        private System.Windows.Forms.TextBox textBoxImporto;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonCancella;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.Label labelTotaleVersato;
    }
}

