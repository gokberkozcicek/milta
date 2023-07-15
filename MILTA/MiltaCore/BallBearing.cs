using GeometryCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class BallBearing:BearingData
    {
        public override string Name { get; set; } = "Ball Bearing";

        [Browsable(false)]
        PointD TP1 { get; set; }=new PointD();
        [Browsable(false)]
        PointD TP2 { get; set; }=new PointD();
        [Browsable(false)]
        PointD TP3 { get; set; }=new PointD();
        [Browsable(false)]
        PointD TP4 { get; set; }=new PointD();
        [Browsable(false)]
        PointD TCP { get; set; }=new PointD();
        [Browsable(false)]
        PointD BP1 { get; set; } =new PointD();
        [Browsable(false)]
        PointD BP2 { get; set; } = new PointD();
        [Browsable(false)]
        PointD BP3 { get; set; }= new PointD();
        [Browsable(false)]
        PointD BP4 { get; set; } = new PointD();
        [Browsable(false)]
        PointD BCP { get; set; }
        [Browsable(false)]
        public Line TL1 { get; set; }
        [Browsable(false)]
        public Line TL2 { get; set; }
        [Browsable(false)]
        public Line TL3 { get; set; }
        [Browsable(false)]
        public Line TL4 { get; set; }
        [Browsable(false)]
        public Line BL1 { get; set; }
        [Browsable(false)]
        public Line BL2 { get; set; }
        [Browsable(false)]
        public Line BL3 { get; set; }
        [Browsable(false)]
        public Line BL4 { get; set; }
        [Browsable(false)]
        public Circle C1 { get; set; }
        [Browsable(false)]
        public Circle C2 { get; set; }
        [Browsable(false)]
        public override List<PointD> Vertices { 
            get {
            return new List<PointD>() { TP1,TP2,TP3,TP4,TCP,BP1,BP2,BP3,BP4,BCP};
            }
            set { }
        }
        
        public override void SetBearing()
        {
            StartPoint = new PointD(LocationX, 0);
            TP1 = StartPoint.Move(-Thickness/2,OuterDiameter/2);
            TP2 = StartPoint.Move(Thickness/2,OuterDiameter/2);
            TP3=StartPoint.Move(Thickness/2,InnerDiameter/2);
            TP4=StartPoint.Move(-Thickness/2,InnerDiameter/2);
            TCP = AnalyticalCalculations.GetCenterPointsOfPointList(new List<PointD> { TP1, TP2, TP3, TP4 });

            BP1=StartPoint.Move(-Thickness/2,-InnerDiameter/2);
            BP2=StartPoint.Move(Thickness/2,-InnerDiameter/2);
            BP3=StartPoint.Move(Thickness/2,-OuterDiameter/2);
            BP4=StartPoint.Move(-Thickness/2,-OuterDiameter/2);
            BCP=AnalyticalCalculations.GetCenterPointsOfPointList(new List<PointD> { BP1 , BP2, BP3, BP4 });

            TL1 = new Line(TP1, TP2);
            TL2 = new Line(TP2, TP3);
            TL3 = new Line(TP3, TP4);
            TL4 = new Line(TP4, TP1);

            BL1 = new Line(BP1, BP2);
            BL2 = new Line(BP2, BP3);
            BL3 = new Line(BP3, BP4);
            BL4 = new Line(BP4, BP1);

            C1 = new Circle(Thickness* 0.25, TCP);
            C2 = new Circle(Thickness * 0.25, BCP);
        }
        [Browsable(false)]
        public override List<ClosedPath> ClosedPaths { get {
                SetBearing();

                ClosedPath rectangle1 = new ClosedPath(new List<EntityData>() { TL1, TL2, TL3, TL4 });
                ClosedPath rectangle2 = new ClosedPath(new List<EntityData>() { BL1, BL2, BL3, BL4 });
                ClosedPath circle1 = new ClosedPath(new List<EntityData> (){ C1});
                ClosedPath circle2 = new ClosedPath(new List<EntityData>() { C2});

                return new List<ClosedPath>() { rectangle1,rectangle2, circle1, circle2 };
            } }
    }
}
