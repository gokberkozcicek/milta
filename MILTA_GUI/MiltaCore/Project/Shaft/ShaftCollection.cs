﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltaCore
{
    public class ShaftCollection : List<ShaftData>, IMiltaObject
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "Shaft Collection";
        public MiltaObjectTypes MiltaObjectType { get; set; } = MiltaObjectTypes.ShaftCollection;
        public new void Add(ShaftData data)
        {
            base.Add(data);
        }
    }
}
