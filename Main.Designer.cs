namespace TCPListenerApplication
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listen = new System.Windows.Forms.Button();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clientsList = new System.Windows.Forms.ListBox();
            this.deleteClient = new System.Windows.Forms.Button();
            this.startChat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.receiveArea = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listen);
            this.groupBox1.Controls.Add(this.ipAddress);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listener Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port";
            // 
            // listen
            // 
            this.listen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.listen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.listen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listen.Location = new System.Drawing.Point(837, 54);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(259, 29);
            this.listen.TabIndex = 5;
            this.listen.Text = "Listen";
            this.listen.UseVisualStyleBackColor = true;
            this.listen.Click += new System.EventHandler(this.Listen_Click);
            // 
            // ipAddress
            // 
            this.ipAddress.BackColor = System.Drawing.SystemColors.Control;
            this.ipAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddress.Location = new System.Drawing.Point(184, 54);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(639, 29);
            this.ipAddress.TabIndex = 4;
            this.ipAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IpAddress_KeyPress);
            // 
            // port
            // 
            this.port.BackColor = System.Drawing.SystemColors.Control;
            this.port.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port.Location = new System.Drawing.Point(6, 54);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(172, 29);
            this.port.TabIndex = 3;
            this.port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Port_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clientsList);
            this.groupBox2.Controls.Add(this.deleteClient);
            this.groupBox2.Controls.Add(this.startChat);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1105, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clients Info";
            // 
            // clientsList
            // 
            this.clientsList.FormattingEnabled = true;
            this.clientsList.ItemHeight = 21;
            this.clientsList.Location = new System.Drawing.Point(9, 26);
            this.clientsList.Name = "clientsList";
            this.clientsList.Size = new System.Drawing.Size(662, 277);
            this.clientsList.TabIndex = 9;
            // 
            // deleteClient
            // 
            this.deleteClient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.deleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClient.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteClient.Location = new System.Drawing.Point(677, 26);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(419, 136);
            this.deleteClient.TabIndex = 7;
            this.deleteClient.Text = "Delete Client";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // startChat
            // 
            this.startChat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.startChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startChat.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startChat.Location = new System.Drawing.Point(677, 168);
            this.startChat.Name = "startChat";
            this.startChat.Size = new System.Drawing.Size(419, 135);
            this.startChat.TabIndex = 6;
            this.startChat.Text = "Start Chat";
            this.startChat.UseVisualStyleBackColor = true;
            this.startChat.Click += new System.EventHandler(this.StartChat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.receiveArea);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 461);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1102, 345);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receive Area";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(629, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(467, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "Get Start Point Of Receive Area";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(467, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // receiveArea
            // 
            this.receiveArea.BackColor = System.Drawing.SystemColors.Control;
            this.receiveArea.Location = new System.Drawing.Point(6, 26);
            this.receiveArea.Name = "receiveArea";
            this.receiveArea.Size = new System.Drawing.Size(1090, 264);
            this.receiveArea.TabIndex = 0;
            this.receiveArea.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1092, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 813);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox receiveArea;
        private System.Windows.Forms.Button startChat;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox clientsList;
        private System.Windows.Forms.Button button3;
    }
}

