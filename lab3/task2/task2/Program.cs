using task2;

public class Program 
{
    static void Main(string[] args)
    {
        Internet internet = new Internet(10, 1);
        Internet internetRoaming = new Internet(1, 10);
        Minutes minutes = new Minutes(900, 100);
        SMS sms = new SMS(50, 5);
        Rate aboba = new Rate(internet, minutes, sms, 100, "aboba");
        Rate abobaRoaming = new Rate(internetRoaming, minutes, sms, 200, "abobaRoaming");
        MobileOperator vodafone = new MobileOperator(new List<Rate>() { aboba, abobaRoaming }, "vodafone");
        ProxyOperator proxyOperator = new ProxyOperator(vodafone, "777");
        Client client = new Client("Adam Johnson", "+380123456789", aboba);
        client.ViewRates(proxyOperator);
        client.ChangeRate(proxyOperator, abobaRoaming);
        client.DisplayCurrentRate();
        client.StopSubscription(proxyOperator);

    }
}