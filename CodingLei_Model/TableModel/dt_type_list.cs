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
    /// 实体类dt_type_list。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("dt_type_list")]
    [Serializable]
    public partial class dt_type_list : Entity
    {
        #region Model
        private int _id;
        private string _typeName;

        /// <summary>
        /// 
        /// </summary>
        [Field("id")]
        public int id
        {
            get { return _id; }
            set
            {
                this.OnPropertyValueChange("id");
                this._id = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("typeName")]
        public string typeName
        {
            get { return _typeName; }
            set
            {
                this.OnPropertyValueChange("typeName");
                this._typeName = value;
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
                _.id,
            };
        }
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.id;
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.id,
                _.typeName,
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._id,
                this._typeName,
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
            public readonly static Field All = new Field("*", "dt_type_list");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field id = new Field("id", "dt_type_list", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field typeName = new Field("typeName", "dt_type_list", "");
        }
        #endregion
    }
}