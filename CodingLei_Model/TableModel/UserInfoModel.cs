using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingLei_Model.TableModel
{
    /// <summary>
    /// 用户信息Model
    /// </summary>
    public class UserInfoModel
    {
        /// <summary>
        /// 会员ID
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 会员姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 会员年龄
        /// </summary>
        public int UserAge { get; set; }
        /// <summary>
        /// 会员联系方式
        /// </summary>
        public string Tell { get; set; }
        /// <summary>
        /// 有效性
        /// </summary>
        public bool Enabled { get; set; }
    }
}
