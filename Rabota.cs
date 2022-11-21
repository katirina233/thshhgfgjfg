using System.Runtime.InteropServices;
using System;

namespace Dll_prac
{
    public class Rabota
    {
        string name;
        public Rabota(string name)
        {
            this.name = name;
        }
        public void Print() => Console.WriteLine($"Name: {name}");
    }
}