using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HruskyAJablka {
    class Hruska {
        private double obvod;
        public double Obvod {
            get { return obvod; }
            set { obvod = value; } 
        }
        private double prumer;
        public double Prumer {
            get { return prumer; }
            set { prumer = value; }
        }
        public Hruska() { }
        public Hruska(double obvod, double prumer) {
            this.obvod = obvod;
            this.prumer = prumer;
        }
        public static explicit operator Hruska(Jablko j) {  //pretypujeme jablko na hrusku, hura!
            return new Hruska(j.Prumer, j.Obvod);
        }
    }
    public class Jablko {
        private double obvod;
        public double Obvod {
            get { return obvod; }
            set { obvod = value; }
        }
        private double prumer;
        
        public double Prumer {
            get { return prumer; }
            set { prumer = value; }
        }

        public Jablko() { }
        public Jablko(double obvod, double prumer) {
            this.obvod = obvod;
            this.prumer = prumer;
        }
        //4/3 π × r³
        public static bool operator ==(Jablko j1, Jablko j2) {
            if ((4 / 3 * Math.PI * Math.Pow(j1.prumer, 3)) == (4 / 3 * Math.PI * Math.Pow(j2.prumer, 3))) {
                return true;
            }
            else {
                return false;
            }
        }
        //4/3 π × r³
        public static bool operator !=(Jablko j1, Jablko j2) {
            if ((4 / 3 * Math.PI * Math.Pow(j1.prumer, 3)) != (4 / 3 * Math.PI * Math.Pow(j2.prumer, 3))) {
                return true;
            }
            else {
                return false;
            }
        }
        public static bool operator >(Jablko j1, Jablko j2) {
            if ((4 / 3 * Math.PI * Math.Pow(j1.prumer, 3)) > (4 / 3 * Math.PI * Math.Pow(j2.prumer, 3))) {
                return true;
            }
            else {
                return false;
            }
        }
        public static bool operator <(Jablko j1, Jablko j2) {
            if ((4 / 3 * Math.PI * Math.Pow(j1.prumer, 3)) < (4 / 3 * Math.PI * Math.Pow(j2.prumer, 3))) {
                return true;
            }
            else {
                return false;
            }
        }
        public bool Equals(Jablko j) {
            bool result = false;
            if ((4 / 3 * Math.PI * Math.Pow(j.prumer, 3) == (4 / 3 * Math.PI * Math.Pow(this.prumer, 3)))) {
                result = true;
            }
            return result;
        }
        public override bool Equals(object obj) {
            Jablko j = (Jablko)obj;
            return ((4 / 3 * Math.PI * Math.Pow(j.prumer, 3) == (4 / 3 * Math.PI * Math.Pow(this.prumer, 3))));
        }
        static void Main(string[] args) {
            Jablko j1 = new Jablko(2, 2);
            Jablko j2 = new Jablko(2, 3);
            Console.WriteLine(j1 == j2 ? "Jablka jsou stejna" : (j1 > j2 ? "Prvni jablko je vetsi" : "Druhe jablko je vetsi"));
            Hruska h1 = (Hruska)j2;
            Console.WriteLine(h1.Obvod);
            double d = 2;
            int p = (int)d;
            Console.WriteLine(j1.Equals(j2) ? "Jablka jsou stejna podle metody Equals" : "Podle metody Equals jablka nejsou stejna");
        }


    }
}
