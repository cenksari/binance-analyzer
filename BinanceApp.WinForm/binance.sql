SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[symbol] [nvarchar](16) COLLATE Turkish_CI_AS NOT NULL,
	[price] [decimal](18, 8) NOT NULL,
	[checked] [datetime] NOT NULL,
 CONSTRAINT [PK_latestPrices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[prices] ADD  CONSTRAINT [DF_latestPrices_checked]  DEFAULT (getdate()) FOR [checked]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_latest_price] 
	@symbol nvarchar(16),
	@price decimal(18, 8)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO prices (symbol,price) VALUES (@symbol,@price);
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_latest_prices] 
	@topn int,
	@symbol nvarchar(128)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT TOP(@topn) symbol,price,checked FROM prices
	WHERE symbol IN (SELECT value FROM STRING_SPLIT(@symbol, ','))
	ORDER BY checked DESC;
END
GO
