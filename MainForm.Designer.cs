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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DataBox = new System.Windows.Forms.ListBox();
            this.FiltersBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveFilterBtn = new System.Windows.Forms.Button();
            this.OperatorBox = new System.Windows.Forms.ComboBox();
            this.KeyBox = new System.Windows.Forms.ComboBox();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.AddFilterBtn = new System.Windows.Forms.Button();
            this.ApplyFilterBtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.EventBox = new System.Windows.Forms.ToolStripComboBox();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.SortDirectionBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
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
            this.splitContainer1.Size = new System.Drawing.Size(959, 414);
            this.splitContainer1.SplitterDistance = 472;
            this.splitContainer1.TabIndex = 0;
            // 
            // DataBox
            // 
            this.DataBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataBox.FormattingEnabled = true;
            this.DataBox.ItemHeight = 18;
            this.DataBox.Location = new System.Drawing.Point(0, 0);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(472, 414);
            this.DataBox.TabIndex = 0;
            this.DataBox.SelectedIndexChanged += new System.EventHandler(this.DataBox_SelectedIndexChanged);
            // 
            // FiltersBox
            // 
            this.FiltersBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltersBox.FormattingEnabled = true;
            this.FiltersBox.ItemHeight = 18;
            this.FiltersBox.Location = new System.Drawing.Point(0, 0);
            this.FiltersBox.Name = "FiltersBox";
            this.FiltersBox.Size = new System.Drawing.Size(483, 280);
            this.FiltersBox.TabIndex = 0;
            this.FiltersBox.SelectedIndexChanged += new System.EventHandler(this.FiltersBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SortDirectionBox);
            this.panel1.Controls.Add(this.SortBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RemoveFilterBtn);
            this.panel1.Controls.Add(this.OperatorBox);
            this.panel1.Controls.Add(this.KeyBox);
            this.panel1.Controls.Add(this.ValueBox);
            this.panel1.Controls.Add(this.AddFilterBtn);
            this.panel1.Controls.Add(this.ApplyFilterBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 134);
            this.panel1.TabIndex = 1;
            // 
            // SortBox
            // 
            this.SortBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortBox.FormattingEnabled = true;
            this.SortBox.Items.AddRange(new object[] {
            "test"});
            this.SortBox.Location = new System.Drawing.Point(185, 51);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(146, 26);
            this.SortBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sort by:";
            // 
            // RemoveFilterBtn
            // 
            this.RemoveFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RemoveFilterBtn.Location = new System.Drawing.Point(3, 51);
            this.RemoveFilterBtn.Name = "RemoveFilterBtn";
            this.RemoveFilterBtn.Size = new System.Drawing.Size(81, 28);
            this.RemoveFilterBtn.TabIndex = 7;
            this.RemoveFilterBtn.Text = "Remove";
            this.RemoveFilterBtn.UseVisualStyleBackColor = true;
            this.RemoveFilterBtn.Click += new System.EventHandler(this.RemoveFilterBtn_Click);
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
            this.ValueBox.Size = new System.Drawing.Size(199, 24);
            this.ValueBox.TabIndex = 4;
            this.ValueBox.TextChanged += new System.EventHandler(this.ValueBox_TextChanged);
            // 
            // AddFilterBtn
            // 
            this.AddFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddFilterBtn.Location = new System.Drawing.Point(3, 6);
            this.AddFilterBtn.Name = "AddFilterBtn";
            this.AddFilterBtn.Size = new System.Drawing.Size(81, 28);
            this.AddFilterBtn.TabIndex = 3;
            this.AddFilterBtn.Text = "Add";
            this.AddFilterBtn.UseVisualStyleBackColor = true;
            this.AddFilterBtn.Click += new System.EventHandler(this.AddFilterBtn_Click);
            // 
            // ApplyFilterBtn
            // 
            this.ApplyFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyFilterBtn.Location = new System.Drawing.Point(390, 94);
            this.ApplyFilterBtn.Name = "ApplyFilterBtn";
            this.ApplyFilterBtn.Size = new System.Drawing.Size(81, 28);
            this.ApplyFilterBtn.TabIndex = 2;
            this.ApplyFilterBtn.Text = "Apply";
            this.ApplyFilterBtn.UseVisualStyleBackColor = true;
            this.ApplyFilterBtn.Click += new System.EventHandler(this.ApplyFilterBtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.EventBox,
            this.RefreshBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(959, 29);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 26);
            this.toolStripLabel1.Text = "Event:";
            // 
            // EventBox
            // 
            this.EventBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventBox.Name = "EventBox";
            this.EventBox.Size = new System.Drawing.Size(121, 29);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(67, 26);
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // SortDirectionBox
            // 
            this.SortDirectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortDirectionBox.FormattingEnabled = true;
            this.SortDirectionBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.SortDirectionBox.Location = new System.Drawing.Point(338, 51);
            this.SortDirectionBox.Name = "SortDirectionBox";
            this.SortDirectionBox.Size = new System.Drawing.Size(132, 26);
            this.SortDirectionBox.TabIndex = 10;
            this.SortDirectionBox.Text = "Ascending";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 443);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scouting Data";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox DataBox;
        private System.Windows.Forms.ListBox FiltersBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ApplyFilterBtn;
        private System.Windows.Forms.Button AddFilterBtn;
        private System.Windows.Forms.ComboBox OperatorBox;
        private System.Windows.Forms.ComboBox KeyBox;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Button RemoveFilterBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox EventBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SortBox;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ComboBox SortDirectionBox;
    }
}