public interface IVisitor<TClass, TReturn>
{
    TReturn Visit(TClass visited);
}