/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/
create database GESTION_DES_CONGE2
use GESTION_DES_CONGE2


use master 
alter database GESTION_DES_CONGE2 set single_user 
alter database GESTION_DES_CONGE2 collate Arabic_ci_as
alter database GESTION_DES_CONGE2 set multi_user

/*------------------------------------------------------------
-- Table: Type_congé
------------------------------------------------------------*/
CREATE TABLE Type_conge(
	id_type        INT  NOT NULL ,
	libelle_type   VARCHAR (150) NOT NULL  ,
	CONSTRAINT Type_conge_PK PRIMARY KEY (id_type)
);


/*------------------------------------------------------------
-- Table: Devision
------------------------------------------------------------*/
CREATE TABLE Devision(
	id_devision    INT  NOT NULL ,
	libelle_D_FR   VARCHAR (150) NOT NULL ,
	libelle_D_AR   VARCHAR (150) NOT NULL  ,
	CONSTRAINT Devision_PK PRIMARY KEY (id_devision)
);


/*------------------------------------------------------------
-- Table: Service
------------------------------------------------------------*/
CREATE TABLE Service(
	id_service     INT  NOT NULL ,
	libelle_S_FR   VARCHAR (150) NOT NULL ,
	libelle_S_AR   VARCHAR (150) NOT NULL ,
	id_devision    INT null   ,
	CONSTRAINT Service_PK PRIMARY KEY (id_service)

	,CONSTRAINT Service_Devision_FK FOREIGN KEY (id_devision) REFERENCES Devision(id_devision)
);


/*------------------------------------------------------------
-- Table: Employe
------------------------------------------------------------*/
CREATE TABLE Employe(
	N_dote        INT  NOT NULL ,
	Nom_FR        VARCHAR (50) NOT NULL ,
	Prenom_FR     VARCHAR (50) NOT NULL ,
	Nom_AR        VARCHAR (50) NOT NULL ,
	Prenom_AR     VARCHAR (50) NOT NULL ,
	Grade_FR      VARCHAR (50) NOT NULL ,
	Grade_AR      VARCHAR (50) NOT NULL ,
	Service_FR    VARCHAR (50) NULL ,
	Service_AR    VARCHAR (50) NULL ,
	Login         VARCHAR (50)  NULL ,
	Mot_de_pass   VARCHAR (50)  NULL ,
	duree_date_precedent     int default(0) ,
	duree_date_actuel         int ,
	statue        VARCHAR (50)  NULL ,
	date_D_A      DATETIME  NULL ,
	date_F_A      DATETIME  NULL ,
	id_service    INT  NOT NULL  ,
	CONSTRAINT Employe_PK PRIMARY KEY (N_dote)

	,CONSTRAINT Employe_Service_FK FOREIGN KEY (id_service) REFERENCES Service(id_service) on update cascade on delete cascade
);
drop table Employe
/*------------------------------------------------------------
-- Table: Detaille_Type_conge
------------------------------------------------------------*/
CREATE TABLE Detaille_Type_conge(
	--id_detaille_type_c   INT  NOT NULL ,
	id_type              INT  NOT NULL,
	libelle_conge        VARCHAR (150) NOT NULL ,
	Nb_jour              INT NULL 
	  
	--CONSTRAINT Detaille_Type_conge_PK PRIMARY KEY (id_detaille_type_c)

	,CONSTRAINT Detaille_Type_conge_Type_conge_FK FOREIGN KEY (id_type) REFERENCES Type_conge(id_type)
);
drop table Detaille_Type_conge

/*------------------------------------------------------------
-- Table: jours_ferier
------------------------------------------------------------*/
CREATE TABLE jours_ferier(
	Id_jour       INT  NOT NULL ,
	jour_firier   VARCHAR (100) NOT NULL ,
	date_jour_D    DATE NOT NULL  ,
	date_jour_F    DATE NOT NULL  ,
	CONSTRAINT jours_ferier_PK PRIMARY KEY (Id_jour)
);
drop table jours_ferier

