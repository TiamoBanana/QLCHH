﻿CREATE DATABASE QLCHH
GO
USE QLCHH;

CREATE TABLE CHUDE (
	MACHUDE NVARCHAR (50) NOT NULL,
	TENCHUDE NVARCHAR (30) NOT NULL,
	PRIMARY KEY (MACHUDE)
)
GO

CREATE TABLE HOA (
	MAHOA NVARCHAR (50) NOT NULL,
	TENHOA NVARCHAR (50) NOT NULL,
	MACHUDE NVARCHAR (50) NOT NULL FOREIGN KEY (MACHUDE) REFERENCES CHUDE (MACHUDE),
	SOLUONG INT NOT NULL,
	DONGIANHAP FLOAT (53) NOT NULL,
	DONGIABAN FLOAT (53) NOT NULL,
	ANH NVARCHAR (300) NOT NULL,
	GHICHU TEXT NULL,
	PRIMARY KEY (MAHOA)
)
GO

CREATE TABLE KHACHHANG (
	MAKHACH NVARCHAR (50) NOT NULL,
	TENKHACH NVARCHAR (50) NOT NULL,
	DIACHI NVARCHAR (50) NOT NULL,
	DIENTHOAI NVARCHAR (20) NOT NULL,
	PRIMARY KEY (MAKHACH)
)
GO

CREATE TABLE NHANVIEN (
	MANHANVIEN NVARCHAR (50) NOT NULL,
	TENNHANVIEN NVARCHAR (50) NOT NULL,
	GIOITINH NVARCHAR (10) NOT NULL,
	DIACHI NVARCHAR (50) NOT NULL,
	DIENTHOAI NVARCHAR (10) NOT NULL,
	NGAYSINH DATETIME NOT NULL,
	PRIMARY KEY (MANHANVIEN)
)
GO

CREATE TABLE HOADON (
	MAHOADON NVARCHAR (30) NOT NULL,
	MANHANVIEN NVARCHAR (50) NOT NULL FOREIGN KEY (MANHANVIEN) REFERENCES NHANVIEN (MANHANVIEN),
	MAKHACH NVARCHAR (50) NOT NULL FOREIGN KEY (MAKHACH) REFERENCES KHACHHANG (MAKHACH),
	NGAYBAN DATETIME NOT NULL,
	MAHOA NVARCHAR (50) NOT NULL FOREIGN KEY (MAHOA) REFERENCES HOA (MAHOA),
	SOLUONG INT NOT NULL,
	DONGIA FLOAT (53) NOT NULL,
	THANHTIEN FLOAT (53) NOT NULL,
	PRIMARY KEY (MAHOADON)
)
GO

CREATE TABLE TAIKHOAN (
	TENDANGNHAP NVARCHAR (50) PRIMARY KEY,
	MATKHAU NVARCHAR (50) NOT NULL,
	NGUOIDUNG NVARCHAR (50) NOT NULL,
	QUYENHAN NVARCHAR (20) NOT NULL,
	ANH NVARCHAR (300) NOT NULL
)

/*Dữ liệu khách hàng*/
INSERT INTO HOADON VALUES (N'HDB001', N'NV001', N'KH002', N'2022-04-19', N'H001', 3, 100000, 300000);

/*Dữ liệu khách hàng*/
INSERT INTO KHACHHANG VALUES (N'KH001', N'Mai Tiến Khôi', N'237, Hà Hoàng Hổ, phường Đông Xuyên', N'0368408750');
INSERT INTO KHACHHANG VALUES (N'KH002', N'Võ Tấn Khôi', N'237, Hà Hoàng Hổ, phường Đông Xuyên', N'0368408750');
INSERT INTO KHACHHANG VALUES (N'KH003', N'Trần Thanh Nhàng', N'237, Hà Hoàng Hổ, phường Đông Xuyên', N'0368408750');
INSERT INTO KHACHHANG VALUES (N'KH004', N'Nguyễn Quốc Toàn', N'237, Hà Hoàng Hổ, phường Đông Xuyên', N'0368408750');
INSERT INTO KHACHHANG VALUES (N'KH005', N'Vương Trường Giang', N'237, Hà Hoàng Hổ, phường Đông Xuyên', N'0368408750');

SELECT * FROM KHACHHANG

/*Dữ liệu nhân viên*/
INSERT INTO NHANVIEN VALUES (N'NV001', N'Mai Tiến Khôi', N'Male', N'237, Hà Hoàng Hổ, phường Đông Xuyên', N'0368408750', '1985-04-19');
INSERT INTO NHANVIEN VALUES (N'NV002', N'Võ Tấn Khôi', N'Male', N'237, Hà Hoàng Hổ, phường Đông Xuyên', N'0368408750', '1985-04-19');
INSERT INTO NHANVIEN VALUES (N'NV003', N'Trần Thanh Nhàng', N'Male', N'237, Hà Hoàng Hổ, phường Đông Xuyên', N'0368408750', '1985-04-19');
INSERT INTO NHANVIEN VALUES (N'NV004', N'Nguyễn Quốc Toàn', N'Female', N'237, Hà Hoàng Hổ, phường Đông Xuyên', N'0368408750', '2001-04-19');
INSERT INTO NHANVIEN VALUES (N'NV005', N'Lê Hoàng Phong', N'Female', N'237, Hà Hoàng Hổ, phường Đông Xuyên', N'0368408750', '1985-04-19');

SELECT * FROM NHANVIEN

/*Dữ liệu nhân viên*/
INSERT INTO CHUDE VALUES (N'CD001',N'Hoa Valentine');
INSERT INTO CHUDE VALUES (N'CD002',N'Ngày của mẹ');
INSERT INTO CHUDE VALUES (N'CD003',N'Ngày 8-3');
INSERT INTO CHUDE VALUES (N'CD004',N'Hoa cưới cầm tay');
INSERT INTO CHUDE VALUES (N'CD005',N'Hoa kỉ niệm ngày cưới');

SELECT * FROM CHUDE

/*Dữ liệu bảng hoa*/
INSERT INTO HOA VALUES (N'H001', N'asdasd', N'CD002', 20, 200000, 300000, N'image.png', N'asdasd');

select *from hoa

/*Dữ liệu bảng tài khoản*/
INSERT INTO TAIKHOAN VALUES (N'khoi1', N'123', N'Mai Tiến Khôi', N'Admin', N'image.png');

select *from taikhoan
