namespace Kidumatica_Update
{
    partial class RatingReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatingReportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.back = new System.Windows.Forms.Button();
            this.ratingReportTable = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupIdVal = new System.Windows.Forms.Label();
            this.RatingReportFormTitle = new System.Windows.Forms.Label();
            this.SubmitRatingReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ratingReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(26, 28);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(125, 71);
            this.back.TabIndex = 6;
            this.back.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ratingReportTable
            // 
            this.ratingReportTable.AllowUserToDeleteRows = false;
            this.ratingReportTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ratingReportTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.267326F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ratingReportTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ratingReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratingReportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.CurrentRating,
            this.ActivityRating});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ratingReportTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.ratingReportTable.Location = new System.Drawing.Point(388, 158);
            this.ratingReportTable.Name = "ratingReportTable";
            this.ratingReportTable.Size = new System.Drawing.Size(594, 329);
            this.ratingReportTable.TabIndex = 7;
            this.ratingReportTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 150;
            // 
            // CurrentRating
            // 
            this.CurrentRating.HeaderText = "Current Rating";
            this.CurrentRating.Name = "CurrentRating";
            this.CurrentRating.Width = 150;
            // 
            // ActivityRating
            // 
            this.ActivityRating.HeaderText = "Rating Per Activity";
            this.ActivityRating.Name = "ActivityRating";
            this.ActivityRating.Width = 150;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Location = new System.Drawing.Point(782, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Group ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupIdVal
            // 
            this.groupIdVal.AutoSize = true;
            this.groupIdVal.Location = new System.Drawing.Point(599, 79);
            this.groupIdVal.Name = "groupIdVal";
            this.groupIdVal.Size = new System.Drawing.Size(0, 15);
            this.groupIdVal.TabIndex = 10;
            // 
            // RatingReportFormTitle
            // 
            this.RatingReportFormTitle.AutoSize = true;
            this.RatingReportFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RatingReportFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RatingReportFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RatingReportFormTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingReportFormTitle.Location = new System.Drawing.Point(602, 18);
            this.RatingReportFormTitle.Name = "RatingReportFormTitle";
            this.RatingReportFormTitle.Size = new System.Drawing.Size(205, 31);
            this.RatingReportFormTitle.TabIndex = 11;
            this.RatingReportFormTitle.Text = "Rating Report Form";
            // 
            // SubmitRatingReport
            // 
            this.SubmitRatingReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SubmitRatingReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SubmitRatingReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitRatingReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitRatingReport.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitRatingReport.Location = new System.Drawing.Point(658, 539);
            this.SubmitRatingReport.Name = "SubmitRatingReport";
            this.SubmitRatingReport.Size = new System.Drawing.Size(83, 42);
            this.SubmitRatingReport.TabIndex = 12;
            this.SubmitRatingReport.Text = "Submit";
            this.SubmitRatingReport.UseVisualStyleBackColor = false;
            this.SubmitRatingReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // RatingReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 635);
            this.Controls.Add(this.SubmitRatingReport);
            this.Controls.Add(this.RatingReportFormTitle);
            this.Controls.Add(this.groupIdVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ratingReportTable);
            this.Controls.Add(this.back);
            this.DoubleBuffered = true;
            this.Name = "RatingReportForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RatingReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ratingReportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView ratingReportTable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label groupIdVal;
        private System.Windows.Forms.Label RatingReportFormTitle;
        private System.Windows.Forms.Button SubmitRatingReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityRating;
    }
}