using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComGraph_Lab_5
{

    public partial class Form1 : Form
    {
        Figure fig = new Figure();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            
            g.TranslateTransform(((PictureBox)sender).Width / 2.0f, ((PictureBox)sender).Height / 2.0f);

            PointF[,] faces = fig.getFacesPerspective();

            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    g.DrawLine(new Pen(Color.Black), faces[i, j], faces[i, j + 1]);
                }
                g.DrawLine(new Pen(Color.Black), faces[i, 3], faces[i, 0]);
            }
            //fig.resetTransform();
        }

        float getFloat(String text)
        {
            text = text.Replace('.', ',');
            float value = 0;
            if (float.TryParse(text, out value))
                return value;
            return value;
        }

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
    }

}
