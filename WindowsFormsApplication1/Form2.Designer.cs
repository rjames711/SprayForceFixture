namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelExportButton = new System.Windows.Forms.Button();
            this.FinishExportButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.topLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.CancelExportButton);
            this.panel1.Controls.Add(this.FinishExportButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 233);
            this.panel1.MinimumSize = new System.Drawing.Size(650, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 30);
            this.panel1.TabIndex = 0;
            // 
            // CancelExportButton
            // 
            this.CancelExportButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CancelExportButton.Location = new System.Drawing.Point(0, 0);
            this.CancelExportButton.Name = "CancelExportButton";
            this.CancelExportButton.Size = new System.Drawing.Size(97, 30);
            this.CancelExportButton.TabIndex = 1;
            this.CancelExportButton.Text = "Cancel Export";
            this.CancelExportButton.UseVisualStyleBackColor = true;
            this.CancelExportButton.Click += new System.EventHandler(this.CancelExportButton_Click);
            // 
            // FinishExportButton
            // 
            this.FinishExportButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FinishExportButton.Location = new System.Drawing.Point(577, 0);
            this.FinishExportButton.Name = "FinishExportButton";
            this.FinishExportButton.Size = new System.Drawing.Size(108, 30);
            this.FinishExportButton.TabIndex = 0;
            this.FinishExportButton.Text = "Finish Export";
            this.FinishExportButton.UseVisualStyleBackColor = true;
            this.FinishExportButton.Click += new System.EventHandler(this.FinishExportButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 31);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.Size = new System.Drawing.Size(685, 202);
            this.mainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.topLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 31);
            this.panel2.TabIndex = 2;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(26, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(187, 16);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Tests Available for Export";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 263);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "Form2";
            this.Text = "Export Dialog";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelExportButton;
        private System.Windows.Forms.Button FinishExportButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label topLabel;
    }
}