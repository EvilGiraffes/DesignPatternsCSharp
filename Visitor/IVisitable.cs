public interface IVisitable<TClass>
{
    TReturn Accept<TReturn>(IVisitor<TClass, TReturn> visited);
}