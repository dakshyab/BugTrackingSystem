namespace BugTrackingSystem
{
    partial class bug_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bug_log));
            this.dataGridView_log = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_log)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_log
            // 
            this.dataGridView_log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_log.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_log.Location = new System.Drawing.Point(12, 23);
            this.dataGridView_log.Name = "dataGridView_log";
            this.dataGridView_log.RowTemplate.Height = 24;
            this.dataGridView_log.Size = new System.Drawing.Size(1079, 473);
            this.dataGridView_log.TabIndex = 0;
            // 
            // bug_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 508);
            this.Controls.Add(this.dataGridView_log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bug_log";
            this.Text = "Bug Log";
            this.Load += new System.EventHandler(this.bug_log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_log;
    }
}