
namespace ComGraph_Lab_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_rotate_y = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Direct_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnePoint_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Oblique_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Kavalie_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Kabine_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Orto_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rotate_x = new System.Windows.Forms.Button();
            this.btn_rotate_z = new System.Windows.Forms.Button();
            this.tb_angle_x = new System.Windows.Forms.TextBox();
            this.tb_angle_y = new System.Windows.Forms.TextBox();
            this.tb_angle_z = new System.Windows.Forms.TextBox();
            this.tb_step_z = new System.Windows.Forms.TextBox();
            this.tb_step_y = new System.Windows.Forms.TextBox();
            this.tb_step_x = new System.Windows.Forms.TextBox();
            this.btn_move_z = new System.Windows.Forms.Button();
            this.btn_move_x = new System.Windows.Forms.Button();
            this.btn_move_y = new System.Windows.Forms.Button();
            this.btn_reflect_x = new System.Windows.Forms.Button();
            this.btn_reflect_y = new System.Windows.Forms.Button();
            this.btn_reflect_z = new System.Windows.Forms.Button();
            this.tb_scale_z = new System.Windows.Forms.TextBox();
            this.tb_scale_y = new System.Windows.Forms.TextBox();
            this.tb_scale_x = new System.Windows.Forms.TextBox();
            this.btn_scale_z = new System.Windows.Forms.Button();
            this.btn_scale_x = new System.Windows.Forms.Button();
            this.btn_scale_y = new System.Windows.Forms.Button();
            this.tb_scale_all = new System.Windows.Forms.TextBox();
            this.btn_scale_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btn_rotate_y
            // 
            this.btn_rotate_y.Location = new System.Drawing.Point(601, 83);
            this.btn_rotate_y.Name = "btn_rotate_y";
            this.btn_rotate_y.Size = new System.Drawing.Size(75, 23);
            this.btn_rotate_y.TabIndex = 1;
            this.btn_rotate_y.Text = "rotate y";
            this.btn_rotate_y.UseVisualStyleBackColor = true;
            this.btn_rotate_y.Click += new System.EventHandler(this.btn_rotate_y_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сброситьИзмененияToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сброситьИзмененияToolStripMenuItem
            // 
            this.сброситьИзмененияToolStripMenuItem.Name = "сброситьИзмененияToolStripMenuItem";
            this.сброситьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.сброситьИзмененияToolStripMenuItem.Text = "Сбросить изменения";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Direct_ToolStripMenuItem,
            this.OnePoint_ToolStripMenuItem,
            this.Oblique_ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItem1.Text = "Проекция";
            // 
            // Direct_ToolStripMenuItem
            // 
            this.Direct_ToolStripMenuItem.Checked = true;
            this.Direct_ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Direct_ToolStripMenuItem.Name = "Direct_ToolStripMenuItem";
            this.Direct_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Direct_ToolStripMenuItem.Text = "Прямоугольная";
            this.Direct_ToolStripMenuItem.Click += new System.EventHandler(this.DirectPerspective_Click);
            // 
            // OnePoint_ToolStripMenuItem
            // 
            this.OnePoint_ToolStripMenuItem.Name = "OnePoint_ToolStripMenuItem";
            this.OnePoint_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OnePoint_ToolStripMenuItem.Text = "Одноточечная";
            this.OnePoint_ToolStripMenuItem.Click += new System.EventHandler(this.OnePointPerspective_Click);
            // 
            // Oblique_ToolStripMenuItem
            // 
            this.Oblique_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Kavalie_ToolStripMenuItem,
            this.Kabine_ToolStripMenuItem,
            this.Orto_ToolStripMenuItem});
            this.Oblique_ToolStripMenuItem.Name = "Oblique_ToolStripMenuItem";
            this.Oblique_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Oblique_ToolStripMenuItem.Text = "Косоугольная";
            // 
            // Kavalie_ToolStripMenuItem
            // 
            this.Kavalie_ToolStripMenuItem.Name = "Kavalie_ToolStripMenuItem";
            this.Kavalie_ToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.Kavalie_ToolStripMenuItem.Text = "Кавалье";
            this.Kavalie_ToolStripMenuItem.Click += new System.EventHandler(this.Kavalie_Click);
            // 
            // Kabine_ToolStripMenuItem
            // 
            this.Kabine_ToolStripMenuItem.Name = "Kabine_ToolStripMenuItem";
            this.Kabine_ToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.Kabine_ToolStripMenuItem.Text = "Кабине";
            this.Kabine_ToolStripMenuItem.Click += new System.EventHandler(this.Kabine_Click);
            // 
            // Orto_ToolStripMenuItem
            // 
            this.Orto_ToolStripMenuItem.Name = "Orto_ToolStripMenuItem";
            this.Orto_ToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.Orto_ToolStripMenuItem.Text = "Ортографическая проекция";
            this.Orto_ToolStripMenuItem.Click += new System.EventHandler(this.Orto_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem2.Text = "Помощь";
            // 
            // btn_rotate_x
            // 
            this.btn_rotate_x.Location = new System.Drawing.Point(601, 54);
            this.btn_rotate_x.Name = "btn_rotate_x";
            this.btn_rotate_x.Size = new System.Drawing.Size(75, 23);
            this.btn_rotate_x.TabIndex = 3;
            this.btn_rotate_x.Text = "rotate x";
            this.btn_rotate_x.UseVisualStyleBackColor = true;
            this.btn_rotate_x.Click += new System.EventHandler(this.btn_rotate_x_Click);
            // 
            // btn_rotate_z
            // 
            this.btn_rotate_z.Location = new System.Drawing.Point(601, 112);
            this.btn_rotate_z.Name = "btn_rotate_z";
            this.btn_rotate_z.Size = new System.Drawing.Size(75, 23);
            this.btn_rotate_z.TabIndex = 4;
            this.btn_rotate_z.Text = "rotate z";
            this.btn_rotate_z.UseVisualStyleBackColor = true;
            this.btn_rotate_z.Click += new System.EventHandler(this.btn_rotate_z_Click);
            // 
            // tb_angle_x
            // 
            this.tb_angle_x.Location = new System.Drawing.Point(535, 54);
            this.tb_angle_x.Name = "tb_angle_x";
            this.tb_angle_x.Size = new System.Drawing.Size(60, 20);
            this.tb_angle_x.TabIndex = 5;
            this.tb_angle_x.Text = "0.1";
            // 
            // tb_angle_y
            // 
            this.tb_angle_y.Location = new System.Drawing.Point(535, 83);
            this.tb_angle_y.Name = "tb_angle_y";
            this.tb_angle_y.Size = new System.Drawing.Size(60, 20);
            this.tb_angle_y.TabIndex = 6;
            this.tb_angle_y.Text = "0.1";
            // 
            // tb_angle_z
            // 
            this.tb_angle_z.Location = new System.Drawing.Point(535, 112);
            this.tb_angle_z.Name = "tb_angle_z";
            this.tb_angle_z.Size = new System.Drawing.Size(60, 20);
            this.tb_angle_z.TabIndex = 7;
            this.tb_angle_z.Text = "0.1";
            // 
            // tb_step_z
            // 
            this.tb_step_z.Location = new System.Drawing.Point(535, 230);
            this.tb_step_z.Name = "tb_step_z";
            this.tb_step_z.Size = new System.Drawing.Size(60, 20);
            this.tb_step_z.TabIndex = 13;
            this.tb_step_z.Text = "10";
            // 
            // tb_step_y
            // 
            this.tb_step_y.Location = new System.Drawing.Point(535, 201);
            this.tb_step_y.Name = "tb_step_y";
            this.tb_step_y.Size = new System.Drawing.Size(60, 20);
            this.tb_step_y.TabIndex = 12;
            this.tb_step_y.Text = "10";
            // 
            // tb_step_x
            // 
            this.tb_step_x.Location = new System.Drawing.Point(535, 172);
            this.tb_step_x.Name = "tb_step_x";
            this.tb_step_x.Size = new System.Drawing.Size(60, 20);
            this.tb_step_x.TabIndex = 11;
            this.tb_step_x.Text = "10";
            // 
            // btn_move_z
            // 
            this.btn_move_z.Location = new System.Drawing.Point(601, 230);
            this.btn_move_z.Name = "btn_move_z";
            this.btn_move_z.Size = new System.Drawing.Size(75, 23);
            this.btn_move_z.TabIndex = 10;
            this.btn_move_z.Text = "move z";
            this.btn_move_z.UseVisualStyleBackColor = true;
            this.btn_move_z.Click += new System.EventHandler(this.btn_move_z_Click);
            // 
            // btn_move_x
            // 
            this.btn_move_x.Location = new System.Drawing.Point(601, 172);
            this.btn_move_x.Name = "btn_move_x";
            this.btn_move_x.Size = new System.Drawing.Size(75, 23);
            this.btn_move_x.TabIndex = 9;
            this.btn_move_x.Text = "move x";
            this.btn_move_x.UseVisualStyleBackColor = true;
            this.btn_move_x.Click += new System.EventHandler(this.btn_move_x_Click);
            // 
            // btn_move_y
            // 
            this.btn_move_y.Location = new System.Drawing.Point(601, 201);
            this.btn_move_y.Name = "btn_move_y";
            this.btn_move_y.Size = new System.Drawing.Size(75, 23);
            this.btn_move_y.TabIndex = 8;
            this.btn_move_y.Text = "move y";
            this.btn_move_y.UseVisualStyleBackColor = true;
            this.btn_move_y.Click += new System.EventHandler(this.btn_move_y_Click);
            // 
            // btn_reflect_x
            // 
            this.btn_reflect_x.Location = new System.Drawing.Point(535, 419);
            this.btn_reflect_x.Name = "btn_reflect_x";
            this.btn_reflect_x.Size = new System.Drawing.Size(75, 23);
            this.btn_reflect_x.TabIndex = 14;
            this.btn_reflect_x.Text = "reflect x";
            this.btn_reflect_x.UseVisualStyleBackColor = true;
            this.btn_reflect_x.Click += new System.EventHandler(this.btn_reflect_x_Click);
            // 
            // btn_reflect_y
            // 
            this.btn_reflect_y.Location = new System.Drawing.Point(535, 448);
            this.btn_reflect_y.Name = "btn_reflect_y";
            this.btn_reflect_y.Size = new System.Drawing.Size(75, 23);
            this.btn_reflect_y.TabIndex = 15;
            this.btn_reflect_y.Text = "reflect y";
            this.btn_reflect_y.UseVisualStyleBackColor = true;
            this.btn_reflect_y.Click += new System.EventHandler(this.btn_reflect_y_Click);
            // 
            // btn_reflect_z
            // 
            this.btn_reflect_z.Location = new System.Drawing.Point(535, 477);
            this.btn_reflect_z.Name = "btn_reflect_z";
            this.btn_reflect_z.Size = new System.Drawing.Size(75, 23);
            this.btn_reflect_z.TabIndex = 16;
            this.btn_reflect_z.Text = "reflect z";
            this.btn_reflect_z.UseVisualStyleBackColor = true;
            this.btn_reflect_z.Click += new System.EventHandler(this.btn_reflect_z_Click);
            // 
            // tb_scale_z
            // 
            this.tb_scale_z.Location = new System.Drawing.Point(535, 342);
            this.tb_scale_z.Name = "tb_scale_z";
            this.tb_scale_z.Size = new System.Drawing.Size(60, 20);
            this.tb_scale_z.TabIndex = 22;
            this.tb_scale_z.Text = "1.1";
            // 
            // tb_scale_y
            // 
            this.tb_scale_y.Location = new System.Drawing.Point(535, 313);
            this.tb_scale_y.Name = "tb_scale_y";
            this.tb_scale_y.Size = new System.Drawing.Size(60, 20);
            this.tb_scale_y.TabIndex = 21;
            this.tb_scale_y.Text = "1.1";
            // 
            // tb_scale_x
            // 
            this.tb_scale_x.Location = new System.Drawing.Point(535, 284);
            this.tb_scale_x.Name = "tb_scale_x";
            this.tb_scale_x.Size = new System.Drawing.Size(60, 20);
            this.tb_scale_x.TabIndex = 20;
            this.tb_scale_x.Text = "1.1";
            // 
            // btn_scale_z
            // 
            this.btn_scale_z.Location = new System.Drawing.Point(601, 342);
            this.btn_scale_z.Name = "btn_scale_z";
            this.btn_scale_z.Size = new System.Drawing.Size(75, 23);
            this.btn_scale_z.TabIndex = 19;
            this.btn_scale_z.Text = "scale z";
            this.btn_scale_z.UseVisualStyleBackColor = true;
            this.btn_scale_z.Click += new System.EventHandler(this.btn_scale_z_Click);
            // 
            // btn_scale_x
            // 
            this.btn_scale_x.Location = new System.Drawing.Point(601, 284);
            this.btn_scale_x.Name = "btn_scale_x";
            this.btn_scale_x.Size = new System.Drawing.Size(75, 23);
            this.btn_scale_x.TabIndex = 18;
            this.btn_scale_x.Text = "scale x";
            this.btn_scale_x.UseVisualStyleBackColor = true;
            this.btn_scale_x.Click += new System.EventHandler(this.btn_scale_x_Click);
            // 
            // btn_scale_y
            // 
            this.btn_scale_y.Location = new System.Drawing.Point(601, 313);
            this.btn_scale_y.Name = "btn_scale_y";
            this.btn_scale_y.Size = new System.Drawing.Size(75, 23);
            this.btn_scale_y.TabIndex = 17;
            this.btn_scale_y.Text = "scale y";
            this.btn_scale_y.UseVisualStyleBackColor = true;
            this.btn_scale_y.Click += new System.EventHandler(this.btn_scale_y_Click);
            // 
            // tb_scale_all
            // 
            this.tb_scale_all.Location = new System.Drawing.Point(535, 371);
            this.tb_scale_all.Name = "tb_scale_all";
            this.tb_scale_all.Size = new System.Drawing.Size(60, 20);
            this.tb_scale_all.TabIndex = 24;
            this.tb_scale_all.Text = "1.1";
            // 
            // btn_scale_all
            // 
            this.btn_scale_all.Location = new System.Drawing.Point(601, 371);
            this.btn_scale_all.Name = "btn_scale_all";
            this.btn_scale_all.Size = new System.Drawing.Size(75, 23);
            this.btn_scale_all.TabIndex = 23;
            this.btn_scale_all.Text = "scale all";
            this.btn_scale_all.UseVisualStyleBackColor = true;
            this.btn_scale_all.Click += new System.EventHandler(this.btn_scale_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 623);
            this.Controls.Add(this.tb_scale_all);
            this.Controls.Add(this.btn_scale_all);
            this.Controls.Add(this.tb_scale_z);
            this.Controls.Add(this.tb_scale_y);
            this.Controls.Add(this.tb_scale_x);
            this.Controls.Add(this.btn_scale_z);
            this.Controls.Add(this.btn_scale_x);
            this.Controls.Add(this.btn_scale_y);
            this.Controls.Add(this.btn_reflect_z);
            this.Controls.Add(this.btn_reflect_y);
            this.Controls.Add(this.btn_reflect_x);
            this.Controls.Add(this.tb_step_z);
            this.Controls.Add(this.tb_step_y);
            this.Controls.Add(this.tb_step_x);
            this.Controls.Add(this.btn_move_z);
            this.Controls.Add(this.btn_move_x);
            this.Controls.Add(this.btn_move_y);
            this.Controls.Add(this.tb_angle_z);
            this.Controls.Add(this.tb_angle_y);
            this.Controls.Add(this.tb_angle_x);
            this.Controls.Add(this.btn_rotate_z);
            this.Controls.Add(this.btn_rotate_x);
            this.Controls.Add(this.btn_rotate_y);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_rotate_y;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Button btn_rotate_x;
        private System.Windows.Forms.Button btn_rotate_z;
        private System.Windows.Forms.TextBox tb_angle_x;
        private System.Windows.Forms.TextBox tb_angle_y;
        private System.Windows.Forms.TextBox tb_angle_z;
        private System.Windows.Forms.TextBox tb_step_z;
        private System.Windows.Forms.TextBox tb_step_y;
        private System.Windows.Forms.TextBox tb_step_x;
        private System.Windows.Forms.Button btn_move_z;
        private System.Windows.Forms.Button btn_move_x;
        private System.Windows.Forms.Button btn_move_y;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OnePoint_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Oblique_ToolStripMenuItem;
        private System.Windows.Forms.Button btn_reflect_x;
        private System.Windows.Forms.Button btn_reflect_y;
        private System.Windows.Forms.Button btn_reflect_z;
        private System.Windows.Forms.TextBox tb_scale_z;
        private System.Windows.Forms.TextBox tb_scale_y;
        private System.Windows.Forms.TextBox tb_scale_x;
        private System.Windows.Forms.Button btn_scale_z;
        private System.Windows.Forms.Button btn_scale_x;
        private System.Windows.Forms.Button btn_scale_y;
        private System.Windows.Forms.TextBox tb_scale_all;
        private System.Windows.Forms.Button btn_scale_all;
        private System.Windows.Forms.ToolStripMenuItem Direct_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Kavalie_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Kabine_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Orto_ToolStripMenuItem;
    }
}

