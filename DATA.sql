USE master
CREATE DATABASE QLBanQuaLuuNiem
GO

USE QLBanQuaLuuNiem
GO

CREATE TABLE ADMIN
(
	TKAdmin VARCHAR(24) PRIMARY KEY,
	PassAdmin VARCHAR(24) NOT NULL,
	HoTen nVarchar(30)
)

CREATE TABLE KhachHang
(
	MaKH INT IDENTITY(1,1) PRIMARY KEY,
	HoTen NVARCHAR(30) NOT NULL,
	TaiKhoan VARCHAR(24) UNIQUE,

	MatKhau VARCHAR(24) NOT NULL,
	SDT VARCHAR(12) NULL ,
	DiaChi NVARCHAR(50) NULL
)	
GO

CREATE TABLE NhaCungCap
(
	MaNCC INT IDENTITY(1,1) PRIMARY KEY,
	TenNCC NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(50) NULL,
	SDT VARCHAR(12) NULL
)
GO
CREATE TABLE ChatLieu
(
	MaChatLieu INT IDENTITY(1,1) PRIMARY KEY,
	TenChatLieu NVARCHAR(30) NOT NULL,
)

CREATE TABLE SanPham
(
	MaSP INT IDENTITY(1,1) PRIMARY KEY,
	TenSP NVARCHAR(30) NOT NULL,
	GiaBan DECIMAL(18,0) CHECK (GiaBan >= 0) NOT NULL,
	MoTa NVARCHAR(MAX) NULL,
	AnhBia VARCHAR(50) NOT NULL,
	NgayCapNhat DATE NULL,
	SoLuongTon INT NULL CHECK (SoLuongTon > 0),
	MaNCC INT,
	MaChatLieu INT,
	Constraint FK_ChatLieu Foreign Key(MaChatLieu) REFERENCES dbo.ChatLieu(MaChatLieu),
	Constraint FK_NhaCungCap Foreign Key(MaNCC)References dbo.NhaCungCap(MaNCC)
)
GO

CREATE TABLE DonDatHang
(
	MaDonHang INT IDENTITY(1,1) PRIMARY KEY,
	DaThanhToan Bit NULL DEFAULT 0,
	TinhTrangGiaoHang Bit NULL DEFAULT 0,
	NgayDat DateTime,
	NgayGiao DateTime,
	MaKH int,
	Constraint FK_KhachHang Foreign Key(MaKH) REFERENCES dbo.KhachHang(MaKH)
)
GO
CREATE TABLE CTDatHang
(
	MaDonHang INT,
	MaSP INT,
	SoLuong INT CHECK (SoLuong > 0),
	DonGia DECIMAL(18,0) CHECK (DonGia >= 0), 
	CONSTRAINT PK_CTDatHang PRIMARY KEY(MaDonHang,MaSP),
	Constraint FK_SanPham Foreign Key(MaSP) REFERENCES dbo.SanPham(MaSP),
	Constraint FK_DonDatHang Foreign Key(MaDonHang) REFERENCES dbo.DonDatHang(MaDonHang),

)


----Chất liệu
INSERT INTO dbo.ChatLieu
(
    TenChatLieu
)
VALUES
(N'Valentine'-- TenChatLieu - nvarchar(30)
)
INSERT INTO dbo.ChatLieu
(
    TenChatLieu
)
VALUES
(N' Quà tặng 20-11' -- TenChatLieu - nvarchar(30)
    )
INSERT INTO dbo.ChatLieu
(
    TenChatLieu
)
VALUES
(N'Sinh Nhật' -- TenChatLieu - nvarchar(30)
    )
INSERT INTO dbo.ChatLieu
(
    TenChatLieu
)
VALUES
(N'Noel' -- TenChatLieu - nvarchar(30)
    )
INSERT INTO dbo.ChatLieu
(
    TenChatLieu
)
VALUES
(N'Quà tặng 8-3' -- TenChatLieu - nvarchar(30)
    )
INSERT INTO dbo.ChatLieu
(
    TenChatLieu
)
VALUES
(N'Tết' -- TenChatLieu - nvarchar(30)
    )



-----Nhà Cung Cấp
INSERT INTO dbo.NhaCungCap
(
    TenNCC,
    DiaChi,
    SDT
)
VALUES
(   N'Công ty LT', -- TenNCC - nvarchar(50)
    N'thành phố hồ chí minh', -- DiaChi - nvarchar(50)
    '0123654789'   -- SDT - varchar(12)
    )