/*------------------------------------------------------------
-- Table: Congé
------------------------------------------------------------*/
------------------------------------------------------------*/
CREATE TABLE Conge(
    N_conge int primary key ,
	N_dote                INT  NOT NULL ,
	Nom_employe           VARCHAR (100) NOT NULL ,
	prenom_employe        VARCHAR (100) NOT NULL  ,
	date_D                DATE NOT NULL ,
	date_F                DATE NOT NULL ,
	Nb_jour               INT  NOT NULL ,
	Date_saisie           DATE NULL ,
	Anne                  DATE NULL ,
	
	id_type_c             INT  NOT NULL ,
	type_de_conge         VARCHAR (100) NOT NULL,	
	N_dote_remplacement   INT  NOT NULL ,
	Nom_remplacement      VARCHAR (100) NOT NULL ,
	Prenom_remplacement   VARCHAR (100) NOT NULL 
	
	
	--CONSTRAINT Conge_PK PRIMARY KEY (N_dote,Id_jour,id_detaille_type_c)

	,CONSTRAINT Conge_Employe_FK FOREIGN KEY (N_dote) REFERENCES Employe(N_dote)on update cascade on delete cascade
	--,CONSTRAINT Conge_jours_ferier0_FK FOREIGN KEY (Id_jour) REFERENCES jours_ferier(Id_jour)on update cascade on delete cascade
	--,CONSTRAINT Conge_Detaille_Type_conge1_FK FOREIGN KEY (id_detaille_type_c) REFERENCES Detaille_Type_conge(id_detaille_type_c)
);
drop table Conge
alter table conge add Num_conge int primary key not null
---------------------------------------------------PROCEDUR CONGE EXCEPTIONELLE-------------------------------------------------------------------------------------
alter proc Conge_exceptionelle(@N_dote int ,@Nom_empoye varchar(60),@prenom_employe varchar(60),@dateD date,@dateF date,@Nbjour int,@datesaisie date,@id_type_C int,@type_conge varchar(60),@Ndote_Remplacement int,@Nom_remplacement varchar(50),@prenom_remplacement varchar(50)) as
begin
declare @dateD_conge date,@dateF_conge date,@nbjoursTotal int,@Ndote int
set @dateD_conge=(select c.date_D from Conge c where c.N_dote=@N_dote)
set @dateF_conge=(select c.date_F from Conge c where c.N_dote=@N_dote)
set @nbjoursTotal =(select sum(c.Nb_jour) from Conge c where id_type_c=2 and c.N_dote=@N_dote)
set @Ndote=(select N_dote from Conge c where c.N_dote=@N_dote)

     if ( GETDATE()<=@dateD_conge or getdate() between @dateD_conge and @dateF_conge or GETDATE()=@dateF_conge  or @nbjoursTotal>10)
	 
	     print'Imposible deffectuer ce conge'
	 
	 else
	 insert into Conge(N_dote,Nom_employe,prenom_employe,date_D,date_F,Nb_jour,Date_saisie,id_type_c,type_de_conge,N_dote_remplacement,Nom_remplacement,Prenom_remplacement)
	 values(@N_dote,@Nom_empoye,@prenom_employe ,@dateD ,@dateF ,@Nbjour ,@datesaisie ,@id_type_C ,@type_conge ,@Ndote_Remplacement ,@Nom_remplacement ,@prenom_remplacement)
end
----------------------------------------------------- END PROCEDURE-------------------------------------------------------------------------------------------------
insert into Type_conge values(1,'Anuel')
insert into Type_conge values(2,'Exceptionelle')
insert into Type_conge values(3,'Maladie')

--------  ANUEL-------------------------------------------
insert into Detaille_Type_conge(id_type,libelle_conge) values(1,'Anuel')
--------  exceptionelle-------------------------------------------
insert into Detaille_Type_conge values(2,'Mariage de l''agent',10)
insert into Detaille_Type_conge values(2,'Naissence d''un enfant',3)
insert into Detaille_Type_conge values(2,'Mariage d''un enfant',3)
insert into Detaille_Type_conge values(2,'Décès du conjoint,d''un descendant ou d''un ascendant',3)
insert into Detaille_Type_conge values(2,'Décès d''un frère ou d''une soeur',2)
insert into Detaille_Type_conge values(2,'Circoncision d''un enfant',1)
insert into Detaille_Type_conge values(2,'Déménagement',2)
insert into Detaille_Type_conge values(2,' l''hospitalisation du conjoint ',2)

