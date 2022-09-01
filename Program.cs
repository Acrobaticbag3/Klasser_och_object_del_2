using System;
using System.Collections.Generic;

namespace Klasser_och_object_del_2 {
    internal class Program {
       static void Main(String[] args) {
            int menyVal = 1;

            while (menyVal != 0) {
                Console.WriteLine("Car_register_List");
            }
            Car c = new Car("Stellantis", "500X Dolcevita", 2021, 5000); // Car object one aka c. Stores info about the car and tillverkare.
            Car a = new Car("BMW Group", "BMW X7", 2004, 5600); // Car object two aka a. Stores info about the car and tillverkare.

            List<Car> carList = new List<Car>();
            carList.Add(c);
            carList.Add(a);

            foreach(Car element in carList){ // Prints out all car elements from "carList".
                Console.WriteLine("========================");

                Console.WriteLine(element.Tillverkare);
                Console.WriteLine(element.Modell);
                Console.WriteLine(element.Årsmodell);
                Console.WriteLine(element.Vikt);

                Console.WriteLine("========================");
            }

          Console.ReadKey();
       }

        class Car { // A secure encapulation method that the Car objects can use to set and get thair variabels.
            private string tillverkare;
            private string modell; 
            private int årsmodell; 
            private int vikt;

            public string Tillverkare{
                get { return tillverkare; }
                set { tillverkare = value; }
            }

            public string Modell{
                get { return modell; }
                set { modell = value; }
            }

            public int Årsmodell{
                get { return årsmodell; }
                set { årsmodell = value; }
            }

            public int Vikt{
                get { return vikt; }
                set { vikt = value; }
            }
            public Car(string t, string m, int å, int v) {
                tillverkare = t;
                modell = m;
                årsmodell = å;
                vikt = v;
            }
        }

        class CarList {
            
        }
    } 
}


