use assignment2

--1. Retrieve a list of MANAGERS.

select ename as "Manager Name" from emp e
where empno in(select mgr_id from emp where mgr_id is not null);--jones blake clark scott king ford

--2.Find out the names and salaries of all employees earning more than 1000 per month
select ename,salary from emp where salary>1000;-- gives everyone except james

--3. Display the names and salaries of all employees except JAMES. 
select ename,salary from emp where ename<>'james'--gives everyone except james as his salary is 950

--4. Find out the details of employees whose names begin with ‘S’. 
select ename from emp where ename like's%'-- smith,scott

--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
select ename from emp where  ename like'%a%'--allen,ward,martin,blake,clark,adams,james

--6. Find out the names of all employees that have ‘L’ as their third character in  their name. 
select ename from emp where  ename like'__l%'--allen,miller

--7. Compute daily salary of JONES. 
select ename, salary / 30 as daily_salary from emp where ename='jones'-- assumig no of working days to be 30 (109 per day)

--8. Calculate the total monthly salary of all employees. 
select sum(salary) as total_monthly_salary from emp --30112

--9. Print the average annual salary . 
select avg(salary*12) as average_anual_salary from emp--25810

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select ename, job, salary, deptno from emp 
where deptno = 30 AND job <> 'salesman'--( blake , manager,2850,30)(james,clerk,950,30)

--11. List unique departments of the EMP table.
select Job from EMP group by Job --analyst,clerk,manager,president,salesman

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename as Employee, salary as "Monthly Salary" from emp
where (deptno = 10 OR deptno= 30) AND salary > 1500--(allen 1600,blake 2850,clark 2450,king 5000)

--13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000.
select ename, job, salary FROM emp
where (job = 'MANAGER' or job = 'ANALYST') and salary not in (1000, 3000, 5000);--(jones manager 3272,blake manager 2850,clark manager 2450,scott analyst 3300,ford analyst 3300)

--14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
select ename, salary, comm from emp
where comm > (salary * 1.10)--martin(sal 1250)(comm 1400)

--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select ename from emp where(ename like '%l%l' and deptno=30) or mgr_id=7782--miller

--16. Display the names of employees with experience of over 30 years and under 40 yrs. Count the total number of employees.
select Ename from emp
where datediff(year, Hiredate, Getdate()) between 30 and 39 --scott,adams
--to count
select count (*) as total_count from emp where datediff(year, Hiredate, Getdate()) between 30 and 39--2

--17. Retrieve the names of departments in ascending order and their employees in descending order. 
select d.dname as "Department Name", e.ename as "Employee Name" from DEPT d
left join EMP e on d.depno = e.deptno
order by "Department Name" asc, "Employee Name" desc --accounting miller,accounting  king,accounting clark, operations null.........


--18. Find out experience of MILLER
select datediff(year,hiredate,getdate()) as experience from emp 
where ename='miller'--41