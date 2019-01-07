
Create DATABASE PMach
GO
USE PMach
CREATE TABLE BENHNHAN (
  IDBN int IDENTITY(1,1) PRIMARY KEY,
  TenBN NVARCHAR(100),
  GioiTinh NVARCHAR (10),
  NgaySinh DATE ,
  DiaChi VARCHAR(100) )
CREATE TABLE THUOC (
  IDThuoc int IDENTITY(1,1) PRIMARY KEY,
  TenThuoc NVARCHAR(100) ,
  IDDV INT ,
  SoLuongTon INT,
  DaXoa INT,
  Gia INT )
CREATE TABLE DONTHUOC (
  IDPK INT PRIMARY KEY,
  IDThuoc INT,
  IDDV INT ,
  SoLuong INT ,
  IDCD INT ,
  Gia INT )
CREATE TABLE PHIEUKHAM (
  IDPK int IDENTITY(1,1) PRIMARY KEY,
  NgayKham DATE,
  IDBN INT,
  TrieuChung NVARCHAR(100),
  ChuanDoan INT)
CREATE TABLE HOADON (
  IDHD int IDENTITY(1,1) PRIMARY KEY,
  IDPK INT,
  NgayKham DATE ,
  TienKham INT  DEFAULT 30000,
  TienThuoc INT,
  TongTien INT)
CREATE TABLE BENH (
  IDB int IDENTITY(1,1) PRIMARY KEY,
  LoaiBenh NVARCHAR(100))
CREATE TABLE CACHDUNG (
  IDCD int IDENTITY(1,1) PRIMARY KEY,
  TenCD NVARCHAR(100))
CREATE TABLE DONVI (
  IDDV int IDENTITY(1,1) PRIMARY KEY,
  TenDV NVARCHAR(100))
CREATE TABLE BAOCAO (
  IDBC int IDENTITY(1,1) PRIMARY KEY,
  Thang INT,
  NgayKham DATE ,
  SoBN INT ,
  DoanhThu INT,
  TiLe REAL)
CREATE TABLE BAOCAOTHUOC(
  IDBCT int IDENTITY(1,1) PRIMARY KEY,
  Thang INT,
  IDThuoc INT,
  IDDV INT,
  SoLuong INT DEFAULT 0,
  SoLan INT DEFAULT 0)

ALTER TABLE dbo.DONTHUOC
ADD FOREIGN KEY(IDThuoc)
REFERENCES dbo.THUOC(IDThuoc)
ALTER TABLE dbo.DONTHUOC
ADD FOREIGN KEY(IDCD) 
REFERENCES dbo.CACHDUNG(IDCD)
ALTER TABLE dbo.DONTHUOC
ADD FOREIGN KEY(IDPK) 
REFERENCES dbo.PHIEUKHAM(IDPK)

ALTER TABLE dbo.THUOC
ADD FOREIGN KEY(IDDV) 
REFERENCES dbo.DONVI(IDDV)

ALTER TABLE dbo.PHIEUKHAM
ADD FOREIGN KEY(IDBN) 
REFERENCES dbo.BENHNHAN(IDBN)
ALTER TABLE dbo.PHIEUKHAM
ADD FOREIGN KEY(ChuanDoan) 
REFERENCES dbo.BENH(IDB)

ALTER TABLE dbo.HOADON
ADD FOREIGN KEY(IDPK) 
REFERENCES dbo.PHIEUKHAM(IDPK)
GO

Insert into dbo.BENHNHAN(TenBN,GioiTinh,NgaySinh,DiaChi)
values (N'Nguyễn Văn Tí',N'Nam','1990-11-11',N'Hà Nội')
Insert into dbo.BENHNHAN(TenBN,GioiTinh,NgaySinh,DiaChi)
values (N'Nguyễn Thị Mão',N'Nữ','1980-1-1',N'Yên Bái')
GO
Insert into dbo.BENH(LoaiBenh)
values (N'Viêm Chân Răng')
Insert into dbo.BENH(LoaiBenh)
values (N'Cảm')
Insert into dbo.BENH(LoaiBenh)
values (N'Sốt Xuất Huyết')
Insert into dbo.BENH(LoaiBenh)
values (N'Rối Loại Tiêu Hóa')
Insert into dbo.BENH(LoaiBenh)
values (N'Sốt Siêu Vi')
GO

