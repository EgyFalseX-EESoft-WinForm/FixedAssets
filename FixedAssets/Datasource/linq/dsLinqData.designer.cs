﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FixedAssets.Datasource.linq
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FixedAssets")]
	public partial class dsLinqDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertRule(Rule instance);
    partial void UpdateRule(Rule instance);
    partial void DeleteRule(Rule instance);
    partial void InsertTblEmp(TblEmp instance);
    partial void UpdateTblEmp(TblEmp instance);
    partial void DeleteTblEmp(TblEmp instance);
    partial void InsertCdJob(CdJob instance);
    partial void UpdateCdJob(CdJob instance);
    partial void DeleteCdJob(CdJob instance);
    partial void InsertCdDepertment(CdDepertment instance);
    partial void UpdateCdDepertment(CdDepertment instance);
    partial void DeleteCdDepertment(CdDepertment instance);
    partial void InsertCdAssetplace(CdAssetplace instance);
    partial void UpdateCdAssetplace(CdAssetplace instance);
    partial void DeleteCdAssetplace(CdAssetplace instance);
    partial void InsertCdAssetState(CdAssetState instance);
    partial void UpdateCdAssetState(CdAssetState instance);
    partial void DeleteCdAssetState(CdAssetState instance);
    partial void InsertCdAssetPropertiy(CdAssetPropertiy instance);
    partial void UpdateCdAssetPropertiy(CdAssetPropertiy instance);
    partial void DeleteCdAssetPropertiy(CdAssetPropertiy instance);
    #endregion
		
		public dsLinqDataDataContext() : 
				base(global::FixedAssets.Properties.Settings.Default.FixedAssetsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dsLinqDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dsLinqDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dsLinqDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dsLinqDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Rule> Rules
		{
			get
			{
				return this.GetTable<Rule>();
			}
		}
		
		public System.Data.Linq.Table<TblEmp> TblEmps
		{
			get
			{
				return this.GetTable<TblEmp>();
			}
		}
		
		public System.Data.Linq.Table<CdJob> CdJobs
		{
			get
			{
				return this.GetTable<CdJob>();
			}
		}
		
		public System.Data.Linq.Table<CdDepertment> CdDepertments
		{
			get
			{
				return this.GetTable<CdDepertment>();
			}
		}
		
		public System.Data.Linq.Table<CdAssetplace> CdAssetplaces
		{
			get
			{
				return this.GetTable<CdAssetplace>();
			}
		}
		
		public System.Data.Linq.Table<CdAssetState> CdAssetStates
		{
			get
			{
				return this.GetTable<CdAssetState>();
			}
		}
		
		public System.Data.Linq.Table<CdAssetPropertiy> CdAssetPropertiys
		{
			get
			{
				return this.GetTable<CdAssetPropertiy>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _UserName;
		
		private System.Nullable<bool> _IsActive;
		
		private System.Nullable<System.DateTime> _LastActivityDate;
		
		private System.Nullable<bool> _IsAdmin;
		
		private System.Nullable<byte> _ModereaId;
		
		private int _EmpId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnIsActiveChanging(System.Nullable<bool> value);
    partial void OnIsActiveChanged();
    partial void OnLastActivityDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastActivityDateChanged();
    partial void OnIsAdminChanging(System.Nullable<bool> value);
    partial void OnIsAdminChanged();
    partial void OnModereaIdChanging(System.Nullable<byte> value);
    partial void OnModereaIdChanged();
    partial void OnEmpIdChanging(int value);
    partial void OnEmpIdChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastActivityDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastActivityDate
		{
			get
			{
				return this._LastActivityDate;
			}
			set
			{
				if ((this._LastActivityDate != value))
				{
					this.OnLastActivityDateChanging(value);
					this.SendPropertyChanging();
					this._LastActivityDate = value;
					this.SendPropertyChanged("LastActivityDate");
					this.OnLastActivityDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsAdmin", DbType="Bit")]
		public System.Nullable<bool> IsAdmin
		{
			get
			{
				return this._IsAdmin;
			}
			set
			{
				if ((this._IsAdmin != value))
				{
					this.OnIsAdminChanging(value);
					this.SendPropertyChanging();
					this._IsAdmin = value;
					this.SendPropertyChanged("IsAdmin");
					this.OnIsAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModereaId", DbType="TinyInt")]
		public System.Nullable<byte> ModereaId
		{
			get
			{
				return this._ModereaId;
			}
			set
			{
				if ((this._ModereaId != value))
				{
					this.OnModereaIdChanging(value);
					this.SendPropertyChanging();
					this._ModereaId = value;
					this.SendPropertyChanged("ModereaId");
					this.OnModereaIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", DbType="Int NOT NULL")]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this.OnEmpIdChanging(value);
					this.SendPropertyChanging();
					this._EmpId = value;
					this.SendPropertyChanged("EmpId");
					this.OnEmpIdChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Rule]")]
	public partial class Rule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RuleID;
		
		private string _RuleName;
		
		private string _RuleDesc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRuleIDChanging(int value);
    partial void OnRuleIDChanged();
    partial void OnRuleNameChanging(string value);
    partial void OnRuleNameChanged();
    partial void OnRuleDescChanging(string value);
    partial void OnRuleDescChanged();
    #endregion
		
		public Rule()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RuleID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RuleID
		{
			get
			{
				return this._RuleID;
			}
			set
			{
				if ((this._RuleID != value))
				{
					this.OnRuleIDChanging(value);
					this.SendPropertyChanging();
					this._RuleID = value;
					this.SendPropertyChanged("RuleID");
					this.OnRuleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RuleName", DbType="NVarChar(100)")]
		public string RuleName
		{
			get
			{
				return this._RuleName;
			}
			set
			{
				if ((this._RuleName != value))
				{
					this.OnRuleNameChanging(value);
					this.SendPropertyChanging();
					this._RuleName = value;
					this.SendPropertyChanged("RuleName");
					this.OnRuleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RuleDesc", DbType="NVarChar(100)")]
		public string RuleDesc
		{
			get
			{
				return this._RuleDesc;
			}
			set
			{
				if ((this._RuleDesc != value))
				{
					this.OnRuleDescChanging(value);
					this.SendPropertyChanging();
					this._RuleDesc = value;
					this.SendPropertyChanged("RuleDesc");
					this.OnRuleDescChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblEmp")]
	public partial class TblEmp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmpId;
		
		private string _EmpName;
		
		private byte _EmpJobId;
		
		private byte _EmpDepertment;
		
		private System.DateTime _dateIn;
		
		private int _UserIn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpIdChanging(int value);
    partial void OnEmpIdChanged();
    partial void OnEmpNameChanging(string value);
    partial void OnEmpNameChanged();
    partial void OnEmpJobIdChanging(byte value);
    partial void OnEmpJobIdChanged();
    partial void OnEmpDepertmentChanging(byte value);
    partial void OnEmpDepertmentChanged();
    partial void OndateInChanging(System.DateTime value);
    partial void OndateInChanged();
    partial void OnUserInChanging(int value);
    partial void OnUserInChanged();
    #endregion
		
		public TblEmp()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this.OnEmpIdChanging(value);
					this.SendPropertyChanging();
					this._EmpId = value;
					this.SendPropertyChanged("EmpId");
					this.OnEmpIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="NVarChar(75) NOT NULL", CanBeNull=false)]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this.OnEmpNameChanging(value);
					this.SendPropertyChanging();
					this._EmpName = value;
					this.SendPropertyChanged("EmpName");
					this.OnEmpNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpJobId", DbType="TinyInt NOT NULL")]
		public byte EmpJobId
		{
			get
			{
				return this._EmpJobId;
			}
			set
			{
				if ((this._EmpJobId != value))
				{
					this.OnEmpJobIdChanging(value);
					this.SendPropertyChanging();
					this._EmpJobId = value;
					this.SendPropertyChanged("EmpJobId");
					this.OnEmpJobIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpDepertment", DbType="TinyInt NOT NULL")]
		public byte EmpDepertment
		{
			get
			{
				return this._EmpDepertment;
			}
			set
			{
				if ((this._EmpDepertment != value))
				{
					this.OnEmpDepertmentChanging(value);
					this.SendPropertyChanging();
					this._EmpDepertment = value;
					this.SendPropertyChanged("EmpDepertment");
					this.OnEmpDepertmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateIn", DbType="DateTime NOT NULL")]
		public System.DateTime dateIn
		{
			get
			{
				return this._dateIn;
			}
			set
			{
				if ((this._dateIn != value))
				{
					this.OndateInChanging(value);
					this.SendPropertyChanging();
					this._dateIn = value;
					this.SendPropertyChanged("dateIn");
					this.OndateInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserIn", DbType="Int NOT NULL")]
		public int UserIn
		{
			get
			{
				return this._UserIn;
			}
			set
			{
				if ((this._UserIn != value))
				{
					this.OnUserInChanging(value);
					this.SendPropertyChanging();
					this._UserIn = value;
					this.SendPropertyChanged("UserIn");
					this.OnUserInChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CdJob")]
	public partial class CdJob : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _JobId;
		
		private string _JobName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnJobIdChanging(byte value);
    partial void OnJobIdChanged();
    partial void OnJobNameChanging(string value);
    partial void OnJobNameChanged();
    #endregion
		
		public CdJob()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobId", DbType="TinyInt NOT NULL", IsPrimaryKey=true)]
		public byte JobId
		{
			get
			{
				return this._JobId;
			}
			set
			{
				if ((this._JobId != value))
				{
					this.OnJobIdChanging(value);
					this.SendPropertyChanging();
					this._JobId = value;
					this.SendPropertyChanged("JobId");
					this.OnJobIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JobName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string JobName
		{
			get
			{
				return this._JobName;
			}
			set
			{
				if ((this._JobName != value))
				{
					this.OnJobNameChanging(value);
					this.SendPropertyChanging();
					this._JobName = value;
					this.SendPropertyChanged("JobName");
					this.OnJobNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CdDepertment")]
	public partial class CdDepertment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _DepertmentId;
		
		private string _Depertment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDepertmentIdChanging(byte value);
    partial void OnDepertmentIdChanged();
    partial void OnDepertmentChanging(string value);
    partial void OnDepertmentChanged();
    #endregion
		
		public CdDepertment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepertmentId", DbType="TinyInt NOT NULL", IsPrimaryKey=true)]
		public byte DepertmentId
		{
			get
			{
				return this._DepertmentId;
			}
			set
			{
				if ((this._DepertmentId != value))
				{
					this.OnDepertmentIdChanging(value);
					this.SendPropertyChanging();
					this._DepertmentId = value;
					this.SendPropertyChanged("DepertmentId");
					this.OnDepertmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Depertment", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Depertment
		{
			get
			{
				return this._Depertment;
			}
			set
			{
				if ((this._Depertment != value))
				{
					this.OnDepertmentChanging(value);
					this.SendPropertyChanging();
					this._Depertment = value;
					this.SendPropertyChanged("Depertment");
					this.OnDepertmentChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CdAssetplace")]
	public partial class CdAssetplace : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AssetplaceId;
		
		private string _Assetplace;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAssetplaceIdChanging(int value);
    partial void OnAssetplaceIdChanged();
    partial void OnAssetplaceChanging(string value);
    partial void OnAssetplaceChanged();
    #endregion
		
		public CdAssetplace()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetplaceId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AssetplaceId
		{
			get
			{
				return this._AssetplaceId;
			}
			set
			{
				if ((this._AssetplaceId != value))
				{
					this.OnAssetplaceIdChanging(value);
					this.SendPropertyChanging();
					this._AssetplaceId = value;
					this.SendPropertyChanged("AssetplaceId");
					this.OnAssetplaceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Assetplace", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Assetplace
		{
			get
			{
				return this._Assetplace;
			}
			set
			{
				if ((this._Assetplace != value))
				{
					this.OnAssetplaceChanging(value);
					this.SendPropertyChanging();
					this._Assetplace = value;
					this.SendPropertyChanged("Assetplace");
					this.OnAssetplaceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CdAssetState")]
	public partial class CdAssetState : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _AssetStateId;
		
		private string _AssetState;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAssetStateIdChanging(byte value);
    partial void OnAssetStateIdChanged();
    partial void OnAssetStateChanging(string value);
    partial void OnAssetStateChanged();
    #endregion
		
		public CdAssetState()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetStateId", DbType="TinyInt NOT NULL", IsPrimaryKey=true)]
		public byte AssetStateId
		{
			get
			{
				return this._AssetStateId;
			}
			set
			{
				if ((this._AssetStateId != value))
				{
					this.OnAssetStateIdChanging(value);
					this.SendPropertyChanging();
					this._AssetStateId = value;
					this.SendPropertyChanged("AssetStateId");
					this.OnAssetStateIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetState", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string AssetState
		{
			get
			{
				return this._AssetState;
			}
			set
			{
				if ((this._AssetState != value))
				{
					this.OnAssetStateChanging(value);
					this.SendPropertyChanging();
					this._AssetState = value;
					this.SendPropertyChanged("AssetState");
					this.OnAssetStateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CdAssetPropertiy")]
	public partial class CdAssetPropertiy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _AssetPropertiyId;
		
		private string _AssetPropertiy;
		
		private string _AssetPropertiyDes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAssetPropertiyIdChanging(byte value);
    partial void OnAssetPropertiyIdChanged();
    partial void OnAssetPropertiyChanging(string value);
    partial void OnAssetPropertiyChanged();
    partial void OnAssetPropertiyDesChanging(string value);
    partial void OnAssetPropertiyDesChanged();
    #endregion
		
		public CdAssetPropertiy()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetPropertiyId", DbType="TinyInt NOT NULL", IsPrimaryKey=true)]
		public byte AssetPropertiyId
		{
			get
			{
				return this._AssetPropertiyId;
			}
			set
			{
				if ((this._AssetPropertiyId != value))
				{
					this.OnAssetPropertiyIdChanging(value);
					this.SendPropertyChanging();
					this._AssetPropertiyId = value;
					this.SendPropertyChanged("AssetPropertiyId");
					this.OnAssetPropertiyIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetPropertiy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string AssetPropertiy
		{
			get
			{
				return this._AssetPropertiy;
			}
			set
			{
				if ((this._AssetPropertiy != value))
				{
					this.OnAssetPropertiyChanging(value);
					this.SendPropertyChanging();
					this._AssetPropertiy = value;
					this.SendPropertyChanged("AssetPropertiy");
					this.OnAssetPropertiyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssetPropertiyDes", DbType="NVarChar(50)")]
		public string AssetPropertiyDes
		{
			get
			{
				return this._AssetPropertiyDes;
			}
			set
			{
				if ((this._AssetPropertiyDes != value))
				{
					this.OnAssetPropertiyDesChanging(value);
					this.SendPropertyChanging();
					this._AssetPropertiyDes = value;
					this.SendPropertyChanged("AssetPropertiyDes");
					this.OnAssetPropertiyDesChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
