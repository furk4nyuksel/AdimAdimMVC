Create Database SqlDers

Use SqlDers

create table Test (Kolon1 int , Kolon2 nvarchar(50))

create table AppUser(UserId int  primary key identity ,UserName nvarchar(50),Password nvarchar(50),IsActive bit)

insert into [TabloAdı] (EklenecekKolon1,EklenecekKolon2,EklenecekKolon3) values (EklenecekKolon1değeri,EklenecekKolon2değeri,EklenecekKolon3değeri)
 
insert into AppUser (UserName,Password,IsActive) values ('ibanez75612','123',1);

select * from AppUser

select UserName from AppUser

select UserName,Password from AppUser

insert into AppUser (UserName,Password,IsActive) values ('tht','123',1);
insert into AppUser (UserName,Password,IsActive) values ('ahmet','123',1);
insert into AppUser (UserName,Password,IsActive) values ('hasan','123',1);
insert into AppUser (UserName,Password,IsActive) values ('user','123',1);
insert into AppUser (UserName,Password,IsActive) values ('ali','123',0);
insert into AppUser (UserName,Password,IsActive) values ('veli','123',0);

select * from AppUser where IsActive=1

select * from AppUser where UserId>=1 and UserId<=3

select count(*) as KolonAdı from AppUser


alter table AppUser add   Age int 

select * from AppUser

 Update AppUser set Age=20 where Age is null

 select * from AppUser

 Select Sum(Age) as YaşToplamı from  AppUser

 Select Avg(Age) as YaşOrtalaması from  AppUser





  Create Table City(CityId int identity primary key, CityName nvarchar(50))

  Create Table County(CountyId int identity primary key,CountyName nvarchar(50),CityId int references City(CityId))

  insert into City(CityName) values ('Adana')
  insert into City(CityName) values ('Adıyaman')
  insert into City(CityName) values ('Afyon')

  insert into County(CountyName,CityId) values ('Seyhan',1)
  insert into County(CountyName,CityId) values ('Ceyhan',1)
  insert into County(CountyName,CityId) values ('Hürriyet',1)--Adana son
  insert into County(CountyName,CityId) values ('Gerger',2)
  insert into County(CountyName,CityId) values ('Kahta',2)
  insert into County(CountyName,CityId) values ('Sincik',2)--Adıyaman son
  insert into County(CountyName,CityId) values ('Çay',3)
  insert into County(CountyName,CityId) values ('Şuhut',3)
  insert into County(CountyName,CityId) values ('Dinar',3)--Afyon son


  select * from City
  select * from County

  select ct.CityName,cy.CountyName from County as cy join City as ct on ct.CityId=cy.CityId



--Silme İşlemleri
--Örnek Database Silmek  <b>Drop Database [Databaseİsmi] </b>

--Örnek Tablo Silmek <b>Drop Table [Tabloİsmi] </b>


-- normalde bağlantılı tablolardan bir şey silinmez ama size göstermek için county tablosunda silebilirim

 delete from County where CountyId=9
