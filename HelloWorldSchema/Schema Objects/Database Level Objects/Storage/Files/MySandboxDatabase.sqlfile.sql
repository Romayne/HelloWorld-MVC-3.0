ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [MySandboxDatabase], FILENAME = 'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\MySandboxDatabase.mdf', SIZE = 2048 KB, FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];

