namespace Caroline
{
    partial class search
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
            this.lbxList = new System.Windows.Forms.ListBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.Location = new System.Drawing.Point(203, 57);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(221, 290);
            this.lbxList.TabIndex = 0;
            this.lbxList.SelectedIndexChanged += new System.EventHandler(this.txbList_SelectedIndexChanged);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(247, 35);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(100, 20);
            this.txbSearch.TabIndex = 1;
            this.txbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.lbxList);
            this.Name = "search";
            this.Text = "search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}