namespace MegaDesk_Evans
{
    partial class ViewAllQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.ViewRecent = new System.Windows.Forms.Button();
            this.ExitViewAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewRecent
            // 
            this.ViewRecent.Location = new System.Drawing.Point(11, 11);
            this.ViewRecent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewRecent.Name = "ViewRecent";
            this.ViewRecent.Size = new System.Drawing.Size(117, 50);
            this.ViewRecent.TabIndex = 3;
            this.ViewRecent.Text = "Search";
            this.ViewRecent.UseVisualStyleBackColor = true;
            // 
            // ExitViewAllButton
            // 
            this.ExitViewAllButton.Location = new System.Drawing.Point(459, 11);
            this.ExitViewAllButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitViewAllButton.Name = "ExitViewAllButton";
            this.ExitViewAllButton.Size = new System.Drawing.Size(130, 50);
            this.ExitViewAllButton.TabIndex = 2;
            this.ExitViewAllButton.Text = "Exit";
            this.ExitViewAllButton.UseVisualStyleBackColor = true;
            this.ExitViewAllButton.Click += new System.EventHandler(this.ExitViewAllButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ViewRecent);
            this.Controls.Add(this.ExitViewAllButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewRecent;
        private System.Windows.Forms.Button ExitViewAllButton;
    }
}