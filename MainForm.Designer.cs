namespace ScoutingAppData
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DataBox = new System.Windows.Forms.ListBox();
            this.FiltersBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.OperatorBox = new System.Windows.Forms.ComboBox();
            this.KeyBox = new System.Windows.Forms.ComboBox();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DataBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FiltersBox);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 385);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.TabIndex = 0;
            // 
            // DataBox
            // 
            this.DataBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataBox.FormattingEnabled = true;
            this.DataBox.ItemHeight = 18;
            this.DataBox.Location = new System.Drawing.Point(0, 0);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(394, 385);
            this.DataBox.TabIndex = 0;
            // 
            // FiltersBox
            // 
            this.FiltersBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltersBox.FormattingEnabled = true;
            this.FiltersBox.ItemHeight = 18;
            this.FiltersBox.Location = new System.Drawing.Point(0, 0);
            this.FiltersBox.Name = "FiltersBox";
            this.FiltersBox.Size = new System.Drawing.Size(402, 294);
            this.FiltersBox.TabIndex = 0;
            this.FiltersBox.SelectedIndexChanged += new System.EventHandler(this.FiltersBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RemoveBtn);
            this.panel1.Controls.Add(this.OperatorBox);
            this.panel1.Controls.Add(this.KeyBox);
            this.panel1.Controls.Add(this.ValueBox);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.ApplyBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 91);
            this.panel1.TabIndex = 1;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RemoveBtn.Location = new System.Drawing.Point(3, 51);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(81, 28);
            this.RemoveBtn.TabIndex = 7;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // OperatorBox
            // 
            this.OperatorBox.FormattingEnabled = true;
            this.OperatorBox.Items.AddRange(new object[] {
            "=",
            ">",
            "<"});
            this.OperatorBox.Location = new System.Drawing.Point(217, 7);
            this.OperatorBox.Name = "OperatorBox";
            this.OperatorBox.Size = new System.Drawing.Size(48, 26);
            this.OperatorBox.TabIndex = 6;
            this.OperatorBox.Text = "=";
            this.OperatorBox.SelectedIndexChanged += new System.EventHandler(this.OperatorBox_SelectedIndexChanged);
            // 
            // KeyBox
            // 
            this.KeyBox.FormattingEnabled = true;
            this.KeyBox.Items.AddRange(new object[] {
            "test"});
            this.KeyBox.Location = new System.Drawing.Point(90, 7);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(121, 26);
            this.KeyBox.TabIndex = 5;
            this.KeyBox.SelectedIndexChanged += new System.EventHandler(this.KeyBox_SelectedIndexChanged);
            this.KeyBox.TextUpdate += new System.EventHandler(this.KeyBox_TextUpdate);
            // 
            // ValueBox
            // 
            this.ValueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueBox.Location = new System.Drawing.Point(271, 8);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(118, 24);
            this.ValueBox.TabIndex = 4;
            this.ValueBox.TextChanged += new System.EventHandler(this.ValueBox_TextChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddBtn.Location = new System.Drawing.Point(3, 6);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(81, 28);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyBtn.Location = new System.Drawing.Point(309, 51);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(81, 28);
            this.ApplyBtn.TabIndex = 2;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Scouting Data";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox DataBox;
        private System.Windows.Forms.ListBox FiltersBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox OperatorBox;
        private System.Windows.Forms.ComboBox KeyBox;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Button RemoveBtn;
    }
}