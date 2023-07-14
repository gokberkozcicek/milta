using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MILTA
{
    internal class ShaftData
    {
        /// <summary>
        /// constructor 
        /// </summary>
        public ShaftData() { }
        public string Id { get; set; }=Guid.NewGuid().ToString();
        public CustomContourCollection InnerContours { get; set; } = new CustomContourCollection();
        public CustomContourCollection OuterContours { get; set; } = new CustomContourCollection();

    }
}
