namespace Volume
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCone = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSurface = new System.Windows.Forms.Label();
            this.cm1 = new System.Windows.Forms.Label();
            this.cm2 = new System.Windows.Forms.Label();
            this.cm3 = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.FormulaBox = new System.Windows.Forms.GroupBox();
            this.lblFurmolaSurface = new System.Windows.Forms.Label();
            this.lblFormulaR = new System.Windows.Forms.Label();
            this.lblFormulaS = new System.Windows.Forms.Label();
            this.lblFormulaT = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.lblS = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.tabCylinder = new System.Windows.Forms.TabPage();
            this.tabSphere = new System.Windows.Forms.TabPage();
            this.tabPyramid = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FormulaGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVolumeCylinder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSurfaceCylinder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCountCylinder = new System.Windows.Forms.Button();
            this.txtRCylinder = new System.Windows.Forms.TextBox();
            this.txtTCylinder = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabCone.SuspendLayout();
            this.FormulaBox.SuspendLayout();
            this.tabCylinder.SuspendLayout();
            this.FormulaGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCone);
            this.tabControl.Controls.Add(this.tabCylinder);
            this.tabControl.Controls.Add(this.tabSphere);
            this.tabControl.Controls.Add(this.tabPyramid);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabCone
            // 
            this.tabCone.Controls.Add(this.label3);
            this.tabCone.Controls.Add(this.txtVolume);
            this.tabCone.Controls.Add(this.label2);
            this.tabCone.Controls.Add(this.txtSurface);
            this.tabCone.Controls.Add(this.label1);
            this.tabCone.Controls.Add(this.lblSurface);
            this.tabCone.Controls.Add(this.cm1);
            this.tabCone.Controls.Add(this.cm2);
            this.tabCone.Controls.Add(this.cm3);
            this.tabCone.Controls.Add(this.btnCount);
            this.tabCone.Controls.Add(this.FormulaBox);
            this.tabCone.Controls.Add(this.txtS);
            this.tabCone.Controls.Add(this.txtR);
            this.tabCone.Controls.Add(this.txtT);
            this.tabCone.Controls.Add(this.lblS);
            this.tabCone.Controls.Add(this.lblR);
            this.tabCone.Controls.Add(this.lblT);
            this.tabCone.Controls.Add(this.panel1);
            this.tabCone.Location = new System.Drawing.Point(4, 29);
            this.tabCone.Name = "tabCone";
            this.tabCone.Padding = new System.Windows.Forms.Padding(3);
            this.tabCone.Size = new System.Drawing.Size(792, 417);
            this.tabCone.TabIndex = 0;
            this.tabCone.Text = "Cone";
            this.tabCone.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "cm^3";
            // 
            // txtVolume
            // 
            this.txtVolume.Enabled = false;
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(508, 363);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(200, 35);
            this.txtVolume.TabIndex = 16;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(714, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "cm^2";
            // 
            // txtSurface
            // 
            this.txtSurface.Enabled = false;
            this.txtSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurface.Location = new System.Drawing.Point(508, 304);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(200, 35);
            this.txtSurface.TabIndex = 14;
            this.txtSurface.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Volume : ";
            // 
            // lblSurface
            // 
            this.lblSurface.AutoSize = true;
            this.lblSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurface.Location = new System.Drawing.Point(389, 307);
            this.lblSurface.Name = "lblSurface";
            this.lblSurface.Size = new System.Drawing.Size(113, 29);
            this.lblSurface.TabIndex = 12;
            this.lblSurface.Text = "Surface : ";
            // 
            // cm1
            // 
            this.cm1.AutoSize = true;
            this.cm1.Location = new System.Drawing.Point(583, 164);
            this.cm1.Name = "cm1";
            this.cm1.Size = new System.Drawing.Size(30, 20);
            this.cm1.TabIndex = 11;
            this.cm1.Text = "cm";
            // 
            // cm2
            // 
            this.cm2.AutoSize = true;
            this.cm2.Location = new System.Drawing.Point(583, 210);
            this.cm2.Name = "cm2";
            this.cm2.Size = new System.Drawing.Size(30, 20);
            this.cm2.TabIndex = 10;
            this.cm2.Text = "cm";
            // 
            // cm3
            // 
            this.cm3.AutoSize = true;
            this.cm3.Location = new System.Drawing.Point(582, 259);
            this.cm3.Name = "cm3";
            this.cm3.Size = new System.Drawing.Size(30, 20);
            this.cm3.TabIndex = 9;
            this.cm3.Text = "cm";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(665, 232);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(119, 50);
            this.btnCount.TabIndex = 8;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // FormulaBox
            // 
            this.FormulaBox.Controls.Add(this.label4);
            this.FormulaBox.Controls.Add(this.lblFurmolaSurface);
            this.FormulaBox.Controls.Add(this.lblFormulaR);
            this.FormulaBox.Controls.Add(this.lblFormulaS);
            this.FormulaBox.Controls.Add(this.lblFormulaT);
            this.FormulaBox.Location = new System.Drawing.Point(376, 6);
            this.FormulaBox.Name = "FormulaBox";
            this.FormulaBox.Size = new System.Drawing.Size(408, 149);
            this.FormulaBox.TabIndex = 7;
            this.FormulaBox.TabStop = false;
            this.FormulaBox.Text = "Formula";
            // 
            // lblFurmolaSurface
            // 
            this.lblFurmolaSurface.AutoSize = true;
            this.lblFurmolaSurface.Location = new System.Drawing.Point(207, 43);
            this.lblFurmolaSurface.Name = "lblFurmolaSurface";
            this.lblFurmolaSurface.Size = new System.Drawing.Size(148, 20);
            this.lblFurmolaSurface.TabIndex = 3;
            this.lblFurmolaSurface.Text = "Surface = π*r*(r + s)";
            // 
            // lblFormulaR
            // 
            this.lblFormulaR.AutoSize = true;
            this.lblFormulaR.Location = new System.Drawing.Point(14, 70);
            this.lblFormulaR.Name = "lblFormulaR";
            this.lblFormulaR.Size = new System.Drawing.Size(141, 20);
            this.lblFormulaR.TabIndex = 2;
            this.lblFormulaR.Text = "r = (S^2 - t^2)^(1/2)";
            // 
            // lblFormulaS
            // 
            this.lblFormulaS.AutoSize = true;
            this.lblFormulaS.Location = new System.Drawing.Point(14, 116);
            this.lblFormulaS.Name = "lblFormulaS";
            this.lblFormulaS.Size = new System.Drawing.Size(145, 20);
            this.lblFormulaS.TabIndex = 1;
            this.lblFormulaS.Text = "S = (r^2 + t^2)^(1/2)";
            // 
            // lblFormulaT
            // 
            this.lblFormulaT.AutoSize = true;
            this.lblFormulaT.Location = new System.Drawing.Point(14, 22);
            this.lblFormulaT.Name = "lblFormulaT";
            this.lblFormulaT.Size = new System.Drawing.Size(141, 20);
            this.lblFormulaT.TabIndex = 0;
            this.lblFormulaT.Text = "t = (S^2 - r^2)^(1/2)";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(426, 256);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(150, 26);
            this.txtS.TabIndex = 6;
            this.txtS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(426, 207);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(150, 26);
            this.txtR.TabIndex = 5;
            this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(426, 161);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(150, 26);
            this.txtT.TabIndex = 4;
            this.txtT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(390, 259);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(32, 20);
            this.lblS.TabIndex = 3;
            this.lblS.Text = "S : ";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(390, 210);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(26, 20);
            this.lblR.TabIndex = 2;
            this.lblR.Text = "r : ";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(390, 164);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(26, 20);
            this.lblT.TabIndex = 1;
            this.lblT.Text = "t : ";
            // 
            // tabCylinder
            // 
            this.tabCylinder.Controls.Add(this.label7);
            this.tabCylinder.Controls.Add(this.txtVolumeCylinder);
            this.tabCylinder.Controls.Add(this.label8);
            this.tabCylinder.Controls.Add(this.txtSurfaceCylinder);
            this.tabCylinder.Controls.Add(this.label9);
            this.tabCylinder.Controls.Add(this.label10);
            this.tabCylinder.Controls.Add(this.label11);
            this.tabCylinder.Controls.Add(this.label12);
            this.tabCylinder.Controls.Add(this.btnCountCylinder);
            this.tabCylinder.Controls.Add(this.txtRCylinder);
            this.tabCylinder.Controls.Add(this.txtTCylinder);
            this.tabCylinder.Controls.Add(this.label13);
            this.tabCylinder.Controls.Add(this.label14);
            this.tabCylinder.Controls.Add(this.FormulaGroup);
            this.tabCylinder.Controls.Add(this.panel2);
            this.tabCylinder.Location = new System.Drawing.Point(4, 29);
            this.tabCylinder.Name = "tabCylinder";
            this.tabCylinder.Padding = new System.Windows.Forms.Padding(3);
            this.tabCylinder.Size = new System.Drawing.Size(792, 417);
            this.tabCylinder.TabIndex = 1;
            this.tabCylinder.Text = "Cylinder";
            this.tabCylinder.UseVisualStyleBackColor = true;
            // 
            // tabSphere
            // 
            this.tabSphere.Location = new System.Drawing.Point(4, 29);
            this.tabSphere.Name = "tabSphere";
            this.tabSphere.Size = new System.Drawing.Size(792, 417);
            this.tabSphere.TabIndex = 2;
            this.tabSphere.Text = "Sphere";
            this.tabSphere.UseVisualStyleBackColor = true;
            // 
            // tabPyramid
            // 
            this.tabPyramid.Location = new System.Drawing.Point(4, 29);
            this.tabPyramid.Name = "tabPyramid";
            this.tabPyramid.Size = new System.Drawing.Size(792, 417);
            this.tabPyramid.TabIndex = 3;
            this.tabPyramid.Text = "Pyramid";
            this.tabPyramid.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Volume = (1/3) * surface * t";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Volume.Properties.Resources.Cone;
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 403);
            this.panel1.TabIndex = 0;
            // 
            // FormulaGroup
            // 
            this.FormulaGroup.Controls.Add(this.label5);
            this.FormulaGroup.Controls.Add(this.label6);
            this.FormulaGroup.Location = new System.Drawing.Point(376, 7);
            this.FormulaGroup.Name = "FormulaGroup";
            this.FormulaGroup.Size = new System.Drawing.Size(408, 149);
            this.FormulaGroup.TabIndex = 9;
            this.FormulaGroup.TabStop = false;
            this.FormulaGroup.Text = "Formula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Volume = π * r ^ 2 * t";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Surface = 2 * π * r * (r + t)";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Volume.Properties.Resources.Cylinder;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 403);
            this.panel2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(714, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "cm^3";
            // 
            // txtVolumeCylinder
            // 
            this.txtVolumeCylinder.Enabled = false;
            this.txtVolumeCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolumeCylinder.Location = new System.Drawing.Point(508, 367);
            this.txtVolumeCylinder.Name = "txtVolumeCylinder";
            this.txtVolumeCylinder.Size = new System.Drawing.Size(200, 35);
            this.txtVolumeCylinder.TabIndex = 29;
            this.txtVolumeCylinder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(714, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "cm^2";
            // 
            // txtSurfaceCylinder
            // 
            this.txtSurfaceCylinder.Enabled = false;
            this.txtSurfaceCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurfaceCylinder.Location = new System.Drawing.Point(508, 308);
            this.txtSurfaceCylinder.Name = "txtSurfaceCylinder";
            this.txtSurfaceCylinder.Size = new System.Drawing.Size(200, 35);
            this.txtSurfaceCylinder.TabIndex = 27;
            this.txtSurfaceCylinder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(389, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 29);
            this.label9.TabIndex = 26;
            this.label9.Text = "Volume : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(389, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Surface : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(583, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "cm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(583, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "cm";
            // 
            // btnCountCylinder
            // 
            this.btnCountCylinder.Location = new System.Drawing.Point(665, 236);
            this.btnCountCylinder.Name = "btnCountCylinder";
            this.btnCountCylinder.Size = new System.Drawing.Size(119, 50);
            this.btnCountCylinder.TabIndex = 22;
            this.btnCountCylinder.Text = "Count";
            this.btnCountCylinder.UseVisualStyleBackColor = true;
            this.btnCountCylinder.Click += new System.EventHandler(this.btnCountCylinder_Click);
            // 
            // txtRCylinder
            // 
            this.txtRCylinder.Location = new System.Drawing.Point(426, 211);
            this.txtRCylinder.Name = "txtRCylinder";
            this.txtRCylinder.Size = new System.Drawing.Size(150, 26);
            this.txtRCylinder.TabIndex = 21;
            this.txtRCylinder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTCylinder
            // 
            this.txtTCylinder.Location = new System.Drawing.Point(426, 165);
            this.txtTCylinder.Name = "txtTCylinder";
            this.txtTCylinder.Size = new System.Drawing.Size(150, 26);
            this.txtTCylinder.TabIndex = 20;
            this.txtTCylinder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(390, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "r : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(390, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "t : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabCone.ResumeLayout(false);
            this.tabCone.PerformLayout();
            this.FormulaBox.ResumeLayout(false);
            this.FormulaBox.PerformLayout();
            this.tabCylinder.ResumeLayout(false);
            this.tabCylinder.PerformLayout();
            this.FormulaGroup.ResumeLayout(false);
            this.FormulaGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCone;
        private System.Windows.Forms.TabPage tabCylinder;
        private System.Windows.Forms.TabPage tabSphere;
        private System.Windows.Forms.TabPage tabPyramid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox FormulaBox;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblFormulaS;
        private System.Windows.Forms.Label lblFormulaT;
        private System.Windows.Forms.Label lblFormulaR;
        private System.Windows.Forms.Label lblFurmolaSurface;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label cm1;
        private System.Windows.Forms.Label cm2;
        private System.Windows.Forms.Label cm3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSurface;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox FormulaGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVolumeCylinder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSurfaceCylinder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCountCylinder;
        private System.Windows.Forms.TextBox txtRCylinder;
        private System.Windows.Forms.TextBox txtTCylinder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

