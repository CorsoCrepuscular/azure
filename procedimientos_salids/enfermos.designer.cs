﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace procedimientos_salida
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="hospital")]
	public partial class enfermosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public enfermosDataContext() : 
				base(global::procedimientos_salida.Properties.Settings.Default.hospitalConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public enfermosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public enfermosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public enfermosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public enfermosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ENFERMO> ENFERMO
		{
			get
			{
				return this.GetTable<ENFERMO>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CONSULTANOMBRE")]
		public ISingleResult<CONSULTANOMBREResult> CONSULTANOMBRE([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NSS", DbType="NVarChar(50)")] string nSS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="APELLIDO", DbType="NVarChar(50)")] ref string aPELLIDO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="S", DbType="NVarChar(50)")] ref string s)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nSS, aPELLIDO, s);
			aPELLIDO = ((string)(result.GetParameterValue(1)));
			s = ((string)(result.GetParameterValue(2)));
			return ((ISingleResult<CONSULTANOMBREResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CONSULTANOMBRE2")]
		public int CONSULTANOMBRE2([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NSS", DbType="NVarChar(50)")] string nSS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="APELLIDO", DbType="NVarChar(50)")] ref string aPELLIDO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="S", DbType="NVarChar(50)")] ref string s)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nSS, aPELLIDO, s);
			aPELLIDO = ((string)(result.GetParameterValue(1)));
			s = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ENFERMO")]
	public partial class ENFERMO
	{
		
		private string _INSCRIPCION;
		
		private string _APELLIDO;
		
		private string _DIRECCION;
		
		private System.Nullable<System.DateTime> _FECHA_NAC;
		
		private string _S;
		
		private string _NSS;
		
		public ENFERMO()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INSCRIPCION", DbType="NVarChar(50)")]
		public string INSCRIPCION
		{
			get
			{
				return this._INSCRIPCION;
			}
			set
			{
				if ((this._INSCRIPCION != value))
				{
					this._INSCRIPCION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDO", DbType="NVarChar(50)")]
		public string APELLIDO
		{
			get
			{
				return this._APELLIDO;
			}
			set
			{
				if ((this._APELLIDO != value))
				{
					this._APELLIDO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIRECCION", DbType="NVarChar(50)")]
		public string DIRECCION
		{
			get
			{
				return this._DIRECCION;
			}
			set
			{
				if ((this._DIRECCION != value))
				{
					this._DIRECCION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_NAC", DbType="DateTime")]
		public System.Nullable<System.DateTime> FECHA_NAC
		{
			get
			{
				return this._FECHA_NAC;
			}
			set
			{
				if ((this._FECHA_NAC != value))
				{
					this._FECHA_NAC = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S", DbType="NVarChar(50)")]
		public string S
		{
			get
			{
				return this._S;
			}
			set
			{
				if ((this._S != value))
				{
					this._S = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NSS", DbType="NVarChar(50)")]
		public string NSS
		{
			get
			{
				return this._NSS;
			}
			set
			{
				if ((this._NSS != value))
				{
					this._NSS = value;
				}
			}
		}
	}
	
	public partial class CONSULTANOMBREResult
	{
		
		private string _APELLIDO;
		
		private string _S;
		
		public CONSULTANOMBREResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDO", DbType="NVarChar(50)")]
		public string APELLIDO
		{
			get
			{
				return this._APELLIDO;
			}
			set
			{
				if ((this._APELLIDO != value))
				{
					this._APELLIDO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S", DbType="NVarChar(50)")]
		public string S
		{
			get
			{
				return this._S;
			}
			set
			{
				if ((this._S != value))
				{
					this._S = value;
				}
			}
		}
	}
}
#pragma warning restore 1591