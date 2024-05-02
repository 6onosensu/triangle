namespace triangle
{
    partial class Triangle_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triangle_form));
            this.calculate_btn = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.Parameter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.A_lab = new System.Windows.Forms.Label();
            this.B_lab = new System.Windows.Forms.Label();
            this.C_lab = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.perimeter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculate_btn
            // 
            this.calculate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calculate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.calculate_btn.ForeColor = System.Drawing.Color.White;
            this.calculate_btn.Location = new System.Drawing.Point(733, 398);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(123, 40);
            this.calculate_btn.TabIndex = 0;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Parameter,
            this.Value});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(648, 23);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(208, 369);
            this.lv.TabIndex = 1;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Parameter
            // 
            this.Parameter.Text = "Parameter";
            this.Parameter.Width = 150;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            // 
            // A_lab
            // 
            this.A_lab.AutoSize = true;
            this.A_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.A_lab.Location = new System.Drawing.Point(40, 32);
            this.A_lab.Name = "A_lab";
            this.A_lab.Size = new System.Drawing.Size(60, 20);
            this.A_lab.TabIndex = 2;
            this.A_lab.Text = "Side A:";
            this.A_lab.Click += new System.EventHandler(this.label1_Click);
            // 
            // B_lab
            // 
            this.B_lab.AutoSize = true;
            this.B_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.B_lab.Location = new System.Drawing.Point(40, 62);
            this.B_lab.Name = "B_lab";
            this.B_lab.Size = new System.Drawing.Size(60, 20);
            this.B_lab.TabIndex = 3;
            this.B_lab.Text = "Side B:";
            // 
            // C_lab
            // 
            this.C_lab.AutoSize = true;
            this.C_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.C_lab.Location = new System.Drawing.Point(40, 94);
            this.C_lab.Name = "C_lab";
            this.C_lab.Size = new System.Drawing.Size(60, 20);
            this.C_lab.TabIndex = 4;
            this.C_lab.Text = "Side C:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(106, 32);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(63, 20);
            this.txt_a.TabIndex = 5;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(106, 64);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(63, 20);
            this.txt_b.TabIndex = 6;
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(106, 96);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(63, 20);
            this.txt_c.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(38, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Area S:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(106, 135);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(63, 20);
            this.s.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(78, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "h:";
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(106, 175);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(63, 20);
            this.h.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(19, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Perimeter:";
            // 
            // perimeter
            // 
            this.perimeter.Location = new System.Drawing.Point(106, 214);
            this.perimeter.Name = "perimeter";
            this.perimeter.Size = new System.Drawing.Size(63, 20);
            this.perimeter.TabIndex = 13;
            // 
            // Triangle_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.perimeter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.h);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.C_lab);
            this.Controls.Add(this.B_lab);
            this.Controls.Add(this.A_lab);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.calculate_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Triangle_form";
            this.Padding = new System.Windows.Forms.Padding(25, 20, 25, 20);
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader Parameter;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Label A_lab;
        private System.Windows.Forms.Label B_lab;
        private System.Windows.Forms.Label C_lab;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox perimeter;
    }
}

