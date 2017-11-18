namespace WriteLogAutomationDemo
{
    partial class QsoEntryDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCALL = new System.Windows.Forms.TextBox();
            this.buttonLogQSO = new System.Windows.Forms.Button();
            this.buttonCheckDupe = new System.Windows.Forms.Button();
            this.labelFreq = new System.Windows.Forms.Label();
            this.textBoxKHz = new System.Windows.Forms.TextBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&CALL:";
            // 
            // textBoxCALL
            // 
            this.textBoxCALL.Location = new System.Drawing.Point(129, 11);
            this.textBoxCALL.Name = "textBoxCALL";
            this.textBoxCALL.Size = new System.Drawing.Size(100, 20);
            this.textBoxCALL.TabIndex = 1;
            // 
            // buttonLogQSO
            // 
            this.buttonLogQSO.Location = new System.Drawing.Point(200, 131);
            this.buttonLogQSO.Name = "buttonLogQSO";
            this.buttonLogQSO.Size = new System.Drawing.Size(75, 23);
            this.buttonLogQSO.TabIndex = 11;
            this.buttonLogQSO.Text = "Log &QSO";
            this.buttonLogQSO.UseVisualStyleBackColor = true;
            this.buttonLogQSO.Click += new System.EventHandler(this.buttonLogQSO_Click);
            // 
            // buttonCheckDupe
            // 
            this.buttonCheckDupe.Location = new System.Drawing.Point(46, 131);
            this.buttonCheckDupe.Name = "buttonCheckDupe";
            this.buttonCheckDupe.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckDupe.TabIndex = 10;
            this.buttonCheckDupe.Text = "Check &Dupe";
            this.buttonCheckDupe.UseVisualStyleBackColor = true;
            this.buttonCheckDupe.Click += new System.EventHandler(this.buttonCheckDupe_Click);
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.Location = new System.Drawing.Point(20, 53);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(89, 13);
            this.labelFreq.TabIndex = 4;
            this.labelFreq.Text = "&Frequency (KHz):";
            // 
            // textBoxKHz
            // 
            this.textBoxKHz.Location = new System.Drawing.Point(129, 49);
            this.textBoxKHz.Name = "textBoxKHz";
            this.textBoxKHz.Size = new System.Drawing.Size(100, 20);
            this.textBoxKHz.TabIndex = 5;
            this.textBoxKHz.Text = "7000";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(72, 91);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(37, 13);
            this.labelMode.TabIndex = 6;
            this.labelMode.Text = "&Mode:";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "LSB",
            "USB",
            "CW",
            "FM",
            "AM",
            "FSK"});
            this.comboBoxMode.Location = new System.Drawing.Point(129, 87);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(85, 21);
            this.comboBoxMode.TabIndex = 7;
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.Location = new System.Drawing.Point(279, 12);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(75, 23);
            this.buttonGetAll.TabIndex = 3;
            this.buttonGetAll.Text = "&Get All";
            this.buttonGetAll.UseVisualStyleBackColor = true;
            this.buttonGetAll.Click += new System.EventHandler(this.buttonGetAll_Click);
            // 
            // QsoEntryDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 169);
            this.Controls.Add(this.buttonGetAll);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.textBoxKHz);
            this.Controls.Add(this.labelFreq);
            this.Controls.Add(this.buttonCheckDupe);
            this.Controls.Add(this.buttonLogQSO);
            this.Controls.Add(this.textBoxCALL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QsoEntryDemo";
            this.Text = "QSO Entry Demo";
            this.Load += new System.EventHandler(this.QsoEntryDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCALL;
        private System.Windows.Forms.Button buttonLogQSO;
        private System.Windows.Forms.Button buttonCheckDupe;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.TextBox textBoxKHz;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Button buttonGetAll;
    }
}