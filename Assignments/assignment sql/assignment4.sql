create database assignment4
use assignment2

create function dbo.CalculateFactorial(@n int)
returns int
as
begin
    declare @result int = 1;
    declare @i int = 1;
    while @i <= @n
    begin
        set @result = @result * @i;
        set @i = @i + 1;
    end
    return @result
	end
create procedure dbo.GenerateMultiplicationTable
    @maxNumber int
as
begin
    declare @i int = 1;
    while @i <= @maxNumber
    begin
        declare @j int = 1;
        while @j <= 10
        begin
            print @i * @j;
            set @j = @j + 1;
        end
        print '------------------------';
        set @i = @i + 1;
    end
end

create table Holidays(
 holiday_date date,
 holiday_name varchar(30) ) 

insert into Holidays (holiday_date, holiday_name) values
 ('2023-01-26', 'Republic Day'),
 ('2023-08-15', 'Independence Day'),
 ('2023-10-02', 'Gandhi Jayanthi'),
 ('2023-12-25', 'Christmas')

 create trigger trr on EMP
after insert, update, delete as
begin
declare @holidayname varchar(20);
select @holidayname = holiday_name from Holidays
where holiday_date = convert(date, getdate());
if @holidayname is not null
begin
declare @errormessage varchar(50);
set @errormessage = 'Due To ' + @holidayname + ' You Cannot Manipulate Data';
throw 51000, @errormessage, 1;
end
end 

select * from Holidays;

insert into Holidays values ('2023-11-13', 'Diwali');
update EMP set salary = 9999 where empno = 7900;


 
