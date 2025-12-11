using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace lab10
{
    public partial class MainWindow : Window
    {
        private Point lastPos;
        private AxisAngleRotation3D rotationX = new AxisAngleRotation3D(new Vector3D(1, 0, 0), 0);
        private AxisAngleRotation3D rotationY = new AxisAngleRotation3D(new Vector3D(0, 1, 0), 0);

        public MainWindow()
        {
            InitializeComponent();
            CreateStar();
            viewport.MouseLeftButtonDown += Viewport_MouseLeftButtonDown;
            viewport.MouseMove += Viewport_MouseMove;
        }

        private void CreateStar()
        {
            var mesh = new MeshGeometry3D();

            mesh.Positions.Add(new Point3D(0, 0, 0.5)); // 0 - центр перед
            mesh.Positions.Add(new Point3D(0, 0, -0.5)); // 1 - центр зад

            // 5 точек лучей
            for (int i = 0; i < 5; i++)
            {
                double angle = i * 72 * Math.PI / 180;
                mesh.Positions.Add(new Point3D(2.5 * Math.Sin(angle), 2.5 * Math.Cos(angle), 0));
            }

            // 5 внутренних точек
            for (int i = 0; i < 5; i++)
            {
                double angle = (i * 72 + 36) * Math.PI / 180;
                mesh.Positions.Add(new Point3D(1.0 * Math.Sin(angle), 1.0 * Math.Cos(angle), 0));
            }

            // Передняя сторона
            for (int i = 0; i < 5; i++)
            {
                AddTriangle(mesh, 0, 2 + i, 7 + i);
                AddTriangle(mesh, 0, 7 + i, 2 + (i + 1) % 5);
            }

            // Задняя сторона
            for (int i = 0; i < 5; i++)
            {
                AddTriangle(mesh, 1, 7 + i, 2 + i);
                AddTriangle(mesh, 1, 2 + (i + 1) % 5, 7 + i);
            }

            // Боковые грани лучей
            for (int i = 0; i < 5; i++)
            {
                int tip = 2 + i;
                int inner1 = 7 + i;
                int inner2 = 7 + (i + 4) % 5;
                AddTriangle(mesh, tip, 0, inner1);
                AddTriangle(mesh, tip, inner2, 1);
            }

            // Боковые грани впадин
            for (int i = 0; i < 5; i++)
            {
                int inner = 7 + i;
                AddTriangle(mesh, inner, 1, 0);
            }

            var material = new DiffuseMaterial(new SolidColorBrush(Colors.Red));
            var model = new GeometryModel3D(mesh, material) { BackMaterial = material };
            var transform = new Transform3DGroup();
            transform.Children.Add(new RotateTransform3D(rotationX));
            transform.Children.Add(new RotateTransform3D(rotationY));
            model.Transform = transform;
            starModel.Content = model;
        }

        private void AddTriangle(MeshGeometry3D mesh, int a, int b, int c)
        {
            mesh.TriangleIndices.Add(a);
            mesh.TriangleIndices.Add(b);
            mesh.TriangleIndices.Add(c);
        }

        private void Viewport_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lastPos = e.GetPosition(viewport);
            viewport.CaptureMouse();
        }

        private void Viewport_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var pos = e.GetPosition(viewport);
                rotationY.Angle += (pos.X - lastPos.X) * 0.5;
                rotationX.Angle += (pos.Y - lastPos.Y) * 0.5;
                lastPos = pos;
            }
            else
                viewport.ReleaseMouseCapture();
        }
    }
}