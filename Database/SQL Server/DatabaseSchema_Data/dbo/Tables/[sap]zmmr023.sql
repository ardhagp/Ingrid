﻿CREATE TABLE [dbo].[[sap]]zmmr023] (
    [z23_mtype]               VARCHAR (255)   NULL,
    [z23_plant]               VARCHAR (255)   NULL,
    [z23_sloc]                VARCHAR (255)   NULL,
    [z23_binloc]              VARCHAR (255)   NULL,
    [z23_material]            VARCHAR (255)   NULL,
    [z23_shorttext]           VARCHAR (MAX)   NULL,
    [z23_longtext]            VARCHAR (MAX)   NULL,
    [z23_partnumber]          VARCHAR (MAX)   NULL,
    [z23_manufcode]           VARCHAR (MAX)   NULL,
    [z23_manufname]           VARCHAR (MAX)   NULL,
    [z23_valtype]             VARCHAR (255)   NULL,
    [z23_plant_sp_mat_stat]   VARCHAR (MAX)   NULL,
    [z23_laboff]              VARCHAR (255)   NULL,
    [z23_matusage]            VARCHAR (MAX)   NULL,
    [z23_mrp]                 VARCHAR (255)   NULL,
    [z23_lot]                 INT             NULL,
    [z23_reorder]             INT             NULL,
    [z23_maxstock]            INT             NULL,
    [z23_safetystock]         INT             NULL,
    [z23_minlotsiz]           INT             NULL,
    [z23_maxlotsiz]           INT             NULL,
    [z23_fixedlotsiz]         INT             NULL,
    [z23_roundingval]         INT             NULL,
    [z23_totalstock]          INT             NULL,
    [z23_uom]                 VARCHAR (255)   NULL,
    [z23_movingprice]         DECIMAL (18, 2) NULL,
    [z23_currency]            VARCHAR (255)   NULL,
    [z23_totalvalue]          INT             NULL,
    [z23_unrestricted]        INT             NULL,
    [z23_inpection]           INT             NULL,
    [z23_stockintransfer]     INT             NULL,
    [z23_block]               INT             NULL,
    [z23_ptv]                 INT             NULL,
    [z23_criticalpart]        VARCHAR (MAX)   NULL,
    [z23_criticalcat]         VARCHAR (MAX)   NULL,
    [z23_basicmaterial]       VARCHAR (MAX)   NULL,
    [z23_materialgroup]       VARCHAR (MAX)   NULL,
    [z23_descmatgroup]        VARCHAR (MAX)   NULL,
    [z23_purchasinggroup]     VARCHAR (MAX)   NULL,
    [z23_valuationclass]      VARCHAR (MAX)   NULL,
    [z23_workcenter]          VARCHAR (MAX)   NULL,
    [z23_dfatclientlevel]     VARCHAR (255)   NULL,
    [z23_dfatplantlevel]      VARCHAR (255)   NULL,
    [z23_weightunit]          VARCHAR (255)   NULL,
    [z23_division]            VARCHAR (255)   NULL,
    [z23_planneddeliverytime] INT             NULL,
    [z23_valuationcategory]   VARCHAR (255)   NULL,
    [z23_standardprice]       DECIMAL (18, 2) NULL,
    [z23_industrystddsc]      VARCHAR (255)   NULL,
    [z23_createdon]           VARCHAR (255)   NULL,
    [z23_pidby]               VARCHAR (255)   NULL,
    [z23_pid]                 VARCHAR (255)   NULL,
    [z23_postingdate]         VARCHAR (255)   NULL
);
