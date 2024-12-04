use [DataBaseName]

select
   Clients.*,
   sum(orders.totalamount) as spent_total
 from Clients
   right join Orders on Clients.id = Orders.client_id
 group by Clients.id, first_name, second_name, email
   having sum(orders.totalamount) > 1000
