namespace Caroline
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
            this.button1 = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rafBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.tbxRoom = new System.Windows.Forms.TextBox();
            this.tbxGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbxTeacher = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(176, 1131);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(338, 1131);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(150, 44);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(500, 1131);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sort";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1794, 1131);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "Find";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rafBtn
            // 
            this.rafBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rafBtn.Location = new System.Drawing.Point(1956, 1131);
            this.rafBtn.Margin = new System.Windows.Forms.Padding(6);
            this.rafBtn.Name = "rafBtn";
            this.rafBtn.Size = new System.Drawing.Size(150, 44);
            this.rafBtn.TabIndex = 5;
            this.rafBtn.Text = "RAF";
            this.rafBtn.UseVisualStyleBackColor = true;
            this.rafBtn.Click += new System.EventHandler(this.rafBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(2118, 1131);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(150, 44);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(1096, 1137);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(6);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(196, 31);
            this.tbxSearch.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1002, 1137);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search";
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(176, 112);
            this.dgvClass.Margin = new System.Windows.Forms.Padding(6);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.Size = new System.Drawing.Size(2092, 1008);
            this.dgvClass.TabIndex = 9;
            this.dgvClass.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvClass_DataBindingComplete);
            // 
            // tbxDate
            // 
            this.tbxDate.Location = new System.Drawing.Point(1390, 62);
            this.tbxDate.Margin = new System.Windows.Forms.Padding(6);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(196, 31);
            this.tbxDate.TabIndex = 11;
            // 
            // tbxRoom
            // 
            this.tbxRoom.Location = new System.Drawing.Point(1032, 62);
            this.tbxRoom.Margin = new System.Windows.Forms.Padding(6);
            this.tbxRoom.Name = "tbxRoom";
            this.tbxRoom.Size = new System.Drawing.Size(196, 31);
            this.tbxRoom.TabIndex = 12;
            // 
            // tbxGrade
            // 
            this.tbxGrade.Location = new System.Drawing.Point(664, 62);
            this.tbxGrade.Margin = new System.Windows.Forms.Padding(6);
            this.tbxGrade.Name = "tbxGrade";
            this.tbxGrade.Size = new System.Drawing.Size(196, 31);
            this.tbxGrade.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(950, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1318, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Teacher";
            // 
            // tbxTeacher
            // 
            this.tbxTeacher.Location = new System.Drawing.Point(338, 56);
            this.tbxTeacher.Margin = new System.Windows.Forms.Padding(6);
            this.tbxTeacher.Name = "tbxTeacher";
            this.tbxTeacher.Size = new System.Drawing.Size(196, 31);
            this.tbxTeacher.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2690, 1262);
            this.Controls.Add(this.tbxTeacher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxGrade);
            this.Controls.Add(this.tbxRoom);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.rafBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button rafBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.TextBox tbxRoom;
        private System.Windows.Forms.TextBox tbxGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbxTeacher;
    }
}

