# FinalProjectWArvatoBootcamp
 
![](https://github.com/malikagan48/FinalProjectWArvatoBootcamp/blob/main/FinalProject/bin/Release/net6.0/Images/11.png)
Final Project with Arvato Bootcamp crew.
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
    Başlangıç projemizi **FinalProject.API** olarak belirledikten sonra package manager console’umuzda varsayılan olarak belirliyor 
    ve **update-database** komutunu giriyoruz. Bu noktadan sonra Api üzerinde [https://localhost:44381/swagger/index.html] portunda 
    inceleme yapabilirsiniz.MVC projesi bağlantısı için konsol üzerinden 'npm install' ve 'npm start' komutları girilmeli. 
 ```
 Son olarak belirlediğimiz kriteri sağlayan bir swagger delete komutu.
 ![](https://github.com/malikagan48/FinalProjectWArvatoBootcamp/blob/main/FinalProject/bin/Release/net6.0/Images/15.PNG)
      
