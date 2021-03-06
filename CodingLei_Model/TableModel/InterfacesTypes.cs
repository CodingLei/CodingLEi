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
    /// 实体类InterfacesTypes。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("InterfacesTypes")]
    [Serializable]
    public partial class InterfacesTypes : Entity
    {
        #region Model
        private int _Id;
        private int? _DelStatus;
        private DateTime? _AddTime;
        private string _InterfaceName;
        private string _Describe;

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
        /// 
        /// </summary>
        [Field("InterfaceName")]
        public string InterfaceName
        {
            get { return _InterfaceName; }
            set
            {
                this.OnPropertyValueChange("InterfaceName");
                this._InterfaceName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Describe")]
        public string Describe
        {
            get { return _Describe; }
            set
            {
                this.OnPropertyValueChange("Describe");
                this._Describe = value;
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
                _.InterfaceName,
                _.Describe,
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
                this._InterfaceName,
                this._Describe,
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
            public readonly static Field All = new Field("*", "InterfacesTypes");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Id = new Field("Id", "InterfacesTypes", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DelStatus = new Field("DelStatus", "InterfacesTypes", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field AddTime = new Field("AddTime", "InterfacesTypes", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field InterfaceName = new Field("InterfaceName", "InterfacesTypes", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Describe = new Field("Describe", "InterfacesTypes", "");
        }
        #endregion
    }
}