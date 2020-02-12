﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _0128_Vibrometer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VibrometerDB")]
	public partial class VibrometerDBClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 확장성 메서드 정의
    partial void OnCreated();
    partial void InsertChannel(Channel instance);
    partial void UpdateChannel(Channel instance);
    partial void DeleteChannel(Channel instance);
    partial void InsertWaveData(WaveData instance);
    partial void UpdateWaveData(WaveData instance);
    partial void DeleteWaveData(WaveData instance);
    partial void InsertTrendData(TrendData instance);
    partial void UpdateTrendData(TrendData instance);
    partial void DeleteTrendData(TrendData instance);
    partial void InsertTrendConfig(TrendConfig instance);
    partial void UpdateTrendConfig(TrendConfig instance);
    partial void DeleteTrendConfig(TrendConfig instance);
    #endregion
		
		public VibrometerDBClassDataContext() : 
				base(global::_0128_Vibrometer.Properties.Settings.Default.VibrometerDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VibrometerDBClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VibrometerDBClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VibrometerDBClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VibrometerDBClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Channel> Channel
		{
			get
			{
				return this.GetTable<Channel>();
			}
		}
		
		public System.Data.Linq.Table<WaveData> WaveData
		{
			get
			{
				return this.GetTable<WaveData>();
			}
		}
		
		public System.Data.Linq.Table<TrendData> TrendData
		{
			get
			{
				return this.GetTable<TrendData>();
			}
		}
		
		public System.Data.Linq.Table<TrendConfig> TrendConfig
		{
			get
			{
				return this.GetTable<TrendConfig>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Channel")]
	public partial class Channel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _name;
		
		private int _sample_rate;
		
    #region 확장성 메서드 정의
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void Onsample_rateChanging(int value);
    partial void Onsample_rateChanged();
    #endregion
		
		public Channel()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sample_rate", DbType="Int")]
		public int sample_rate
		{
			get
			{
				return this._sample_rate;
			}
			set
			{
				if ((this._sample_rate != value))
				{
					this.Onsample_rateChanging(value);
					this.SendPropertyChanging();
					this._sample_rate = value;
					this.SendPropertyChanged("sample_rate");
					this.Onsample_rateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WaveData_TB")]
	public partial class WaveData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _channel_Id;
		
		private System.Data.Linq.Binary _data;
		
    #region 확장성 메서드 정의
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Onchannel_IdChanging(int value);
    partial void Onchannel_IdChanged();
    partial void OndataChanging(System.Data.Linq.Binary value);
    partial void OndataChanged();
    #endregion
		
		public WaveData()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_channel_Id", DbType="Int")]
		public int channel_Id
		{
			get
			{
				return this._channel_Id;
			}
			set
			{
				if ((this._channel_Id != value))
				{
					this.Onchannel_IdChanging(value);
					this.SendPropertyChanging();
					this._channel_Id = value;
					this.SendPropertyChanged("channel_Id");
					this.Onchannel_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data", DbType="VarBinary(MAX)", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((this._data != value))
				{
					this.OndataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("data");
					this.OndataChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TrendData")]
	public partial class TrendData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _trendConfig_Id;
		
		private System.DateTime _time;
		
		private double _value;
		
    #region 확장성 메서드 정의
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OntrendConfig_IdChanging(int value);
    partial void OntrendConfig_IdChanged();
    partial void OnTimeChanging(System.DateTime value);
    partial void OnTimeChanged();
    partial void OnValueChanging(double value);
    partial void OnValueChanged();
    #endregion
		
		public TrendData()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trendConfig_Id", DbType="Int")]
		public int trendConfig_Id
		{
			get
			{
				return this._trendConfig_Id;
			}
			set
			{
				if ((this._trendConfig_Id != value))
				{
					this.OntrendConfig_IdChanging(value);
					this.SendPropertyChanging();
					this._trendConfig_Id = value;
					this.SendPropertyChanged("trendConfig_Id");
					this.OntrendConfig_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="time", Storage="_time", DbType="DateTime2")]
		public System.DateTime Time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="value", Storage="_value", DbType="Float")]
		public double Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TrendConfig")]
	[global::System.Data.Linq.Mapping.InheritanceMappingAttribute(Code="1", Type=typeof(TrendConfig), IsDefault=true)]
	[global::System.Data.Linq.Mapping.InheritanceMappingAttribute(Code="2", Type=typeof(RmsConfig))]
	[global::System.Data.Linq.Mapping.InheritanceMappingAttribute(Code="3", Type=typeof(PeakConfig))]
	public partial class TrendConfig : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _type;
		
		private string _name;
		
    #region 확장성 메서드 정의
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OntypeChanging(int value);
    partial void OntypeChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public TrendConfig()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="Int", IsDiscriminator=true)]
		public int type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50)", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
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
	
	public partial class RmsConfig : TrendConfig
	{
		
		private System.Nullable<int> _start;
		
		private System.Nullable<int> _end;
		
    #region 확장성 메서드 정의
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstartChanging(System.Nullable<int> value);
    partial void OnstartChanged();
    partial void OnendChanging(System.Nullable<int> value);
    partial void OnendChanged();
    #endregion
		
		public RmsConfig()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_start", DbType="Int")]
		public System.Nullable<int> start
		{
			get
			{
				return this._start;
			}
			set
			{
				if ((this._start != value))
				{
					this.OnstartChanging(value);
					this.SendPropertyChanging();
					this._start = value;
					this.SendPropertyChanged("start");
					this.OnstartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[end]", Storage="_end", DbType="Int")]
		public System.Nullable<int> end
		{
			get
			{
				return this._end;
			}
			set
			{
				if ((this._end != value))
				{
					this.OnendChanging(value);
					this.SendPropertyChanging();
					this._end = value;
					this.SendPropertyChanged("end");
					this.OnendChanged();
				}
			}
		}
	}
	
	public partial class PeakConfig : TrendConfig
	{
		
		private string _option;
		
    #region 확장성 메서드 정의
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnoptionChanging(string value);
    partial void OnoptionChanged();
    #endregion
		
		public PeakConfig()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[option]", Storage="_option", DbType="VarChar(50)")]
		public string option
		{
			get
			{
				return this._option;
			}
			set
			{
				if ((this._option != value))
				{
					this.OnoptionChanging(value);
					this.SendPropertyChanging();
					this._option = value;
					this.SendPropertyChanged("option");
					this.OnoptionChanged();
				}
			}
		}
	}
}
#pragma warning restore 1591
