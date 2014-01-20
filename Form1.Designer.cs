namespace SocketClient_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblstatusmessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndisconnect = new System.Windows.Forms.Button();
            this.txtport = new System.Windows.Forms.TextBox();
            this.txtipaddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnconnect = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.receivedmessageListbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstatusmessage
            // 
            this.lblstatusmessage.AutoSize = true;
            this.lblstatusmessage.ForeColor = System.Drawing.Color.Blue;
            this.lblstatusmessage.Location = new System.Drawing.Point(160, 267);
            this.lblstatusmessage.Name = "lblstatusmessage";
            this.lblstatusmessage.Size = new System.Drawing.Size(36, 14);
            this.lblstatusmessage.TabIndex = 36;
            this.lblstatusmessage.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 35;
            this.label3.Text = "Connection Status:";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(316, 235);
            this.btnclose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 24);
            this.btnclose.TabIndex = 34;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btndisconnect
            // 
            this.btndisconnect.Location = new System.Drawing.Point(225, 54);
            this.btndisconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndisconnect.Name = "btndisconnect";
            this.btndisconnect.Size = new System.Drawing.Size(114, 48);
            this.btndisconnect.TabIndex = 30;
            this.btndisconnect.Text = "Disconnect from Server";
            this.btndisconnect.UseVisualStyleBackColor = true;
            this.btndisconnect.Click += new System.EventHandler(this.btndisconnect_Click);
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(108, 31);
            this.txtport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(116, 22);
            this.txtport.TabIndex = 29;
            this.txtport.Text = "8000";
            // 
            // txtipaddress
            // 
            this.txtipaddress.Location = new System.Drawing.Point(108, 7);
            this.txtipaddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtipaddress.Name = "txtipaddress";
            this.txtipaddress.Size = new System.Drawing.Size(116, 22);
            this.txtipaddress.TabIndex = 28;
            this.txtipaddress.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 26;
            this.label1.Text = "Server IP:";
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(108, 54);
            this.btnconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(117, 48);
            this.btnconnect.TabIndex = 25;
            this.btnconnect.Text = "Connect to Server";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SocketClient_2.Properties.Resources._31;
            this.pictureBox6.Location = new System.Drawing.Point(382, 13);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(71, 58);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 14);
            this.label5.TabIndex = 39;
            this.label5.Text = "Received Message:";
            // 
            // receivedmessageListbox
            // 
            this.receivedmessageListbox.BackColor = System.Drawing.Color.LemonChiffon;
            this.receivedmessageListbox.FormattingEnabled = true;
            this.receivedmessageListbox.ItemHeight = 14;
            this.receivedmessageListbox.Location = new System.Drawing.Point(43, 125);
            this.receivedmessageListbox.Name = "receivedmessageListbox";
            this.receivedmessageListbox.Size = new System.Drawing.Size(371, 102);
            this.receivedmessageListbox.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(465, 292);
            this.Controls.Add(this.receivedmessageListbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblstatusmessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndisconnect);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.txtipaddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconnect);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Socket Client 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstatusmessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndisconnect;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.TextBox txtipaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox receivedmessageListbox;
    }
}

