﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dos.ORM;

namespace CodingLei_Model.TableModel
{
    /// <summary>
    /// 实体类Community_TopicReply。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Community_TopicReply")]
    [Serializable]
    public partial class Community_TopicReply : Entity
    {
        #region Model
        private int _Id;
        private int? _Delstatus;
        private DateTime? _AddTime;
        private string _Contents;
        private string _ReplyOpenid;
        private int? _ReplyId;
        private string _ReplyName;
        private string _ReplyHeadImg;
        private int? _IsRead;

        /// <summary>
        /// 
        /// </summary>
        [Field("Id")]
        public int Id
        {
            get { return _Id; }
            set
            {
                this.OnPropertyValueChange("Id");
                this._Id = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Delstatus")]
        public int? Delstatus
        {
            get { return _Delstatus; }
            set
            {
                this.OnPropertyValueChange("Delstatus");
                this._Delstatus = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("AddTime")]
        public DateTime? AddTime
        {
            get { return _AddTime; }
            set
            {
                this.OnPropertyValueChange("AddTime");
                this._AddTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Contents")]
        public string Contents
        {
            get { return _Contents; }
            set
            {
                this.OnPropertyValueChange("Contents");
                this._Contents = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ReplyOpenid")]
        public string ReplyOpenid
        {
            get { return _ReplyOpenid; }
            set
            {
                this.OnPropertyValueChange("ReplyOpenid");
                this._ReplyOpenid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ReplyId")]
        public int? ReplyId
        {
            get { return _ReplyId; }
            set
            {
                this.OnPropertyValueChange("ReplyId");
                this._ReplyId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ReplyName")]
        public string ReplyName
        {
            get { return _ReplyName; }
            set
            {
                this.OnPropertyValueChange("ReplyName");
                this._ReplyName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("ReplyHeadImg")]
        public string ReplyHeadImg
        {
            get { return _ReplyHeadImg; }
            set
            {
                this.OnPropertyValueChange("ReplyHeadImg");
                this._ReplyHeadImg = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("IsRead")]
        public int? IsRead
        {
            get { return _IsRead; }
            set
            {
                this.OnPropertyValueChange("IsRead");
                this._IsRead = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                _.Id,
            };
        }
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.Id;
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.Id,
                _.Delstatus,
                _.AddTime,
                _.Contents,
                _.ReplyOpenid,
                _.ReplyId,
                _.ReplyName,
                _.ReplyHeadImg,
                _.IsRead,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._Id,
                this._Delstatus,
                this._AddTime,
                this._Contents,
                this._ReplyOpenid,
                this._ReplyId,
                this._ReplyName,
                this._ReplyHeadImg,
                this._IsRead,
            };
        }
        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "Community_TopicReply");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "Community_TopicReply", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Delstatus = new Field("Delstatus", "Community_TopicReply", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AddTime = new Field("AddTime", "Community_TopicReply", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Contents = new Field("Contents", "Community_TopicReply", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ReplyOpenid = new Field("ReplyOpenid", "Community_TopicReply", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ReplyId = new Field("ReplyId", "Community_TopicReply", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ReplyName = new Field("ReplyName", "Community_TopicReply", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ReplyHeadImg = new Field("ReplyHeadImg", "Community_TopicReply", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IsRead = new Field("IsRead", "Community_TopicReply", "");
        }
        #endregion

    }
}