using System.Drawing;

public interface IClone
{
    IClone Clone();
}
public abstract class LightNode : IClone
{
    protected List<LightNode> children = new List<LightNode>();

    public abstract string OuterHTML { get; }
    public abstract string InnerHTML { get; }

    public void AppendChild(LightNode node)
    {
        children.Add(node);
    }

    public void ReplaceChild(LightNode newNode, LightNode oldNode)
    {
        int index = children.IndexOf(oldNode);
        if (index != -1)
        {
            children[index] = newNode;
        }
    }

    public void RemoveChild(LightNode node)
    {
        children.Remove(node);
    }

    public void InsertBefore(LightNode newNode, LightNode refNode)
    {
        int index = children.IndexOf(refNode);
        if (index != -1)
        {
            children.Insert(index, newNode);
        }
    }
    public IClone Clone()
    {
        return this.MemberwiseClone() as IClone;
    }
}
