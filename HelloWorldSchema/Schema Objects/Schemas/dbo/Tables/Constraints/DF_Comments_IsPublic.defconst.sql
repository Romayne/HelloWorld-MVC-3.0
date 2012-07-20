ALTER TABLE [dbo].[Comments]
    ADD CONSTRAINT [DF_Comments_IsPublic] DEFAULT ((0)) FOR [IsPublic];

