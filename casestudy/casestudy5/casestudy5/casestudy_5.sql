create database casestudy5
use casestudy5
 
 
-- Create a table to store student information with a composite key


create table Student (

    StudentID int,

    Name varchar(25),
	DOB date,
	constraint UQ_Student unique (StudentID, Name)
	);
	drop table student
	insert into student (StudentID, Name, DOB) values(4, 'Sana','2000- 7-20'),
          (5, 'Nikki', '2001-3- 20'),
          (6, 'Joshua', '2000-8- 17'),
           (7, 'Dino', '2001-7-21'),
            (8, 'Jin', '2004-9- 20'),
        (9, 'Anusha','2009-7-23');

-- Create a table to store course information with a composite key

create table Course (

    CourseID int,

    CourseName varchar(25),

    constraint UQ_Course unique (CourseID, CourseName)

);
insert into course values(101,'java'),
(102,'python'),
(103,'C'),
(104,'c#'),
(105,'SQL'),
(106,'HTML+CSS');

-- Create a table to store student registration information with a composite key

create table Register (

    StudentID int,

    CourseID int,

    RegistrationDate date,

    constraint CK_Register unique (StudentID, CourseID)

)
select * from Course

select * from student

select * from register

