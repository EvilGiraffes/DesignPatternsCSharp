public class CarBuilder: IBuilder<Car>
{
    string _licensePlate = default!;
    string _vinNumber = default!;
    string _type = default!;
    string _model = default!;
    int _year;
    int _kmDriven;
    public CarBuilder WithLicensePlate(string plate)
    {
        _licensePlate = plate;
        return this;
    }
    public CarBuilder WithVinNumber(string num)
    {
        _vinNumber = num;
        return this;
    }
    public CarBuilder WithType(string type)
    {
        _type = type;
        return this;
    }
    public CarBuilder WithModel(string model)
    {
        _model = model;
        return this;
    }
    public CarBuilder WithYear(int year)
    {
        _year = year;
        return this;
    }
    public CarBuilder WithKmDriven(int kmDriven)
    {
        _kmDriven = kmDriven;
        return this;
    }
    public Car Build() => new(_licensePlate, _vinNumber, _type, _model, _year, _kmDriven);
    public static implicit operator Car(CarBuilder builder) => builder.Build();
}