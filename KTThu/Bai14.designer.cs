﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KTThu
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Test_Config")]
	public partial class Bai14DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCOSO(COSO instance);
    partial void UpdateCOSO(COSO instance);
    partial void DeleteCOSO(COSO instance);
    partial void InsertGV(GV instance);
    partial void UpdateGV(GV instance);
    partial void DeleteGV(GV instance);
    partial void InsertDONVI(DONVI instance);
    partial void UpdateDONVI(DONVI instance);
    partial void DeleteDONVI(DONVI instance);
    #endregion
		
		public Bai14DataContext() : 
				base(global::KTThu.Properties.Settings.Default.Test_ConfigConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Bai14DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bai14DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bai14DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Bai14DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<COSO> COSOs
		{
			get
			{
				return this.GetTable<COSO>();
			}
		}
		
		public System.Data.Linq.Table<GV> GVs
		{
			get
			{
				return this.GetTable<GV>();
			}
		}
		
		public System.Data.Linq.Table<DONVI> DONVIs
		{
			get
			{
				return this.GetTable<DONVI>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.COSO")]
	public partial class COSO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _macoso;
		
		private string _tencoso;
		
		private EntitySet<DONVI> _DONVIs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmacosoChanging(string value);
    partial void OnmacosoChanged();
    partial void OntencosoChanging(string value);
    partial void OntencosoChanged();
    #endregion
		
		public COSO()
		{
			this._DONVIs = new EntitySet<DONVI>(new Action<DONVI>(this.attach_DONVIs), new Action<DONVI>(this.detach_DONVIs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_macoso", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string macoso
		{
			get
			{
				return this._macoso;
			}
			set
			{
				if ((this._macoso != value))
				{
					this.OnmacosoChanging(value);
					this.SendPropertyChanging();
					this._macoso = value;
					this.SendPropertyChanged("macoso");
					this.OnmacosoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tencoso", DbType="NVarChar(MAX)")]
		public string tencoso
		{
			get
			{
				return this._tencoso;
			}
			set
			{
				if ((this._tencoso != value))
				{
					this.OntencosoChanging(value);
					this.SendPropertyChanging();
					this._tencoso = value;
					this.SendPropertyChanged("tencoso");
					this.OntencosoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="COSO_DONVI", Storage="_DONVIs", ThisKey="macoso", OtherKey="macoso")]
		public EntitySet<DONVI> DONVIs
		{
			get
			{
				return this._DONVIs;
			}
			set
			{
				this._DONVIs.Assign(value);
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
		
		private void attach_DONVIs(DONVI entity)
		{
			this.SendPropertyChanging();
			entity.COSO = this;
		}
		
		private void detach_DONVIs(DONVI entity)
		{
			this.SendPropertyChanging();
			entity.COSO = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GV")]
	public partial class GV : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _masv;
		
		private string _hoten;
		
		private string _sdt;
		
		private string _ghichu;
		
		private string _madonvi;
		
		private EntityRef<DONVI> _DONVI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmasvChanging(string value);
    partial void OnmasvChanged();
    partial void OnhotenChanging(string value);
    partial void OnhotenChanged();
    partial void OnsdtChanging(string value);
    partial void OnsdtChanged();
    partial void OnghichuChanging(string value);
    partial void OnghichuChanged();
    partial void OnmadonviChanging(string value);
    partial void OnmadonviChanged();
    #endregion
		
		public GV()
		{
			this._DONVI = default(EntityRef<DONVI>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_masv", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string masv
		{
			get
			{
				return this._masv;
			}
			set
			{
				if ((this._masv != value))
				{
					this.OnmasvChanging(value);
					this.SendPropertyChanging();
					this._masv = value;
					this.SendPropertyChanged("masv");
					this.OnmasvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoten", DbType="NVarChar(MAX)")]
		public string hoten
		{
			get
			{
				return this._hoten;
			}
			set
			{
				if ((this._hoten != value))
				{
					this.OnhotenChanging(value);
					this.SendPropertyChanging();
					this._hoten = value;
					this.SendPropertyChanged("hoten");
					this.OnhotenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdt", DbType="NChar(11) NOT NULL", CanBeNull=false)]
		public string sdt
		{
			get
			{
				return this._sdt;
			}
			set
			{
				if ((this._sdt != value))
				{
					this.OnsdtChanging(value);
					this.SendPropertyChanging();
					this._sdt = value;
					this.SendPropertyChanged("sdt");
					this.OnsdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ghichu", DbType="NVarChar(MAX)")]
		public string ghichu
		{
			get
			{
				return this._ghichu;
			}
			set
			{
				if ((this._ghichu != value))
				{
					this.OnghichuChanging(value);
					this.SendPropertyChanging();
					this._ghichu = value;
					this.SendPropertyChanged("ghichu");
					this.OnghichuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_madonvi", DbType="NVarChar(50)")]
		public string madonvi
		{
			get
			{
				return this._madonvi;
			}
			set
			{
				if ((this._madonvi != value))
				{
					if (this._DONVI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmadonviChanging(value);
					this.SendPropertyChanging();
					this._madonvi = value;
					this.SendPropertyChanged("madonvi");
					this.OnmadonviChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONVI_GV", Storage="_DONVI", ThisKey="madonvi", OtherKey="madonvi", IsForeignKey=true)]
		public DONVI DONVI
		{
			get
			{
				return this._DONVI.Entity;
			}
			set
			{
				DONVI previousValue = this._DONVI.Entity;
				if (((previousValue != value) 
							|| (this._DONVI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DONVI.Entity = null;
						previousValue.GVs.Remove(this);
					}
					this._DONVI.Entity = value;
					if ((value != null))
					{
						value.GVs.Add(this);
						this._madonvi = value.madonvi;
					}
					else
					{
						this._madonvi = default(string);
					}
					this.SendPropertyChanged("DONVI");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONVI")]
	public partial class DONVI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _madonvi;
		
		private string _tendonvi;
		
		private string _macoso;
		
		private EntitySet<GV> _GVs;
		
		private EntityRef<COSO> _COSO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmadonviChanging(string value);
    partial void OnmadonviChanged();
    partial void OntendonviChanging(string value);
    partial void OntendonviChanged();
    partial void OnmacosoChanging(string value);
    partial void OnmacosoChanged();
    #endregion
		
		public DONVI()
		{
			this._GVs = new EntitySet<GV>(new Action<GV>(this.attach_GVs), new Action<GV>(this.detach_GVs));
			this._COSO = default(EntityRef<COSO>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_madonvi", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string madonvi
		{
			get
			{
				return this._madonvi;
			}
			set
			{
				if ((this._madonvi != value))
				{
					this.OnmadonviChanging(value);
					this.SendPropertyChanging();
					this._madonvi = value;
					this.SendPropertyChanged("madonvi");
					this.OnmadonviChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tendonvi", DbType="NVarChar(MAX)")]
		public string tendonvi
		{
			get
			{
				return this._tendonvi;
			}
			set
			{
				if ((this._tendonvi != value))
				{
					this.OntendonviChanging(value);
					this.SendPropertyChanging();
					this._tendonvi = value;
					this.SendPropertyChanged("tendonvi");
					this.OntendonviChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_macoso", DbType="NVarChar(50)")]
		public string macoso
		{
			get
			{
				return this._macoso;
			}
			set
			{
				if ((this._macoso != value))
				{
					if (this._COSO.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmacosoChanging(value);
					this.SendPropertyChanging();
					this._macoso = value;
					this.SendPropertyChanged("macoso");
					this.OnmacosoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONVI_GV", Storage="_GVs", ThisKey="madonvi", OtherKey="madonvi")]
		public EntitySet<GV> GVs
		{
			get
			{
				return this._GVs;
			}
			set
			{
				this._GVs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="COSO_DONVI", Storage="_COSO", ThisKey="macoso", OtherKey="macoso", IsForeignKey=true)]
		public COSO COSO
		{
			get
			{
				return this._COSO.Entity;
			}
			set
			{
				COSO previousValue = this._COSO.Entity;
				if (((previousValue != value) 
							|| (this._COSO.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._COSO.Entity = null;
						previousValue.DONVIs.Remove(this);
					}
					this._COSO.Entity = value;
					if ((value != null))
					{
						value.DONVIs.Add(this);
						this._macoso = value.macoso;
					}
					else
					{
						this._macoso = default(string);
					}
					this.SendPropertyChanged("COSO");
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
		
		private void attach_GVs(GV entity)
		{
			this.SendPropertyChanging();
			entity.DONVI = this;
		}
		
		private void detach_GVs(GV entity)
		{
			this.SendPropertyChanging();
			entity.DONVI = null;
		}
	}
}
#pragma warning restore 1591
