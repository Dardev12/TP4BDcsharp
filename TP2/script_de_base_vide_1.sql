

/* Nom(s) :Leo Mercier Darren Lambert */


/* PARTIE 2 */
/* d�truit la bd si elle existe */
use master
go
IF  EXISTS (SELECT name FROM sys.databases 
		    WHERE name = 'bd_natation')
  drop database bd_natation
go
/* cr�ation de votre bd et de vos tables */

create database bd_natation
go

use bd_natation
go

CREATE TABLE tbl_Categorie_Nageur(
    ID        INT IDENTITY (1,1) NOT NULL ,
    Age   NVARCHAR(10)  NOT NULL ,
    CONSTRAINT Categorie_Nageur_PK PRIMARY KEY (ID),
	CONSTRAINT UC UNIQUE (Age)
)
go
/*Table des nageurs, avec cle etrangeres vers la table des categorie*/
CREATE TABLE tbl_Nageur(
    id_nageur                    INT IDENTITY (1,1) NOT NULL ,
    Nom                   NVARCHAR (100) NULL , /* Test du champ Null qui doit �tre modifier en not null */
    Prenom                NVARCHAR (100) NOT NULL ,
    Genre                 NCHAR (1)  NOT NULL DEFAULT 'M',
    Adresse_Email         NVARCHAR (200) NOT NULL ,
    Id_Categorie_Nageur   INT  NULL  ,
    CONSTRAINT Nageur_PK PRIMARY KEY (id_nageur)
)
go


CREATE TABLE tbl_Categori_Compet(
    ID       INT IDENTITY (1,1) NOT NULL ,
    Niveau   NVARCHAR (100) NOT NULL  ,
    CONSTRAINT Categori_Compet_PK PRIMARY KEY (ID)
)
go
CREATE TABLE tbl_Competition(
    ID                   INT IDENTITY (1,1) NOT NULL ,
    Nom                  NVARCHAR (100) NOT NULL ,
    Description          NVARCHAR (100) NOT NULL ,
    Distance             DECIMAL	NOT NULL ,
    Id_Categori_Compet   INT  NOT NULL  ,
    CONSTRAINT Competition_PK PRIMARY KEY (ID),
);
go
CREATE TABLE tbl_Resultat(
    Id_competition          INT  NOT NULL ,
    Id_Nageur   INT  NOT NULL ,
    Position    INT   NULL  ,
    CONSTRAINT Resultat_PK PRIMARY KEY (ID_competition,Id_Nageur)
)
go

ALTER TABLE tbl_Resultat ADD 
	CONSTRAINT [FK_resultat] FOREIGN KEY 
	(Id_competition) REFERENCES tbl_Competition (ID) ON UPDATE CASCADE,
	CONSTRAINT [FK_nageur] FOREIGN KEY (Id_Nageur) REFERENCES tbl_Nageur (id_nageur) ON UPDATE CASCADE
GO

ALTER TABLE tbl_Competition ADD
	CONSTRAINT [FK_categori_competition] FOREIGN KEY
	(Id_Categori_Compet) REFERENCES tbl_Categori_Compet (ID) ON UPDATE CASCADE
go

ALTER TABLE tbl_Nageur ADD
	CONSTRAINT [FK_categori_nageur] FOREIGN KEY
	(Id_Categorie_Nageur) REFERENCES tbl_Categorie_Nageur (ID) ON UPDATE CASCADE
go

/* toutes les contraintes sont d�finis dans le create de la table auncune contrainte apr�s le create (dans le cas d'une table avec cl� �trang�re)*/

/* toutes les contraintes sont d�finis apr�s la creation de la table (dans le cas d'une table avec cl� �trang�re)*/

/* contraintes */
ALTER TABLE tbl_Nageur WITH NOCHECK 
ADD CONSTRAINT ls_GENRE CHECK(Genre like '[M,F]')
go
	
ALTER TABLE tbl_Nageur WITH NOCHECK 
ADD CONSTRAINT ls_EMAIL CHECK(Adresse_Email  like '%@%')
go

ALTER TABLE tbl_Resultat WITH NOCHECK 
ADD CONSTRAINT ls_position CHECK(Position  between 0 and 7)
go
/* modification d'un null en not null */
/*alter table test null champ 'Nom' tbl_nageur*/
alter table
	tbl_Nageur
alter column
	Nom
		NVARCHAR (100) NOT NULL;
go
/* contrainte pas 2 donn�es pareilles */


