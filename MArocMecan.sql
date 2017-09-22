create database MarocMecan 
GO 
use MarocMecan
Go

Go
 create table Modele (
Id_Modele int Primary key ,
Libelle_Modele varchar(30)
)
GO
create table Piece (
Id_Piece int Primary key,
Libelle_Piece varchar(30),
Id_modele int references Modele(Id_Modele)
)
GO
create table Etat(
Id_Etat int Primary key ,
Libelle_Etat varchar(30),

)

GO
create table Lot (
Id_Lot int Primary key ,
Libelle_Lot varchar(30),
Date_Achat DateTime,
PrixAchat decimal(10,2),
)

GO
create table Materiel (
Id_Materiel int primary key ,
Description_Mat varchar(100),
NSerie int ,
id_modele int references Modele(Id_Modele),
PrixAchat decimal(10,2),
Id_Lot int references Lot(Id_Lot),
Id_Etat int references Etat(Id_Etat),
)
GO
create table Preparation (
Id_Preparation int Primary key ,
id_piece int references Piece(Id_Piece),
id_materiel int references Materiel(Id_Materiel) on delete set null,
Dtae_Envoie_Reparation DateTime,
Date_Retour_Reparation DateTime,
Montant_Reparation Decimal(10,2),
Observation_Reparation varchar(200)
)
 -- Constraints ----------------------------
alter table Preparation add constraint CH_DateRetrour_DateEnvoi check(Dtae_Envoie_Reparation < Date_Retour_Reparation)
alter table Preparation add constraint Montant_Reparation check( Montant_Reparation >0)
GO
-- 3  Procedure Stocke ---------------------
alter Procedure CalculerMontantModel @Id_Modele int , @Montan Decimal(10,2) output 
as begin

 set @Montan= ( select sum(Montant_Reparation) from Preparation where id_piece in ( select Id_Piece from Piece where Id_modele=2))

End
GO
declare  @Modd decimal(10,2)
exec CalculerMontantModel 2 ,@Modd output
select @Modd
----------- 5 fonction retourn Prix Reparation 
GO
create function RetourPrixReparationMat( @IDMAT int)
returns Decimal(10,2)
as
begin 
return (select sum(Montant_Reparation)  from Reparation where id_materiel =@IDMAT)
End
GO
-- 6 TSQL Aficcher pour chaque materiel (ID_Mat,Designation,Coutreparation)
select Id_Materiel, Description_Mat, dbo.RetourPrixReparationMat(Id_Materiel) from Materiel
---------------------------------------------
GO
--- 4 Procedure Stocke
create Procedure PS_ListeMateriel @Date1 date , @Date2 date
as begin 
select *from Reparation where Dtae_Envoie_Reparation between @Date1 and @Date2
end
GO

Exec PS_ListeMateriel '2014-01-01' ,'2017-10-01'

--------------------





exec sp_rename 'Preparation','Reparation'