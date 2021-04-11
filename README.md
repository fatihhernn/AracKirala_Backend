<p align="center"> Merhaba 👋🏾 Github sayfama hoşgeldin!  ☁️ </p>

<h1 align="center">Rent A Car Project : Araba Kiralama Projesi</h1> 

<p align="center">
  <img src="https://github.com/fatihhernn/ReCapProject/blob/master/Screenshot_27.png" width="600" alt=".netProject">
</p>

## ⭐ Introduction
- **Katmanlı mimari örnekleri esas alınarak Entities, DataAccess, Business, Core ve WebAPI katmanlarından oluşan araba kiralama projesidir. Bu projede SOLID,DRY,REPOSITORY DESING PATTERN, SOCKET PROGRAMLAMA, DEFENSIVE PROGRAMLAMA mimarileri dikkate alınarak hazırlanmaktadır. Json Web Token entegrasyonu; Transaction, Cache, Validation,Logger ve Performance aspect'lerinin implementasyonu gerçekleştirilmiştir.** 
- **Validation için FluentValidation desteği, IoC için ise Autofac, Cache işlemleri için Microsoft Memory Cache, desteği eklenmiştir.**
- **Loglamalar hem dosyaya hem de veritabanında tutulabilir.**
- **[Sql query](https://github.com/fatihhernn/ReCapProject/blob/master/rentacardb.sql) bu linkte Sql tablolarını Sql Server 2019'da oluşturabilirisiniz.**

## Installation
```bash
# Clone to repository
$ git clone https://github.com/fatihhernn/ReCapProject.git

# Go to the folder you cloned
$ cd re-cap-project-with-csharp

# Install dependencies
$ dotnet restore
```


## Layers
&nbsp;&nbsp;&nbsp;&nbsp;📂 ``Business Layers`` <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📋 [Concrete Classes](https://github.com/fatihhernn/ReCapProject/tree/master/Business/Concrete) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📋 [Abstract Interfaces](https://github.com/fatihhernn/ReCapProject/tree/master/Business/Abstract) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📋 [Autofac / SecuredOperation](https://github.com/fatihhernn/ReCapProject/tree/master/Business/Abstracthttps://github.com/fatihhernn/ReCapProject/blob/master/Business/BusinessAspects/Autofac/SecuredOperation.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📋 [Constants "Magic String 💫"](https://github.com/fatihhernn/ReCapProject/tree/master/Business/Abstracthttps://github.com/fatihhernn/ReCapProject/blob/master/Business/BusinessAspects/Autofac/SecuredOperation.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📋 [DependencyResolver / Autofac](https://github.com/fatihhernn/ReCapProject/blob/master/Business/DependencyResolver/Autofac/AutofacBusinessModule.cs) <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 📋 [ValidationRules / FluentValidation](https://github.com/fatihhernn/ReCapProject/tree/master/Business/ValidationRules/FluentValidation) <br>





