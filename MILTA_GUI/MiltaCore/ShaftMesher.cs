using NETFEA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    internal class ShaftMesher
    {
        internal ShaftData Shaft { get; set; }
        public ShaftMesher(ShaftData shaft)
        {
            Shaft = shaft;
            Mesh();
        }
        private void Mesh()
        {
            Shaft.FEA.MeshData.Nodes.Clear();
            Shaft.FEA.MeshData.Elements.Clear();
            double[] vertices = Linspace(0, Shaft.GetLength(), Shaft.NumberOfNodes);
            int i = 1;
            foreach (var vertex in vertices)
            {
                FeNode node = new FeNode(i, vertex, 0, 0);
                Shaft.FEA.MeshData.AddNode(node);
                i++;
            }
            i = 1;
            for (int j = 0; j < Shaft.FEA.MeshData.Nodes.Count - 1; j++)
            {
                Beam3EB beamElement = new Beam3EB(i, new int[] { j, j + 1 });
                Shaft.FEA.MeshData.AddElement(beamElement);
                i++;
            }
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
