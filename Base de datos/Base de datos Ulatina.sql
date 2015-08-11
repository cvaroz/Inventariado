
if exists (select name from dbo.sysobjects [Ulatina])
drop database [Ulatina]
go

---Se crea la base de datos---
Create database "Ulatina"
go

---Se usa la base de datos---
Use "Ulatina"
go

---Creacion de la tabla de bienes---
if exists (select name from dbo.sysobjects where name = 'Tbl_Bienes')
drop table [Tbl_Bienes]
go
create table [Tbl_Bienes](
biene_serie int not null identity(1,1),
biene_marca varchar (30) not null,
biene_modelo varchar (30) not null,
biene_nombre varchar (30) not null,
biene_descripcion varchar (45) not null,
biene_color varchar (30) not null,
biene_departamento varchar (30) not null,
biene_codicion varchar (30) not null) on [primary] 
go

---creacion de la Primary key de la Tabla bienes
alter table [Tbl_Bienes] with nocheck add
constraint [PK_bienes] primary key (biene_serie)
go


---Procedimiento almacenado para la tabla Tbl_bienes
if exists(select name from dbo.sysobjects where name = 'Sp_Ins_bienes')
drop procedure[Sp_Ins_bienes]
go
create procedure[Sp_Ins_bienes](
--@biene_serie varchar(30),
@biene_marca varchar(30),
@biene_modelo varchar (30),
@biene_nombre varchar (30),
@biene_descripcion varchar (45),
@biene_color varchar (30),
@biene_departamento varchar (30),
@biene_codicion varchar (30))
as
insert into Tbl_Bienes( biene_marca,biene_modelo,biene_nombre,biene_descripcion,biene_color,biene_departamento,biene_codicion  )
values(@biene_marca, @biene_modelo,@biene_nombre,@biene_descripcion,@biene_color,@biene_departamento,@biene_codicion)
go
-----@biene_serie,
------biene_serie,


if exists(select name from dbo.sysobjects where name = 'Vp_Bienes')
drop view[Vp_Bienes]
go
create view[Vp_Bienes]
as
select biene_serie as Serie,
biene_marca as Marca,
biene_modelo as Modelo,
biene_nombre  as Nombre,
biene_descripcion  as Descripcion,
biene_color as Color,
biene_departamento as Departamento,
biene_codicion as Condicion
from Tbl_Bienes  
go



if exists(select name from dbo.sysobjects where name = 'Sp_Cns_Bienes')
drop procedure[Sp_Cns_Bienes]
go
create procedure[Sp_Cns_Bienes](
@biene_serie varchar(30))
as
select * from Tbl_Bienes  
where biene_serie = Rtrim(Ltrim(@biene_serie))
go



if exists(select name from dbo.sysobjects where name = 'Sp_Upd_Bien')
drop procedure[Sp_Upd_Bien]
go
create procedure[Sp_Upd_Bien](
@biene_serie varchar(30),
@biene_marca varchar(30),
@biene_modelo varchar (30),
@biene_nombre varchar (30),
@biene_descripcion varchar (45),
@biene_color varchar (30),
@biene_departamento varchar (30),
@biene_codicion varchar (30))
as
update Tbl_Bienes  set
biene_marca  = @biene_marca ,
biene_modelo  = @biene_modelo,
biene_nombre  = @biene_nombre,
biene_descripcion  = @biene_descripcion,
biene_color = @biene_color, 
biene_departamento  = @biene_departamento,
biene_codicion  = @biene_codicion

where biene_serie = @biene_serie 
go



if exists(select name from dbo.sysobjects where name = 'Sp_Del_Bienes')
drop procedure[Sp_Del_Bienes]
go
create procedure[Sp_Del_Bienes](
@biene_serie varchar(30))
as
delete from Tbl_Bienes 
where RTRIM(LTRIM(biene_serie )) = RTRIM(LTRIM(@biene_serie))
go




if exists(select name from dbo.sysobjects where name = 'Sp_Cns_bienes_X_nombre')
drop procedure [Sp_Cns_bienes_X_nombre]
go
create procedure [Sp_Cns_bienes_X_nombre](
@bien_nombre varchar(8))
as 
select biene_serie as Serie,
biene_marca as Marca,
biene_modelo as Modelo,
biene_nombre  as Nombre,
biene_descripcion  as Descripcion,
biene_color as Color,
biene_departamento as Departamento,
biene_codicion as Condicion

from Tbl_Bienes   
where biene_nombre  like '%' + @bien_nombre  + '%'
go


if exists (select name from dbo.sysobjects where name = 'Tbl_usuarios')
drop table [Tbl_usuarios]
go
create table [Tbl_usuarios](
usua_identificacion varchar (30) not null,
usua_nombre varchar (30) not null,
usua_nombreusuario varchar (30) not null,
usua_edad integer not null,
usua_sexo varchar (30) not null,
usua_telefono varchar (30) not null,
usua_email varchar (50) not null,
usua_contraseña varchar (30) not null) on [primary] 
go

---creacion de la Primary key de la Tabla bienes
alter table [Tbl_usuarios] with nocheck add
constraint [PK_usuario] primary key (usua_identificacion)
go


if exists(select name from dbo.sysobjects where name = 'Sp_Ins_usuarios')
drop procedure[Sp_Ins_usuarios]
go
create procedure[Sp_Ins_usuarios](
@usua_identificacion varchar(30),
@usua_nombre varchar (30),
@usua_nombreusuario varchar (30),
@usua_edad integer,
@usua_sexo varchar (30),
@usua_telefono varchar (30),
@usua_email varchar (50),
@usua_contraseña  varchar (30))
as
insert into Tbl_usuarios ( usua_identificacion,usua_nombre,usua_nombreusuario,usua_edad,usua_sexo,usua_telefono,usua_email,usua_contraseña  )
values(@usua_identificacion, @usua_nombre,@usua_nombreusuario,@usua_edad,@usua_sexo,@usua_telefono,@usua_email,@usua_contraseña)
go


select * from Tbl_Bienes 
select * from Vp_Bienes
SELECT @@SERVERNAME AS 'Server Name'
select * from Tbl_usuarios 