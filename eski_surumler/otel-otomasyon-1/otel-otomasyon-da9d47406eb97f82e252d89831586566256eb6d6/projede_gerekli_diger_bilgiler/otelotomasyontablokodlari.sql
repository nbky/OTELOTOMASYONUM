create table odalar(
ID int identity(1,1) not null primary key,
isim varchar(3) not null ,
limit tinyint default 1,
durum nvarchar(4) default 'Boþ'
);
go
create table musteriler(
ID int identity(1,1) not null primary key,
TCKimlik varchar(11) not null unique,
Ad nvarchar(30) not null,
Soyad nvarchar(30) not null,
Telefon nvarchar(11) not null,
Cinsiyet varchar(5),
Medenihal varchar(5)

);
go
create table hangiodadakimvar (
ID int identity(1,1) not null primary key,
OdaID int,
MusteriID int,
GirisTarihi date,
CikisTarihi date,
Durum nvarchar(5) default 'Giriþ'
Constraint FK_OdaID
foreign key (OdaID) References odalar(ID),
constraint FK_MusteriID
foreign key (MusteriID) References musteriler(ID)

);

