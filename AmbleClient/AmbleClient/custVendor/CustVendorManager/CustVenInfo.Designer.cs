﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using MySql.Data.MySqlClient;


[assembly: EdmSchemaAttribute()]

namespace AmbleClient.custVendor.CustVendorManager
{
    #region 上下文
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    public partial class CustVenInfoEntities : ObjectContext
    {
        #region 构造函数
    
        /// <summary>
        /// 请使用应用程序配置文件的“CustVenInfoEntities”部分中的连接字符串初始化新 CustVenInfoEntities 对象。
        /// </summary>
        public CustVenInfoEntities() : base("name=CustVenInfoEntities", "CustVenInfoEntities")
        {
            ChangeString();
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 CustVenInfoEntities 对象。
        /// </summary>
        public CustVenInfoEntities(string connectionString) : base(connectionString, "CustVenInfoEntities")
        {
            ChangeString();
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 CustVenInfoEntities 对象。
        /// </summary>
        public CustVenInfoEntities(EntityConnection connection) : base(connection, "CustVenInfoEntities")
        {
            ChangeString();
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
        private void ChangeString()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder(((EntityConnection)Connection).StoreConnection.ConnectionString);
            sb.UserID = ServerInfo.GetUserId();
            sb.Password = ServerInfo.GetPassword();
            sb.Server = ServerInfo.GetServerAddress();
            sb.Database = "shenzhenerp";
            ((EntityConnection)Connection).StoreConnection.ConnectionString = sb.ConnectionString;

        }
        #endregion
    
        #region 分部方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<custvendorinfo> custvendorinfo
        {
            get
            {
                if ((_custvendorinfo == null))
                {
                    _custvendorinfo = base.CreateObjectSet<custvendorinfo>("custvendorinfo");
                }
                return _custvendorinfo;
            }
        }
        private ObjectSet<custvendorinfo> _custvendorinfo;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<custvendorinfoshipto> custvendorinfoshipto
        {
            get
            {
                if ((_custvendorinfoshipto == null))
                {
                    _custvendorinfoshipto = base.CreateObjectSet<custvendorinfoshipto>("custvendorinfoshipto");
                }
                return _custvendorinfoshipto;
            }
        }
        private ObjectSet<custvendorinfoshipto> _custvendorinfoshipto;

        #endregion
        #region AddTo 方法
    
        /// <summary>
        /// 用于向 custvendorinfo EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddTocustvendorinfo(custvendorinfo custvendorinfo)
        {
            base.AddObject("custvendorinfo", custvendorinfo);
        }
    
        /// <summary>
        /// 用于向 custvendorinfoshipto EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddTocustvendorinfoshipto(custvendorinfoshipto custvendorinfoshipto)
        {
            base.AddObject("custvendorinfoshipto", custvendorinfoshipto);
        }

        #endregion
    }
    

    #endregion
    
    #region 实体
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="shenzhenerpModel", Name="custvendorinfo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class custvendorinfo : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 custvendorinfo 对象。
        /// </summary>
        /// <param name="cvId">cvId 属性的初始值。</param>
        /// <param name="cvtype">cvtype 属性的初始值。</param>
        /// <param name="cvname">cvname 属性的初始值。</param>
        /// <param name="ownerName">ownerName 属性的初始值。</param>
        public static custvendorinfo Createcustvendorinfo(global::System.Int32 cvId, global::System.SByte cvtype, global::System.String cvname, global::System.Int16 ownerName)
        {
            custvendorinfo custvendorinfo = new custvendorinfo();
            custvendorinfo.cvId = cvId;
            custvendorinfo.cvtype = cvtype;
            custvendorinfo.cvname = cvname;
            custvendorinfo.ownerName = ownerName;
            return custvendorinfo;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 cvId
        {
            get
            {
                return _cvId;
            }
            set
            {
                if (_cvId != value)
                {
                    OncvIdChanging(value);
                    ReportPropertyChanging("cvId");
                    _cvId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("cvId");
                    OncvIdChanged();
                }
            }
        }
        private global::System.Int32 _cvId;
        partial void OncvIdChanging(global::System.Int32 value);
        partial void OncvIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.SByte cvtype
        {
            get
            {
                return _cvtype;
            }
            set
            {
                OncvtypeChanging(value);
                ReportPropertyChanging("cvtype");
                _cvtype = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cvtype");
                OncvtypeChanged();
            }
        }
        private global::System.SByte _cvtype;
        partial void OncvtypeChanging(global::System.SByte value);
        partial void OncvtypeChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String cvname
        {
            get
            {
                return _cvname;
            }
            set
            {
                OncvnameChanging(value);
                ReportPropertyChanging("cvname");
                _cvname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("cvname");
                OncvnameChanged();
            }
        }
        private global::System.String _cvname;
        partial void OncvnameChanging(global::System.String value);
        partial void OncvnameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String country
        {
            get
            {
                return _country;
            }
            set
            {
                OncountryChanging(value);
                ReportPropertyChanging("country");
                _country = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("country");
                OncountryChanged();
            }
        }
        private global::System.String _country;
        partial void OncountryChanging(global::System.String value);
        partial void OncountryChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cvnumber
        {
            get
            {
                return _cvnumber;
            }
            set
            {
                OncvnumberChanging(value);
                ReportPropertyChanging("cvnumber");
                _cvnumber = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cvnumber");
                OncvnumberChanged();
            }
        }
        private global::System.String _cvnumber;
        partial void OncvnumberChanging(global::System.String value);
        partial void OncvnumberChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.SByte> rate
        {
            get
            {
                return _rate;
            }
            set
            {
                OnrateChanging(value);
                ReportPropertyChanging("rate");
                _rate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rate");
                OnrateChanged();
            }
        }
        private Nullable<global::System.SByte> _rate;
        partial void OnrateChanging(Nullable<global::System.SByte> value);
        partial void OnrateChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String term
        {
            get
            {
                return _term;
            }
            set
            {
                OntermChanging(value);
                ReportPropertyChanging("term");
                _term = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("term");
                OntermChanged();
            }
        }
        private global::System.String _term;
        partial void OntermChanging(global::System.String value);
        partial void OntermChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String contact1
        {
            get
            {
                return _contact1;
            }
            set
            {
                Oncontact1Changing(value);
                ReportPropertyChanging("contact1");
                _contact1 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("contact1");
                Oncontact1Changed();
            }
        }
        private global::System.String _contact1;
        partial void Oncontact1Changing(global::System.String value);
        partial void Oncontact1Changed();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String contact2
        {
            get
            {
                return _contact2;
            }
            set
            {
                Oncontact2Changing(value);
                ReportPropertyChanging("contact2");
                _contact2 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("contact2");
                Oncontact2Changed();
            }
        }
        private global::System.String _contact2;
        partial void Oncontact2Changing(global::System.String value);
        partial void Oncontact2Changed();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String phone1
        {
            get
            {
                return _phone1;
            }
            set
            {
                Onphone1Changing(value);
                ReportPropertyChanging("phone1");
                _phone1 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("phone1");
                Onphone1Changed();
            }
        }
        private global::System.String _phone1;
        partial void Onphone1Changing(global::System.String value);
        partial void Onphone1Changed();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String phone2
        {
            get
            {
                return _phone2;
            }
            set
            {
                Onphone2Changing(value);
                ReportPropertyChanging("phone2");
                _phone2 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("phone2");
                Onphone2Changed();
            }
        }
        private global::System.String _phone2;
        partial void Onphone2Changing(global::System.String value);
        partial void Onphone2Changed();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cellphone
        {
            get
            {
                return _cellphone;
            }
            set
            {
                OncellphoneChanging(value);
                ReportPropertyChanging("cellphone");
                _cellphone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cellphone");
                OncellphoneChanged();
            }
        }
        private global::System.String _cellphone;
        partial void OncellphoneChanging(global::System.String value);
        partial void OncellphoneChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String fax
        {
            get
            {
                return _fax;
            }
            set
            {
                OnfaxChanging(value);
                ReportPropertyChanging("fax");
                _fax = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("fax");
                OnfaxChanged();
            }
        }
        private global::System.String _fax;
        partial void OnfaxChanging(global::System.String value);
        partial void OnfaxChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String email1
        {
            get
            {
                return _email1;
            }
            set
            {
                Onemail1Changing(value);
                ReportPropertyChanging("email1");
                _email1 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("email1");
                Onemail1Changed();
            }
        }
        private global::System.String _email1;
        partial void Onemail1Changing(global::System.String value);
        partial void Onemail1Changed();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String email2
        {
            get
            {
                return _email2;
            }
            set
            {
                Onemail2Changing(value);
                ReportPropertyChanging("email2");
                _email2 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("email2");
                Onemail2Changed();
            }
        }
        private global::System.String _email2;
        partial void Onemail2Changing(global::System.String value);
        partial void Onemail2Changed();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 ownerName
        {
            get
            {
                return _ownerName;
            }
            set
            {
                OnownerNameChanging(value);
                ReportPropertyChanging("ownerName");
                _ownerName = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ownerName");
                OnownerNameChanged();
            }
        }
        private global::System.Int16 _ownerName;
        partial void OnownerNameChanging(global::System.Int16 value);
        partial void OnownerNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> lastUpdateName
        {
            get
            {
                return _lastUpdateName;
            }
            set
            {
                OnlastUpdateNameChanging(value);
                ReportPropertyChanging("lastUpdateName");
                _lastUpdateName = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("lastUpdateName");
                OnlastUpdateNameChanged();
            }
        }
        private Nullable<global::System.Int16> _lastUpdateName;
        partial void OnlastUpdateNameChanging(Nullable<global::System.Int16> value);
        partial void OnlastUpdateNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> lastUpdateDate
        {
            get
            {
                return _lastUpdateDate;
            }
            set
            {
                OnlastUpdateDateChanging(value);
                ReportPropertyChanging("lastUpdateDate");
                _lastUpdateDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("lastUpdateDate");
                OnlastUpdateDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _lastUpdateDate;
        partial void OnlastUpdateDateChanging(Nullable<global::System.DateTime> value);
        partial void OnlastUpdateDateChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.SByte> blacklisted
        {
            get
            {
                return _blacklisted;
            }
            set
            {
                OnblacklistedChanging(value);
                ReportPropertyChanging("blacklisted");
                _blacklisted = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("blacklisted");
                OnblacklistedChanged();
            }
        }
        private Nullable<global::System.SByte> _blacklisted;
        partial void OnblacklistedChanging(Nullable<global::System.SByte> value);
        partial void OnblacklistedChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> amount
        {
            get
            {
                return _amount;
            }
            set
            {
                OnamountChanging(value);
                ReportPropertyChanging("amount");
                _amount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("amount");
                OnamountChanged();
            }
        }
        private Nullable<global::System.Int32> _amount;
        partial void OnamountChanging(Nullable<global::System.Int32> value);
        partial void OnamountChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String notes
        {
            get
            {
                return _notes;
            }
            set
            {
                OnnotesChanging(value);
                ReportPropertyChanging("notes");
                _notes = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("notes");
                OnnotesChanged();
            }
        }
        private global::System.String _notes;
        partial void OnnotesChanging(global::System.String value);
        partial void OnnotesChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String paymentTerm
        {
            get
            {
                return _paymentTerm;
            }
            set
            {
                OnpaymentTermChanging(value);
                ReportPropertyChanging("paymentTerm");
                _paymentTerm = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("paymentTerm");
                OnpaymentTermChanged();
            }
        }
        private global::System.String _paymentTerm;
        partial void OnpaymentTermChanging(global::System.String value);
        partial void OnpaymentTermChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String shippingTerm
        {
            get
            {
                return _shippingTerm;
            }
            set
            {
                OnshippingTermChanging(value);
                ReportPropertyChanging("shippingTerm");
                _shippingTerm = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("shippingTerm");
                OnshippingTermChanged();
            }
        }
        private global::System.String _shippingTerm;
        partial void OnshippingTermChanging(global::System.String value);
        partial void OnshippingTermChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String billTo
        {
            get
            {
                return _billTo;
            }
            set
            {
                OnbillToChanging(value);
                ReportPropertyChanging("billTo");
                _billTo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("billTo");
                OnbillToChanged();
            }
        }
        private global::System.String _billTo;
        partial void OnbillToChanging(global::System.String value);
        partial void OnbillToChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String productLine
        {
            get
            {
                return _productLine;
            }
            set
            {
                OnproductLineChanging(value);
                ReportPropertyChanging("productLine");
                _productLine = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("productLine");
                OnproductLineChanged();
            }
        }
        private global::System.String _productLine;
        partial void OnproductLineChanging(global::System.String value);
        partial void OnproductLineChanged();

        #endregion
    
    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="shenzhenerpModel", Name="custvendorinfoshipto")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class custvendorinfoshipto : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 custvendorinfoshipto 对象。
        /// </summary>
        /// <param name="cvShipId">cvShipId 属性的初始值。</param>
        /// <param name="cvId">cvId 属性的初始值。</param>
        public static custvendorinfoshipto Createcustvendorinfoshipto(global::System.Int32 cvShipId, global::System.Int32 cvId)
        {
            custvendorinfoshipto custvendorinfoshipto = new custvendorinfoshipto();
            custvendorinfoshipto.cvShipId = cvShipId;
            custvendorinfoshipto.cvId = cvId;
            return custvendorinfoshipto;
        }

        #endregion
        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 cvShipId
        {
            get
            {
                return _cvShipId;
            }
            set
            {
                if (_cvShipId != value)
                {
                    OncvShipIdChanging(value);
                    ReportPropertyChanging("cvShipId");
                    _cvShipId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("cvShipId");
                    OncvShipIdChanged();
                }
            }
        }
        private global::System.Int32 _cvShipId;
        partial void OncvShipIdChanging(global::System.Int32 value);
        partial void OncvShipIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 cvId
        {
            get
            {
                return _cvId;
            }
            set
            {
                OncvIdChanging(value);
                ReportPropertyChanging("cvId");
                _cvId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cvId");
                OncvIdChanged();
            }
        }
        private global::System.Int32 _cvId;
        partial void OncvIdChanging(global::System.Int32 value);
        partial void OncvIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String shipTo
        {
            get
            {
                return _shipTo;
            }
            set
            {
                OnshipToChanging(value);
                ReportPropertyChanging("shipTo");
                _shipTo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("shipTo");
                OnshipToChanged();
            }
        }
        private global::System.String _shipTo;
        partial void OnshipToChanging(global::System.String value);
        partial void OnshipToChanged();

        #endregion
    
    }

    #endregion
    
}
