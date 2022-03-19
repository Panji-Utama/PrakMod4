using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200089
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NIM : 1302200089
            Console.WriteLine("Hasil Penjumlahan 3 angka: " + Penjumlahan.JumlahTigaAngka<long>(13, 02, 20));

            Console.WriteLine("\n");

            SimpleDataBase<long> simpleData = new SimpleDataBase<long>();
            simpleData.AddNewData(13);
            simpleData.AddNewData(02);
            simpleData.AddNewData(20);


            simpleData.PrintData();
        }
    }

    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T satu, T dua, T tiga)
        {
            dynamic A = satu;
            dynamic B = dua;
            dynamic C = tiga;
            //Console.WriteLine(satu + "" + dua + ""  + tiga);
            return A + B + C;
        }
    }

    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates; 
        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T x)
        {
            storedData.Add(x);
            inputDates.Add(DateTime.UtcNow);
        }

        public void PrintData()
        {
            int panjang = storedData.Count;
            for (int i = 0; i < panjang; i++)
            {
                Console.WriteLine("Data " + (i+1) + " berisi : " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            }

        }
    }


}
