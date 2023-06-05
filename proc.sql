-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE <Procedure_Name, sysname, ProcedureName> 
	-- Add the parameters for the stored procedure here
	<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
create procedure st_updateRoles 
@rid tinyint, 
@name varchar(30)
as
update roles
set r_name = @name
where
r_id = @rid;

create procedure st_insertRole 
@name varchar(30)
as
insert into roles values (@name)

create procedure st_deleteRole @rid tinyint
as
delete from roles where r_id = @rid 

create procedure st_getRoles 
as 
select r.r_id as 'RoleID', r.r_name as 'Role' from roles r

create procedure st_insertUser 
@name varchar(40),
@username varchar(40),
@password varchar(20),
@phone varchar(15),
@address varchar(100),
@roleId tinyint
as
insert into users values (@name,@username,@password,@phone,@address,@roleId)

create procedure st_updateUser 
@name varchar(40),
@username varchar(40),
@password varchar(20),
@phone varchar(15),
@address varchar(100),
@roleId tinyint,
@userId int
as
update users
set
u_name = @name,
u_uname = @username,
u_password = @password,
u_number = @phone,
u_address = @address,
u_roleID = @roleId
where
u_id = @userId


create procedure st_getUser
as 
select
u.u_id as 'User Id',
u.u_name as 'User',
u.u_uname as 'Username',
u.u_password as 'Password',
u.u_number as 'Phone',
u.u_address as 'Address',
u.u_roleID as 'Role ID',
r.r_name as 'Role'
from users u 
inner join roles r
on r.r_id = u.u_roleID
order by u.u_name asc
Select * from  users

create procedure st_insertCustomer
@name varchar(50),
@phone varchar(15),
@address varchar(100)
as 
insert into customers values(@name,@phone,@address)

create procedure st_updatecustomers
@name varchar(50),
@phone varchar(15),
@address varchar(100),
@cID bigint
as
update customers
set
c_name = @name,
c_phone = @phone,
c_address= @address
where c_id = @cID

create procedure st_deletecustomer
@cID bigint
as
delete from customers where c_id = @cID

create procedure st_getCustomers
as 
select
c.c_id as 'ID',
c.c_name as 'Customer',
c.c_phone as 'Phone',
c.c_address as 'Address'
from customers c
order by c.c_name asc

create procedure st_insertfloor
@floor varchar(20),
@floorN tinyint
as
insert into floors values(@floor,@floorN)

create procedure st_updatefloor
@floor varchar(20),
@floorN tinyint,
@floorID tinyint
as
update floors
set f_name = @floor,
f_number = @floorN
where
f_id = @floorID

create procedure st_deletefloor
@floorID tinyint
as 
delete from floors where f_id = @floorID

create procedure st_getfloors
as
select f.f_id as 'ID', f.f_name as 'Floor', f.f_number as 'Floor Number' from floors f

create procedure st_insertTable
@tableNumber smallint,
@chair tinyint,
@floorID tinyint
as
insert into tables values (@tableNumber,@chair,@floorID)

create procedure st_updateTable
@tableNumber smallint,
@chair tinyint,
@floorID tinyint,
@tableID smallint
as
update tables
set
t_number = @tableNumber,
t_chairs = @chair,
tf_id = @floorID
where
t_id = @tableID

create procedure st_deleteTable
@tID smallint
as 
delete from tables where t_id = @tID

create procedure st_gettable
as
select
t.t_number as 'Table Number',
f.f_name as 'Floor',
f.f_id as 'Floor ID',
t.t_id as 'Table ID',
t.t_chairs as 'Chairs'
from tables t
inner join floors f
on f.f_id = t.tf_id

create procedure st_getUser4Auth
@user varchar(40),
@pass varchar(20)
as 
select
u.u_id as 'User Id',
u.u_name as 'User',
u.u_uname as 'Username',
u.u_password as 'Password',
u.u_number as 'Phone',
u.u_address as 'Address',
u.u_roleID as 'Role ID',
r.r_name as 'Role'
from users u 
inner join roles r
on r.r_id = u.u_roleID
where u.u_uname = @user and u.u_password = @pass

