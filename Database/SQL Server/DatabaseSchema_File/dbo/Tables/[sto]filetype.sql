CREATE TABLE [dbo].[[sto]]filetype] (
    [filetype_id]        CHAR (32)    COLLATE Latin1_General_CI_AI NOT NULL,
    [filetype_extension] VARCHAR (5)  COLLATE Latin1_General_CI_AI NULL,
    [filetype_name]      VARCHAR (50) COLLATE Latin1_General_CI_AI NULL,
    CONSTRAINT [PK_[sto]]filetype] PRIMARY KEY CLUSTERED ([filetype_id] ASC)
);

