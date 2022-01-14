USE master
GO
--Tạo CSDL QuanLyCuaHangJuno
CREATE DATABASE QuanLyCuaHangJuno
GO
--Kết nối với CSDL muốn làm việc
USE QuanLyCuaHangJuno
GO
--Tạo bảng Nhân viên
CREATE TABLE NhanVien
(
	MaNV varchar(10) PRIMARY KEY,
	HoTenNV nvarchar(50) NOT NULL,
	GioiTinh nvarchar(10) NOT NULL,
	NgaySinh date NOT NULL,
	CMT varchar(20) NOT NULL,
	DiaChi nvarchar(100) NOT NULL,
	SDT varchar(15) NOT NULL,
	Email varchar(50),
	TenTK varchar(30) NOT NULL,
	MatKhau varchar(30) NOT NULL,
	Quyen nvarchar(50) NOT NULL,
	TrangThai bit NOT NULL
)
GO
--Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (MaNV,HoTenNV,GioiTinh,NgaySinh,CMT,DiaChi,SDT,Email,TenTK,MatKhau,Quyen,TrangThai)
VALUES ('NV001',N'Nguyễn Văn Tín',N'Nam','12/02/2000','112233445',N'Hà Nội','0336759957','tinabc@gmail.com','Admin','admin',N'Quản lý',0),
		('NV002',N'Trần Quang Đại',N'Nam','12/12/1990','123456789',N'Hà Nội','0364827643','quangdai@gmail.com','quangdai123','123456',N'Nhân viên',0),
		('NV003',N'Nguyễn Quang Huy',N'Nam','12/12/1999','123456789',N'Hà Nội','0364827643','abc@gmail.com','nv003','123456',N'Nhân viên',0),
		('NV004',N'Nguyễn Thanh Mai',N'Nữ','12/7/2000','123456789',N'Hà Nội','0364827643','acb@gmail.com','nv004','123456',N'Nhân viên',0)

GO
--Tạo bảng giảm giá hóa đơn bán hàng
CREATE TABLE GiamGiaHoaDon
(
	MaGG varchar(10) PRIMARY KEY,
	TGBatDau datetime NOT NULL,
	TGKetThuc datetime NOT NULL,
	TyLeGiamGia float NOT NULL,
	DieuKienApDung money NOT NULL
)
GO
INSERT INTO GiamGiaHoaDon(MaGG,TGBatDau,TGKetThuc,TyLeGiamGia,DieuKienApDung)
VALUES('GG000','2021-01-01','2023-12-30',10,500000),
		('GG001','2021-11-11','2021-11-30',10,500000),
		('GG002','2021-12-01','2021-12-30',10,500000)

GO

--Tạo bảng Khách hàng
CREATE TABLE KhachHang
(
	MaKH varchar(10) PRIMARY KEY,
	HoTenKH nvarchar(50) NOT NULL,
	SDT varchar(15),
	DiaChi nvarchar(100)
)
INSERT INTO KhachHang(MaKH,HoTenKH,SDT,DiaChi)
VALUES('KH001',N'Nguyễn Văn A', '0123123123',N'Hà Nội'),
		('KH002',N'Nguyễn Văn B', '0123456789',N'Hà Nội'),
		('KH003',N'Đặng Thị C', '0123456788',N'Hà Nội'),
		('KH004',N'Trần Thu D', '0123456787',N'Hà Nội'),
		('KH005',N'Lê Văn E', '0123456786',N'Hà Nội'),
		('KH006',N'Nguyễn Hùng Tình', '0984138630',N'Hà Nội'),
		('KH007',N'Nguyễn Thế Tài', '0912345678',N'Hà Nội'),
		('KH008',N'Nguyễn Quang Thắng', '0981234567',N'Bắc Ninh'),
		('KH009',N'Lê Hoàng Tú', '0984138600',N'Hà Nội'),
		('KH010',N'Trần Văn Thìn', '0984456765',N'Hải Dương')
--Tạo bảng Loại Sản Phẩm
CREATE TABLE LoaiSanPham
(
	MaLoaiSP varchar(10) PRIMARY KEY,
	TenLoaiSP nvarchar(50) NOT NULL
)
GO
--Thêm dữ liệu vào bảng LoaiSanPham
INSERT INTO LoaiSanPham(MaLoaiSP,TenLoaiSP)
VALUES ('LSP001',N'Giày'),
		('LSP002',N'Túi'),
		('LSP003',N'Mắt kính'),
		('LSP004',N'Trang sức'),
		('LSP005',N'Vớ'),
		('LSP006',N'Áo thun')
