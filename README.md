# Car Rental

## Proje Hakkında
Bu proje CQRS ve Mediator design paternleri barındıran bir çalışmadır.

## CQRS ve Mediatör Tasarım Desenleri
### CQRS (Command Query Responsibility Segregation)
CQRS, Komut ve Sorgu Sorumluluğu Ayrımı anlamına gelir. Bu desen, veri değiştiren işlemler (komutlar) ile veri sorgulayan işlemlerin (sorgular) ayrı modellerle temsil edilmesini sağlar. Böylece, her iki işlem türü için farklı gereksinimlere ve performans optimizasyonlarına uygun çözümler geliştirilebilir.

Komutlar: Sistemde veri değiştiren işlemler (create, update, delete) komutlar aracılığıyla gerçekleştirilir. Komutlar genellikle yan etkiler yaratır ve bir sonucu döndürmezler.
Sorgular: Verileri okumak ve sorgulamak için kullanılır. Sorguların yan etkisi yoktur ve genellikle veri dönerler.
CQRS, uygulamaların ölçeklenebilirliğini ve bakımını iyileştirir, çünkü komut ve sorgu işlemlerini ayrı ayrı optimize etmek mümkündür.

### Mediatör
Mediatör tasarım deseni, bileşenlerin doğrudan birbirleriyle iletişim kurmak yerine bir aracı (mediatör) üzerinden iletişim kurmasını sağlar. Bu, bileşenler arasındaki bağımlılıkları azaltır ve kodun daha düzenli ve yönetilebilir olmasını sağlar.

Merkezi Kontrol: Tüm istekler ve işlemler merkezi bir mediatör aracılığıyla yönetilir. Bu, kodun anlaşılabilirliğini ve genişletilebilirliğini artırır.
Gevşek Bağlantı: Bileşenler mediatör aracılığıyla iletişim kurduğundan, bileşenler arasında sıkı bağımlılıklar ortadan kalkar. Bu, bileşenlerin bağımsız olarak değiştirilebilmesini ve test edilebilmesini kolaylaştırır.
Mediatör deseni, özellikle CQRS ile birlikte kullanıldığında, komut ve sorgu işlemlerinin düzenlenmesinde ve yönetilmesinde büyük fayda sağlar.

### Proje Yapısı
Bu proje, CQRS ve Mediatör tasarım desenlerini kullanarak bir .NET Core MVC uygulaması geliştirmek için örnek bir yapı sunmaktadır. Projede, komutlar ve sorgular ayrı katmanlarda düzenlenmiş ve mediatör aracılığıyla yönetilmektedir. Bu, kodun daha modüler, ölçeklenebilir ve bakımının kolay olmasını sağlamaktadır.

## Kullanılan Diğer Teknoloji Ve Araçlar
- .Net Core Mvc
- EntityFramework
- AutoMapper
- MediatR

## Projeye Ait Görseller

### UI

![Ekran görüntüsü 2024-06-13 103247](https://github.com/Yahyaygmr/CarRentCM-P7/assets/101245826/0cb127ef-c675-4dce-800d-8c229d912541)
![Ekran görüntüsü 2024-06-13 103331](https://github.com/Yahyaygmr/CarRentCM-P7/assets/101245826/c64eab41-86ee-42b4-a6b6-c0973098945c)
![Ekran görüntüsü 2024-06-13 103359](https://github.com/Yahyaygmr/CarRentCM-P7/assets/101245826/6792555e-c5d2-46f0-b5ad-c5b23c4ea4af)
![Ekran görüntüsü 2024-06-13 103428](https://github.com/Yahyaygmr/CarRentCM-P7/assets/101245826/4ebe7eb6-e3c9-41fd-b218-4144c6a72bb4)
![Ekran görüntüsü 2024-06-13 103512](https://github.com/Yahyaygmr/CarRentCM-P7/assets/101245826/07b841c0-ff4d-4085-8b0e-f3339edef309)
![Ekran görüntüsü 2024-06-13 103532](https://github.com/Yahyaygmr/CarRentCM-P7/assets/101245826/3a17ad84-ac51-40ec-b28d-d9378f524109)

### Admin

![Ekran görüntüsü 2024-06-13 103619](https://github.com/Yahyaygmr/CarRentCM-P7/assets/101245826/ad74e66e-e09f-4ca7-9030-bf800a7d4957)
![Ekran görüntüsü 2024-06-13 103657](https://github.com/Yahyaygmr/CarRentCM-P7/assets/101245826/6e0daca1-7fa7-4cc6-b6a0-f123c523b8cc)
