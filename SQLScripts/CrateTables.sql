use [DataBaseName]

create table Categories (
  id		int NOT NULL Primary key identity,
  parent	int NOT NULL,
  "name"		CHAR(25) NULL
)


create table Products(
  id				uniqueidentifier	not null primary key default newsequentialid() ,
  category_id		int					not null references Categories(id), 
  name				varchar(50)			not null,
  description_short varchar(255)
  )


create table Prices(
  product_id	uniqueidentifier	not null	references Products(id),
  price			dec					not null	default(0.0),
  date_start	DateTime			not null	default GETDATE(),
  )



create table Clients(
  id			uniqueidentifier	not null	primary key default newsequentialid() ,
  first_name	varchar(50)			not null,
  second_name	varchar(50)			not null,
  email			varchar(255)
  )

create table orders(
  id			uniqueidentifier	not null	primary key default newsequentialid() ,
  client_id		uniqueidentifier	not null	references Clients(id),
  totalamount	decimal				not null,
  orderdate		DateTime			not null	default GETDATE(),
  )


create table order_products(
 order_id	uniqueidentifier		not null	references Orders(id),
 product_id	uniqueidentifier		not null	references Products(id),
 amount		int
 )