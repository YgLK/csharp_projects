<h1 align="center">  RPG Models Management System 

[![.NET](https://img.shields.io/badge/--512BD4?logo=.net&logoColor=ffffff)](https://dotnet.microsoft.com/) [![Visual Studio](https://img.shields.io/badge/--6C33AF?logo=visual%20studio)](https://visualstudio.microsoft.com/)

## Table of contents

> ### 1. [Description](#description)
> ### 2. [Setup](#initial-setup)
> ### 3. [Database structure](#database-struct)
> ### 4. [Technologies used](#technologies-used)
> ### 5. [App overview](#overview)


## Description  <a name="description"></a>
**RPG Models Management System** is a great choice for all RPG game fans. 

This application can store RPG game models. Users can share their models in the common database.
The models stored in application have **tree structure** (User -> Categories -> Models).
Each user can create Categories. To created Category user can add models. 
Users can add models only to theirs categories.
Each Category can have predefined properties which models must fulfill in order to belong to it.

Application contains custom user management system with roles. <br>
Only Admin, Moderators or Category owners can delete models - your models are safe.

Database is created with the `Code first` approach and `Entity Framework`.
## Setup  <a name="initial-setup"></a>

1. Install .NET and MySQL (if not installed already).
2. Create db by following those steps:
    1. Open Package Manager Console ([help](/Others/how_to_open_PM.png)).
    2. Create migration (`PM> add-migration createDatabase`).
    3. Update database (`PM> update-database`).
    4. Add admin to the Users table (he cannot be created from the app level).
3. Run the app from the Visual Studio or build the project and run the created executable file.

## Database structure <a name="database-struct"></a>
The database was managed with Microsoft SQL Server Management Studio.

<p align="center">
  <img src="./Overview/db_structure.png" />
</p>


## Technologies used <a name="technologies-used"></a>

| Technologies                                          |
|:------------------------------------------------------|
| [.NET Framework 4.7.2](https://dotnet.microsoft.com/) |
| [MySQL](https://www.mysql.com/)                       |

## App overview  <a name="overview"></a>
<p align="center">
  <img src="./Overview/menu.png" />
</p>
<figcaption align = "center"><b>Welcome screen</b></figcaption>
<br>
<br>
<br>
<p align="center">
  <img src="./Overview/catalog.png" />
</p>
<figcaption align = "center"><b>Model catalog</b></figcaption>
<br>
<br>
<br>
<p align="center">
  <img src="./Overview/add_category.png" />
</p>
<figcaption align = "center"><b>Add category form</b></figcaption>
<br>
<br>
<br>
<p align="center">
  <img src="./Overview/add_new_model.png" />
</p>
<figcaption align = "center"><b>Add model form  (yellow properties are inherited from the catalog)</b></figcaption>
<br>
<br>
<br>
<p align="center">
  <img src="./Overview/properties.png" />
</p>
<figcaption align = "center"><b>Model properties table</b></figcaption>
<br>
<br>
<br>
<p align="center">
  <img src="./Overview/edit_model_properties.png" />
</p>
<figcaption align = "center"><b>Edit model properties (yellow properties are inherited from the catalog and can't be deleted)</b></figcaption>
<br>
<br>
<br>
<p align="center">
  <img src="./Overview/user_panel.png" />
</p>
<figcaption align = "center"><b>User management panel</b></figcaption>

