CREATE DATABASE DBCoursesApp
go
use DBCoursesApp
go

CREATE TABLE Student(
	Id int identity,
	Name varchar(100)
)
go
CREATE TABLE Course (
	Id int identity,
	Name varchar(100)
)
go

insert into Student(Name) values('Mijael')
insert into Student(Name) values('Pedro')
insert into Student(Name) values('Brayan')

insert into Course(Name) values('Math')
insert into Course(Name) values('Aricmetic')
insert into Course(Name) values('History')

select * from Student
select * from Course