--------  Les jours fériés-------------------------------------------
insert into jours_ferier values(1,'Aïd Al Fitr','2020/5/24','2020/5/28');
insert into jours_ferier values(2,'Aid al Adha','2020/7/30','2020/7/31');
insert into jours_ferier values(3,'Premier Moharram','2020/11/1','2020/11/1');
insert into jours_ferier values(4,'Aid al Mawlid Annabawi','2020/10/29','2020/10/29');
----------------------------------------------------------------------------
insert into jours_ferier values(5,'Manifeste de l’Indépendance','2020/11/1','2020/11/1');
insert into jours_ferier values(6,'Fête du travail','2020/5/1','2020/5/1');
insert into jours_ferier values(7,'Fête du Trône','2020/7/30','2020/7/30');
insert into jours_ferier values(8,'Journée de Oued Ed-Dahab','2020/8/14','2020/8/14');
insert into jours_ferier values(9,'La révolution du Roi et du peuple','2020/8/20','2020/8/20');
insert into jours_ferier values(10,'Fête de la Jeunesse','2020/8/21','2020/8/21');
insert into jours_ferier values(11,'Marche verte','2020/11/6','2020/11/6');
insert into jours_ferier values(12,'Fête de l’indépendance','2020/11/18','2020/11/18');
alter table jours_ferier add  duree int

update jours_ferier set duree=DATEDIFF(	day,date_jour_D,date_jour_F)+1
select * from jours_ferier
--------------------------------------------Division----------------------------------------------------


select * from jours_ferier

insert into Devision values(1,'Division de l''évaluation et de la planification des ressources en eau','قسم تقييم وتخطيط الموارد المائية')
,(2,'Département de la gestion des ressources en eau','قسم التدبير المستدام لموارد المياه')
                           ,(3,'Section du domaine public de l''eau','قسم الملك العام المائي')
						   ,(4,'Département des affaires administratives et financières','قسم الشؤون الإدارية والمالية')
select * from Service
---------------------------------------------Service------------------------------------------------
                                    --sont division--
	 	insert into Service(id_service,libelle_S_FR,libelle_S_AR) values(1,'Le Département de la communication et de la collaboration','مصلحة التواصل واتعاون'),
	                     (2,'Département de l''informatique et de l''accession à l''information','مصلحةالمعلوميات والنضم المعلوماتية'),
					     (3,'Département de contrôle interne et d''inspection','مصلحة مراقبة التدبير والافتحاص الداخلي')
							       --sous division--
						 insert into Service    values	  (4,'Service de suivi et d''évaluation des ressources en eau','مصلحة تتبع وتقييم موارد المياه',1),

							  (5,'Office de planification et d''études des ressources en eau','مصلحة تخطيط موارد المياه والدراسات',1),

							  (6,'Office de gestion et de mise en valeur des ressources en eau','مصلحة تدبير وتنمية موارد المياه',2),

							  (7,'Office de l''eau et des travaux','مصلحة الاشغال والتجهيزات المائية',2),

							  (8,'Autorité de la qualité de l''eau','مصلحة جودة المياه',2),

							  (9,'Le service public de gestion de l''eau','مصلحة تدبير الملك العام المائي',3),

							  (10,'Autorité juridique et des conflits','مصلحة الشؤون القانونية والنزاعات',3),

							  (11,'Office des aides et redevances','مصلحة المساعدات والاتاوات',3),

							  (12,'Département Programmation et Finance','مصلحة البرمجة والتمويل',4),

							  (13,'Autorité des ressources humaines et des moyens généraux','مصلحة الموارد البشرية والوسائل العامة',4),

							  (14,'Département des transactions et de la comptabilité','مصلحة الصفقات والمحاسبة',4)

							  -- 
