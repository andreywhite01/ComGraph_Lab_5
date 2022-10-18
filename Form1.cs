using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ComGraph_Lab_5
{

    public partial class Form1 : Form
    {
        Figure fig;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fig = new Figure();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // перемещаем точку начала координат в центр PictureBox
            g.TranslateTransform(((PictureBox)sender).Width / 2.0f, ((PictureBox)sender).Height / 2.0f);

            drawFigure(g, fig);
            drawAxes(g);
        }

        void drawFigure(Graphics g, Figure fig)
        {
            PointF[,] faces = fig.getFacesPerspective();
            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    g.DrawLine(new Pen(Color.Black, 2), faces[i, j], faces[i, j + 1]);
                }
                g.DrawLine(new Pen(Color.Black, 2), faces[i, 3], faces[i, 0]);
            }
        }
        void drawAxes(Graphics g)
        {
            // рисуем оси проекции (при проекии на плоскость XOY ось OZ не видна)
            PointF[] axes = { new PointF(0, 0), new PointF(100, 0), new PointF(0, 100) };
            g.DrawLine(new Pen(Color.Red, 3), axes[0], axes[1]);
            g.DrawLine(new Pen(Color.Green, 3), axes[0], axes[2]);
        }

        // вспомогающая функция для получения чисел из TextBox
        float getFloat(String text)
        {
            text = text.Replace('.', ',');
            float value = 0;
            if (float.TryParse(text, out value))
                return value;
            return value;
        }

        #region операции над фигурой
        private void rotate(char axis, TextBox tb)
        {
            float angle;
            if ((angle = getFloat(tb.Text)) != 0)
            {
                fig.rotate(axis, angle);
                pictureBox1.Image = null;
            }
        }

        private void move(char axis, TextBox tb)
        {
            float step;
            if ((step = getFloat(tb.Text)) != 0)
            {
                fig.move(axis, step);
                pictureBox1.Image = null;
            }
        }

        private void scale(char axis, TextBox tb)
        {
            float k;
            if ((k = getFloat(tb.Text)) != 0)
            {
                if (axis == 'a')
                {
                    fig.scale('a', k);
                    pictureBox1.Image = null;
                    return;
                }
                fig.scale(axis, k);
                pictureBox1.Image = null;
            }
        }

        private void reflect(char axis)
        {
            fig.reflect(axis);
            pictureBox1.Image = null;
        }
        #endregion

        #region кнопки управления
        private void btn_rotate_x_Click(object sender, EventArgs e)
        {
            rotate('x', tb_angle_x);
        }

        private void btn_rotate_y_Click(object sender, EventArgs e)
        {
            rotate('y', tb_angle_y);
        }

        private void btn_rotate_z_Click(object sender, EventArgs e)
        {
            rotate('z', tb_angle_z);
        }

        private void btn_move_x_Click(object sender, EventArgs e)
        {
            move('x', tb_step_x);
        }

        private void btn_move_y_Click(object sender, EventArgs e)
        {
            move('y', tb_step_y);
        }

        private void btn_move_z_Click(object sender, EventArgs e)
        {
            move('z', tb_step_z);
        }

        private void btn_scale_x_Click(object sender, EventArgs e)
        {
            scale('x', tb_scale_x);
        }

        private void btn_scale_y_Click(object sender, EventArgs e)
        {
            scale('y', tb_scale_y);
        }

        private void btn_scale_z_Click(object sender, EventArgs e)
        {
            scale('z', tb_scale_z);
        }

        private void btn_scale_all_Click(object sender, EventArgs e)
        {
            scale('a', tb_scale_all);
        }

        private void btn_reflect_x_Click(object sender, EventArgs e)
        {
            reflect('x');
        }

        private void btn_reflect_y_Click(object sender, EventArgs e)
        {
            reflect('y');
        }

        private void btn_reflect_z_Click(object sender, EventArgs e)
        {
            reflect('z');
        }
        #endregion

        #region настройка проекций
        private void DirectPerspective_Click(object sender, EventArgs e)
        {
            fig.set_DirectPerspective();

            offCheckedPerspective();
            Direct_ToolStripMenuItem.Checked = true;

        }
        private void OnePointPerspective_Click(object sender, EventArgs e)
        {
            fig.set_OnePointPerspective();

            offCheckedPerspective();
            OnePoint_ToolStripMenuItem.Checked = true;

        }
        private void Kavalie_Click(object sender, EventArgs e)
        {
            fig.set_KavaliePerspective();

            offCheckedPerspective();
            Oblique_ToolStripMenuItem.Checked = true;
            Kavalie_ToolStripMenuItem.Checked = true;
        }
        private void Kabine_Click(object sender, EventArgs e)
        {
            fig.set_KabinePerspective();

            offCheckedPerspective();
            Oblique_ToolStripMenuItem.Checked = true;
            Kabine_ToolStripMenuItem.Checked = true;
        }
        private void Orto_Click(object sender, EventArgs e)
        {
            fig.set_OrtoPerspective();

            offCheckedPerspective();
            Oblique_ToolStripMenuItem.Checked = true;
            Orto_ToolStripMenuItem.Checked = true;
        }
        // отключить выбранную проекцию
        private void offCheckedPerspective()
        {
            Direct_ToolStripMenuItem.Checked = false;
            OnePoint_ToolStripMenuItem.Checked = false;
            Oblique_ToolStripMenuItem.Checked = false;
            Kavalie_ToolStripMenuItem.Checked = false;
            Kabine_ToolStripMenuItem.Checked = false;
            Orto_ToolStripMenuItem.Checked = false;

            pictureBox1.Image = null;
        }
        #endregion

        #region обработчики горячих клавиш
        // переменные для отслеживания состояния мыши
        bool isLKM_Down = false;
        Point startMouseCoordinates;
        Point mouseCoordinates;

        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
        {
            // вращение
            if (keyData == (Keys.R))
            {
                float angleX = (startMouseCoordinates.Y - mouseCoordinates.Y) / 100.0f;
                float angleY = (startMouseCoordinates.X - mouseCoordinates.X) / 100.0f;

                fig.rotate('x', angleX);
                fig.rotate('y', -angleY);

                startMouseCoordinates = new Point(mouseCoordinates.X, mouseCoordinates.Y);

                pictureBox1.Image = null;
            }
            // перемещение
            if (keyData == (Keys.M))
            {
                float stepX = (startMouseCoordinates.Y - mouseCoordinates.Y) / 1.0f;
                float stepY = (startMouseCoordinates.X - mouseCoordinates.X) / 1.0f;

                fig.move('x', -stepY);
                fig.move('y', -stepX);

                startMouseCoordinates = new Point(mouseCoordinates.X, mouseCoordinates.Y);

                pictureBox1.Image = null;
            }
            // масштабирование
            if (keyData == (Keys.S))
            {
                float kX = 1 + (startMouseCoordinates.Y - mouseCoordinates.Y) / 500.0f;
                float kY = 1 - (startMouseCoordinates.X - mouseCoordinates.X) / 500.0f;

                fig.scale('x', kY);
                fig.scale('y', kX);
                
                startMouseCoordinates = new Point(mouseCoordinates.X, mouseCoordinates.Y);

                pictureBox1.Image = null;
            }
            return base.ProcessCmdKey(ref message, keyData);
        }

        private void pictureBox1_LKMDown(object sender, MouseEventArgs e)
        {
            startMouseCoordinates = new Point(e.X, e.Y);
            mouseCoordinates = new Point(e.X, e.Y);
            isLKM_Down = true;
        }

        private void pictureBox1_LKMUp(object sender, MouseEventArgs e)
        {
            isLKM_Down = false;
            startMouseCoordinates = new Point(0, 0);
            mouseCoordinates = new Point(0, 0);
        }

        private void pictureBox1_LKMMove(object sender, MouseEventArgs e)
        {
            if (isLKM_Down)
            {
                if (mouseCoordinates.X == e.X && mouseCoordinates.Y == e.Y)
                    mouseCoordinates = new Point(0, 0);
                else
                {
                    mouseCoordinates = new Point(e.X, e.Y);
                }
            }
        }
        #endregion

        #region функции кнопок в меню программы
        // закрыть программу
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // сброс к начальным настройкам
        private void toDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fig.setDefault();
            pictureBox1.Image = null;
        }

        // открытие окна с помощью
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormHelp helpForm = new FormHelp();
            helpForm.Show();
        }
        #endregion
    }
}
