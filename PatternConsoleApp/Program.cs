using System.Text;
using Pattern.Gof.AbstractFactory;

Console.OutputEncoding = Encoding.UTF8;

/*var creditStrategy = new CreditCardStrategy("9999 9999 9999 9999", "SILVIO LUIZ BASSI", "2029/12/28", "579");
Purchase purchaseCredit = new(creditStrategy);
purchaseCredit.ProcessPayment(100.00);

var pixStrategy = new PixStrategy("silviobassi2@gmail.com", "Silvio Luiz Bassi", "Banco Pan");

Purchase purchasePix = new(pixStrategy);
purchasePix.ProcessPayment(2000.00);*/

/*var professionalSubscriber = new ProfessionalSubscriber("Silvio Luiz Bassi", "silvio@email.com");
var customerSubscriber = new CustomerSubscriber("Pedro Oliveira Bassi", "pedro@email.com");

var schedulePublisher =
    new SchedulePublisher(DateTime.Now, "Avenida da Saudade, 3389, Centro - São José do Rio Preto/SP");

schedulePublisher.Subscribe(professionalSubscriber);
schedulePublisher.Subscribe(customerSubscriber);

schedulePublisher.Notify();*/

Console.WriteLine("🏠 Brazilian Restaurant:");

var brazilianRestaurantFactory = new BrazilianRestaurantFactory();
ClientAbstractFactory client1 = new(brazilianRestaurantFactory);
client1.DisplayMeal();

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("🏠 Japanese Restaurant:");

var japaneseRestaurantFactory = new JapaneseRestaurantFactory();
ClientAbstractFactory client2 = new(japaneseRestaurantFactory);
client2.DisplayMeal();

