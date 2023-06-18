using Bogus;

using Bridge;

Faker faker = new();
ICreditCardProcessor cardProcessor = new KlarnaProcessor()
{
    Authentic = faker.Random.Bool()
};
Store store = new OnlineStore(cardProcessor);
CreditCard card = new()
{
    Number = faker.Finance.CreditCardNumber(),
    FullName = faker.Person.FullName,
    ExpirationDate = faker.Date.FutureDateOnly(3),
    CVV = faker.Finance.CreditCardCvv()
};
string product = faker.Commerce.ProductName();
double price = faker.Random.Double(10, 100);
store.Purchase(card, product, price);