-------------------------------------------TRIGER-------------------------------------------------------------------------------------------------------------
alter trigger demenuer_duree on conge after insert as 

begin 
     declare @duree_rest int 
	 
	 set @duree_rest =e.Duree_rest  from Employe e inner join Conge c on e.N_dote=c.N_dote
	 update Employe set employe.Duree_rest=@duree_rest
end
drop trigger demenuer_duree
select * from Conge
select * from Employe
 
--///////////////////////////////////////////  NEW PROC /////////////////////////////////////////////////////////// 
create  proc duree_F_C(@N_dote int,@duree int)as
      begin
         declare @duree_date_precedent int
		 declare @duree_date_actuel int
	     
	     declare @nb_F int

	     set @duree_date_precedent=(select e.duree_date_precedent from Employe e where N_dote=@N_dote)
		 set @duree_date_actuel=(select e.duree_date_actuel from Employe e where N_dote=@N_dote)
		 -----------------
		declare @d int =(select duree_date_precedent from Employe where N_dote=@N_dote)
	    declare @dd int
		set @dd=@duree-@duree_date_precedent
		declare @ddd int 
		set @ddd=@duree-@dd
	    --------------------
		if(@duree<=@duree_date_precedent)
		update Employe set duree_date_precedent=duree_date_precedent-@duree where N_dote=@N_dote
		else
		if(@duree > @duree_date_precedent)
		update Employe set duree_date_precedent=0,duree_date_actuel=duree_date_actuel-@dd where N_dote=@N_dote
		else
		if(@duree_date_precedent=0)
		update Employe set duree_date_actuel=duree_date_actuel-@duree where N_dote=@N_dote
end

drop trigger duree_F
--////////////////////////////// ENE PROC ///////////////////////////////////////////////////////////////////////////	 
--///////////////////////////////////////////////// PROC MODIFIER DUREE///////////////////////////////////////////////////
create proc modifier_N_J (@duree_N int,@N_dote int,@N_conge int) as 
begin
    declare @duree_precedent int
	declare @duree_actuel int
	declare @duree_ancienne_C int
	declare @d1 int 
	declare @d2 int
	declare @dd int
	declare @dd1 int 
	
	select @duree_ancienne_C= Nb_jour  from Conge c where N_conge =@N_conge and id_type_c=1
	select @duree_precedent=e.duree_date_precedent from Employe e where N_dote=@N_dote
	select @duree_actuel=e.duree_date_actuel from Employe e where N_dote=@N_dote
	if(@duree_N<@duree_ancienne_C)
	   begin
	        set @d1=@duree_ancienne_C-@duree_N
			set @d2=22-@duree_actuel
			if(@d2>@d1)
			  begin
			      update Employe set duree_date_actuel=(duree_date_actuel+@d1) where N_dote=@N_dote
			  end
			  else
			  if(@d2<@d1)
			     begin
				 set @dd1=@d1-@d2
				     update Employe set duree_date_precedent=@dd1,duree_date_actuel=22 where N_dote=@N_dote
			     end
	   end
	   else
	   if(@duree_N>@duree_ancienne_C)
	      begin
		       set @d1=@duree_N-@duree_ancienne_C
			     set @d2=@duree_precedent-@d1
			   if(@d2<0)
			       begin
				 
				       update Employe set duree_date_actuel=(duree_date_actuel+(@d2)) where N_dote=@N_dote
			       end
				   if(@d2>0)
				   begin
				   set @d2=@duree_precedent-@d1
				       update Employe set duree_date_precedent=@d2 where N_dote=@N_dote
				   end
	      end
end

--///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

select * from Employe
 
select * from conge where id_type_c=1
 update conge set Nb_jour=5 where N_conge=1018
update Employe set duree_date_actuel=22
delete from conge where id_type_c
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
-----------------------------------end-------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
--/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
--/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

select top 1 * from Conge where id_type_c=3 and N_dote=123

