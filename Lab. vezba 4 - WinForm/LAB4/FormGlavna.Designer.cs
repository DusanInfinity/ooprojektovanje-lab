
namespace LAB4
{
    partial class FormGlavna
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGlavna));
            this.lblVreme = new System.Windows.Forms.Label();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.comboSort = new System.Windows.Forms.ComboBox();
            this.grBoxListaVozaca = new System.Windows.Forms.GroupBox();
            this.dgvListaVozaca = new System.Windows.Forms.DataGridView();
            this.btnObrisiVozaca = new System.Windows.Forms.Button();
            this.btnIzmeniVozaca = new System.Windows.Forms.Button();
            this.btnDodajVozaca = new System.Windows.Forms.Button();
            this.tmrVreme = new System.Windows.Forms.Timer(this.components);
            this.grBoxListaVozaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVreme
            // 
            resources.ApplyResources(this.lblVreme, "lblVreme");
            this.lblVreme.Name = "lblVreme";
            // 
            // btnSortiraj
            // 
            resources.ApplyResources(this.btnSortiraj, "btnSortiraj");
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // comboSort
            // 
            resources.ApplyResources(this.comboSort, "comboSort");
            this.comboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSort.FormattingEnabled = true;
            this.comboSort.Items.AddRange(new object[] {
            resources.GetString("comboSort.Items"),
            resources.GetString("comboSort.Items1"),
            resources.GetString("comboSort.Items2")});
            this.comboSort.Name = "comboSort";
            this.comboSort.SelectedIndexChanged += new System.EventHandler(this.comboSort_SelectedIndexChanged);
            // 
            // grBoxListaVozaca
            // 
            resources.ApplyResources(this.grBoxListaVozaca, "grBoxListaVozaca");
            this.grBoxListaVozaca.Controls.Add(this.dgvListaVozaca);
            this.grBoxListaVozaca.Controls.Add(this.btnObrisiVozaca);
            this.grBoxListaVozaca.Controls.Add(this.btnIzmeniVozaca);
            this.grBoxListaVozaca.Controls.Add(this.btnDodajVozaca);
            this.grBoxListaVozaca.Name = "grBoxListaVozaca";
            this.grBoxListaVozaca.TabStop = false;
            // 
            // dgvListaVozaca
            // 
            resources.ApplyResources(this.dgvListaVozaca, "dgvListaVozaca");
            this.dgvListaVozaca.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaVozaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVozaca.Name = "dgvListaVozaca";
            this.dgvListaVozaca.RowTemplate.Height = 24;
            // 
            // btnObrisiVozaca
            // 
            resources.ApplyResources(this.btnObrisiVozaca, "btnObrisiVozaca");
            this.btnObrisiVozaca.Image = global::LAB4.Properties.Resources.Delete_32x32;
            this.btnObrisiVozaca.Name = "btnObrisiVozaca";
            this.btnObrisiVozaca.UseVisualStyleBackColor = true;
            this.btnObrisiVozaca.Click += new System.EventHandler(this.btnObrisiVozaca_Click);
            // 
            // btnIzmeniVozaca
            // 
            resources.ApplyResources(this.btnIzmeniVozaca, "btnIzmeniVozaca");
            this.btnIzmeniVozaca.Image = global::LAB4.Properties.Resources.Edit_32x32;
            this.btnIzmeniVozaca.Name = "btnIzmeniVozaca";
            this.btnIzmeniVozaca.UseVisualStyleBackColor = true;
            this.btnIzmeniVozaca.Click += new System.EventHandler(this.btnIzmeniVozaca_Click);
            // 
            // btnDodajVozaca
            // 
            resources.ApplyResources(this.btnDodajVozaca, "btnDodajVozaca");
            this.btnDodajVozaca.Image = global::LAB4.Properties.Resources.Check_32x32;
            this.btnDodajVozaca.Name = "btnDodajVozaca";
            this.btnDodajVozaca.UseVisualStyleBackColor = true;
            this.btnDodajVozaca.Click += new System.EventHandler(this.btnDodajVozaca_Click);
            // 
            // tmrVreme
            // 
            this.tmrVreme.Interval = 1000;
            this.tmrVreme.Tick += new System.EventHandler(this.tmrVreme_Tick);
            // 
            // FormGlavna
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grBoxListaVozaca);
            this.Controls.Add(this.comboSort);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.lblVreme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGlavna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGlavna_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBoxListaVozaca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.ComboBox comboSort;
        private System.Windows.Forms.GroupBox grBoxListaVozaca;
        private System.Windows.Forms.Button btnIzmeniVozaca;
        private System.Windows.Forms.Button btnDodajVozaca;
        private System.Windows.Forms.Button btnObrisiVozaca;
        private System.Windows.Forms.Timer tmrVreme;
        private System.Windows.Forms.DataGridView dgvListaVozaca;
    }
}

