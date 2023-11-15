create database assignments

use assignments;


--creating client table
create table Clients(
Client_ID  int primary key,
Cname varchar(40) not null,
Address varchar(30),
Email varchar(30) unique,
Phone bigint,
Business varchar(20) not null
)
insert into Clients values(1001,'acme utilities','nodia','contact@acmeutil.com',9567880032,'manufacturing'),
(1002,'trackon consultants','mumbai','consult@trackon.com',8734210091,'consultant'),
(1003,'MoneySaver Distributors ','Kolkata',' save@moneysaver.com ',7799886655 ,'Reseller '),
(1004 ,'Lawful Corp ','Chennai ','justice@lawful.com ',9210342219 ,'Professional ')

select* from Clients

--creating table employee

create table Employees(
empno int primary key,
ename varchar(20) not null,
job varchar(15),
salary bigint  check (salary>0),
Deptno int foreign key references Departments(Deptno) )

insert into Employees values(
7001,'Sandeep','Analyst',25000,10),
(7002,'Rajesh','Designer',30000,10),
(7003,'Madhav','Developer',40000,20),
(7004,'Manoj','Developer',40000,20),
(7005,'Abhay','Designer',35000,10),
(7006,'Uma','Tester',30000,30),
(7007,'Gita','Tech. Writer',30000,40),
(7008,'Priya','Tester',35000,30),
(7009,'Nutan','Developer',45000,20),
(7010,'Smita','Analyst',20000,10),
(7011,'Anand','Project Mgr',65000,10)

select* from Employees

--salary check constraint
alter table Employees
add constraint Salcheck check(Salary>0)


--foreign key 
alter table Employees
Deptno int foreign key references Departments(Deptno)


--crating table departments
create table departments(
deptno int primary key,
dname varchar(15),
loc varchar(20))

insert into Departments values(10,'Design','Pune'),
(20,'Development','Pune'),
(30,'Testing','Mumbai'),
(40,'Document','Mumbai')

select * from departments



--creating table projects
create table Project(Project_ID int primary key,
Descr varchar(30) not null,
Start_Date date,
Planned_End_Date date,
Actual_End_Date date ,
Budget int check(Budget>0),
Client_ID int REFERENCES Clients(Client_ID))


insert into Project values(401,'Inventory','01-Apr-11','01-Oct-11','31-Oct-11',150000,1001)


insert into Project(Project_ID,Descr,Start_Date,Planned_End_Date,Budget,Client_ID) values
       (402,'Accounting','01-Aug-11','01-Jan-12',500000,1002),
	   (403,'Payroll','01-Oct-11','31-Dec-11',75000,1003),
	   (404,'Contact Mgmt','01-Nov-11','31-Dec-11',50000,1004)

select* from project




---creating tbale empprojecttasks

create table empProjectTasks(
    Project_ID int,
    Empno int,
    Start_Date date,
    End_Date date,
    Task varchar(15)not null,
    Status varchar(15),
	primary key(Project_ID,Empno),
    foreign key (Project_ID) references Project(Project_ID),
    foreign key(Empno) references Employees(Empno)
	)

 

insert into EmpProjectTasks values(401,7001,'01-Apr-11','20-Apr-11','System Analysis','Completed'),
								  (401,7002,'21-Apr-11','30-May-11','System Design','Completed'),
								  (401,7003,'01-Jun-11','15-Jul-11','Coding','Completed'),
								  (401,7004,'18-Jul-11','01-Sep-11','Coding','Completed'),
								  (401,7006,'03-Sep-11','15-Sep-11','Testing','Completed'),
								  (401,7009,'18-Sep-11','05-Oct-11','Code Change','Completed'),
								  (401,7008,'06-Oct-11','16-Oct-11','Testing','Completed'),
								  (401,7007,'06-Oct-11','22-Oct-11','Documentation','Completed'),
								  (401,7011,'22-Oct-11','31-Oct-11','Sign off','Completed'),
								  (402,7010,'01-Aug-11','20-Aug-11','System Analysis','Completed'),
								  (402,7002,'22-Aug-11','30-Sep-11','System Design','Completed')

 

insert into empProjectTasks(Project_ID,Empno,Start_Date,Task,Status) values(402,7004,'01-Oct-11','Coding','In Progress')

 

select * from EmpProjectTasks

 

 

 











