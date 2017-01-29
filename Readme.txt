The solutions consists of 3 porjects.

HelloWorld1 is a console app to simply write the string "Hello World" to console.

HelloWorld2 contains an api class, IApiService, which contains the methods for writing "Hello World" and could potentially be implemented by a web or mobile application.
ConsoleApiService is the concrete implementation of this api service and will contain the concrete implementation for specifically writing to Console.

HelloWorld3 contains an additional service, IWriteService. This interface contains a method for write, and implementing classes must define "how" to write a message.
There are 3 concrete classes to implement the "Write" functionality: Console, Database, and MessageBox.
In Program.cs, the WriteService must be passed to the ApiService's "WriteHelloWorld" method to tell it "how" to write. 
The method of writing (console, database, messageBox) is stored as a value "OutputType" in App.config. 

Additonally, app.config has a connectionString for database writing. The database must have a table called "Messages" with a column called "Message"
