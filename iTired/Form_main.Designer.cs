namespace iTired
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.groupBox_other = new System.Windows.Forms.GroupBox();
            this.label_start_cluster_num = new System.Windows.Forms.Label();
            this.textBox_start_cluster_num = new System.Windows.Forms.TextBox();
            this.label_file_size = new System.Windows.Forms.Label();
            this.textBox_file_byte_size = new System.Windows.Forms.TextBox();
            this.groupBox_file = new System.Windows.Forms.GroupBox();
            this.textBox_fileBody = new System.Windows.Forms.TextBox();
            this.label_filename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_file_ext = new System.Windows.Forms.TextBox();
            this.groupBox_dates = new System.Windows.Forms.GroupBox();
            this.label_created_date = new System.Windows.Forms.Label();
            this.textBox_created_date = new System.Windows.Forms.TextBox();
            this.label_created_time = new System.Windows.Forms.Label();
            this.textBox_created_time = new System.Windows.Forms.TextBox();
            this.label_modified_date = new System.Windows.Forms.Label();
            this.textBox_access_date = new System.Windows.Forms.TextBox();
            this.textBox_modified_date = new System.Windows.Forms.TextBox();
            this.label_accessed_date = new System.Windows.Forms.Label();
            this.label_modified_time = new System.Windows.Forms.Label();
            this.textBox_modified_time = new System.Windows.Forms.TextBox();
            this.groupBox_attributes = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox_readonly = new System.Windows.Forms.CheckBox();
            this.checkBox_hidden = new System.Windows.Forms.CheckBox();
            this.checkBox_system = new System.Windows.Forms.CheckBox();
            this.checkBox_volume_label = new System.Windows.Forms.CheckBox();
            this.checkBox_folder = new System.Windows.Forms.CheckBox();
            this.checkBox_archive = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox_data = new iTired.HexEditor.HexBox();
            this.groupBox_data.SuspendLayout();
            this.groupBox_info.SuspendLayout();
            this.groupBox_other.SuspendLayout();
            this.groupBox_file.SuspendLayout();
            this.groupBox_dates.SuspendLayout();
            this.groupBox_attributes.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_data
            // 
            this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_data.Controls.Add(this.richTextBox_data);
            this.groupBox_data.Location = new System.Drawing.Point(12, 25);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(500, 96);
            this.groupBox_data.TabIndex = 1;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "Byte Data";
            // 
            // groupBox_info
            // 
            this.groupBox_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_info.Controls.Add(this.groupBox_other);
            this.groupBox_info.Controls.Add(this.groupBox_file);
            this.groupBox_info.Controls.Add(this.groupBox_dates);
            this.groupBox_info.Controls.Add(this.groupBox_attributes);
            this.groupBox_info.Enabled = false;
            this.groupBox_info.Location = new System.Drawing.Point(12, 127);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(500, 252);
            this.groupBox_info.TabIndex = 2;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Information";
            // 
            // groupBox_other
            // 
            this.groupBox_other.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_other.Controls.Add(this.label_start_cluster_num);
            this.groupBox_other.Controls.Add(this.textBox_start_cluster_num);
            this.groupBox_other.Controls.Add(this.label_file_size);
            this.groupBox_other.Controls.Add(this.textBox_file_byte_size);
            this.groupBox_other.Location = new System.Drawing.Point(315, 16);
            this.groupBox_other.Name = "groupBox_other";
            this.groupBox_other.Size = new System.Drawing.Size(172, 227);
            this.groupBox_other.TabIndex = 20;
            this.groupBox_other.TabStop = false;
            this.groupBox_other.Text = "Other";
            // 
            // label_start_cluster_num
            // 
            this.label_start_cluster_num.AutoSize = true;
            this.label_start_cluster_num.Location = new System.Drawing.Point(9, 19);
            this.label_start_cluster_num.Name = "label_start_cluster_num";
            this.label_start_cluster_num.Size = new System.Drawing.Size(76, 13);
            this.label_start_cluster_num.TabIndex = 15;
            this.label_start_cluster_num.Text = "Start cluster #:";
            // 
            // textBox_start_cluster_num
            // 
            this.textBox_start_cluster_num.Location = new System.Drawing.Point(90, 16);
            this.textBox_start_cluster_num.Name = "textBox_start_cluster_num";
            this.textBox_start_cluster_num.ReadOnly = true;
            this.textBox_start_cluster_num.Size = new System.Drawing.Size(76, 20);
            this.textBox_start_cluster_num.TabIndex = 16;
            // 
            // label_file_size
            // 
            this.label_file_size.AutoSize = true;
            this.label_file_size.Location = new System.Drawing.Point(9, 46);
            this.label_file_size.Name = "label_file_size";
            this.label_file_size.Size = new System.Drawing.Size(70, 13);
            this.label_file_size.TabIndex = 17;
            this.label_file_size.Text = "File byte size:";
            // 
            // textBox_file_byte_size
            // 
            this.textBox_file_byte_size.Location = new System.Drawing.Point(90, 43);
            this.textBox_file_byte_size.Name = "textBox_file_byte_size";
            this.textBox_file_byte_size.ReadOnly = true;
            this.textBox_file_byte_size.Size = new System.Drawing.Size(76, 20);
            this.textBox_file_byte_size.TabIndex = 18;
            // 
            // groupBox_file
            // 
            this.groupBox_file.Controls.Add(this.textBox_fileBody);
            this.groupBox_file.Controls.Add(this.label_filename);
            this.groupBox_file.Controls.Add(this.label1);
            this.groupBox_file.Controls.Add(this.textBox_file_ext);
            this.groupBox_file.Location = new System.Drawing.Point(12, 16);
            this.groupBox_file.Name = "groupBox_file";
            this.groupBox_file.Size = new System.Drawing.Size(174, 74);
            this.groupBox_file.TabIndex = 19;
            this.groupBox_file.TabStop = false;
            this.groupBox_file.Text = "File name";
            // 
            // textBox_fileBody
            // 
            this.textBox_fileBody.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fileBody.Location = new System.Drawing.Point(94, 19);
            this.textBox_fileBody.Name = "textBox_fileBody";
            this.textBox_fileBody.ReadOnly = true;
            this.textBox_fileBody.Size = new System.Drawing.Size(70, 20);
            this.textBox_fileBody.TabIndex = 1;
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.Location = new System.Drawing.Point(13, 22);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(53, 13);
            this.label_filename.TabIndex = 0;
            this.label_filename.Text = "File Body:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Extension:";
            // 
            // textBox_file_ext
            // 
            this.textBox_file_ext.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_file_ext.Location = new System.Drawing.Point(94, 45);
            this.textBox_file_ext.Name = "textBox_file_ext";
            this.textBox_file_ext.ReadOnly = true;
            this.textBox_file_ext.Size = new System.Drawing.Size(70, 20);
            this.textBox_file_ext.TabIndex = 3;
            // 
            // groupBox_dates
            // 
            this.groupBox_dates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_dates.Controls.Add(this.label_created_date);
            this.groupBox_dates.Controls.Add(this.textBox_created_date);
            this.groupBox_dates.Controls.Add(this.label_created_time);
            this.groupBox_dates.Controls.Add(this.textBox_created_time);
            this.groupBox_dates.Controls.Add(this.label_modified_date);
            this.groupBox_dates.Controls.Add(this.textBox_access_date);
            this.groupBox_dates.Controls.Add(this.textBox_modified_date);
            this.groupBox_dates.Controls.Add(this.label_accessed_date);
            this.groupBox_dates.Controls.Add(this.label_modified_time);
            this.groupBox_dates.Controls.Add(this.textBox_modified_time);
            this.groupBox_dates.Location = new System.Drawing.Point(12, 95);
            this.groupBox_dates.Name = "groupBox_dates";
            this.groupBox_dates.Size = new System.Drawing.Size(174, 148);
            this.groupBox_dates.TabIndex = 19;
            this.groupBox_dates.TabStop = false;
            this.groupBox_dates.Text = "Dates";
            // 
            // label_created_date
            // 
            this.label_created_date.AutoSize = true;
            this.label_created_date.Location = new System.Drawing.Point(6, 16);
            this.label_created_date.Name = "label_created_date";
            this.label_created_date.Size = new System.Drawing.Size(71, 13);
            this.label_created_date.TabIndex = 5;
            this.label_created_date.Text = "Created date:";
            // 
            // textBox_created_date
            // 
            this.textBox_created_date.Location = new System.Drawing.Point(87, 13);
            this.textBox_created_date.Name = "textBox_created_date";
            this.textBox_created_date.ReadOnly = true;
            this.textBox_created_date.Size = new System.Drawing.Size(77, 20);
            this.textBox_created_date.TabIndex = 6;
            // 
            // label_created_time
            // 
            this.label_created_time.AutoSize = true;
            this.label_created_time.Location = new System.Drawing.Point(6, 42);
            this.label_created_time.Name = "label_created_time";
            this.label_created_time.Size = new System.Drawing.Size(69, 13);
            this.label_created_time.TabIndex = 7;
            this.label_created_time.Text = "Created time:";
            // 
            // textBox_created_time
            // 
            this.textBox_created_time.Location = new System.Drawing.Point(87, 39);
            this.textBox_created_time.Name = "textBox_created_time";
            this.textBox_created_time.ReadOnly = true;
            this.textBox_created_time.Size = new System.Drawing.Size(77, 20);
            this.textBox_created_time.TabIndex = 8;
            // 
            // label_modified_date
            // 
            this.label_modified_date.AutoSize = true;
            this.label_modified_date.Location = new System.Drawing.Point(6, 69);
            this.label_modified_date.Name = "label_modified_date";
            this.label_modified_date.Size = new System.Drawing.Size(74, 13);
            this.label_modified_date.TabIndex = 9;
            this.label_modified_date.Text = "Modified date:";
            // 
            // textBox_access_date
            // 
            this.textBox_access_date.Location = new System.Drawing.Point(87, 119);
            this.textBox_access_date.Name = "textBox_access_date";
            this.textBox_access_date.ReadOnly = true;
            this.textBox_access_date.Size = new System.Drawing.Size(77, 20);
            this.textBox_access_date.TabIndex = 14;
            // 
            // textBox_modified_date
            // 
            this.textBox_modified_date.Location = new System.Drawing.Point(87, 66);
            this.textBox_modified_date.Name = "textBox_modified_date";
            this.textBox_modified_date.ReadOnly = true;
            this.textBox_modified_date.Size = new System.Drawing.Size(77, 20);
            this.textBox_modified_date.TabIndex = 10;
            // 
            // label_accessed_date
            // 
            this.label_accessed_date.AutoSize = true;
            this.label_accessed_date.Location = new System.Drawing.Point(6, 122);
            this.label_accessed_date.Name = "label_accessed_date";
            this.label_accessed_date.Size = new System.Drawing.Size(69, 13);
            this.label_accessed_date.TabIndex = 13;
            this.label_accessed_date.Text = "Access date:";
            // 
            // label_modified_time
            // 
            this.label_modified_time.AutoSize = true;
            this.label_modified_time.Location = new System.Drawing.Point(6, 96);
            this.label_modified_time.Name = "label_modified_time";
            this.label_modified_time.Size = new System.Drawing.Size(72, 13);
            this.label_modified_time.TabIndex = 11;
            this.label_modified_time.Text = "Modified time:";
            // 
            // textBox_modified_time
            // 
            this.textBox_modified_time.Location = new System.Drawing.Point(87, 93);
            this.textBox_modified_time.Name = "textBox_modified_time";
            this.textBox_modified_time.ReadOnly = true;
            this.textBox_modified_time.Size = new System.Drawing.Size(77, 20);
            this.textBox_modified_time.TabIndex = 12;
            // 
            // groupBox_attributes
            // 
            this.groupBox_attributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_attributes.Controls.Add(this.flowLayoutPanel1);
            this.groupBox_attributes.Location = new System.Drawing.Point(192, 16);
            this.groupBox_attributes.Name = "groupBox_attributes";
            this.groupBox_attributes.Size = new System.Drawing.Size(117, 227);
            this.groupBox_attributes.TabIndex = 4;
            this.groupBox_attributes.TabStop = false;
            this.groupBox_attributes.Text = "Attributes";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.checkBox_readonly);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_hidden);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_system);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_volume_label);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_folder);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_archive);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 202);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // checkBox_readonly
            // 
            this.checkBox_readonly.AutoCheck = false;
            this.checkBox_readonly.AutoSize = true;
            this.checkBox_readonly.Location = new System.Drawing.Point(3, 3);
            this.checkBox_readonly.Name = "checkBox_readonly";
            this.checkBox_readonly.Size = new System.Drawing.Size(76, 17);
            this.checkBox_readonly.TabIndex = 0;
            this.checkBox_readonly.Text = "Read Only";
            this.checkBox_readonly.UseVisualStyleBackColor = true;
            // 
            // checkBox_hidden
            // 
            this.checkBox_hidden.AutoCheck = false;
            this.checkBox_hidden.AutoSize = true;
            this.checkBox_hidden.Location = new System.Drawing.Point(3, 26);
            this.checkBox_hidden.Name = "checkBox_hidden";
            this.checkBox_hidden.Size = new System.Drawing.Size(60, 17);
            this.checkBox_hidden.TabIndex = 1;
            this.checkBox_hidden.Text = "Hidden";
            this.checkBox_hidden.UseVisualStyleBackColor = true;
            // 
            // checkBox_system
            // 
            this.checkBox_system.AutoCheck = false;
            this.checkBox_system.AutoSize = true;
            this.checkBox_system.Location = new System.Drawing.Point(3, 49);
            this.checkBox_system.Name = "checkBox_system";
            this.checkBox_system.Size = new System.Drawing.Size(60, 17);
            this.checkBox_system.TabIndex = 2;
            this.checkBox_system.Text = "System";
            this.checkBox_system.UseVisualStyleBackColor = true;
            // 
            // checkBox_volume_label
            // 
            this.checkBox_volume_label.AutoCheck = false;
            this.checkBox_volume_label.AutoSize = true;
            this.checkBox_volume_label.Location = new System.Drawing.Point(3, 72);
            this.checkBox_volume_label.Name = "checkBox_volume_label";
            this.checkBox_volume_label.Size = new System.Drawing.Size(86, 17);
            this.checkBox_volume_label.TabIndex = 3;
            this.checkBox_volume_label.Text = "Volume label";
            this.checkBox_volume_label.UseVisualStyleBackColor = true;
            // 
            // checkBox_folder
            // 
            this.checkBox_folder.AutoCheck = false;
            this.checkBox_folder.AutoSize = true;
            this.checkBox_folder.Location = new System.Drawing.Point(3, 95);
            this.checkBox_folder.Name = "checkBox_folder";
            this.checkBox_folder.Size = new System.Drawing.Size(55, 17);
            this.checkBox_folder.TabIndex = 4;
            this.checkBox_folder.Text = "Folder";
            this.checkBox_folder.UseVisualStyleBackColor = true;
            // 
            // checkBox_archive
            // 
            this.checkBox_archive.AutoCheck = false;
            this.checkBox_archive.AutoSize = true;
            this.checkBox_archive.Location = new System.Drawing.Point(3, 118);
            this.checkBox_archive.Name = "checkBox_archive";
            this.checkBox_archive.Size = new System.Drawing.Size(62, 17);
            this.checkBox_archive.TabIndex = 5;
            this.checkBox_archive.Text = "Archive";
            this.checkBox_archive.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.aboutToolStripMenuItem.Text = "Other";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // richTextBox_data
            // 
            this.richTextBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_data.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.richTextBox_data.LineInfoVisible = true;
            this.richTextBox_data.Location = new System.Drawing.Point(12, 20);
            this.richTextBox_data.Name = "richTextBox_data";
            this.richTextBox_data.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.richTextBox_data.Size = new System.Drawing.Size(482, 70);
            this.richTextBox_data.TabIndex = 2;
            this.richTextBox_data.InsertActiveChanged += new System.EventHandler(this.richTextBox_data_InsertActiveChanged);
            this.richTextBox_data.ByteProviderChanged += new System.EventHandler(this.richTextBox_data_ByteProviderChanged);
            this.richTextBox_data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_data_KeyDown);
            this.richTextBox_data.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox_data_KeyUp);
            this.richTextBox_data.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox_data_MouseUp);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 391);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.groupBox_data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(530, 430);
            this.Name = "Form_main";
            this.Text = "iTired";
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_other.ResumeLayout(false);
            this.groupBox_other.PerformLayout();
            this.groupBox_file.ResumeLayout(false);
            this.groupBox_file.PerformLayout();
            this.groupBox_dates.ResumeLayout(false);
            this.groupBox_dates.PerformLayout();
            this.groupBox_attributes.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.GroupBox groupBox_attributes;
        private System.Windows.Forms.CheckBox checkBox_archive;
        private System.Windows.Forms.CheckBox checkBox_folder;
        private System.Windows.Forms.CheckBox checkBox_volume_label;
        private System.Windows.Forms.CheckBox checkBox_system;
        private System.Windows.Forms.CheckBox checkBox_hidden;
        private System.Windows.Forms.CheckBox checkBox_readonly;
        private System.Windows.Forms.TextBox textBox_file_ext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fileBody;
        private System.Windows.Forms.Label label_filename;
        private System.Windows.Forms.TextBox textBox_modified_date;
        private System.Windows.Forms.Label label_modified_date;
        private System.Windows.Forms.TextBox textBox_created_time;
        private System.Windows.Forms.Label label_created_time;
        private System.Windows.Forms.TextBox textBox_created_date;
        private System.Windows.Forms.Label label_created_date;
        private System.Windows.Forms.TextBox textBox_file_byte_size;
        private System.Windows.Forms.Label label_file_size;
        private System.Windows.Forms.TextBox textBox_start_cluster_num;
        private System.Windows.Forms.Label label_start_cluster_num;
        private System.Windows.Forms.TextBox textBox_access_date;
        private System.Windows.Forms.Label label_accessed_date;
        private System.Windows.Forms.TextBox textBox_modified_time;
        private System.Windows.Forms.Label label_modified_time;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox_file;
        private System.Windows.Forms.GroupBox groupBox_dates;
        private System.Windows.Forms.GroupBox groupBox_other;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private HexEditor.HexBox richTextBox_data;
    }
}

