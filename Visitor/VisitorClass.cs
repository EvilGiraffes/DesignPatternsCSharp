public class VisitorClass: IVisitable<VisitorClass>
{
    public int Stuff { get; set; } = 0;
    public TReturn Accept<TReturn>(IVisitor<VisitorClass, TReturn> visitor) => visitor.Visit(this);
}