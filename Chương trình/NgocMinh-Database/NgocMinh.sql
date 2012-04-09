CREATE TABLE KhachHang
(
	MaKH varchar(5) primary key,
	TenKH nvarchar(50) not null,
	DiaChi nvarchar(100),
	DienThoai varchar(11),
)

CREATE TABLE NhaCungCap
(
	MaNCC varchar(5) primary key,
	TenNCC nvarchar(50) not null,
	DiaChi nvarchar(100),
	DienThoai varchar(11),
)

CREATE TABLE KhoanThu
(
	MaKT int primary key identity,
	TenKT nvarchar(100) not null,
	GhiChu ntext
)

CREATE TABLE KhoanChi
(
	MaKC int primary key identity,
	TenKC nvarchar(100) not null,
	GhiChu ntext
)

CREATE TABLE NhanVien
(
	MaNV varchar(5) primary key,
	TenNV nvarchar(50) not null,
	NgaySinh datetime,
	GioiTinh bit default(0),
	CMND varchar(11),
	DiaChi nvarchar(100),
	DienThoai varchar(11)
)

CREATE TABLE QuyDinh
(
	TenCongTy nvarchar(255),
	DiaChi nvarchar(255),
	DienThoai varchar(11),
	LichSaoLuu int default(0),
	ThoiDiemSaoLuuTiepTheo datetime,
	ViTriSaoLuu nvarchar(255),
	TimKiemTuDong bit default(1),
	TaiKhoanCo bigint default(0)
)

CREATE TABLE LoaiNguoiDung
(
	MaLoaiNguoiDung int primary key identity,
	TenLoaiNguoiDung nvarchar(100)
)

CREATE TABLE NguoiDung
(
	MaNguoiDung int primary key identity,
	MaLoaiNguoiDung int not null,
	TenDangNhap varchar(100) not null,
	MatKhau varchar(255) not null,
	TenNguoiDung nvarchar(100),
	constraint fk_NguoiDung_LoaiNguoiDung foreign key(MaLoaiNguoiDung) references LoaiNguoiDung(MaLoaiNguoiDung)
)

CREATE TABLE PhieuThu
(
	SoPT int primary key identity,
	MaKH varchar(5) not null,
	NgayLap datetime not null,
	NgayThu datetime,
	MaKT int not null,
	SoTienThu bigint not null check(SoTienThu>0),
	Ton bigint,
	GhiChu ntext,
	TinhTrang bit default(0),
	DuTru bigint,
	constraint fk_PT_KH foreign key (MaKH) references KhachHang(MaKH),
	constraint fk_PT_KT foreign key (MaKT) references KhoanThu(MaKT)
)

CREATE TABLE PhieuChi
(
	SoPC int primary key identity,
	MaNV varchar(5) not null,
	NgayLap datetime not null,
	NgayChi datetime,
	MaKC int not null,
	SoTienChi bigint not null check(SoTienChi>0),
	Ton bigint,
	GhiChu ntext,
	TinhTrang bit default(0),
	DuTru bigint,
	constraint fk_PC_NV foreign key (MaNV) references NhanVien(MaNV),
	constraint fk_PC_KC foreign key (MaKC) references KhoanChi(MaKC)
)

CREATE TABLE LoaiPhieu
(
	MaLoaiPhieu int primary key identity,
	TenLoaiPhieu nvarchar(50),
	SoPhieuTruoc int default(0)
)

CREATE TABLE GiaoDichKH
(
	MaGD int primary key identity,
	MaKH varchar(5) not null,
	NgayBatDauGD datetime,
	SoTienVay bigint check(SoTienVay>=0) default(0),
	SoTienConNo bigint check(SoTienConNo>=0) default(0),
	SoTienLaiDaTra bigint check(SoTienLaiDaTra>=0) default(0),
	GhiChu ntext,
	TinhTrang bit default(0),
	constraint fk_GD_KH foreign key (MaKH) references KhachHang(MaKH),
)

