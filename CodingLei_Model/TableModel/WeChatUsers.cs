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
    /// 实体类WeChatUsers。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("WeChatUsers")]
    [Serializable]
    public partial class WeChatUsers : Entity
    {
        #region Model
        private int _Id;
        private DateTime? _AddTime;
        private int? _DelStatus;
        private string _Openid;
        private string _Nickname;
        private string _Sex;
        private string _Headimgurl;
        private int? _ISSendWeChat1;
        private string _CardID;
        private string _PatientID;
        private int? _RoleType;
        private int? _PositionRoles;
        private string _Category;

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
        [Field("DelStatus")]
        public int? DelStatus
        {
            get { return _DelStatus; }
            set
            {
                this.OnPropertyValueChange("DelStatus");
                this._DelStatus = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Openid")]
        public string Openid
        {
            get { return _Openid; }
            set
            {
                this.OnPropertyValueChange("Openid");
                this._Openid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Nickname")]
        public string Nickname
        {
            get { return _Nickname; }
            set
            {
                this.OnPropertyValueChange("Nickname");
                this._Nickname = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Sex")]
        public string Sex
        {
            get { return _Sex; }
            set
            {
                this.OnPropertyValueChange("Sex");
                this._Sex = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Headimgurl")]
        public string Headimgurl
        {
            get { return _Headimgurl; }
            set
            {
                this.OnPropertyValueChange("Headimgurl");
                this._Headimgurl = value;
            }
        }
        /// <summary>
        /// 时候发送微信通知（1是，0否）
        /// </summary>
        [Field("ISSendWeChat1")]
        public int? ISSendWeChat1
        {
            get { return _ISSendWeChat1; }
            set
            {
                this.OnPropertyValueChange("ISSendWeChat1");
                this._ISSendWeChat1 = value;
            }
        }
        /// <summary>
        /// 身份证号
        /// </summary>
        [Field("CardID")]
        public string CardID
        {
            get { return _CardID; }
            set
            {
                this.OnPropertyValueChange("CardID");
                this._CardID = value;
            }
        }
        /// <summary>
        /// 就诊卡号
        /// </summary>
        [Field("PatientID")]
        public string PatientID
        {
            get { return _PatientID; }
            set
            {
                this.OnPropertyValueChange("PatientID");
                this._PatientID = value;
            }
        }
        /// <summary>
        /// _0医生，1患者
        /// </summary>
        [Field("RoleType")]
        public int? RoleType
        {
            get { return _RoleType; }
            set
            {
                this.OnPropertyValueChange("RoleType");
                this._RoleType = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("PositionRoles")]
        public int? PositionRoles
        {
            get { return _PositionRoles; }
            set
            {
                this.OnPropertyValueChange("PositionRoles");
                this._PositionRoles = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Category")]
        public string Category
        {
            get { return _Category; }
            set
            {
                this.OnPropertyValueChange("Category");
                this._Category = value;
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
                _.AddTime,
                _.DelStatus,
                _.Openid,
                _.Nickname,
                _.Sex,
                _.Headimgurl,
                _.ISSendWeChat1,
                _.CardID,
                _.PatientID,
                _.RoleType,
                _.PositionRoles,
                _.Category,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._Id,
                this._AddTime,
                this._DelStatus,
                this._Openid,
                this._Nickname,
                this._Sex,
                this._Headimgurl,
                this._ISSendWeChat1,
                this._CardID,
                this._PatientID,
                this._RoleType,
                this._PositionRoles,
                this._Category,
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
            public readonly static Field All = new Field("*", "WeChatUsers");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "WeChatUsers", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AddTime = new Field("AddTime", "WeChatUsers", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DelStatus = new Field("DelStatus", "WeChatUsers", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Openid = new Field("Openid", "WeChatUsers", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Nickname = new Field("Nickname", "WeChatUsers", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Sex = new Field("Sex", "WeChatUsers", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Headimgurl = new Field("Headimgurl", "WeChatUsers", "");
            /// <summary>
			/// 时候发送微信通知（1是，0否）
			/// </summary>
			public readonly static Field ISSendWeChat1 = new Field("ISSendWeChat1", "WeChatUsers", "时候发送微信通知（1是，0否）");
            /// <summary>
			/// 身份证号
			/// </summary>
			public readonly static Field CardID = new Field("CardID", "WeChatUsers", "身份证号");
            /// <summary>
			/// 就诊卡号
			/// </summary>
			public readonly static Field PatientID = new Field("PatientID", "WeChatUsers", "就诊卡号");
            /// <summary>
			/// _0医生，1患者
			/// </summary>
			public readonly static Field RoleType = new Field("RoleType", "WeChatUsers", "_0医生，1患者");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PositionRoles = new Field("PositionRoles", "WeChatUsers", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Category = new Field("Category", "WeChatUsers", "");
        }
        #endregion
    }
}