/* PARTIE 3 */
/* insertion de donn�es en batch � partir de LT_classe*/
Insert into tbl_Categori_Compet
VALUES(
	'Facile'
)
GO
Insert into tbl_Categori_Compet
VALUES(
	'Moyen'
)
GO
Insert into tbl_Categori_Compet
VALUES(
	'Complex'
)
GO

Insert into tbl_Categorie_Nageur
VALUES(
	'10-15'
)
GO
Insert into tbl_Categorie_Nageur
VALUES(
	'15-20'
)
GO
Insert into tbl_Categorie_Nageur
VALUES(
	'20-30'
)
GO
Insert into tbl_Categorie_Nageur
VALUES(
	'30-35'
)
go
Insert into tbl_Competition
Values(
	'Les Papa nageurs',
	'Cette course est destine au Pere de famille',
	10.2,
	1
)
go
Insert into tbl_Competition
Values(
	'Les maman nageuses',
	'Cette course est destine aux mamans',
	8.0,
	2
)
go
Insert into tbl_Competition
Values(
	'Les enfants nageurs',
	'Cette course est destine aux enfants',
	10.2,
	3
)
go
Insert into tbl_Competition
Values(
	'test',
	'test',
	10.2,
	3
)
go

Insert into tbl_Nageur 
VALUES(
	'Paquet',
	'Denis',
	'M',
	'denisPaquet3@gmail.com',
	1
)
go
Insert into tbl_Nageur 
VALUES(
	'lambert',
	'darren',
	'M',
	'lambertdarren@gmail.com',
	2
)
go
Insert into tbl_Nageur 
VALUES(
	'mercier',
	'leo',
	'M',
	'mercierleo@gmail.com',
	2
)
go
Insert into tbl_Nageur 
VALUES(
	'Pav',
	'Olic',
	'M',
	'pavolic@gmail.com',
	2
)
go
Insert into tbl_Nageur 
VALUES(
	'Walls',
	'Miranda',
	'F',
	'wallsmiranda@gmail.com',
	2
)
go
Insert into tbl_Nageur 
VALUES(
	'Labbé',
	'Arianne',
	'F',
	'labbearianne@gmail.com',
	2
)
go

Insert Into tbl_Resultat
VALUES(
	1,
	1,
	NULL
)
GO
Insert Into tbl_Resultat
VALUES(
	1,
	2,
	NULL
)
GO
Insert Into tbl_Resultat
VALUES(
	1,
	3,
	NULL
)
GO
Insert Into tbl_Resultat
VALUES(
	2,
	3,
	NULL
)
GO

Insert Into tbl_Resultat
VALUES(
	3,
	3,
	NULL
)
GO
/* insertion donn�es sp�cifiques */
insert into tbl_Nageur(Nom, Prenom, Genre, Adresse_Email)
select nom, prenom, sexe, nom+prenom+'@gmail.com'
from DBelection.dbo.elec2017
where not nom='' AND NOT prenom='' AND sexe like '[M,F]'
go

/* test des contraintes */
select * from tbl_Nageur
go
/* grand select pour d�montrer ajouts impos�s */
create view vueNageurCompe
as
select tbl_Competition.ID ,tbl_Nageur.id_nageur ,tbl_Nageur.nom, tbl_Nageur.prenom, tbl_Resultat.position from tbl_Competition inner join tbl_Resultat on tbl_Competition.ID = tbl_Resultat.Id_competition
inner join tbl_Nageur on tbl_Resultat.Id_Nageur = tbl_Nageur.id_nageur
go

select * from vueNageurCompe
where ID = 1
go

create procedure updateView
@id_compe INT,
@id_nageur INT,
@position INT
as
begin
update vueNageurCompe
set position = @position
where id_nageur = @id_nageur and ID = @id_compe
end
go

create procedure DesincriptionCompe
@no_nageur INT
as
begin try
	set nocount on
	begin transaction
		/*delete from tbl_Resultat where Id_Nageur=@no_nageur
		delete from tbl_Nageur where Id_Nageur=@no_nageur*/
		/* erreur provoquée : contrainte de référence :no_cours inexistant*/
		insert into tbl_Resultat (Id_Nageur,Id_competition,Position) values ('Bjr','AWE','H20')

	commit transaction
end try
begin catch
	if @@TRANCOUNT>0
		begin
			rollback transaction
			raiserror('Erreur lors de la supression',16,1)
		end
end catch
go
