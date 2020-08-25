namespace PersonalDictionary
{
    partial class ManagementData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementData));
            this.gbManagement = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txb_Details = new System.Windows.Forms.TextBox();
            this.txb_Meaning = new System.Windows.Forms.TextBox();
            this.txb_German = new System.Windows.Forms.TextBox();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Details = new System.Windows.Forms.Label();
            this.lbl_Meaning = new System.Windows.Forms.Label();
            this.lbl_German = new System.Windows.Forms.Label();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.AvailableListWord = new System.Windows.Forms.GroupBox();
            this.gridItemData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.German = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VNShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VNLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbManagement.SuspendLayout();
            this.AvailableListWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManagement
            // 
            this.gbManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbManagement.Controls.Add(this.btnSearch);
            this.gbManagement.Controls.Add(this.btnBack);
            this.gbManagement.Controls.Add(this.btn_Edit);
            this.gbManagement.Controls.Add(this.btn_Delete);
            this.gbManagement.Controls.Add(this.btn_Update);
            this.gbManagement.Controls.Add(this.btn_Add);
            this.gbManagement.Controls.Add(this.txb_Details);
            this.gbManagement.Controls.Add(this.txb_Meaning);
            this.gbManagement.Controls.Add(this.txb_German);
            this.gbManagement.Controls.Add(this.txb_ID);
            this.gbManagement.Controls.Add(this.lbl_Details);
            this.gbManagement.Controls.Add(this.lbl_Meaning);
            this.gbManagement.Controls.Add(this.lbl_German);
            this.gbManagement.Controls.Add(this.ID_lbl);
            this.gbManagement.Location = new System.Drawing.Point(0, 0);
            this.gbManagement.Name = "gbManagement";
            this.gbManagement.Size = new System.Drawing.Size(1127, 618);
            this.gbManagement.TabIndex = 0;
            this.gbManagement.TabStop = false;
            this.gbManagement.Text = "Add New Word";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Image = global::PersonalDictionary.Properties.Resources.Search_512;
            this.btnSearch.Location = new System.Drawing.Point(666, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 44);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(979, 197);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 48);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(857, 125);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(85, 47);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(979, 53);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(92, 48);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(979, 128);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(92, 47);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(857, 53);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(85, 48);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txb_Details
            // 
            this.txb_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Details.Location = new System.Drawing.Point(242, 251);
            this.txb_Details.Multiline = true;
            this.txb_Details.Name = "txb_Details";
            this.txb_Details.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Details.Size = new System.Drawing.Size(858, 361);
            this.txb_Details.TabIndex = 3;
            // 
            // txb_Meaning
            // 
            this.txb_Meaning.Location = new System.Drawing.Point(242, 192);
            this.txb_Meaning.Name = "txb_Meaning";
            this.txb_Meaning.Size = new System.Drawing.Size(333, 26);
            this.txb_Meaning.TabIndex = 3;
            // 
            // txb_German
            // 
            this.txb_German.Location = new System.Drawing.Point(242, 128);
            this.txb_German.Name = "txb_German";
            this.txb_German.Size = new System.Drawing.Size(333, 26);
            this.txb_German.TabIndex = 3;
            // 
            // txb_ID
            // 
            this.txb_ID.Location = new System.Drawing.Point(242, 65);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(333, 26);
            this.txb_ID.TabIndex = 3;
            // 
            // lbl_Details
            // 
            this.lbl_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Details.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Details.Location = new System.Drawing.Point(70, 247);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(84, 29);
            this.lbl_Details.TabIndex = 2;
            this.lbl_Details.Text = "Details:";
            // 
            // lbl_Meaning
            // 
            this.lbl_Meaning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Meaning.AutoSize = true;
            this.lbl_Meaning.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Meaning.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Meaning.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Meaning.Location = new System.Drawing.Point(70, 188);
            this.lbl_Meaning.Name = "lbl_Meaning";
            this.lbl_Meaning.Size = new System.Drawing.Size(99, 29);
            this.lbl_Meaning.TabIndex = 2;
            this.lbl_Meaning.Text = "Meaning:";
            // 
            // lbl_German
            // 
            this.lbl_German.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_German.AutoSize = true;
            this.lbl_German.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_German.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_German.ForeColor = System.Drawing.Color.Blue;
            this.lbl_German.Location = new System.Drawing.Point(70, 125);
            this.lbl_German.Name = "lbl_German";
            this.lbl_German.Size = new System.Drawing.Size(95, 29);
            this.lbl_German.TabIndex = 2;
            this.lbl_German.Text = "German:";
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ID_lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lbl.ForeColor = System.Drawing.Color.Blue;
            this.ID_lbl.Location = new System.Drawing.Point(70, 65);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(39, 29);
            this.ID_lbl.TabIndex = 2;
            this.ID_lbl.Text = "ID:";
            // 
            // AvailableListWord
            // 
            this.AvailableListWord.Controls.Add(this.gridItemData);
            this.AvailableListWord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AvailableListWord.Location = new System.Drawing.Point(0, 624);
            this.AvailableListWord.Name = "AvailableListWord";
            this.AvailableListWord.Size = new System.Drawing.Size(1127, 320);
            this.AvailableListWord.TabIndex = 1;
            this.AvailableListWord.TabStop = false;
            this.AvailableListWord.Text = "Vocabulary List";
            // 
            // gridItemData
            // 
            this.gridItemData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItemData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItemData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.German,
            this.VNShort,
            this.VNLong});
            this.gridItemData.Location = new System.Drawing.Point(3, 22);
            this.gridItemData.Name = "gridItemData";
            this.gridItemData.RowHeadersWidth = 62;
            this.gridItemData.RowTemplate.Height = 28;
            this.gridItemData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItemData.Size = new System.Drawing.Size(1121, 295);
            this.gridItemData.TabIndex = 0;
            this.gridItemData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItemData_RowEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            // 
            // German
            // 
            this.German.DataPropertyName = "German";
            this.German.HeaderText = "German";
            this.German.MinimumWidth = 8;
            this.German.Name = "German";
            // 
            // VNShort
            // 
            this.VNShort.DataPropertyName = "German";
            this.VNShort.HeaderText = "VNShort";
            this.VNShort.MinimumWidth = 8;
            this.VNShort.Name = "VNShort";
            // 
            // VNLong
            // 
            this.VNLong.DataPropertyName = "VNLong";
            this.VNLong.HeaderText = "VNLong";
            this.VNLong.MinimumWidth = 8;
            this.VNLong.Name = "VNLong";
            // 
            // ManagementData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 944);
            this.Controls.Add(this.AvailableListWord);
            this.Controls.Add(this.gbManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagementData";
            this.Text = "Personal Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementData_FormClosing);
            this.gbManagement.ResumeLayout(false);
            this.gbManagement.PerformLayout();
            this.AvailableListWord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItemData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManagement;
        private System.Windows.Forms.GroupBox AvailableListWord;
        private System.Windows.Forms.DataGridView gridItemData;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txb_Details;
        private System.Windows.Forms.TextBox txb_Meaning;
        private System.Windows.Forms.TextBox txb_German;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.Label lbl_Meaning;
        private System.Windows.Forms.Label lbl_German;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn German;
        private System.Windows.Forms.DataGridViewTextBoxColumn VNShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn VNLong;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
    }
}