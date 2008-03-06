#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 * 
 * Contributions by Georg Wächter.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Math
{
	/// <summary>
	/// Represents a bezier curve with as many points as you want.
	/// </summary>
	[Serializable]
	public struct BezierCurve
	{
		#region Fields

		private List<Vector2> points;

		/// <summary>
		/// The parallel value.
		/// </summary>
		/// <remarks>This value defines whether the curve should be calculated as a
		/// parallel curve to the original bezier curve. A value of 0.0f represents
		/// the original curve, 5.0f i.e. stands for a curve that has always a distance
		/// of 5.0f to the orignal curve at any point.</remarks>
		public float Parallel;

		#endregion

		#region Properties

		/// <summary>
		/// Gets the points of this curve.
		/// </summary>
		/// <remarks>The first point and the last points represent the anchor points.</remarks>
		public IList<Vector2> Points
		{
			get 
			{ 
				return points; 
			}
			set
			{
				if (value != null)
					points = (List<Vector2>)value;
			}
		}

		#endregion

		#region Constructors

		/// <summary>
		/// Constructs a new <see cref="BezierCurve"/>.
		/// </summary>
		/// <param name="points">The points.</param>
		public BezierCurve(IEnumerable<Vector2> points)
		{
			if (points == null)
				throw new ArgumentNullException("points", "Must point to a valid list of Vector2 structures.");

			this.points = new List<Vector2>(points);
			this.Parallel = 0.0f;
		}

		/// <summary>
		/// Constructs a new <see cref="BezierCurve"/>.
		/// </summary>
		/// <param name="points">The points.</param>
		public BezierCurve(params Vector2[] points)
		{
			if (points == null)
				throw new ArgumentNullException("points", "Must point to a valid list of Vector2 structures.");

			this.points = new List<Vector2>(points);
			this.Parallel = 0.0f;
		}

		/// <summary>
		/// Constructs a new <see cref="BezierCurve"/>.
		/// </summary>
		/// <param name="parallel">The parallel value.</param>
		/// <param name="points">The points.</param>
		public BezierCurve(float parallel, params Vector2[] points)
		{
			if (points == null)
				throw new ArgumentNullException("points", "Must point to a valid list of Vector2 structures.");

			this.Parallel = parallel;
			this.points = new List<Vector2>(points);
		}

		/// <summary>
		/// Constructs a new <see cref="BezierCurve"/>.
		/// </summary>
		/// <param name="parallel">The parallel value.</param>
		/// <param name="points">The points.</param>
		public BezierCurve(float parallel, IEnumerable<Vector2> points)
		{
			if (points == null)
				throw new ArgumentNullException("points", "Must point to a valid list of Vector2 structures.");

			this.Parallel = parallel;
			this.points = new List<Vector2>(points);
		}

		#endregion

		#region Functions

		/// <summary>
		/// Calculates the point with the specified t.
		/// </summary>
		/// <param name="t">The t value, between 0.0f and 1.0f.</param>
		/// <returns>Resulting point.</returns>
		public Vector2 CalculatePoint(float t)
		{
			Vector2 r = new Vector2();
			double c = 1.0d - (double)t;
			float temp;
			int i = 0;

			foreach (Vector2 pt in points)
			{
				temp = (float)Functions.BinomialCoefficient(points.Count - 1, i) * (float)(System.Math.Pow((double)t, (double)i) *
						System.Math.Pow(c, (double)(points.Count - 1) - (double)i));

				r.X += temp * pt.X;
				r.Y += temp * pt.Y;
				i++;
			}

			if (Parallel == 0.0f)
				return r;

			Vector2 perpendicular = new Vector2();
			
			if (t != 0.0f)
				perpendicular = r - CalculatePointOfDerivative(t);
			else
				perpendicular = points[1] - points[0];

			perpendicular.Normalize();
			perpendicular = perpendicular.Perpendicular;

			return r + perpendicular * Parallel;
		}

		/// <summary>
		/// Calculates the point with the specified t of the derivative of this function.
		/// </summary>
		/// <param name="t">The t, value between 0.0f and 1.0f.</param>
		/// <returns>Resulting point.</returns>
		private Vector2 CalculatePointOfDerivative(float t)
		{
			Vector2 r = new Vector2();
			double c = 1.0d - (double)t;
			float temp;
			int i = 0;

			foreach (Vector2 pt in points)
			{
				temp = (float)Functions.BinomialCoefficient(points.Count - 2, i) * (float)(System.Math.Pow((double)t, (double)i) *
						System.Math.Pow(c, (double)(points.Count - 2) - (double)i));

				r.X += temp * pt.X;
				r.Y += temp * pt.Y;
				i++;
			}

			return r;
		}

		/// <summary>
		/// Calculates the length of this bezier curve.
		/// </summary>
		/// <param name="precision">The precision.</param>
		/// <returns>Length of curve.</returns>
		/// <remarks>The precision gets better as the <paramref name="precision"/>
		/// value gets smaller.</remarks>
		public float CalculateLength(float precision)
		{
			float length = 0.0f;
			Vector2 old = CalculatePoint(0.0f);

			for (float i = precision; i < (1.0f + precision); i += precision)
			{
				Vector2 n = CalculatePoint(i);
				length += (n - old).Length;
				old = n;
			}
			
			return length;
		}

		#endregion
	}
}
