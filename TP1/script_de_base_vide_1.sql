

/* Nom(s) :Leo Mercier Darren Lambert */


/* PARTIE 2 */
/* détruit la bd si elle existe */
use master
go

IF  EXISTS (SELECT name FROM sys.databases 
		    WHERE name = 'bd_natation')
  drop database bd_natation
go
/* création de votre bd et de vos tables */

create database bd_natation
go 

use bd_natation
go

CREATE TABLE tbl_Categorie_Nageur(
    ID        INT IDENTITY (1,1) NOT NULL ,
    Age NVARCHAR(10) NOT NULL,
    CONSTRAINT Categorie_Nageur_PK PRIMARY KEY (ID),
	CONSTRAINT UC UNIQUE (Age)
)
go
/*Table des nageurs, avec cle etrangeres vers la table des categorie*/
CREATE TABLE tbl_Nageur(
    ID                    INT IDENTITY (1,1) NOT NULL ,
    Nom                   NVARCHAR (100) NULL , /* Test du champ Null qui doit être modifier en not null */
    Prenom                NVARCHAR (100) NOT NULL ,
    Genre                 NCHAR (1)  NOT NULL DEFAULT 'M',
    Adresse_Email         NVARCHAR (200) NOT NULL ,
    Id_Categorie_Nageur   INT  NULL  ,
    CONSTRAINT Nageur_PK PRIMARY KEY (ID)
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
	CONSTRAINT UC_cat_compe UNIQUE (Id_Categori_Compet)
);
go
CREATE TABLE tbl_Resultat(
    Id_competition          INT  NOT NULL ,
    Id_Nageur   INT  NOT NULL ,
    Position    INT   NULL  ,
    CONSTRAINT Resultat_PK PRIMARY KEY (ID_competition,Id_Nageur),
	CONSTRAINT UC_comp UNIQUE (Id_competition)
)
go

ALTER TABLE tbl_Resultat ADD 
	CONSTRAINT [FK_resultat] FOREIGN KEY 
	(Id_competition) REFERENCES tbl_Competition (ID) ON UPDATE CASCADE,
	CONSTRAINT [FK_nageur] FOREIGN KEY (Id_Nageur) REFERENCES tbl_Nageur (ID) ON UPDATE CASCADE
GO

ALTER TABLE tbl_Competition ADD
	CONSTRAINT [FK_categori_competition] FOREIGN KEY
	(Id_Categori_Compet) REFERENCES tbl_Categori_Compet (ID) ON UPDATE CASCADE
go

ALTER TABLE tbl_Nageur ADD
	CONSTRAINT [FK_categori_nageur] FOREIGN KEY
	(Id_Categorie_Nageur) REFERENCES tbl_Categorie_Nageur (ID) ON UPDATE CASCADE
go

/* toutes les contraintes sont définis dans le create de la table auncune contrainte après le create (dans le cas d'une table avec clé étrangère)*/

/* toutes les contraintes sont définis après la creation de la table (dans le cas d'une table avec clé étrangère)*/

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
/* contrainte pas 2 données pareilles */


/* PARTIE 3 */
/* insertion de données en batch à partir de LT_classe*/
Insert into tbl_Categori_Compet
VALUES(
	'Facile'
)
GO
Insert into tbl_Categorie_Nageur
VALUES(
	'30-35'
)
GO
Insert into tbl_Competition
Values(
	'Les Papa nageux',
	'Cette course est destiné au Père de famille',
	10.2,
	1
)
GO

Insert into tbl_Nageur 
VALUES(
	'Paquet',
	'Denis',
	'M',
	'denisPaquet3@gmail.com',
	1
)
go

Insert Into tbl_Resultat
VALUES(
	1,
	1,
	NULL
)
GO
/* insertion données spécifiques */
insert into tbl_Nageur(Nom, Prenom, Genre, Adresse_Email)
select nom, prenom, sexe, nom+prenom+'@gmail.com'
from DBelection.dbo.elec2017
where not nom='' AND NOT prenom='' AND sexe like '[M,F]'
go

/* test des contraintes */
		
		sp_help tbl_Nageur
		go
		sp_help tbl_Competition
		go
		sp_help tbl_Resultat
		go
		sp_help tbl_Categorie_Nageur
		go
		sp_help tbl_Categori_Compet
		go

		

/* grand select pour démontrer ajouts imposés */
select * from tbl_Competition
select * from tbl_Nageur
select * from tbl_Resultat
select * from tbl_Categorie_Nageur
select * from tbl_Categori_Compet