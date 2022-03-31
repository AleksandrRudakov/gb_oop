using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_4_library
{
    public class Creator
    {
        //private Dictionary<int, Building> _data = new Dictionary<int, Building>();
        private static Hashtable hashtable = new Hashtable();
        public static Hashtable Hashtable { get { return hashtable; } set { hashtable = value; } }
        public static Building CreateBuild()
        {
            Building n = new Building();
            hashtable.Add(n.Number, n);
            return n;
        }
        public static Building CreateBuild(int height, int floor, int flat, int entrance)
        {
            Building n = new Building(height, floor, flat, entrance);
            hashtable.Add(n.Number, n);
            return n;
        }
        private Creator()
        {
            hashtable = new Hashtable();
        }

        public static bool DeleteBuild(int id)
        {
            try
            {
                hashtable.Remove(id);
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
            return true;
        }
    }
}
