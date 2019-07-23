namespace Kidumatica_Update
{
    partial class StudentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMain));
            this.back = new System.Windows.Forms.Button();
            this.ParentsFeedback = new System.Windows.Forms.Button();
            this.StudentRatingVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupID = new System.Windows.Forms.TextBox();
            this.HelloStudent = new System.Windows.Forms.Label();
            this.HistoryFeedback = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(26, 28);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(125, 71);
            this.back.TabIndex = 5;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ParentsFeedback
            // 
            this.ParentsFeedback.BackColor = System.Drawing.Color.Bisque;
            this.ParentsFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ParentsFeedback.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParentsFeedback.Location = new System.Drawing.Point(488, 96);
            this.ParentsFeedback.Name = "ParentsFeedback";
            this.ParentsFeedback.Size = new System.Drawing.Size(229, 71);
            this.ParentsFeedback.TabIndex = 6;
            this.ParentsFeedback.Text = "Give a Feedback";
            this.ParentsFeedback.UseVisualStyleBackColor = false;
            this.ParentsFeedback.Click += new System.EventHandler(this.ParentsFeedback_Click);
            // 
            // StudentRatingVal
            // 
            this.StudentRatingVal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.StudentRatingVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StudentRatingVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentRatingVal.Font = new System.Drawing.Font("Comic Sans MS", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRatingVal.Location = new System.Drawing.Point(532, 357);
            this.StudentRatingVal.Name = "StudentRatingVal";
            this.StudentRatingVal.Size = new System.Drawing.Size(130, 28);
            this.StudentRatingVal.TabIndex = 8;
            this.StudentRatingVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your Rating:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Group ID:";
            // 
            // groupID
            // 
            this.groupID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupID.Font = new System.Drawing.Font("Comic Sans MS", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupID.Location = new System.Drawing.Point(532, 481);
            this.groupID.Name = "groupID";
            this.groupID.Size = new System.Drawing.Size(130, 28);
            this.groupID.TabIndex = 11;
            this.groupID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HelloStudent
            // 
            this.HelloStudent.AutoSize = true;
            this.HelloStudent.Location = new System.Drawing.Point(445, 74);
            this.HelloStudent.Name = "HelloStudent";
            this.HelloStudent.Size = new System.Drawing.Size(0, 15);
            this.HelloStudent.TabIndex = 12;
            // 
            // HistoryFeedback
            // 
            this.HistoryFeedback.BackColor = System.Drawing.Color.Bisque;
            this.HistoryFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HistoryFeedback.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryFeedback.Location = new System.Drawing.Point(488, 183);
            this.HistoryFeedback.Name = "HistoryFeedback";
            this.HistoryFeedback.Size = new System.Drawing.Size(229, 71);
            this.HistoryFeedback.TabIndex = 13;
            this.HistoryFeedback.Text = "View Recieved Feedbacks";
            this.HistoryFeedback.UseVisualStyleBackColor = false;
            this.HistoryFeedback.Click += new System.EventHandler(this.HistoryFeedback_Click);
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.BackColor = System.Drawing.Color.SandyBrown;
            this.StudentName.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.Location = new System.Drawing.Point(505, 49);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(49, 24);
            this.StudentName.TabIndex = 14;
            this.StudentName.Text = "hello";
            this.StudentName.Click += new System.EventHandler(this.StudentName_Click);
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 635);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.HistoryFeedback);
            this.Controls.Add(this.HelloStudent);
            this.Controls.Add(this.groupID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentRatingVal);
            this.Controls.Add(this.ParentsFeedback);
            this.Controls.Add(this.back);
            this.DoubleBuffered = true;
            this.Name = "StudentMain";
            this.Text = "StudentMain";
            this.Load += new System.EventHandler(this.StudentMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button ParentsFeedback;
        private System.Windows.Forms.TextBox StudentRatingVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox groupID;
        private System.Windows.Forms.Label HelloStudent;
        private System.Windows.Forms.Button HistoryFeedback;
        private System.Windows.Forms.Label StudentName;
    }
}