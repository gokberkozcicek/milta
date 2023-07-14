using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MILTA
{
    internal class MiltaTreeNode:TreeNode
    {
        string Id { get; set; }=Guid.NewGuid().ToString();
    }
}
