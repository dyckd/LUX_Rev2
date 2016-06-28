﻿namespace Daniels_LightTestApplication
{
    partial class MainForm
    {

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_runtest = new System.Windows.Forms.Button();
            this.comport_dc = new System.Windows.Forms.Button();
            this.lft_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.up_btn = new System.Windows.Forms.Button();
            this.dwn_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.connect_btn = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.xdeglbl = new System.Windows.Forms.Label();
            this.ydeglbl = new System.Windows.Forms.Label();
            this.xdeg_txt = new System.Windows.Forms.TextBox();
            this.ydeg_txt = new System.Windows.Forms.TextBox();
            this.goto_btn = new System.Windows.Forms.Button();
            this.manualcontrol_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.home_interior_text = new System.Windows.Forms.TextBox();
            this.home_exterior_text = new System.Windows.Forms.TextBox();
            this.home_interior_clk = new System.Windows.Forms.Button();
            this.home_interior_counter = new System.Windows.Forms.Button();
            this.home_exterior_counter = new System.Windows.Forms.Button();
            this.home_exterior_clock = new System.Windows.Forms.Button();
            this.sethome_bt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lightsensor_comport = new System.Windows.Forms.DomainUpDown();
            this.lightsensor_btn = new System.Windows.Forms.Button();
            this.luxvalue = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.decimalplace_output = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.fu_buffer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_runtest
            // 
            this.btn_runtest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_runtest.Location = new System.Drawing.Point(174, 9);
            this.btn_runtest.Name = "btn_runtest";
            this.btn_runtest.Size = new System.Drawing.Size(64, 23);
            this.btn_runtest.TabIndex = 0;
            this.btn_runtest.Text = "&Run Test";
            this.btn_runtest.UseVisualStyleBackColor = false;
            this.btn_runtest.Click += new System.EventHandler(this.btn_runtest_Click);
            // 
            // comport_dc
            // 
            this.comport_dc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comport_dc.Location = new System.Drawing.Point(93, 10);
            this.comport_dc.Name = "comport_dc";
            this.comport_dc.Size = new System.Drawing.Size(75, 23);
            this.comport_dc.TabIndex = 8;
            this.comport_dc.Text = "&Disconnect";
            this.comport_dc.UseVisualStyleBackColor = false;
            this.comport_dc.Click += new System.EventHandler(this.comport_dc_Click);
            // 
            // lft_btn
            // 
            this.lft_btn.Image = global::Daniels_LightTestApplication.Properties.Resources.lft_arrow;
            this.lft_btn.Location = new System.Drawing.Point(723, 79);
            this.lft_btn.Name = "lft_btn";
            this.lft_btn.Size = new System.Drawing.Size(37, 37);
            this.lft_btn.TabIndex = 12;
            this.lft_btn.UseVisualStyleBackColor = true;
            this.lft_btn.Click += new System.EventHandler(this.lft_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.Image = global::Daniels_LightTestApplication.Properties.Resources.rght_arrow;
            this.right_btn.Location = new System.Drawing.Point(830, 79);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(37, 37);
            this.right_btn.TabIndex = 11;
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // up_btn
            // 
            this.up_btn.Image = global::Daniels_LightTestApplication.Properties.Resources.up_arrow1;
            this.up_btn.Location = new System.Drawing.Point(776, 38);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(37, 37);
            this.up_btn.TabIndex = 10;
            this.up_btn.UseVisualStyleBackColor = true;
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // dwn_btn
            // 
            this.dwn_btn.Location = new System.Drawing.Point(776, 119);
            this.dwn_btn.Name = "dwn_btn";
            this.dwn_btn.Size = new System.Drawing.Size(37, 37);
            this.dwn_btn.TabIndex = 9;
            this.dwn_btn.UseVisualStyleBackColor = true;
            this.dwn_btn.Click += new System.EventHandler(this.dwn_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Location = new System.Drawing.Point(766, 81);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(58, 32);
            this.home_btn.TabIndex = 13;
            this.home_btn.Text = "HOME";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.connect_btn.Location = new System.Drawing.Point(12, 10);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 14;
            this.connect_btn.Text = "&Connect";
            this.connect_btn.UseVisualStyleBackColor = false;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.Location = new System.Drawing.Point(11, 176);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(520, 101);
            this.Output.TabIndex = 15;
            // 
            // xdeglbl
            // 
            this.xdeglbl.AutoSize = true;
            this.xdeglbl.Location = new System.Drawing.Point(340, 153);
            this.xdeglbl.Name = "xdeglbl";
            this.xdeglbl.Size = new System.Drawing.Size(18, 13);
            this.xdeglbl.TabIndex = 16;
            this.xdeglbl.Text = "X°";
            // 
            // ydeglbl
            // 
            this.ydeglbl.AutoSize = true;
            this.ydeglbl.Location = new System.Drawing.Point(414, 153);
            this.ydeglbl.Name = "ydeglbl";
            this.ydeglbl.Size = new System.Drawing.Size(18, 13);
            this.ydeglbl.TabIndex = 17;
            this.ydeglbl.Text = "Y°";
            // 
            // xdeg_txt
            // 
            this.xdeg_txt.Location = new System.Drawing.Point(290, 150);
            this.xdeg_txt.Name = "xdeg_txt";
            this.xdeg_txt.Size = new System.Drawing.Size(48, 20);
            this.xdeg_txt.TabIndex = 18;
            // 
            // ydeg_txt
            // 
            this.ydeg_txt.Location = new System.Drawing.Point(364, 150);
            this.ydeg_txt.Name = "ydeg_txt";
            this.ydeg_txt.Size = new System.Drawing.Size(48, 20);
            this.ydeg_txt.TabIndex = 19;
            // 
            // goto_btn
            // 
            this.goto_btn.Location = new System.Drawing.Point(450, 148);
            this.goto_btn.Name = "goto_btn";
            this.goto_btn.Size = new System.Drawing.Size(70, 23);
            this.goto_btn.TabIndex = 20;
            this.goto_btn.Text = "&Go To!";
            this.goto_btn.UseVisualStyleBackColor = true;
            this.goto_btn.Click += new System.EventHandler(this.goto_btn_Click);
            // 
            // manualcontrol_lb
            // 
            this.manualcontrol_lb.AutoSize = true;
            this.manualcontrol_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualcontrol_lb.Location = new System.Drawing.Point(736, 20);
            this.manualcontrol_lb.Name = "manualcontrol_lb";
            this.manualcontrol_lb.Size = new System.Drawing.Size(121, 13);
            this.manualcontrol_lb.TabIndex = 21;
            this.manualcontrol_lb.Text = "MANUAL CONTROL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Interior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Exterior";
            // 
            // home_interior_text
            // 
            this.home_interior_text.Location = new System.Drawing.Point(290, 43);
            this.home_interior_text.Name = "home_interior_text";
            this.home_interior_text.Size = new System.Drawing.Size(53, 20);
            this.home_interior_text.TabIndex = 24;
            // 
            // home_exterior_text
            // 
            this.home_exterior_text.Location = new System.Drawing.Point(290, 78);
            this.home_exterior_text.Name = "home_exterior_text";
            this.home_exterior_text.Size = new System.Drawing.Size(53, 20);
            this.home_exterior_text.TabIndex = 25;
            // 
            // home_interior_clk
            // 
            this.home_interior_clk.Location = new System.Drawing.Point(349, 30);
            this.home_interior_clk.Name = "home_interior_clk";
            this.home_interior_clk.Size = new System.Drawing.Size(65, 38);
            this.home_interior_clk.TabIndex = 26;
            this.home_interior_clk.Text = "Clockwise";
            this.home_interior_clk.UseVisualStyleBackColor = true;
            this.home_interior_clk.Click += new System.EventHandler(this.home_interior_clk_Click);
            // 
            // home_interior_counter
            // 
            this.home_interior_counter.Location = new System.Drawing.Point(420, 30);
            this.home_interior_counter.Name = "home_interior_counter";
            this.home_interior_counter.Size = new System.Drawing.Size(103, 38);
            this.home_interior_counter.TabIndex = 27;
            this.home_interior_counter.Text = "Counter-Clockwise";
            this.home_interior_counter.UseVisualStyleBackColor = true;
            this.home_interior_counter.Click += new System.EventHandler(this.home_interior_counter_Click);
            // 
            // home_exterior_counter
            // 
            this.home_exterior_counter.Location = new System.Drawing.Point(420, 72);
            this.home_exterior_counter.Name = "home_exterior_counter";
            this.home_exterior_counter.Size = new System.Drawing.Size(103, 38);
            this.home_exterior_counter.TabIndex = 29;
            this.home_exterior_counter.Text = "Counter-Clockwise";
            this.home_exterior_counter.UseVisualStyleBackColor = true;
            this.home_exterior_counter.Click += new System.EventHandler(this.home_exterior_counter_Click);
            // 
            // home_exterior_clock
            // 
            this.home_exterior_clock.Location = new System.Drawing.Point(349, 72);
            this.home_exterior_clock.Name = "home_exterior_clock";
            this.home_exterior_clock.Size = new System.Drawing.Size(65, 38);
            this.home_exterior_clock.TabIndex = 28;
            this.home_exterior_clock.Text = "Clockwise";
            this.home_exterior_clock.UseVisualStyleBackColor = true;
            this.home_exterior_clock.Click += new System.EventHandler(this.home_exterior_clock_Click);
            // 
            // sethome_bt
            // 
            this.sethome_bt.Location = new System.Drawing.Point(349, 116);
            this.sethome_bt.Name = "sethome_bt";
            this.sethome_bt.Size = new System.Drawing.Size(174, 23);
            this.sethome_bt.TabIndex = 30;
            this.sethome_bt.Text = "Set Home";
            this.sethome_bt.UseVisualStyleBackColor = true;
            this.sethome_bt.Click += new System.EventHandler(this.sethome_bt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "(deg)";
            // 
            // lightsensor_comport
            // 
            this.lightsensor_comport.Items.Add("COM2");
            this.lightsensor_comport.Items.Add("COM4");
            this.lightsensor_comport.Location = new System.Drawing.Point(12, 46);
            this.lightsensor_comport.Name = "lightsensor_comport";
            this.lightsensor_comport.Size = new System.Drawing.Size(182, 20);
            this.lightsensor_comport.TabIndex = 32;
            this.lightsensor_comport.Text = "Light Sensor COM Port";
            // 
            // lightsensor_btn
            // 
            this.lightsensor_btn.Location = new System.Drawing.Point(12, 71);
            this.lightsensor_btn.Name = "lightsensor_btn";
            this.lightsensor_btn.Size = new System.Drawing.Size(182, 23);
            this.lightsensor_btn.TabIndex = 33;
            this.lightsensor_btn.Text = "Connect Light Sensor";
            this.lightsensor_btn.UseVisualStyleBackColor = true;
            this.lightsensor_btn.Click += new System.EventHandler(this.lightsensor_btn_Click);
            // 
            // luxvalue
            // 
            this.luxvalue.Location = new System.Drawing.Point(39, 97);
            this.luxvalue.Name = "luxvalue";
            this.luxvalue.Size = new System.Drawing.Size(48, 20);
            this.luxvalue.TabIndex = 34;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "LUX";
            // 
            // decimalplace_output
            // 
            this.decimalplace_output.Location = new System.Drawing.Point(174, 97);
            this.decimalplace_output.Name = "decimalplace_output";
            this.decimalplace_output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.decimalplace_output.Size = new System.Drawing.Size(20, 20);
            this.decimalplace_output.TabIndex = 36;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(93, 100);
            this.label.Name = "label";
            this.label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label.Size = new System.Drawing.Size(75, 13);
            this.label.TabIndex = 37;
            this.label.Text = "Decimal Place";
            // 
            // fu_buffer
            // 
            this.fu_buffer.Location = new System.Drawing.Point(39, 123);
            this.fu_buffer.Name = "fu_buffer";
            this.fu_buffer.Size = new System.Drawing.Size(155, 20);
            this.fu_buffer.TabIndex = 38;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(549, 289);
            this.Controls.Add(this.fu_buffer);
            this.Controls.Add(this.label);
            this.Controls.Add(this.decimalplace_output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luxvalue);
            this.Controls.Add(this.lightsensor_btn);
            this.Controls.Add(this.lightsensor_comport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sethome_bt);
            this.Controls.Add(this.home_exterior_counter);
            this.Controls.Add(this.home_exterior_clock);
            this.Controls.Add(this.home_interior_counter);
            this.Controls.Add(this.home_interior_clk);
            this.Controls.Add(this.home_exterior_text);
            this.Controls.Add(this.home_interior_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manualcontrol_lb);
            this.Controls.Add(this.goto_btn);
            this.Controls.Add(this.ydeg_txt);
            this.Controls.Add(this.xdeg_txt);
            this.Controls.Add(this.ydeglbl);
            this.Controls.Add(this.xdeglbl);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.lft_btn);
            this.Controls.Add(this.right_btn);
            this.Controls.Add(this.up_btn);
            this.Controls.Add(this.dwn_btn);
            this.Controls.Add(this.comport_dc);
            this.Controls.Add(this.btn_runtest);
            this.Name = "MainForm";
            this.Text = "Light Test Application";
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_runtest;
        private System.Windows.Forms.Button comport_dc;
        private System.Windows.Forms.Button dwn_btn;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Button lft_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label xdeglbl;
        private System.Windows.Forms.Label ydeglbl;
        private System.Windows.Forms.TextBox xdeg_txt;
        private System.Windows.Forms.TextBox ydeg_txt;
        private System.Windows.Forms.Button goto_btn;
        private System.Windows.Forms.Label manualcontrol_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox home_interior_text;
        private System.Windows.Forms.TextBox home_exterior_text;
        private System.Windows.Forms.Button home_interior_clk;
        private System.Windows.Forms.Button home_interior_counter;
        private System.Windows.Forms.Button home_exterior_counter;
        private System.Windows.Forms.Button home_exterior_clock;
        private System.Windows.Forms.Button sethome_bt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown lightsensor_comport;
        private System.Windows.Forms.Button lightsensor_btn;
        public System.Windows.Forms.TextBox luxvalue;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.TextBox decimalplace_output;
        private System.Windows.Forms.TextBox fu_buffer;

        public System.EventHandler abort_btn_Click { get; set; }
    }
}

