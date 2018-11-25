IF OBJECT_ID('Events') IS NOT NULL     
    DROP TABLE Events

CREATE TABLE [dbo].Events (
    [Id]   int identity,
    [Start] datetime NOT NULL,
	[End]   datetime NOT NULL,
	[Type] Int,
	[ClientId]  NVARCHAR (128) NOT NULL	
		foreign key references AspNetUsers(Id),
	[ServiceId]  NVARCHAR (128) NOT NULL
		foreign key references AspNetUsers(Id)
);

insert into dbo.Events  (Start, [End],Type, ClientId, ServiceId) values
('11/25/2018', '11/26/2018', 1,'f7b64a7b-ebc5-4187-959c-9999a3fcea77','f7b64a7b-ebc5-4187-959c-9999a3fcea77')


DELETE FROM [dbo].[__MigrationHistory]


