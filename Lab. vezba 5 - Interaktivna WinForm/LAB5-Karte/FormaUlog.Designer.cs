
namespace LAB5_Karte
{
    partial class FormaUlog
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
            this.lblPoeni = new System.Windows.Forms.Label();
            this.lblUlog = new System.Windows.Forms.Label();
            this.numPoeni = new System.Windows.Forms.NumericUpDown();
            this.numUlog = new System.Windows.Forms.NumericUpDown();
            this.btnPokreniIgru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUlog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Location = new System.Drawing.Point(31, 35);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(61, 13);
            this.lblPoeni.TabIndex = 0;
            this.lblPoeni.Text = "Broj poena:";
            // 
            // lblUlog
            // 
            this.lblUlog.AutoSize = true;
            this.lblUlog.Location = new System.Drawing.Point(60, 76);
            this.lblUlog.Name = "lblUlog";
            this.lblUlog.Size = new System.Drawing.Size(32, 13);
            this.lblUlog.TabIndex = 1;
            this.lblUlog.Text = "Ulog:";
            // 
            // numPoeni
            // 
            this.numPoeni.Location = new System.Drawing.Point(99, 35);
            this.numPoeni.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPoeni.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPoeni.Name = "numPoeni";
            this.numPoeni.Size = new System.Drawing.Size(120, 20);
            this.numPoeni.TabIndex = 2;
            this.numPoeni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUlog
            // 
            this.numUlog.Location = new System.Drawing.Point(99, 74);
            this.numUlog.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUlog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUlog.Name = "numUlog";
            this.numUlog.Size = new System.Drawing.Size(120, 20);
            this.numUlog.TabIndex = 3;
            this.numUlog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPokreniIgru
            // 
            this.btnPokreniIgru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPokreniIgru.Location = new System.Drawing.Point(99, 129);
            this.btnPokreniIgru.Name = "btnPokreniIgru";
            this.btnPokreniIgru.Size = new System.Drawing.Size(79, 28);
            this.btnPokreniIgru.TabIndex = 4;
            this.btnPokreniIgru.Text = "Pokreni igru!";
            this.btnPokreniIgru.UseVisualStyleBackColor = true;
            this.btnPokreniIgru.Click += new System.EventHandler(this.btnPokreniIgru_Click);
            // 
            // FormaUlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 169);
            this.Controls.Add(this.btnPokreniIgru);
            this.Controls.Add(this.numUlog);
            this.Controls.Add(this.numPoeni);
            this.Controls.Add(this.lblUlog);
            this.Controls.Add(this.lblPoeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormaUlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izbor uloga";
            ((System.ComponentModel.ISupportInitialize)(this.numPoeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUlog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Label lblUlog;
        private System.Windows.Forms.NumericUpDown numPoeni;
        private System.Windows.Forms.NumericUpDown numUlog;
        private System.Windows.Forms.Button btnPokreniIgru;
    }
}