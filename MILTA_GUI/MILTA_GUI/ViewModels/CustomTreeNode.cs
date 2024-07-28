using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kitware.VTK;
using MiltaCore;
namespace MILTA_GUI
{
    internal class CustomTreeNode:TreeNode
    {
        internal CustomNodeStatus Status { get; set; }
        internal IMiltaObject BaseObject { get; set; }
        internal bool IsPropertyGridObject { get; set; } = true;
        public CustomTreeNode(IMiltaObject baseObject)
        {
            this.BaseObject = baseObject;
            this.Text = baseObject.Name;
            this.Status = CustomNodeStatus.Valid;
            SetNodeImages();
            SetPropertyGridStatus();
        }
        internal void SetPropertyGridStatus()
        {
            switch (BaseObject.MiltaObjectType)
            {
                case MiltaObjectTypes.ShaftCollection:
                    IsPropertyGridObject = false;
                    break;
                case MiltaObjectTypes.SectionCollection:
                    IsPropertyGridObject = false;
                    break;
                case MiltaObjectTypes.LoadCollection:
                    IsPropertyGridObject = false;
                    break;
                case MiltaObjectTypes.BCCollection:
                    IsPropertyGridObject = false;
                    break;
                default:
                    break;
            }
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
                case MiltaObjectTypes.LoadCollection:
                    ImageIndex = 6;
                    SelectedImageIndex = 6;
                    break;
                case MiltaObjectTypes.BCCollection:
                    ImageIndex = 7;
                    SelectedImageIndex = 7;
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
