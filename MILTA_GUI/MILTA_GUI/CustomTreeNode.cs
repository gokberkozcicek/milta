using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiltaCore;
namespace MILTA_GUI
{
    internal class CustomTreeNode:TreeNode
    {
        internal CustomNodeStatus Status { get; set; }
        internal IMiltaObject BaseObject { get; set; }
        public CustomTreeNode(IMiltaObject baseObject)
        {
            this.BaseObject = baseObject;
            this.Text = baseObject.Name;
            this.Status = CustomNodeStatus.Valid;
            SetNodeImages();
        }

        internal void SetNodeImages()
        {
            switch (BaseObject.MiltaObjectType)
            {
                case MiltaObjectTypes.MiltaProject:
                    ImageIndex=0;
                    SelectedImageIndex = 0;
                    break;
                case MiltaObjectTypes.Shaft:
                    ImageIndex = 1;
                    SelectedImageIndex = 1;
                    break;
                case MiltaObjectTypes.SectionCollection:
                    ImageIndex = 2;
                    SelectedImageIndex = 2;
                    break;
                default:
                    ImageIndex = 3;
                    SelectedImageIndex=3;
                    break;
            }
        }
    }

    public enum CustomNodeStatus
    {
        Valid,
        UnValid,
        Warning
    }
}
