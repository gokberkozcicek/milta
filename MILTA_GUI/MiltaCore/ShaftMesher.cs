using MiltaCore.Math;
using NETFEA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class ShaftMesher
    {
        public ShaftData Shaft { get; set; }
        public MeshData MeshData { get; set; }
        public ComponentSetCollection ComponentSets { get; set; }
        public ShaftMesher(ShaftData shaft)
        {
            Shaft = shaft;
            MeshData = new MeshData();
            ComponentSets = new ComponentSetCollection();
        }
        private void InitMesher()
        {
            Mesh();
            CreateNodeSets();
            CreateElementSets();
        }
        private void Mesh()
        {
            MeshData.Nodes.Clear();
            MeshData.Elements.Clear();
            double[] vertices = Linspace(0, Shaft.GetLength(), Shaft.NumberOfNodes);
            int i = 1;
            foreach (var vertex in vertices)
            {
                FeNode node = new FeNode(i, vertex, 0, 0);
                MeshData.AddNode(node);
                i++;
            }
            i = 1;
            for (int j = 0; j < MeshData.Nodes.Count - 1; j++)
            {
                Beam3EB beamElement = new Beam3EB(i, new int[] { j, j + 1 });
                MeshData.AddElement(beamElement);
                i++;
            }
        }
        private FeNode GetNodeByLocation(PointD point)
        {
            foreach (var node in MeshData.Nodes)
            {
                PointD nodePoint=new PointD(node.Value.X,node.Value.Y,node.Value.Z);
                if (nodePoint.IsEqual(point))
                {
                    return node.Value;
                }
            }
            return null;
        }
        private void CreateNodeSets()
        {
            PointDCollection locationPoints=GetLocationPoints();
            foreach (var point in locationPoints)
            {
                FeNode node = GetNodeByLocation(point);
                if (node != null)
                {
                    NodeSet ns=new NodeSet(node.Id,"SHAFT_NSET"+node.Id);
                    ComponentSets.Add(ns);
                }
            }
        }
        private void CreateElementSets()
        {
            foreach (var element in MeshData.Elements)
            {
                ElementSet es = new ElementSet(element.Value.Id, "SHAFT_NSET" + element.Value.Id);
                ComponentSets.Add(es);
            }
        }
        private PointDCollection GetLocationPoints()
        {
            PointDCollection points = new PointDCollection();
            foreach (var section in Shaft.OuterSections)
            {
                points.Add(section.StartPoint);
            }
            foreach (var load in Shaft.Loads)
            {
                points.Add(new PointD(load.Location,0,0));
            }
            foreach (var bc in Shaft.Bcs)
            {
                points.Add(new PointD(bc.Location, 0, 0));
            }
            points.Sort();
            return points;
        }
        double[] Linspace(double start, double end, int num)
        {
            if (num <= 1)
            {
                throw new ArgumentException("Number of samples must be greater than 1.");
            }

            double[] result = new double[num];
            double step = (end - start) / (num - 1);

            for (int i = 0; i < num; i++)
            {
                result[i] = start + i * step;
            }

            return result;
        }
    }
}
