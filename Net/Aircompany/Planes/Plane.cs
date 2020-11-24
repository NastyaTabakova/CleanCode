using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane 
    {
        public string ModelofPlane;
        public int MaximumSpeedofPlane;
        public int MaximumFlightDistanceofPlane;
        public int MaximumLoadCapacityofPlane;

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            ModelofPlane = model;
            MaximumSpeedofPlane = maxSpeed;
            MaximumFlightDistanceofPlane = maxFlightDistance;
            MaximumLoadCapacityofPlane = maxLoadCapacity;
        }

        public string GetModelofPlane() 
        {
            return ModelofPlane;
        }

        public int GetMaximumSpeedofPlane()
        {
            return MaximumSpeedofPlane;
        }

        public int GetMaximumFlightDistanceofPlane()
        {
            return MaximumFlightDistanceofPlane;
        }

        public int GetMaximumLoadCapacityofPlane()
        {
            return MaximumLoadCapacityofPlane;
        }

        public override string ToString()
        {
            return "Plane{" +
                "model='" + ModelofPlane + '\'' +
                ", maxSpeed=" + MaximumSpeedofPlane +
                ", maxFlightDistance=" + MaximumFlightDistanceofPlane +
                ", maxLoadCapacity=" + MaximumLoadCapacityofPlane +
                '}';
        }

        public override bool Equals(object obj)
        {
            return obj is Plane plane &&
                   ModelofPlane == plane.ModelofPlane &&
                   MaximumSpeedofPlane == plane.MaximumSpeedofPlane &&
                   MaximumFlightDistanceofPlane == plane.MaximumFlightDistanceofPlane &&
                   MaximumLoadCapacityofPlane == plane.MaximumLoadCapacityofPlane;
        }

        public override int GetHashCode()
        {
            return ModelofPlane.GetHashCode() + MaximumSpeedofPlane.GetHashCode() + MaximumFlightDistanceofPlane.GetHashCode() + MaximumLoadCapacityofPlane.GetHashCode();
        }        

    }
}
