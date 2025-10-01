using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace lab5
{
    public delegate void CircularMotionEventHandler(object sender, CircularMotionEventArgs e);

    public class CircularMotionEventArgs: EventArgs
    {
        public Point Center { get; }
        public int Radius { get; }
        public CircularMotionEventArgs(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }
    }
    public class CircularMotionDetector : Component
    {
        private List<Point> points = new List<Point> ();
        private const int minPoints = 100;
        private const int maxPoints = 200;
        private const double circularityThreshold = 0.8;

        public event CircularMotionEventHandler CircularMotionDetected;

        public void AddPoint(Point point)
        { 
            points.Add(point);

            if (points.Count > maxPoints)
            { 
                points.RemoveAt(0);
            }
            if (points.Count == maxPoints)
            {
                checkCircularMotion();
            }
            
        }

        private void checkCircularMotion()
        {
            if (isCircularMotion(out Point center, out int radius))
            {
                CircularMotionDetected?.Invoke(this, new CircularMotionEventArgs(center, radius));
                points.Clear();
            } 
        }

        private bool isCircularMotion(out Point center, out int radius) 
        {
            center = getCentroid();
            var distances = new List<double> ();

            foreach (var point in points)
            {
                double distance = Math.Sqrt(Math.Pow(point.X - center.X, 2) + Math.Pow(point.Y - center.Y, 2));
                distances.Add(distance);
            }

            double avgDistance = distances.Sum()/distances.Count;
            radius = (int)avgDistance;

            double variance = distances.Sum(d => Math.Pow(d - avgDistance, 2)) / distances.Count;
            double circularity = 1.0 - (variance / (avgDistance * avgDistance));
            bool fullCircle = CheckFullCircle(center);

            return circularity > circularityThreshold && radius > 10 && fullCircle;
        }

        private bool CheckFullCircle(Point center)
        {
            var angles = new List<double>();
            foreach (var point in points)
            {
                double angle = Math.Atan2(point.Y - center.Y, point.X - center.X);
                if (angle < 0) angle += 2 * Math.PI; 
                angles.Add(angle);
            }

            angles.Sort();

            double maxGap = 0;
            for (int i = 0; i < angles.Count - 1; i++)
            {
                double gap = angles[i + 1] - angles[i];
                if (gap > maxGap) maxGap = gap;
            }

            double wrapGap = (angles[0] + 2 * Math.PI) - angles[angles.Count - 1];
            if (wrapGap > maxGap) maxGap = wrapGap;

            return maxGap < Math.PI / 2;
        }

        private Point getCentroid()
        {
            int x = points.Sum (p => p.X)/points.Count;
            int y = points.Sum (p => p.Y)/points.Count;

            return new Point (x, y);
        }
    }
}
