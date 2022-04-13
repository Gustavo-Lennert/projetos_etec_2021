create database Loja;
use Loja;

create table cliente(
	codigo int primary key auto_increment not null,
    nome varchar(10) not null,
    sobrenome varchar (20),
    idade int,
    data date not null,
    cpf int not null,
    sexo varchar(10) not null
);
alter table cliente add salario decimal (7,2);
alter table cliente change data dtnascto date;

insert into cliente (nome, sobrenome, dtnascto, idade, cpf, sexo, salario)
values ('Leo', 'Pires', '1980-10-10', 34, 123456789, 'M',540.00), ('Leoncio', 'Silva', '1982-01-05', 32, 987654321, 'M', 1500.00), 
('Leandro', 'Souza', '1960-12-30', 54, 654987321, 'M', 2000.00), ('Ana', 'Felix', '1962-11-25', 52, 321456789, 'F', 2300.00); 

select codigo, nome, idade from cliente;
select salario, idade from cliente where nome = "Leo";
alter table cliente drop idade;
alter table cliente modify cpf varchar(11);

select * from cliente where salario > 1000 order by salario desc;
alter table cliente add bairro char(20) not null;

desc cliente;
insert into cliente values (null, 'Paula', 'Castro', '1963-11-30', '221456789', 'F', 680.00, 'Ingá');

select * from cliente;
desc cliente;
alter table cliente modify sexo char(1);

update cliente set bairro = "Centro" where codigo = 1
update cliente set bairro = "Centro" where codigo = 2;
update cliente set bairro = "Icaraí" where codigo = 3;
update cliente set bairro = "Jurandir" where codigo = 4;

select distinct bairro from cliente;
select nome, sobrenome, cpf from cliente where nome like 'Leo%';
select * from cliente where salario between 1000 and 2000; 
select max(salario) from cliente;
select min(salario) from cliente;
select * from cliente where nome like 'Le%';
