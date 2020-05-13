namespace TCPListenerApplication
{
    partial class ChatWithClient
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
            this.Groupbox1 = new System.Windows.Forms.GroupBox();
            this.SendEncoding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.sendArea = new System.Windows.Forms.RichTextBox();
            this.Groupbox2 = new System.Windows.Forms.GroupBox();
            this.ReceiveEncoding = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.receieveArea = new System.Windows.Forms.RichTextBox();
            this.controlLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.clientInfo = new System.Windows.Forms.Label();
            this.notification = new System.Windows.Forms.ToolTip(this.components);
            this.Groupbox1.SuspendLayout();
            this.Groupbox2.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Groupbox1
            // 
            this.Groupbox1.Controls.Add(this.SendEncoding);
            this.Groupbox1.Controls.Add(this.label1);
            this.Groupbox1.Controls.Add(this.send);
            this.Groupbox1.Controls.Add(this.sendArea);
            this.Groupbox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupbox1.Location = new System.Drawing.Point(5, 37);
            this.Groupbox1.Name = "Groupbox1";
            this.Groupbox1.Size = new System.Drawing.Size(556, 343);
            this.Groupbox1.TabIndex = 0;
            this.Groupbox1.TabStop = false;
            this.Groupbox1.Text = "Send Area";
            // 
            // SendEncoding
            // 
            this.SendEncoding.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendEncoding.FormattingEnabled = true;
            this.SendEncoding.Location = new System.Drawing.Point(347, 26);
            this.SendEncoding.Name = "SendEncoding";
            this.SendEncoding.Size = new System.Drawing.Size(202, 25);
            this.SendEncoding.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Encoding of the Message";
            // 
            // send
            // 
            this.send.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Location = new System.Drawing.Point(7, 302);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(543, 34);
            this.send.TabIndex = 9;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.Send_Click);
            // 
            // sendArea
            // 
            this.sendArea.Location = new System.Drawing.Point(7, 56);
            this.sendArea.Name = "sendArea";
            this.sendArea.Size = new System.Drawing.Size(543, 238);
            this.sendArea.TabIndex = 0;
            this.sendArea.Text = "";
            this.sendArea.Enter += new System.EventHandler(this.SendArea_Enter);
            // 
            // Groupbox2
            // 
            this.Groupbox2.Controls.Add(this.ReceiveEncoding);
            this.Groupbox2.Controls.Add(this.label2);
            this.Groupbox2.Controls.Add(this.clear);
            this.Groupbox2.Controls.Add(this.receieveArea);
            this.Groupbox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupbox2.Location = new System.Drawing.Point(5, 386);
            this.Groupbox2.Name = "Groupbox2";
            this.Groupbox2.Size = new System.Drawing.Size(556, 389);
            this.Groupbox2.TabIndex = 1;
            this.Groupbox2.TabStop = false;
            this.Groupbox2.Text = "Receive Area";
            // 
            // ReceiveEncoding
            // 
            this.ReceiveEncoding.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveEncoding.FormattingEnabled = true;
            this.ReceiveEncoding.Location = new System.Drawing.Point(346, 19);
            this.ReceiveEncoding.Name = "ReceiveEncoding";
            this.ReceiveEncoding.Size = new System.Drawing.Size(202, 25);
            this.ReceiveEncoding.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Encoding of the Received Message";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(7, 347);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(541, 34);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear Chat";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // receieveArea
            // 
            this.receieveArea.Location = new System.Drawing.Point(6, 50);
            this.receieveArea.Name = "receieveArea";
            this.receieveArea.Size = new System.Drawing.Size(543, 293);
            this.receieveArea.TabIndex = 1;
            this.receieveArea.Text = "";
            // 
            // controlLabel
            // 
            this.controlLabel.AutoSize = true;
            this.controlLabel.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlLabel.Location = new System.Drawing.Point(530, 7);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(23, 23);
            this.controlLabel.TabIndex = 4;
            this.controlLabel.Text = "X";
            this.controlLabel.Click += new System.EventHandler(this.Label3_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.controlPanel.Controls.Add(this.clientInfo);
            this.controlPanel.Controls.Add(this.controlLabel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(569, 34);
            this.controlPanel.TabIndex = 2;
            this.controlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            this.controlPanel.MouseLeave += new System.EventHandler(this.ControlPanel_MouseLeave);
            this.controlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseMove);
            // 
            // clientInfo
            // 
            this.clientInfo.AutoSize = true;
            this.clientInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInfo.Location = new System.Drawing.Point(7, 9);
            this.clientInfo.Name = "clientInfo";
            this.clientInfo.Size = new System.Drawing.Size(86, 21);
            this.clientInfo.TabIndex = 5;
            this.clientInfo.Text = "ClientInfo";
            // 
            // notification
            // 
            this.notification.AutomaticDelay = 100;
            // 
            // ChatWithClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 780);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.Groupbox2);
            this.Controls.Add(this.Groupbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatWithClient";
            this.Text = "ChatWithClient";
            this.Load += new System.EventHandler(this.ChatWithClient_Load);
            this.Groupbox1.ResumeLayout(false);
            this.Groupbox1.PerformLayout();
            this.Groupbox2.ResumeLayout(false);
            this.Groupbox2.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Groupbox1;
        private System.Windows.Forms.GroupBox Groupbox2;
        private System.Windows.Forms.RichTextBox sendArea;
        private System.Windows.Forms.Button send;
        public System.Windows.Forms.RichTextBox receieveArea;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label controlLabel;
        private System.Windows.Forms.Label clientInfo;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ComboBox SendEncoding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ReceiveEncoding;
        private System.Windows.Forms.ToolTip notification;
    }
}