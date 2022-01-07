create database quiz
create table questions
(
id int identity(1,1) primary key,
qset varchar(250) not null,
qNo varchar(250) not null,
question varchar(350) not null,
optionA varchar(250) not null,
optionB varchar(250) not null,
optionC varchar(250) not null,
optionD varchar(250) not null,
ans varchar(250) not null
)
qset,qNo,question,optionA,optionB,optionC,optionD,ans
select * from questions
select distinct qset from questions;
select max(qset) from questions
select max(qNo) from questions where qset = '1'
