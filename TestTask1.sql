USE [TestTask]

--�������� ������
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
--���������� ������
INSERT INTO Category(idCategory, NameCategory) values (1,'��������'),
													  (2,'�������'),
													  (3,'�������'),
													  (4,'������');

INSERT INTO Product(idProduct, NameProduct) values (1,'������'),
												   (2,'������'),
												   (3,'������'),
												   (4,'�������'),
												   (5,'��������'),
												   (6,'����������'),
												   (7,'�����'),
												   (8,'������'),
												   (9,'����������'),
												   (10,'�������');

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

--������ �� ����� �������� �������� � �������� ��������� ����� '-'														  
SELECT (p.NameProduct + ' - ' + c.NameCategory) AS PCName 
FROM Product p
LEFT JOIN ProductCategory pc ON p.idProduct = pc.idProduct
LEFT JOIN Category c ON pc.idCategory = c.idCategory