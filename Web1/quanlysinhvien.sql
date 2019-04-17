
use master
go
if exists (select name from sysdatabases where name='LAB2_QLSV')
	drop database LAB_QLSV
go
create database QLSV
go
USE QLSV
go
create table LOP
(
	MALOP		char(8)		not null	primary key,
	TENLOP		varchar(30)	not null	unique
)
go
create table SINHVIEN
(
	MASV		char(8)			not null	primary key,
	HO			varchar(40)		not null, 
	TEN			varchar(10)		not null,
	NGAYSINH	smalldatetime	NULL,		
	PHAI		char(3)			not null	default 'nam',
	NOISINH		varchar(50)		NULL		default '',
	DIACHI		varchar(100)	NULL		default '',
	NGHIHOC		bit				NULL		default 0,
	MALOP		char(8)			null,	
	foreign key(MALOP) references LOP(MALOP)
)
GO
create table MONHOC
(
	MAMH		char(8)		not null	primary key,
	TENMH		char(30)	not null	unique,
	SOTIET_LT	int			NULL		default 45
				check(SOTIET_LT>=0 and SOTIET_LT<=120),
	SOTIET_TH	int			NULL		default 0
				check(SOTIET_TH>=0 and SOTIET_TH<=120)
)
go

create table DIEM
(
	MASV	char(8)	NOT NULL,
	MAMH	char(8)	NOT NULL,
	LAN		int		not null,				                                
	HOCKY	int		not null
					check(HOCKY>=1 and HOCKY<=8),
	DIEM	float	not null
					check((DIEM>=0 and DIEM<=10)or DIEM =1),
	constraint pk_diem primary key(MASV,MAMH,LAN),
	foreign key(MASV)references SINHVIEN(MASV),
	FOREIGN KEY(MAMH)REFERENCES MONHOC(MAMH)
)
go

insert into LOP values('MMT1','Mang may tinh 1')
insert into LOP values('MMT2','Mang may tinh 2')
insert into LOP values('MMT3','Mang may tinh 3')
insert into LOP values('CNPM1','cong nghe phan mem 1')
insert into LOP values('CNPM2','cong nghe phan mem 2')
insert into LOP values('HTTT1','He thong thong tin 1')
insert into LOP values('HTTT2','He thong thong tin 2')
insert into LOP values('HTTT3','He thong thong tin 3')
insert into LOP values('HTTT4','He thong thong tin 4')
GO
select *from LOP
GO
insert into SINHVIEN values('SV1','TRAN VAN','LONG','4/10/1985','nam','HAI PHONG','12.TRAN QUOC TOAN Q.1',0,'MMT2')
insert into SINHVIEN values('SV7','BUI THI DIEM','NGOC','6/6/1985','nu','BINH DUONG','18/7.NGUYEN KIEM Q.PHU NHUAN',0,'MMT2')
insert into SINHVIEN values('SV3','TRAN THI LE','THUY','4/11/1984','nu','TP HCM','42.LAC LONG QUAN Q.TB',0,'HTTT2')
insert into SINHVIEN values('SV5','HOANG THI NGOC','LAN','5/12/1983','nu','BEN TRE','122.PHAN THI NHO Q.TB',0,'CNPM1')
insert into SINHVIEN values('SV6','PHAN QUOC','HUNG','4/1/1982','nam','DONG NAI','12.BUI THI XUAN Q.1',0,'HTTT1')
insert into SINHVIEN values('SV4','PHAM THANH','TRINH','10/5/1986','nam','LONG AN','30/6.NO TRANG LONG Q.BT',0,'CNPM1')
insert into SINHVIEN values('SV2','LE THI','NGOC','5/10/1984','nu','BRVT','26.LUY BAN BICH.Q.TAN PHU',0,'HTTT1')
go
select *from SINHVIEN
go
insert into MONHOC values('MT','TOAN',45,0)
insert into MONHOC values('ML','LY',45,0)
insert into MONHOC values('MTHDC','TIN HOC DAI CUONG',45,45)
insert into MONHOC values('MKTCT','KINH TE CHINH TRI',45,0)
insert into MONHOC values('MKTLT','KY THUAT LAP TRINH',60,45)
insert into MONHOC values('MMMT','MANG MAY TINH',45,45)
insert into MONHOC values('MAV','ANH VAN',60,0)
go
select *from MONHOC
go
insert into DIEM values('SV2','MAV',1,2,6.5)
insert into DIEM values('SV2','MT',1,2,9)
insert into DIEM values('SV1','MTHDC',1,3,4)
insert into DIEM values('SV3','MKTCT',1,2,3)
insert into DIEM values('SV3','ML',1,2,7)
insert into DIEM values('SV1','MT',1,2,6.5)
insert into DIEM values('SV1','MAV',1,2,9)
insert into DIEM values('SV1','MKTCT',1,2,7)
insert into DIEM values('SV1','ML',1,3,6.5)
insert into DIEM values('SV1','MMMT',2,2,4.5)
insert into DIEM values('SV1','MKTLT',1,3,8)
