namespace WriteLogAutomationDemo
{
    partial class QsoCollectionForm
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
            this.labelQsoCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCALL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of QSOs:";
            // 
            // labelQsoCount
            // 
            this.labelQsoCount.AutoSize = true;
            this.labelQsoCount.Location = new System.Drawing.Point(163, 89);
            this.labelQsoCount.Name = "labelQsoCount";
            this.labelQsoCount.Size = new System.Drawing.Size(0, 13);
            this.labelQsoCount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last CALL Logged:";
            // 
            // labelCALL
            // 
            this.labelCALL.AutoSize = true;
            this.labelCALL.Location = new System.Drawing.Point(163, 124);
            this.labelCALL.Name = "labelCALL";
            this.labelCALL.Size = new System.Drawing.Size(0, 13);
            this.labelCALL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "This form is now connected to WriteLog. \r\nEnter (or edit) a QSO in WriteLog and t" +
    "his form will update.\r\n";
            // 
            // QsoCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 166);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCALL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelQsoCount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QsoCollectionForm";
            this.Text = "Qso Collection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QsoCollectionForm_FormClosing);
            this.Load += new System.EventHandler(this.QsoCollectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQsoCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCALL;
        private System.Windows.Forms.Label label3;
    }
}