
namespace LAB4
{
    partial class FormVozac
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
            this.grpBoxOsnovniPodaci = new System.Windows.Forms.GroupBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.cbPol = new System.Windows.Forms.ComboBox();
            this.txtMestoIzdavanja = new System.Windows.Forms.TextBox();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblMestoIzdavanja = new System.Windows.Forms.Label();
            this.txtBrVozackeDozvole = new System.Windows.Forms.TextBox();
            this.lblBrVozackeDozvole = new System.Windows.Forms.Label();
            this.dtpVazenjeDo = new System.Windows.Forms.DateTimePicker();
            this.dtpVazenjeOd = new System.Windows.Forms.DateTimePicker();
            this.lblVazenjeDo = new System.Windows.Forms.Label();
            this.lblVazenjeOd = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.gbKategorija = new System.Windows.Forms.GroupBox();
            this.dgvKategorije = new System.Windows.Forms.DataGridView();
            this.gbZabrana = new System.Windows.Forms.GroupBox();
            this.dgvZabrane = new System.Windows.Forms.DataGridView();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnObrisiZabranu = new System.Windows.Forms.Button();
            this.btnDodajZabranu = new System.Windows.Forms.Button();
            this.btnObrisiKategoriju = new System.Windows.Forms.Button();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.grpBoxOsnovniPodaci.SuspendLayout();
            this.gbKategorija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            this.gbZabrana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxOsnovniPodaci
            // 
            this.grpBoxOsnovniPodaci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxOsnovniPodaci.Controls.Add(this.pbSlika);
            this.grpBoxOsnovniPodaci.Controls.Add(this.btnDodajSliku);
            this.grpBoxOsnovniPodaci.Controls.Add(this.cbPol);
            this.grpBoxOsnovniPodaci.Controls.Add(this.txtMestoIzdavanja);
            this.grpBoxOsnovniPodaci.Controls.Add(this.lblPol);
            this.grpBoxOsnovniPodaci.Controls.Add(this.lblMestoIzdavanja);
            this.grpBoxOsnovniPodaci.Controls.Add(this.txtBrVozackeDozvole);
            this.grpBoxOsnovniPodaci.Controls.Add(this.lblBrVozackeDozvole);
            this.grpBoxOsnovniPodaci.Controls.Add(this.dtpVazenjeDo);
            this.grpBoxOsnovniPodaci.Controls.Add(this.dtpVazenjeOd);
            this.grpBoxOsnovniPodaci.Controls.Add(this.lblVazenjeDo);
            this.grpBoxOsnovniPodaci.Controls.Add(this.lblVazenjeOd);
            this.grpBoxOsnovniPodaci.Controls.Add(this.dtpDatumRodjenja);
            this.grpBoxOsnovniPodaci.Controls.Add(this.lblDatumRodjenja);
            this.grpBoxOsnovniPodaci.Controls.Add(this.txtPrezime);
            this.grpBoxOsnovniPodaci.Controls.Add(this.lblPrezime);
            this.grpBoxOsnovniPodaci.Controls.Add(this.txtIme);
            this.grpBoxOsnovniPodaci.Controls.Add(this.lblIme);
            this.grpBoxOsnovniPodaci.Location = new System.Drawing.Point(12, 12);
            this.grpBoxOsnovniPodaci.Name = "grpBoxOsnovniPodaci";
            this.grpBoxOsnovniPodaci.Size = new System.Drawing.Size(569, 286);
            this.grpBoxOsnovniPodaci.TabIndex = 0;
            this.grpBoxOsnovniPodaci.TabStop = false;
            this.grpBoxOsnovniPodaci.Text = "Osnovni podaci";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajSliku.Location = new System.Drawing.Point(379, 186);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(117, 32);
            this.btnDodajSliku.TabIndex = 8;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // cbPol
            // 
            this.cbPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPol.FormattingEnabled = true;
            this.cbPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cbPol.Location = new System.Drawing.Point(178, 242);
            this.cbPol.Name = "cbPol";
            this.cbPol.Size = new System.Drawing.Size(112, 24);
            this.cbPol.TabIndex = 7;
            // 
            // txtMestoIzdavanja
            // 
            this.txtMestoIzdavanja.Location = new System.Drawing.Point(178, 214);
            this.txtMestoIzdavanja.Name = "txtMestoIzdavanja";
            this.txtMestoIzdavanja.Size = new System.Drawing.Size(112, 22);
            this.txtMestoIzdavanja.TabIndex = 6;
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(138, 242);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(32, 17);
            this.lblPol.TabIndex = 16;
            this.lblPol.Text = "Pol:";
            // 
            // lblMestoIzdavanja
            // 
            this.lblMestoIzdavanja.AutoSize = true;
            this.lblMestoIzdavanja.Location = new System.Drawing.Point(58, 214);
            this.lblMestoIzdavanja.Name = "lblMestoIzdavanja";
            this.lblMestoIzdavanja.Size = new System.Drawing.Size(114, 17);
            this.lblMestoIzdavanja.TabIndex = 15;
            this.lblMestoIzdavanja.Text = "Mesto izdavanja:";
            // 
            // txtBrVozackeDozvole
            // 
            this.txtBrVozackeDozvole.Location = new System.Drawing.Point(178, 186);
            this.txtBrVozackeDozvole.Name = "txtBrVozackeDozvole";
            this.txtBrVozackeDozvole.Size = new System.Drawing.Size(112, 22);
            this.txtBrVozackeDozvole.TabIndex = 5;
            this.txtBrVozackeDozvole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrVozackeDozvole_KeyPress);
            // 
            // lblBrVozackeDozvole
            // 
            this.lblBrVozackeDozvole.AutoSize = true;
            this.lblBrVozackeDozvole.Location = new System.Drawing.Point(33, 186);
            this.lblBrVozackeDozvole.Name = "lblBrVozackeDozvole";
            this.lblBrVozackeDozvole.Size = new System.Drawing.Size(139, 17);
            this.lblBrVozackeDozvole.TabIndex = 14;
            this.lblBrVozackeDozvole.Text = "Br. vozacke dozvole:";
            // 
            // dtpVazenjeDo
            // 
            this.dtpVazenjeDo.CustomFormat = "dd.MM.yyyy.";
            this.dtpVazenjeDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVazenjeDo.Location = new System.Drawing.Point(178, 158);
            this.dtpVazenjeDo.Name = "dtpVazenjeDo";
            this.dtpVazenjeDo.Size = new System.Drawing.Size(112, 22);
            this.dtpVazenjeDo.TabIndex = 4;
            // 
            // dtpVazenjeOd
            // 
            this.dtpVazenjeOd.CustomFormat = "dd.MM.yyyy.";
            this.dtpVazenjeOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVazenjeOd.Location = new System.Drawing.Point(178, 130);
            this.dtpVazenjeOd.Name = "dtpVazenjeOd";
            this.dtpVazenjeOd.Size = new System.Drawing.Size(112, 22);
            this.dtpVazenjeOd.TabIndex = 3;
            // 
            // lblVazenjeDo
            // 
            this.lblVazenjeDo.AutoSize = true;
            this.lblVazenjeDo.Location = new System.Drawing.Point(144, 158);
            this.lblVazenjeDo.Name = "lblVazenjeDo";
            this.lblVazenjeDo.Size = new System.Drawing.Size(28, 17);
            this.lblVazenjeDo.TabIndex = 13;
            this.lblVazenjeDo.Text = "do:";
            // 
            // lblVazenjeOd
            // 
            this.lblVazenjeOd.AutoSize = true;
            this.lblVazenjeOd.Location = new System.Drawing.Point(36, 130);
            this.lblVazenjeOd.Name = "lblVazenjeOd";
            this.lblVazenjeOd.Size = new System.Drawing.Size(136, 17);
            this.lblVazenjeOd.TabIndex = 12;
            this.lblVazenjeOd.Text = "Vazenje dozvole od:";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(178, 102);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(112, 22);
            this.dtpDatumRodjenja.TabIndex = 2;
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(64, 102);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(108, 17);
            this.lblDatumRodjenja.TabIndex = 11;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(178, 74);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(112, 22);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(109, 74);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 10;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(178, 46);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(112, 22);
            this.txtIme.TabIndex = 0;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(138, 46);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 9;
            this.lblIme.Text = "Ime:";
            // 
            // gbKategorija
            // 
            this.gbKategorija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbKategorija.Controls.Add(this.btnObrisiKategoriju);
            this.gbKategorija.Controls.Add(this.btnDodajKategoriju);
            this.gbKategorija.Controls.Add(this.dgvKategorije);
            this.gbKategorija.Location = new System.Drawing.Point(12, 304);
            this.gbKategorija.Name = "gbKategorija";
            this.gbKategorija.Size = new System.Drawing.Size(570, 200);
            this.gbKategorija.TabIndex = 1;
            this.gbKategorija.TabStop = false;
            this.gbKategorija.Text = "Kategorija";
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKategorije.BackgroundColor = System.Drawing.Color.White;
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.Location = new System.Drawing.Point(7, 22);
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.RowHeadersWidth = 51;
            this.dgvKategorije.RowTemplate.Height = 24;
            this.dgvKategorije.Size = new System.Drawing.Size(560, 112);
            this.dgvKategorije.TabIndex = 2;
            // 
            // gbZabrana
            // 
            this.gbZabrana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbZabrana.Controls.Add(this.btnObrisiZabranu);
            this.gbZabrana.Controls.Add(this.btnDodajZabranu);
            this.gbZabrana.Controls.Add(this.dgvZabrane);
            this.gbZabrana.Location = new System.Drawing.Point(12, 510);
            this.gbZabrana.Name = "gbZabrana";
            this.gbZabrana.Size = new System.Drawing.Size(570, 200);
            this.gbZabrana.TabIndex = 2;
            this.gbZabrana.TabStop = false;
            this.gbZabrana.Text = "Zabrana upravljanja";
            // 
            // dgvZabrane
            // 
            this.dgvZabrane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZabrane.BackgroundColor = System.Drawing.Color.White;
            this.dgvZabrane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZabrane.Location = new System.Drawing.Point(7, 22);
            this.dgvZabrane.Name = "dgvZabrane";
            this.dgvZabrane.RowHeadersWidth = 51;
            this.dgvZabrane.RowTemplate.Height = 24;
            this.dgvZabrane.Size = new System.Drawing.Size(560, 112);
            this.dgvZabrane.TabIndex = 2;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProsledi.Location = new System.Drawing.Point(190, 726);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(87, 36);
            this.btnProsledi.TabIndex = 3;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.Location = new System.Drawing.Point(302, 726);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(87, 36);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnObrisiZabranu
            // 
            this.btnObrisiZabranu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiZabranu.Image = global::LAB4.Properties.Resources.Delete_32x32;
            this.btnObrisiZabranu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiZabranu.Location = new System.Drawing.Point(432, 140);
            this.btnObrisiZabranu.Name = "btnObrisiZabranu";
            this.btnObrisiZabranu.Size = new System.Drawing.Size(132, 54);
            this.btnObrisiZabranu.TabIndex = 1;
            this.btnObrisiZabranu.Text = "Obrisi zabranu";
            this.btnObrisiZabranu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiZabranu.UseVisualStyleBackColor = true;
            this.btnObrisiZabranu.Click += new System.EventHandler(this.btnObrisiZabranu_Click);
            // 
            // btnDodajZabranu
            // 
            this.btnDodajZabranu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajZabranu.Image = global::LAB4.Properties.Resources.Check_32x32;
            this.btnDodajZabranu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajZabranu.Location = new System.Drawing.Point(7, 140);
            this.btnDodajZabranu.Name = "btnDodajZabranu";
            this.btnDodajZabranu.Size = new System.Drawing.Size(165, 54);
            this.btnDodajZabranu.TabIndex = 0;
            this.btnDodajZabranu.Text = "Dodaj novu zabranu";
            this.btnDodajZabranu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajZabranu.UseVisualStyleBackColor = true;
            this.btnDodajZabranu.Click += new System.EventHandler(this.btnDodajZabranu_Click);
            // 
            // btnObrisiKategoriju
            // 
            this.btnObrisiKategoriju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiKategoriju.Image = global::LAB4.Properties.Resources.Delete_32x32;
            this.btnObrisiKategoriju.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiKategoriju.Location = new System.Drawing.Point(432, 145);
            this.btnObrisiKategoriju.Name = "btnObrisiKategoriju";
            this.btnObrisiKategoriju.Size = new System.Drawing.Size(132, 54);
            this.btnObrisiKategoriju.TabIndex = 1;
            this.btnObrisiKategoriju.Text = "Obrisi kategoriju";
            this.btnObrisiKategoriju.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnObrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnObrisiKategoriju.Click += new System.EventHandler(this.btnObrisiKategoriju_Click);
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajKategoriju.Image = global::LAB4.Properties.Resources.Check_32x32;
            this.btnDodajKategoriju.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(7, 140);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(165, 54);
            this.btnDodajKategoriju.TabIndex = 0;
            this.btnDodajKategoriju.Text = "Dodaj novu kategoriju";
            this.btnDodajKategoriju.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSlika.Location = new System.Drawing.Point(379, 46);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(117, 120);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 17;
            this.pbSlika.TabStop = false;
            // 
            // FormVozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 781);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.gbZabrana);
            this.Controls.Add(this.gbKategorija);
            this.Controls.Add(this.grpBoxOsnovniPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVozac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozac";
            this.Load += new System.EventHandler(this.FormVozac_Load);
            this.grpBoxOsnovniPodaci.ResumeLayout(false);
            this.grpBoxOsnovniPodaci.PerformLayout();
            this.gbKategorija.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            this.gbZabrana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxOsnovniPodaci;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblMestoIzdavanja;
        private System.Windows.Forms.TextBox txtBrVozackeDozvole;
        private System.Windows.Forms.Label lblBrVozackeDozvole;
        private System.Windows.Forms.DateTimePicker dtpVazenjeDo;
        private System.Windows.Forms.DateTimePicker dtpVazenjeOd;
        private System.Windows.Forms.Label lblVazenjeDo;
        private System.Windows.Forms.Label lblVazenjeOd;
        private System.Windows.Forms.ComboBox cbPol;
        private System.Windows.Forms.TextBox txtMestoIzdavanja;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.GroupBox gbKategorija;
        private System.Windows.Forms.GroupBox gbZabrana;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvKategorije;
        private System.Windows.Forms.DataGridView dgvZabrane;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.Button btnObrisiKategoriju;
        private System.Windows.Forms.Button btnObrisiZabranu;
        private System.Windows.Forms.Button btnDodajZabranu;
        private System.Windows.Forms.PictureBox pbSlika;
    }
}