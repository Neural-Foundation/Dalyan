﻿CREATE TABLE [dbo].[SampleTable] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (50)  NULL,
    [CompanyId]        INT            NULL,
    [Gender]           INT            NULL,
    [Active]           BIT            NULL,
    [Movies]           NVARCHAR (50)  NULL,
    [Series]           NVARCHAR (50)  NULL,
    [ProfilePicture]   IMAGE          NULL,
    [LoginDate]        DATETIME       NULL,
    [LongLoginDate]    DATETIME       NULL,
    [LongText]         NVARCHAR (500) NULL,
    [Price]            FLOAT (53)     NOT NULL,
    [Price2]           DECIMAL (18)   NULL,
    [CreatedDate]      DATETIME       NULL,
    [CreatedIpAddress] NVARCHAR (50)  NULL,
    [CreatedUserId]    INT            NULL,
    [UpdatedDate]      DATETIME       NULL,
    [UpdatedIpAddress] NVARCHAR (50)  NULL,
    [UpdatedUserId]    INT            NULL,
    [IsDeleted]        BIT            NULL,
    CONSTRAINT [PK_SampleTable] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SampleTable_Company] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company] ([Id])
);