CREATE TABLE PhieuNhanNoKH
(
	SoPhieuNhanNo int primary key identity,
	MaGD int not null,
	NgayBatDauNhanNo datetime,
	SoTienVay bigint check(SoTienVay>=0) default(0),
	SoTienConNo bigint check(SoTienConNo>=0) default(0),
	SoTienLaiDaTra bigint check(SoTienLaiDaTra>=0) default(0),
	LyDoVay ntext,
	LaiSuat tinyint default(0),
	KyHanNo tinyint check(KyHanNo>0) default(1),
	KyHanLai tinyint check(KyHanLai>0) default(1),
	NgayTraLaiTiepTheo datetime,
	KyHanThongBao tinyint check(KyHanThongBao>0) default(1),
	PhatQuaHan bit default(0),
	TinhTrang bit default(0),
	SoPhieuNhanNoKHCTCuoi int,
	constraint fk_PNNKH_GD foreign key (MaGD) references GiaoDichKH(MaGD)
)

CREATE TABLE PhieuNhanNoKHCT
(
	SoPhieuNhanNoCT int primary key identity,
	SoPhieuNhanNo int not null,
	SoPhieu int not null,
	MaLoaiPhieu int not null,
	NgayLapPhieu datetime not null,
	NgayGiaoDich datetime,
	SoTienVay bigint check(SoTienVay >= 0),
	SoTienTra bigint check(SoTienTra >= 0),
	SoTienTinhLai bigint,
	SoPhieuNhanNoKHCTTiep int,
	TienLai bigint,
	Ton bigint,
	TinhTrang bit default(0),
	constraint fk_PNNKHCT_PNNKH foreign key (SoPhieuNhanNo) references PhieuNhanNoKH(SoPhieuNhanNo),
	constraint fk_PNNKHCT_LoaiPhieu foreign key (MaLoaiPhieu) references LoaiPhieu(MaLoaiPhieu)
)

CREATE TABLE GiaoDichNCC
(
	MaGD int primary key identity,
	MaNCC varchar(5) not null,
	NgayBatDauGD datetime,
	SoTienVay bigint check(SoTienVay>=0) default(0),
	SoTienConNo bigint check(SoTienConNo>=0) default(0),
	SoTienLaiDaTra bigint check(SoTienLaiDaTra>=0) default(0),
	GhiChu ntext,
	TinhTrang bit default(0),
	constraint fk_GD_NCC foreign key (MaNCC) references NhaCungCap(MaNCC)
)

CREATE TABLE PhieuNhanNoNCC
(
	SoPhieuNhanNo int primary key identity,
	MaGD int not null,
	NgayBatDauNhanNo datetime,
	SoTienVay bigint check(SoTienVay>=0) default(0),
	SoTienConNo bigint check(SoTienConNo>=0) default(0),
	SoTienLaiDaTra bigint check(SoTienLaiDaTra>=0) default(0),
	LyDoVay ntext,
	LaiSuat tinyint default(0),
	KyHanNo int check(KyHanNo>0) default(1),
	KyHanLai int check(KyHanLai>0) default(1),
	NgayTraLaiTiepTheo datetime,
	KyHanThongBao int check(KyHanThongBao>0) default(1),
	PhatQuaHan bit default(0),
	TinhTrang bit default(0),
	SoPhieuNhanNoNCCCTCuoi int,
	constraint fk_PNNNCC_GD foreign key (MaGD) references GiaoDichNCC(MaGD)
)

CREATE TABLE PhieuNhanNoNCCCT
(
	SoPhieuNhanNoCT int primary key identity,
	SoPhieuNhanNo int not null,
	SoPhieu int not null,
	MaLoaiPhieu int not null,
	NgayLapPhieu datetime not null,
	NgayGiaoDich datetime,
	SoTienVay bigint check(SoTienVay >= 0),
	SoTienTra bigint check(SoTienTra >= 0),
	SoTienTinhLai bigint,
	SoPhieuNhanNoKHCTTiep int,
	TienLai bigint,
	Ton bigint,
	constraint fk_PNNNCCCT_PNNNCC foreign key (SoPhieuNhanNo) references PhieuNhanNoNCC(SoPhieuNhanNo),
	constraint fk_PNNNCCCT_LoaiPhieu foreign key (MaLoaiPhieu) references LoaiPhieu(MaLoaiPhieu)
)