declare cur cursor for select e.N_dote,e.Nom_FR,e.Duree_rest,c.Nb_jour from Employe e inner join Conge c on e.N_dote=c.N_dote group by e.N_dote,e.Nom_FR,e.Duree_rest,c.Nb_jour
-----------------------------------------------------------------------------------

select top 1 * from Conge where id_type_c=2 and N_dote=123 and(GETDATE() between date_D and date_F) or (GETDATE()<=date_D) or (GETDATE()=date_F) order by date_F desc 


	select top 1 * from Conge where id_type_c=3 and N_dote=123 and(GETDATE() between date_D and date_F) or (GETDATE()<=date_D) or (GETDATE()=date_F) order by date_F desc
	
CREATE PROC PS_LAST_ROW AS 
BEGIN 
EXEC last_leave_S 
select * from last_leave where (GETDATE() between date_D and date_F) or (GETDATE()<=date_D) or (GETDATE()=date_F)
select * from Conge
select N_dote,Nom_employe,prenom_employe,date_D,date_F,Nb_jour,Date_saisie,id_type_c,type_de_conge,N_dote_remplacement,Nom_remplacement,Prenom_remplacement from Conge 
select * from Devision
delete Devision where id_devision=1
select * from Employe

alter table employe alter column Service_AR varchar(200) null
insert into EMPLOYE (N_dote,Nom_FR,Prenom_FR,Nom_AR,Prenom_AR,Grade_FR,Grade_AR,Login,Mot_de_pass,duree_date_actuel,statue,id_service)
values(123,'BOUFDIL','Abd assamad','بوفضيل','عبد الصمد','TS','تس','abdassamad','123azer',22,'Admin',1)
select*  from Employe
insert into EMPLOYE (N_dote,Nom_FR,Prenom_FR,Nom_AR,Prenom_AR,Grade_FR,Grade_AR,Login,Mot_de_pass,duree_date_actuel,statue,id_service)
values(128,'ALHACHMI','RACHID','الهاشمي','رشيد','TS','تس','hachimi','h1',22,'user',1)

insert into EMPLOYE (N_dote,Nom_FR,Prenom_FR,Nom_AR,Prenom_AR,Grade_FR,Grade_AR,duree_date_actuel,id_service)
values(127,'FATIHI','Rachida','فاتحي','رشيدة','TSssss','تسسسسسس',22,1)
delete from Employe
delete Employe
insert into EMPLOYE (N_dote,Nom_FR,Prenom_FR,Nom_AR,Prenom_AR,Grade_FR,Grade_AR,Duree_rest,id_service)
values(125,'SAADANI','Hamid','السعداني','حميد','TS','تس',22,1)
select * from Employe
insert into EMPLOYE (N_dote,Nom_FR,Prenom_FR,Nom_AR,Prenom_AR,Grade_FR,Grade_AR,Duree_rest,id_service)
values(124,'ALAMI','Rachid','?????','????','TS','???? ?????',22,1)
select * from Detaille_Type_conge
select * from Type_conge
insert into Type_conge values(1,'Anuel')
insert into Type_conge values(2,'Exceptionelle')
insert into Type_conge values(3,'Maladie')
select * from employe
insert into conge (N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c,type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement) values
(123,'fff','ccc','2020/03/18','2020/03/25',7,'2020/03/18','2020',1,'Anuel',123,'hhh','uhuu')
select * from  Conge

insert into Detaille_Type_conge(id_type,libelle_conge) values(3,'Maladie')
update Detaille_Type_conge set libelle_conge='Décès du conjoint' where libelle_conge='Décès du conjoint,d''un descendant ou d''un ascendant'

select * from Employe where N_dote<>123
select N_dote,Nom_employe,prenom_employe,date_D,date_F,Nb_jour,Date_saisie,id_type_c,type_de_conge,N_dote_remplacement,Nom_remplacement,Prenom_remplacement from Conge where id_type_c=2
select * from  Detaille_Type_conge

