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
    /// 实体类Employee。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("Employee")]
    [Serializable]
    public partial class Employee : Entity
    {
        #region Model
        private int _Id;
        private int? _DelStatus;
        private DateTime? _AddTime;
        private string _LoginPassword;
        private string _EmployeeName;
        private string _Phone;
        private string _EmployeeId;

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
        /// 是否有效（0，有效，1，无效）
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
        /// 密码
        /// </summary>
        [Field("LoginPassword")]
        public string LoginPassword
        {
            get { return _LoginPassword; }
            set
            {
                this.OnPropertyValueChange("LoginPassword");
                this._LoginPassword = value;
            }
        }
        /// <summary>
        /// 员工姓名
        /// </summary>
        [Field("EmployeeName")]
        public string EmployeeName
        {
            get { return _EmployeeName; }
            set
            {
                this.OnPropertyValueChange("EmployeeName");
                this._EmployeeName = value;
            }
        }
        /// <summary>
        /// 手机号
        /// </summary>
        [Field("Phone")]
        public string Phone
        {
            get { return _Phone; }
            set
            {
                this.OnPropertyValueChange("Phone");
                this._Phone = value;
            }
        }
        /// <summary>
        /// 员工工号
        /// </summary>
        [Field("EmployeeId")]
        public string EmployeeId
        {
            get { return _EmployeeId; }
            set
            {
                this.OnPropertyValueChange("EmployeeId");
                this._EmployeeId = value;
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
                _.DelStatus,
                _.AddTime,
                _.LoginPassword,
                _.EmployeeName,
                _.Phone,
                _.EmployeeId,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._Id,
                this._DelStatus,
                this._AddTime,
                this._LoginPassword,
                this._EmployeeName,
                this._Phone,
                this._EmployeeId,
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
            public readonly static Field All = new Field("*", "Employee");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "Employee", "");
            /// <summary>
			/// 是否有效（0，有效，1，无效）
			/// </summary>
			public readonly static Field DelStatus = new Field("DelStatus", "Employee", "是否有效（0，有效，1，无效）");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AddTime = new Field("AddTime", "Employee", "");
            /// <summary>
			/// 密码
			/// </summary>
			public readonly static Field LoginPassword = new Field("LoginPassword", "Employee", "密码");
            /// <summary>
			/// 员工姓名
			/// </summary>
			public readonly static Field EmployeeName = new Field("EmployeeName", "Employee", "员工姓名");
            /// <summary>
			/// 手机号
			/// </summary>
			public readonly static Field Phone = new Field("Phone", "Employee", "手机号");
            /// <summary>
			/// 员工工号
			/// </summary>
			public readonly static Field EmployeeId = new Field("EmployeeId", "Employee", "员工工号");
        }
        #endregion
    }
}