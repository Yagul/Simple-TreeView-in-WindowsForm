using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDD_Menu
{
    public partial class TreeViewForm : Form
    {
        public TreeViewForm()
        {
            InitializeComponent();

            treeView1.Nodes.Add("Sports");
            treeView1.Nodes[0].Nodes.Add("Indoor");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Carrom");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Cards");
            treeView1.Nodes[0].Nodes.Add("Outdoor");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Cricket");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Football");
            treeView1.Nodes.Add("Food");
            treeView1.Nodes[1].Nodes.Add("Breakfast");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Dosa");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("Idly");
            treeView1.Nodes[1].Nodes.Add("Lunch");
            treeView1.Nodes[1].Nodes[1].Nodes.Add("Cricket");
            treeView1.Nodes[1].Nodes[1].Nodes.Add("Football");
            treeView1.Nodes[1].Nodes.Add("Dinner");
            treeView1.Nodes[1].Nodes[2].Nodes.Add("Cricket");
            treeView1.Nodes[1].Nodes[2].Nodes.Add("Football");
           

            treeView1.CheckBoxes = true;
            AddNodeButton.Click += AddNodeButton_Click;
            RemoveNodeButton.Click += RemoveNodeButton_Click;
        }

        private void AddNodeButton_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode("New Node");
            treeView1.Nodes.Add(newNode);
        }

        // Remove Node button click event handler
        private void RemoveNodeButton_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                RemoveCheckedNodes(node);
            }
        }

        // Remove checked nodes recursively
        private void RemoveCheckedNodes(TreeNode parentNode)
        {
            for (int i = parentNode.Nodes.Count - 1; i >= 0; i--)
            {
                TreeNode node = parentNode.Nodes[i];
                if (node.Checked)
                {
                    parentNode.Nodes.Remove(node);
                }
                else
                {
                    RemoveCheckedNodes(node);
                }
            }
        }

        // AfterCheck event handler
        private void TreeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Your code here if you want to perform any action after checking a node
        }
    }
}
