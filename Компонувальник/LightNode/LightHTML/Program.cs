using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Робимо тегі
            LightElementNode html = new LightElementNode
            {
                TagName = "html",
                CssClasses = new List<string>() { "htmlForm" }
            };

            LightElementNode ul = new LightElementNode
            {
                TagName = "ul",
                CssClasses = new List<string>() { "virtual" }
            };
            LightElementNode ul1 = new LightElementNode
            {
                TagName = "ul"
            };
            LightElementNode li1 = new LightElementNode
            {
                TagName = "li"
            };
            LightElementNode img = new LightElementNode
            {
                TagName = "img",
                SingleTag= true,
                CssClasses = new List<string>() { "img" }

            };
            LightElementNode li2 = new LightElementNode
            {
                TagName = "li"
            };
            LightElementNode li3 = new LightElementNode
            {
                TagName = "li"
            };
            LightTextNode text1 = new LightTextNode
            {
                Text = "Перший елемент списку"
            };
            LightTextNode text2 = new LightTextNode
            {
                Text = "Другий елемент списку"
            };

            //Додайємо тегі 
            li1.AppendChild(text1);
            li2.AppendChild(text2);
            ul.AppendChild(li1);
            ul.AppendChild(li2);
            ul.AppendChild(li3);
            ul.AppendChild(img);
            ul1.AppendChild(li1);
            ul1.AppendChild(li2);
            ul1.AppendChild(li3);
            ul1.AppendChild(img);
            html.AppendChild(ul);
            html.AppendChild(ul1);

            //Клонуємо те що вийшло
            LightElementNode html1 = html.Clone() as LightElementNode;

            //Виводимо 2-ма способами
            Console.WriteLine(html.OuterHTML);
            //Console.WriteLine(html1.InnerHTML);

        }
    }
}
