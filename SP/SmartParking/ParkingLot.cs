using Firebase.Database;
using Firebase.Database.Query;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;

using System.IO; //for SteamReader

namespace SmartParking
{
    public partial class ParkingLot : Form
    {
        FirebaseClient client = new FirebaseClient("https://heymotocarro-1a1d4.firebaseio.com/");
        Graphics G;
        Rectangle[] rect = new Rectangle[6]; //6 parking slots
        Beacons BeaconsSet;
        ParkingMap ParkingMapSet;
        Sensors SensorSet;

        public ParkingLot()
        {
            InitializeComponent();
           // WindowState = FormWindowState.Maximized;
        }
        private void ParkingLot_Load(object sender, EventArgs e)
        {
            G = this.CreateGraphics();
        }
        private void loadData(object sender, EventArgs e)
        {
            getBeaconDataAsync();
        }
        private void DrawSlots(object sender, EventArgs e)
        {
            int k = 0;
            int l = 0;

            Pen blackPen = new Pen(Color.Black, 0);
            SolidBrush myBrush = new SolidBrush(Color.Beige);
            SolidBrush myBrush2 = new SolidBrush(Color.Brown);

            Console.WriteLine("Drawing Parking Lot..");

            // Create rectangle and Draw rectangle to screen.
            //Dimensions are taken from firebase in inches

            for (int i = 0; i < 3; i++) //1st half of parking lot
            {
                rect[i] = new Rectangle(100 + 100 * i, 100, 100, 200);
                G.FillRectangle(myBrush, rect[i]);
                G.DrawRectangle(blackPen, rect[i]);
            }

            for (int j = 3; j < 6; j++) //2nd half of parking lot
            {
                rect[j] = new Rectangle(100 + 100 * k, 350, 100, 200);
                G.FillRectangle(myBrush, rect[j]);
                G.DrawRectangle(blackPen, rect[j]);
                k++;
            }



            //Update parking space rectangle color
            G.FillRectangle(myBrush2, rect[2]);
            G.FillRectangle(myBrush2, rect[5]);

            foreach (var rectangle in rect)
            {

            }




            //draw parking numbers
            for (int i = 0; i < 3; i++)
            {
                 DrawStringFloatFormat((i + 1).ToString(), 100 + 100 * i + 50, 200.0F);
            }
            for (int j = 3; j < 6; j++)
            {
                DrawStringFloatFormat((j + 1).ToString(), 100 + 100 * l + 50, 450.0F);
                l++;
            }

            Console.WriteLine("Drawing Complete");
        }
        private async void getBeaconDataAsync() // grabs population from database 
        {


            //******************** Get initial list of beacons ***********************//
            //Console.WriteLine("INITIAL TESTS\n");
            BeaconsSet = await client //Beacon BeaconSet = client
               .Child("Beacons/")//Prospect list
               .OnceSingleAsync<Beacons>(); //"Beacons" class has data field (array of Beacon objects) which are automatically mapped to the data field
            displayBeaconsData(BeaconsSet);

            //*NAME HAS TO MATCH CORRESPONDING TO JSON FILE*

            //ParkingMap
            //  6 Data (Parking Slots)
            //      4 Position (1 point for each corner of parking slot)

            ParkingMapSet = await client //ParkingMap ParkingMap = client
               .Child("ParkingMap/")//Prospect list
               .OnceSingleAsync<ParkingMap>();

            //Sensors
            //  4 Data (Points)
            //      1 Position (x,y)

            SensorSet = await client //ParkingMap ParkingMap = client
                .Child("Sensors/")//Prospect list
                .OnceSingleAsync<Sensors>();

            var i = 1;
            var j = 1;
            foreach (var slot in ParkingMapSet.data) //var slot: anything, just an iterator
            {
                Console.WriteLine($"slot #{i}: { slot.position[0].x} [{ slot.position[0].y}]");
                i++;
            }

            foreach(var sensor in SensorSet.data)
            {
                Console.WriteLine($"sensor #{j} x={sensor.position.x} y={sensor.position.y}");
                j++;
            }


            //******************** Get changes on beacons ***********************//
            onChildChanged();


        }

