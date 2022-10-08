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
            float[] x = new float[NUMBER_OF_VERTIX] { 0.0f, 4.0f, 2.0f, 0.5f, 0.0f, 4.0f, 2.0f, 0.5f };
            float[] y = new float[NUMBER_OF_VERTIX] { 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 3.0f, 1.5f, 1.0f };
            float[] z = new float[NUMBER_OF_VERTIX] { 0.0f, 0.0f, 1.0f, 1.0f, 0.0f, 0.0f, 1.0f, 1.0f };

            points = new VectorF3D(new PointF3D[NUMBER_OF_VERTIX]);
            defaultPoints = new VectorF3D(new PointF3D[NUMBER_OF_VERTIX]);

            for (int i = 0; i < NUMBER_OF_VERTIX; ++i)
            {
                points[i] = new PointF3D(x[i] * 50.0f, -y[i] * 50.0f, z[i] * 50.0f, 1.0f);
            }
            setFaces();
            makePerspective();
        }

        public void setDefault()
        {
            points = defaultPoints;
            setFaces();
        }

        private void setFaces()
        {
            faces[0] = new VectorF3D(new PointF3D[DIMENSION] { points[0], points[1], points[2], points[3] });
            faces[1] = new VectorF3D(new PointF3D[DIMENSION] { points[4], points[5], points[6], points[7] });
            faces[2] = new VectorF3D(new PointF3D[DIMENSION] { points[0], points[1], points[5], points[4] });
            faces[3] = new VectorF3D(new PointF3D[DIMENSION] { points[2], points[3], points[7], points[6] });
            faces[4] = new VectorF3D(new PointF3D[DIMENSION] { points[0], points[3], points[7], points[4] });
            faces[5] = new VectorF3D(new PointF3D[DIMENSION] { points[1], points[2], points[6], points[5] });
        }

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
        #endregion

        #region проекции
        private void offCheckedPerspective()
        {
            directP = false;
            onePointP = false;
            kavalieP = false;
            kabineP = false;
            ortoP = false;
        }

        public PointF[,] getFacesPerspective()
        {
            makePerspective();
            return faces2D;
        }

        public void apply_DirectPerspective()
        {
            faces2D = new PointF[6, 4];
            VectorF3D[] newFaces = new VectorF3D[6];
            for (int i = 0; i < 6; ++i)
            {
                newFaces[i] = faces[i].Clone();
            }

            float[,] moveMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 1 }
            };

            for (int i = 0; i < 6; ++i)
            {
                newFaces[i].dot(moveMatrix);
                for (int j = 0; j < 4; ++j)
                {
                    faces2D[i, j] = newFaces[i].getPoint2D()[j];
                }
            }
        }
        public void apply_OnePointPerspective()
        {
            faces2D = new PointF[6, 4];
            VectorF3D[] newFaces = new VectorF3D[6];
            for (int i = 0; i < 6; ++i)
            {
                newFaces[i] = faces[i].Clone();
            }
            float r = 0.001f;

            float[,] moveMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 20, r },
                { 0, 0, 0, 1 }
            };

            for (int i = 0; i < 6; ++i)
            {
                newFaces[i].dot(moveMatrix);
                for (int j = 0; j < 4; ++j)
                {
                    faces2D[i, j] = newFaces[i].getPoint2D()[j];
                }
            }
        }

        // косоугольные проекции
        public void apply_ObliquePerspective(float l, float alpha)
        {
            faces2D = new PointF[6, 4];
            VectorF3D[] newFaces = new VectorF3D[6];
            for (int i = 0; i < 6; ++i)
            {
                newFaces[i] = faces[i].Clone();
            }

            float[,] moveMatrix = new float[,] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                {l * (float)Math.Cos(alpha), l * (float)Math.Sin(alpha), 0, 0 },
                { 0, 0, 0, 1 }
            };

            for (int i = 0; i < 6; ++i)
            {
                newFaces[i].dot(moveMatrix);
                for (int j = 0; j < 4; ++j)
                {
                    faces2D[i, j] = newFaces[i].getPoint2D()[j];
                }
            }
        }
        public void apply_KavaliePerspective()
        {
            float l = 1.0f;
            float alpha = (float)Math.PI / 4.0f;
            apply_ObliquePerspective(l, alpha);
        }
        public void apply_KabinePerspective()
        {
            float l = 1/2.0f;
            float alpha = (float)Math.Atan(2);
            apply_ObliquePerspective(l, alpha);
        }
        public void apply_OrtoPerspective()
        {
            float l = 0.0f;
            float alpha = (float)Math.PI / 2.0f;
            apply_ObliquePerspective(l, alpha);
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

        #endregion

        public int  getNimberOfVertix()
        {
            return NUMBER_OF_VERTIX;
        }

        private VectorF3D points;
        private VectorF3D defaultPoints;
        private PointF[,] faces2D;

        bool directP = true;
        bool onePointP = false;
        bool kavalieP = false;
        bool kabineP = false;
        bool ortoP = false;

        VectorF3D[] faces = new VectorF3D[6];
    }

}
