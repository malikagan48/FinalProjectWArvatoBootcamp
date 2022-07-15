# FinalProjectWArvatoBootcamp
 Final Project with Arvato Bootcamp crew.
![](https://github.com/malikagan48/FinalProjectWArvatoBootcamp/blob/main/FinalProject/bin/Release/net6.0/Images/11.png)

<hr>

Arvato Supply Chain Solutions ve Patika.dev iş birliği ile yapılan **Arvato .Net Bootcamp** 'inin bitirme projesini geliştirmeye çalıştım. Proje içerisinde belirtilen teknolojileri kullanmaya çalıştım. 

●Net 6
●Ef Core
●Web Api
●Postgresql
●Swagger
●JWT Token(Authentication)





**Çekilen verilerden örnek birkaç görsel**

![](https://github.com/malikagan48/FinalProjectWArvatoBootcamp/blob/main/FinalProject/bin/Release/net6.0/Images/12.PNG)

<hr>

![](https://github.com/malikagan48/FinalProjectWArvatoBootcamp/blob/main/FinalProject/bin/Release/net6.0/Images/13.PNG)

<hr>
**Projemizin ön yüzü bu şekilde gelmektedir.**
![](https://github.com/malikagan48/FinalProjectWArvatoBootcamp/blob/main/FinalProject/bin/Release/net6.0/Images/14.PNG)

 ## :computer: Projenin Kurulumu
  Proje’yi çalıştırmak için PostgreSql veritabanına ihtiyaç duyuyoruz,  bilgisayarımızda yüklü ve çalışıyor olması gerekmektedir.
 
  FinalProject.API katmanı üzerinden 'appsettings.json' dosyası içindeki connection stringle kendi database'inize bağlanabilirsiniz
  ```
  "ConnectionStrings": {
    "DefaultConnection": "User ID=(DatabaseUserBuraya(postgres));Password=(ŞifreBuraya);Host=(HostIp veya 'localhost');Port=(PortNumarası(5432));Database=MiniCommerceDb;Integrated Security=true;Pooling=true"
  },
    Başlangıç projemizi **FinalProject.API** olarak belirledikten sonra package manager console’umuzda varsayılan olarak belirliyor ve **update-database** komutunu giriyoruz. Bu noktadan sonra Api üzerinde [https://localhost:44381/swagger/index.html] portunda inceleme yapabilirsiniz.MVC projesi bağlantısı için konsol üzerinden 'npm install' ve 'npm start' komutları girilmeli. 
 ```
 Son olarak belirlediğimiz kriteri sağlayan bir swagger delete komutu.
 ![](https://github.com/malikagan48/FinalProjectWArvatoBootcamp/blob/main/FinalProject/bin/Release/net6.0/Images/15.PNG)
      
<h2> 🛠 &nbsp;Projemizde Kullanılan Teknolojiler</h2>

<table style"float:right;">
  <tr>
    <td><img src="https://img.shields.io/badge/-ASP.NETCore-5C2D91?style=flat&logo=.net&logoColor=white"/></td>
    <td><img src="https://img.shields.io/badge/-MVC-5C2D91?logo=.net"/></td>
    <td><img src="https://img.shields.io/badge/-EntityFramework-5C2D91?style=flat&logo=.net&logoColor=white"/></td>  
    <td><img src="https://img.shields.io/badge/PostgreSQL-316192?logo=postgresql&logoColor=white"/></td>
  </tr>
  <tr>
    <td><img src="https://img.shields.io/badge/-FluentValidation-CC2927?style=flat-square&logo=.net&logoColor=ffffff"/></td>
    <td><img src="https://img.shields.io/badge/-AutoMapper-5C2D91?style=flat&logo=.net&logoColor=white"/</td>  
    <td><img src="https://img.shields.io/badge/-IdentityCore-5C2D91?style=flat&logo=.net&logoColor=white"/></td>
    <td><img src="https://img.shields.io/badge/-Docker-61DAFB?logo=docker"/></td> 
  </tr>
  <tr>
    <td><img src="https://img.shields.io/badge/-Github-black?style=flat&logo=github"/></td>
    <td> <img src="https://img.shields.io/badge/-Git-black?style=flat&logo=git"/></td>   
    <td><img src="https://img.shields.io/badge/-JavaScript-black?style=flat&logo=javascript"/></td>
    <td><img src="https://img.shields.io/badge/-npm-CB3837?logo=npm"/></td>
  </tr>
  <tr>
    <td><img src="https://img.shields.io/badge/-Bootstrap-563D7C?style=flat&logo=bootstrap"/></td>
    <td><img src="https://img.shields.io/badge/-HTML5-E34F26?style=flat&logo=html5&logoColor=white"></td>
 		<td><img src="https://img.shields.io/badge/-CSS3-1572B6?style=flat&logo=css3"/></td>
    <td><img src="https://img.shields.io/badge/-json-02569B?style=flat&logo=json"/></td>
  </tr>

</table>