Insert into dbo.CACHDUNG(TenCD)
values (N'Dùng ngày 3 lần mỗi lần 1 viên sau khi ăn')
Insert into dbo.CACHDUNG(TenCD)
values (N'Dùng ngày 2 lần sáng, tối mỗi lần 1 viên sau khi ăn')
Insert into dbo.CACHDUNG(TenCD)
values (N'Dùng vào buổi sáng mỗi lần 1 viên sau khi ăn')
Insert into dbo.CACHDUNG(TenCD)
values (N'Dùng vào buổi tối mỗi lần 1 viên sau khi ăn')
GO

Insert into dbo.DONVI(TenDV)
values (N'Viên')
Insert into dbo.DONVI(TenDV)
values (N'Chai')
GO

Insert into dbo.THUOC(TenThuoc,IDDV,SoLuongTon,DaXoa,Gia)
values (N'Paracetamol',2,99,0,200000)
Insert into dbo.THUOC(TenThuoc,IDDV,SoLuongTon,DaXoa,Gia)
values (N'Ampicillin',1,99,0,15000)
Insert into dbo.THUOC(TenThuoc,IDDV,SoLuongTon,DaXoa,Gia)
values (N'Vitamin tổng hợp',2,99,0,100000)
GO

Insert into dbo.PHIEUKHAM(NgayKham,IDBN,TrieuChung,ChuanDoan)
values ('2019-1-6',1,N'Sốt,chân răng bị sưng',1)
Insert into dbo.PHIEUKHAM(NgayKham,IDBN,TrieuChung,ChuanDoan)
values ('2019-1-6',2,N'Tiêu chảy,đau bụng theo từng cơn',4)
GO

Insert into dbo.DONTHUOC(IDPK,IDThuoc,IDDV,SoLuong,IDCD,Gia)
values (1,2,1,21,1,315000)
Insert into dbo.DONTHUOC(IDPK,IDThuoc,IDDV,SoLuong,IDCD,Gia)
values (2,1,2,1,1,200000)
GO

Insert into dbo.HOADON(IDPK,NgayKham,TienThuoc,TongTien)
values (1,'2019-1-6',315000,345000)
Insert into dbo.HOADON(IDPK,NgayKham,TienThuoc,TongTien)
values (1,'2019-1-6',200000,230000)
GO

Insert into dbo.BAOCAO(Thang,NgayKham,SoBN,DoanhThu,TiLe)
values (1,'2019-1-6',2,575000,2875000)

Insert into dbo.BAOCAOTHUOC(Thang,IDThuoc,IDDV,SoLuong,SoLan)
values (1,2,1,21,1)
Insert into dbo.BAOCAOTHUOC(Thang,IDThuoc,IDDV,SoLuong,SoLan)
values (1,1,2,1,1)
GO

SELECT * FROM BENHNHAN
SELECT * FROM THUOC
SELECT * FROM CACHDUNG
SELECT * FROM DONVI
SELECT * FROM BENH
SELECT * FROM PHIEUKHAM
SELECT * FROM DONTHUOC
SELECT * FROM HOADON
SELECT * FROM BAOCAO
SELECT * FROM BAOCAOTHUOC
GO
--Hàm load ds bệnh nhân theo ngày(BM1)--
CREATE PROC LayDSBenhNhanByNgay
@NgayKham date
AS
BEGIN
SELECT b.TenBN,b.GioiTinh,b.NgaySinh, b.DiaChi
FROM BENHNHAN b, PHIEUKHAM p
WHERE @NgayKham=p.NgayKham AND p.IDBN=b.IDBN
END
GO

--hàm đếm số bệnh nhân theo ngày (QD1)--
CREATE PROC DemBenhNhanByNgay
@NgayKham date,
@DEM int output
AS
BEGIN
SELECT @DEM=COUNT(*)
FROM PHIEUKHAM p
WHERE p.NgayKham=@NgayKham
END
GO

--lấy thông tin đơn thuốc theo id phiếu khám--
CREATE PROC LayTTDonThuocByPK
@IDPK int
AS
BEGIN
SELECT t.TenThuoc,dv.TenDV,d.SoLuong,c.TenCD
FROM THUOC t, DONTHUOC d,DONVI dv,CACHDUNG c
WHERE @IDPK=d.IDPK AND d.IDThuoc=t.IDThuoc AND dv.IDDV=t.IDDV AND c.IDCD=d.IDCD
END
GO

