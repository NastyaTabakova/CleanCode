using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType MillitaryType;

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            MillitaryType = type;
        }

        public override bool Equals(object obj)
        {
            return obj is MilitaryPlane plane && base.Equals(obj) && MillitaryType == plane.MillitaryType;
        }
        public MilitaryType GetPlaneType()
        {
            return MillitaryType;
        }
        public override int GetHashCode() 
        {
            return base.GetHashCode() + MillitaryType.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + MillitaryType +
                    '}');
        }        
    }
}
