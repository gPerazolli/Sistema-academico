create database db_sys_academico

use db_sys_academico;

CREATE TABLE tbl_periodos(
per_id INT NOT NULL PRIMARY KEY,
per_nome VARCHAR(50) NOT NULL,
per_sigla VARCHAR(5) NOT NULL,
);

CREATE TABLE tbl_cursos(
cur_id INT NOT NULL PRIMARY KEY,
cur_nome VARCHAR(50) NOT NULL,
cur_sigla VARCHAR(25) NOT NULL,
cur_observacoes VARCHAR(500),
FOREIGN KEY(cur_id) REFERENCES tbl_periodos(per_id),
);

CREATE TABLE tbl_disciplinas(
dis_id INT NOT NULL PRIMARY KEY,
dis_nome VARCHAR(50) NOT NULL,
dis_sigla VARCHAR(25) NOT NULL,
dis_observacoes VARCHAR(500),
);

CREATE TABLE disciplinas_cursos(
dis_id INT NOT NULL,
cur_id INT NOT NULL,
FOREIGN KEY(cur_id) REFERENCES tbl_cursos(cur_id),
FOREIGN KEY(dis_id) REFERENCES tbl_disciplinas(dis_id),
);

CREATE TABLE tbl_login(
nome_usu VARCHAR(50),
login_usu VARCHAR(50),
senha_usu VARCHAR(50)
);

insert into tbl_login (nome_usu, login_usu, senha_usu) values ('Administrador', 'Admin', 'admin');


insert into tbl_cursos (cur_id, cur_nome, cur_sigla, cur_observacoes) 
values(01, 'Engenharia Mecanica', 'EM', '');
insert into tbl_cursos (cur_id, cur_nome, cur_sigla, cur_observacoes) 
values(02, 'Engenharia Civil', 'EC', '');
insert into tbl_cursos (cur_id, cur_nome, cur_sigla, cur_observacoes) 
values(03, 'Engenharia Eletrica', 'EE', '');
insert into tbl_cursos (cur_id, cur_nome, cur_sigla, cur_observacoes) 
values(04, 'Enfermagem', 'ENF', '');
insert into tbl_cursos (cur_id, cur_nome, cur_sigla, cur_observacoes) 
values(05, 'Educação Fisica', 'EF', '');

insert into tbl_periodos (per_id, per_nome, per_sigla)
values (01, '1 Periodo', 'P1');
insert into tbl_periodos (per_id, per_nome, per_sigla)
values (02, '2 Periodo', 'P2');
insert into tbl_periodos (per_id, per_nome, per_sigla)
values (10, 'hghg', 'hgh');
insert into tbl_periodos (per_id, per_nome, per_sigla)
values (08, 'hhgj', 'tt');
insert into tbl_periodos (per_id, per_nome, per_sigla)
values (09, 'hjh', 'hh');

insert into tbl_disciplinas (dis_id, dis_nome, dis_sigla, dis_observacoes)
values (01, 'Matematica I', 'MI', '');
insert into tbl_disciplinas (dis_id, dis_nome, dis_sigla, dis_observacoes)
values (02, 'Matematica II', 'MII', '');
insert into tbl_disciplinas (dis_id, dis_nome, dis_sigla, dis_observacoes)
values (03, 'Fisica I', 'FI', '');
insert into tbl_disciplinas (dis_id, dis_nome, dis_sigla, dis_observacoes)
values (04, 'Fisica II', 'FII', '');
insert into tbl_disciplinas (dis_id, dis_nome, dis_sigla, dis_observacoes)
values (0, 'Topografia', 'TP', 'MErda');

insert into disciplinas_cursos (dis_id, cur_id)
values (01,01);
insert into disciplinas_cursos (dis_id, cur_id)
values (02,02);
insert into disciplinas_cursos (dis_id, cur_id)
values (03,03);
insert into disciplinas_cursos (dis_id, cur_id)
values (04,04);
insert into disciplinas_cursos (dis_id, cur_id)
values (05,05);


select * from tbl_cursos order by cur_nome asc;

select *from tbl_login;

select * from tbl_periodos;
select * from tbl_disciplinas;
select * from disciplinas_cursos;

alter table tbl_login alter column login_usu varchar(50) not null;
select count(cur_sigla) num from tbl_cursos
alter table tbl_login add primary key(login_usu);
