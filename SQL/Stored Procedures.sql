CREATE DATABASE DBCoursesApp
go

CREATE PROCEDURE sp_Student_List
as
begin
	select s.Id,s.Name, count(sc.Course_Id) as "CourseCount" from Student s inner join Student_Course sc on s.Id = sc.Student_Id
	group by s.Id,s.Name
end
go

CREATE PROCEDURE sp_Course_List
as
begin
	select Id,Name from Course
end
go

CREATE PROCEDURE sp_Course_Save
@Id int,
@Name varchar(100)
as
begin
	if exists (select Id from Course where Id = @Id)
		update Course
		set Name = @Name
		where Id = @Id
	else
		insert into Course(Name)
		values(@Name)
end
go

CREATE PROCEDURE sp_Student_AddCourse
@Student_Id int,
@Course_Id int
as
begin
	if not exists(select Course_Id from Student_Course where Student_Id = @Student_Id and Course_Id = @Course_Id)
	insert into Student_Course(Student_Id, Course_Id)
	values (@Student_Id, @Course_Id)
end
go

CREATE PROCEDURE sp_Student_DeleteCourse
@Student_Id int,
@Course_Id int
as
begin
	if exists(select Course_Id from Student_Course where Student_Id = @Student_Id and Course_Id = @Course_Id)
	delete Student_Course
	where Student_Id = @Student_Id and Course_Id = @Course_Id
end
go

CREATE PROCEDURE sp_Student_ListCourse
@Student_Id int
as
begin
	Select c.Id, c.Name from Student_Course sc inner join Course c on sc.Course_Id = c.Id where Student_Id = @Student_Id
end
go
