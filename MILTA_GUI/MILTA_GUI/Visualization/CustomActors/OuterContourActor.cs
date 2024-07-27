using Kitware.VTK;
using MiltaCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MILTA_GUI
{
    public class OuterContourActor: CustomActor
    {
        public override CustomActorTypes ActorTypes { get; set; }=CustomActorTypes.OuterContour;
        public CellCollection ContourCells { get; set; }
        public vtkActor GetActor()
        {
            Dictionary<long, long> pointKeys = new Dictionary<long, long>();
            vtkPoints points = vtkPoints.New();
            // Define vertices
            foreach (var cellPoint in ContourCells.Points)
            {
                long pointId = points.InsertNextPoint(cellPoint.X, cellPoint.Y, cellPoint.Z);
                pointKeys.Add(cellPoint.Number, pointId);

            }
            // Create the unstructured grid
            vtkUnstructuredGrid unstructuredGrid = vtkUnstructuredGrid.New();
            unstructuredGrid.SetPoints(points);

            // Create cell array to store cells
            vtkCellArray cells = vtkCellArray.New();

            foreach (var cell in ContourCells)
            {
                cells.InsertNextCell(4);
                foreach (var point in cell.Points)
                {
                    pointKeys.TryGetValue(point.Number, out long key);
                    cells.InsertCellPoint(key);

                }
            }


            unstructuredGrid.SetCells(9, cells);

            vtkDataSetMapper mapper = vtkDataSetMapper.New();
            mapper.SetInput(unstructuredGrid);

            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            actor.GetProperty().EdgeVisibilityOn();
            actor.GetProperty().SetEdgeColor(0, 0, 0);
            Actor = actor;
            return actor;
        }
    }
}