insert into conge(N_conge,N_dote,Nom_employe,prenom_employe,date_D,date_F,Nb_jour,Date_saisie,id_type_c,type_de_conge,N_dote_remplacement,Nom_remplacement,Prenom_remplacement)
values(1,123,'بوفضيل','عبد الصمد','2020/03/18','2020/03/20',3,'2020/03/18',2,'Mariage d''un enfant',124,'عالمي','رشيد')
select * from Conge
select* from Employe
select * from Type_conge
delete Conge where id_type_c=1

select * from Conge where N_dote='بوفضيل' and date_D='2020/03/20' and date_F='2020/03/29' and getdate() between date_D and date_F and date_D > getdate()


exec Conge_exceptionelle 125,'فاتحي','رشيدة','2020/03/22','2020/06/27',69,'2020/03/20',2,'Naissence d''un enfant',125,'عالمي','رشيد'
select * from  conge where N_dote=125 and id_type_c=3  or (getdate()<=date_D or getdate() between date_D and date_F or getdate() = date_F )
select * from  Employe
select * from  Service
select * from Devision
delete Conge where id_type_c=3
values(127,'FATIHI','Rachida','فاتحي','رشيدة','TS','تس',22,1)

select top c.*,e.Grade_AR from conge c inner join employe e on e.N_dote=c.N_dote where c.N_dote=127

select top 1 * from Conge where id_type_c=2 and N_dote=123 and    (GETDATE() between date_D and date_F)  or (GETDATE()=date_F) order by date_F desc 
select * from  conge where id_type_c=3
select top 1 * from Conge where id_type_c=3 and N_dote=127 and(GETDATE() between date_D and date_F) or (GETDATE()=date_F) order by date_F desc 
delete from Conge where id_type_c=1

select * from Employe
select * from Conge
select * from jours_ferier

update employe set Duree_rest=22

select e.N_dote,e.Nom_FR,e.Duree_rest,c.Nb_jour from Employe e  inner join conge c on e.N_dote=c.N_dote group by e.N_dote,e.Nom_FR,e.Duree_rest,c.Nb_jour

	 select * from devision
	 delete Service


-----------------------------calculer le conge anuel---------------------------------------------------------------------------------------------------
 --/////////////////function duration between two dats excluding weekends//////////////////////////////////////
 create proc ps_CountWeekDays(@fromdate Datetime, @todate Datetime) as 
 begin 
       declare @duration int
	   set @duration=(SELECT(DATEDIFF(dd, @fromdate, @todate) + 1)-(DATEDIFF(wk, @fromdate, @todate) * 2)-(CASE WHEN DATENAME(dw, @fromdate) = 'Sunday' THEN 1 ELSE 0 END)-(CASE WHEN DATENAME(dw, @todate) = 'Saturday' THEN 1 ELSE 0 END))
	   select @duration as numbre_of_days
	   end

	   exec ps_CountWeekDays '2020/4/8','2020/4/11'
-------------------------------------------------------------------------------------------------------------------------------------------------------
select * from jours_ferier
exec calculer_C_N_W '2020/4/1','2020/4/6'

select j.* from jours_ferier j inner join Conge c on c.Id_jour=j.Id_jour

insert into jours_ferier values(3,'Premier Moharram','2020/11/1','2020/11/1');

delete jours_ferier where Id_jour=123
select * from jours_ferier
update jours_ferier set
--///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
alter proc test(@date1 date,@date2 date) as
begin
     declare @jour_F int
	

	 declare @dateDiff int
	 declare @dateFIN int 
	 declare @t int
	 

	 select @dateFIN=SDU_Tools.DateDiffNoWeekends(@date1,@date2)
select * from Employe	 
	 
	 if(@date1 in(select date_jours_D from jours_ferier) or @date1 in (select date_jours_D from jours_ferier) )
	    select @dateFIN-1
	 else
	    select @dateFIN	
