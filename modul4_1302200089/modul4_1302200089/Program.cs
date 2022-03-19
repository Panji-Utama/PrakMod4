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
            SimpleDataBase<int> simpleData = new SimpleDataBase<int>();
            simpleData.AddNewData(13);
            simpleData.AddNewData(02);
            simpleData.AddNewData(20);


            simpleData.PrintData();
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
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + i + " berisi : " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            }

        }
    }


}
