using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightweight
{
    public class CreateHTML : FileLightNode
    {
        public CreateHTML() {
            file = "pg1513.txt";
        }
        public override void BuildConstract(string LightNode)
        {
            string text = File.ReadAllText(file);

            string[] lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);


            LightHTML html = new LightHTML();

            LightElementNode teg = html.CreateElement($"{LightNode}");

            LightElementNode currentElement = null;

            string elementType = "";
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                if (line.Length > 20 && !char.IsWhiteSpace(line[0]))
                {
                    elementType = "p";
                }
                if (line.Length < 20 && !char.IsWhiteSpace(line[0]))
                {
                    elementType = "h2";
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    elementType = "blockquote";
                }
                if (currentElement == null)
                {
                    elementType = "h1";
                }

                LightElementNode newElement = html.CreateElement(elementType);

                LightTextNode textNode = html.CreateTextNode(line);

                newElement.AppendChild(textNode);

                if (currentElement == null)
                {
                    teg.AppendChild(newElement);
                }
                else
                {
                    teg.AppendChild(newElement);
                }

                currentElement = newElement;
            }

            Console.WriteLine(teg.InnerHTML);
        }
    }
}
