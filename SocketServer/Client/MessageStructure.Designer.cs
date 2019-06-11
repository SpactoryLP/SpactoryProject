namespace Client
{
    partial class MessageStructure
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
            this.messageLBL = new System.Windows.Forms.Label();
            this.userNickLBL = new System.Windows.Forms.Label();
            this.timeLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageLBL
            // 
            this.messageLBL.AutoSize = true;
            this.messageLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLBL.Location = new System.Drawing.Point(3, 32);
            this.messageLBL.Name = "messageLBL";
            this.messageLBL.Size = new System.Drawing.Size(0, 18);
            this.messageLBL.TabIndex = 0;
            // 
            // userNickLBL
            // 
            this.userNickLBL.AutoSize = true;
            this.userNickLBL.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNickLBL.Location = new System.Drawing.Point(4, 4);
            this.userNickLBL.Name = "userNickLBL";
            this.userNickLBL.Size = new System.Drawing.Size(0, 14);
            this.userNickLBL.TabIndex = 1;
            // 
            // timeLBL
            // 
            this.timeLBL.AutoSize = true;
            this.timeLBL.Location = new System.Drawing.Point(244, 64);
            this.timeLBL.Name = "timeLBL";
            this.timeLBL.Size = new System.Drawing.Size(0, 13);
            this.timeLBL.TabIndex = 2;
            // 
            // MessageStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.timeLBL);
            this.Controls.Add(this.userNickLBL);
            this.Controls.Add(this.messageLBL);
            this.Name = "MessageStructure";
            this.Size = new System.Drawing.Size(300, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLBL;
        private System.Windows.Forms.Label userNickLBL;
        private System.Windows.Forms.Label timeLBL;
    }
}
