using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightweight
{
    public class LightElementNode : LightNode
    {
        private string teg;
        private List<LightNode> children = new List<LightNode>();
        public LightElementNode(string teg)
        {
            this.teg = teg;
        }

        public override string OuterHTML
        {
            get
            {
                string Tag = "\n<" + teg + ">";
                foreach (LightNode child in children)
                {
                    Tag +=child.OuterHTML + "</" + teg + ">";
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


        public void AppendChild(LightNode node)
        {
            children.Add(node);
        }
    }
}
