namespace Sportboot
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNummer = new System.Windows.Forms.TextBox();
            this.txtLänge = new System.Windows.Forms.TextBox();
            this.txtLeistung = new System.Windows.Forms.TextBox();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBootabspeichern = new System.Windows.Forms.Button();
            this.Simulation = new System.Windows.Forms.Label();
            this.btnFührerscheinpflicht = new System.Windows.Forms.Button();
            this.btnGewicht = new System.Windows.Forms.Button();
            this.lbl_Führerscheinpflicht = new System.Windows.Forms.Label();
            this.Gewicht = new System.Windows.Forms.Label();
            this.lblGewicht = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNummer
            // 
            this.txtNummer.Location = new System.Drawing.Point(217, 51);
            this.txtNummer.Name = "txtNummer";
            this.txtNummer.Size = new System.Drawing.Size(100, 22);
            this.txtNummer.TabIndex = 0;
            // 
            // txtLänge
            // 
            this.txtLänge.Location = new System.Drawing.Point(217, 95);
            this.txtLänge.Name = "txtLänge";
            this.txtLänge.Size = new System.Drawing.Size(100, 22);
            this.txtLänge.TabIndex = 1;
            // 
            // txtLeistung
            // 
            this.txtLeistung.Location = new System.Drawing.Point(217, 148);
            this.txtLeistung.Name = "txtLeistung";
            this.txtLeistung.Size = new System.Drawing.Size(100, 22);
            this.txtLeistung.TabIndex = 2;
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(389, 51);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.Size = new System.Drawing.Size(399, 247);
            this.txtAusgabe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bootsnummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Länge in Meter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Leistung in Kw";
            // 
            // btnBootabspeichern
            // 
            this.btnBootabspeichern.Location = new System.Drawing.Point(217, 198);
            this.btnBootabspeichern.Name = "btnBootabspeichern";
            this.btnBootabspeichern.Size = new System.Drawing.Size(100, 38);
            this.btnBootabspeichern.TabIndex = 7;
            this.btnBootabspeichern.Text = "Speichern";
            this.btnBootabspeichern.UseVisualStyleBackColor = true;
            this.btnBootabspeichern.Click += new System.EventHandler(this.btnBootabspeichern_Click);
            // 
            // Simulation
            // 
            this.Simulation.AutoSize = true;
            this.Simulation.Location = new System.Drawing.Point(16, 287);
            this.Simulation.Name = "Simulation";
            this.Simulation.Size = new System.Drawing.Size(69, 16);
            this.Simulation.TabIndex = 8;
            this.Simulation.Text = "Simulation";
            // 
            // btnFührerscheinpflicht
            // 
            this.btnFührerscheinpflicht.Location = new System.Drawing.Point(146, 330);
            this.btnFührerscheinpflicht.Name = "btnFührerscheinpflicht";
            this.btnFührerscheinpflicht.Size = new System.Drawing.Size(133, 45);
            this.btnFührerscheinpflicht.TabIndex = 9;
            this.btnFührerscheinpflicht.Text = "Führerscheinpflicht";
            this.btnFührerscheinpflicht.UseVisualStyleBackColor = true;
            this.btnFührerscheinpflicht.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGewicht
            // 
            this.btnGewicht.Location = new System.Drawing.Point(146, 393);
            this.btnGewicht.Name = "btnGewicht";
            this.btnGewicht.Size = new System.Drawing.Size(133, 45);
            this.btnGewicht.TabIndex = 10;
            this.btnGewicht.Text = "Gewicht";
            this.btnGewicht.UseVisualStyleBackColor = true;
            this.btnGewicht.Click += new System.EventHandler(this.btnGewicht_Click);
            // 
            // lbl_Führerscheinpflicht
            // 
            this.lbl_Führerscheinpflicht.AutoSize = true;
            this.lbl_Führerscheinpflicht.Location = new System.Drawing.Point(337, 344);
            this.lbl_Führerscheinpflicht.Name = "lbl_Führerscheinpflicht";
            this.lbl_Führerscheinpflicht.Size = new System.Drawing.Size(0, 16);
            this.lbl_Führerscheinpflicht.TabIndex = 11;
            // 
            // Gewicht
            // 
            this.Gewicht.AutoSize = true;
            this.Gewicht.Location = new System.Drawing.Point(337, 407);
            this.Gewicht.Name = "Gewicht";
            this.Gewicht.Size = new System.Drawing.Size(0, 16);
            this.Gewicht.TabIndex = 12;
            // 
            // lblGewicht
            // 
            this.lblGewicht.AutoSize = true;
            this.lblGewicht.Location = new System.Drawing.Point(389, 406);
            this.lblGewicht.Name = "lblGewicht";
            this.lblGewicht.Size = new System.Drawing.Size(0, 16);
            this.lblGewicht.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGewicht);
            this.Controls.Add(this.Gewicht);
            this.Controls.Add(this.lbl_Führerscheinpflicht);
            this.Controls.Add(this.btnGewicht);
            this.Controls.Add(this.btnFührerscheinpflicht);
            this.Controls.Add(this.Simulation);
            this.Controls.Add(this.btnBootabspeichern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.txtLeistung);
            this.Controls.Add(this.txtLänge);
            this.Controls.Add(this.txtNummer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNummer;
        private System.Windows.Forms.TextBox txtLänge;
        private System.Windows.Forms.TextBox txtLeistung;
        private System.Windows.Forms.TextBox txtAusgabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBootabspeichern;
        private System.Windows.Forms.Label Simulation;
        private System.Windows.Forms.Button btnFührerscheinpflicht;
        private System.Windows.Forms.Button btnGewicht;
        private System.Windows.Forms.Label lbl_Führerscheinpflicht;
        private System.Windows.Forms.Label Gewicht;
        private System.Windows.Forms.Label lblGewicht;
    }
}

