using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeckleCore;
using SuperObjectModel;
using Rhino.Geometry;

namespace SuperObjectModelRhino
{
  public class Initialiser : ISpeckleInitializer
  {
    public Initialiser( ) { }
  }

  public static partial class Conversions
  {

    // Rhino Point -> SuperSphericalPoint
    public static SuperSphericalPoint ToSpeckle( this Point3d myRhinoPoint )
    {
      var mySphPt = new SuperSphericalPoint();
      /* TODO: ADD TRIGONOMETRY; Cartesian to Polar */

      mySphPt.radius = 42;
      mySphPt.azimuth = 0.21;
      mySphPt.inclination = 0.12;

      mySphPt.GenerateHash();
      return mySphPt;
    }

    // SuperSphericalPoint -> Rhino Point
    public static Point3d ToNative( this SuperSphericalPoint mySphPt )
    {
      var myRhPt = new Point3d( 0, 0, 0 );
      /* TODO: ADD TRIGONOMETRY; Polar to Cartesian */
      return myRhPt;
    }

  }
}
