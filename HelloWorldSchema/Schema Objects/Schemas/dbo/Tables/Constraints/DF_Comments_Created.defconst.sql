ALTER TABLE [dbo].[Comments]
    ADD CONSTRAINT [DF_Comments_Created] DEFAULT (getdate()) FOR [Created];