--hàm load cho biểu mẫu 3--
CREATE PROC LayDSBM3
AS
BEGIN
SELECT bn.TenBN,p.NgayKham,b.LoaiBenh, p.TrieuChung
FROM BENHNHAN bn, PHIEUKHAM p, BENH b
WHERE bn.IDBN=p.IDBN AND p.ChuanDoan=b.IDB
END
GO

--hàm load ds Bệnh nhân--
CREATE PROC LayDSBN
AS
BEGIN
SELECT * FROM BENHNHAN
END
GO

--hàm load ds thuốc còn sử dụng
CREATE PROC LayDSThuoc
AS
BEGIN
SELECT* FROM THUOC
WHERE DaXoa=0
END
GO

--hàm load báo cáo theo tháng--
CREATE PROC LayBC
@thang int
AS
BEGIN
SELECT NgayKham,SoBN,DoanhThu,TiLe
FROM BAOCAO
WHERE Thang=@thang
END
GO

--hàm load báo cáo thuốc theo tháng--
CREATE PROC LayBCT
@thang int
AS
BEGIN
SELECT t.TenThuoc,d.TenDV,b.SoLuong,b.SoLan
FROM BAOCAOTHUOC b, THUOC t,DONVI d
WHERE b.Thang=@thang AND b.IDThuoc=t.IDThuoc AND d.IDDV=b.IDDV
END
GO
--hàm thêm BN--
CREATE PROC ThemBN
@ten NVARCHAR (100),
@gioitinh NVARCHAR(10),
@ngaysinh date,
@diachi NVARCHAR(100)
AS
BEGIN
INSERT INTO BENHNHAN(TenBN,GioiTinh,NgaySinh,DiaChi)
values (@ten,@gioitinh,@ngaysinh,@diachi)
END
GO

--Thêm ĐV--
CREATE PROC ThemDV
@ten NVARCHAR (100)
AS
BEGIN
INSERT INTO DONVI(TenDV)
values (@ten)
END
GO

--Thêm CD--
CREATE PROC ThemCD
@ten NVARCHAR (100)
AS
BEGIN
INSERT INTO CACHDUNG(TenCD)
values (@ten)
END
GO

--Thêm Bệnh--
CREATE PROC ThemB
@ten NVARCHAR (100)
AS
BEGIN
INSERT INTO BENH(LoaiBenh)
values (@ten)
END
GO

--Hàm thêm Thuốc--
CREATE PROC ThemThuoc
@ten NVARCHAR (100),
@iddv INT,
@soluong int,
@xoa int,
@gia int
AS
BEGIN
INSERT INTO THUOC(TenThuoc,IDDV,SoLuongTon,DaXoa,Gia)
values (@ten,@iddv,@soluong,@xoa,@gia)
END
GO

--hàm thêm Đơn thuốc--
CREATE PROC ThemDT
@idpk int,
@idt int,
@iddv INT,
@soluong int,
@idcd int
AS
BEGIN
INSERT INTO DONTHUOC(IDPK,IDThuoc,IDDV,SoLuong,IDCD,Gia)
values (@idpk,@idt,@iddv,@soluong,@idcd,@soluong*(SELECT Gia FROM THUOC WHERE IDThuoc=@idt))
END
GO

--hàm lấy mã pk từ tên BN và ngày khám--
CREATE PROC LayIDPK
@tenBN NVARCHAR (100),
@ngay date,
@id int output
AS
BEGIN
SELECT @id= p.IDPK
FROM PHIEUKHAM p,BENHNHAN b
WHERE b.TenBN=@tenBN AND p.NgayKham=@ngay AND p.IDBN=b.IDBN
END
GO


--hàm tạo hóa đơn--
CREATE PROC TaoHD
@tenBN NVARCHAR (100),
@ngay date,
@tienkham int
AS
BEGIN
DECLARE @idpk int, @tienthuoc int
SET @idpk= LayIDPK(@tenBN,@ngay)
SELECT  @tienthuoc= SUM(Gia)
FROM DONTHUOC
WHERE IDPK=@idpk

