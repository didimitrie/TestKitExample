using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeckleCore;

namespace SuperObjectModel
{
  [Serializable]
  public class SuperSphericalPoint : SpeckleObject
  {
    public override string Type { get; set; } = "SphericalPoint";

    public double radius { get; set; } = 1;

    public double inclination { get; set; } = 0;

    public double azimuth { get; set; } = 0;

    public SuperSphericalPoint() { }
  }

}
