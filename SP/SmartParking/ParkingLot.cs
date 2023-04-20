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

namespace TeamVaxxers
{
    public partial class ParkingLot : Form
    {
        FirebaseClient client = new FirebaseClient("https://heymotocarro-1a1d4.firebaseio.com/");
        Graphics G;
        Rectangle[] rect = new Rectangle[6]; //6 parking slots
        Beacons BeaconsSet;
        ParkingMap ParkingMap;

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
            SolidBrush myBrush = new SolidBrush(Color.SkyBlue);
            SolidBrush myBrush2 = new SolidBrush(Color.Green);


            // Create rectangle and Draw rectangle to screen.
            //Dimensions are taken from firebase in inches

            for (int i = 0; i < 3; i++) //1st half of parking lot
            {
                rect[i] = new Rectangle(100 * i, 100, 100, 200);
                G.FillRectangle(myBrush, rect[i]);
                G.DrawRectangle(blackPen, rect[i]);
            }

            for (int j = 3; j < 6; j++) //2nd half of parking lot
            {
                rect[j] = new Rectangle(100 * k, 350, 100, 200);
                G.FillRectangle(myBrush, rect[j]);
                G.DrawRectangle(blackPen, rect[j]);
                k++;
            }

            //Update parking space rectangle color
            G.FillRectangle(myBrush2, rect[2]);
            G.FillRectangle(myBrush2, rect[5]);

            //draw parking numbers
            for (int i = 0; i < 3; i++)
            {
                 DrawStringFloatFormat((i + 1).ToString(), 100 * i + 50, 200.0F);
            }
            for (int j = 3; j < 6; j++)
            {
                DrawStringFloatFormat((j + 1).ToString(), 100 * l + 50, 450.0F);
                l++;
            }
        }
        private async void getBeaconDataAsync() // grabs population from database 
        {


            //******************** Get initial list of beacons ***********************//
            //Console.WriteLine("INITIAL TESTS\n");
            BeaconsSet = await client //Beacon BeaconSet = client
               .Child("Beacons/")//Prospect list
               .OnceSingleAsync<Beacons>();
            displayBeaconsData(BeaconsSet);


            //ParkingMap
            //  6 Data (Parking Slots)
            //      4 Position (1 point for each corner of parking slot)

            ParkingMap = await client //ParkingMap ParkingMap = client
               .Child("ParkingMap/")//Prospect list
               .OnceSingleAsync<ParkingMap>();

            var i = 1;
            foreach (var slot in ParkingMap.data) //var slot: anything, just an iterator
            {
                Console.WriteLine($"slot #{i}: { slot.position[0].x} [{ slot.position[0].y}]");
                i++;
            }


            //******************** Get changes on beacons ***********************//
            onChildChanged();


        }

        private void onChildChanged() // Waits for data base to start with variable
        {

            Console.WriteLine("Updated Beacon Data"); //Console.Writeline() had \n at end by default
            var child = client.Child("Beacons/data");
            var observable = child.AsObservable<Beacon>();
            var subscription = observable
                .Subscribe(x =>
                {
                    Console.WriteLine($"beacon id: { x.Object.Id} [{ x.Object.D1}]");                 
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

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Add User Clicked");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