GO
--Tạo bảng Sản Phẩm
CREATE TABLE SanPham
(
	MaSP varchar(10) PRIMARY KEY,
	TenSP nvarchar(50) NOT NULL,
	KieuDang nvarchar(50),
	ChatLieu nvarchar(50),
	DonGia money NOT NULL,
	ThoiGianBaoHanh int NOT NULL,
	ThoiGianTraHang int NOT NULL,
	MaLoaiSP varchar(10) NOT NULL,
	CONSTRAINT dk_SanPham_LoaiSP FOREIGN KEY (MaLoaiSP) REFERENCES LoaiSanPham(MaLoaiSP)
)
GO
--Thêm dữ liệu vào bảng Sản phẩm
INSERT INTO SanPham(MaSP,TenSP,KieuDang,ChatLieu,DonGia,ThoiGianBaoHanh,ThoiGianTraHang,MaLoaiSP)
VALUES ('SP001','Sneakers Phoenix',N'Giày sneaker',N'Da tổng hợp',895000,6,7,'LSP001'),
		('SP002','Sneaker Jelly',N'Giày sneaker',N'Microfiber và Polyester',695000,6,7,'LSP001'),
		('SP003','Trendy Bridging Chunky',N'Giày sneaker',N'Microfiber',795000,6,7,'LSP001'),
		('SP004',N'Giày Mules Mũi Nhọn Gót Trụ',N'Giày cao gót',N'Da tổng hợp',455000,6,7,'LSP001'),
		('SP005',N'Giày Cao Gót Mũi Nhọn Gắn Dây Xích Mảnh',N'Giày cao gót',N'Da tổng hợp',495000,6,7,'LSP001'),
		('SP006',N'Giày Sandal Đế Thể Thao Phối Khóa Trang Trí',N'Giày xăng đan',N'Da tổng hợp',455000,6,7,'LSP001'),
		('SP007',N'Giày Xăng Đan Quai Ngang Trang Trí Kim Loại',N'Giày xăng đan',N'Da tổng hợp',390000,6,7,'LSP001'),
		('SP008',N'Túi Xách Nhỏ Đeo Chéo Nắp Viền Dây Kim Loại',N'Túi xách thời trang',N'Da tổng hợp',755000,6,7,'LSP002'),
		('SP009',N'Túi Xách Trung Nắp 2 Tầng',N'Túi xách thời trang',N'Da tổng hợp',855000,6,7,'LSP002'),
		('SP010',N'Túi Xách Lớn Top Handle',N'Túi xách thời trang',N'Da tổng hợp',795000,6,7,'LSP002'),
		('SP011',N'Balo Khóa Scrunchies',N'Balo thời trang',N'Da tổng hợp',855000,6,7,'LSP002'),
		('SP012',N'Ví The Maze',N'Ví cầm tay',N'Da tổng hợp',555000,6,7,'LSP002'),
		('SP013',N'Mắt Kính Vuông Kim Loại Phối Nhựa',N'Mắt kính thời trang',N'Kim loại',555000,6,7,'LSP003'),
		('SP014',N'Dây Chuyền Hình Chiếc Lá Đính Đá',NULL,N'Phủ lớp vàng 14K',190000,6,7,'LSP004'),
		('SP015',N'Vớ Cổ Cao Bộ 2 Đôi Kiểu Mèo Và Xương Cá',N'Vớ',N'Vải',80000,6,7,'LSP005'),
		('SP016',N'Áo Thun "Bánh Mỳ Sài Gòn"',N'Trang phục dạo phố thường ngày',N'Thun',249000,6,7,'LSP006'),
		('SP017',N'Áo Thun "Top Giàu Sang"',NULL,N'Thun',249000,6,7,'LSP006')
GO

--Tạo bảng Màu của sản phẩm
CREATE TABLE Mau
(
	MaMau varchar(10) PRIMARY KEY,
	Mau nvarchar(20) NOT NULL
)
GO
--Thêm dữ liệu vào bảng Màu
INSERT INTO Mau(MaMau,Mau)
VALUES ('M001',N'Trắng'),
		('M002',N'Kem'),
		('M003',N'Xám'),
		('M004',N'Xanh'),
		('M005',N'Đen'),
		('M006',N'Hồng'),
		('M007',N'Vàng'),
		('M008',N'Cam'),
		('M009',N'Xanh lá')
