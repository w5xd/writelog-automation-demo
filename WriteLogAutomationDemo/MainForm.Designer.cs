namespace WriteLogAutomationDemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonDemoQsoCollection = new System.Windows.Forms.Button();
            this.buttonQsoEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCWMemF2 = new System.Windows.Forms.TextBox();
            this.buttonUpdateCWMemory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDemoQsoCollection
            // 
            this.buttonDemoQsoCollection.Location = new System.Drawing.Point(150, 178);
            this.buttonDemoQsoCollection.Name = "buttonDemoQsoCollection";
            this.buttonDemoQsoCollection.Size = new System.Drawing.Size(143, 23);
            this.buttonDemoQsoCollection.TabIndex = 8;
            this.buttonDemoQsoCollection.Text = "Demo QSO &Collection";
            this.buttonDemoQsoCollection.UseVisualStyleBackColor = true;
            this.buttonDemoQsoCollection.Click += new System.EventHandler(this.buttonDemoQsoCollection_Click);
            // 
            // buttonQsoEntry
            // 
            this.buttonQsoEntry.Location = new System.Drawing.Point(150, 131);
            this.buttonQsoEntry.Name = "buttonQsoEntry";
            this.buttonQsoEntry.Size = new System.Drawing.Size(143, 23);
            this.buttonQsoEntry.TabIndex = 6;
            this.buttonQsoEntry.Text = "Demo QSO &Entry";
            this.buttonQsoEntry.UseVisualStyleBackColor = true;
            this.buttonQsoEntry.Click += new System.EventHandler(this.buttonQsoEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "F2 CW &memory:";
            // 
            // textBoxCWMemF2
            // 
            this.textBoxCWMemF2.Location = new System.Drawing.Point(178, 89);
            this.textBoxCWMemF2.Name = "textBoxCWMemF2";
            this.textBoxCWMemF2.Size = new System.Drawing.Size(100, 20);
            this.textBoxCWMemF2.TabIndex = 3;
            this.textBoxCWMemF2.WordWrap = false;
            // 
            // buttonUpdateCWMemory
            // 
            this.buttonUpdateCWMemory.Location = new System.Drawing.Point(298, 88);
            this.buttonUpdateCWMemory.Name = "buttonUpdateCWMemory";
            this.buttonUpdateCWMemory.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateCWMemory.TabIndex = 4;
            this.buttonUpdateCWMemory.Text = "&Update";
            this.buttonUpdateCWMemory.UseVisualStyleBackColor = true;
            this.buttonUpdateCWMemory.Click += new System.EventHandler(this.buttonUpdateCWMemory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Message:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(311, 205);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(12, 13);
            this.messageLabel.TabIndex = 12;
            this.messageLabel.Text = "x";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 227);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUpdateCWMemory);
            this.Controls.Add(this.textBoxCWMemF2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonQsoEntry);
            this.Controls.Add(this.buttonDemoQsoCollection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "WriteLog Automation Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDemoQsoCollection;
        private System.Windows.Forms.Button buttonQsoEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCWMemF2;
        private System.Windows.Forms.Button buttonUpdateCWMemory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label messageLabel;
    }
}

