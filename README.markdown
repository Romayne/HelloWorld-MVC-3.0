HelloWorld MVC 3.0
====================

This .NET MVC3 sample demonstrates a .NET application stack using a Service Layer architecture that ties into a Repository pattern which uses LINQ to SQL. The project uses the default design from the new MVC 4.0 template.

How To Use
====================

The database schema can be found in the HelloWorldSchema\Schema Objects\Schemas\dbo\Tables\Comments.table.sql file. 
Create this table and then edit the connection string found in HelloWorldDatabaseAssess\DatabaseWrapper.cs DefaultConnection constant.
Additionally you may have to download Moq and add it as a reference in the HelloWorldTests projects.

Known Issues
====================

This project does not pass exceptions up the call stack, nor does it place any try catch blocks around mappers or controllers. There are also no integration tests since this project demonstrates unit testing on the repository and mapper layer only.

Copyright and Ownership
====================
The MVC 4.0 template and images used are copyright to their original authors. 
jQuery, jQuery Notify, jQuery UI, Modernizr, and Moq are copyright to their original authors.

Live Demo and Contact
====================

Contact directly at [info@calgarywebdev.com](info@calgarywebdev.com).