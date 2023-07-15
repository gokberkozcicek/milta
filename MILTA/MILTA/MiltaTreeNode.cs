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
        internal string Id { get; set; }=Guid.NewGuid().ToString();
        internal MiltaTreeNodeTypesEnum NodeType { get; set; } = MiltaTreeNodeTypesEnum.None;
        internal string BaseObjectId { get; set; }
    }
    internal enum MiltaTreeNodeTypesEnum {
        None,
        Shaft,
        InnerContourHeader,
        OuterContourHeader,
        Contour,
        BearingsHeader,
        Bearing

    }
}
