using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
namespace ConsoleApp1
{

    public class BeamElement3D
    {
        private double E;  // Young's modulus
        private double G;  // Shear modulus
        private double A;  // Cross-sectional area
        private double Iy; // Second moment of area about the local y-axis
        private double Iz; // Second moment of area about the local z-axis
        private double J;  // Torsional constant
        private double Length; // Length of the beam element

        public BeamElement3D(double E, double G, double A, double Iy, double Iz, double J, double Length)
        {
            this.E = E;
            this.G = G;
            this.A = A;
            this.Iy = Iy;
            this.Iz = Iz;
            this.J = J;
            this.Length = Length;
        }

        public Matrix<double> ComputeStiffnessMatrix()
        {
            double L = Length;

            double EAL = E * A / L;
            double GJ = G * J / L;

            double EIL = 12 * E * Iz / (L * L * L);
            double GJL = 12 * G * J / (L * L * L);

            double EIyL = 4 * E * Iy / L;
            double EIyL2 = 2 * E * Iy / L;

            double[,] kData = new double[,]
            {
            { EAL,  0,    0,    0,    0,    0,   -EAL,  0,    0,    0,    0,    0    },
            { 0,     GJL,  0,    0,    0,    -GJ,  0,    -GJL, 0,    0,    0,    -GJ  },
            { 0,     0,    EIyL, 0,    -EIyL2, 0,   0,    0,    -EIyL, 0,    -EIyL2, 0    },
            { 0,     0,    0,    GJL,  0,    0,    0,    0,    0,    -GJL,  0,    0    },
            { 0,     0,    -EIyL2, 0,   EIyL,  0,    0,    0,    EIyL2,  0,    EIyL,  0    },
            { 0,     -GJ,  0,    0,    0,    GJ,   0,    GJ,   0,    0,    0,    0    },
            { -EAL,  0,    0,    0,    0,    0,    EAL,  0,    0,    0,    0,    0    },
            { 0,     -GJL, 0,    0,    0,    GJ,   0,    GJL,  0,    0,    0,    GJ   },
            { 0,     0,    -EIyL, 0,   EIyL2, 0,    0,    0,    EIyL,  0,    EIyL2, 0    },
            { 0,     0,    0,    -GJL, 0,    0,    0,    0,    0,    GJL,  0,    0    },
            { 0,     0,    -EIyL2, 0,   EIyL,  0,    0,    0,    EIyL2, 0,    EIyL,  0    },
            { 0,     -GJ,  0,    0,    0,    0,    0,    GJ,   0,    0,    0,    GJ   }
            };

            return DenseMatrix.OfArray(kData);
        }
    }

    public class StiffnessMatrixSolver
    {
        private Matrix<double> globalStiffnessMatrix;

        public StiffnessMatrixSolver(int numNodes)
        {
            int numDOFs = numNodes * 6;
            globalStiffnessMatrix = Matrix<double>.Build.Dense(numDOFs, numDOFs);
        }

        public void AssembleStiffnessMatrix(Matrix<double> localStiffnessMatrix, int[] nodeIndices)
        {
            for (int i = 0; i < nodeIndices.Length; i++)
            {
                int globalRow = nodeIndices[i] * 6;

                for (int j = 0; j < nodeIndices.Length; j++)
                {
                    int globalColumn = nodeIndices[j] * 6;

                    for (int k = 0; k < 12; k++)
                    {
                        for (int l = 0; l < 12; l++)
                        {
                            globalStiffnessMatrix[globalRow + k, globalColumn + l] += localStiffnessMatrix[k, l];
                        }
                    }
                }
            }
        }

        public Matrix<double> GetGlobalStiffnessMatrix()
        {
            return globalStiffnessMatrix;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Matrix<double> ali = Matrix<double>.Build.Dense(4, 4);
            Console.Write(ali);
            Console.ReadLine();
        }
    }







}
