create database xd;
use xd;

create table lmao(
id int primary key identity(1,1),
jmeno varchar(20) not null,
prijmeni varchar(20) not null
);

insert into lmao(jmeno,prijmeni) values('Bruz','Muz');