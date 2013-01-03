using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubenAPIReader
{
    public class Books
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string Title
        {
            get;
            set;
        }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author
        {
            get;
            set;
        }
        /// <summary>
        /// API地址
        /// </summary>
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// 页数
        /// </summary>
        public string Pages
        {
            get;
            set;
        }
        /// <summary>
        /// 价格
        /// </summary>
        public string Price
        {
            get;
            set;
        }
        /// <summary>
        /// 序号
        /// </summary>
        public int Index
        {
            get;
            set;
        }
    }
}
