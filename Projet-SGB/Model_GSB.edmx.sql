
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/10/2022 08:43:52
-- Generated from EDMX file: D:\Users\tbouron\Desktop\Romeuf\PPE3_GSB_2022\Mission 1\Projet-SGB\Projet-SGB\Model_GSB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GSB_OK];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__fichefrai__idEta__20C1E124]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[fichefrais] DROP CONSTRAINT [FK__fichefrai__idEta__20C1E124];
GO
IF OBJECT_ID(N'[dbo].[FK__fichefrai__idVis__21B6055D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[fichefrais] DROP CONSTRAINT [FK__fichefrai__idVis__21B6055D];
GO
IF OBJECT_ID(N'[dbo].[FK__LigneFrai__idFra__286302EC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LigneFraisForfait] DROP CONSTRAINT [FK__LigneFrai__idFra__286302EC];
GO
IF OBJECT_ID(N'[dbo].[FK__LigneFraisForfai__276EDEB3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LigneFraisForfait] DROP CONSTRAINT [FK__LigneFraisForfai__276EDEB3];
GO
IF OBJECT_ID(N'[dbo].[FK__LigneFraisHorsFo__300424B4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LigneFraisHorsForfait] DROP CONSTRAINT [FK__LigneFraisHorsFo__300424B4];
GO
IF OBJECT_ID(N'[dbo].[FK_Laboratoire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Visiteur] DROP CONSTRAINT [FK_Laboratoire];
GO
IF OBJECT_ID(N'[dbo].[FK_SECTEUR]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Region] DROP CONSTRAINT [FK_SECTEUR];
GO
IF OBJECT_ID(N'[dbo].[FK_TRAVAILLER]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Travailler] DROP CONSTRAINT [FK_TRAVAILLER];
GO
IF OBJECT_ID(N'[dbo].[FK_VISITEUR]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Region] DROP CONSTRAINT [FK_VISITEUR];
GO
IF OBJECT_ID(N'[dbo].[FK_VISITEURSECTEUR]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Secteur] DROP CONSTRAINT [FK_VISITEURSECTEUR];
GO
IF OBJECT_ID(N'[dbo].[FK_VISITEURTRAVAIL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Travailler] DROP CONSTRAINT [FK_VISITEURTRAVAIL];
GO
IF OBJECT_ID(N'[dbo].[FK_medecin_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MEDECIN] DROP CONSTRAINT [FK_medecin_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_medicament_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MEDICAMENT] DROP CONSTRAINT [FK_medicament_fk];
GO
IF OBJECT_ID(N'[dbo].[FK_offrir_fk1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OFFRIR] DROP CONSTRAINT [FK_offrir_fk1];
GO
IF OBJECT_ID(N'[dbo].[FK_offrir_fk2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OFFRIR] DROP CONSTRAINT [FK_offrir_fk2];
GO
IF OBJECT_ID(N'[dbo].[FK_rapport_fk1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RAPPORT] DROP CONSTRAINT [FK_rapport_fk1];
GO
IF OBJECT_ID(N'[dbo].[FK_rapport_fk2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RAPPORT] DROP CONSTRAINT [FK_rapport_fk2];
GO
IF OBJECT_ID(N'[dbo].[FK_rapport_fk3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RAPPORT] DROP CONSTRAINT [FK_rapport_fk3];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Etat]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Etat];
GO
IF OBJECT_ID(N'[dbo].[FAMILLE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FAMILLE];
GO
IF OBJECT_ID(N'[dbo].[fichefrais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[fichefrais];
GO
IF OBJECT_ID(N'[dbo].[FraisForfait]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FraisForfait];
GO
IF OBJECT_ID(N'[dbo].[Laboratoire]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Laboratoire];
GO
IF OBJECT_ID(N'[dbo].[LigneFraisForfait]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LigneFraisForfait];
GO
IF OBJECT_ID(N'[dbo].[LigneFraisHorsForfait]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LigneFraisHorsForfait];
GO
IF OBJECT_ID(N'[dbo].[MEDECIN]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MEDECIN];
GO
IF OBJECT_ID(N'[dbo].[MEDICAMENT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MEDICAMENT];
GO
IF OBJECT_ID(N'[dbo].[MOTIF]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MOTIF];
GO
IF OBJECT_ID(N'[dbo].[OFFRIR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OFFRIR];
GO
IF OBJECT_ID(N'[dbo].[RAPPORT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RAPPORT];
GO
IF OBJECT_ID(N'[dbo].[Region]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Region];
GO
IF OBJECT_ID(N'[dbo].[Secteur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Secteur];
GO
IF OBJECT_ID(N'[dbo].[SPECIALITE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SPECIALITE];
GO
IF OBJECT_ID(N'[dbo].[Travailler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Travailler];
GO
IF OBJECT_ID(N'[dbo].[Visiteur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Visiteur];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Etat'
CREATE TABLE [dbo].[Etat] (
    [id] char(2)  NOT NULL,
    [libelle] varchar(30)  NULL
);
GO

-- Creating table 'FAMILLE'
CREATE TABLE [dbo].[FAMILLE] (
    [idFamille] char(3)  NOT NULL,
    [libFamille] varchar(80)  NOT NULL
);
GO

-- Creating table 'fichefrais'
CREATE TABLE [dbo].[fichefrais] (
    [idVisiteur] char(3)  NOT NULL,
    [mois] char(6)  NOT NULL,
    [nbJustificatifs] int  NULL,
    [montantValide] decimal(10,2)  NULL,
    [dateModif] datetime  NULL,
    [idEtat] char(2)  NULL
);
GO

-- Creating table 'FraisForfait'
CREATE TABLE [dbo].[FraisForfait] (
    [id] char(3)  NOT NULL,
    [libelle] char(20)  NULL,
    [montant] decimal(5,2)  NULL
);
GO

-- Creating table 'Laboratoire'
CREATE TABLE [dbo].[Laboratoire] (
    [idLabo] int IDENTITY(1,1) NOT NULL,
    [nomLabo] char(20)  NULL
);
GO

-- Creating table 'LigneFraisForfait'
CREATE TABLE [dbo].[LigneFraisForfait] (
    [idVisiteur] char(3)  NOT NULL,
    [mois] char(6)  NOT NULL,
    [idFraisForfait] char(3)  NOT NULL,
    [quantite] int  NULL
);
GO

-- Creating table 'LigneFraisHorsForfait'
CREATE TABLE [dbo].[LigneFraisHorsForfait] (
    [id] int IDENTITY(1,1) NOT NULL,
    [idVisiteur] char(3)  NOT NULL,
    [mois] char(6)  NOT NULL,
    [libelle] varchar(100)  NULL,
    [date] datetime  NULL,
    [montant] decimal(10,2)  NULL
);
GO

-- Creating table 'MEDECIN'
CREATE TABLE [dbo].[MEDECIN] (
    [idMedecin] int IDENTITY(1,1) NOT NULL,
    [nom] varchar(30)  NOT NULL,
    [prenom] varchar(30)  NOT NULL,
    [adresse] varchar(80)  NOT NULL,
    [tel] varchar(15)  NULL,
    [idSpecialite] char(3)  NULL,
    [departement] int  NOT NULL
);
GO

-- Creating table 'MEDICAMENT'
CREATE TABLE [dbo].[MEDICAMENT] (
    [idMedicament] char(12)  NOT NULL,
    [nomCommercial] varchar(64)  NOT NULL,
    [idFamille] char(3)  NOT NULL,
    [composition] varchar(256)  NOT NULL,
    [effets] varchar(256)  NOT NULL,
    [contreIndications] varchar(256)  NOT NULL
);
GO

-- Creating table 'MOTIF'
CREATE TABLE [dbo].[MOTIF] (
    [idMotif] int IDENTITY(1,1) NOT NULL,
    [libMotif] varchar(64)  NULL
);
GO

-- Creating table 'OFFRIR'
CREATE TABLE [dbo].[OFFRIR] (
    [idRapport] int  NOT NULL,
    [idMedicament] char(12)  NOT NULL,
    [quantite] int  NULL
);
GO

-- Creating table 'RAPPORT'
CREATE TABLE [dbo].[RAPPORT] (
    [idRapport] int IDENTITY(1,1) NOT NULL,
    [dateRapport] datetime  NULL,
    [idMotif] int  NULL,
    [bilan] varchar(64)  NULL,
    [idVisiteur] char(3)  NOT NULL,
    [idMedecin] int  NOT NULL
);
GO

-- Creating table 'Region'
CREATE TABLE [dbo].[Region] (
    [idRegion] int  NOT NULL,
    [libRegion] varchar(64)  NULL,
    [idVisiteur] char(3)  NOT NULL,
    [idSecteur] int  NOT NULL
);
GO

-- Creating table 'Secteur'
CREATE TABLE [dbo].[Secteur] (
    [idSecteur] int  NOT NULL,
    [libSecteur] varchar(64)  NULL,
    [idVisiteur] char(3)  NOT NULL
);
GO

-- Creating table 'SPECIALITE'
CREATE TABLE [dbo].[SPECIALITE] (
    [idSpecialite] char(3)  NOT NULL,
    [libSpecialite] varchar(64)  NOT NULL
);
GO

-- Creating table 'Visiteur'
CREATE TABLE [dbo].[Visiteur] (
    [idVisiteur] char(3)  NOT NULL,
    [idLabo] int  NOT NULL,
    [nom] varchar(32)  NULL,
    [prenom] varchar(32)  NULL,
    [rue] varchar(64)  NULL,
    [cp] char(5)  NULL,
    [ville] varchar(64)  NULL,
    [dateEmbauche] char(10)  NULL,
    [identifiant] varchar(16)  NOT NULL,
    [password] varchar(128)  NOT NULL
);
GO

-- Creating table 'TestSet'
CREATE TABLE [dbo].[TestSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [libTest] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Travailler'
CREATE TABLE [dbo].[Travailler] (
    [Region1_idRegion] int  NOT NULL,
    [Visiteur1_idVisiteur] char(3)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Etat'
ALTER TABLE [dbo].[Etat]
ADD CONSTRAINT [PK_Etat]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [idFamille] in table 'FAMILLE'
ALTER TABLE [dbo].[FAMILLE]
ADD CONSTRAINT [PK_FAMILLE]
    PRIMARY KEY CLUSTERED ([idFamille] ASC);
GO

-- Creating primary key on [idVisiteur], [mois] in table 'fichefrais'
ALTER TABLE [dbo].[fichefrais]
ADD CONSTRAINT [PK_fichefrais]
    PRIMARY KEY CLUSTERED ([idVisiteur], [mois] ASC);
GO

-- Creating primary key on [id] in table 'FraisForfait'
ALTER TABLE [dbo].[FraisForfait]
ADD CONSTRAINT [PK_FraisForfait]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [idLabo] in table 'Laboratoire'
ALTER TABLE [dbo].[Laboratoire]
ADD CONSTRAINT [PK_Laboratoire]
    PRIMARY KEY CLUSTERED ([idLabo] ASC);
GO

-- Creating primary key on [idVisiteur], [mois], [idFraisForfait] in table 'LigneFraisForfait'
ALTER TABLE [dbo].[LigneFraisForfait]
ADD CONSTRAINT [PK_LigneFraisForfait]
    PRIMARY KEY CLUSTERED ([idVisiteur], [mois], [idFraisForfait] ASC);
GO

-- Creating primary key on [id] in table 'LigneFraisHorsForfait'
ALTER TABLE [dbo].[LigneFraisHorsForfait]
ADD CONSTRAINT [PK_LigneFraisHorsForfait]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [idMedecin] in table 'MEDECIN'
ALTER TABLE [dbo].[MEDECIN]
ADD CONSTRAINT [PK_MEDECIN]
    PRIMARY KEY CLUSTERED ([idMedecin] ASC);
GO

-- Creating primary key on [idMedicament] in table 'MEDICAMENT'
ALTER TABLE [dbo].[MEDICAMENT]
ADD CONSTRAINT [PK_MEDICAMENT]
    PRIMARY KEY CLUSTERED ([idMedicament] ASC);
GO

-- Creating primary key on [idMotif] in table 'MOTIF'
ALTER TABLE [dbo].[MOTIF]
ADD CONSTRAINT [PK_MOTIF]
    PRIMARY KEY CLUSTERED ([idMotif] ASC);
GO

-- Creating primary key on [idRapport], [idMedicament] in table 'OFFRIR'
ALTER TABLE [dbo].[OFFRIR]
ADD CONSTRAINT [PK_OFFRIR]
    PRIMARY KEY CLUSTERED ([idRapport], [idMedicament] ASC);
GO

-- Creating primary key on [idRapport] in table 'RAPPORT'
ALTER TABLE [dbo].[RAPPORT]
ADD CONSTRAINT [PK_RAPPORT]
    PRIMARY KEY CLUSTERED ([idRapport] ASC);
GO

-- Creating primary key on [idRegion] in table 'Region'
ALTER TABLE [dbo].[Region]
ADD CONSTRAINT [PK_Region]
    PRIMARY KEY CLUSTERED ([idRegion] ASC);
GO

-- Creating primary key on [idSecteur] in table 'Secteur'
ALTER TABLE [dbo].[Secteur]
ADD CONSTRAINT [PK_Secteur]
    PRIMARY KEY CLUSTERED ([idSecteur] ASC);
GO

-- Creating primary key on [idSpecialite] in table 'SPECIALITE'
ALTER TABLE [dbo].[SPECIALITE]
ADD CONSTRAINT [PK_SPECIALITE]
    PRIMARY KEY CLUSTERED ([idSpecialite] ASC);
GO

-- Creating primary key on [idVisiteur] in table 'Visiteur'
ALTER TABLE [dbo].[Visiteur]
ADD CONSTRAINT [PK_Visiteur]
    PRIMARY KEY CLUSTERED ([idVisiteur] ASC);
GO

-- Creating primary key on [Id] in table 'TestSet'
ALTER TABLE [dbo].[TestSet]
ADD CONSTRAINT [PK_TestSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Region1_idRegion], [Visiteur1_idVisiteur] in table 'Travailler'
ALTER TABLE [dbo].[Travailler]
ADD CONSTRAINT [PK_Travailler]
    PRIMARY KEY CLUSTERED ([Region1_idRegion], [Visiteur1_idVisiteur] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [idEtat] in table 'fichefrais'
ALTER TABLE [dbo].[fichefrais]
ADD CONSTRAINT [FK__fichefrai__idEta__20C1E124]
    FOREIGN KEY ([idEtat])
    REFERENCES [dbo].[Etat]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__fichefrai__idEta__20C1E124'
CREATE INDEX [IX_FK__fichefrai__idEta__20C1E124]
ON [dbo].[fichefrais]
    ([idEtat]);
GO

-- Creating foreign key on [idFamille] in table 'MEDICAMENT'
ALTER TABLE [dbo].[MEDICAMENT]
ADD CONSTRAINT [FK_medicament_fk]
    FOREIGN KEY ([idFamille])
    REFERENCES [dbo].[FAMILLE]
        ([idFamille])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_medicament_fk'
CREATE INDEX [IX_FK_medicament_fk]
ON [dbo].[MEDICAMENT]
    ([idFamille]);
GO

-- Creating foreign key on [idVisiteur] in table 'fichefrais'
ALTER TABLE [dbo].[fichefrais]
ADD CONSTRAINT [FK__fichefrai__idVis__21B6055D]
    FOREIGN KEY ([idVisiteur])
    REFERENCES [dbo].[Visiteur]
        ([idVisiteur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idVisiteur], [mois] in table 'LigneFraisForfait'
ALTER TABLE [dbo].[LigneFraisForfait]
ADD CONSTRAINT [FK__LigneFraisForfai__276EDEB3]
    FOREIGN KEY ([idVisiteur], [mois])
    REFERENCES [dbo].[fichefrais]
        ([idVisiteur], [mois])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idVisiteur], [mois] in table 'LigneFraisHorsForfait'
ALTER TABLE [dbo].[LigneFraisHorsForfait]
ADD CONSTRAINT [FK__LigneFraisHorsFo__300424B4]
    FOREIGN KEY ([idVisiteur], [mois])
    REFERENCES [dbo].[fichefrais]
        ([idVisiteur], [mois])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__LigneFraisHorsFo__300424B4'
CREATE INDEX [IX_FK__LigneFraisHorsFo__300424B4]
ON [dbo].[LigneFraisHorsForfait]
    ([idVisiteur], [mois]);
GO

-- Creating foreign key on [idFraisForfait] in table 'LigneFraisForfait'
ALTER TABLE [dbo].[LigneFraisForfait]
ADD CONSTRAINT [FK__LigneFrai__idFra__286302EC]
    FOREIGN KEY ([idFraisForfait])
    REFERENCES [dbo].[FraisForfait]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__LigneFrai__idFra__286302EC'
CREATE INDEX [IX_FK__LigneFrai__idFra__286302EC]
ON [dbo].[LigneFraisForfait]
    ([idFraisForfait]);
GO

-- Creating foreign key on [idLabo] in table 'Visiteur'
ALTER TABLE [dbo].[Visiteur]
ADD CONSTRAINT [FK_Laboratoire]
    FOREIGN KEY ([idLabo])
    REFERENCES [dbo].[Laboratoire]
        ([idLabo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Laboratoire'
CREATE INDEX [IX_FK_Laboratoire]
ON [dbo].[Visiteur]
    ([idLabo]);
GO

-- Creating foreign key on [idSpecialite] in table 'MEDECIN'
ALTER TABLE [dbo].[MEDECIN]
ADD CONSTRAINT [FK_medecin_fk]
    FOREIGN KEY ([idSpecialite])
    REFERENCES [dbo].[SPECIALITE]
        ([idSpecialite])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_medecin_fk'
CREATE INDEX [IX_FK_medecin_fk]
ON [dbo].[MEDECIN]
    ([idSpecialite]);
GO

-- Creating foreign key on [idMedecin] in table 'RAPPORT'
ALTER TABLE [dbo].[RAPPORT]
ADD CONSTRAINT [FK_rapport_fk2]
    FOREIGN KEY ([idMedecin])
    REFERENCES [dbo].[MEDECIN]
        ([idMedecin])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_rapport_fk2'
CREATE INDEX [IX_FK_rapport_fk2]
ON [dbo].[RAPPORT]
    ([idMedecin]);
GO

-- Creating foreign key on [idMedicament] in table 'OFFRIR'
ALTER TABLE [dbo].[OFFRIR]
ADD CONSTRAINT [FK_offrir_fk2]
    FOREIGN KEY ([idMedicament])
    REFERENCES [dbo].[MEDICAMENT]
        ([idMedicament])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_offrir_fk2'
CREATE INDEX [IX_FK_offrir_fk2]
ON [dbo].[OFFRIR]
    ([idMedicament]);
GO

-- Creating foreign key on [idMotif] in table 'RAPPORT'
ALTER TABLE [dbo].[RAPPORT]
ADD CONSTRAINT [FK_rapport_fk3]
    FOREIGN KEY ([idMotif])
    REFERENCES [dbo].[MOTIF]
        ([idMotif])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_rapport_fk3'
CREATE INDEX [IX_FK_rapport_fk3]
ON [dbo].[RAPPORT]
    ([idMotif]);
GO

-- Creating foreign key on [idRapport] in table 'OFFRIR'
ALTER TABLE [dbo].[OFFRIR]
ADD CONSTRAINT [FK_offrir_fk1]
    FOREIGN KEY ([idRapport])
    REFERENCES [dbo].[RAPPORT]
        ([idRapport])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idVisiteur] in table 'RAPPORT'
ALTER TABLE [dbo].[RAPPORT]
ADD CONSTRAINT [FK_rapport_fk1]
    FOREIGN KEY ([idVisiteur])
    REFERENCES [dbo].[Visiteur]
        ([idVisiteur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_rapport_fk1'
CREATE INDEX [IX_FK_rapport_fk1]
ON [dbo].[RAPPORT]
    ([idVisiteur]);
GO

-- Creating foreign key on [idSecteur] in table 'Region'
ALTER TABLE [dbo].[Region]
ADD CONSTRAINT [FK_SECTEUR]
    FOREIGN KEY ([idSecteur])
    REFERENCES [dbo].[Secteur]
        ([idSecteur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SECTEUR'
CREATE INDEX [IX_FK_SECTEUR]
ON [dbo].[Region]
    ([idSecteur]);
GO

-- Creating foreign key on [idVisiteur] in table 'Region'
ALTER TABLE [dbo].[Region]
ADD CONSTRAINT [FK_VISITEUR]
    FOREIGN KEY ([idVisiteur])
    REFERENCES [dbo].[Visiteur]
        ([idVisiteur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VISITEUR'
CREATE INDEX [IX_FK_VISITEUR]
ON [dbo].[Region]
    ([idVisiteur]);
GO

-- Creating foreign key on [idVisiteur] in table 'Secteur'
ALTER TABLE [dbo].[Secteur]
ADD CONSTRAINT [FK_VISITEURSECTEUR]
    FOREIGN KEY ([idVisiteur])
    REFERENCES [dbo].[Visiteur]
        ([idVisiteur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VISITEURSECTEUR'
CREATE INDEX [IX_FK_VISITEURSECTEUR]
ON [dbo].[Secteur]
    ([idVisiteur]);
GO

-- Creating foreign key on [Region1_idRegion] in table 'Travailler'
ALTER TABLE [dbo].[Travailler]
ADD CONSTRAINT [FK_Travailler_Region]
    FOREIGN KEY ([Region1_idRegion])
    REFERENCES [dbo].[Region]
        ([idRegion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Visiteur1_idVisiteur] in table 'Travailler'
ALTER TABLE [dbo].[Travailler]
ADD CONSTRAINT [FK_Travailler_Visiteur]
    FOREIGN KEY ([Visiteur1_idVisiteur])
    REFERENCES [dbo].[Visiteur]
        ([idVisiteur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Travailler_Visiteur'
CREATE INDEX [IX_FK_Travailler_Visiteur]
ON [dbo].[Travailler]
    ([Visiteur1_idVisiteur]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------