using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	public class Category
	{
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public class CompositeType<T> where T : class, new()
    {
        public T Node { get; set; }
        public List<CompositeType<T>> Children { get; set; } = new List<CompositeType<T>>();

        public CompositeType<T> Add(T child)
        {
            CompositeType<T> composite = new CompositeType<T>() { Node = child };
            Children.Add(composite);
            return composite;
        }

        public static void Show(CompositeType<T> composite, TreeView treeView)
        {
            TreeNode treeNode = new TreeNode();
            var childNodes = addItemToNode(treeNode, composite);
            treeView.Nodes.Add(treeNode);
        }

        private static TreeNode addItemToNode(TreeNode treeNode, CompositeType<T> composite)
        {
            TreeNode child = treeNode.Nodes.Add(composite.Node.ToString());
            foreach (var item in composite.Children)
            {
                addItemToNode(child, item);
            }
            return child;
        }
    }
}
