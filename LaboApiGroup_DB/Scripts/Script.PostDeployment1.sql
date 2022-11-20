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
INSERT INTO [Gift] (Gift_Type,landing) VALUES
('DiscDurExterne',2),
('pcPortable i3',3),
('Oppo reno',4),
('IPhone',5),
('Trotinetteelectrique',6)

INSERT INTO [Role] (Name) VALUES
('Coordinateur'),
('Administrateur'),
('Contributeur'),
('projectOwner'),
('Analyste')

INSERT INTO [Project] (Start_Date,End_Date,Description,Tittle,Financial_Targets,Earn_Money) VALUES
('2022/08/12','2024/04/19','Implementation des structures publics de base pour les communes de la ville','Renovation structure',900000,850000),
('2020/05/10','2023/02/05','Mise en place du Systeme de management de la firme avec toute la documentation requise et installation du parc machine','S.M.D',900000,500000),
('2020/10/16','2024/05/27','Nouveau systéme de gestion informatisé pour les ASBL','Renovation structure',1000000,400000),
('2022/08/12','2024/04/19','Prologiciel pour gerer les documents digitaux ','prologiciel de gestion',500000,20000),
('2021/08/12','2024/06/25','creation deflux facilitateur pour le control et la validation des produits pharma ','installation',1500000,2000000)
