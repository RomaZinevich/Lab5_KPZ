using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public bool SingleTag { get; set; }
        public List<string> CssClasses { get; set; }

        public override string OuterHTML
        {
            get
            {   
                string Tag = "<" + TagName;
                if (CssClasses != null && CssClasses.Count > 0)
                {
                    Tag += " class=\"" + string.Join(" ", CssClasses) + "\"";
                }
                if (SingleTag)
                {
                    Tag += ">\n";
                }
                else
                {
                    Tag += ">";
                    string closingTag = "</" + TagName + ">";
                    string innerHTML = InnerHTML;
                    return "\n" + Tag + innerHTML + closingTag + "\n" ;
                }
                return Tag;
            }
        }

        public override string InnerHTML
        {
            get
            {
                string innerHTML = "";
                foreach (LightNode child in children)
                {
                    innerHTML += child.OuterHTML;
                }
                return innerHTML;
            }
        }
    }
}
