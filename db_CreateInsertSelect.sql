CREATE TABLE [dbo].[ProductsAndCategories](
	[id_Product] [bigint] NOT NULL,
	[Product] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProductsAndCategories] PRIMARY KEY CLUSTERED 
(
	[id_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT ProductsAndCategories VALUES (1,'Mouse', 'Toy')
INSERT ProductsAndCategories VALUES (2,'Elephant', 'Toy')
INSERT ProductsAndCategories VALUES (3,'Mouse', 'Animal')
INSERT ProductsAndCategories VALUES (4,'Elephant', 'Car')
INSERT ProductsAndCategories VALUES (5,'Earphone', '')
INSERT ProductsAndCategories VALUES (6,'1984', 'Book')
INSERT ProductsAndCategories VALUES (7,'Pen', '')
INSERT ProductsAndCategories VALUES (8,'Guitar', 'Musical Instrument')
GO

Select Product, Category from ProductsAndCategories
group by Product, Category


