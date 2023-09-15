using Task2;

LeashesFactory leashesFactory = new LeashesFactory();
var leash = leashesFactory.FactoryMethod("ultracomfortable", Size.Small);
leashesFactory.Advert(leash);
Console.WriteLine();
MuzzlesFactory muzzlesFactory = new MuzzlesFactory();
var muzzle = muzzlesFactory.FactoryMethod("superbig", Size.Large);
muzzlesFactory.Advert(muzzle);