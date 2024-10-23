using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                DoTask();
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
			finally { Console.ReadLine(); }
        }

        private static void DoTask()
        {
            Console.WriteLine("How many times you want to do the operation?");
            int count=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Select Operation\n1 ---Car\n2 ---Motor Cycle");
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        PrintCar();
                        break;
                    case 2:
                        PrintMotorCycle();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
            }
            

            
        }

        private static void PrintMotorCycle()
        {
            string brand = "Yamaha";
            string model = "R-15";
            int yearmake = 2022;
            int engine = 160;
            int gear = 6;
            double maximumPowerinBPH=14.04;
            int maximumTorqueinNM=27;
            int mileageinKMPL=50;
            string frontBrake="Hard Break";
            string rearBrake="Light Break";
            VehicleType vehicleType = VehicleType.Personal;
            MotorCycle cycle=new MotorCycle(brand,model,yearmake,gear,engine, vehicleType, maximumPowerinBPH,maximumTorqueinNM,mileageinKMPL,frontBrake,rearBrake);
            
            cycle.GetDetails();
            string start = cycle.StartMethod("Bruhm.. ");
            Console.WriteLine(start);
            string cooling = cycle.Cooling("Cooling Essential");
            Console.WriteLine(cooling);
            Console.WriteLine();
            Console.WriteLine("Exterior Design");
            Console.WriteLine("-----------------");
            string[] extDesdign = cycle.GetExteriorDesign("Sticker, Hydrolic Whistle, Mobile stand, Cover");
            for (int i = 0; i < extDesdign.Length;i++)
            {
                Console.WriteLine((i+1).ToString()+". "+ extDesdign[i]);
            }

        }

        private static void PrintCar()
        {
           
            string brand = "Suzuki";
            string model = "Maruti-800";
            int yearmake = 2000;
            int engine = 800;
            int gear = 5;
            int door = 4;
            int seat = 4;
            VehicleType type = VehicleType.Personal;
            Car car = new Car(brand, model, yearmake, gear, engine, type, seat, door);
            car.GetDetails();
            string[] carDesign = car.GetInteriorDesign("TissueBox,Chanachur,Airfreshner, Pillow, Boat");
            for (int i = 0; i < carDesign.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + "." + carDesign[i].Trim());
            }
        }
    }
}
