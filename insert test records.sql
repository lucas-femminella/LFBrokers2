USE [LFbrokers]
GO

INSERT INTO [dbo].[Zona] ([ID] ,[Zona],[Impuesto])  
VALUES (1, 'Zona 1', 0.10)
GO


INSERT INTO [dbo].[Zona] ([ID] ,[Zona],[Impuesto])  
VALUES (2, 'Zona 2', 0.20)
GO


INSERT INTO [dbo].[Zona] ([ID] ,[Zona],[Impuesto])  
VALUES (3, 'Zona 3', 0.30)
GO



INSERT INTO [dbo].[Provincia] ([ID], [Provincia])
VALUES(1, 'Provincia 1')
GO

INSERT INTO [dbo].[Provincia] ([ID], [Provincia])
VALUES(2, 'Provincia 2')
GO

INSERT INTO [dbo].[Provincia] ([ID], [Provincia])
VALUES(3, 'Provincia 3')
GO



INSERT INTO [dbo].[Localidad] ([ID], [Localidad], [Provincia])
VALUES (1 ,'Localidad 1', 1)
GO

INSERT INTO [dbo].[Localidad] ([ID], [Localidad], [Provincia])
VALUES (2 ,'Localidad 2', 2)
GO

INSERT INTO [dbo].[Localidad] ([ID], [Localidad], [Provincia])
VALUES (3 ,'Localidad 3', 3)
GO



INSERT INTO [dbo].[CodigoPostal]([ID] ,[CodigoPostal], [Localidad], [Zona])
VALUES (1, 'CP1', 1, 1)
GO

INSERT INTO [dbo].[CodigoPostal]([ID] ,[CodigoPostal], [Localidad], [Zona])
VALUES (2, 'CP2', 2, 2)
GO

INSERT INTO [dbo].[CodigoPostal]([ID] ,[CodigoPostal], [Localidad], [Zona])
VALUES (3, 'CP3', 3, 3)
GO



INSERT INTO [dbo].[Aseguradora] ([ID],[Nombre],[Codigo])
VALUES (1 ,'Aseguradora 1', 1)
GO


INSERT INTO [dbo].[Aseguradora] ([ID],[Nombre],[Codigo])
VALUES (2 ,'Aseguradora 2', 2)
GO



INSERT INTO [dbo].[Ramo]
           ([ID]
           ,[Ramo])
     VALUES
           (1
           ,'Ramo 1')
GO


INSERT INTO [dbo].[Ramo]
           ([ID]
           ,[Ramo])
     VALUES
           (2
           ,'Ramo 2')
GO

INSERT INTO [dbo].[Ramo]
           ([ID]
           ,[Ramo])
     VALUES
           (3
           ,'Ramo 3')
GO

INSERT INTO [dbo].[Producto]
           ([ID]
           ,[Producto]
           ,[Descripcion]
           ,[Ramo])
     VALUES
           (1
           ,'Producto 1'
           ,'Descripcion 1'
           ,1)
GO


INSERT INTO [dbo].[Producto]
           ([ID]
           ,[Producto]
           ,[Descripcion]
           ,[Ramo])
     VALUES
           (2
           ,'Producto 2'
           ,'Descripcion 2'
           ,2)
GO

INSERT INTO [dbo].[Producto]
           ([ID]
           ,[Producto]
           ,[Descripcion]
           ,[Ramo])
     VALUES
           (3
           ,'Producto 3'
           ,'Descripcion 3'
           ,3)
GO


INSERT INTO [dbo].[Especialidad]
           ([ID]
           ,[Nombre]
           ,[Observaciones]
           ,[Producto]
           ,[Riesgo])
     VALUES
           (1
           ,'Especialidad 1'
           ,'Observacion 1'
           ,1
           ,1)
GO


INSERT INTO [dbo].[Especialidad]
           ([ID]
           ,[Nombre]
           ,[Observaciones]
           ,[Producto]
           ,[Riesgo])
     VALUES
           (2
           ,'Especialidad 2'
           ,'Observacion 2'
           ,2
           ,2)
GO

INSERT INTO [dbo].[Especialidad]
           ([ID]
           ,[Nombre]
           ,[Observaciones]
           ,[Producto]
           ,[Riesgo])
     VALUES
           (3
           ,'Especialidad 3'
           ,'Observacion 3'
           ,3
           ,3)
GO



