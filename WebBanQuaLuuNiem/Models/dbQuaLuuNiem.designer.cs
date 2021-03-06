#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanQuaLuuNiem.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLBanQuaLuuNiem")]
	public partial class dbQuaLuuNiemDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertADMIN(ADMIN instance);
    partial void UpdateADMIN(ADMIN instance);
    partial void DeleteADMIN(ADMIN instance);
    partial void InsertChatLieu(ChatLieu instance);
    partial void UpdateChatLieu(ChatLieu instance);
    partial void DeleteChatLieu(ChatLieu instance);
    partial void InsertCTDatHang(CTDatHang instance);
    partial void UpdateCTDatHang(CTDatHang instance);
    partial void DeleteCTDatHang(CTDatHang instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertDonDatHang(DonDatHang instance);
    partial void UpdateDonDatHang(DonDatHang instance);
    partial void DeleteDonDatHang(DonDatHang instance);
    partial void InsertNhaCungCap(NhaCungCap instance);
    partial void UpdateNhaCungCap(NhaCungCap instance);
    partial void DeleteNhaCungCap(NhaCungCap instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    #endregion
		
		public dbQuaLuuNiemDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLBanQuaLuuNiemConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbQuaLuuNiemDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQuaLuuNiemDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQuaLuuNiemDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQuaLuuNiemDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ADMIN> ADMINs
		{
			get
			{
				return this.GetTable<ADMIN>();
			}
		}
		
		public System.Data.Linq.Table<ChatLieu> ChatLieus
		{
			get
			{
				return this.GetTable<ChatLieu>();
			}
		}
		
		public System.Data.Linq.Table<CTDatHang> CTDatHangs
		{
			get
			{
				return this.GetTable<CTDatHang>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<DonDatHang> DonDatHangs
		{
			get
			{
				return this.GetTable<DonDatHang>();
			}
		}
		
		public System.Data.Linq.Table<NhaCungCap> NhaCungCaps
		{
			get
			{
				return this.GetTable<NhaCungCap>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ADMIN")]
	public partial class ADMIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TKAdmin;
		
		private string _PassAdmin;
		
		private string _HoTen;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTKAdminChanging(string value);
    partial void OnTKAdminChanged();
    partial void OnPassAdminChanging(string value);
    partial void OnPassAdminChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    #endregion
		
		public ADMIN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TKAdmin", DbType="VarChar(24) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TKAdmin
		{
			get
			{
				return this._TKAdmin;
			}
			set
			{
				if ((this._TKAdmin != value))
				{
					this.OnTKAdminChanging(value);
					this.SendPropertyChanging();
					this._TKAdmin = value;
					this.SendPropertyChanged("TKAdmin");
					this.OnTKAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassAdmin", DbType="VarChar(24) NOT NULL", CanBeNull=false)]
		public string PassAdmin
		{
			get
			{
				return this._PassAdmin;
			}
			set
			{
				if ((this._PassAdmin != value))
				{
					this.OnPassAdminChanging(value);
					this.SendPropertyChanging();
					this._PassAdmin = value;
					this.SendPropertyChanged("PassAdmin");
					this.OnPassAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(30)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChatLieu")]
	public partial class ChatLieu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaChatLieu;
		
		private string _TenChatLieu;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChatLieuChanging(int value);
    partial void OnMaChatLieuChanged();
    partial void OnTenChatLieuChanging(string value);
    partial void OnTenChatLieuChanged();
    #endregion
		
		public ChatLieu()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChatLieu", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaChatLieu
		{
			get
			{
				return this._MaChatLieu;
			}
			set
			{
				if ((this._MaChatLieu != value))
				{
					this.OnMaChatLieuChanging(value);
					this.SendPropertyChanging();
					this._MaChatLieu = value;
					this.SendPropertyChanged("MaChatLieu");
					this.OnMaChatLieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenChatLieu", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenChatLieu
		{
			get
			{
				return this._TenChatLieu;
			}
			set
			{
				if ((this._TenChatLieu != value))
				{
					this.OnTenChatLieuChanging(value);
					this.SendPropertyChanging();
					this._TenChatLieu = value;
					this.SendPropertyChanged("TenChatLieu");
					this.OnTenChatLieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChatLieu_SanPham", Storage="_SanPhams", ThisKey="MaChatLieu", OtherKey="MaChatLieu")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.ChatLieu = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.ChatLieu = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTDatHang")]
	public partial class CTDatHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private int _MaSP;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<decimal> _DonGia;
		
		private EntityRef<DonDatHang> _DonDatHang;
		
		private EntityRef<SanPham> _SanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaChanging(System.Nullable<decimal> value);
    partial void OnDonGiaChanged();
    #endregion
		
		public CTDatHang()
		{
			this._DonDatHang = default(EntityRef<DonDatHang>);
			this._SanPham = default(EntityRef<SanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					if (this._DonDatHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					if (this._SanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonDatHang_CTDatHang", Storage="_DonDatHang", ThisKey="MaDonHang", OtherKey="MaDonHang", IsForeignKey=true)]
		public DonDatHang DonDatHang
		{
			get
			{
				return this._DonDatHang.Entity;
			}
			set
			{
				DonDatHang previousValue = this._DonDatHang.Entity;
				if (((previousValue != value) 
							|| (this._DonDatHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonDatHang.Entity = null;
						previousValue.CTDatHangs.Remove(this);
					}
					this._DonDatHang.Entity = value;
					if ((value != null))
					{
						value.CTDatHangs.Add(this);
						this._MaDonHang = value.MaDonHang;
					}
					else
					{
						this._MaDonHang = default(int);
					}
					this.SendPropertyChanged("DonDatHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_CTDatHang", Storage="_SanPham", ThisKey="MaSP", OtherKey="MaSP", IsForeignKey=true)]
		public SanPham SanPham
		{
			get
			{
				return this._SanPham.Entity;
			}
			set
			{
				SanPham previousValue = this._SanPham.Entity;
				if (((previousValue != value) 
							|| (this._SanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SanPham.Entity = null;
						previousValue.CTDatHangs.Remove(this);
					}
					this._SanPham.Entity = value;
					if ((value != null))
					{
						value.CTDatHangs.Add(this);
						this._MaSP = value.MaSP;
					}
					else
					{
						this._MaSP = default(int);
					}
					this.SendPropertyChanged("SanPham");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _HoTen;
		
		private string _TaiKhoan;
		
		private string _MatKhau;
		
		private string _SDT;
		
		private string _DiaChi;
		
		private EntitySet<DonDatHang> _DonDatHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    #endregion
		
		public KhachHang()
		{
			this._DonDatHangs = new EntitySet<DonDatHang>(new Action<DonDatHang>(this.attach_DonDatHangs), new Action<DonDatHang>(this.detach_DonDatHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="VarChar(24)")]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(24) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(12)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DonDatHang", Storage="_DonDatHangs", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<DonDatHang> DonDatHangs
		{
			get
			{
				return this._DonDatHangs;
			}
			set
			{
				this._DonDatHangs.Assign(value);
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
		
		private void attach_DonDatHangs(DonDatHang entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_DonDatHangs(DonDatHang entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonDatHang")]
	public partial class DonDatHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private System.Nullable<bool> _DaThanhToan;
		
		private System.Nullable<bool> _TinhTrangGiaoHang;
		
		private System.Nullable<System.DateTime> _NgayDat;
		
		private System.Nullable<System.DateTime> _NgayGiao;
		
		private System.Nullable<int> _MaKH;
		
		private EntitySet<CTDatHang> _CTDatHangs;
		
		private EntityRef<KhachHang> _KhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    partial void OnDaThanhToanChanging(System.Nullable<bool> value);
    partial void OnDaThanhToanChanged();
    partial void OnTinhTrangGiaoHangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangGiaoHangChanged();
    partial void OnNgayDatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayDatChanged();
    partial void OnNgayGiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayGiaoChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    #endregion
		
		public DonDatHang()
		{
			this._CTDatHangs = new EntitySet<CTDatHang>(new Action<CTDatHang>(this.attach_CTDatHangs), new Action<CTDatHang>(this.detach_CTDatHangs));
			this._KhachHang = default(EntityRef<KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaThanhToan", DbType="Bit")]
		public System.Nullable<bool> DaThanhToan
		{
			get
			{
				return this._DaThanhToan;
			}
			set
			{
				if ((this._DaThanhToan != value))
				{
					this.OnDaThanhToanChanging(value);
					this.SendPropertyChanging();
					this._DaThanhToan = value;
					this.SendPropertyChanged("DaThanhToan");
					this.OnDaThanhToanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrangGiaoHang", DbType="Bit")]
		public System.Nullable<bool> TinhTrangGiaoHang
		{
			get
			{
				return this._TinhTrangGiaoHang;
			}
			set
			{
				if ((this._TinhTrangGiaoHang != value))
				{
					this.OnTinhTrangGiaoHangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrangGiaoHang = value;
					this.SendPropertyChanged("TinhTrangGiaoHang");
					this.OnTinhTrangGiaoHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDat", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayDat
		{
			get
			{
				return this._NgayDat;
			}
			set
			{
				if ((this._NgayDat != value))
				{
					this.OnNgayDatChanging(value);
					this.SendPropertyChanging();
					this._NgayDat = value;
					this.SendPropertyChanged("NgayDat");
					this.OnNgayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayGiao", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayGiao
		{
			get
			{
				return this._NgayGiao;
			}
			set
			{
				if ((this._NgayGiao != value))
				{
					this.OnNgayGiaoChanging(value);
					this.SendPropertyChanging();
					this._NgayGiao = value;
					this.SendPropertyChanged("NgayGiao");
					this.OnNgayGiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonDatHang_CTDatHang", Storage="_CTDatHangs", ThisKey="MaDonHang", OtherKey="MaDonHang")]
		public EntitySet<CTDatHang> CTDatHangs
		{
			get
			{
				return this._CTDatHangs;
			}
			set
			{
				this._CTDatHangs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DonDatHang", Storage="_KhachHang", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.DonDatHangs.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.DonDatHangs.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KhachHang");
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
		
		private void attach_CTDatHangs(CTDatHang entity)
		{
			this.SendPropertyChanging();
			entity.DonDatHang = this;
		}
		
		private void detach_CTDatHangs(CTDatHang entity)
		{
			this.SendPropertyChanging();
			entity.DonDatHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhaCungCap")]
	public partial class NhaCungCap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNCC;
		
		private string _TenNCC;
		
		private string _DiaChi;
		
		private string _SDT;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNCCChanging(int value);
    partial void OnMaNCCChanged();
    partial void OnTenNCCChanging(string value);
    partial void OnTenNCCChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public NhaCungCap()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNCC", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNCC
		{
			get
			{
				return this._MaNCC;
			}
			set
			{
				if ((this._MaNCC != value))
				{
					this.OnMaNCCChanging(value);
					this.SendPropertyChanging();
					this._MaNCC = value;
					this.SendPropertyChanged("MaNCC");
					this.OnMaNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNCC", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNCC
		{
			get
			{
				return this._TenNCC;
			}
			set
			{
				if ((this._TenNCC != value))
				{
					this.OnTenNCCChanging(value);
					this.SendPropertyChanging();
					this._TenNCC = value;
					this.SendPropertyChanged("TenNCC");
					this.OnTenNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(12)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhaCungCap_SanPham", Storage="_SanPhams", ThisKey="MaNCC", OtherKey="MaNCC")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.NhaCungCap = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.NhaCungCap = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private string _TenSP;
		
		private decimal _GiaBan;
		
		private string _MoTa;
		
		private string _AnhBia;
		
		private System.Nullable<System.DateTime> _NgayCapNhat;
		
		private System.Nullable<int> _SoLuongTon;
		
		private System.Nullable<int> _MaNCC;
		
		private System.Nullable<int> _MaChatLieu;
		
		private EntitySet<CTDatHang> _CTDatHangs;
		
		private EntityRef<ChatLieu> _ChatLieu;
		
		private EntityRef<NhaCungCap> _NhaCungCap;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnGiaBanChanging(decimal value);
    partial void OnGiaBanChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    partial void OnAnhBiaChanging(string value);
    partial void OnAnhBiaChanged();
    partial void OnNgayCapNhatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayCapNhatChanged();
    partial void OnSoLuongTonChanging(System.Nullable<int> value);
    partial void OnSoLuongTonChanged();
    partial void OnMaNCCChanging(System.Nullable<int> value);
    partial void OnMaNCCChanged();
    partial void OnMaChatLieuChanging(System.Nullable<int> value);
    partial void OnMaChatLieuChanged();
    #endregion
		
		public SanPham()
		{
			this._CTDatHangs = new EntitySet<CTDatHang>(new Action<CTDatHang>(this.attach_CTDatHangs), new Action<CTDatHang>(this.detach_CTDatHangs));
			this._ChatLieu = default(EntityRef<ChatLieu>);
			this._NhaCungCap = default(EntityRef<NhaCungCap>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaBan", DbType="Decimal(18,0) NOT NULL")]
		public decimal GiaBan
		{
			get
			{
				return this._GiaBan;
			}
			set
			{
				if ((this._GiaBan != value))
				{
					this.OnGiaBanChanging(value);
					this.SendPropertyChanging();
					this._GiaBan = value;
					this.SendPropertyChanged("GiaBan");
					this.OnGiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(MAX)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnhBia", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string AnhBia
		{
			get
			{
				return this._AnhBia;
			}
			set
			{
				if ((this._AnhBia != value))
				{
					this.OnAnhBiaChanging(value);
					this.SendPropertyChanging();
					this._AnhBia = value;
					this.SendPropertyChanged("AnhBia");
					this.OnAnhBiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayCapNhat", DbType="Date")]
		public System.Nullable<System.DateTime> NgayCapNhat
		{
			get
			{
				return this._NgayCapNhat;
			}
			set
			{
				if ((this._NgayCapNhat != value))
				{
					this.OnNgayCapNhatChanging(value);
					this.SendPropertyChanging();
					this._NgayCapNhat = value;
					this.SendPropertyChanged("NgayCapNhat");
					this.OnNgayCapNhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongTon", DbType="Int")]
		public System.Nullable<int> SoLuongTon
		{
			get
			{
				return this._SoLuongTon;
			}
			set
			{
				if ((this._SoLuongTon != value))
				{
					this.OnSoLuongTonChanging(value);
					this.SendPropertyChanging();
					this._SoLuongTon = value;
					this.SendPropertyChanged("SoLuongTon");
					this.OnSoLuongTonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNCC", DbType="Int")]
		public System.Nullable<int> MaNCC
		{
			get
			{
				return this._MaNCC;
			}
			set
			{
				if ((this._MaNCC != value))
				{
					if (this._NhaCungCap.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNCCChanging(value);
					this.SendPropertyChanging();
					this._MaNCC = value;
					this.SendPropertyChanged("MaNCC");
					this.OnMaNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChatLieu", DbType="Int")]
		public System.Nullable<int> MaChatLieu
		{
			get
			{
				return this._MaChatLieu;
			}
			set
			{
				if ((this._MaChatLieu != value))
				{
					if (this._ChatLieu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaChatLieuChanging(value);
					this.SendPropertyChanging();
					this._MaChatLieu = value;
					this.SendPropertyChanged("MaChatLieu");
					this.OnMaChatLieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_CTDatHang", Storage="_CTDatHangs", ThisKey="MaSP", OtherKey="MaSP")]
		public EntitySet<CTDatHang> CTDatHangs
		{
			get
			{
				return this._CTDatHangs;
			}
			set
			{
				this._CTDatHangs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChatLieu_SanPham", Storage="_ChatLieu", ThisKey="MaChatLieu", OtherKey="MaChatLieu", IsForeignKey=true)]
		public ChatLieu ChatLieu
		{
			get
			{
				return this._ChatLieu.Entity;
			}
			set
			{
				ChatLieu previousValue = this._ChatLieu.Entity;
				if (((previousValue != value) 
							|| (this._ChatLieu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ChatLieu.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._ChatLieu.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaChatLieu = value.MaChatLieu;
					}
					else
					{
						this._MaChatLieu = default(Nullable<int>);
					}
					this.SendPropertyChanged("ChatLieu");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhaCungCap_SanPham", Storage="_NhaCungCap", ThisKey="MaNCC", OtherKey="MaNCC", IsForeignKey=true)]
		public NhaCungCap NhaCungCap
		{
			get
			{
				return this._NhaCungCap.Entity;
			}
			set
			{
				NhaCungCap previousValue = this._NhaCungCap.Entity;
				if (((previousValue != value) 
							|| (this._NhaCungCap.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhaCungCap.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._NhaCungCap.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaNCC = value.MaNCC;
					}
					else
					{
						this._MaNCC = default(Nullable<int>);
					}
					this.SendPropertyChanged("NhaCungCap");
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
		
		private void attach_CTDatHangs(CTDatHang entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = this;
		}
		
		private void detach_CTDatHangs(CTDatHang entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = null;
		}
	}
}
#pragma warning restore 1591
