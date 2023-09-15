using Task1;

Product iphone15 = new Product(1, "iphone", "new phone", 1000);
Product toy = new Product(2, "toy", "toy for kids to play", 30);
Product sandwich = new Product(3, "sandwich", "for your stomach", 5);

Dictionary<int, Product> epicentrProducts = new Dictionary<int, Product>() { { iphone15.GetProductId(), iphone15 },
    { toy.GetProductId(), toy }, {sandwich.GetProductId(), sandwich } };

Store epicentr = new Store("Epicentr", epicentrProducts, "Peremohy Ave 10", "epicentr.com");
Buyer dimas = new Buyer(OrderType.OfflineOrder, Delivery.Courier, PaymentMethod.Cash, toy, epicentr.Address);
Buyer glibas = new Buyer(OrderType.OnlineOrder, Delivery.Courier, PaymentMethod.Cash, iphone15, epicentr.WebAddress);
Buyer denys = new Buyer(OrderType.OnlineOrder, Delivery.SelfPickup, PaymentMethod.Card, sandwich, epicentr.WebAddress);

IStrategy strategy = new OfflineCashCourierStrategy(epicentr.Address, epicentrProducts);
IStrategy strategy1 = new OnlineCourierCashStrategy(epicentr.WebAddress, epicentrProducts);
IStrategy strategy2 = new OnlineCardSelfPickupStrategy(epicentr.WebAddress, epicentrProducts);

dimas.LookForProduct(strategy);
Console.WriteLine();
glibas.LookForProduct(strategy1);
Console.WriteLine();
denys.LookForProduct(strategy2);