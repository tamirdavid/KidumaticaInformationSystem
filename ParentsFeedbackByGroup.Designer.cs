namespace Kidumatica_Update
{
    partial class ParentsFeedbackByGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentsFeedbackByGroup));
            this.ChooseGroup = new System.Windows.Forms.ComboBox();
            this.ParentsFreeTextByGroup = new System.Windows.Forms.RichTextBox();
            this.Question1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportToExcel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Question1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseGroup
            // 
            this.ChooseGroup.BackColor = System.Drawing.Color.SeaShell;
            this.ChooseGroup.FormattingEnabled = true;
            this.ChooseGroup.Location = new System.Drawing.Point(43, 87);
            this.ChooseGroup.Name = "ChooseGroup";
            this.ChooseGroup.Size = new System.Drawing.Size(195, 21);
            this.ChooseGroup.TabIndex = 0;
            this.ChooseGroup.SelectedIndexChanged += new System.EventHandler(this.ChooseGroup_SelectedIndexChanged);
            // 
            // ParentsFreeTextByGroup
            // 
            this.ParentsFreeTextByGroup.BackColor = System.Drawing.Color.SeaShell;
            this.ParentsFreeTextByGroup.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParentsFreeTextByGroup.ForeColor = System.Drawing.Color.Black;
            this.ParentsFreeTextByGroup.Location = new System.Drawing.Point(12, 114);
            this.ParentsFreeTextByGroup.Name = "ParentsFreeTextByGroup";
            this.ParentsFreeTextByGroup.Size = new System.Drawing.Size(262, 307);
            this.ParentsFreeTextByGroup.TabIndex = 1;
            this.ParentsFreeTextByGroup.Text = "";
            this.ParentsFreeTextByGroup.TextChanged += new System.EventHandler(this.ParentsFreeTextByGroup_TextChanged);
            // 
            // Question1
            // 
            this.Question1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Question1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Question1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Question1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Question1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Question1.Location = new System.Drawing.Point(363, 114);
            this.Question1.Name = "Question1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Question1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Question1.Size = new System.Drawing.Size(543, 307);
            this.Question1.TabIndex = 2;
            this.Question1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Question1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Question";
            this.Column1.Name = "Column1";
            this.Column1.Width = 400;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Average Grade";
            this.Column2.Name = "Column2";
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportToExcel.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToExcel.Location = new System.Drawing.Point(591, 459);
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(107, 65);
            this.ExportToExcel.TabIndex = 3;
            this.ExportToExcel.Text = "Export To Excel";
            this.ExportToExcel.UseVisualStyleBackColor = false;
            this.ExportToExcel.Click += new System.EventHandler(this.xl_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(552, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Parents feedback";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(60, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(118, 72);
            this.back.TabIndex = 7;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ParentsFeedbackByGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 635);
            this.Controls.Add(this.back);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ExportToExcel);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.ParentsFreeTextByGroup);
            this.Controls.Add(this.ChooseGroup);
            this.DoubleBuffered = true;
            this.Name = "ParentsFeedbackByGroup";
            this.Text = "ActivityFeedbackByGroup";
            this.Load += new System.EventHandler(this.ActivityFeedbackByGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Question1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseGroup;
        private System.Windows.Forms.RichTextBox ParentsFreeTextByGroup;
        private System.Windows.Forms.DataGridView Question1;
        private System.Windows.Forms.Button ExportToExcel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button back;
    }
}