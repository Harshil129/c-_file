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

namespace WindowsFormsApp1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="myDatabase")]
	public partial class myDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertDept(Dept instance);
    partial void UpdateDept(Dept instance);
    partial void DeleteDept(Dept instance);
    partial void InsertEmp(Emp instance);
    partial void UpdateEmp(Emp instance);
    partial void DeleteEmp(Emp instance);
    #endregion
		
		public myDatabaseDataContext() : 
				base(global::WindowsFormsApp1.Properties.Settings.Default.myDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public myDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public myDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public myDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public myDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Dept> Depts
		{
			get
			{
				return this.GetTable<Dept>();
			}
		}
		
		public System.Data.Linq.Table<Emp> Emps
		{
			get
			{
				return this.GetTable<Emp>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Eno;
		
		private string _Ename;
		
		private string _Job;
		
		private System.Nullable<decimal> _Salary;
		
		private string _Dname;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEnoChanging(int value);
    partial void OnEnoChanged();
    partial void OnEnameChanging(string value);
    partial void OnEnameChanged();
    partial void OnJobChanging(string value);
    partial void OnJobChanged();
    partial void OnSalaryChanging(System.Nullable<decimal> value);
    partial void OnSalaryChanged();
    partial void OnDnameChanging(string value);
    partial void OnDnameChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Eno", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Eno
		{
			get
			{
				return this._Eno;
			}
			set
			{
				if ((this._Eno != value))
				{
					this.OnEnoChanging(value);
					this.SendPropertyChanging();
					this._Eno = value;
					this.SendPropertyChanged("Eno");
					this.OnEnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ename", DbType="VarChar(50)")]
		public string Ename
		{
			get
			{
				return this._Ename;
			}
			set
			{
				if ((this._Ename != value))
				{
					this.OnEnameChanging(value);
					this.SendPropertyChanging();
					this._Ename = value;
					this.SendPropertyChanged("Ename");
					this.OnEnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job", DbType="VarChar(50)")]
		public string Job
		{
			get
			{
				return this._Job;
			}
			set
			{
				if ((this._Job != value))
				{
					this.OnJobChanging(value);
					this.SendPropertyChanging();
					this._Job = value;
					this.SendPropertyChanged("Job");
					this.OnJobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Money")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dname", DbType="VarChar(50)")]
		public string Dname
		{
			get
			{
				return this._Dname;
			}
			set
			{
				if ((this._Dname != value))
				{
					this.OnDnameChanging(value);
					this.SendPropertyChanging();
					this._Dname = value;
					this.SendPropertyChanged("Dname");
					this.OnDnameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dept")]
	public partial class Dept : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Deptno;
		
		private string _Dname;
		
		private string _Loc;
		
		private EntitySet<Emp> _Emps;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDeptnoChanging(int value);
    partial void OnDeptnoChanged();
    partial void OnDnameChanging(string value);
    partial void OnDnameChanged();
    partial void OnLocChanging(string value);
    partial void OnLocChanged();
    #endregion
		
		public Dept()
		{
			this._Emps = new EntitySet<Emp>(new Action<Emp>(this.attach_Emps), new Action<Emp>(this.detach_Emps));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Deptno", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Deptno
		{
			get
			{
				return this._Deptno;
			}
			set
			{
				if ((this._Deptno != value))
				{
					this.OnDeptnoChanging(value);
					this.SendPropertyChanging();
					this._Deptno = value;
					this.SendPropertyChanged("Deptno");
					this.OnDeptnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dname", DbType="VarChar(50)")]
		public string Dname
		{
			get
			{
				return this._Dname;
			}
			set
			{
				if ((this._Dname != value))
				{
					this.OnDnameChanging(value);
					this.SendPropertyChanging();
					this._Dname = value;
					this.SendPropertyChanged("Dname");
					this.OnDnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Loc", DbType="VarChar(50)")]
		public string Loc
		{
			get
			{
				return this._Loc;
			}
			set
			{
				if ((this._Loc != value))
				{
					this.OnLocChanging(value);
					this.SendPropertyChanging();
					this._Loc = value;
					this.SendPropertyChanged("Loc");
					this.OnLocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dept_Emp", Storage="_Emps", ThisKey="Deptno", OtherKey="Deptno")]
		public EntitySet<Emp> Emps
		{
			get
			{
				return this._Emps;
			}
			set
			{
				this._Emps.Assign(value);
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
		
		private void attach_Emps(Emp entity)
		{
			this.SendPropertyChanging();
			entity.Dept = this;
		}
		
		private void detach_Emps(Emp entity)
		{
			this.SendPropertyChanging();
			entity.Dept = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Emp")]
	public partial class Emp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Empno;
		
		private string _Ename;
		
		private string _Job;
		
		private string _Mgr;
		
		private System.Nullable<System.DateTime> _HireDate;
		
		private System.Nullable<decimal> _Salary;
		
		private int _Deptno;
		
		private EntityRef<Dept> _Dept;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpnoChanging(int value);
    partial void OnEmpnoChanged();
    partial void OnEnameChanging(string value);
    partial void OnEnameChanged();
    partial void OnJobChanging(string value);
    partial void OnJobChanged();
    partial void OnMgrChanging(string value);
    partial void OnMgrChanged();
    partial void OnHireDateChanging(System.Nullable<System.DateTime> value);
    partial void OnHireDateChanged();
    partial void OnSalaryChanging(System.Nullable<decimal> value);
    partial void OnSalaryChanged();
    partial void OnDeptnoChanging(int value);
    partial void OnDeptnoChanged();
    #endregion
		
		public Emp()
		{
			this._Dept = default(EntityRef<Dept>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empno", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Empno
		{
			get
			{
				return this._Empno;
			}
			set
			{
				if ((this._Empno != value))
				{
					this.OnEmpnoChanging(value);
					this.SendPropertyChanging();
					this._Empno = value;
					this.SendPropertyChanged("Empno");
					this.OnEmpnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ename", DbType="VarChar(50)")]
		public string Ename
		{
			get
			{
				return this._Ename;
			}
			set
			{
				if ((this._Ename != value))
				{
					this.OnEnameChanging(value);
					this.SendPropertyChanging();
					this._Ename = value;
					this.SendPropertyChanged("Ename");
					this.OnEnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Job", DbType="VarChar(50)")]
		public string Job
		{
			get
			{
				return this._Job;
			}
			set
			{
				if ((this._Job != value))
				{
					this.OnJobChanging(value);
					this.SendPropertyChanging();
					this._Job = value;
					this.SendPropertyChanged("Job");
					this.OnJobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mgr", DbType="VarChar(50)")]
		public string Mgr
		{
			get
			{
				return this._Mgr;
			}
			set
			{
				if ((this._Mgr != value))
				{
					this.OnMgrChanging(value);
					this.SendPropertyChanging();
					this._Mgr = value;
					this.SendPropertyChanged("Mgr");
					this.OnMgrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HireDate", DbType="Date")]
		public System.Nullable<System.DateTime> HireDate
		{
			get
			{
				return this._HireDate;
			}
			set
			{
				if ((this._HireDate != value))
				{
					this.OnHireDateChanging(value);
					this.SendPropertyChanging();
					this._HireDate = value;
					this.SendPropertyChanged("HireDate");
					this.OnHireDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Money")]
		public System.Nullable<decimal> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Deptno", DbType="Int NOT NULL")]
		public int Deptno
		{
			get
			{
				return this._Deptno;
			}
			set
			{
				if ((this._Deptno != value))
				{
					if (this._Dept.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDeptnoChanging(value);
					this.SendPropertyChanging();
					this._Deptno = value;
					this.SendPropertyChanged("Deptno");
					this.OnDeptnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dept_Emp", Storage="_Dept", ThisKey="Deptno", OtherKey="Deptno", IsForeignKey=true)]
		public Dept Dept
		{
			get
			{
				return this._Dept.Entity;
			}
			set
			{
				Dept previousValue = this._Dept.Entity;
				if (((previousValue != value) 
							|| (this._Dept.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Dept.Entity = null;
						previousValue.Emps.Remove(this);
					}
					this._Dept.Entity = value;
					if ((value != null))
					{
						value.Emps.Add(this);
						this._Deptno = value.Deptno;
					}
					else
					{
						this._Deptno = default(int);
					}
					this.SendPropertyChanged("Dept");
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
