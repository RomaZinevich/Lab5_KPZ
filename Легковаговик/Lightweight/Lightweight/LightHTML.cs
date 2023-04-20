
namespace Lightweight
{
    public class LightHTML
    {
        public LightElementNode CreateElement(string tag)
        {
            return new LightElementNode(tag);
        }
        public LightTextNode CreateTextNode(string text)
        {
            return new LightTextNode(text);
        }
    }
}
