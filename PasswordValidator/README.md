<h1 align="center">  Password Validator

[![.NET](https://img.shields.io/badge/--512BD4?logo=.net&logoColor=ffffff)](https://dotnet.microsoft.com/) [![Visual Studio](https://img.shields.io/badge/--6C33AF?logo=visual%20studio)](https://visualstudio.microsoft.com/)

## Table of contents

> ### 1. [Description](#description)
> ### 2. [Setup](#initial-setup)
> ### 3. [Technologies used](#technologies-used)
> ### 4. [App overview](#overview)


## Description  <a name="description"></a>
Password Validator is responsible for determining whether a proposed password is acceptable for use and could include checks.

By default, password must contain at least
   *  7 characters
   *  1 capital letter
   *  1 special character
   *  3 digits

Conditions are easily configurable and can be turned off.

## Setup  <a name="initial-setup"></a>

1. Install .NET (if not installed already).
2. Run the app from the Visual Studio or build the project and run the created executable file.
   * Control is stored in the `PasswordValidatorControl`
   * Test application is stored in the `TestPasswordValidator`


## Technologies used <a name="technologies-used"></a>

| Technologies                                          |
|:------------------------------------------------------|
| [.NET Framework 4.7.2](https://dotnet.microsoft.com/) |

## App overview  <a name="overview"></a>
<p align="center">
  <img src="./Overview/password_rejected.png" />
</p>
<figcaption align = "center"><b>No conditions met</b></figcaption>
<br>
<br>
<br><p align="center">
  <img src="./Overview/conditions_met.png" />
</p>
<figcaption align = "center"><b>Only part of the conditions met</b></figcaption>
<br>
<br>
<br><p align="center">
  <img src="./Overview/password_accepted.png" />
</p>
<figcaption align = "center"><b>All conditions met, password accepted</b></figcaption>