CREATE TABLE HanTraLaiKH
(
	MaHanTraLai int primary key identity,
	SoPhieuNhanNo int not null,
	NgayThayDoi timestamp,
	KyHanLai int check(KyHanLai>0) default(1),
	NgayTraLaiTiepTheo datetime,
	constraint fk_PNNKH_HanTraLaiKH foreign key (SoPhieuNhanNo) references PhieuNhanNoKH(SoPhieuNhanNo),
)

CREATE TABLE HanTraNoKH
(
	MaHanTraNo int primary key identity,
	SoPhieuNhanNo int not null,
	NgayThayDoi timestamp,
	KyHanNo int check(KyHanNo>0) default(1),
	constraint fk_PNNKH_HanTraNoKH foreign key (SoPhieuNhanNo) references PhieuNhanNoKH(SoPhieuNhanNo),
)

CREATE TABLE HanTraLaiNCC
(
	MaHanTraLai int primary key identity,
	SoPhieuNhanNo int not null,
	NgayThayDoi timestamp,
	KyHanLai int check(KyHanLai>0) default(1),
	NgayTraLaiTiepTheo datetime,
	constraint fk_PNNNCC_HanTraLaiNCC foreign key (SoPhieuNhanNo) references PhieuNhanNoNCC(SoPhieuNhanNo),
)

CREATE TABLE HanTraNoNCC
(
	MaHanTraNo int primary key identity,
	SoPhieuNhanNo int not null,
	NgayThayDoi timestamp,
	KyHanNo int check(KyHanNo>0) default(1),
	constraint fk_PNNNCC_HanTraNoNCC foreign key (SoPhieuNhanNo) references PhieuNhanNoNCC(SoPhieuNhanNo),
)
---------------------------------------------------------------------------------------------------------
-- CAC THU TUC
---------------------------------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[Insert_PhieuThu]
(
	@MaKH varchar(5),
	@NgayLap datetime,
	@NgayThu datetime,
	@MaKT int,
	@SoTienThu bigint,
	@GhiChu ntext,
	@TinhTrang bit,
	@MaPhieuThu int OUTPUT
)
AS
BEGIN
	DECLARE @TaiKhoanCo bigint
	SET @TaiKhoanCo=0
	IF @TinhTrang=1
	BEGIN
		SELECT @TaiKhoanCo=TaiKhoanCo FROM QuyDinh
		SET @TaiKhoanCo=@TaiKhoanCo+@SoTienThu
		UPDATE QuyDinh SET TaiKhoanCo=@TaiKhoanCo
	END
	INSERT INTO PhieuThu(MaKH,NgayLap,NgayThu,MaKT,SoTienThu,GhiChu,Ton,TinhTrang) 
	Values (@MaKH, @NgayLap, @NgayThu, @MaKT, @SoTienThu,@GhiChu, @TaiKhoanCo,@TinhTrang)
	SET @MaPhieuThu = SCOPE_IDENTITY()
