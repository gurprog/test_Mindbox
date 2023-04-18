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
INSERT ProductsAndCategories VALUES (3,'Earphone', '')
INSERT ProductsAndCategories VALUES (4,'1984', 'Book')
INSERT ProductsAndCategories VALUES (5,'Pen', '')
INSERT ProductsAndCategories VALUES (6,'Guitar', 'Musical Instrument')
GO

Select Product, Category from ProductsAndCategories
group by Product, Category


