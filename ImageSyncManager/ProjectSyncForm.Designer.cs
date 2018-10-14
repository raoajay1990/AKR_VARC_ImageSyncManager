namespace ImageSyncManager
{
    partial class ProjectSyncForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSyncPath = new System.Windows.Forms.Label();
            this.txtSyncPath = new System.Windows.Forms.TextBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Sync Manager";
            // 
            // lblSyncPath
            // 
            this.lblSyncPath.AutoSize = true;
            this.lblSyncPath.Location = new System.Drawing.Point(3, 57);
            this.lblSyncPath.Name = "lblSyncPath";
            this.lblSyncPath.Size = new System.Drawing.Size(56, 13);
            this.lblSyncPath.TabIndex = 1;
            this.lblSyncPath.Text = "Sync Path";
            // 
            // txtSyncPath
            // 
            this.txtSyncPath.Location = new System.Drawing.Point(65, 54);
            this.txtSyncPath.Name = "txtSyncPath";
            this.txtSyncPath.Size = new System.Drawing.Size(207, 20);
            this.txtSyncPath.TabIndex = 2;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(89, 108);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 3;
            this.btnSync.Text = "Submit";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(108, 174);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.txtSyncPath);
            this.Controls.Add(this.lblSyncPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSyncPath;
        private System.Windows.Forms.TextBox txtSyncPath;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Label lblResult;
    }
}

