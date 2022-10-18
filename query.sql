CREATE TABLE product(
 product_id SERIAL PRIMARY KEY,
 name VARCHAR(30)
);

INSERT INTO product(name)
VALUES ('Strawberry'),
('Watermelon'),
('Apple pie');

CREATE TABLE category(
 category_id SERIAL PRIMARY KEY,
 name VARCHAR(30)
);

INSERT INTO category(name)
VALUES ('Berries'),
('Fruits'),
('Dairy');

CREATE TABLE product_category(
    product_id INT REFERENCES product(product_id),
    category_id INT REFERENCES category(category_id),
    PRIMARY KEY (product_id, category_id)
);

INSERT INTO product_category(product_id, category_id)
VALUES (1, 1),
(2, 1),
(2, 2);


SELECT p.name AS "Имя продукта", c.name AS "Имя категории"
FROM product p
LEFT JOIN product_category pc
    ON p.product_id = pc.product_id
LEFT JOIN category c
    ON pc.category_id = c.category_id










