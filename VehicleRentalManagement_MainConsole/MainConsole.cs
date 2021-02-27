using System;
using VehicleRentalManagement_DataAccessLayer;

namespace VehicleRentalManagement_MainConsole
{
    class MainConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VehicleDAL da = new VehicleDAL();
            da.connectionTest();
        }
    }
}
