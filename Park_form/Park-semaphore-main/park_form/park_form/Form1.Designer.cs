namespace park_form
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listFuori = new System.Windows.Forms.ListBox();
            this.listDentro = new System.Windows.Forms.ListBox();
            this.listTransito = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblPostiLiberi = new System.Windows.Forms.Label();
            this.listUscite = new System.Windows.Forms.ListBox();
            this.lblAutoUscite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listFuori
            // 
            this.listFuori.FormattingEnabled = true;
            this.listFuori.ItemHeight = 15;
            this.listFuori.Location = new System.Drawing.Point(12, 27);
            this.listFuori.Name = "listFuori";
            this.listFuori.Size = new System.Drawing.Size(120, 289);
            this.listFuori.TabIndex = 0;
            // 
            // listDentro
            // 
            this.listDentro.FormattingEnabled = true;
            this.listDentro.ItemHeight = 15;
            this.listDentro.Location = new System.Drawing.Point(138, 27);
            this.listDentro.Name = "listDentro";
            this.listDentro.Size = new System.Drawing.Size(120, 289);
            this.listDentro.TabIndex = 1;
            // 
            // listTransito
            // 
            this.listTransito.FormattingEnabled = true;
            this.listTransito.ItemHeight = 15;
            this.listTransito.Location = new System.Drawing.Point(264, 27);
            this.listTransito.Name = "listTransito";
            this.listTransito.Size = new System.Drawing.Size(120, 289);
            this.listTransito.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(390, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(390, 56);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblPostiLiberi
            // 
            this.lblPostiLiberi.AutoSize = true;
            this.lblPostiLiberi.Location = new System.Drawing.Point(390, 82);
            this.lblPostiLiberi.Name = "lblPostiLiberi";
            this.lblPostiLiberi.Size = new System.Drawing.Size(72, 15);
            this.lblPostiLiberi.TabIndex = 5;
            this.lblPostiLiberi.Text = "Posti liberi: 10";
            // 
            // listUscite
            // 
            this.listUscite.FormattingEnabled = true;
            this.listUscite.ItemHeight = 15;
            this.listUscite.Location = new System.Drawing.Point(390, 120);
            this.listUscite.Name = "listUscite";
            this.listUscite.Size = new System.Drawing.Size(120, 94);
            this.listUscite.TabIndex = 6;
            // 
            // lblAutoUscite
            // 
            this.lblAutoUscite.AutoSize = true;
            this.lblAutoUscite.Location = new System.Drawing.Point(390, 217);
            this.lblAutoUscite.Name = "lblAutoUscite";
            this.lblAutoUscite.Size = new System.Drawing.Size(72, 15);
            this.lblAutoUscite.TabIndex = 7;
            this.lblAutoUscite.Text = "Auto uscite: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fuori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dentro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "In transito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Uscite:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(522, 331);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAutoUscite);
            this.Controls.Add(this.listUscite);
            this.Controls.Add(this.lblPostiLiberi);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listTransito);
            this.Controls.Add(this.listDentro);
            this.Controls.Add(this.listFuori);
            this.Name = "Form1";
            this.Text = "Simulazione Parcheggio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listFuori;
        private System.Windows.Forms.ListBox listDentro;
        private System.Windows.Forms.ListBox listTransito;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblPostiLiberi;
        private System.Windows.Forms.ListBox listUscite;
        private System.Windows.Forms.Label lblAutoUscite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}