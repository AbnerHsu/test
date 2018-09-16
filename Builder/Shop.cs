namespace Pattern.Builder
{
    public class Shop
    {
        private VehicleBuilder _builder;
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            _builder = vehicleBuilder;
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }

        public VehicleBuilder GetVehicle { get { return _builder;} }
    }
}