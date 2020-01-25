namespace MegaDesk_Evans
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.ExitSearchPageButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitSearchPageButton
            // 
            this.ExitSearchPageButton.Location = new System.Drawing.Point(333, 12);
            this.ExitSearchPageButton.Name = "ExitSearchPageButton";
            this.ExitSearchPageButton.Size = new System.Drawing.Size(136, 63);
            this.ExitSearchPageButton.TabIndex = 0;
            this.ExitSearchPageButton.Text = "Exit";
            this.ExitSearchPageButton.UseVisualStyleBackColor = true;
            this.ExitSearchPageButton.Click += new System.EventHandler(this.ExitSearchPageButton_Click_1);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(12, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(129, 63);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchQuotes
            // 
            this.ClientSize = new System.Drawing.Size(481, 336);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ExitSearchPageButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button ExitSearchPageButton;
        private System.Windows.Forms.Button SearchButton;
    }
}