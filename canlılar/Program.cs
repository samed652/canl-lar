using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canlılar
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Canli
    {
        public string beslenme { get; set; }
        public string nefes { get; set; }
    }
    public class Hayvan : Canli
    {
        public string hareket{ get; set; }
    }
    public class Kopek : Hayvan
    {
        public string havlamak { get; set; }
    }
    public class Kangal : Kopek
    {
        public string guclu { get; set; }
    }
}
