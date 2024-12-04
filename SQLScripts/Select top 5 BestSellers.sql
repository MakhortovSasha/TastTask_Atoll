 use [DataBaseName]
 
 select top 5
   Products."name" as product,
   sum(Order_products.amount) as "ordered amount"  
 from Products
   right join Order_products on Products.id = Order_products.product_id
 group by products.id, products."name"
 order by "ordered amount" desc