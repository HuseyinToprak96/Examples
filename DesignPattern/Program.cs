
#region Açıklama


/*
 Design patternler genellikle davranışsal (behavioral) ve yapısal (structural) olmak üzere iki ana kategoriye ayrılır. 

1. Davranışsal tasarım desenleri, nesneler ve sınıflar arasındaki davranışları yönetmek ve organize etmek için kullanılır. Bu desenler, nesneler arasındaki etkileşimleri, sorumlulukları ve algoritma yürütme şekillerini düzenlemek için kullanılır. Örnek olarak, Observer, Strategy ve State gibi tasarım desenleri davranışsal desenlere örnek olarak verilebilir.

2. Yapısal tasarım desenleri, sınıflar ve nesneler arasındaki ilişkileri organize etmek ve yapılandırmak için kullanılır. Bu desenler, nesnelerin nasıl bir araya geleceğini, bileşik nesnelerin oluşturulmasını ve sınıf hiyerarşilerinin yapılandırılmasını ele alır. Örnek olarak, Adapter, Decorator ve Composite gibi tasarım desenleri yapısal desenlere örnek olarak verilebilir.

Her iki kategori de farklı amaçlara hizmet eder ve tasarım problemlerine farklı çözümler sunar. Her bir tasarım deseni belirli bir senaryoya veya soruna uygun olabilir ve kullanıldıkları alanlar farklılık gösterebilir. Bu nedenle, tasarım desenlerini davranışsal ve yapısal kategorilere göre gruplandırmak, belirli bir desenin amacını ve kullanım alanını daha iyi anlamamıza yardımcı olabilir.
 */

/*
1. Finansal Sektör:

Observer Pattern: Finansal verilerin güncellenmesi ve dağıtılması için kullanılır.
Strategy Pattern: Farklı yatırım stratejilerinin uygulanması için kullanılır.

2. Telekomünikasyon Sektörü:

Observer Pattern: Abonelerin durumlarının takip edilmesi ve bildirimlerin yapılması için kullanılır.
Adapter Pattern: Farklı iletişim protokolleri arasında veri dönüşümü için kullanılır.

3. Otomotiv Sektörü:

Factory Pattern: Farklı araç modellerinin üretimi için kullanılır.
Builder Pattern: Araç yapısının adım adım oluşturulması için kullanılır.

4. E-ticaret Sektörü:

Singleton Pattern: Ödeme işlemleri, sepet yönetimi gibi ortak nesnelere tek bir erişim noktası sağlamak için kullanılır.
Observer Pattern: Stok güncellemeleri, indirim bildirimleri gibi olaylarda kullanıcıları bilgilendirmek için kullanılır.

5. Oyun Geliştirme Sektörü:

State Pattern: Oyundaki karakterlerin farklı durumlarının yönetimi için kullanılır.
Composite Pattern: Oyun nesnelerinin hiyerarşik bir yapıda yönetilmesi için kullanılır.
 */
#endregion
using DesignPattern.Patterns;

//Iterator
/*
 Bu örnekte, bir IIterator arayüzü tanımlanmıştır. Bu arayüz, koleksiyon üzerinde gezinmek için gerekli metotları içerir: HasNext() ve Next(). MyList sınıfı, IIterator arayüzünü uygular ve bir liste üzerinde gezinmek için gerekli mantığı sağlar. Program sınıfında ise, bir string listesi oluşturulur ve MyList sınıfı kullanılarak bu listenin üzerinde döngü yapılarak elemanlar ekrana yazdırılır. Iterator tasarım deseni, koleksiyonun iç yapısını gizler ve gezinme işlemlerini kolaylaştırır.
 */

#region Iterator
Console.WriteLine("Iterator Design Pattern");
List<string> names = new List<string> { "John", "Jane", "Mike", "Emily" };
IIterator<string> iterator = new MyList<string>(names);

