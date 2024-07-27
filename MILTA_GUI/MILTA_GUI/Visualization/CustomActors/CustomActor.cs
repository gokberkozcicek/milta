﻿using Kitware.VTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILTA_GUI
{
    public abstract class CustomActor
    {
        public string Id { get; set; }=Guid.NewGuid().ToString();
        public vtkActor Actor { get; set; }
        public abstract CustomActorTypes ActorTypes { get; set; }
    }
    public enum CustomActorTypes
    {
        OuterContour
    }
}