create procedure st_updatefoodcate 
@rid tinyint, 
@name varchar(30)
as
update foodcate
set r_name = @name
where
r_id = @rid;

create procedure st_insertfoodcate 
@name varchar(30)
as
insert into foodcate values (@name)

create procedure st_deletefoodcate @rid tinyint
as
delete from foodcate where r_id = @rid 

create procedure st_getfoodcate 
as 
select r.r_id as 'Food ID', r.r_name as 'Food Categories' from foodcate r

create procedure st_insertMenuItem
@name varchar(50),
@catID tinyint,
@price money,
@status tinyint
as
insert into foodmenu values(@name,@catID,@price,@status)

create procedure st_updateMenuItem
@name varchar(50),
@catID tinyint,
@price money,
@status tinyint,
@mid int
as
update foodmenu 
set
m_name = @name,
m_price = @price,
m_status = @status
where
m_id = @mid

create procedure st_DeleteMenuItem
@mid int
as
delete from foodmenu where m_id = @mid

create procedure st_getMenuItemWRtCategory
@cid tinyint
as
select
m.m_id as 'Menu ID',
m.m_name as 'Menu Items',
m.m_price as 'Price',
case when (m.m_status = 1) then 'Available' else 'Not Available' end as 'Status',
c.r_id as 'Cateergory ID',
c.r_name as 'Category'
from foodmenu m
inner join foodcate c
on c.r_id = m.f_id
where
c.r_id = @cid
create procedure st_getMenuItem
as
select
m.m_id as 'Menu ID',
m.m_name as 'Menu Items',
m.m_price as 'Price',
case when (m.m_status = 1) then 'Available' else 'Not Available' end as 'Status',
c.r_id as 'Cateergory ID',
c.r_name as 'Category'
from foodmenu m
inner join foodcate c
on c.r_id = m.f_id

create procedure st_getpriceWRTMenuItems
@mid int
as
Select m.m_price as 'Price' from foodmenu m where m.m_id = @mid

create procedure st_gettablesWRTFloor
@floorID tinyint
as
Select
t.t_number as 'Table Number',
t.t_id as 'Table ID'
from tables t
inner join floors f
on f.f_id = t.tf_id
where
f.f_id = @floorID

create procedure st_insertorder
@date date,
@cusID bigint,
@orderType tinyint,
@floorid tinyint,
@tableid smallint,
@t_amount money,
@a_paid money,
@a_return money,
@status tinyint
as
insert into orders values (@date,@cusID,@orderType,@floorid,@tableid,@t_amount,@a_paid,@a_return,@status)

create procedure st_updateorder
@id bigint,
@date date,
@cusID bigint,
@orderType tinyint,
@floorid tinyint,
@tableid smallint,
@t_amount money,
@a_paid money,
@a_return money,
@status tinyint
as
update orders
set
o_date = @date,
o_cusID = @cusID,
o_ordertype = @orderType,
o_floorid = @floorid,
o_tableID = @tableid,
o_totalamount = @t_amount,
o_amountPaid = @a_paid,
o_amountreturn = @a_return,
o_status = @status
where
o_id = @id

create procedure st_deleteorder
@id bigint
as
delete from orders where o_id = @id

create procedure st_insertorderDetail
@order bigint,
@p_id int
as
insert into orderDetail values(@order,@p_id)

create procedure st_updateorderDetail
@o_id bigint,
@order bigint,
@p_id int
as
update orderDetail
set 
od_orderId = @order,
od_proID = @p_id
where
od_id = @o_id

alter procedure st_getcusIDWRTPhone
@phone varchar(15)
as
select 
c.c_id as 'CustomerID',
c.c_name as 'Name',
c.c_address as 'Address'
from customers c  where  c.c_phone = @phone
create procedure st_getCategoryWRTItem
@name varchar(50)
as 
Select
c.r_id as 'Cid',
c.r_name as 'Name'
from foodmenu m
inner join foodcate c
on c.r_id = m.f_id
where
m.m_name = @name

create procedure st_getOrderID
{
select top 1 
}