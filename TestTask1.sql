USE [TestTask]

--Создание таблиц
CREATE TABLE [Product](
	[idProduct] [int] NOT NULL,
	[NameProduct] [nvarchar](100) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED (idProduct)
); 
CREATE TABLE [Category](
	[idCategory] [int] NOT NULL,
	[NameCategory] [nvarchar](100) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED (idCategory)
); 
CREATE TABLE [ProductCategory](
    idProduct int NOT NULL,
	idCategory int NOT NULL,
    CONSTRAINT FK_product_product FOREIGN KEY (idProduct) REFERENCES Product(idProduct),
	CONSTRAINT FK_catrgory_catrgory FOREIGN KEY (idCategory) REFERENCES Category(idCategory)
);
--Добавление данных
INSERT INTO Category(idCategory, NameCategory) values (1,'Продукты'),
													  (2,'Техника'),
													  (3,'Планеты'),
													  (4,'Одежда');

INSERT INTO Product(idProduct, NameProduct) values (1,'Огурцы'),
												   (2,'Венера'),
												   (3,'Куртка'),
												   (4,'Трактор'),
												   (5,'Помидоры'),
												   (6,'Автомобиль'),
												   (7,'Брюки'),
												   (8,'Юпитер'),
												   (9,'Экзоскелет'),
												   (10,'Брекеты');

INSERT INTO ProductCategory(idProduct, idCategory) values (1,1),
														  (2,3),
														  (3,4),
														  (4,2),
														  (5,1),
														  (6,2),
														  (7,4),
														  (8,3),
														  (9,2),
														  (9,4);

--Запрос на вывод названия продукта и названия категории через '-'														  
SELECT (p.NameProduct + ' - ' + c.NameCategory) AS PCName 
FROM Product p
LEFT JOIN ProductCategory pc ON p.idProduct = pc.idProduct
LEFT JOIN Category c ON pc.idCategory = c.idCategory