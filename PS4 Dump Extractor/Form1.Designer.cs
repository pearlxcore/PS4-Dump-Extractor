namespace PS4_Dump_Extractor
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
            this.textOpen = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openPS4DMP = new System.Windows.Forms.OpenFileDialog();
            this.saveFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.openSLB2 = new System.Windows.Forms.OpenFileDialog();
            this.buttonExtractNow = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textOpen
            // 
            this.textOpen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textOpen.Location = new System.Drawing.Point(30, 21);
            this.textOpen.Name = "textOpen";
            this.textOpen.ReadOnly = true;
            this.textOpen.Size = new System.Drawing.Size(262, 20);
            this.textOpen.TabIndex = 0;
            this.textOpen.TabStop = false;
            this.textOpen.Text = "Select PS4 dump to extract";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(217, 48);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Open Dump";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openPS4DMP
            // 
            this.openPS4DMP.FileName = "PS4NORDump";
            this.openPS4DMP.Filter = "|*.BIN";
            this.openPS4DMP.Title = "Select PS4 NOR Dump";
            // 
            // openSLB2
            // 
            this.openSLB2.Filter = "|*.*";
            this.openSLB2.Title = "Select PS4 SLB2 File...";
            // 
            // buttonExtractNow
            // 
            this.buttonExtractNow.Enabled = false;
            this.buttonExtractNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtractNow.Location = new System.Drawing.Point(30, 79);
            this.buttonExtractNow.Name = "buttonExtractNow";
            this.buttonExtractNow.Size = new System.Drawing.Size(262, 50);
            this.buttonExtractNow.TabIndex = 11;
            this.buttonExtractNow.Text = "Extract Dump";
            this.buttonExtractNow.UseVisualStyleBackColor = true;
            this.buttonExtractNow.Click += new System.EventHandler(this.buttonExtractNow_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(129, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Normal";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(39, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "sflash0";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 150);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonExtractNow);
            this.Controls.Add(this.textOpen);
            this.Controls.Add(this.buttonOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS4 Dump Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textOpen;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openPS4DMP;
        private System.Windows.Forms.FolderBrowserDialog saveFolder;
        private System.Windows.Forms.OpenFileDialog openSLB2;
        private System.Windows.Forms.Button buttonExtractNow;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

