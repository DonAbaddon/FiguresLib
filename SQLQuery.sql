SELECT product.name as 'Product', category.name as 'Category' 
  FROM product 
  LEFT JOIN product_category ON product.id = product_category.id_product 
  LEFT JOIN category ON category.id = product_category.id_category;
