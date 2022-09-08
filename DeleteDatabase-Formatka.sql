USE master;
GO
IF DB_ID (N'Formatka') IS NOT NULL
DROP DATABASE Formatka; -- usunięcie bazy danych jeśli nie jest pusta
