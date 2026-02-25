create table Course(
	cid char(5) constraint pk_crid primary key,
	cname varchar(100) not null,
	cduration varchar(100) not null,
	cfee int not null
)
create table Student(
	sid char(5) constraint pk_sid primary key,
	sname varchar(100) not null,
	sgender char(10) constraint ck_sGender Check(sgender in ('Male', 'Female', 'Other')),
	sdate date,
	cid char(5) constraint fk_cid foreign key references Course(cid)
)

select * from Student
select * from Course

select sid, sname, sgender, sdate, c.cid, cname, cduration, cfee from Student inner join Course c on Student.cid = c.cid

go;

use ADOdb

go
create procedure prcGetAllDetails
as 
begin
	select sid, sname, sgender, sdate, c.cid, cname, cduration, cfee from Student inner join Course c on Student.cid = c.cid
end

exec prcGetAllDetails


go

create procedure prcGetDetailsWithId @StuId char(5)
as 
begin
	select sid, sname, sgender, sdate, c.cid, cname, cduration, cfee 
	from Student s
	inner join Course c on s.cid = c.cid
	where s.sid = @StuId
end

exec prcGetDetailsWithId '1'
