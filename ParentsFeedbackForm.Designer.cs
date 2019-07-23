namespace Kidumatica_Update
{
    partial class ParentsFeedbackForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentsFeedbackForm));
            this.questionnaire = new System.Windows.Forms.DataGridView();
            this.questionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ans1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ans2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ans3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ans4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ans5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.back = new System.Windows.Forms.Button();
            this.Submit_parentFeedback = new System.Windows.Forms.Button();
            this.PfFormTitle = new System.Windows.Forms.Label();
            this.pfdescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.questionnaire)).BeginInit();
            this.SuspendLayout();
            // 
            // questionnaire
            // 
            this.questionnaire.AllowUserToAddRows = false;
            this.questionnaire.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.questionnaire.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.questionnaire.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.questionnaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.questionnaire.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.questionnaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionnaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionId,
            this.Question,
            this.Ans1,
            this.Ans2,
            this.Ans3,
            this.Ans4,
            this.Ans5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.questionnaire.DefaultCellStyle = dataGridViewCellStyle4;
            this.questionnaire.Location = new System.Drawing.Point(263, 117);
            this.questionnaire.Name = "questionnaire";
            this.questionnaire.Size = new System.Drawing.Size(695, 261);
            this.questionnaire.TabIndex = 0;
            this.questionnaire.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // questionId
            // 
            this.questionId.HeaderText = "questionId";
            this.questionId.Name = "questionId";
            this.questionId.Visible = false;
            // 
            // Question
            // 
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.Question.DefaultCellStyle = dataGridViewCellStyle3;
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            this.Question.Width = 400;
            // 
            // Ans1
            // 
            this.Ans1.HeaderText = "1";
            this.Ans1.Name = "Ans1";
            this.Ans1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ans1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ans1.Width = 50;
            // 
            // Ans2
            // 
            this.Ans2.HeaderText = "2";
            this.Ans2.Name = "Ans2";
            this.Ans2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ans2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ans2.Width = 50;
            // 
            // Ans3
            // 
            this.Ans3.HeaderText = "3";
            this.Ans3.Name = "Ans3";
            this.Ans3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ans3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ans3.Width = 50;
            // 
            // Ans4
            // 
            this.Ans4.HeaderText = "4";
            this.Ans4.Name = "Ans4";
            this.Ans4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ans4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ans4.Width = 50;
            // 
            // Ans5
            // 
            this.Ans5.HeaderText = "5";
            this.Ans5.Name = "Ans5";
            this.Ans5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ans5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ans5.Width = 50;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(55, 14);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(118, 72);
            this.back.TabIndex = 6;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Submit_parentFeedback
            // 
            this.Submit_parentFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Submit_parentFeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Submit_parentFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit_parentFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit_parentFeedback.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_parentFeedback.Location = new System.Drawing.Point(638, 585);
            this.Submit_parentFeedback.Name = "Submit_parentFeedback";
            this.Submit_parentFeedback.Size = new System.Drawing.Size(75, 38);
            this.Submit_parentFeedback.TabIndex = 7;
            this.Submit_parentFeedback.Text = "Submit";
            this.Submit_parentFeedback.UseVisualStyleBackColor = false;
            this.Submit_parentFeedback.Click += new System.EventHandler(this.Submit_parentFeedback_Click);
            // 
            // PfFormTitle
            // 
            this.PfFormTitle.AutoSize = true;
            this.PfFormTitle.BackColor = System.Drawing.Color.Honeydew;
            this.PfFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PfFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PfFormTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PfFormTitle.Location = new System.Drawing.Point(522, 55);
            this.PfFormTitle.Name = "PfFormTitle";
            this.PfFormTitle.Size = new System.Drawing.Size(245, 31);
            this.PfFormTitle.TabIndex = 12;
            this.PfFormTitle.Text = "Parents Feedback Form";
            // 
            // pfdescription
            // 
            this.pfdescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pfdescription.Location = new System.Drawing.Point(449, 424);
            this.pfdescription.Name = "pfdescription";
            this.pfdescription.Size = new System.Drawing.Size(509, 140);
            this.pfdescription.TabIndex = 13;
            this.pfdescription.Text = "";
            this.pfdescription.TextChanged += new System.EventHandler(this.pfdescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Additional Comment";
            // 
            // ParentsFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pfdescription);
            this.Controls.Add(this.PfFormTitle);
            this.Controls.Add(this.Submit_parentFeedback);
            this.Controls.Add(this.back);
            this.Controls.Add(this.questionnaire);
            this.DoubleBuffered = true;
            this.Name = "ParentsFeedbackForm";
            this.Text = "Kidumatica";
            ((System.ComponentModel.ISupportInitialize)(this.questionnaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView questionnaire;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Submit_parentFeedback;
        private System.Windows.Forms.Label PfFormTitle;
        private System.Windows.Forms.RichTextBox pfdescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ans1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ans2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ans3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ans4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ans5;
    }
}