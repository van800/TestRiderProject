

//using NUnit.Framework;
using UnityEngine;

namespace UGS.vrtoy.toys.orrery {
	public struct Star {

		internal const string TableName = "constellations";

		internal const string AsClause = "id AS Id, con AS Con, ra AS RA, dec AS Dec, mag AS Mag";

		public const float RAToDegrees = 360f / 24f;

		public int Id { get; set; }

		public string Con { get; set; }

		public float RA { get; set; }

		public float Dec { get; set; }

		public float Mag { get; set; }

		public bool isPenUp { get { return 0f == RA && 0f == Dec; } }

		public float yRotDegrees { get { return RA * RAToDegrees; } }

		public float xRotDegrees { get { return Dec; } } // already in degrees

		public Quaternion rotation { get { return Quaternion.Euler(-xRotDegrees, -yRotDegrees, 0f); } }

		public int sectorNum {
			get {
				const int MaxU = 1;
				const int Divisor = 360 / MaxU; // half at top, half at bottom
				int u = (int) xRotDegrees / Divisor;
				int v = (int) yRotDegrees / 180; // divide top-bottom
//				Assert.IsTrue(0 <= v && v < 2, "{0} v:{1} out of range", this, v);
//				Assert.IsTrue(0 <= u && u < MaxU, "{0} u:{1} out of range", this, u);
				int sectorNum = u + v * MaxU;
//				Assert.IsTrue(0 <= sectorNum && sectorNum < 1, "{0}.sectorNum:{1} out of range (calculated from u:{2} & v:{3})", this, sectorNum, u, v);
				return sectorNum;
			}
		}

		public Vector3 plotVector3(float radius) {
			return rotation * new Vector3(0f, 0f, radius);
		}

		public override string ToString() {
			return string.Format("{0}(Id:{1}, Con:\"{2}\", RA:{3}, Dec:{4}, Mag:{5})", typeof (Star).Name, Id, Con, RA, Dec, Mag);
		}

	}
}
