namespace LinkMaker.UI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.PackageFile = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.VariablesGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VariablesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LinksGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LinksDataGridView = new System.Windows.Forms.DataGridView();
            this.linkPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PackageFileGroupBox = new System.Windows.Forms.GroupBox();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.PackageFileChooseButton = new System.Windows.Forms.Button();
            this.PackageFileTextBox = new System.Windows.Forms.TextBox();
            this.PackageFileMakeLinksButton = new System.Windows.Forms.Button();
            this.SingleLink = new System.Windows.Forms.TabPage();
            this.SingleLinkMakeLinkButton = new System.Windows.Forms.Button();
            this.LinkGroupBox = new System.Windows.Forms.GroupBox();
            this.LinkChooseButton = new System.Windows.Forms.Button();
            this.LinkTextBox = new System.Windows.Forms.TextBox();
            this.TargetGroupBox = new System.Windows.Forms.GroupBox();
            this.TargetChooseButton = new System.Windows.Forms.Button();
            this.TargetTextBox = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.PackageFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.VariablesGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariablesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).BeginInit();
            this.LinksGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).BeginInit();
            this.PackageFileGroupBox.SuspendLayout();
            this.SingleLink.SuspendLayout();
            this.LinkGroupBox.SuspendLayout();
            this.TargetGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.PackageFile);
            this.TabControl.Controls.Add(this.SingleLink);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.ItemSize = new System.Drawing.Size(58, 22);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(784, 562);
            this.TabControl.TabIndex = 0;
            // 
            // PackageFile
            // 
            this.PackageFile.Controls.Add(this.splitContainer1);
            this.PackageFile.Controls.Add(this.PackageFileGroupBox);
            this.PackageFile.Controls.Add(this.PackageFileMakeLinksButton);
            this.PackageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageFile.Location = new System.Drawing.Point(4, 26);
            this.PackageFile.Name = "PackageFile";
            this.PackageFile.Padding = new System.Windows.Forms.Padding(3);
            this.PackageFile.Size = new System.Drawing.Size(776, 532);
            this.PackageFile.TabIndex = 1;
            this.PackageFile.Text = "Generate From Package File";
            this.PackageFile.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(7, 88);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.VariablesGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LinksGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(763, 407);
            this.splitContainer1.SplitterDistance = 133;
            this.splitContainer1.TabIndex = 10;
            // 
            // VariablesGroupBox
            // 
            this.VariablesGroupBox.Controls.Add(this.panel1);
            this.VariablesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariablesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VariablesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.VariablesGroupBox.Name = "VariablesGroupBox";
            this.VariablesGroupBox.Size = new System.Drawing.Size(763, 133);
            this.VariablesGroupBox.TabIndex = 8;
            this.VariablesGroupBox.TabStop = false;
            this.VariablesGroupBox.Text = "Variables";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VariablesDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 113);
            this.panel1.TabIndex = 1;
            // 
            // VariablesDataGridView
            // 
            this.VariablesDataGridView.AllowUserToAddRows = false;
            this.VariablesDataGridView.AllowUserToDeleteRows = false;
            this.VariablesDataGridView.AutoGenerateColumns = false;
            this.VariablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VariablesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.VariablesDataGridView.DataSource = this.variableBindingSource;
            this.VariablesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariablesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.VariablesDataGridView.Name = "VariablesDataGridView";
            this.VariablesDataGridView.RowHeadersVisible = false;
            this.VariablesDataGridView.Size = new System.Drawing.Size(757, 113);
            this.VariablesDataGridView.TabIndex = 0;
            this.VariablesDataGridView.CurrentCellChanged += new System.EventHandler(this.VariablesDataGridView_CurrentCellChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 33F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.FillWeight = 50.76142F;
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // variableBindingSource
            // 
            this.variableBindingSource.DataSource = typeof(LinkMaker.XML.Variable);
            // 
            // LinksGroupBox
            // 
            this.LinksGroupBox.Controls.Add(this.panel2);
            this.LinksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinksGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinksGroupBox.Location = new System.Drawing.Point(0, 0);
            this.LinksGroupBox.Name = "LinksGroupBox";
            this.LinksGroupBox.Size = new System.Drawing.Size(763, 270);
            this.LinksGroupBox.TabIndex = 9;
            this.LinksGroupBox.TabStop = false;
            this.LinksGroupBox.Text = "Links";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LinksDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 250);
            this.panel2.TabIndex = 1;
            // 
            // LinksDataGridView
            // 
            this.LinksDataGridView.AllowUserToAddRows = false;
            this.LinksDataGridView.AllowUserToDeleteRows = false;
            this.LinksDataGridView.AllowUserToResizeRows = false;
            this.LinksDataGridView.AutoGenerateColumns = false;
            this.LinksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LinksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkPathDataGridViewTextBoxColumn,
            this.linkTypeDataGridViewTextBoxColumn,
            this.targetPathDataGridViewTextBoxColumn});
            this.LinksDataGridView.DataSource = this.linkBindingSource;
            this.LinksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinksDataGridView.Location = new System.Drawing.Point(0, 0);
            this.LinksDataGridView.Name = "LinksDataGridView";
            this.LinksDataGridView.ReadOnly = true;
            this.LinksDataGridView.RowHeadersVisible = false;
            this.LinksDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LinksDataGridView.Size = new System.Drawing.Size(757, 250);
            this.LinksDataGridView.TabIndex = 0;
            this.LinksDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.LinksDataGridView_DataError);
            // 
            // linkPathDataGridViewTextBoxColumn
            // 
            this.linkPathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.linkPathDataGridViewTextBoxColumn.DataPropertyName = "LinkPath";
            this.linkPathDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkPathDataGridViewTextBoxColumn.Name = "linkPathDataGridViewTextBoxColumn";
            this.linkPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkTypeDataGridViewTextBoxColumn
            // 
            this.linkTypeDataGridViewTextBoxColumn.DataPropertyName = "LinkType";
            this.linkTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.linkTypeDataGridViewTextBoxColumn.Name = "linkTypeDataGridViewTextBoxColumn";
            this.linkTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // targetPathDataGridViewTextBoxColumn
            // 
            this.targetPathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.targetPathDataGridViewTextBoxColumn.DataPropertyName = "TargetPath";
            this.targetPathDataGridViewTextBoxColumn.HeaderText = "Target";
            this.targetPathDataGridViewTextBoxColumn.Name = "targetPathDataGridViewTextBoxColumn";
            this.targetPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkBindingSource
            // 
            this.linkBindingSource.DataSource = typeof(LinkMaker.XML.Link);
            // 
            // PackageFileGroupBox
            // 
            this.PackageFileGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PackageFileGroupBox.Controls.Add(this.ReloadButton);
            this.PackageFileGroupBox.Controls.Add(this.PackageFileChooseButton);
            this.PackageFileGroupBox.Controls.Add(this.PackageFileTextBox);
            this.PackageFileGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageFileGroupBox.Location = new System.Drawing.Point(6, 6);
            this.PackageFileGroupBox.Name = "PackageFileGroupBox";
            this.PackageFileGroupBox.Size = new System.Drawing.Size(764, 75);
            this.PackageFileGroupBox.TabIndex = 7;
            this.PackageFileGroupBox.TabStop = false;
            this.PackageFileGroupBox.Text = "Package File Location";
            // 
            // ReloadButton
            // 
            this.ReloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.Image = ((System.Drawing.Image)(resources.GetObject("ReloadButton.Image")));
            this.ReloadButton.Location = new System.Drawing.Point(112, 46);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(23, 23);
            this.ReloadButton.TabIndex = 4;
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // PackageFileChooseButton
            // 
            this.PackageFileChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageFileChooseButton.Location = new System.Drawing.Point(6, 46);
            this.PackageFileChooseButton.Name = "PackageFileChooseButton";
            this.PackageFileChooseButton.Size = new System.Drawing.Size(100, 23);
            this.PackageFileChooseButton.TabIndex = 3;
            this.PackageFileChooseButton.Text = "Choose...";
            this.PackageFileChooseButton.UseVisualStyleBackColor = true;
            this.PackageFileChooseButton.Click += new System.EventHandler(this.PackageFileChooseButton_Click);
            // 
            // PackageFileTextBox
            // 
            this.PackageFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PackageFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageFileTextBox.Location = new System.Drawing.Point(6, 20);
            this.PackageFileTextBox.Name = "PackageFileTextBox";
            this.PackageFileTextBox.ReadOnly = true;
            this.PackageFileTextBox.Size = new System.Drawing.Size(752, 20);
            this.PackageFileTextBox.TabIndex = 2;
            // 
            // PackageFileMakeLinksButton
            // 
            this.PackageFileMakeLinksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PackageFileMakeLinksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageFileMakeLinksButton.Location = new System.Drawing.Point(670, 501);
            this.PackageFileMakeLinksButton.Name = "PackageFileMakeLinksButton";
            this.PackageFileMakeLinksButton.Size = new System.Drawing.Size(100, 23);
            this.PackageFileMakeLinksButton.TabIndex = 6;
            this.PackageFileMakeLinksButton.Text = "Make Links";
            this.PackageFileMakeLinksButton.UseVisualStyleBackColor = true;
            this.PackageFileMakeLinksButton.Click += new System.EventHandler(this.PackageFileMakeLinksButton_Click);
            // 
            // SingleLink
            // 
            this.SingleLink.Controls.Add(this.SingleLinkMakeLinkButton);
            this.SingleLink.Controls.Add(this.LinkGroupBox);
            this.SingleLink.Controls.Add(this.TargetGroupBox);
            this.SingleLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleLink.Location = new System.Drawing.Point(4, 26);
            this.SingleLink.Name = "SingleLink";
            this.SingleLink.Padding = new System.Windows.Forms.Padding(3);
            this.SingleLink.Size = new System.Drawing.Size(776, 532);
            this.SingleLink.TabIndex = 0;
            this.SingleLink.Text = "Make Single Link";
            this.SingleLink.UseVisualStyleBackColor = true;
            // 
            // SingleLinkMakeLinkButton
            // 
            this.SingleLinkMakeLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleLinkMakeLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleLinkMakeLinkButton.Location = new System.Drawing.Point(668, 168);
            this.SingleLinkMakeLinkButton.Name = "SingleLinkMakeLinkButton";
            this.SingleLinkMakeLinkButton.Size = new System.Drawing.Size(100, 23);
            this.SingleLinkMakeLinkButton.TabIndex = 2;
            this.SingleLinkMakeLinkButton.Text = "Make Link";
            this.SingleLinkMakeLinkButton.UseVisualStyleBackColor = true;
            this.SingleLinkMakeLinkButton.Click += new System.EventHandler(this.SingleLinkMakeLinkButton_Click);
            // 
            // LinkGroupBox
            // 
            this.LinkGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkGroupBox.Controls.Add(this.LinkChooseButton);
            this.LinkGroupBox.Controls.Add(this.LinkTextBox);
            this.LinkGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkGroupBox.Location = new System.Drawing.Point(6, 87);
            this.LinkGroupBox.Name = "LinkGroupBox";
            this.LinkGroupBox.Size = new System.Drawing.Size(762, 75);
            this.LinkGroupBox.TabIndex = 1;
            this.LinkGroupBox.TabStop = false;
            this.LinkGroupBox.Text = "Link to Create";
            // 
            // LinkChooseButton
            // 
            this.LinkChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkChooseButton.Location = new System.Drawing.Point(6, 47);
            this.LinkChooseButton.Name = "LinkChooseButton";
            this.LinkChooseButton.Size = new System.Drawing.Size(75, 23);
            this.LinkChooseButton.TabIndex = 3;
            this.LinkChooseButton.Text = "Choose...";
            this.LinkChooseButton.UseVisualStyleBackColor = true;
            this.LinkChooseButton.Click += new System.EventHandler(this.JunctionChooseButton_Click);
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkTextBox.Location = new System.Drawing.Point(6, 20);
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.ReadOnly = true;
            this.LinkTextBox.Size = new System.Drawing.Size(750, 20);
            this.LinkTextBox.TabIndex = 2;
            // 
            // TargetGroupBox
            // 
            this.TargetGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetGroupBox.Controls.Add(this.TargetChooseButton);
            this.TargetGroupBox.Controls.Add(this.TargetTextBox);
            this.TargetGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetGroupBox.Location = new System.Drawing.Point(6, 6);
            this.TargetGroupBox.Name = "TargetGroupBox";
            this.TargetGroupBox.Size = new System.Drawing.Size(762, 75);
            this.TargetGroupBox.TabIndex = 0;
            this.TargetGroupBox.TabStop = false;
            this.TargetGroupBox.Text = "Existing Target";
            // 
            // TargetChooseButton
            // 
            this.TargetChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetChooseButton.Location = new System.Drawing.Point(6, 46);
            this.TargetChooseButton.Name = "TargetChooseButton";
            this.TargetChooseButton.Size = new System.Drawing.Size(75, 23);
            this.TargetChooseButton.TabIndex = 1;
            this.TargetChooseButton.Text = "Choose...";
            this.TargetChooseButton.UseVisualStyleBackColor = true;
            this.TargetChooseButton.Click += new System.EventHandler(this.TargetChooseButton_Click);
            // 
            // TargetTextBox
            // 
            this.TargetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetTextBox.Location = new System.Drawing.Point(6, 20);
            this.TargetTextBox.Name = "TargetTextBox";
            this.TargetTextBox.ReadOnly = true;
            this.TargetTextBox.Size = new System.Drawing.Size(750, 20);
            this.TargetTextBox.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "LinkMaker";
            this.TabControl.ResumeLayout(false);
            this.PackageFile.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.VariablesGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VariablesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).EndInit();
            this.LinksGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LinksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).EndInit();
            this.PackageFileGroupBox.ResumeLayout(false);
            this.PackageFileGroupBox.PerformLayout();
            this.SingleLink.ResumeLayout(false);
            this.LinkGroupBox.ResumeLayout(false);
            this.LinkGroupBox.PerformLayout();
            this.TargetGroupBox.ResumeLayout(false);
            this.TargetGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SingleLink;
        private System.Windows.Forms.TabPage PackageFile;
        private System.Windows.Forms.GroupBox LinkGroupBox;
        private System.Windows.Forms.GroupBox TargetGroupBox;
        private System.Windows.Forms.Button SingleLinkMakeLinkButton;
        private System.Windows.Forms.Button LinkChooseButton;
        private System.Windows.Forms.TextBox LinkTextBox;
        private System.Windows.Forms.Button TargetChooseButton;
        private System.Windows.Forms.TextBox TargetTextBox;
        private System.Windows.Forms.Button PackageFileChooseButton;
        private System.Windows.Forms.TextBox PackageFileTextBox;
        private System.Windows.Forms.Button PackageFileMakeLinksButton;
        private System.Windows.Forms.GroupBox PackageFileGroupBox;
        private System.Windows.Forms.GroupBox LinksGroupBox;
        private System.Windows.Forms.DataGridView LinksDataGridView;
        private System.Windows.Forms.GroupBox VariablesGroupBox;
        private System.Windows.Forms.DataGridView VariablesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource linkBindingSource;
        private System.Windows.Forms.BindingSource variableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

