namespace Bridge;
public readonly record struct CreditCard
{
    public required string Number { get; init; }
    public required string FullName { get; init; }
    public required DateOnly ExpirationDate { get; init; }
    public required string CVV { get; init; }
}
