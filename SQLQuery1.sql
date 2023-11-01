create table Student
(
	Id int identity(1,1) primary key,
	Name nvarchar(255),
	Gender int,
	Year int,
	DpId int,
	constraint FK_Student_Department foreign key(DpId) references Department(DepartmentId)
);
ALTER TABLE Student
ADD CONSTRAINT CK_Gender
CHECK (Gender IN (0, 1));

ALTER TABLE Student
add constraint CK_Year
Check(Year > 0);