GO
--Tạo bảng Kích cỡ của sản phẩm
CREATE TABLE KichCo
(
	MaKC varchar(10) PRIMARY KEY,
	KichCo nvarchar(20)
)
GO
--Thêm dữ liệu vào bảng Kích cỡ
INSERT INTO KichCo(MaKC,KichCo)
VALUES 	('KC000',NULL),
		('KC001','35'),
		('KC002','36'),
		('KC003','37'),
		('KC004','38'),
		('KC005','39'),
		('KC006','Freesize'),
		('KC007','S'),
		('KC008','M'),
		('KC009','L'),
		('KC010','XL'),
		('KC011','XXL')
GO

CREATE TABLE SanPham_ChiTiet
(
	MaSP_CT varchar(10) PRIMARY KEY,
	MaSP varchar(10) NOT NULL,
	MaMau varchar(10),
	MaKC varchar(10),
	SoLuongTon int NOT NULL,
	CONSTRAINT fk_sp_ct_SanPham FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
	CONSTRAINT fk_sp_ct_mau FOREIGN KEY (MaMau) REFERENCES Mau(MaMau),
	CONSTRAINT fk_sp_ct_kc FOREIGN KEY (MaKC) REFERENCES KichCo(MaKC)
)
GO
--Thêm dữ liệu vào bảng SanPham_ChiTiet
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES	('CT001','SP001','M007','KC001',2),
		('CT002','SP001','M007','KC002',2),
		('CT003','SP001','M007','KC003',4),
		('CT004','SP001','M007','KC004',2),
		('CT005','SP001','M007','KC005',2),
		('CT006','SP001','M002','KC001',4),
		('CT007','SP001','M002','KC002',2),
		('CT008','SP001','M002','KC003',2),
		('CT009','SP001','M002','KC004',2),
		('CT010','SP001','M002','KC005',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT011','SP002','M001','KC001',3),
		('CT012','SP002','M001','KC002',3),
		('CT013','SP002','M001','KC003',4),
		('CT014','SP002','M001','KC004',3),
		('CT015','SP002','M001','KC005',3)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT016','SP003','M001','KC001',2),
		('CT017','SP003','M001','KC002',2),
		('CT018','SP003','M001','KC003',2),
		('CT019','SP003','M001','KC004',2),
		('CT020','SP003','M001','KC005',2),
		('CT021','SP003','M004','KC001',2),
		('CT022','SP003','M004','KC002',2),
		('CT023','SP003','M004','KC003',3),
		('CT024','SP003','M004','KC004',2),
		('CT025','SP003','M004','KC005',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT026','SP004','M002','KC001',2),
		('CT027','SP004','M002','KC002',2),
		('CT028','SP004','M002','KC003',2),
		('CT029','SP004','M002','KC004',2),
		('CT030','SP004','M002','KC005',2),
		('CT031','SP004','M006','KC001',2),
		('CT032','SP004','M006','KC002',2),
		('CT033','SP004','M006','KC003',2),
		('CT034','SP004','M006','KC004',2),
		('CT035','SP004','M006','KC005',2),
		('CT036','SP004','M003','KC001',2),
		('CT037','SP004','M003','KC002',2),
		('CT038','SP004','M003','KC003',2),
		('CT039','SP004','M003','KC004',2),
		('CT040','SP004','M003','KC005',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT041','SP005','M002','KC001',2),
		('CT042','SP005','M002','KC002',2),
		('CT043','SP005','M002','KC003',2),
		('CT044','SP005','M002','KC004',2),
		('CT045','SP005','M002','KC005',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT046','SP006','M001','KC001',2),
		('CT047','SP006','M001','KC002',2),
		('CT048','SP006','M001','KC003',2),
		('CT049','SP006','M001','KC004',2),
		('CT050','SP006','M001','KC005',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT051','SP007','M001','KC001',2),
		('CT052','SP007','M001','KC002',2),
		('CT053','SP007','M001','KC003',2),
		('CT054','SP007','M001','KC004',2),
		('CT055','SP007','M001','KC005',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT056','SP008','M007','KC000',2),
		('CT057','SP008','M002','KC000',2)
		
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT058','SP009','M004','KC000',2),
		('CT059','SP009','M002','KC000',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT060','SP010','M006','KC000',2),
		('CT061','SP010','M002','KC000',2)	
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT062','SP011','M007','KC000',2),
		('CT063','SP011','M001','KC000',2),
		('CT064','SP011','M004','KC000',2),
		('CT065','SP011','M005','KC000',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT066','SP012','M006','KC001',2),
		('CT067','SP012','M006','KC002',2),
		('CT068','SP012','M006','KC003',2),
		('CT069','SP012','M006','KC004',2),
		('CT070','SP012','M006','KC005',2),
		('CT071','SP012','M002','KC001',2),
		('CT072','SP012','M002','KC002',2),
		('CT073','SP012','M002','KC003',2),
		('CT074','SP012','M002','KC004',2),
		('CT075','SP012','M002','KC005',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT076','SP013','M005','KC000',7),
		('CT077','SP013','M006','KC002',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT078','SP014','M005','KC000',7),
		('CT079','SP014','M006','KC002',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT086','SP015','M005','KC000',7),
		('CT087','SP015','M006','KC002',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT080','SP016','M005','KC006',7),
		('CT081','SP016','M004','KC006',2),
		('CT082','SP016','M001','KC006',2)
INSERT INTO SanPham_ChiTiet(MaSP_CT,MaSP,MaMau,MaKC,SoLuongTon)
VALUES ('CT083','SP017','M006','KC006',7),
		('CT084','SP017','M004','KC006',2),
		('CT085','SP017','M001','KC006',2)
GO
CREATE TABLE KhuyenMai
(
	MaKM varchar(10) PRIMARY KEY,
	NgayBatDau date NOT NULL,
	NgayKetThuc date NOT NULL
)
GO
INSERT INTO KhuyenMai(MaKM,NgayBatDau,NgayKetThuc)
VAlUES('KM000','2021-01-01','2023-12-30'),
		('KM001','2021-11-01','2021-12-30'),
		('KM002','2021-11-01','2021-12-30'),
		('KM003','2021-11-01','2021-12-30')

GO
--Tạo bảng KhuyenMai_SanPham
CREATE TABLE KhuyenMai_SanPham
(
	MaKM varchar(10) NOT NULL,
	MaSP varchar(10) NOT NULL,
	TyLeKhuyenMai float NOT NULL,
	PRIMARY KEY(MaKM,MaSP),
	CONSTRAINT fk_KhuyenMai FOREIGN KEY (MaKM) REFERENCES KhuyenMai(MaKM),
	CONSTRAINT fk_km_sp_SanPham FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
)
GO
INSERT INTO KhuyenMai_SanPham (MaKM,MaSP,TyLeKhuyenMai)
VAlUES('KM000','SP001',10),
		('KM000','SP002',10),
		('KM000','SP003',10),
		('KM000','SP004',10),
		('KM000','SP005',10),
		('KM000','SP006',20),
		('KM000','SP007',20),
		('KM000','SP008',20),
		('KM000','SP009',30),
		('KM000','SP010',30)
GO
--Tạo bảng hóa đơn bán hàng
CREATE TABLE HoaDonBanHang
(
	MaHD varchar(10) PRIMARY KEY,
	NgayBan datetime NOT NULL,
	MaKH varchar(10) NOT NULL,
	MaGG varchar(10),
	MaNV varchar(10) NOT NULL,
	CONSTRAINT fk_HoaDonBanHang_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
	CONSTRAINT fk_HoaDonBanHang_GiamGiaHoaDon FOREIGN KEY (MaGG) REFERENCES GiamGiaHoaDon(MaGG),
	CONSTRAINT fk_HoaDonBanHang_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)
GO


----- Sửa MaGG null----
--Alter Table HoaDonBanHang
--Alter Column MaGG varchar(10);

INSERT INTO HoaDonBanHang(MaHD,NgayBan,MaKH,MaNV)
VALUES('HD001','2000-01-05 00:00:00.000','KH001','NV001'),
		('HD002','2021-01-05 00:00:00.000','KH002','NV001'),
		('HD003','2021-02-05 00:00:00.000','KH003','NV002'),
		('HD004','2021-03-05 00:00:00.000','KH004','NV002'),
		('HD005','2021-04-05 00:00:00.000','KH005','NV002')
GO
--Tạo bảng HoaDonBanHang_SanPham
CREATE TABLE HoaDonBanHang_SanPham
(
	MaHD varchar(10) NOT NULL,
	MaSP_CT varchar(10) NOT NULL,
	SoLuongBan int NOT NULL,
	PRIMARY KEY(MaHD, MaSP_CT),
	CONSTRAINT fk_HoaDonBanHang_SanPham_HoaDon FOREIGN KEY (MaHD) REFERENCES HoaDonBanHang(MaHD),
	CONSTRAINT fk_HoaDonBanHang_SanPham_ChiTiet FOREIGN KEY (MaSP_CT) REFERENCES SanPham_ChiTiet(MaSP_CT)
)
GO

INSERT INTO HoaDonBanHang_SanPham
VALUES('HD001','CT001',2),
	('HD001','CT002',2),
	('HD001','CT003',2),
	('HD001','CT004',2),
	('HD002','CT005',2),
	('HD002','CT006',2),
	('HD002','CT007',2),
	('HD002','CT008',2),
	('HD003','CT009',2),
	('HD003','CT010',2),
	('HD003','CT011',2),
	('HD003','CT012',2),
	('HD004','CT013',2),
	('HD004','CT014',2),
	('HD004','CT015',2),
	('HD005','CT016',2),
	('HD005','CT017',2),
	('HD005','CT018',2),
	('HD005','CT019',2),
	('HD005','CT020',2)

--Tú add Start
--Tạo bảng Phiếu Bảo Hành
CREATE TABLE PhieuBaoHanh
(
	MaPhieu varchar(10) PRIMARY KEY,
	NgayLapPhieu datetime NOT NULL,
	NgayTra date NOT NULL,
	MaNV varchar(10) NOT NULL,
	MaHD varchar(10) NOT NULL,
	CONSTRAINT fk_PhieuBaoHanh_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
	CONSTRAINT fk_PhieuBaoHanh_SanPham_hoadonbanhang FOREIGN KEY (MaHD) REFERENCES HoaDonBanHang(MaHD)
)
GO
--Tạo bảng PhieuBaohanh_SanPham
CREATE TABLE PhieuBaohanh_SanPham
(
	MaPhieu varchar(10) NOT NULL,
	MaHD varchar(10) NOT NULL,
	MaSP_CT varchar(10) NOT NULL,
	Loi nvarchar(100) NOT NULL,
	ChiTietLoi nvarchar(100) NOT NULL,
	SoLuong int NOT NULL,
	PRIMARY KEY(MaPhieu, MaSP_CT),
	CONSTRAINT fk_PhieubaoHanh_SanPham_HoaDon FOREIGN KEY (MaPhieu) REFERENCES PhieuBaoHanh(MaPhieu),
	CONSTRAINT fk_PhieuBaoHanh_SanPham_hoadonbanhang_sanpham FOREIGN KEY (MaHD,MaSP_CT) REFERENCES HoaDonBanHang_SanPham(MaHD,MaSP_CT)

)
GO
--Tú add End

--Tạo bảng Phiếu Trả Hàng
CREATE TABLE PhieuTraHang
(
	MaPhieuTra varchar(10) PRIMARY KEY,
	NgayLap datetime NOT NULL,
	MaNV varchar(10) NOT NULL,
	MaSP_CT varchar(10) NOT NULL,
	MaHD varchar(10) NOT NULL,
	LyDoTra nvarchar(100) NOT NULL,
	CONSTRAINT fk_PhieuTraHang_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
	CONSTRAINT fk_PhieuTraHang_hoadonbanhang_sanpham FOREIGN KEY (MaHD,MaSP_CT) REFERENCES HoaDonBanHang_SanPham(MaHD,MaSP_CT))
GO

INSERT INTO PhieuTraHang
VALUES('PT001','2000-01-15 00:00:00.000','NV001','CT001','HD001',N'Sản phẩm hỏng')
GO
--Tình thêm mới bảng Start
--Tạo bảng Phiếu Doi Hàng
CREATE TABLE PhieuDoiHang
(
	MaPhieuDoi varchar(10) PRIMARY KEY,
	NgayLap datetime NOT NULL,
	MaNV varchar(10) NOT NULL,
	MaHD varchar(10) NOT NULL,
	LyDoDoi nvarchar(100) NOT NULL,
	TienThua money NOT NULL,
	TienThuLai money NOT NULL,
	CONSTRAINT fk_PhieuTraHangg_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
	CONSTRAINT fk_PhieuTraHangg_hoadonbanhang FOREIGN KEY (MaHD) REFERENCES HoaDonBanHang(MaHD))
GO

---- Tình thêm mới bảng PhieuDoi_SanPhamHD
CREATE TABLE PhieuDoi_SanPhamHD
(
	ID int IDENTITY(1,1) primary key,
	MaPD varchar(10) NOT NULL,
	MaSPCT varchar(10) NOT NULL,
	SL int NOT NULL,
	CONSTRAINT fk_MaPhieuDoi FOREIGN KEY (MaPD) REFERENCES PhieuDoiHang(MaPhieuDoi)
)
GO

--- Tình thêm mới bảng PhieuDoi_SanPhamDoi
CREATE TABLE PhieuDoi_SanPhamDoi
(
	ID int IDENTITY(1,1) primary key,
	MaPD varchar(10) NOT NULL,
	MaSPCT varchar(10) NOT NULL,
	SL int NOT NULL,
	CONSTRAINT fk_MaPhieuDoi1 FOREIGN KEY (MaPD) REFERENCES PhieuDoiHang(MaPhieuDoi)
)
GO 
--Tình thêm mới bảng End


--Tạo bảng PhieuDatHang
CREATE TABLE PhieuDatHang
(
	MaPhieuDat varchar(10) PRIMARY KEY,
	NgayDat datetime NOT NULL,
	ThoiHanGiaoHang date NOT NULL,
	TrangThai nvarchar(100) NOT NULL,
	MaNV varchar(10) NOT NULL,
	CONSTRAINT fk_PhieuDatHang_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)
GO
--Thêm dữ liệu bảng PhieuDatHang
INSERT INTO PhieuDatHang(MaPhieuDat,NgayDat,ThoiHanGiaoHang,TrangThai,MaNV)
VALUES ('PD001','2022-01-10 15:30:00','2022-01-17',N'Nhập một phần','NV001'),
		('PD002','2022-01-11 08:30:00','2022-01-18',N'Chưa nhập','NV001')

GO
--Tạo bảng DatHang_SanPham
CREATE TABLE DatHang_SanPham
(
	MaPhieuDat varchar(10) NOT NULL,
	MaSP_CT varchar(10) NOT NULL,
	SoLuongDat int NOT NULL,
	PRIMARY KEY(MaPhieuDat,MaSP_CT),
	CONSTRAINT fk_PhieuDatHang FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDatHang(MaPhieuDat),
	CONSTRAINT fk_dh_sp_SanPham_ChiTiet FOREIGN KEY (MaSP_CT) REFERENCES SanPham_ChiTiet(MaSP_CT)
)
GO
--Thêm  dữ liệu bảng DatHang_SanPham
INSERT INTO DatHang_SanPham(MaPhieuDat,MaSP_CT,SoLuongDat)
VALUES ('PD001','CT003',5),
		('PD001','CT006',7),
		('PD001','CT023',5),
		('PD002','CT011',5),
		('PD002','CT022',5)
GO
--Tạo bảng PhieuNhapHang
CREATE TABLE PhieuNhapHang
(
	MaPhNhap varchar(10) PRIMARY KEY,
	NgayNhap datetime NOT NULL,
	NguoiGiao nvarchar(50) NOT NULL,
	MaPhieuDat varchar(10) NOT NULL,
	MaNV varchar(10) NOT NULL,
	CONSTRAINT fk_PhieuNhapHang_PhieuDatHang FOREIGN KEY (MaPhieuDat) REFERENCES PhieuDatHang(MaPhieuDat),
	CONSTRAINT fk_PhieuNhapHang_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)
GO
--Thêm dữ liệu bảng PhieuNhapHang
INSERT INTO PhieuNhapHang(MaPhNhap,NgayNhap,NguoiGiao,MaPhieuDat,MaNV)
VALUES ('PN001','2022-01-15 09:10:00',N'Trần Văn Toàn','PD001','NV002')
GO
--Tạo bảng NhapHang_SanPham
CREATE TABLE NhapHang_SanPham
(
	MaSP_CT varchar(10) NOT NULL, 
	MaPhNhap varchar(10) NOT NULL,
	SoLuongNhap int NOT NULL,
	PRIMARY KEY(MaPhNhap,MaSP_CT),
	CONSTRAINT fk_PhieuNhapHang FOREIGN KEY (MaPhNhap) REFERENCES PhieuNhapHang(MaPhNhap),
	CONSTRAINT fk_nh_sp_SanPham_ChiTiet FOREIGN KEY (MaSP_CT) REFERENCES SanPham_ChiTiet(MaSP_CT)
)
GO
--Thêm dữ liệu bảng NhapHang_SanPham
INSERT INTO NhapHang_SanPham(MaSP_CT,MaPhNhap,SoLuongNhap)
VALUES ('CT003','PN001',2),
		('CT006','PN001',2),
		('CT023','PN001',1)
GO