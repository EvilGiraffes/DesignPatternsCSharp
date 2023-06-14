public class Visitor: IVisitor<VisitorClass, int>
{
    public int Visit(VisitorClass visited)
    {
        return visited.Stuff++;
    }
}