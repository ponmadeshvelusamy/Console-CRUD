Create table SchoolDetails(
SchoolName nvarchar(100) not null,
SchoolID bigint Identity(100,5),
ContactNo bigint not null,
Email nvarchar(100) not null,
Address nvarchar(100) not null,
Pincode bigint not null,
)
insert into SchoolDetails(SchoolName,ContactNo,Email,Address,Pincode)
values('sankar ponnar high secondary school',9087654321,'SankarPonnarSchool@gmail.com','2/200,East Street palani,palani(T.K),Dindugul(D.T)',624601)

select SchoolID,SchoolName,ContactNo,Email,Address,Pincode from SchoolDetails


create procedure SchoolDetailsignup
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

exec SchoolDetailsignup 'sankarhighsecondaryschool',9080706050,'sankarponnarschool@gmail.com','2/23,sankarponnarschool,palani,dindugul',624601

select *from [SchoolDetails]

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
exec serachDetails 110

create or alter procedure DeleteDetails
(@SchoolID bigint
)
as
begin
delete from SchoolDetails
where SchoolID=@SchoolID
end

exec DeleteDetails 110

select *from SchoolDetails