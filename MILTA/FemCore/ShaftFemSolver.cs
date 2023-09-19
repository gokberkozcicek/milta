using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Math;
using Numpy;
using Numpy.Models;
using static Numpy.np;

namespace FemCore
{

    public class ShaftFemSolver
    {

        ShaftFemData shaftData = new ShaftFemData();
        CustomShaftBoundaryCollection shaftBoundaryCondition = new CustomShaftBoundaryCollection();
        
        


        public void SetSolverInput(double elasticModulus, double shearModulus, int numberOfElement, double elementLength, List<double> shaftSectionDiamaters)
        {

            shaftData.ElasticModulus = elasticModulus;
            shaftData.ShearModulus = shearModulus;
            shaftData.NumberOfElement = numberOfElement;
            shaftData.ElementLength = elementLength;

            foreach (var item in shaftSectionDiamaters)
            {
                ShaftSectionData shaftSectionData = new ShaftSectionData();

                shaftSectionData.ShaftDiameter = item;

                shaftData.ShaftSectionDatas.Add(shaftSectionData);

            }
        }

        public void SetBoundaryCondition(List<int>  shaftBoundary) 
        {

            foreach (var item in shaftBoundary)
            {
                ShaftBoundaryConditionData shaftBoundaryCondition = new ShaftBoundaryConditionData();
                shaftBoundaryCondition.NodeNumber = item;

                if (item == 1)
                {
                    shaftBoundaryCondition.boundaryCondition = BoundaryCondition.Fixed;
                }
                else
                {
                    shaftBoundaryCondition.boundaryCondition = BoundaryCondition.Fixed;
                }

            }

        }






        public void Solve() 
        {
            int topsay = 0;
            int[,] top1 = new int[shaftData.NumberOfElement, 12];


            for (int i1 = 0; i1 < shaftData.NumberOfElement; i1++)
            {
                topsay++;
                top1[i1, 0] = topsay;
                topsay++;
                top1[i1, 1] = topsay;
                topsay++;
                top1[i1, 2] = topsay;
                topsay++;
                top1[i1, 3] = topsay;
                topsay++;
                top1[i1, 4] = topsay;
                topsay++;
                top1[i1, 5] = topsay;
                topsay++;
                top1[i1, 6] = topsay;
                topsay++;
                top1[i1, 7] = topsay;
                topsay++;
                top1[i1, 8] = topsay;
                topsay++;
                top1[i1, 9] = topsay;
                topsay++;
                top1[i1, 10] = topsay;
                topsay++;
                top1[i1, 11] = topsay;
                topsay -= 6;
            }


            int maxNodeNumber = top1.Cast<int>().Max();
            double[,] kGlobal = new double[maxNodeNumber, maxNodeNumber]; 



            for (int i = 0; i < shaftData.ShaftSectionDatas.Count; i++)
            {
                double a = shaftData.ElasticModulus * shaftData.ShaftSectionDatas[i].CrossSectionArea / shaftData.ElementLength;
                double b = 12 * shaftData.ElasticModulus * shaftData.ShaftSectionDatas[i].SectionInertia / (Math.Pow(shaftData.ElementLength, 3));
                double c = 6*shaftData.ElasticModulus * shaftData.ShaftSectionDatas[i].SectionInertia / (Math.Pow(shaftData.ElementLength, 2));
                double d = 12 * shaftData.ElasticModulus * shaftData.ShaftSectionDatas[i].SectionInertia / (Math.Pow(shaftData.ElementLength, 3));
                double e = 6 * shaftData.ElasticModulus * shaftData.ShaftSectionDatas[i].SectionInertia / (Math.Pow(shaftData.ElementLength, 2));
                double f = shaftData.ShearModulus * shaftData.ShaftSectionDatas[i].ShearConstantKv / shaftData.ElementLength;
                double g = 2 * shaftData.ElasticModulus * shaftData.ShaftSectionDatas[i].SectionInertia / shaftData.ElementLength;
                double h = 2 * shaftData.ElasticModulus * shaftData.ShaftSectionDatas[i].SectionInertia / shaftData.ElementLength;

                for (int isay = 0; isay < shaftData.NumberOfElement; isay++)
                {
                    double[,] kel = new double[,]
                    {
                    {a, 0, 0, 0, 0, 0, -a, 0, 0, 0, 0, 0},
                    {0, b, 0, 0, 0, c, 0, -b, 0, 0, 0, c},
                    {0, 0, d, 0, -e, 0, 0, 0, -d, 0, -e, 0},
                    {0, 0, 0, f, 0, 0, 0, 0, 0, -f, 0, 0},
                    {0, 0, -e, 0, 2 * g, 0, 0, 0, e, 0, g, 0},
                    {0, c, 0, 0, 0, 2 * h, 0, -c, 0, 0, 0, h},
                    {-a, 0, 0, 0, 0, 0, a, 0, 0, 0, 0, 0},
                    {0, -b, 0, 0, 0, -c, 0, b, 0, 0, 0, -c},
                    {0, 0, -d, 0, e, 0, 0, 0, d, 0, e, 0},
                    {0, 0, 0, -f, 0, 0, 0, 0, 0, f, 0, 0},
                    {0, 0, -e, 0, g, 0, 0, 0, e, 0, 2 * g, 0},
                    {0, c, 0, 0, 0, h, 0, -c, 0, 0, 0, 2 * h}
                    };

                    for (int i1 = 0; i1 < 12; i1++)
                    {
                        for (int j1 = 0; j1 < 12; j1++)
                        {
                            kGlobal[(int)top1[isay, i1] - 1, (int)top1[isay, j1] - 1] += (double)kel[i1, j1];
                        }
                    }
                }
            }

            int rowCountGlobalK = kGlobal.GetLength(0);

            double[,] forceBoundary = new double[rowCountGlobalK, 1];


            forceBoundary[forceBoundary.GetLength(0) - 5, 0] = 1 * 1000;

            kGlobal = MatrixOperation.DeleteNthRowAndColumn(kGlobal, 5);
            kGlobal = MatrixOperation.DeleteNthRowAndColumn(kGlobal, 4);
            kGlobal = MatrixOperation.DeleteNthRowAndColumn(kGlobal, 3);
            kGlobal = MatrixOperation.DeleteNthRowAndColumn(kGlobal, 2);
            kGlobal = MatrixOperation.DeleteNthRowAndColumn(kGlobal, 1);
            kGlobal = MatrixOperation.DeleteNthRowAndColumn(kGlobal, 0);


            forceBoundary = MatrixOperation.DeleteNthRow(forceBoundary, 5);
            forceBoundary = MatrixOperation.DeleteNthRow(forceBoundary, 4);
            forceBoundary = MatrixOperation.DeleteNthRow(forceBoundary, 3);
            forceBoundary = MatrixOperation.DeleteNthRow(forceBoundary, 2);
            forceBoundary = MatrixOperation.DeleteNthRow(forceBoundary, 1);
            forceBoundary = MatrixOperation.DeleteNthRow(forceBoundary, 0);


            double[,] result = new double[kGlobal.GetLength(0), 1];

            result = MatrixOperation.MatrixMultiply(kGlobal.PseudoInverse(), forceBoundary);



            var ali = 2;



        }

    }
}
