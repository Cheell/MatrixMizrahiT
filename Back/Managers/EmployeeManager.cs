using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Managers
{
    public class YearManager
    {
        private static readonly sbyte monthsAmount = 12;
        private static List<Employees> GenerateRandomEmployeeData()
        {
            var result = new List<Employees>();
            for (sbyte i = 0; i < monthsAmount; i++)
            {
                Random rnd = new Random();
                result.Add(new Employees(rnd.Next(3, 50), i));
            }
            return result;
        }

        public static async Task<List<Employees>> GetEmpData() => await Task.Run(() => GenerateRandomEmployeeData());
    }
}
