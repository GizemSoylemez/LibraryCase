--N katmanlı mimari de 2 katman kullandım

1-Library.Entities Katmanı: Bu katmanda aslında code first olarak db de olmasını istediğim tablo isimlerimi ve parametrelerini tanımladım.

2-Library.Data Katmanı: Bu katmanda 3 klasörüm bulunuyor.

2.1-Interface: Bu klasörümde Solid prensiblerinin son prensini depenceny invesion prensibine uygun olarak yapmak istedim.

Aynı zamanda Generic bir yapı olmasını ve kod tekrarından uzak olmak için IGeneric Interface kullandım.

2.2-Concrete:

2.2.1-Contexts: Bu klasörümde context'imi tanımladım.Burada DbContexten kalıtım yapıyorum. DbContextti bana Ef sağlamış oluyor.

Ve DbSet diyerek tablolarımı burada isimlendirmiş oluyorum aynı zamanda db nameni burada veriyorum.

2.2.2-Ef:Bu klasörde Repositori mi oluşturuyorum. Interface olarak tanımladığımı kalıtım yapıyorum. Burada da generic bir yapı oluyor.

2.3-Mapping: Bu klasörde Solid prensibin ilk kuralına uygun olması için özelliklerimi Entities içinde değil ayrı bir klasör olarak tanımlıyorum

ve bu klasörü sadece contexte tanımlıyorum.

**Database oluşturma**

-Database mi oluşturmak için Data katmanına migration çektim.

Bunu yaparken 1- add-migration Initial diyerek Initial adında bir migration oluşturdum.

2- update-database diyere MsSql Database oluşturmasını sağladım.

**appsettings.json içerisinden Connectionstringi değiştererek db yi kurabilirsiniz.

--Web:MVC mantığı kullanarak oluşturdum.

Controller: HomeController altında CRUD işlemlerimi gerçekleştiriyorum.

Model: Book Modeli oluşturdum.

View: Home Indexin içinde Index, Edit, ListBook viewlerini oluşturdum.

--Startup: Startupun içirisine Dependency Injection kullandım.
