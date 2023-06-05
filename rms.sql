create database rms	
use rms
create table roles
(
r_id tinyint not null identity primary key,
r_name varchar(30) not null
)

create table users
(
u_id int not null primary key identity,
u_name varchar(30) not null,
u_uname varchar(30) not null unique,
u_password varchar(30) not null,
u_number varchar(15) not null,
u_address varchar(100) not null,
u_roleID tinyint not null foreign key references roles(r_id) on delete no action on update no action
)


create table customers
(
c_id bigint not null identity primary key,
c_name varchar(50) not null,
c_phone varchar(15) unique not null,
c_address varchar(100) not null
)

create table floors
(
f_id tinyint not null identity primary key,
f_name varchar(20) not null,
f_number tinyint not null 
)
create table tables
(
t_id smallint not null identity primary key,
t_number smallint not null unique,
t_chairs tinyint not null,
tf_id tinyint not null foreign key references floors(f_id) on delete no action on update no action
)
create table foodcate
(
r_id tinyint not null identity primary key,
r_name varchar(30) not null
)
create table foodmenu
(
m_id int not null identity primary key,
m_name varchar(50) not null,
f_id tinyint not null foreign key references foodcate(r_id) on delete cascade on update cascade,
m_price money,
m_status tinyint 
)
create table orders
(
o_id bigint not null identity primary key,
o_date date not null,
o_cusID bigint not null foreign key references customers(c_id) on delete no action on update no action,
o_ordertype tinyint not null,
o_floorid tinyint foreign key references floors(f_id) on delete no action on update no action,
o_tableID smallint foreign key references tables(t_id) on delete no action on update no action,
)
alter table orders add o_totalamount money not null
alter table orders add o_amountPaid money
alter table orders add o_amountreturn money 
create table orderDetail
(
od_id bigint not null identity primary key,
od_orderId bigint not null foreign key references orders(o_id) on delete no action on update no action,
od_proID int not null foreign key references foodmenu(m_id) on delete no action on update no action,
)

alter table foodmenu add m_image image not null
alter table orders add o_status tinyint not null --0 pending 1 finished 2 Cancelled