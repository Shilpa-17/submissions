create database codetestsql

--creating table 1
create table books(
id int primary key,
title varchar(30),
author varchar(20),
isbn  bigint unique ,
published_date datetime)

insert into books values(1,'My First SQL book','Marry Parker',981483029127,'2012-02-22 12:08:17'),
(2,'My Second SQL book','john Mayer',857300923713,'1972-07-03 09:22:45'),
(3,'My third Sql book','cary flint',523120967812,'2015-10-18 14:05:44')

select * from  books
  select * from books  where author like'%er'

  --creating table2
  create table reviews(
  id int,
  book_id int,
  reviewer_name varchar(30),
  content varchar(30),
  rating int,
  published_date datetime)

  insert into reviews values(1,1,'john smith','my first review',4,'2017-12-10 05:50:10'),
  (2,2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
  ( 3,3, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10')

  

  select * from reviews
 select Title,Author from Books 
select Reviewer_name from Reviews

 select Reviewer_name from Reviews
group by Reviewer_name
having count(Book_id)>1
 --table3
 create table Customer
(Cust_ID int,
Customer_Name varchar(15),
Age int,
Address varchar(20),
Salary float) 

insert into Customer values
(1, 'Ramesh',32,'Ahemedabad',2000.00),
(2,'Khilan', 25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',4500.00),
(7,'Muffy',24,'Indore',10000.00)

select * from Customer
select reviewer_name from reviews
group by  reviewer_name
having count(distinct book_id) > 1

--table4
create table Orders
(OID int,
Order_Date DateTime,
Customer_ID int,
Amount int) 

insert into Orders values
(102,'2009-10-08 00:00:00',3,3000),
(101, '2009-10-08 00:00:00',3,1500),
(100,'2009-11-20 00:00:00',2,1560),
(103,'2008-05-20 00:00:00',4,2060) 

select * from Orders
select customer_name from  Customer where Address like '%o%';
  select order_date ,count(customer_id) as total_customers from orders
  group by Order_Date having count (customer_id)>1;



--table5

create table Employee
(Empid int,
Emp_Name varchar(15),
Age int,
Address varchar(15),
Salary float) 

insert into Employee values

(1, 'Ramesh',32,'Ahemedabad',2000.00),
(2,'Khilan', 25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',null),
(7,'Muffy',24,'Indore',null)

select* from employee
  select lower (emp_name) as lowercase from employee where salary is null;

  --last query
  select gender ,count (*) as totalcount from studentdetails 
  group by gender;
 
 