INSERT INTO HOADON (IDPK,NgayKham,TienKham,TienThuoc,TongTien)
values (@idpk,@ngay,@tienkham,@tienthuoc,@tienkham+@tienthuoc)
END
GO

--hàm thêm pk--
CREATE PROC ThemPK
@ngay date,
@idbn int,
@trieuchung nvarchar (100),
@idb int
AS
BEGIN
INSERT INTO PHIEUKHAM(NgayKham,IDBN,TrieuChung,ChuanDoan)
values (@ngay,@idbn,@trieuchung,@idb)
END
GO

--hàm xóa BN--
CREATE PROC XoaBN
@idbn int
AS
BEGIN
DELETE FROM BENHNHAN WHERE IDBN=@idbn
DELETE FROM PHIEUKHAM WHERE IDBN=@idbn
DELETE FROM DONTHUOC WHERE IDPK= (SELECT IDPK FROM PHIEUKHAM WHERE IDBN=@idbn) 
END
go

--hàm xóa Đơn Thuốc--
CREATE PROC XoaDT
@iddt int
AS
BEGIN
DELETE FROM DONTHUOC WHERE IDPK=@idDT
END
go

--hàm xóa PK--
CREATE PROC XoaPK
@id int
AS
BEGIN
DELETE FROM PHIEUKHAM WHERE IDBN=@id
DELETE FROM HOADON WHERE IDPK=@id
DELETE FROM DONTHUOC WHERE IDPK=@id
END
go

--hàm xóa HD--
CREATE PROC XoaHD
@id int
AS
BEGIN
DELETE FROM HOADON WHERE IDHD=@id
END
go

--hàm xóa Thuốc--
CREATE PROC XoaThuoc
@Ten nvarchar
AS
BEGIN
UPDATE THUOC 
SET DaXoa=1
WHERE IDThuoc=@ten

END
go

--hàm xóa CD--
CREATE PROC XoaCD
@id int
AS
BEGIN
DELETE FROM CACHDUNG WHERE IDCD=@id
DELETE FROM DONTHUOC WHERE IDCD=@id
END
go

--hàm xóa DV--
CREATE PROC XoaDV
@id int
AS
BEGIN
DELETE FROM DONVI WHERE IDDV=@id
DELETE FROM THUOC WHERE IDDV=@id
END
go

--hàm xóa Bệnh--
CREATE PROC XoaB
@id int
AS
BEGIN
DELETE FROM BENH WHERE IDB=@id
DELETE FROM PHIEUKHAM WHERE ChuanDoan=@id
END
go

--hàm sửa TT BN
CREATE PROC SuaBN
@id INT,
@ten NVARCHAR (100),
@gioitinh NVARCHAR(10),
@ngaysinh date,
@diachi NVARCHAR(100)
AS
BEGIN
UPDATE BENHNHAN 
SET TenBN=@ten,GioiTinh=@gioitinh,NgaySinh=@ngaysinh,DiaChi=@diachi 
WHERE IDBN=@id
END
GO

--SỬa ĐV--
CREATE PROC SuaDV
@id int,
@ten NVARCHAR (100)
AS
BEGIN
UPDATE DONVI
SET TenDV=@ten
WHERE IDDV=@id
END
GO

--SỬa Bệnh--
CREATE PROC SuaB
@id int,
@ten NVARCHAR (100)
AS
BEGIN
UPDATE BENH
SET LoaiBenh=@ten
WHERE IDB=@id
END
GO

--SỬa CD--
CREATE PROC SuaCD
@id int,
@ten NVARCHAR (100)
AS
BEGIN
UPDATE CACHDUNG
SET TenCD=@ten
WHERE IDCD=@id
END
GO

--Hàm SỬA Thuốc--
CREATE PROC SuaThuoc
@id int,
@ten NVARCHAR (100),
@iddv INT,
@soluong int,
@xoa int,
@gia int
AS
BEGIN
UPDATE THUOC
SET TenThuoc=@ten,IDDV=@iddv,SoLuongTon=@soluong,DaXoa=@xoa,Gia=@gia
WHERE IDThuoc=@id
END
GO

