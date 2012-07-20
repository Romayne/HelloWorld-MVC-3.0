ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [MySandboxDatabase_log], FILENAME = 'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\MySandboxDatabase_log.ldf', SIZE = 1024 KB, MAXSIZE = 2097152 MB, FILEGROWTH = 10 %);