end
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
exec test '2020/5/24','2020/5/28'

 select SDU_Tools.DateDiffNoWeekends('2020/5/24','2020/5/28')

 select DATEADD(day,2,'2020/5/23')-1


 select * from Conge c  where c.date_D between '2020/4/2' and '2020/4/2' or c.date_F between '2020/4/2' and '2020/4/2'
 select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c where c.date_D between '2020/4/2' and '2020/4/2' or c.date_F between '2020/4/2' and '2020/4/2'

select * from Employe

select * from Service
delete conge where N_dote='""' and Nom_employe ='""' and date_D='""' and date_F='""'

select * from Conge

select top 1 * from Conge where id_type_c=2 and N_dote=123 and(GETDATE() between date_D and date_F) or (GETDATE()=date_F)   order by date_F 
select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c where c.id_type_c=2 group by N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement, Nom_remplacement, Prenom_remplacement having sum(c.Nb_jour) >=10 
select * from ServiceDevision
delete 

select * from Employe

alter proc test_J @dateD date,@dateF date  as 
begin
declare cur cursor for select date_jours_D,date_jours_F from jours_ferier 
declare @date_jours_D date,@date_jours_F date
  open cur 
     fetch  cur into @date_jours_D,@date_jours_F
   
   
      while(@@FETCH_STATUS=0)
         begin
            if(@dateD = @date_jours_D or @dateF =@date_jours_F)
	           select DATEDIFF(day,@dateD,@dateF)-1
		 end
		 close cur
		 deallocate cur
end
exec test_J '2/2/2020','10/2/2020'
alter table jour



alter procedure rt_date
	@date1 date,
	@date2 date
	as
	begin
  declare @nb_holiday int

  declare @nb_Total int
  set @nb_Total=(select DATEDIFF(day, @Date1, @Date2) - DATEDIFF(week, @Date1, @Date2))

  select @nb_holiday=@nb_holiday-@nb_Total
   if(exists(select * from jours_ferier
   where @date1  between date_jours_D  and date_jours_F or @date2 between date_jours_D and date_jours_F))
   begin 
    set @nb_holiday=(select DATEDIFF(day, @Date1, @Date2))
	
	select @nb_holiday =(@nb_holiday-
	(select sum(jours_ferier.duree) from jours_ferier
	where @date1  between date_jours_D  and date_jours_F or 
	@date2 between date_jours_D and date_jours_F))
	
   end
	end

	exec rt_date '2020/5/24','2020/5/30'

	select * from conge
	select c.N_dote,c.Nom_employe,c.prenom_employe,c.date_D,c.date_F,c.Nb_jour,c.Date_saisie,c.Anne,c.id_type_c,c.type_de_conge,c.N_dote_remplacement,c.Nom_remplacement,c.Prenom_remplacement from Conge c 

update conge set N_dote=128 ,Nom_employe='hachimi',prenom_employe='rachid'
,date_D='2020/8/4',date_F='2020/8/12',Nb_jour=3,id_type_c=1,type_de_conge='Anuel'
,N_dote_remplacement=123,Nom_remplacement='boufdil',Prenom_remplacement='abd assamad' 
where id_type_c=1 and N_dote=128 and date_D='2020/4/6' and date_F='2020/4/12'



exec modifier_N_J 5,123,26
select * from Conge where id_type_c=1

select * from Employe
--///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
alter proc test_duree @N_conge int as 
begin 
declare @duree int
    set @duree=(select nb_jour from Conge where N_conge =@N_conge)
	--select @duree
	end

	exec test_duree 20


	create proc duree_C(@date1 date,@date2 date) as 
	begin
	declare @duree int
	     select @duree= datediff(day,'2020/8/8','2020/8/11')

declare @startdate date,
@enddate date, @a integer
set @startdate='2016-04-01'
set @enddate='2016-04-28'
set @a=0
select @startdate
select @enddate
while @startdate<=@enddate
Begin
if Datename(dw,@startdate)in('Monday','Tuesday','Wednesday','Thursday','Friday')
begin
set @a=@a+1
end
set @startdate=DATEADD(d,1,@startdate)
end;
select @a

--//////////////////////////