--hàm Sửa Đơn thuốc--
CREATE PROC SuaDT
@idpk int,
@idt int,
@iddv INT,
@soluong int,
@idcd int
AS
BEGIN
UPDATE DONTHUOC
SET IDThuoc=@idt,IDDV=@iddv,SoLuong=@soluong,IDCD=@idcd,Gia=@soluong*(SELECT Gia FROM THUOC WHERE IDThuoc=@idt)
WHERE IDPK=@idpk
END
GO

--hàm sửa pk--
CREATE PROC SuaPK
@id int,
@ngay date,
@idbn int,
@trieuchung nvarchar (100),
@idb int
AS
BEGIN
UPDATE PHIEUKHAM
SET NgayKham=@ngay,IDBN=@idbn,TrieuChung=@trieuchung,ChuanDoan=@idb
WHERE IDPK=@id
END
GO

--hàm update Báo Cáo cho mỗi lần thêm phiếu khám--
CREATE PROC UpdateThemBC
@IDPK INT
AS
BEGIN
DECLARE @thang int
DECLARE @ngay date
DECLARE @tien int

SELECT @ngay= NgayKham
FROM PHIEUKHAM
WHERE @IDPK=IDPK

SELECT @thang= MONTH( NgayKham)
FROM PHIEUKHAM
WHERE @IDPK=IDPK

SELECT @tien= TongTien
FROM  HOADON
WHERE @IDPK=IDPK 

IF (NOT EXISTS (SELECT *
			   FROM BAOCAO
				WHERE Thang=@thang))
INSERT INTO dbo.BAOCAO (Thang,NgayKham,SoBN,DoanhThu,TiLe)
values (@thang,@ngay,1,@Tien,@Tien)
ELSE
BEGIN
IF (NOT EXISTS (SELECT *
			   FROM BAOCAO
				WHERE NgayKham=@ngay))
	INSERT INTO dbo.BAOCAO(Thang,NgayKham,SoBN,DoanhThu,TiLe)
	values (@thang,@ngay,1,@tien,@tien)
ELSE
UPDATE dbo.	BAOCAO
SET SoBN=SoBN+1,DoanhThu=DoanhThu+@tien,TiLe=(DoanhThu+@tien)/(SoBN+1)
END
END
GO

--hàm update Báo cáo thuốc khi thêm phiếu khám--
CREATE PROC UpdateThemBCT
@IDPK INT
AS
BEGIN
DECLARE @idt int
DECLARE @soluong int
DECLARE @iddv int
DECLARE @thang int
 
SELECT @idt= IDThuoc
FROM DONTHUOC
WHERE @IDPK=IDPK

SELECT @soluong= SoLuong
FROM DONTHUOC
WHERE @IDPK=IDPK

SELECT @iddv= IDDV
FROM DONTHUOC
WHERE @IDPK=IDPK


SELECT @thang= MONTH( NgayKham)
FROM PHIEUKHAM
WHERE @IDPK=IDPK

IF (NOT EXISTS (SELECT *
			   FROM BAOCAOTHUOC
				WHERE Thang=@thang))
INSERT INTO dbo.BAOCAOTHUOC (Thang,IDThuoc,IDDV,SoLuong,SoLan)
values (@thang,@idt,@iddv,@soluong,1)
ELSE
BEGIN
IF (NOT EXISTS (SELECT *
			   FROM BAOCAOTHUOC
				WHERE IDThuoc=@idt))
	INSERT INTO dbo.BAOCAOTHUOC(Thang,IDThuoc,IDDV,SoLuong,SoLan)
	values (@thang,@idt,@iddv,@soluong,1)
ELSE
UPDATE dbo.	BAOCAOTHUOC
SET Soluong=Soluong+@soluong,SoLan=SoLan+1
END
END

--hàm load danh sách bệnh nhân trong ngày đó ( thời gian lấy từ thời gian hệ thống )
create proc loadDSBNinDay
as
begin
select distinct bn.IDBN,bn.TenBN,bn.GioiTinh,bn.NgaySinh,bn.DiaChi
from BENHNHAN bn join PHIEUKHAM pk on bn.IDBN=pk.IDBN
where pk.NgayKham in (SELECT convert(varchar, getdate(), 111))
end
go
--drop proc loadDSBNinDay
exec loadDSBNinDay
go


--hàm load tên thuốc để chọn
create proc loadListMedicineToSelect
as
begin
	select distinct THUOC.TenThuoc
	from THUOC
end
go

exec loadListMedicineToSelect