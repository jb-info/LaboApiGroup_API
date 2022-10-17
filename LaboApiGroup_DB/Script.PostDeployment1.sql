/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO [Users]
VALUES
('Ayoub Macbaete', 'ayoubmacbaete@gmail.com', '1234=test', '2001-03-03'),
('Jeremy Bouillon', 'jeremybouillon@gmail.com', '1234=test', '1979-02-03'),
('Michael Buyens', 'michaelbuyens@gmail.com', '1234=test', '2002-03-03')

INSERT INTO [Transaction]
VALUES
('Peluche', 100),
('Iphone', 5000),
('Porsche', 500000)

INSERT INTO Role
VALUES
('ProjectOwner'),
('Administrateur'),
('Contributeur'),
('Utilisateur')

INSERT INTO Project
VALUES
('2022-01-01', '2024-01-01','Aventure intérieur avec des microbes ...', 'Mon test DB', 15000, 100),
('2012-11-12', '2023-06-05',' Les paramètres date et format correspondent respectivement à une donnée de type Date ou DateTime et au format', 'Les paramètres date et format correspondent', 15000, 100),
('2022-01-01', '2024-01-01','Il n’y a pas le nom de colonne, donc les fautes de frappe sont limitées. Par ailleurs, les colonnes peuvent être renommées sans avoir à changer la requête ...', 'les colonnes peuvent être renommées', 150000, 100),
('2022-01-01', '2024-01-01','Il est possible d’ajouter plusieurs lignes à un tableau avec une seule requête. ...', 'Mune seule requête', 15000, 100)