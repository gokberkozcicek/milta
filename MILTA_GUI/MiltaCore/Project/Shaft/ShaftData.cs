using MiltaCore.Sections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETFEA;
namespace MiltaCore
{
    public class ShaftData : IMiltaObject, IMiltaComponent,INotifyPropertyChanged
    {
        [Browsable(false)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual string Name { get; set; } = "Shaft";
        [Browsable(false)]
        public virtual MiltaObjectTypes MiltaObjectType { get; set; }=MiltaObjectTypes.Shaft;
        [Browsable(false)]
        public MiltaComponentTypes ComponentTypes { get; set; } = MiltaComponentTypes.Shaft;

        [Browsable(false)]  
        public PointD StartPoint { get; set; }
        [Browsable(false)]
        public SectionCollection OuterSections { get; set; }
        [Browsable(false)]
        public SectionCollection InnerSections { get; set; }
        [Browsable(false)]
        public BcCollection Bcs { get; set; }
        [Browsable(false)]
        public LoadCollection Loads { get; set; }
        [Browsable(false)]
        public IMiltaObject ParentObject { get; set; }

        private int _numberOfNodes = 1000;

        public int NumberOfNodes
        {
            get { return _numberOfNodes; }
            set
            {
                var oldValue = _numberOfNodes;
                _numberOfNodes = value;
                Notify("NODECOUNT", oldValue, _numberOfNodes, Id);
            }
        }
        [Browsable(false)]
        public MeshData MeshData { get; set; }
        [Browsable(false)]
        public bool IsMeshed { get; set; } = false;
        public ShaftData(IMiltaObject parent) { 
            OuterSections=new SectionCollection(this);
            InnerSections = new SectionCollection(this);
            Bcs = new BcCollection(this);
            Loads=new LoadCollection(this);
            StartPoint=new PointD(0,0,0);
            ParentObject = parent;
            MeshData = new MeshData();
        }
        public void Mesh()
        {
            ShaftMesher mesher = new ShaftMesher(this);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propertyName, object oldValue, object newValue, string Id)
        {
            OnPropertyChanged(this, new ExtendedPropertyChangedEventArgs(propertyName, oldValue, newValue, Id));

        }
        public virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(sender, e);
        }
        public double GetLength()
        {
            double length = 0;
            foreach (var section in this.OuterSections)
            {
                length += section.Length;
            }
            return length;
        }
    }
}
