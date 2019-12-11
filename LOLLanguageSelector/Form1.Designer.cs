namespace LOLLanguageSelector
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrowse.Location = new System.Drawing.Point(252, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 20);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "League of Legends Language Selector";
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.Gray;
            this.txtFilePath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFilePath.Location = new System.Drawing.Point(6, 19);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(242, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(50, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installation Directory";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Controls.Add(this.cmbLanguage);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(50, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 48);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Your Language";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.BackColor = System.Drawing.Color.Gray;
            this.cmbLanguage.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(6, 19);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 21);
            this.cmbLanguage.TabIndex = 0;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLaunch.Location = new System.Drawing.Point(241, 99);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(115, 48);
            this.btnLaunch.TabIndex = 5;
            this.btnLaunch.Text = "Launch!";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(426, 165);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LoL Language Selector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Button btnLaunch;
    }
}

