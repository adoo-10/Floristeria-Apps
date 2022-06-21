Create Database FloristeriaParcial

use FloristeriaParcial

Create table Flores(
idFlor int identity(1,1) primary key,
nombreFlor varchar(45) not null,
cantidad int not null,
precio decimal (5, 2) not null,
estado int not null,
);

insert into Flores values ('Girasol', 1, 0.90, 1);

select * from Flores;