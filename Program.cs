using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            var sites = int.Parse(Console.ReadLine());
            var securityKey = int.Parse(Console.ReadLine());
            
            var list = new List<string>();
            decimal sum=0;
            for (int i = 0; i < sites; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToList();
                list.Add(input[0]);
                var visits = uint.Parse(input[1]);
                var PriceForVisit = decimal.Parse(input[2]);
                sum += visits * PriceForVisit;
                   
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Total Loss: {0:f20}",sum);
            BigInteger securityToken = 1;
            for (int i = 0; i < sites; i++)
            {
                securityToken *= securityKey ;
            }
            Console.WriteLine("Security Token: {0}",securityToken);
        }
    }
}

