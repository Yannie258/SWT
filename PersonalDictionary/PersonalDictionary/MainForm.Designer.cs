namespace PersonalDictionary
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
            this.gbx_List = new System.Windows.Forms.GroupBox();
            this.lbItem = new System.Windows.Forms.ListBox();
            this.gbx_Details = new System.Windows.Forms.GroupBox();
            this.btnSpeaker = new System.Windows.Forms.Button();
            this.btnLookup = new System.Windows.Forms.Button();
            this.lblDetail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mean_lbl = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.txbDetail = new System.Windows.Forms.TextBox();
            this.txbMean = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spkmean = new System.Windows.Forms.Button();
            this.spkdetail = new System.Windows.Forms.Button();
            this.gbx_List.SuspendLayout();
            this.gbx_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_List
            // 
            this.gbx_List.Controls.Add(this.lbItem);
            this.gbx_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbx_List.Location = new System.Drawing.Point(0, 0);
            this.gbx_List.Name = "gbx_List";
            this.gbx_List.Size = new System.Drawing.Size(324, 690);
            this.gbx_List.TabIndex = 0;
            this.gbx_List.TabStop = false;
            this.gbx_List.Text = "German-Vietnamese";
            // 
            // lbItem
            // 
            this.lbItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItem.FormattingEnabled = true;
            this.lbItem.ItemHeight = 20;
            this.lbItem.Location = new System.Drawing.Point(3, 22);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(318, 665);
            this.lbItem.TabIndex = 0;
            this.lbItem.Click += new System.EventHandler(this.lbItem_Click);
            // 
            // gbx_Details
            // 
            this.gbx_Details.Controls.Add(this.spkdetail);
            this.gbx_Details.Controls.Add(this.spkmean);
            this.gbx_Details.Controls.Add(this.btnSpeaker);
            this.gbx_Details.Controls.Add(this.btnLookup);
            this.gbx_Details.Controls.Add(this.lblDetail);
            this.gbx_Details.Controls.Add(this.label2);
            this.gbx_Details.Controls.Add(this.Mean_lbl);
            this.gbx_Details.Controls.Add(this.txbSearch);
            this.gbx_Details.Controls.Add(this.txbDetail);
            this.gbx_Details.Controls.Add(this.txbMean);
            this.gbx_Details.Controls.Add(this.pictureBox1);
            this.gbx_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_Details.Location = new System.Drawing.Point(324, 0);
            this.gbx_Details.Name = "gbx_Details";
            this.gbx_Details.Size = new System.Drawing.Size(791, 690);
            this.gbx_Details.TabIndex = 1;
            this.gbx_Details.TabStop = false;
            this.gbx_Details.Text = "Search";
            // 
            // btnSpeaker
            // 
            this.btnSpeaker.Image = global::PersonalDictionary.Properties.Resources._38px_Speaker_Icon2;
            this.btnSpeaker.Location = new System.Drawing.Point(499, 79);
            this.btnSpeaker.Name = "btnSpeaker";
            this.btnSpeaker.Size = new System.Drawing.Size(47, 57);
            this.btnSpeaker.TabIndex = 5;
            this.btnSpeaker.UseVisualStyleBackColor = true;
            this.btnSpeaker.Click += new System.EventHandler(this.btnSpeaker_Click);
            // 
            // btnLookup
            // 
            this.btnLookup.BackColor = System.Drawing.Color.Cyan;
            this.btnLookup.ForeColor = System.Drawing.Color.Purple;
            this.btnLookup.Location = new System.Drawing.Point(580, 94);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(74, 30);
            this.btnLookup.TabIndex = 4;
            this.btnLookup.Text = "Search";
            this.btnLookup.UseVisualStyleBackColor = false;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.ForeColor = System.Drawing.Color.Blue;
            this.lblDetail.Location = new System.Drawing.Point(74, 247);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(77, 25);
            this.lblDetail.TabIndex = 3;
            this.lblDetail.Text = "Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(74, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meaning:";
            // 
            // Mean_lbl
            // 
            this.Mean_lbl.AutoSize = true;
            this.Mean_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mean_lbl.ForeColor = System.Drawing.Color.Blue;
            this.Mean_lbl.Location = new System.Drawing.Point(79, 164);
            this.Mean_lbl.Name = "Mean_lbl";
            this.Mean_lbl.Size = new System.Drawing.Size(94, 25);
            this.Mean_lbl.TabIndex = 3;
            this.Mean_lbl.Text = "Meaning:";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(194, 94);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(287, 30);
            this.txbSearch.TabIndex = 2;
            // 
            // txbDetail
            // 
            this.txbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDetail.Location = new System.Drawing.Point(79, 307);
            this.txbDetail.Multiline = true;
            this.txbDetail.Name = "txbDetail";
            this.txbDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDetail.Size = new System.Drawing.Size(402, 347);
            this.txbDetail.TabIndex = 2;
            // 
            // txbMean
            // 
            this.txbMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMean.Location = new System.Drawing.Point(194, 164);
            this.txbMean.Name = "txbMean";
            this.txbMean.Size = new System.Drawing.Size(287, 30);
            this.txbMean.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::PersonalDictionary.Properties.Resources.Search_5121;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(79, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // spkmean
            // 
            this.spkmean.Image = global::PersonalDictionary.Properties.Resources._38px_Speaker_Icon2;
            this.spkmean.Location = new System.Drawing.Point(499, 164);
            this.spkmean.Name = "spkmean";
            this.spkmean.Size = new System.Drawing.Size(47, 55);
            this.spkmean.TabIndex = 6;
            this.spkmean.UseVisualStyleBackColor = true;
            this.spkmean.Click += new System.EventHandler(this.spkmean_Click);
            // 
            // spkdetail
            // 
            this.spkdetail.Image = global::PersonalDictionary.Properties.Resources._38px_Speaker_Icon2;
            this.spkdetail.Location = new System.Drawing.Point(499, 307);
            this.spkdetail.Name = "spkdetail";
            this.spkdetail.Size = new System.Drawing.Size(47, 60);
            this.spkdetail.TabIndex = 7;
            this.spkdetail.UseVisualStyleBackColor = true;
            this.spkdetail.Click += new System.EventHandler(this.spkdetail_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 690);
            this.Controls.Add(this.gbx_Details);
            this.Controls.Add(this.gbx_List);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbx_List.ResumeLayout(false);
            this.gbx_Details.ResumeLayout(false);
            this.gbx_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_List;
        private System.Windows.Forms.GroupBox gbx_Details;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mean_lbl;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.TextBox txbDetail;
        private System.Windows.Forms.TextBox txbMean;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbItem;
        private System.Windows.Forms.Button btnSpeaker;
        private System.Windows.Forms.Button spkdetail;
        private System.Windows.Forms.Button spkmean;
    }
}