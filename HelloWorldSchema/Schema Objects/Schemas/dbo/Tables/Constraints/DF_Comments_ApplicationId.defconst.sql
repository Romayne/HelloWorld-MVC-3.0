ALTER TABLE [dbo].[Comments]
    ADD CONSTRAINT [DF_Comments_ApplicationId] DEFAULT ((0)) FOR [ApplicationId];

