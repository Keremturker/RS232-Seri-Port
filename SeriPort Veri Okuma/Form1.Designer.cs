namespace SeriPort_Veri_Okuma
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
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.comboStopBiti = new System.Windows.Forms.ComboBox();
            this.lblEslikBit = new System.Windows.Forms.Label();
            this.comboParity = new System.Windows.Forms.ComboBox();
            this.comboDataBit = new System.Windows.Forms.ComboBox();
            this.lblDatabit = new System.Windows.Forms.Label();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.lblPortSec = new System.Windows.Forms.Label();
            this.comboPortAdi = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(249, 56);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(55, 24);
            this.btnYenile.TabIndex = 70;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lblStopBit
            // 
            this.lblStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStopBit.Location = new System.Drawing.Point(13, 185);
            this.lblStopBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(155, 24);
            this.lblStopBit.TabIndex = 63;
            this.lblStopBit.Text = "Stop Bit";
            // 
            // comboStopBiti
            // 
            this.comboStopBiti.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "One",
            "Two",
            "One"});
            this.comboStopBiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboStopBiti.FormattingEnabled = true;
            this.comboStopBiti.Items.AddRange(new object[] {
            "None (0)",
            "One (1)",
            "Two (2)",
            "OnePointFive (3)"});
            this.comboStopBiti.Location = new System.Drawing.Point(176, 184);
            this.comboStopBiti.Margin = new System.Windows.Forms.Padding(4);
            this.comboStopBiti.Name = "comboStopBiti";
            this.comboStopBiti.Size = new System.Drawing.Size(128, 24);
            this.comboStopBiti.TabIndex = 68;
            // 
            // lblEslikBit
            // 
            this.lblEslikBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEslikBit.Location = new System.Drawing.Point(13, 153);
            this.lblEslikBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEslikBit.Name = "lblEslikBit";
            this.lblEslikBit.Size = new System.Drawing.Size(155, 24);
            this.lblEslikBit.TabIndex = 62;
            this.lblEslikBit.Text = "Parity (Eşlik Biti)";
            // 
            // comboParity
            // 
            this.comboParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboParity.FormattingEnabled = true;
            this.comboParity.Items.AddRange(new object[] {
            "None  (0)",
            "Odd    (1)",
            "Even   (2)",
            "Mark  (3)",
            "Space (4)"});
            this.comboParity.Location = new System.Drawing.Point(176, 152);
            this.comboParity.Margin = new System.Windows.Forms.Padding(4);
            this.comboParity.Name = "comboParity";
            this.comboParity.Size = new System.Drawing.Size(128, 24);
            this.comboParity.TabIndex = 67;
            // 
            // comboDataBit
            // 
            this.comboDataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboDataBit.FormattingEnabled = true;
            this.comboDataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboDataBit.Location = new System.Drawing.Point(176, 120);
            this.comboDataBit.Margin = new System.Windows.Forms.Padding(4);
            this.comboDataBit.Name = "comboDataBit";
            this.comboDataBit.Size = new System.Drawing.Size(128, 24);
            this.comboDataBit.TabIndex = 66;
            // 
            // lblDatabit
            // 
            this.lblDatabit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDatabit.Location = new System.Drawing.Point(13, 120);
            this.lblDatabit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabit.Name = "lblDatabit";
            this.lblDatabit.Size = new System.Drawing.Size(155, 24);
            this.lblDatabit.TabIndex = 61;
            this.lblDatabit.Text = "Data Bit";
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBaudRate.FormattingEnabled = true;
            this.comboBaudRate.Items.AddRange(new object[] {
            "75",
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBaudRate.Location = new System.Drawing.Point(176, 88);
            this.comboBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(128, 24);
            this.comboBaudRate.TabIndex = 65;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaudRate.Location = new System.Drawing.Point(13, 88);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(155, 24);
            this.lblBaudRate.TabIndex = 60;
            this.lblBaudRate.Text = "Veri Hızı (Baud Rate)";
            // 
            // btnBaglan
            // 
            this.btnBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.Location = new System.Drawing.Point(16, 226);
            this.btnBaglan.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(288, 31);
            this.btnBaglan.TabIndex = 69;
            this.btnBaglan.Text = "BAĞLAN";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // lblPortSec
            // 
            this.lblPortSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPortSec.Location = new System.Drawing.Point(13, 56);
            this.lblPortSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortSec.Name = "lblPortSec";
            this.lblPortSec.Size = new System.Drawing.Size(155, 24);
            this.lblPortSec.TabIndex = 59;
            this.lblPortSec.Text = "Port Seçiniz";
            // 
            // comboPortAdi
            // 
            this.comboPortAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPortAdi.FormattingEnabled = true;
            this.comboPortAdi.Location = new System.Drawing.Point(176, 56);
            this.comboPortAdi.Margin = new System.Windows.Forms.Padding(4);
            this.comboPortAdi.Name = "comboPortAdi";
            this.comboPortAdi.Size = new System.Drawing.Size(66, 24);
            this.comboPortAdi.TabIndex = 64;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(343, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(433, 248);
            this.listView1.TabIndex = 73;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.DarkBlue;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Snow;
            this.lblBaslik.Location = new System.Drawing.Point(13, 9);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(5);
            this.lblBaslik.Size = new System.Drawing.Size(291, 32);
            this.lblBaslik.TabIndex = 71;
            this.lblBaslik.Text = "Seri Port Veri Okuma";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 296);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.lblStopBit);
            this.Controls.Add(this.comboStopBiti);
            this.Controls.Add(this.lblEslikBit);
            this.Controls.Add(this.comboParity);
            this.Controls.Add(this.comboDataBit);
            this.Controls.Add(this.lblDatabit);
            this.Controls.Add(this.comboBaudRate);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.lblPortSec);
            this.Controls.Add(this.comboPortAdi);
            this.Name = "Form1";
            this.Text = "Veri Okuma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblStopBit;
        private System.Windows.Forms.ComboBox comboStopBiti;
        private System.Windows.Forms.Label lblEslikBit;
        private System.Windows.Forms.ComboBox comboParity;
        private System.Windows.Forms.ComboBox comboDataBit;
        private System.Windows.Forms.Label lblDatabit;
        private System.Windows.Forms.ComboBox comboBaudRate;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Label lblPortSec;
        private System.Windows.Forms.ComboBox comboPortAdi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblBaslik;
    }
}

