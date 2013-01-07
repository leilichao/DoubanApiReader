using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace DoubenAPIReader
{
    public partial class ReadAPIForm : Form
    {
        public ReadAPIForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 搜索按钮
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ThreadSearch));
            thread.IsBackground = true;
            thread.Start();
        }

        private void ThreadSearch()
        {
            this.Invoke(new Action(SearchBooks));
        }

        /// <summary>
        /// 搜索图书信息
        /// </summary>
        private void SearchBooks()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.tbSearch.Text))
                {
                    this.dgvBookInfo.Visible = true;
                    List<Books> list = new List<Books>();
                    this.Invoke((MethodInvoker)delegate
                    {
                        GetDataSource ds = new GetDataSource();
                        JObject reader = JObject.Parse(ds.GetTagsInfo(this.tbSearch.Text));//使用Object读json字符串

                        var temp = from file in reader["books"].Children()
                                   select file;
                        foreach (var tempFile in temp)
                        {
                            Books book = new Books();
                            book.Title = tempFile["title"].ToString().Trim();
                            if (tempFile["author"].ToString().Trim() == "[]")
                            {
                                book.Author = tempFile["author"].ToString().Trim();
                            }
                            else
                            {
                                book.Author = tempFile["author"][0].ToString().Trim();
                            }
                            book.Url = tempFile["url"].ToString().Trim();
                            book.Pages = tempFile["pages"].ToString().Trim();
                            book.Price = tempFile["price"].ToString().Trim();
                            book.Index = list.Count + 1;
                            list.Add(book);
                        }
                    });
                    if (list.Count == 0)
                    {
                        this.dgvBookInfo.Visible = false;
                        MessageBox.Show("没有查询到相关信息或者查询信息!!");
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.dgvBookInfo.DataSource = list;//数据绑定到datagridview   
                        });
                    }
                }
                else
                {
                    MessageBox.Show("请输入信息后在查找！！");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("没有查询到相关信息!!");
            }
        }

        /// <summary>
        /// 点击查询结果列表，获取图书详细信息
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void dgvBookInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dgvBookInfo.Visible = false;
                this.panel1.Visible = true;
                int index = this.dgvBookInfo.CurrentRow.Index;
                string temp = this.dgvBookInfo.Rows[index].Cells[2].Value.ToString();
                GetDataSource getdata = new GetDataSource();
                JObject reader = JObject.Parse(getdata.GetJsonFile(temp));
                this.labelBookName.Text = reader["title"].ToString().Trim();
                this.labelBookID.Text = reader["id"].ToString().Trim();
                this.labelBookAuthor.Text = "";
                for (int i = 0; i < reader["author"].Count(); i++)
                {
                    if (reader["author"].ToString().Trim() == "[]")
                    {
                        this.labelBookAuthor.Text = reader["author"].ToString().Trim();
                    }
                    else
                    {
                        this.labelBookAuthor.Text += reader["author"][i].ToString().Trim();
                    }
                }
                this.labelBookPublisher.Text = reader["publisher"].ToString().Trim();
                this.labelBookPublishDate.Text = reader["pubdate"].ToString().Trim();
                this.labelBookBinding.Text = reader["binding"].ToString().Trim();
                this.labelBookPages.Text = reader["pages"].ToString().Trim();
                this.labelBookPrice.Text = reader["price"].ToString().Trim();
                this.pictureBox2.ImageLocation = reader["images"]["large"].ToString().Trim();
                this.richTbSummery.Text = reader["summary"].ToString().Trim();
                this.labelBookTranslator.Text = "";
                for (int i = 0; i < reader["translator"].Count(); i++)
                {
                    if (reader["translator"].ToString().Trim() == "[]")
                    {
                        this.labelBookTranslator.Text = reader["translator"].ToString().Trim();
                    }
                    else
                    {
                        this.labelBookTranslator.Text += reader["translator"][0].ToString().Trim();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("发生异常，请检查！");
            }

        }

        /// <summary>
        /// 返回按钮，隐藏显示的信息
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            this.dgvBookInfo.Visible = true;
        }
    }
}
