namespace Dr.Prepper
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.dirname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.results = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_rename = new System.Windows.Forms.Button();
            this.lbl_success = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dirname);
            this.groupBox1.Controls.Add(this.btn_browse);
            this.groupBox1.Location = new System.Drawing.Point(16, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Choose Base Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prepares files for import into SharePoint by removing special characters from fil" +
    "enames.";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(7, 20);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // dirname
            // 
            this.dirname.Location = new System.Drawing.Point(89, 22);
            this.dirname.Name = "dirname";
            this.dirname.Size = new System.Drawing.Size(556, 20);
            this.dirname.TabIndex = 1;
            this.dirname.TextChanged += new System.EventHandler(this.dirname_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_scan);
            this.groupBox2.Location = new System.Drawing.Point(13, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 83);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Perform Scan";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(6, 54);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(641, 23);
            this.btn_scan.TabIndex = 0;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "You will have a chance to confirm before any files are renamed";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.results);
            this.groupBox3.Location = new System.Drawing.Point(13, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 265);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Preview Results";
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(6, 45);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.Size = new System.Drawing.Size(641, 208);
            this.results.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "These files will be renamed";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_success);
            this.groupBox4.Controls.Add(this.btn_rename);
            this.groupBox4.Location = new System.Drawing.Point(13, 488);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(654, 73);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4. Rename Files";
            // 
            // btn_rename
            // 
            this.btn_rename.Location = new System.Drawing.Point(13, 20);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(634, 23);
            this.btn_rename.TabIndex = 0;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // lbl_success
            // 
            this.lbl_success.AutoSize = true;
            this.lbl_success.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_success.Location = new System.Drawing.Point(13, 50);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(48, 13);
            this.lbl_success.TabIndex = 1;
            this.lbl_success.Text = "Success";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 566);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dr. Prepper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dirname;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.Label lbl_success;
    }
}

