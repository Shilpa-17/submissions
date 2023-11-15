use assignments
select * from Employees
create table tblAudit
( details nvarchar(max))
create or alter trigger trgAuditInsert
on employees
for insert
as
begin
declare @id int
select @id=empno from inserted

--insert the newly added employee into audit table

insert into tblaudit values('New Employee with Empno :' + cast(@id as varchar(5))+

'is added at :' +cast(getdate() as varchar(20)))
end
insert into Employees values(7012,'shilpa','HR',65500,30)
select * from tblaudit

--delete

create or alter trigger trgAuditDelete
on employees
for delete
as
begin
select * from Employees
select * from deleted
end
delete from Employees where empno in(7012)

--using assignment2
use assignment2