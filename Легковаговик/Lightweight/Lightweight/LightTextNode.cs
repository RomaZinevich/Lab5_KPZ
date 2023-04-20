using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightweight
{
    public class LightTextNode : LightNode
    {
        private string Text;
        public LightTextNode(string text)
        {
            this.Text = text;
        }

        public override string OuterHTML
        {
            get { return Text; }
        }

        public override string InnerHTML
        {
            get { return Text; }
        }
    }
}
