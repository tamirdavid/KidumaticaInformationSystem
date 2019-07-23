namespace Kidumatica_Update
{
    partial class OpenEquipmentDemandForLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenEquipmentDemandForLC));
            this.Submit_ED_Approval = new System.Windows.Forms.Button();
            this.OpenEDforLC = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approve = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NotApproved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ApprovalNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OpenEDforLC)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit_ED_Approval
            // 
            this.Submit_ED_Approval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Submit_ED_Approval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit_ED_Approval.Font = new System.Drawing.Font("Comic Sans MS", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_ED_Approval.Location = new System.Drawing.Point(554, 494);
            this.Submit_ED_Approval.Name = "Submit_ED_Approval";
            this.Submit_ED_Approval.Size = new System.Drawing.Size(99, 36);
            this.Submit_ED_Approval.TabIndex = 0;
            this.Submit_ED_Approval.Text = "Submit";
            this.Submit_ED_Approval.UseVisualStyleBackColor = false;
            this.Submit_ED_Approval.Click += new System.EventHandler(this.Submit_ED_Approval_Click);
            // 
            // OpenEDforLC
            // 
            this.OpenEDforLC.AllowUserToDeleteRows = false;
            this.OpenEDforLC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OpenEDforLC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OpenEDforLC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OpenEDforLC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Creator,
            this.DateTime,
            this.Details,
            this.Description,
            this.Approve,
            this.NotApproved,
            this.ApprovalNote});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OpenEDforLC.DefaultCellStyle = dataGridViewCellStyle2;
            this.OpenEDforLC.Location = new System.Drawing.Point(28, 146);
            this.OpenEDforLC.Name = "OpenEDforLC";
            this.OpenEDforLC.Size = new System.Drawing.Size(1143, 305);
            this.OpenEDforLC.TabIndex = 1;
            this.OpenEDforLC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Creator
            // 
            this.Creator.HeaderText = "Creator";
            this.Creator.Name = "Creator";
            this.Creator.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Date Time";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            this.DateTime.Width = 150;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 300;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // Approve
            // 
            this.Approve.HeaderText = "Approve";
            this.Approve.Name = "Approve";
            this.Approve.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Approve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NotApproved
            // 
            this.NotApproved.HeaderText = "Not Approved";
            this.NotApproved.Name = "NotApproved";
            this.NotApproved.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NotApproved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ApprovalNote
            // 
            this.ApprovalNote.HeaderText = "Approval Note";
            this.ApprovalNote.Name = "ApprovalNote";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(118, 72);
            this.back.TabIndex = 2;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.open.Font = new System.Drawing.Font("Comic Sans MS", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.Location = new System.Drawing.Point(502, 56);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(235, 35);
            this.open.TabIndex = 3;
            this.open.Text = "Open Equipment Demand";
            this.open.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OpenEquipmentDemandForLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 635);
            this.Controls.Add(this.open);
            this.Controls.Add(this.back);
            this.Controls.Add(this.OpenEDforLC);
            this.Controls.Add(this.Submit_ED_Approval);
            this.DoubleBuffered = true;
            this.Name = "OpenEquipmentDemandForLC";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OpenEDforLC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_ED_Approval;
        private System.Windows.Forms.DataGridView OpenEDforLC;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Approve;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NotApproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalNote;
        private System.Windows.Forms.TextBox open;
    }
}