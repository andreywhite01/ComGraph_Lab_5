using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComGraph_Lab_5
{
    
    class Figure
    {
        const int NUMBER_OF_VERTIX = 8;
        const int DIMENSION = 4;
        public Figure()
        {
            // задаем начальные координаты точек фигуры
            float[] x = new float[NUMBER_OF_VERTIX] { 0.0f, 4.0f, 2.0f, 0.5f, 0.0f, 4.0f, 2.0f, 0.5f };
            float[] y = new float[NUMBER_OF_VERTIX] { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 3.0f, 1.5f, 1.0f };
            float[] z = new float[NUMBER_OF_VERTIX] { 0.0f, 0.0f, 1.0f, 1.0f, 0.0f, 0.0f, 1.0f, 1.0f };

            points = new VectorF3D(new PointF3D[NUMBER_OF_VERTIX]);
            defaultPoints = new VectorF3D(new PointF3D[NUMBER_OF_VERTIX]);
            float scaleCoef = 50.0f;

            for (int i = 0; i < NUMBER_OF_VERTIX; ++i)
            {
                points[i] = new PointF3D(x[i], -y[i], z[i], 1.0f) * scaleCoef;
                defaultPoints[i] = new PointF3D(x[i], -y[i], z[i], 1.0f) * scaleCoef;
            }
            setFaces();
            makePerspective();
        }

        #region переменные
        private VectorF3D points;
        private VectorF3D defaultPoints;
        private VectorF3D[] faces = new VectorF3D[6];
        private PointF[,] faces2D;

        private bool directP = true;
        private bool onePointP = false;
        private bool kavalieP = false;
        private bool kabineP = false;
        private bool ortoP = false;
        #endregion

        #region пользовательский интерфейс
        public void setDefault()
        {
            points = defaultPoints.Clone();
            setFaces();
        }
        public void rotate(char axis, float a)
        {
            switch (axis)
            {
                case 'x':
                    {
                        //rotate_x = a;
                        rotateX(a);
                        break;
                    }
                case 'y':
                    {
                        //rotate_y = a;
                        rotateY(a);
                        break;
                    }
                case 'z':
                    {
                        //rotate_z = a;
                        rotateZ(a);
                        break;
                    }
                default:
                    break;
            }
        }
        public void scale(char axis, float k)
        {
            switch (axis)
            {
                case 'x':
                    {
                        scaleX(k);
                        break;
                    }
                case 'y':
                    {
                        scaleY(k);
                        break;
                    }
                case 'z':
                    {
                        scaleZ(k);
                        break;
                    }
                case 'a':
                    {
                        scaleAll(k);
                        break;
                    }
                default:
                    break;
            }
        }
        public void move(char axis, float step)
        {
            switch (axis)
            {
                case 'x':
                    {
                        moveX(step);
                        break;
                    }
                case 'y':
                    {
                        moveY(step);
                        break;
                    }
                case 'z':
                    {
                        moveZ(step);
                        break;
                    }
                default:
                    break;
            }
        }
        public void reflect(char axis)
        {
            switch (axis)
            {
                case 'x':
                    {
                        reflectX();
                        break;
                    }
                case 'y':
                    {
                        reflectY();
                        break;
                    }
                case 'z':
                    {
                        reflectZ();
                        break;
                    }
                default:
                    break;
            }
            setFaces();
        }

        public void set_DirectPerspective()
        {
            offCheckedPerspective();
            directP = true;
        }
        public void set_OnePointPerspective()
        {
            offCheckedPerspective();
            onePointP = true;
        }
        // косоугольные проекции
        public void set_KavaliePerspective()
        {
            offCheckedPerspective();
            kavalieP = true;
        }
        public void set_KabinePerspective()
        {
            offCheckedPerspective();
            kabineP = true;
        }
        public void set_OrtoPerspective()
        {
            offCheckedPerspective();
            ortoP = true;
        }

        public PointF[,] getFacesPerspective()
        {
            makePerspective();
            return faces2D;
        }
        #endregion

        // обновление полигонов фигуры
        private void setFaces()
        {
            faces[0] = new VectorF3D(new PointF3D[DIMENSION] { points[0], points[1], points[2], points[3] });
            faces[1] = new VectorF3D(new PointF3D[DIMENSION] { points[4], points[5], points[6], points[7] });
            faces[2] = new VectorF3D(new PointF3D[DIMENSION] { points[0], points[1], points[5], points[4] });
            faces[3] = new VectorF3D(new PointF3D[DIMENSION] { points[2], points[3], points[7], points[6] });
            faces[4] = new VectorF3D(new PointF3D[DIMENSION] { points[0], points[3], points[7], points[4] });
            faces[5] = new VectorF3D(new PointF3D[DIMENSION] { points[1], points[2], points[6], points[5] });
        }

        #region вращение вокруг осей
        private void rotateX(float a)
        {
            float[,] rotateMatrix = new float[,] {
                { 1, 0,                     0,                  0 },
                { 0, (float)Math.Cos(a),    (float)Math.Sin(a), 0 },
                { 0, -(float)Math.Sin(a),   (float)Math.Cos(a), 0 },
                { 0, 0,                     0,                  1 }
            };
            points.dot(rotateMatrix);
            setFaces();
        }
        private void rotateY(float a)
        {
            float[,] rotateMatrix = new float[,] {
                { (float)Math.Cos(a),   0, -(float)Math.Sin(a), 0 },
                { 0,                    1, 0,                   0 },
                { (float)Math.Sin(a),   0, (float)Math.Cos(a),  0 },
                { 0,                    0, 0,                   1 }
            };
            points.dot(rotateMatrix);
            setFaces();
        }
        private void rotateZ(float a)
        {
            float[,] rotateMatrix = new float[,] {
                { (float)Math.Cos(a),   (float)Math.Sin(a), 0,  0 },
                { -(float)Math.Sin(a),  (float)Math.Cos(a), 0,  0 },
                { 0,                    0,                  1,  0 },
                { 0,                    0,                  0,  1 }
            };
            points.dot(rotateMatrix);
            setFaces();
        }
        #endregion

        #region масштабирование
        private void scaleX(float k)
        {
            float[,] scaleMatrix = new float[,] {
                { k, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };
            points.dot(scaleMatrix);
        }
        private void scaleY(float k)
        {
            float[,] scaleMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, k, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };
            points.dot(scaleMatrix);
        }
        private void scaleZ(float k)
        {
            float[,] scaleMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, k, 0 },
                { 0, 0, 0, 1 }
            };
            points.dot(scaleMatrix);
        }
        private void scaleAll(float k)
        {
            float[,] scaleMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 / k }
            };
            points.dot(scaleMatrix);
        }
        #endregion

        #region перенос
        private void moveX(float k)
        {
            float[,] moveMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { k, 0, 0, 1 }
            };
            points.dot(moveMatrix);
        }
        private void moveY(float k)
        {
            float[,] moveMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, k, 0, 1 }
            };
            points.dot(moveMatrix);
        }
        private void moveZ(float k)
        {
            float[,] moveMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, k, 1 }
            };
            points.dot(moveMatrix);
        }
        #endregion

        #region отражение
        private void reflectX()
        {
            float[,] reflectMatrix = new float[,] {
                { -1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };
            points.dot(reflectMatrix);
        }
        private void reflectY()
        {
            float[,] reflectMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, -1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };
            points.dot(reflectMatrix);
        }
        private void reflectZ()
        {
            float[,] reflectMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, -1, 0 },
                { 0, 0, 0, 1 }
            };
            points.dot(reflectMatrix);
        }
        #endregion

        #region перспективные преобразования
        private void makePerspective()
        {
            setFaces();
            if (directP)
            {
                apply_DirectPerspective();
                return;
            }
            if (onePointP)
            {
                apply_OnePointPerspective();
                return;
            }
            if (kavalieP)
            {
                apply_KavaliePerspective();
                return;
            }
            if (kabineP)
            {
                apply_KabinePerspective();
                return;
            }
            if (ortoP)
            {
                apply_OrtoPerspective();
                return;
            }
        }

        // отключаем перспективу
        private void offCheckedPerspective()
        {
            directP = false;
            onePointP = false;
            kavalieP = false;
            kabineP = false;
            ortoP = false;
        }

        // находим конкретную перспективу и проецируем на плоскость z=0
        private void set2DFaces(VectorF3D[] faces, float[,] perspectiveMatrix)
        {
            for (int i = 0; i < 6; ++i)
            {
                faces[i].dot(perspectiveMatrix);
                for (int j = 0; j < 4; ++j)
                {
                    faces2D[i, j] = faces[i].getPoint2D()[j];
                }
            }
        }

        // применяем перспективное отображение ко всем точкам фигуры
        private void applyPerspective(float[,] perspectiveMatrix)
        {
            faces2D = new PointF[6, 4];
            VectorF3D[] newFaces = new VectorF3D[6];
            for (int i = 0; i < 6; ++i)
            {
                newFaces[i] = faces[i].Clone();
            }
            set2DFaces(newFaces, perspectiveMatrix);
        }

        // инициализируем матрицы преобразования для перспективного отображения и применяем ее
        private void apply_DirectPerspective()
        {
            float[,] perspectiveMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 1 }
            };
            applyPerspective(perspectiveMatrix);
        }
        private void apply_OnePointPerspective()
        {
            float r = -0.001f;
            float[,] perspectiveMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, r },
                { 0, 0, 0, 1 }
            };
            applyPerspective(perspectiveMatrix);
        }
        // косоугольные проекции
        private void apply_ObliquePerspective(float l, float alpha)
        {
            float[,] perspectiveMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                {l * (float)Math.Cos(alpha), l * (float)Math.Sin(alpha), 0, 0 },
                { 0, 0, 0, 1 }
            };
            applyPerspective(perspectiveMatrix);
        }
        private void apply_KavaliePerspective()
        {
            float l = 1.0f;
            float alpha = (float)Math.PI / 4.0f;
            apply_ObliquePerspective(l, alpha);
        }
        private void apply_KabinePerspective()
        {
            float l = 1/2.0f;
            float alpha = (float)Math.Atan(2);
            apply_ObliquePerspective(l, alpha);
        }
        private void apply_OrtoPerspective()
        {
            float l = 0.0f;
            float alpha = (float)Math.PI / 2.0f;
            apply_ObliquePerspective(l, alpha);
        }
        #endregion
    }
}
