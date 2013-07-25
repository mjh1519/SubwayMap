using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayMap 
{
    class Subway 
    {
        private int numtotal = 0;

        public int calculation(int start, int end, int[] num)
        {
            for (int k = start; k < end; k++)
            {
                numtotal += num[k];
            }
            return numtotal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> dic = new Dictionary<String, int>();
            dic["영등포구청"] = 6;
            dic["당산"] = 4;
            dic["합정"] = 3;
            dic["홍대입구"] = 4;
            dic["충정로"] = 5;

            Dictionary<String, int> dic1 = new Dictionary<String, int>();
            dic1["영등포구청"] = 1;
            dic1["당산"] = 2;
            dic1["합정"] = 3;
            dic1["홍대입구"] = 4;
            dic1["충정로"] = 5;

            Subway sub = new Subway();
            int[] num = new int[5];
            String[] name = new String[5];

            String start, end;

            Console.WriteLine("2호선 지하철");
            Console.Write("출발역 : ");
            start = Console.ReadLine();
            Console.Write("도착역 : ");
            end = Console.ReadLine();

            int k = 0;

            foreach (KeyValuePair<string, int> d in dic)
            {
                for (int j = k; j < k + 1; j++)
                {
                    num[j] = d.Value;
                    name[j] = d.Key;
                }
                k++;
            }
            Console.WriteLine(sub.calculation(dic1[start], dic1[end], num));
        }
    }
}
