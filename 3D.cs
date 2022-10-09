using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ComGraph_Lab_5
{
    class PointF3D
    {
        public PointF3D(float _x, float _y, float _z, float _h)
        {
            x = _x;
            y = _y;
            z = _z;
            h = _h;
        }
        public PointF3D()
        {
            x = float.NaN;
            y = float.NaN;
            z = float.NaN;
            h = float.NaN;
        }
        public PointF3D Clone()
        {
            float newX = x;
            float newY = y;
            float newZ = z;
            float newH = h;

            return new PointF3D(newX, newY, newZ, newH);
        }
        public float x;
        public float y;
        public float z;
        public float h;

        public PointF getFrontProjection()
        {
            return new PointF(x, y);
        }

        #region перегрузка операторов
        public static PointF3D operator /(PointF3D a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return new PointF3D(a.x / b, a.y / b, a.z / b, a.h / b);
        }

        public static PointF3D operator *(PointF3D a, float b)
        {
            return new PointF3D(a.x * b, a.y * b, a.z * b, a.h);
        }

        public float this[int index]
        {
            get
            {
                if (index == 0)
                    return x;
                if (index == 1)
                    return y;
                if (index == 2)
                    return z;
                if (index == 3)
                    return h;

                throw new IndexOutOfRangeException();
            }

            set
            {
                if (index == 0)
                {
                    x = value;
                    return;
                }
                if (index == 1)
                {
                    y = value;
                    return;
                }
                if (index == 2)
                {
                    z = value;
                    return;
                }
                if (index == 3)
                {
                    h = value;
                    return;
                }

                throw new IndexOutOfRangeException();
            }
        }
        #endregion

        // скаялярное умножение
        public void dot(float[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 4)
            {
                throw new InvalidOperationException();
            }

            PointF3D result = new PointF3D(0, 0, 0, 0);

            for (int i = 0; i < m.Length; ++i)
            {
                result.x += x * m[0, i];
                result.y += y * m[1, i];
                result.z += z * m[2, i];
                result.h += h * m[3, i];

                result /= result.h;
            }
            x = result.x;
            y = result.y;
            z = result.z;
            h = result.h;
        }

    }

    class VectorF3D
    {
        public PointF3D[] vector;
        public int Length = 0;

        public VectorF3D(float[,] _m)
        {
            Length = _m.GetLength(0);
            vector = new PointF3D[Length];
            for (int i = 0; i < Length; ++i)
            {
                vector[i] = new PointF3D(_m[i, 0], _m[i, 1], _m[i, 2], _m[i, 3]);
            }
        }
        public VectorF3D(PointF3D[] points)
        {
            Length = points.Length;
            vector = points;
        }
        public VectorF3D Clone()
        {
            PointF3D[] newPoints = new PointF3D[Length];
            for (int i = 0; i < Length; ++i)
            {
                newPoints[i] = vector[i].Clone();
            }

            return new VectorF3D(newPoints);
        }
        public PointF[] getPoint2D()
        {
            PointF[] points2D = new PointF[Length];

            for (int i = 0; i < Length; ++i)
            {
                points2D[i] = new PointF(vector[i].x, vector[i].y);
            }
            return points2D;
        }

        // перегрузка оператора
        public PointF3D this[int index]
        {
            get
            {
               return vector[index];
            }

            set
            {
                vector[index] = value;
            }
        }

        public static VectorF3D operator *(VectorF3D a, float b)
        {
            PointF3D[] newPoints = new PointF3D[a.Length];

            for (int i = 0; i < a.Length; ++i)
            {
                newPoints[i] = a[i].Clone() * b;
            }

            VectorF3D newVector = new VectorF3D(newPoints);

            return newVector;
        }

        // сскалярное умножение
        public void dot(float[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 4)
            {
                throw new InvalidOperationException();
            }

            VectorF3D result = new VectorF3D(new float[Length, 4]);

            for (int r = 0; r < Length; ++r)
            {
                for (int c = 0; c < 4; ++c)
                {
                    result[r][c] = 0;
                    for (int k = 0; k < 4; ++k)
                    {
                        float tmp1 = vector[r][k];
                        float tmp2 = m[k, c];
                        float tmp = vector[r][k] * m[k, c];
                        result[r][c] += vector[r][k] * m[k, c];
                    }
                }
                if (result[r].h == 0)
                    result[r].h = 1;
                else
                    result[r] /= result[r].h;
            }
            vector = result.vector;
            Length = result.Length;
        }

    }
}
