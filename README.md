<p align="center"> Merhaba 👋🏾 Github sayfama hoşgeldin!  ☁️ </p>

<h1 align="center">Rent A Car Project : Araba Kiralama Projesi</h1> 



## ⭐ Introduction
- **Katmanlı mimari örnekleri esas alınarak Entities, DataAccess, Business, Core ve WebAPI katmanlarından oluşan araba kiralama projesidir. Bu projede SOLID,DRY,REPOSITORY DESING PATTERN, SOCKET PROGRAMLAMA, DEFENSIVE PROGRAMLAMA mimarileri dikkate alınarak hazırlanmaktadır. Json Web Token entegrasyonu; Transaction, Cache, Validation,Logger ve Performance aspect'lerinin implementasyonu gerçekleştirilmiştir.** 
- **Validation için FluentValidation desteği, IoC için ise Autofac, Cache işlemleri için Microsoft Memory Cache, desteği eklenmiştir.**
- **Loglamalar hem dosyaya hem de veritabanında tutulabilir.**
- **[Sql query](https://github.com/fatihhernn/ReCapProject/blob/master/rentacardb.sql) bu linkte Sql tablolarını Sql Server 2019'da oluşturabilirisiniz.**

## ⭐ Installation
```bash
# Clone to repository
$ git clone https://github.com/fatihhernn/ReCapProject.git

# Go to the folder you cloned
$ cd re-cap-project-with-csharp

# Install dependencies
$ dotnet restore
```

## ⭐ Projemizi localimize kaydettikten sonra oluşan klasörlerimiz 
<table>
  <tr>
     <td>Business</td>
     <td>Core</td>
    <td>DataAccess</td>
    <td>Entities</td>
    <td>API</td>
  </tr>
  
  <tr>
    <td>
           <img src="https://github.com/fatihhernn/ReCapProject/blob/master/business.png" width="600" alt=".netProject">
   </td>
   <td>
           <img src="https://github.com/fatihhernn/ReCapProject/blob/master/core.png" width="600" alt=".netProject">
   </td>
   <td>
           <img src="https://github.com/fatihhernn/ReCapProject/blob/master/dataaccess.png" width="600" alt=".netProject">
   </td>
   <td>
           <img src="https://github.com/fatihhernn/ReCapProject/blob/master/entities.png" width="600" alt=".netProject">
   </td>
   <td>
           <img src="https://github.com/fatihhernn/ReCapProject/blob/master/api.png" width="600" alt=".netProject">
   </td>
 </table>



## ⭐ Layers
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Business Layers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 [``Concrete Classes``](https://github.com/fatihhernn/ReCapProject/tree/master/Business/Concrete) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 [``Abstract Interfaces``](https://github.com/fatihhernn/ReCapProject/tree/master/Business/Abstract) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 [``Autofac / SecuredOperation``](https://github.com/fatihhernn/ReCapProject/tree/master/Business/Abstracthttps://github.com/fatihhernn/ReCapProject/blob/master/Business/BusinessAspects/Autofac/SecuredOperation.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 [``Constants "Magic String 💫"``](https://github.com/fatihhernn/ReCapProject/tree/master/Business/Abstracthttps://github.com/fatihhernn/ReCapProject/blob/master/Business/BusinessAspects/Autofac/SecuredOperation.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 [``DependencyResolver / Autofac``](https://github.com/fatihhernn/ReCapProject/blob/master/Business/DependencyResolver/Autofac/AutofacBusinessModule.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📂 [``ValidationRules / FluentValidation``](https://github.com/fatihhernn/ReCapProject/tree/master/Business/ValidationRules/FluentValidation) <br>


&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Core Layers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``Aspects``](https://github.com/fatihhernn/ReCapProject/tree/master/Core/Aspects) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``CrossCuttingConcerns``](https://github.com/fatihhernn/ReCapProject/tree/master/Core/CrossCuttingConcerns)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``DataAccess``](https://github.com/fatihhernn/ReCapProject/tree/master/Core/DataAccess)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``DependencyResolver``](https://github.com/fatihhernn/ReCapProject/tree/master/Core/DependencyResolver)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``Entities``](https://github.com/fatihhernn/ReCapProject/tree/master/Core/Entities)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``Extensions``](https://github.com/fatihhernn/ReCapProject/tree/master/Core/Extensions)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``Utilities``](https://github.com/fatihhernn/ReCapProject/tree/master/Core/Utilities)<br>


&nbsp;&nbsp;&nbsp;&nbsp;📂 ``DataAccess Layers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``Abstract``](https://github.com/fatihhernn/ReCapProject/tree/master/DataAccess/Abstract) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``Concrete``](https://github.com/fatihhernn/ReCapProject/tree/master/DataAccess/Concrete)<br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Entity Layers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``Abstract``](https://github.com/fatihhernn/ReCapProject/tree/master/Entities/Abstract) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``Concrete``](https://github.com/fatihhernn/ReCapProject/tree/master/Entities/Concrete)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``DTOs``](https://github.com/fatihhernn/ReCapProject/tree/master/Entities/DTOs)<br>

&nbsp;&nbsp;&nbsp;&nbsp;📂 ``API Layers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;📂 [``Controllers``](https://github.com/fatihhernn/ReCapProject/tree/master/WebUI/Controllers) <br>


## Database için gerekli olan tablolarımız
<table>
  <tr>
     <td>Brands</td>
     <td>CarImages</td>
     <td>Cars</td>
     <td>Colors</td>
     <td>Customers</td>
     <td>OperationClaims</td>
     <td>Rentals</td>
     <td>UserOperationClaims</td>
     <td>Users</td>
     <td>Payment</td>
  </tr>
  <tr>
    <td>
      
Variable Name | Data Type
------------ | -------------
Id | INT
BrandName | NVARCHAR(25)

   
   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
CarId | INT
CarImagesDate | DATETIME
ImagePath | NVARCHAR(MAX)
   
   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
BrandId | INT
ColorId | INT
ModelYear | NVARCHAR(25)
DailyPrice | DECIMAL
Description | NVARCHAR(25)

   
   </td>
    <td>

Variable Name | Data Type
------------ | -------------
Id | INT
ColorName | NVARCHAR(25)

   </td>
    <td>


Variable Name | Data Type
------------ | -------------
Id | INT
UserId | INT
CustomerName | NVARCHAR(25)
FindexScore | INT

   </td>
    <td>


Variable Name | Data Type
------------ | -------------
Id | INT
Name  | VARCHAR(250)

   </td>
   <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
CarId | INT
CustomerId | INT
RentDate | DATETIME
ReturnDate | DATETIME
PaymentId | INT

   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
UserId | INT
OperationId | INT

   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
Id | INT
FirstName | VARCHAR(50)
LastName | VARCHAR(50)
Email | VARCHAR(50)
PasswordHash | VARBINARY (500)
PasswordSalt | VARBINARY (500)
Status | BIT

   </td>
    <td>
  
Variable Name | Data Type
------------ | -------------
PaymentId | INT
CardNameSurname | VARCHAR(100)
CardNumber | NVARCHAR(100)
CardExpiryDate | NVARCHAR(50)
CardCvv | NVARCHAR (3)
AmountPaye | DECIMAL(18, 2) 

   </td>
  </tr>
 </table>




## ⭐ [Bu backend projesinin, frontend tasarımı Angular ile inşaa edildi. İndirmek ve incelemek için tıkla](https://github.com/fatihhernn/RecapProjectFrontend) 
<p align="center">
  <img src="https://github.com/fatihhernn/ReCapProject/blob/master/Screenshot_27.png" width="600" alt=".netProject">
</p>

