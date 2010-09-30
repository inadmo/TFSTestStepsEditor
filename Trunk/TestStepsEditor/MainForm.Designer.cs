﻿namespace TestStepsEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._workItemLabel = new System.Windows.Forms.Label();
            this._workItemTextBox = new System.Windows.Forms.TextBox();
            this._loadButton = new System.Windows.Forms.Button();
            this._saveButton = new System.Windows.Forms.Button();
            this._changeProjectButton = new System.Windows.Forms.Button();
            this._testStepsGridView = new System.Windows.Forms.DataGridView();
            this._projectLabel = new System.Windows.Forms.Label();
            this._rowLabel = new System.Windows.Forms.Label();
            this._insertButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._testStepsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _workItemLabel
            // 
            this._workItemLabel.AutoSize = true;
            this._workItemLabel.Location = new System.Drawing.Point(9, 9);
            this._workItemLabel.Name = "_workItemLabel";
            this._workItemLabel.Size = new System.Drawing.Size(56, 13);
            this._workItemLabel.TabIndex = 0;
            this._workItemLabel.Text = "Work Item";
            // 
            // _workItemTextBox
            // 
            this._workItemTextBox.Location = new System.Drawing.Point(71, 6);
            this._workItemTextBox.Name = "_workItemTextBox";
            this._workItemTextBox.Size = new System.Drawing.Size(100, 20);
            this._workItemTextBox.TabIndex = 1;
            this._workItemTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WorkItemTextBox_KeyPress);
            // 
            // _loadButton
            // 
            this._loadButton.Location = new System.Drawing.Point(177, 4);
            this._loadButton.Name = "_loadButton";
            this._loadButton.Size = new System.Drawing.Size(75, 23);
            this._loadButton.TabIndex = 2;
            this._loadButton.Text = "&Load";
            this._loadButton.UseVisualStyleBackColor = true;
            this._loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(258, 4);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(75, 23);
            this._saveButton.TabIndex = 4;
            this._saveButton.Text = "&Save";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // _changeProjectButton
            // 
            this._changeProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._changeProjectButton.Location = new System.Drawing.Point(671, 3);
            this._changeProjectButton.Name = "_changeProjectButton";
            this._changeProjectButton.Size = new System.Drawing.Size(109, 23);
            this._changeProjectButton.TabIndex = 5;
            this._changeProjectButton.Text = "&Change Project";
            this._changeProjectButton.UseVisualStyleBackColor = true;
            this._changeProjectButton.Click += new System.EventHandler(this.ChangeProjectButton_Click);
            // 
            // _testStepsGridView
            // 
            this._testStepsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._testStepsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._testStepsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this._testStepsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._testStepsGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this._testStepsGridView.Location = new System.Drawing.Point(12, 33);
            this._testStepsGridView.Name = "_testStepsGridView";
            this._testStepsGridView.Size = new System.Drawing.Size(768, 428);
            this._testStepsGridView.TabIndex = 6;
            this._testStepsGridView.CurrentCellChanged += new System.EventHandler(this.TestStepsGridView_CurrentCellChanged);
            // 
            // _projectLabel
            // 
            this._projectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._projectLabel.AutoSize = true;
            this._projectLabel.Location = new System.Drawing.Point(583, 8);
            this._projectLabel.Name = "_projectLabel";
            this._projectLabel.Size = new System.Drawing.Size(82, 13);
            this._projectLabel.TabIndex = 7;
            this._projectLabel.Text = "(not connected)";
            this._projectLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _rowLabel
            // 
            this._rowLabel.AutoSize = true;
            this._rowLabel.Location = new System.Drawing.Point(339, 8);
            this._rowLabel.Name = "_rowLabel";
            this._rowLabel.Size = new System.Drawing.Size(32, 13);
            this._rowLabel.TabIndex = 8;
            this._rowLabel.Text = "Row:";
            // 
            // _insertButton
            // 
            this._insertButton.Location = new System.Drawing.Point(410, 4);
            this._insertButton.Name = "_insertButton";
            this._insertButton.Size = new System.Drawing.Size(75, 23);
            this._insertButton.TabIndex = 9;
            this._insertButton.Text = "&Insert Step";
            this._insertButton.UseVisualStyleBackColor = true;
            this._insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // _deleteButton
            // 
            this._deleteButton.Location = new System.Drawing.Point(491, 4);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(75, 23);
            this._deleteButton.TabIndex = 10;
            this._deleteButton.Text = "&Delete Step";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this._deleteButton);
            this.Controls.Add(this._insertButton);
            this.Controls.Add(this._rowLabel);
            this.Controls.Add(this._projectLabel);
            this.Controls.Add(this._testStepsGridView);
            this.Controls.Add(this._changeProjectButton);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._loadButton);
            this.Controls.Add(this._workItemTextBox);
            this.Controls.Add(this._workItemLabel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "Test Steps Editor";
            ((System.ComponentModel.ISupportInitialize)(this._testStepsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label _workItemLabel;
		private System.Windows.Forms.TextBox _workItemTextBox;
		private System.Windows.Forms.Button _loadButton;
		private System.Windows.Forms.Button _saveButton;
		private System.Windows.Forms.Button _changeProjectButton;
		private System.Windows.Forms.DataGridView _testStepsGridView;
		private System.Windows.Forms.Label _projectLabel;
        private System.Windows.Forms.Label _rowLabel;
        private System.Windows.Forms.Button _insertButton;
        private System.Windows.Forms.Button _deleteButton;
	}
}