INSERT INTO dbo.NhaCungCap
(
    TenNCC,
    DiaChi,
    SDT
)
VALUES
(   N'Công Ty HL', -- TenNCC - nvarchar(50)
    N'Thành Phố Hồ Chí Minh', -- DiaChi - nvarchar(50)
    '0142365789'   -- SDT - varchar(12)
    )
INSERT INTO dbo.NhaCungCap
(
    TenNCC,
    DiaChi,
    SDT
)
VALUES
(   N'Công ty LL', -- TenNCC - nvarchar(50)
    N'Thành Phố Hồ Chí Minh', -- DiaChi - nvarchar(50)
    '0836356899'   -- SDT - varchar(12)
    )

	SELECT * FROM dbo.SanPham
------Sản Phẩm
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Tết HQT1',       -- TenSP - nvarchar(30)
    250000,      -- GiaBan - decimal(18, 0)
    N'Tết xuân an khang quà ngập tràn',       -- MoTa - nvarchar(50)
    'HQT1.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    20,         -- SoLuongTon - int
    1,         -- MaNCC - int
    6          -- MaChatLieu - int
    )
INSERT INTO	dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Tết HQT2',       -- TenSP - nvarchar(30)
    150000,      -- GiaBan - decimal(18, 0)
    N'Tết xuân an khang quà ngập tràn',       -- MoTa - nvarchar(50)
    'HQT2.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    10,         -- SoLuongTon - int
    2,         -- MaNCC - int
    6          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà tết HQT3',       -- TenSP - nvarchar(30)
    120000,      -- GiaBan - decimal(18, 0)
    N'Tết xuân an khang quà ngập tràn',       -- MoTa - nvarchar(50)
    'HQT3.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    5,         -- SoLuongTon - int
    3,         -- MaNCC - int
    6          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Tết HQT4',       -- TenSP - nvarchar(30)
    1500000,      -- GiaBan - decimal(18, 0)
    N'Tết xuân an khang quà ngập tràn',       -- MoTa - nvarchar(50)
    'HQT4.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    2,         -- SoLuongTon - int
    1,         -- MaNCC - int
    6          -- MaChatLieu - int
   )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Giáo viên HGV1',       -- TenSP - nvarchar(30)
    50000,      -- GiaBan - decimal(18, 0)
    N'Ngày nhà giáo viên Việt Nam là nhớ ơn thầy cô đã dạy dỗ chúng em nên người',       -- MoTa - nvarchar(50)
    'HGV1.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    12,         -- SoLuongTon - int
    1,         -- MaNCC - int
    2         -- MaChatLieu - int
    )
	
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà giáo viên HGV2',       -- TenSP - nvarchar(30)
    10000,      -- GiaBan - decimal(18, 0)
    N'Ngày nhà giáo viên Việt Nam là nhớ ơn thầy cô đã dạy dỗ chúng em nên người',       -- MoTa - nvarchar(50)
    'HGV2.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    10,         -- SoLuongTon - int
    1,         -- MaNCC - int
    2          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà giáo viên HGV3',       -- TenSP - nvarchar(30)
    500000,      -- GiaBan - decimal(18, 0)
    N'Ngày nhà giáo viên Việt Nam là nhớ ơn thầy cô đã dạy dỗ chúng em nên người',       -- MoTa - nvarchar(50)
    'ThuyenBuom.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    10,         -- SoLuongTon - int
    3,         -- MaNCC - int
    2         -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà giáo viên HGV4',       -- TenSP - nvarchar(30)
    120000,      -- GiaBan - decimal(18, 0)
    N'Ngày nhà giáo viên Việt Nam là nhớ ơn thầy cô đã dạy dỗ chúng em nên người',       -- MoTa - nvarchar(max)
    'HGV4.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    10,         -- SoLuongTon - int
    3,         -- MaNCC - int
    2          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà giáo viên HGV5',       -- TenSP - nvarchar(30)
    150000,      -- GiaBan - decimal(18, 0)
    N'Ngày nhà giáo viên Việt Nam là nhớ ơn thầy cô đã dạy dỗ chúng em nên người',       -- MoTa - nvarchar(max)
    'HGV5.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    20,         -- SoLuongTon - int
    2,         -- MaNCC - int
    2          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Valentine HV1',       -- TenSP - nvarchar(30)
    120000,      -- GiaBan - decimal(18, 0)
    N'Ngày lễ tình nhân đẹp đẽ của những người yêu nhau',       -- MoTa - nvarchar(max)
    'HV1.png',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    20,         -- SoLuongTon - int
    3,         -- MaNCC - int
    1          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Valentine HV2',       -- TenSP - nvarchar(30)
    130000,      -- GiaBan - decimal(18, 0)
    N'Ngày lễ tình nhân đẹp đẽ của những người yêu nhau',       -- MoTa - nvarchar(max)
    'HV2.png',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    20,         -- SoLuongTon - int
    2,         -- MaNCC - int
    1          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Valentine HV3',       -- TenSP - nvarchar(30)
    150000,      -- GiaBan - decimal(18, 0)
    N'Ngày lễ tình nhân đẹp đẽ của những người yêu nhau',       -- MoTa - nvarchar(max)
    'HV3.png',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    20,         -- SoLuongTon - int
    1,         -- MaNCC - int
    1          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Valentine HV4',       -- TenSP - nvarchar(30)
    180000,      -- GiaBan - decimal(18, 0)
    N'Ngày lễ tình nhân đẹp đẽ của những người yêu nhau',       -- MoTa - nvarchar(max)
    'HV4.png',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    22,         -- SoLuongTon - int
    2,         -- MaNCC - int
    1          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Valentine HV5',       -- TenSP - nvarchar(30)
    200000,      -- GiaBan - decimal(18, 0)
    N'Ngày lễ tình nhân đẹp đẽ của những người yêu nhau',       -- MoTa - nvarchar(max)
    'HV5.png',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    28,         -- SoLuongTon - int
    1,         -- MaNCC - int
    1          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Noel HNL1',       -- TenSP - nvarchar(30)
    140000,      -- GiaBan - decimal(18, 0)
    N'Ngày Noel chung vui bên gia đình hay người yêu đều vui vẻ',       -- MoTa - nvarchar(max)
    'HNL1.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    50,         -- SoLuongTon - int
    3,         -- MaNCC - int
    4          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Noel HNL2',       -- TenSP - nvarchar(30)
    150000,      -- GiaBan - decimal(18, 0)
    N'Ngày Noel chung vui bên gia đình hay người yêu đều vui vẻ',       -- MoTa - nvarchar(max)
    'HNL2.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    10,         -- SoLuongTon - int
    2,         -- MaNCC - int
    4          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Noel HNL3',       -- TenSP - nvarchar(30)
    125000,      -- GiaBan - decimal(18, 0)
    N'Ngày Noel chung vui bên gia đình hay người yêu đều vui vẻ',       -- MoTa - nvarchar(max)
    'HNL3.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    20,         -- SoLuongTon - int
    1,         -- MaNCC - int
    4          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà Noel HNL4',       -- TenSP - nvarchar(30)
    150000,      -- GiaBan - decimal(18, 0)
    N'Ngày Noel chung vui bên gia đình hay người yêu đều vui vẻ',       -- MoTa - nvarchar(max)
    'HNL4.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    30,         -- SoLuongTon - int
    1,         -- MaNCC - int
    4          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà ngày 8-3 HPN1',       -- TenSP - nvarchar(30)
    140000,      -- GiaBan - decimal(18, 0)
    N'Ngày quốc tế phụ nữ là phụ nữ được ưu tiên hàng đầu',       -- MoTa - nvarchar(max)
    'HPN1.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    10,         -- SoLuongTon - int
    3,         -- MaNCC - int
    5          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà ngày 8-3 HPN2',       -- TenSP - nvarchar(30)
    150000,      -- GiaBan - decimal(18, 0)
    N'Ngày quốc tế phụ nữ là phụ nữ được ưu tiên hàng đầu',       -- MoTa - nvarchar(max)
    'HPN2.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    10,         -- SoLuongTon - int
    1,         -- MaNCC - int
    5          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà ngày 8-3 HPN3',       -- TenSP - nvarchar(30)
    140000,      -- GiaBan - decimal(18, 0)
    N'Ngày quốc tế phụ nữ là phụ nữ được ưu tiên hàng đầu',       -- MoTa - nvarchar(max)
    'HPN3.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    10,         -- SoLuongTon - int
    2,         -- MaNCC - int
    5          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà ngày 8-3 HPN4',       -- TenSP - nvarchar(30)
    145000,      -- GiaBan - decimal(18, 0)
    N'Ngày quốc tế phụ nữ là phụ nữ được ưu tiên hàng đầu',       -- MoTa - nvarchar(max)
    'HPN4.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    12,         -- SoLuongTon - int
    1,         -- MaNCC - int
    5          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà ngày 8-3 HPN5',       -- TenSP - nvarchar(30)
    100000,      -- GiaBan - decimal(18, 0)
    N'Ngày quốc tế phụ nữ là phụ nữ được ưu tiên hàng đầu',       -- MoTa - nvarchar(max)
    'HPN5.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    10,         -- SoLuongTon - int
    1,         -- MaNCC - int
    5          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà sinh nhật HSN1',       -- TenSP - nvarchar(30)
    100000,      -- GiaBan - decimal(18, 0)
    N'Mua Quà để chúc mừng sinh nhật bạn vui vẻ',       -- MoTa - nvarchar(max)
    'HSN1.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    10,         -- SoLuongTon - int
    3,         -- MaNCC - int
    3          -- MaChatLieu - int
    )
	INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà sinh nhật HSN2',       -- TenSP - nvarchar(30)
    110000,      -- GiaBan - decimal(18, 0)
    N'Mua Quà để chúc mừng sinh nhật bạn vui vẻ',       -- MoTa - nvarchar(max)
    'HSN2.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    20,         -- SoLuongTon - int
    2,         -- MaNCC - int
    3          -- MaChatLieu - int
    )
