
<h1>BlissApi Technical Test</h1>
<h3>Description</h3>
The intention of this project is to mimic the behaviour of a server api according to the following documentation https://blissrecruitmentapi.docs.apiary.io/#reference/0/share/share


<h3> Running the project</h3>

In order to run this project you need .NET 6 runtime or SDK.

After the installation, just run on the solution folder

    dotnet run

If you open it via Visual Studio, the swagger api documentation will be automatically loaded so you can test each endpoint at your will.

<h3>Recreating the database</h3>

This project was created using EntityFramework with an sqlite database. If you wish to recreate the database with your data you should:

1.Erase the "CityInfo.db" existing on root of the solution folder and the files contained on the "Migrations" folder

2.Modify the class "QuestionsInfoDbContext.cs" to your appeal regarding the OnModelCreating virtual method to create your data populating the Choices and Question tables

3.On Visual Studio apply the following commands on the Package Manager console
    
    add-migration {name_of_your_migration}

4.The migration should be created on the "Migrations" folder, the snapshot of the database should be contained on the same folder as well, in order to create the database just put the following commmand on Package-Manager console:

    update-database

After these steps the database should be created with the data you chose on the OnModelCreating method override.





