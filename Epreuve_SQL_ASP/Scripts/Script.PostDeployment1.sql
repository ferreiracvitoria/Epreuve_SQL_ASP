/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

-- Insertion de données fictives dans la table CritereEcologique
INSERT INTO [dbo].[CritereEcologique] ([Nom]) VALUES
('Biologique'),
('Recyclable'),
('Énergie propre'),
('Faible empreinte carbone'),
('Éco-labellisé');

-- Insertion de données fictives dans la table Categorie
INSERT INTO [dbo].[Categorie] ([Nom]) VALUES
('Électronique'),
('Vêtements'),
('Alimentation'),
('Mobilier'),
('Produits de beauté');

-- Insertion de données fictives dans la table Produit avec critères écologiques
INSERT INTO [dbo].[Produit] ([Id_CritereEcologique], [Id_Categorie], [Nom], [Description], [Prix], [Stock]) VALUES
-- Produit 1
(1, 3, 'Ordinateur portable écologique', 'Ordinateur portable éco-responsable avec faible consommation d''énergie.', 1200.00, 50),

-- Produit 2
(2, 4, 'Sac recyclable en coton', 'Sac en coton recyclable, idéal pour faire vos courses de manière écologique.', 19.99, 100),

-- Produit 3
(3, 2, 'Barre énergétique biologique', 'Barre énergétique bio, sans additifs chimiques.', 2.49, 200),

-- Produit 4
(4, 5, 'Shampooing naturel', 'Shampooing écologique, fabriqué à partir d''ingrédients naturels.', 8.99, 75),

-- Produit 5
(5, 1, 'Meuble en bois certifié FSC', 'Meuble en bois provenant de forêts gérées durablement, certifié FSC.', 299.99, 30);


EXEC SP_Media_Insert 1, 'unnamed.jpg';
EXEC SP_Media_Insert 2, 'SacCotton.jpg';
EXEC SP_Media_Insert 3, 'BarresEnergetiques.jpg';
EXEC SP_Media_Insert 4, 'Shampooing.png';
EXEC SP_Media_Insert 5, 'Meuble.webp';