while (iterator.HasNext())
{
    string name = iterator.Next();
    Console.WriteLine(name);
}
#endregion
//Proxy
/*
 Bu örnekte, IImage arayüzü tanımlanmıştır ve bu arayüz, bir resmi ekrana yansıtmak için Display() metodu içerir. RealImage sınıfı, gerçek bir resmi temsil eder ve Display() metodu içinde resmi yüklemek ve ekrana yazdırmak için gereken işlemleri gerçekleştirir. ProxyImage sınıfı ise, RealImage sınıfının yerine geçerek onun davranışını kontrol eder. Eğer resim daha önceden yüklenmemişse, ProxyImage sınıfı RealImage'i yaratır ve ardından resmi yükler ve ekrana yazdırır. Bu sayede, istemci sadece ProxyImage sınıfıyla etkileşime geçer. Proxy tasarım deseni, gerçek nesnenin yerine geçerek ek işlemler yapmak veya gerçek nesnenin yaratılmasını erteleme gibi durumları ele alır.
 */
#region Proxy
Console.WriteLine("Proxy Design Pattern");
IImage image = new ProxyImage("image.jpg");
    image.Display();
#endregion

#region Command
Console.WriteLine("Command Design Pattern");
var editor = new Editor();
var cutCommand = new CutCommand(editor);
var pasteCommand = new PasteCommand(editor, "Yapıştırılacak metin");

cutCommand.Execute(); // Kes
editor.PrintContent(); // Editor içeriği: 

pasteCommand.Execute(); // Yapıştır
editor.PrintContent(); // Editor içeriği: Yapıştırılacak metin

pasteCommand.Undo(); // Yapıştırın geri al
editor.PrintContent(); // Editor içeriği:
#endregion

#region State

// Kullanım
Console.WriteLine("State Design Pattern");
var context = new StateContext();
context.Request(); // Lamba kapatıldı.
context.SetState(new OpenState());
context.Request(); // Lamba açıldı.
#endregion

#region Singleton

// Singleton örneğini al
Console.WriteLine("Singleton Design Pattern");
Singleton singleton1 = Singleton.Instance;
Singleton singleton2 = Singleton.Instance;

// İki örneğin aynı olduğunu kontrol et
bool areSameInstance = ReferenceEquals(singleton1, singleton2);

Console.WriteLine($"İki örnek aynı mı: {areSameInstance}");

#endregion

#region Template
Console.WriteLine("Template Design Pattern");
AbstractClass abstractClass = new ConcreteClass();
abstractClass.TemplateMethod();
#endregion

#region Prototype
Console.WriteLine("Prototype Design Pattern");
Circle circle = new Circle { Radius = 5 };
Circle clonedCircle = (Circle)circle.Clone();
Console.WriteLine("Original Circle Radius: " + circle.Radius);
Console.WriteLine("Cloned Circle Radius: " + clonedCircle.Radius);

Rectangle rectangle = new Rectangle { Width = 10, Height = 20 };
Rectangle clonedRectangle = (Rectangle)rectangle.Clone();
Console.WriteLine("Original Rectangle Width: " + rectangle.Width + ", Height: " + rectangle.Height);
Console.WriteLine("Cloned Rectangle Width: " + clonedRectangle.Width + ", Height: " + clonedRectangle.Height);
#endregion

#region Decorator
ConcreteComponent component = new ConcreteComponent();
ConcreteDecorator decorator = new ConcreteDecorator(component);
decorator.Operation();

#endregion

#region ObServer
Console.WriteLine("Observer Design Pattern");
ConcreteSubject subject = new ConcreteSubject();
ConcreteObserver observer1 = new ConcreteObserver();
ConcreteObserver observer2 = new ConcreteObserver();

subject.Attach(observer1);
subject.Attach(observer2);
subject.Notify("Hello Observers!");
#endregion

#region Strategy
Console.WriteLine("Strategy Design Pattern");
StrategyContext strategyContext = new StrategyContext(new ConcreteStrategyA());
strategyContext.ExecuteStrategy();

strategyContext = new StrategyContext(new ConcreteStrategyB());
strategyContext.ExecuteStrategy();
#endregion

#region Builder

Console.WriteLine("Builder Design Pattern");
ProductBuilder builder = new ProductBuilder();
Product product = builder.SetName("Phone")
                        .SetDescription("Smartphone")
                        .SetPrice(999.99)
                        .Build();

Console.WriteLine($"Product Name: {product.Name}");
Console.WriteLine($"Product Description: {product.Description}");
Console.WriteLine($"Product Price: {product.Price}");
#endregion

#region Factory
Console.WriteLine("Factory Design Pattern");
ProductFactory factory = new ProductFactory();
IProduct productA = factory.CreateProduct("A");
productA.Display();
IProduct productB = factory.CreateProduct("B");
productB.Display();
#endregion