END
/*
DECLARE @MaPhieuThu int
EXEC Insert_PhieuThu 'KH001','10/4/2012','10/4/2012',1,1250000,N'asdf',1,@MaPhieuThu OUTPUT
SELECT @MaPhieuThu
*/
ALTER PROCEDURE [dbo].[Insert_PhieuChi]
(
	@MaNV varchar(5),
	@NgayLap datetime,
	@NgayChi datetime,
	@MaKC int,
	@SoTienChi bigint,
	@GhiChu ntext,
	@TinhTrang bit,
	@MaPhieuChi int OUTPUT
)
AS
BEGIN
	DECLARE @TaiKhoanCo bigint
	SET @TaiKhoanCo=0
	IF @TinhTrang=1
	BEGIN
		SELECT @TaiKhoanCo=TaiKhoanCo FROM QuyDinh
		SET @TaiKhoanCo=@TaiKhoanCo-@SoTienChi
		UPDATE QuyDinh SET TaiKhoanCo=@TaiKhoanCo
	END
	INSERT INTO PhieuChi(MaNV,NgayLap,NgayChi,MaKC,SoTienChi,GhiChu,Ton,TinhTrang) 
	Values (@MaNV, @NgayLap, @NgayChi, @MaKC, @SoTienChi,@GhiChu, @TaiKhoanCo,@TinhTrang)
	SET @MaPhieuChi = SCOPE_IDENTITY()
END
/*
DECLARE @MaPhieuChi int
EXEC Insert_PhieuChi 'NV001','10/4/2012','10/4/2012',1,1250000,N'asdf',0,@MaPhieuChi OUTPUT
SELECT @MaPhieuChi
*/
CREATE PROCEDURE [dbo].[Update_PhieuThu]
(
	@SoPT int,
	@MaKH varchar(5),
	@NgayLap datetime,
	@NgayThu datetime,
	@MaKT int,
	@SoTienThu bigint,
	@GhiChu ntext,
	@TinhTrang bit
)
AS
BEGIN
	DECLARE @TinhTrangCu bit
	SELECT @TinhTrangCu = TinhTrang FROM PhieuThu WHERE SoPT = @SoPT
	IF @TinhTrangCu=0
	BEGIN
		DECLARE @TaiKhoanCo bigint
		SET @TaiKhoanCo=0
		IF @TinhTrang=1
		BEGIN
			SELECT @TaiKhoanCo=TaiKhoanCo FROM QuyDinh
			SET @TaiKhoanCo=@TaiKhoanCo+@SoTienThu
			UPDATE QuyDinh SET TaiKhoanCo=@TaiKhoanCo
		END
		UPDATE PhieuThu SET MaKH = @MaKH, NgayLap = @NgayLap,NgayThu = @NgayThu,MaKT = @MaKT,
			SoTienThu = @SoTienThu,GhiChu = @GhiChu,Ton = @TaiKhoanCo,TinhTrang = @TinhTrang
		WHERE SoPT = @SoPT
	END
END
/*
EXEC Update_PhieuThu 1,'KH001','10/5/2012','11/5/2012',1,1250000,N'asdf',1
*/
CREATE PROCEDURE [dbo].[Update_PhieuChi]
(
	@SoPC int,
	@MaNV varchar(5),
	@NgayLap datetime,
	@NgayChi datetime,
	@MaKC int,
	@SoTienChi bigint,
	@GhiChu ntext,
	@TinhTrang bit
)
AS
BEGIN
	DECLARE @TinhTrangCu bit
	SELECT @TinhTrangCu = TinhTrang FROM PhieuChi WHERE SoPC = @SoPC
	IF @TinhTrangCu=0
	BEGIN
		DECLARE @TaiKhoanCo bigint
		SET @TaiKhoanCo=0
		IF @TinhTrang=1
		BEGIN
			SELECT @TaiKhoanCo=TaiKhoanCo FROM QuyDinh
			SET @TaiKhoanCo=@TaiKhoanCo-@SoTienChi
			UPDATE QuyDinh SET TaiKhoanCo=@TaiKhoanCo
		END
		UPDATE PhieuChi SET MaNV = @MaNV, NgayLap = @NgayLap,NgayChi = @NgayChi,MaKC = @MaKC,
			SoTienChi = @SoTienChi,GhiChu = @GhiChu,Ton = @TaiKhoanCo,TinhTrang = @TinhTrang
		WHERE SoPC = @SoPC
	END
END
/*
EXEC Update_PhieuChi 4,'NV001','10/4/2012','10/4/2012',1,1250000,N'asdf',1
*/