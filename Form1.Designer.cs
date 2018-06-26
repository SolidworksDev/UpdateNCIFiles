namespace UpdateNCFiles
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.searchLocation = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.lbFilesFound = new System.Windows.Forms.ListBox();
            this.filesFound = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.Cancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Search, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchLocation, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(186, 367);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(169, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(77, 26);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Search
            // 
            this.Search.Enabled = false;
            this.Search.Location = new System.Drawing.Point(86, 3);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(77, 26);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // searchLocation
            // 
            this.searchLocation.Location = new System.Drawing.Point(3, 3);
            this.searchLocation.Name = "searchLocation";
            this.searchLocation.Size = new System.Drawing.Size(77, 26);
            this.searchLocation.TabIndex = 2;
            this.searchLocation.Text = "Directory";
            this.searchLocation.UseVisualStyleBackColor = true;
            this.searchLocation.Click += new System.EventHandler(this.searchLocation_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(10, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(51, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(126, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(4, 46);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(47, 13);
            this.lblReplace.TabIndex = 3;
            this.lblReplace.Text = "Replace";
            this.lblReplace.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(51, 43);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(126, 20);
            this.txtReplace.TabIndex = 4;
            // 
            // lbFilesFound
            // 
            this.lbFilesFound.FormattingEnabled = true;
            this.lbFilesFound.Location = new System.Drawing.Point(15, 111);
            this.lbFilesFound.Name = "lbFilesFound";
            this.lbFilesFound.Size = new System.Drawing.Size(423, 238);
            this.lbFilesFound.TabIndex = 5;
            // 
            // filesFound
            // 
            this.filesFound.AutoSize = true;
            this.filesFound.Location = new System.Drawing.Point(12, 79);
            this.filesFound.Name = "filesFound";
            this.filesFound.Size = new System.Drawing.Size(187, 13);
            this.filesFound.TabIndex = 6;
            this.filesFound.Text = "The Following Files Have Been Found";
            this.filesFound.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 411);
            this.Controls.Add(this.filesFound);
            this.Controls.Add(this.lbFilesFound);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SARNC";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.ListBox lbFilesFound;
        private System.Windows.Forms.Label filesFound;
        private System.Windows.Forms.Button searchLocation;
    }
}

