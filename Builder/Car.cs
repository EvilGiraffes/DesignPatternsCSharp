public class Car 
{
    string _licensePlate;
    string _vinNumber;
    string _type;
    string _model;
    int _year;
    int _kmDriven;
    public Car(string licensePlate, string vinNumber, string type, string model, int year, int kmDriven)
    {
        _licensePlate = licensePlate;
        _vinNumber = vinNumber;
        _type = type;
        _model = model;
        _year = year;
        _kmDriven = kmDriven;
    }
}