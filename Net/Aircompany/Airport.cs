using Aircompany.Models;
using Aircompany.Planes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        public List<Plane> Planes;

        public Airport(IEnumerable<Plane> planes)
        {
            Planes = planes.ToList();
        }

        public List<PassengerPlane> GetPassengersPlanes()
        {
            var passengerPlanes = new List<PassengerPlane>();
            for (int i=0; i < Planes.Count; i++)
            {
                if (Planes[i].GetType() == typeof(PassengerPlane))
                {
                    passengerPlanes.Add((PassengerPlane)Planes[i]);
                }
            }
            return passengerPlanes;
        }

        public List<MilitaryPlane> GetMilitaryPlanes()
        {
            var militaryPlanes = new List<MilitaryPlane>();
            for (int i = 0; i < Planes.Count; i++)
            {
                if (Planes[i].GetType() == typeof(MilitaryPlane))
                {
                    militaryPlanes.Add((MilitaryPlane)Planes[i]);
                }
            }
            return militaryPlanes;
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            return GetPassengersPlanes().Aggregate((w, x) => w.GetPassengersCapacity() > x.GetPassengersCapacity() ? w : x);
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            var transportMilitaryPlanes = new List<MilitaryPlane>(); 
            for (int i = 0; i < GetMilitaryPlanes().Count; i++)
            {
                MilitaryPlane plane = GetMilitaryPlanes()[i];
                if (plane.GetPlaneType() == MilitaryType.TRANSPORT)
                {
                    transportMilitaryPlanes.Add(plane);
                }
            }
            return transportMilitaryPlanes;
        }

        public Airport SortPlanesByMaximumDistance()
        {
            return new Airport(Planes.OrderBy(w => w.GetMaximumFlightDistanceofPlane()));
        }

        public Airport SortPlanesByMaximumSpeed()
        {
            return new Airport(Planes.OrderBy(w => w.GetMaximumSpeedofPlane()));
        }

        public Airport SortPlanesByMaximumLoadCapacity()
        {
            return new Airport(Planes.OrderBy(w => w.GetMaximumLoadCapacityofPlane()));
        }


        public IEnumerable<Plane> GetAllPlanes()
        {
            return Planes;
        }

        public override string ToString()
        {
            return "Airport{" +
                    "planes=" + string.Join(", ", Planes.Select(x => x.GetModelofPlane())) +
                    '}';
        }
    }
}
