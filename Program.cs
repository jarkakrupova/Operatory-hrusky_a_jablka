using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HruskyAJablka {
	public class Hruska {
		private double vyska;
		public double Vyska {
			get { return vyska; }
			set { vyska = value; }
		}
		private double prumer;
		public double Prumer {
			get { return prumer; }
			set { prumer = value; }
		}
		public Hruska() { }
		public Hruska(double vyska, double prumer) {
			this.vyska = vyska;
			this.prumer = prumer;
		}
		public static explicit operator Hruska(Jablko j) {  //pretypujeme jablko na hrusku, hura!
			return new Hruska(j.Prumer, j.Vyska);
		}
		public static Hruska operator +(Jablko j, Hruska h) {
			return new Hruska(j.Vyska + h.Vyska, j.Prumer + h.Prumer);
		}
		public static Hruska operator +(Hruska h1, Hruska h2) {
			return new Hruska(h1.Vyska + h2.Vyska, h1.Prumer + h2.Prumer);
		}
	}
	public class Jablko {
		private double vyska;
		public double Vyska {
			get { return vyska; }
			set { vyska = value; }
		}
		private double prumer;

		public double Prumer {
			get { return prumer; }
			set { prumer = value; }
		}

		public Jablko() { }
		public Jablko(double vyska, double prumer) {
			this.vyska = vyska;
			this.prumer = prumer;
		}
		public static Jablko operator +(Jablko j1, Jablko j2) {
			return new Jablko(j1.Vyska + j2.Vyska, j1.Prumer + j2.Prumer);
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
		//public bool Equals(Jablko j) {
		//	bool result = false;
		//	if ((4 / 3 * Math.PI * Math.Pow(j.prumer, 3) == (4 / 3 * Math.PI * Math.Pow(this.prumer, 3)))) {
		//		result = true;
		//	}
		//	return result;
		//}
		public override bool Equals(object obj) {
			Jablko j = (Jablko)obj;
			return ((4 / 3 * Math.PI * Math.Pow(j.prumer, 3) == (4 / 3 * Math.PI * Math.Pow(this.prumer, 3))));
		}
		public static implicit operator Jablko(Hruska h) {
			return new Jablko(h.Vyska, h.Prumer);
		}
		static void Main(string[] args) {
			Jablko j1 = new Jablko(1, 5);
			Jablko j2 = new Jablko(2, 3);
			Hruska h0 = new Hruska(7, 4);
			Console.WriteLine(j1 == j2 ? "Jablka jsou stejna" : (j1 > j2 ? "Prvni jablko je vetsi" : "Druhe jablko je vetsi"));
			Hruska h1 = (Hruska)j2;
			Console.WriteLine($"Explicitni pretypovani jablka na hrusku: Hruska ma vysku {h1.Vyska} a prumer {h1.Prumer}");
			double d = 2;
			int p = (int)d;
			Console.WriteLine(j1.Equals(j2) ? "Jablka jsou stejna podle metody Equals" : "Podle metody Equals jablka nejsou stejna");
			Jablko j3 = j1 + j2;
			Console.WriteLine($"Obvod secteneho jablka je {j3.Vyska}");
			Hruska h2 = j2 + h1;
			Console.WriteLine($"Scitani jablek s hruskama dopadlo takto: Vysledna hruska ma obvod {h2.Vyska} a prumer {h2.Prumer}");
			Hruska h3 = h0 + h2;
			Console.WriteLine($"Scitani hrusek s hruskama dopadlo takto: vysledna hruska ma prumer {h3.Prumer} a vysku {h3.Vyska}");
			Jablko j4 = h0;
			Console.WriteLine($"Implicitni pretypovani vyse zminene hrusky na jablko: vysledne jablko ma obvod {j4.Vyska} a prumer {j4.Prumer}");
		}


	}
}
