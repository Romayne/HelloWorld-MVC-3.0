﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloWorldDatabaseAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MySandboxDatabase")]
	public partial class DatabaseAccessLINQtoSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertComment(Comment instance);
    partial void UpdateComment(Comment instance);
    partial void DeleteComment(Comment instance);
    #endregion
		
		public DatabaseAccessLINQtoSQLDataContext() : 
				base(global::HelloWorldDatabaseAccess.Properties.Settings.Default.MySandboxDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAccessLINQtoSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAccessLINQtoSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAccessLINQtoSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseAccessLINQtoSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Comment> Comments
		{
			get
			{
				return this.GetTable<Comment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comments")]
	public partial class Comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _ApplicationId;
		
		private string _Creator;
		
		private string _Details;
		
		private bool _IsPublic;
		
		private System.DateTime _Created;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnApplicationIdChanging(int value);
    partial void OnApplicationIdChanged();
    partial void OnCreatorChanging(string value);
    partial void OnCreatorChanged();
    partial void OnDetailsChanging(string value);
    partial void OnDetailsChanged();
    partial void OnIsPublicChanging(bool value);
    partial void OnIsPublicChanged();
    partial void OnCreatedChanging(System.DateTime value);
    partial void OnCreatedChanged();
    #endregion
		
		public Comment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApplicationId", DbType="Int NOT NULL")]
		public int ApplicationId
		{
			get
			{
				return this._ApplicationId;
			}
			set
			{
				if ((this._ApplicationId != value))
				{
					this.OnApplicationIdChanging(value);
					this.SendPropertyChanging();
					this._ApplicationId = value;
					this.SendPropertyChanged("ApplicationId");
					this.OnApplicationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Creator", DbType="VarChar(255)")]
		public string Creator
		{
			get
			{
				return this._Creator;
			}
			set
			{
				if ((this._Creator != value))
				{
					this.OnCreatorChanging(value);
					this.SendPropertyChanging();
					this._Creator = value;
					this.SendPropertyChanged("Creator");
					this.OnCreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Details", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Details
		{
			get
			{
				return this._Details;
			}
			set
			{
				if ((this._Details != value))
				{
					this.OnDetailsChanging(value);
					this.SendPropertyChanging();
					this._Details = value;
					this.SendPropertyChanged("Details");
					this.OnDetailsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsPublic", DbType="Bit NOT NULL")]
		public bool IsPublic
		{
			get
			{
				return this._IsPublic;
			}
			set
			{
				if ((this._IsPublic != value))
				{
					this.OnIsPublicChanging(value);
					this.SendPropertyChanging();
					this._IsPublic = value;
					this.SendPropertyChanged("IsPublic");
					this.OnIsPublicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime NOT NULL")]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
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