update Employe set Duree_rest=22
update conge set Nb_jour=16 where N_dote=127
delete from Conge
select * from Conge
select * from Employe
select c.N_conge,c.Nb_jour,e.N_dote,e.Duree_rest from Conge c  inner join Employe e on e.N_dote=c.N_dote where N_conge=1

exec modifier_N_J 10,127,1018
	  sele


	  
	  delete from employe

select N_dote, Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge,
N_dote_remplacement, Nom_remplacement, Prenom_remplacement from Conge c where c.id_type_c=2 group by N_dote,
Nom_employe, prenom_employe, date_D, date_F, Nb_jour, Date_saisie,Anne, id_type_c, type_de_conge, N_dote_remplacement,
Nom_remplacement, Prenom_remplacement having sum(c.Nb_jour) >=10
select N_dote from conge c where c.id_type_c=2 and N_dote=127 group by N_dote having sum(Nb_jour)>=10 

select * from Conge where id_type_c=3
select top 1 * from Conge where id_type_c=3 and N_dote=123 order by N_conge desc
select top 1 * from Conge where id_type_c=1 and N_dote=123 and(getdate()<=date_D or (GETDATE() between date_D and date_F) or (GETDATE()=date_F)) order by date_F desc
select * from Conge where id_type_c=1 and N_dote=123 and(getdate()<=date_D or (GETDATE() between date_D and date_F) or (GETDATE()=date_F)) 

select * from Type_conge


create trigger change_date on conge instead of insert as
begin 
   declare cur cursor for select duree_date_precedent,duree_date_actuel from conge 
   declare @duree_date_precedent int,@duree_date_actuel int
   open cur 
        fetch cur into @duree_date_precedent,@duree_date_actuel
		while (@@FETCH_STATUS=0)
		begin
		      fetch next from cur into @duree_date_precedent,@duree_date_actuel
			  if(getdate()=('1/1'))
			  update Conge set duree_date_precedent=0+duree_date_precedent+duree_date_actuel,duree_date_actuel=22
			end  
	  close cur
 deallocate cur
 end
 

 delete Conge
 select * from Conge
 insert into Conge values(124,123,'boufdil','abdassamad','2020/4/4','2020/4/10',7,getdate(),'2020',0,20,1,'Anuel',128,'rachidi','khalid',1)
 insert into Conge values(128,128,'hamid','hamidi','2021/4/4','2021/4/10',7,getdate(),'2021',0,20,1,'Anuel',128,'rachidi','khalid',1)
 select * from Employe

 
 create proc ps_duree_conge(@fromdate date,@todate date) as
 begin 
      declare cur cursor for select date_jours_D,date_jours_F from jours_ferier 
	  declare @date_jours_D date
	  declare @date_jours_F date
	       open cur
		      fetch cur into @date_jours_D,@date_jours_F
			  while(@@FETCH_STATUS=0)
			       begin  
				   	   declare @d int     set @d=(select day(@date_jours_D))
				       declare @m int     set @m=(select day(@date_jours_D))
							print cast(@date_jours_D as varchar)+'  '+cast(@date_jours_F as varchar)
							fetch next from cur into @date_jours_D,@date_jours_F
				   end	
			close cur
deallocate cur
	select * from jours_ferier				
		   
     create proc verifier_suppression(@N_dote int) as 
	 begin 
	      select * from Conge where N_conge=1 and getdate() between date_D and date_F or GETDATE()=date_D or GETDATE()=date_F or GETDATE()>date_F
		  

		  select * from Employe
		  select N_dote,Nom_FR,Prenom_FR,Nom_AR,Prenom_AR,Grade_FR,Grade_AR,id_service,service_AR,duree_date_precedent,duree_date_actuel from EMPLOYE

		
		  select id_service,libelle_S_FR,libelle_S_AR,id_devision from Service s

		  select * from Employe
		  select * from Conge
		  select * from Conge where id_type_c=1
		  update Conge set Nb_jour=2 where id_type_c=1 and N_dote=123 and N_conge=0
		  update Employe set duree_date_actuel=18

		  	exec modifier_N_J 1,123,0 
