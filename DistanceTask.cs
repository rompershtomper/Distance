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
