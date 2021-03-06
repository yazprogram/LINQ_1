﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="OKUL")]
public partial class LINQORNEKDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertOGRENCI(OGRENCI instance);
  partial void UpdateOGRENCI(OGRENCI instance);
  partial void DeleteOGRENCI(OGRENCI instance);
  #endregion
	
	public LINQORNEKDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["OKULConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public LINQORNEKDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LINQORNEKDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LINQORNEKDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LINQORNEKDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<OGRENCI> OGRENCIs
	{
		get
		{
			return this.GetTable<OGRENCI>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OGRENCI")]
public partial class OGRENCI : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _AD;
	
	private string _SOYAD;
	
	private string _EPOSTA;
	
	private string _TELEFON;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnADChanging(string value);
    partial void OnADChanged();
    partial void OnSOYADChanging(string value);
    partial void OnSOYADChanged();
    partial void OnEPOSTAChanging(string value);
    partial void OnEPOSTAChanged();
    partial void OnTELEFONChanging(string value);
    partial void OnTELEFONChanged();
    #endregion
	
	public OGRENCI()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AD", DbType="NVarChar(20)")]
	public string AD
	{
		get
		{
			return this._AD;
		}
		set
		{
			if ((this._AD != value))
			{
				this.OnADChanging(value);
				this.SendPropertyChanging();
				this._AD = value;
				this.SendPropertyChanged("AD");
				this.OnADChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOYAD", DbType="NVarChar(30)")]
	public string SOYAD
	{
		get
		{
			return this._SOYAD;
		}
		set
		{
			if ((this._SOYAD != value))
			{
				this.OnSOYADChanging(value);
				this.SendPropertyChanging();
				this._SOYAD = value;
				this.SendPropertyChanged("SOYAD");
				this.OnSOYADChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EPOSTA", DbType="NVarChar(50)")]
	public string EPOSTA
	{
		get
		{
			return this._EPOSTA;
		}
		set
		{
			if ((this._EPOSTA != value))
			{
				this.OnEPOSTAChanging(value);
				this.SendPropertyChanging();
				this._EPOSTA = value;
				this.SendPropertyChanged("EPOSTA");
				this.OnEPOSTAChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TELEFON", DbType="NVarChar(50)")]
	public string TELEFON
	{
		get
		{
			return this._TELEFON;
		}
		set
		{
			if ((this._TELEFON != value))
			{
				this.OnTELEFONChanging(value);
				this.SendPropertyChanging();
				this._TELEFON = value;
				this.SendPropertyChanged("TELEFON");
				this.OnTELEFONChanged();
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
#pragma warning restore 1591
