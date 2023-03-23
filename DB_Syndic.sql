drop database DB

create table Logement
(
	NumLogement int primary key ,
)
create table Coproprietaire(

	 CinCop int primary key  IDENTITY(1,1) , 
	 NomCop varchar(20),
	 PrenomCop varchar(20),
	 Email varchar(20),
	 Tel int ,
		 int foreign key references Logement(NumLogement) unique
)
alter table Coproprietaire
alter column CinCop varchar(30)
create table Rubrique(
	) varchar(30) primary key

)
create table Depense (

	IdDepense int primary key IDENTITY(1,1),
	Rubrique varchar(30) foreign key references Rubrique(NomRubrique) on delete no action,
	NomDepense varchar(30),
	DateDepense date , 
	MontantDepense float,

)

create table Paiement (

	IdP int primary key identity(1,1)  , 
	CinCop int foreign key references Coproprietaire(CinCop),
	NumLogement int foreign key references Logement(NumLogement),
	NomPayeur varchar(30),
	Datepaiement date , 
	MontatP float , 
	NbrMois int 
)
create table Statupaiement(

	IdStatut int identity(1,1) primary key,
	CinCoproprio int foreign key references Coproprietaire(CinCop),
	NumLogement int foreign key references Logement(NumLogement),
	Mois int,
	Annee int

)
