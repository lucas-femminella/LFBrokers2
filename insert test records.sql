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
           ,'Praxis Medica Individual'
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
           ,'Praxis Medica Individual'
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




INSERT INTO [dbo].[ProductoAseguradora]
           ([ID]
           ,[Producto]
           ,[Aseguradora]
           ,[Activo]
           ,[ComisionPrimaBase])
     VALUES
           (1
           ,1
           ,1
           ,1
           ,15)
GO


INSERT INTO [dbo].[ProductoAseguradora]
           ([ID]
           ,[Producto]
           ,[Aseguradora]
           ,[Activo]
           ,[ComisionPrimaBase])
     VALUES
           (2
           ,2
           ,2
           ,2
           ,20)
GO


INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(1 ,1 ,1 ,0.05)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(2 ,1 ,2 ,0.06)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(3 ,1 ,3 ,0.07)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(4 ,1 ,4 ,0.08)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(5 ,1 ,5 ,0.09)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(6 ,1 ,6 ,0.10)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(7 ,1 ,7 ,0.11)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(8 ,1 ,8 ,0.12)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(9 ,1 ,9 ,0.13)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(10 ,1 ,10 ,0.14)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(11 ,1 ,11 ,0.15)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(12 ,1 ,12 ,0.16)
GO

INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(13 ,2 ,1 ,0.05)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(14 ,2 ,2 ,0.06)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(15 ,2 ,3 ,0.07)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(16 ,2 ,4 ,0.08)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(17 ,2 ,5 ,0.09)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(18 ,2 ,6 ,0.10)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(19 ,2 ,7 ,0.11)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(20 ,2 ,8 ,0.12)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(21 ,2 ,9 ,0.13)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(22 ,2 ,10 ,0.14)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(23 ,2 ,11 ,0.15)
GO
INSERT INTO [dbo].[RecargoCuotas] ([ID] ,[Aseguradora] ,[CantidadCuotas] ,[RecargoFinanciero])
VALUES(24 ,2 ,12 ,0.16)
GO

INSERT INTO [dbo].[EspecialidadPrimaPorSuma]
           ([ID]
           ,[Especialidad]
           ,[PrimaBase]
           ,[SumaAsegurada]
           ,[ProductoAseguradora]
           ,[EspecialidadCodigoExterno]
           ,[PrimaVigenteDesde])
     VALUES
           (1
           ,1
           ,2500
           ,500000
           ,1
           ,1
           , DATEADD(year, 1, GETDATE()))
GO

INSERT INTO [dbo].[EspecialidadPrimaPorSuma]
           ([ID]
           ,[Especialidad]
           ,[PrimaBase]
           ,[SumaAsegurada]
           ,[ProductoAseguradora]
           ,[EspecialidadCodigoExterno]
           ,[PrimaVigenteDesde])
     VALUES
           (2
           ,2
           ,5500
           ,1000000
           ,1
           ,2
           , DATEADD(year, 1, GETDATE()))
GO

INSERT INTO [dbo].[EspecialidadPrimaPorSuma]
           ([ID]
           ,[Especialidad]
           ,[PrimaBase]
           ,[SumaAsegurada]
           ,[ProductoAseguradora]
           ,[EspecialidadCodigoExterno]
           ,[PrimaVigenteDesde])
     VALUES
           (3
           ,3
           ,14000
           ,1500000
           ,1
           ,2
           , DATEADD(year, 1, GETDATE()))
GO