use master
go
create database QuanLyThoiTrang
go
use QuanLyThoiTrang

--QLTaiKhoan
create table QLTaiKhoan (
	MaNV int,
	TenTK nvarchar(50) not null,
	MatKhau nvarchar(50) not null,
)
--SanPham
create table SanPham (
	MaSp int not null,
	TenSp nvarchar(100),
	DonViTinh nvarchar(20),
	GiaBan money,
	SoLuong int,
	LoaiSanPham nvarchar(30),
	MauSac nvarchar(20),
	KichThuoc char(5),
	MoTa nvarchar(100),
	primary key (MaSp),
)

--NhanVien
create table NhanVien(
	MaNV int primary key,
	HoTenNV nvarchar(30),
	GioiTinh nvarchar(3),
	DiaChi nvarchar (100),
	NgaySinh datetime,
	Phone varchar(24),
	ChucVu nvarchar(30)
)

--HoaDon
create table HoaDon(
	MaHD int primary key,
	NgayLapHD datetime,
	MaNV int,
	TenNV nvarchar(100),
	MaKH varchar(5),
	TenKh nvarchar(100),
	SoDienThoai varchar(24),
)

--CTHoaDon
create table CT_HoaDon(
	MaHD int ,
	MaSp int,
	TenSp nvarchar(100),
	MauSac nvarchar(20) ,
	KichThuoc char(3),
	SoLuong int,
	DonGia money,
	ChietKhau int, 
	
)

--NhaCungCap
create table NhaCungCap(
	MaNCC int primary key,
	TenNCC nvarchar(100),
	LoaiHang nvarchar(50),
	GiaNhap money,
	Phone varchar(20),
	DCMail varchar(50)
)
--NhapHang
create table NhapHang(
MaNH int primary key,
MaSp int not null,
TenSp nvarchar(50),
LoaiSanPham nvarchar(30), 
SoLuong int,
GiaNhap money,
MaNCC int,
TenNCC nvarchar(100),
)

--KhachHang
create table Khachhang(
MaKH varchar(5) primary key,
TenKH nvarchar(100),
DiaChi nvarchar(100),
Phone nvarchar(20),
DCMail varchar(50)
)
-----
alter table HoaDon
add foreign key(MaKH) references KhachHang(MaKH)

alter table HoaDon
add foreign key(MaNV) references NhanVien(MaNV)

alter table CT_HoaDon
add foreign key(MaSP) references SanPham(MaSP)

alter table QLTaiKhoan
add foreign key(MaNV) references NhanVien(MaNV)

alter table NhapHang
add foreign key(MaSp) references SanPham(MaSp) 

alter table NhapHang
add foreign key(MaNCC) references NhaCungCap(MaNCC)

alter table CT_HoaDon
add foreign key(MaHD) references HoaDon(MaHD)
--


