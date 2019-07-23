namespace Kidumatica_Update
{
    partial class OldFeedbacks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldFeedbacks));
            this.AllActivitesFeedback = new System.Windows.Forms.Label();
            this.activityFeedbackOld = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllActivitesFeedback
            // 
            this.AllActivitesFeedback.AccessibleName = "AllActivitesFeedback";
            this.AllActivitesFeedback.AutoSize = true;
            this.AllActivitesFeedback.BackColor = System.Drawing.Color.LavenderBlush;
            this.AllActivitesFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllActivitesFeedback.Font = new System.Drawing.Font("Comic Sans MS", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllActivitesFeedback.Location = new System.Drawing.Point(460, 68);
            this.AllActivitesFeedback.Name = "AllActivitesFeedback";
            this.AllActivitesFeedback.Size = new System.Drawing.Size(237, 29);
            this.AllActivitesFeedback.TabIndex = 0;
            this.AllActivitesFeedback.Text = "All Activites Feedback";
            this.AllActivitesFeedback.Click += new System.EventHandler(this.label1_Click);
            // 
            // activityFeedbackOld
            // 
            this.activityFeedbackOld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.activityFeedbackOld.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityFeedbackOld.Location = new System.Drawing.Point(336, 114);
            this.activityFeedbackOld.Multiline = true;
            this.activityFeedbackOld.Name = "activityFeedbackOld";
            this.activityFeedbackOld.Size = new System.Drawing.Size(459, 379);
            this.activityFeedbackOld.TabIndex = 1;
            this.activityFeedbackOld.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(12, 22);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(121, 74);
            this.back.TabIndex = 19;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // OldFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 635);
            this.Controls.Add(this.back);
            this.Controls.Add(this.activityFeedbackOld);
            this.Controls.Add(this.AllActivitesFeedback);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "OldFeedbacks";
            this.Text = "OldFeedbackEmp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AllActivitesFeedback;
        private System.Windows.Forms.TextBox activityFeedbackOld;
        private System.Windows.Forms.Button back;
    }
}