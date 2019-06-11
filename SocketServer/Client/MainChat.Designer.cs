namespace Client
{
    partial class MainChat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.connectBTN = new System.Windows.Forms.Button();
            this.nameTBX = new System.Windows.Forms.TextBox();
            this.ToSendTBX = new System.Windows.Forms.TextBox();
            this.sendBTN = new System.Windows.Forms.Button();
            this.mesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.mesPanel);
            this.MainPanel.Controls.Add(this.connectBTN);
            this.MainPanel.Controls.Add(this.nameTBX);
            this.MainPanel.Controls.Add(this.ToSendTBX);
            this.MainPanel.Controls.Add(this.sendBTN);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 1;
            // 
            // connectBTN
            // 
            this.connectBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBTN.Location = new System.Drawing.Point(437, 10);
            this.connectBTN.Name = "connectBTN";
            this.connectBTN.Size = new System.Drawing.Size(75, 23);
            this.connectBTN.TabIndex = 9;
            this.connectBTN.Text = "connect";
            this.connectBTN.UseVisualStyleBackColor = true;
            this.connectBTN.Click += new System.EventHandler(this.connectBTN_Click_1);
            // 
            // nameTBX
            // 
            this.nameTBX.Location = new System.Drawing.Point(529, 12);
            this.nameTBX.Name = "nameTBX";
            this.nameTBX.Size = new System.Drawing.Size(264, 20);
            this.nameTBX.TabIndex = 8;
            // 
            // ToSendTBX
            // 
            this.ToSendTBX.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToSendTBX.Location = new System.Drawing.Point(94, 409);
            this.ToSendTBX.Name = "ToSendTBX";
            this.ToSendTBX.Size = new System.Drawing.Size(694, 28);
            this.ToSendTBX.TabIndex = 7;
            // 
            // sendBTN
            // 
            this.sendBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBTN.Location = new System.Drawing.Point(12, 405);
            this.sendBTN.Name = "sendBTN";
            this.sendBTN.Size = new System.Drawing.Size(75, 36);
            this.sendBTN.TabIndex = 6;
            this.sendBTN.Text = "send";
            this.sendBTN.UseVisualStyleBackColor = true;
            this.sendBTN.Click += new System.EventHandler(this.sendBTN_Click_1);
            // 
            // mesPanel
            // 
            this.mesPanel.AutoScroll = true;
            this.mesPanel.Location = new System.Drawing.Point(409, 55);
            this.mesPanel.Name = "mesPanel";
            this.mesPanel.Size = new System.Drawing.Size(387, 348);
            this.mesPanel.TabIndex = 10;
            // 
            // MainChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "MainChat";
            this.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button connectBTN;
        private System.Windows.Forms.TextBox nameTBX;
        private System.Windows.Forms.TextBox ToSendTBX;
        private System.Windows.Forms.Button sendBTN;
        private System.Windows.Forms.FlowLayoutPanel mesPanel;
    }
}
