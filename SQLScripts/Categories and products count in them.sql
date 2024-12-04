use [DataBaseName]

select 
  Categories.id,
  Categories."name",
  count(Products.id) as "products count"
  from Categories
    left join Products on Products.category_id = Categories.id
	group by Categories.id, Categories.name
	having count(Products.id) > 0