--
insert into NhaCungCap values ('101','kingclothes','vay','50000','0306201554','nguyennhan@gmail.com')
insert into NhaCungCap values ('102','skinny','quần jean','200000','0167542035','hotrongnghia@gmail.com')
insert into NhaCungCap values ('103','classic','quần tây tối giản','300000','0954862563','duongthanhtan@gmail.com')
insert into NhaCungCap values ('104','original','áo khoác hoddie zipper','450000','0526458624','tranthingocnhi@gmail.com')
--
insert into SanPham (MaSp,TenSp,DonViTinh,GiaBan,SoLuong,LoaiSanPham,MauSac,KichThuoc,MoTa)
values ('001',N'Pyjama','VND','100000','50',N'đồ bộ',N'Trắng','M',N'vải mát.')
insert into SanPham (MaSp,TenSp,DonViTinh,GiaBan,SoLuong,LoaiSanPham,MauSac,KichThuoc,MoTa)
values ('002',N'Quần Jean Cotton Tối Giản','VND','250000','100',N'quần jean',N'Đen','XL',N'độ bền cao, mặc mát, thoải mái.')
insert into SanPham (MaSp,TenSp,DonViTinh,GiaBan,SoLuong,LoaiSanPham,MauSac,KichThuoc,MoTa)
values ('003',N'Quần Tây Tối Giản HG17','VND','325000','100',N'Quần Tây Tối Giản',N'Xanh','L',N'mềm mại, thoáng khí, hút ẩm tốt.')
insert into SanPham (MaSp,TenSp,DonViTinh,GiaBan,SoLuong,LoaiSanPham,MauSac,KichThuoc,MoTa)
values ('004',N'Áo Khoác Hoddie Zipper - Ver25','VND','325000','100',N'áo khoác hoddie zipper',N'Đen','L',N'mềm mại, co giãn đàn hồi.')
--
insert into NhapHang values('11111','001',N'quần jeans','quần','50','50000','101','kingclothes')
--
insert into NhanVien(MaNV,HoTenNV,GioiTinh,DiaChi,NgaySinh,Phone,ChucVu)
values (001,N'Nguyễn Thị Mỹ Dung',N'Nữ',N'TPHCM','12/2/1998',0354862152,N'Thu Ngân')
insert into NhanVien(MaNV,HoTenNV,GioiTinh,DiaChi,NgaySinh,Phone,ChucVu)
values (002,N'Trần Hoàng Khang',N'Nam',N'Long An','3/2/1997',0352684596,N'Quản lý')
insert into NhanVien(MaNV,HoTenNV,GioiTinh,DiaChi,NgaySinh,Phone,ChucVu)
values (003,N'Lê Thị Tường Vi',N'Nữ',N'Long An','11/7/1999',0167426586,N'Thủ kho')
insert into NhanVien(MaNV,HoTenNV,GioiTinh,DiaChi,NgaySinh,Phone,ChucVu)
values (004,N'Nguyễn Yến Nhi',N'Nữ',N'TPHCM', '10/5/1998',09365485236,N'Kế toán')
insert into NhanVien(MaNV,HoTenNV,GioiTinh,DiaChi,NgaySinh,Phone,ChucVu)
values (005,N'Phan Thành Lợi',N'Nam',N'TPHCM','8/2/1997',0985862152,N'Thu Ngân')
------
insert into Khachhang (MaKH, TenKH, DiaChi, Phone, DCMail)
values (01, N'Nguyễn Quang Khải', N'TPHCM', 0321678543, 'nguyenquangkhai@gmail.com')
insert into Khachhang (MaKH, TenKH, DiaChi, Phone, DCMail)
values (02, N'Đỗ Đức Trọng', N'TPHCM', 0321678543, 'doductrong@gmail.com')
insert into Khachhang (MaKH, TenKH, DiaChi, Phone, DCMail)
values (03, N'Lâm Chí Hùng', N'TPHCM', 0978546371, 'lamchihung@gmail.com')
insert into Khachhang (MaKH, TenKH, DiaChi, Phone, DCMail)
values (04, N'Hồ Nhật Minh Anh', N'TPHCM', 0897245632, 'honhatminhanh@gmail.com')
------
insert into HoaDon (MaHD, NgayLapHD, MaNV, TenNV, MaKH, TenKh, SoDienThoai)
values (1, '1/4/2021', 001, N'Nguyễn Thị Mỹ Dung', 01, N'Nguyễn Quang Khải', 0321678543)
insert into HoaDon (MaHD, NgayLapHD, MaNV, TenNV, MaKH, TenKh, SoDienThoai)
values (2, '2/5/2021', 005, N'Phan Thành Lợi', 02, N'Đỗ Đức Trọng', 0321678543)
insert into HoaDon (MaHD, NgayLapHD, MaNV, TenNV, MaKH, TenKh, SoDienThoai)
values (3, '8/7/2021', 005, N'Phan Thành Lợi', 03, N'Lâm Chí Hùng', 0978546371)
insert into HoaDon (MaHD, NgayLapHD, MaNV, TenNV, MaKH, TenKh, SoDienThoai)
values (4, '9/5/2021', 001, N'Nguyễn Thị Mỹ Dung', 04, N'Hồ Nhật Minh Anh', 0897245632)
------

insert into CT_HoaDon(MaHD, MaSp, TenSp,MauSac ,KichThuoc ,SoLuong, DonGia, ChietKhau)
values (1, '002', N'Quần Jean Cotton Tối Giản',N'Do','L' ,1, '250000', '3')
insert into CT_HoaDon(MaHD, MaSp, TenSp,MauSac,KichThuoc, SoLuong, DonGia, ChietKhau)
values (2, '003', N'Quần Tây Tối Giản HG17',N'Cam','XL', 2, '325000', '10')
insert into CT_HoaDon(MaHD, MaSp, TenSp,MauSac,KichThuoc, SoLuong, DonGia, ChietKhau)
values (3, '001', N'Quần Jean Cotton Tối Giản',N'Xam','L', 2, '250000', '5')
insert into CT_HoaDon(MaHD, MaSp, TenSp,MauSac,KichThuoc, SoLuong, DonGia, ChietKhau)
values (4, '004', N'Áo Khoác Hoddie Zipper - Ver25',N'Trang','L', 1, '325000', '2')

---------------
insert into QLTaiKhoan values(001,'admin','123')
insert into QLTaiKhoan values(002,'thungan1','123')
insert into QLTaiKhoan values(003,'thungan2','123')
insert into QLTaiKhoan values(004,'thungan3','123')
insert into QLTaiKhoan values(005,'nguyennhan','123')
--
