using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KoanHelpers;

namespace TheKoans
{
    public class AboutCloning
    {
        public static void Run() {
            Tree tree1 = new Tree();
            tree1.name = "Ulme";
            Tree tree2 = tree1.Clone() as Tree;
            tree2.name = "Birke";
            Assert.assertThat("name of tree1 is still the same", "Ulme" == tree1.name);
            Tree tree3 = tree1.ImproperClone() as Tree;
            tree3.name = "Birke";
            Assert.assertThat("this works also", "Ulme" == tree1.name);
            
        }
    }
    class Tree : ICloneable{
        public string name = "";
        public object Clone() {
            Tree clone = new Tree();
            clone.name = this.name.Clone() as string;
            return clone;
        }
        public object ImproperClone()
        {
            Tree clone = new Tree();
            clone.name = this.name;
            return clone;
        }

    }
}
