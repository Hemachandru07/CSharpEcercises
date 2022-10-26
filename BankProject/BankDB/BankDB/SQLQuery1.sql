create table sbaccount
(
AccountNumber int primary key,
CustomerName varchar(20),
CustomerAddress varchar(30),
CurrentBalance double precision
)

select *from sbaccount

alter table sbaccount
add constraint df_CurrentBalance default 0 for CurrentBalance 

insert into sbaccount values(1234,'chandru', 'chennai',default)
delete from sbaccount where AccountNumber = 1234