        private void onChildChanged() // Waits for data base to start with variable
        {
            //THIS FUNCTION DOES NOT STORE BEACON DATA, JUST PRINTS OUT ID AND D1 WHEN DATA IS UPDATED
            Console.WriteLine("Updated Beacon Data"); //Console.Writeline() had \n at end by default
            var child = client.Child("Beacons/data"); //.Child() specifies child node in the Firebase database from which to recieve data
            var observable = child.AsObservable<Beacon>();
            var subscription = observable
                .Subscribe(x =>
                {
                    //use beacon id to track
                    Console.WriteLine($"beacon id: { x.Object.Id} [{ x.Object.D1}]");
                    
                    foreach (var data in BeaconsSet.data) //iterator
                    {
                        if (data.Id == x.Object.Id) //if id matches id of beacon that was changed
                        { //update beacons field
                            data.D1 = x.Object.D1;
                            data.D2 = x.Object.D2;
                            data.D3 = x.Object.D3;
                            data.D4 = x.Object.D4;
                        }
                    }

                    //trilateration(x.Object.D1, x.Object.D2, x.Object.D3, x.Object.D4);
                });
           
        }
        public void DrawStringFloatFormat(String drawString, float x, float y)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);          

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
           // drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            // Draw string to screen.
            G.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
        }

        private void displayBeaconsData(Beacons beacons) // display beacons
        {
            var i = 1;
            foreach (var beacon in beacons.data)
            {
                Console.WriteLine($"beacon id #{i}: { beacon.Id} [{ beacon.D1}]");
                i++;
            }

        }

        private double[] trilateration(double d1, double d2, double d3, double d4)
        {
            // Calculate the coefficients of the linear system of equations
            double A1 = 2 * (SensorSet.data[1].position.x - SensorSet.data[0].position.x);
            double B1 = 2 * (SensorSet.data[1].position.y - SensorSet.data[0].position.y);
            double C1 = Math.Pow(d1, 2) - Math.Pow(d2, 2) - Math.Pow(SensorSet.data[0].position.x, 2) + Math.Pow(SensorSet.data[1].position.x, 2) - Math.Pow(SensorSet.data[0].position.y, 2) + Math.Pow(SensorSet.data[1].position.y, 2);
            double A2 = 2 * (SensorSet.data[2].position.x - SensorSet.data[0].position.x);
            double B2 = 2 * (SensorSet.data[2].position.y - SensorSet.data[0].position.y);
            double C2 = Math.Pow(d1, 2) - Math.Pow(d3, 2) - Math.Pow(SensorSet.data[0].position.x, 2) + Math.Pow(SensorSet.data[2].position.x, 2) - Math.Pow(SensorSet.data[0].position.y, 2) + Math.Pow(SensorSet.data[2].position.y, 2);
            double A3 = 2 * (SensorSet.data[3].position.x - SensorSet.data[0].position.x);
            double B3 = 2 * (SensorSet.data[3].position.y - SensorSet.data[0].position.y);
            double C3 = Math.Pow(d1, 2) - Math.Pow(d4, 2) - Math.Pow(SensorSet.data[0].position.x, 2) + Math.Pow(SensorSet.data[3].position.x, 2) - Math.Pow(SensorSet.data[0].position.y, 2) + Math.Pow(SensorSet.data[3].position.y, 2);

            // Solve the linear system of equations using Cramer's rule
            double det = A1 * B2 * B3 + B1 * A3 * B2 + A2 * B1 * B3 - A3 * B2 * B1 - B3 * A2 * B1 - B2 * A1 * B3;
            double x = (C1 * B2 * B3 + B1 * C3 * B2 + C2 * B1 * B3 - C3 * B2 * B1 - B3 * C2 * B1 - B2 * C1 * B3) / det;
            double y = (A1 * C2 * B3 + C1 * A3 * B2 + A2 * B1 * C3 - A3 * B2 * C1 - B3 * A2 * C1 - B1 * A3 * C2) / det;

            // Return the result as a 2D point
            double[] result = { x, y };
            return result;
        }



        //even handlers

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Add User Clicked");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
