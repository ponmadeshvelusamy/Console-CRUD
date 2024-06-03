Create table SchoolDetails(
SchoolName nvarchar(100) not null,
SchoolID bigint Identity(100,5),
ContactNo bigint not null,
Email nvarchar(100) not null,
Address nvarchar(100) not null,
Pincode bigint not null,
)


create procedure Schoolin
(@SchoolName nvarchar(100),
@ContactNo bigint ,
@Email nvarchar(100),
@Address nvarchar(100),
@Pincode bigint  
)
as
begin
insert into [dbo].[SchoolDetails]([SchoolName],[ContactNo],[Email],[Address],[Pincode])

values
(
@SchoolName,
@ContactNo,
@Email,
@Address,
@Pincode
)
end


create or alter procedure EditorUpdate
(
@SchoolID bigint,
@ContactNO bigint,
@Email nvarchar(100)

)
as
begin
update SchoolDetails
set ContactNo=@ContactNo,Email=@Email
where
SchoolID=@SchoolID
end

exec EditorUpdate 100,9790263388,'SankarPonnarSchool@gmail.com'

Create or alter procedure serachDetails
(@SchoolID bigint 
)
as
begin
select  * from SchoolDetails
where SchoolID=@SchoolID
end 





create or alter procedure DeleteDetails
(@SchoolID bigint
)
as
begin
delete from SchoolDetails
where SchoolID=@SchoolID
end

exec DeleteDetails 110