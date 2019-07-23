namespace Kidumatica_Update
{
    partial class AddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            this.label1 = new System.Windows.Forms.Label();
            this.NoteTitleTextBox = new System.Windows.Forms.TextBox();
            this.NoteDescription = new System.Windows.Forms.RichTextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.ExpiryDate = new System.Windows.Forms.Label();
            this.LastShownDT = new System.Windows.Forms.DateTimePicker();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NoteTitleTextBox
            // 
            this.NoteTitleTextBox.Location = new System.Drawing.Point(414, 33);
            this.NoteTitleTextBox.Name = "NoteTitleTextBox";
            this.NoteTitleTextBox.Size = new System.Drawing.Size(278, 20);
            this.NoteTitleTextBox.TabIndex = 1;
            // 
            // NoteDescription
            // 
            this.NoteDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NoteDescription.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteDescription.ForeColor = System.Drawing.Color.Black;
            this.NoteDescription.Location = new System.Drawing.Point(331, 78);
            this.NoteDescription.Name = "NoteDescription";
            this.NoteDescription.Size = new System.Drawing.Size(361, 370);
            this.NoteDescription.TabIndex = 2;
            this.NoteDescription.Text = "";
            this.NoteDescription.TextChanged += new System.EventHandler(this.NoteDescription_TextChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Cyan;
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Submit.Location = new System.Drawing.Point(716, 466);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(88, 36);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.AutoSize = true;
            this.ExpiryDate.BackColor = System.Drawing.Color.Aqua;
            this.ExpiryDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ExpiryDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExpiryDate.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDate.Location = new System.Drawing.Point(781, 34);
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.Size = new System.Drawing.Size(107, 26);
            this.ExpiryDate.TabIndex = 4;
            this.ExpiryDate.Text = "Expiry Date";
            this.ExpiryDate.Click += new System.EventHandler(this.ExpiryDate_Click);
            // 
            // LastShownDT
            // 
            this.LastShownDT.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LastShownDT.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LastShownDT.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.LastShownDT.Location = new System.Drawing.Point(731, 78);
            this.LastShownDT.MinDate = new System.DateTime(2019, 6, 14, 0, 0, 0, 0);
            this.LastShownDT.Name = "LastShownDT";
            this.LastShownDT.Size = new System.Drawing.Size(199, 20);
            this.LastShownDT.TabIndex = 5;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(51, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 65);
            this.back.TabIndex = 6;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 635);
            this.Controls.Add(this.back);
            this.Controls.Add(this.LastShownDT);
            this.Controls.Add(this.ExpiryDate);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.NoteDescription);
            this.Controls.Add(this.NoteTitleTextBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "AddNote";
            this.Text = "AddNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NoteTitleTextBox;
        private System.Windows.Forms.RichTextBox NoteDescription;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label ExpiryDate;
        private System.Windows.Forms.DateTimePicker LastShownDT;
        private System.Windows.Forms.Button back;
    }
}