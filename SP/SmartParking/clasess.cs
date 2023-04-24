namespace SmartParking
{

    public class Admin
    {
        public string username { get; set; } = "";
        public string password { get; set; } = "";

        public void addCar()
        {

        }
    }
  
    public class Beacon
    {
        public double D1 { get; set; }
        public double D2 { get; set; }
        public double D3 { get; set; }
        public double D4 { get; set; }
        public long Id { get; set; }
        public long Time { get; set; }

    }
    public class Beacons
    {
        public int total { get; set; }
        public Beacon[] data { get; set; }

    }


    public class Point //coordinatess
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Slot //for easch parking slot
    {
        public Point[] position { get; set; }
    }

    //class parking lot that has total
    public class ParkingMap
    {
        public int total { get; set; }
        public Slot[] data { get; set; } //array of Slots
    }



    public class Sensor
    { 
        public Point position { get; set; } //sensor just has one point
    }
    public class Sensors
    {
        public Sensor[] data { get; set; } //array of sensors
        public int total { get; set; } 
    }

    
}

