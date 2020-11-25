--select * from Answers
--select * from Questions
--select * from TestGroups 
--select * from Tests
--select * from UserAnswers
--select * from UserGroups
--select * from Users
--select * from Groups
--select * from Results


--insert into Users(FirstName,LastName,Login,Password,IsAdmin) values
--('Ghost','Hunter','admin','11111',1),
--('John','White','white','22222',0),
--('Jack','Black','black','33333',0),
--('Steve','McRed','mcred','44444',0),
--('Devid','Green','green','55555',0),
--('Michael','Gray','gray','66666',0)

--insert into Groups(NameGroup) values
--('s32-rp1'),
--('s33-rp2'),
--('s34-rp3'),
--('s35-rp4')

--insert into UserGroups(User_Id,Group_Id) values
--(2,1),
--(3,1),
--(4,1),
--(5,2),
--(6,3)

--select id from Questions
--where Test_Id is NULL

--Видалення питань і відповідей
--create or alter proc sp_Clear
--as
--delete from Answers
--where Question_Id in(select Id from Questions where Test_Id is NULL)
--delete from Questions
--where Id in(select id from Questions
--where Test_Id is NULL)

select id from Questions
where Test_Id=6

select * from Answers
where Question_Id in (select id from Questions
where Test_Id=6
)

select * from UserAnswers

--insert into UserAnswers(Date,Answer_Id,User_Id) values
--(GETDATE(),77,2),
--(GETDATE(),80,2),
--(GETDATE(),84,2),
--(GETDATE(),87,2),
--(GETDATE(),89,2)


select * from Answers
where Question_Id in(select Id from Questions where Test_Id=6)
and Id in (select Answer_Id from UserAnswers where User_Id=2)

select * from Questions where Test_Id=6

select * from 
(UserAnswers left join Answers 
on UserAnswers.Answer_Id=Answers.Id) left join Questions
on Answers.Question_Id=Questions.Id



--exec sp_Clear

--create or alter procedure proc1
--as 
--select * from Sage


