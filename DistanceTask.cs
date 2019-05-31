using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
            double xa = Math.Sqrt((ax - x)* (ax - x) + (ay - y)* (ay - y));//вектор из точки x в точку a
            double xb = Math.Sqrt((bx - x)* (bx - x) + (by - y)* (by - y));//вектор из точки x в точку b
            double ab = Math.Sqrt((bx - ax)* (bx - ax) + (by - ay)* (by - ay));//вектор из точки a в точку b

            double angleA = Math.Acos((xa*xa + ab*ab - xb*xb) / (2 * xa * ab));//угол между сторонами ax и ab
            double angleB = Math.Acos((xb*xb + ab*ab - xa*xa) / (2 * xb * ab));//угол между сторонами ba и bx

            double halfPerimetr = (xa + xb + ab) / 2;
            double square = Math.Sqrt(halfPerimetr * (halfPerimetr - xa) * (halfPerimetr - xb) * (halfPerimetr - ab));

            if ((xa+xb)==ab)
                return 0.00;
            if ((angleA <= 1.57) && (angleB <= 1.57))
                return (square * 2) / ab;
            return Math.Min(xa, xb);
        }
	}
}



//return (Math.Abs((by-ay)*x-(bx-ax)*y+bx*ay-by*ax))/Math.Sqrt(Math.Pow(by-ay,2)+Math.Pow(bx-ax,2));

//return Math.Abs((ay - by) * x + (bx - ax) * y + (ax * by - bx * ay)) / Math.Sqrt(Math.Pow(by - ay, 2) + Math.Pow(bx - ax, 2));

//if (((xa + xb) > (ab * xb + ab)) && ((ab * xb + ab) > (xa * xa + ab)) && ((xa * xa + ab) > xb))
