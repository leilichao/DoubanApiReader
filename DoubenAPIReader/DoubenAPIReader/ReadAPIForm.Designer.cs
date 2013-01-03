namespace DoubenAPIReader
{
    partial class ReadAPIForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadAPIForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTbSummery = new System.Windows.Forms.RichTextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.labelBookPrice = new System.Windows.Forms.Label();
            this.labelBookPages = new System.Windows.Forms.Label();
            this.labelBookBinding = new System.Windows.Forms.Label();
            this.labelBookPublishDate = new System.Windows.Forms.Label();
            this.labelBookPublisher = new System.Windows.Forms.Label();
            this.labelBookTranslator = new System.Windows.Forms.Label();
            this.labelBookAuthor = new System.Windows.Forms.Label();
            this.labelBookID = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelSummery = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelBinding = new System.Windows.Forms.Label();
            this.labelPubTime = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelTrans = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(339, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(150, 38);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(182, 21);
            this.tbSearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.AllowUserToResizeColumns = false;
            this.dgvBookInfo.AllowUserToResizeRows = false;
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookInfo.Location = new System.Drawing.Point(0, 78);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.RowHeadersVisible = false;
            this.dgvBookInfo.RowTemplate.Height = 23;
            this.dgvBookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookInfo.Size = new System.Drawing.Size(560, 417);
            this.dgvBookInfo.TabIndex = 1;
            this.dgvBookInfo.Visible = false;
            this.dgvBookInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookInfo_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Index";
            this.Column1.FillWeight = 76.14214F;
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Title";
            this.Column2.FillWeight = 104.7716F;
            this.Column2.HeaderText = "书名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Author";
            this.Column3.FillWeight = 104.7716F;
            this.Column3.HeaderText = "作者";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Url";
            this.Column4.FillWeight = 104.7716F;
            this.Column4.HeaderText = "图书API";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Pages";
            this.Column5.FillWeight = 104.7716F;
            this.Column5.HeaderText = "页数";
            this.Column5.Name = "Column5";
            this.Column5.Width = 54;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Price";
            this.Column6.FillWeight = 104.7716F;
            this.Column6.HeaderText = "价格";
            this.Column6.Name = "Column6";
            this.Column6.Width = 54;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTbSummery);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.labelBookPrice);
            this.panel1.Controls.Add(this.labelBookPages);
            this.panel1.Controls.Add(this.labelBookBinding);
            this.panel1.Controls.Add(this.labelBookPublishDate);
            this.panel1.Controls.Add(this.labelBookPublisher);
            this.panel1.Controls.Add(this.labelBookTranslator);
            this.panel1.Controls.Add(this.labelBookAuthor);
            this.panel1.Controls.Add(this.labelBookID);
            this.panel1.Controls.Add(this.labelBookName);
            this.panel1.Controls.Add(this.labelSummery);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelPages);
            this.panel1.Controls.Add(this.labelBinding);
            this.panel1.Controls.Add(this.labelPubTime);
            this.panel1.Controls.Add(this.labelPublisher);
            this.panel1.Controls.Add(this.labelTrans);
            this.panel1.Controls.Add(this.labelAuthor);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 417);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // richTbSummery
            // 
            this.richTbSummery.Location = new System.Drawing.Point(52, 292);
            this.richTbSummery.Name = "richTbSummery";
            this.richTbSummery.ReadOnly = true;
            this.richTbSummery.Size = new System.Drawing.Size(496, 113);
            this.richTbSummery.TabIndex = 22;
            this.richTbSummery.Text = "";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(473, 6);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 21;
            this.btnCancle.Text = "返回";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // labelBookPrice
            // 
            this.labelBookPrice.AutoSize = true;
            this.labelBookPrice.Location = new System.Drawing.Point(301, 265);
            this.labelBookPrice.Name = "labelBookPrice";
            this.labelBookPrice.Size = new System.Drawing.Size(41, 12);
            this.labelBookPrice.TabIndex = 20;
            this.labelBookPrice.Text = "label9";
            // 
            // labelBookPages
            // 
            this.labelBookPages.AutoSize = true;
            this.labelBookPages.Location = new System.Drawing.Point(301, 237);
            this.labelBookPages.Name = "labelBookPages";
            this.labelBookPages.Size = new System.Drawing.Size(41, 12);
            this.labelBookPages.TabIndex = 19;
            this.labelBookPages.Text = "label8";
            // 
            // labelBookBinding
            // 
            this.labelBookBinding.AutoSize = true;
            this.labelBookBinding.Location = new System.Drawing.Point(301, 214);
            this.labelBookBinding.Name = "labelBookBinding";
            this.labelBookBinding.Size = new System.Drawing.Size(41, 12);
            this.labelBookBinding.TabIndex = 18;
            this.labelBookBinding.Text = "label7";
            // 
            // labelBookPublishDate
            // 
            this.labelBookPublishDate.AutoSize = true;
            this.labelBookPublishDate.Location = new System.Drawing.Point(301, 182);
            this.labelBookPublishDate.Name = "labelBookPublishDate";
            this.labelBookPublishDate.Size = new System.Drawing.Size(41, 12);
            this.labelBookPublishDate.TabIndex = 17;
            this.labelBookPublishDate.Text = "label6";
            // 
            // labelBookPublisher
            // 
            this.labelBookPublisher.AutoSize = true;
            this.labelBookPublisher.Location = new System.Drawing.Point(301, 153);
            this.labelBookPublisher.Name = "labelBookPublisher";
            this.labelBookPublisher.Size = new System.Drawing.Size(41, 12);
            this.labelBookPublisher.TabIndex = 16;
            this.labelBookPublisher.Text = "label5";
            // 
            // labelBookTranslator
            // 
            this.labelBookTranslator.AutoSize = true;
            this.labelBookTranslator.Location = new System.Drawing.Point(301, 122);
            this.labelBookTranslator.Name = "labelBookTranslator";
            this.labelBookTranslator.Size = new System.Drawing.Size(41, 12);
            this.labelBookTranslator.TabIndex = 15;
            this.labelBookTranslator.Text = "label4";
            // 
            // labelBookAuthor
            // 
            this.labelBookAuthor.AutoSize = true;
            this.labelBookAuthor.Location = new System.Drawing.Point(301, 97);
            this.labelBookAuthor.Name = "labelBookAuthor";
            this.labelBookAuthor.Size = new System.Drawing.Size(41, 12);
            this.labelBookAuthor.TabIndex = 14;
            this.labelBookAuthor.Text = "label3";
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(301, 68);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(41, 12);
            this.labelBookID.TabIndex = 13;
            this.labelBookID.Text = "label2";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(301, 40);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(41, 12);
            this.labelBookName.TabIndex = 12;
            this.labelBookName.Text = "label1";
            // 
            // labelSummery
            // 
            this.labelSummery.AutoSize = true;
            this.labelSummery.Location = new System.Drawing.Point(15, 292);
            this.labelSummery.Name = "labelSummery";
            this.labelSummery.Size = new System.Drawing.Size(41, 12);
            this.labelSummery.TabIndex = 10;
            this.labelSummery.Text = "概要：";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(254, 265);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 12);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "价格：";
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(254, 237);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(41, 12);
            this.labelPages.TabIndex = 7;
            this.labelPages.Text = "页数：";
            // 
            // labelBinding
            // 
            this.labelBinding.AutoSize = true;
            this.labelBinding.Location = new System.Drawing.Point(254, 214);
            this.labelBinding.Name = "labelBinding";
            this.labelBinding.Size = new System.Drawing.Size(41, 12);
            this.labelBinding.TabIndex = 6;
            this.labelBinding.Text = "装帧：";
            // 
            // labelPubTime
            // 
            this.labelPubTime.AutoSize = true;
            this.labelPubTime.Location = new System.Drawing.Point(230, 182);
            this.labelPubTime.Name = "labelPubTime";
            this.labelPubTime.Size = new System.Drawing.Size(65, 12);
            this.labelPubTime.TabIndex = 5;
            this.labelPubTime.Text = "出版时间：";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(242, 153);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(53, 12);
            this.labelPublisher.TabIndex = 4;
            this.labelPublisher.Text = "出版社：";
            // 
            // labelTrans
            // 
            this.labelTrans.AutoSize = true;
            this.labelTrans.Location = new System.Drawing.Point(254, 122);
            this.labelTrans.Name = "labelTrans";
            this.labelTrans.Size = new System.Drawing.Size(41, 12);
            this.labelTrans.TabIndex = 3;
            this.labelTrans.Text = "翻译：";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(254, 97);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 12);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "作者：";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(266, 68);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(29, 12);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID：";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(254, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(41, 12);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "书名：";
            // 
            // ReadAPIForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBookInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReadAPIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "豆瓣图书阅读器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSummery;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelBinding;
        private System.Windows.Forms.Label labelPubTime;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelTrans;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBookPrice;
        private System.Windows.Forms.Label labelBookPages;
        private System.Windows.Forms.Label labelBookBinding;
        private System.Windows.Forms.Label labelBookPublishDate;
        private System.Windows.Forms.Label labelBookPublisher;
        private System.Windows.Forms.Label labelBookTranslator;
        private System.Windows.Forms.Label labelBookAuthor;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.RichTextBox richTbSummery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewLinkColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

