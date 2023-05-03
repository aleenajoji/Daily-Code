using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFlowerPetel
{
    internal class Flower
    {
		private string _flowerNmae;

		public string FlowerName
		{
			get { return _flowerNmae; }
			set { _flowerNmae = value; }
		}
		private int _petelNo;

		public int PetelNo
		{
			get { return _petelNo; }
			set { _petelNo = value; }
		}

		public Flower() { }
		public Flower(string flowerName,int petelNo) { 
			_petelNo = petelNo;
			_flowerNmae = flowerName;
		}

	}
}