INSERT INTO dbo.SanPham
(
    TenSP,
    GiaBan,
    MoTa,
    AnhBia,
    NgayCapNhat,
    SoLuongTon,
    MaNCC,
    MaChatLieu
)
VALUES
(   N'Hộp quà sinh nhật HSN3',       -- TenSP - nvarchar(30)
    120000,      -- GiaBan - decimal(18, 0)
    N'Mua Quà để chúc mừng sinh nhật bạn vui vẻ',       -- MoTa - nvarchar(max)
    'HSN3.jpg',        -- AnhBia - varchar(50)
    GETDATE(), -- NgayCapNhat - date
    11,         -- SoLuongTon - int
    2,         -- MaNCC - int
    3          -- MaChatLieu - int
    )
------------Khách hàng
INSERT INTO dbo.KhachHang
(
    HoTen,
    TaiKhoan,
    MatKhau,
    SDT,
    DiaChi
)
VALUES
(   N'Trần Nhựt Linh', -- HoTen - nvarchar(30)
    'LinhTran1811',  -- TaiKhoan - varchar(24)
    '230600',  -- MatKhau - varchar(24)
    '0836256441',  -- SDT - varchar(12)
    N'Thành Phố Cà Mau'  -- DiaChi - nvarchar(50)
    )
INSERT INTO dbo.KhachHang
(
    HoTen,
    TaiKhoan,
    MatKhau,
    SDT,
    DiaChi
)
VALUES
(   N'Lê Minh Trường Thắng', -- HoTen - nvarchar(30)
    'ThangLe1811',  -- TaiKhoan - varchar(24)
    '240900',  -- MatKhau - varchar(24)
    '0856356942',  -- SDT - varchar(12)
    N'Thành Phố Nha Trang'  -- DiaChi - nvarchar(50)
 )

 SELECT * FROM dbo.KhachHang --WHERE HoTen = 'Trần Nhựt Linh'
 SELECT * FROM dbo.SanPham
 SELECT * FROM dbo.ChatLieu
 SELECT * FROM dbo.NhaCungCap
 SELECT * FROM dbo.ADMIN
 

INSERT INTO dbo.ADMIN
(
    TKAdmin,
    PassAdmin,
    HoTen
)
VALUES
(   'Admin', -- TKAdmin - varchar(24)
    '123456789	', -- PassAdmin - varchar(24)
    N'Lê Minh Trường Thắng' -- HoTen - nvarchar(30)
  )  
INSERT INTO dbo.ADMIN
(
    TKAdmin,
    PassAdmin,
    HoTen
)
VALUES
(   'User', -- TKAdmin - varchar(24)
    '123456789', -- PassAdmin - varchar(24)
    N'Trần Nhựt Linh' -- HoTen - nvarchar(30)
    )
