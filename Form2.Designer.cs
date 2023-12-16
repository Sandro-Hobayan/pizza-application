namespace pizza_application
{
    partial class Form2
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
            grppizza = new GroupBox();
            radveggie = new RadioButton();
            radpepperoni = new RadioButton();
            radhamandcheese = new RadioButton();
            radhawaian = new RadioButton();
            grpsize = new GroupBox();
            radextralarge = new RadioButton();
            radlarge = new RadioButton();
            radmedium = new RadioButton();
            radsmall = new RadioButton();
            grpcrusttype = new GroupBox();
            radthick = new RadioButton();
            radthin = new RadioButton();
            grpextratoppings = new GroupBox();
            chkpeppers = new CheckBox();
            chkpineapple = new CheckBox();
            chktomatoes = new CheckBox();
            chkonions = new CheckBox();
            chkmushrooms = new CheckBox();
            chkextracheese = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            lblamount = new Label();
            lbltotalamount = new Label();
            panel3 = new Panel();
            label2 = new Label();
            lbltoppstotal = new Label();
            lbltoppings2 = new Label();
            lbltoppings1 = new Label();
            lblextra = new Label();
            panel2 = new Panel();
            lbltotall = new Label();
            lbltotal = new Label();
            lblcrustprice = new Label();
            lblsizeprize = new Label();
            lblcrustt = new Label();
            lblsizee = new Label();
            lblextratoppings = new Label();
            lblsize = new Label();
            lblpizza = new Label();
            lblyourorder = new Label();
            button3 = new Button();
            grppizza.SuspendLayout();
            grpsize.SuspendLayout();
            grpcrusttype.SuspendLayout();
            grpextratoppings.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // grppizza
            // 
            grppizza.BackColor = SystemColors.InactiveBorder;
            grppizza.Controls.Add(radveggie);
            grppizza.Controls.Add(radpepperoni);
            grppizza.Controls.Add(radhamandcheese);
            grppizza.Controls.Add(radhawaian);
            grppizza.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grppizza.Location = new Point(12, 44);
            grppizza.Name = "grppizza";
            grppizza.Size = new Size(534, 75);
            grppizza.TabIndex = 0;
            grppizza.TabStop = false;
            grppizza.Text = "Pizza:";
            // 
            // radveggie
            // 
            radveggie.AutoSize = true;
            radveggie.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radveggie.Location = new Point(425, 33);
            radveggie.Name = "radveggie";
            radveggie.Size = new Size(91, 29);
            radveggie.TabIndex = 3;
            radveggie.Text = "Veggie";
            radveggie.UseVisualStyleBackColor = true;
            radveggie.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radpepperoni
            // 
            radpepperoni.AutoSize = true;
            radpepperoni.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radpepperoni.Location = new Point(300, 33);
            radpepperoni.Name = "radpepperoni";
            radpepperoni.Size = new Size(119, 29);
            radpepperoni.TabIndex = 2;
            radpepperoni.Text = "Pepperoni";
            radpepperoni.UseVisualStyleBackColor = true;
            radpepperoni.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radhamandcheese
            // 
            radhamandcheese.AutoSize = true;
            radhamandcheese.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radhamandcheese.Location = new Point(119, 33);
            radhamandcheese.Name = "radhamandcheese";
            radhamandcheese.Size = new Size(175, 29);
            radhamandcheese.TabIndex = 1;
            radhamandcheese.Text = "Ham and Cheese";
            radhamandcheese.UseVisualStyleBackColor = true;
            radhamandcheese.CheckedChanged += radhamandcheese_CheckedChanged;
            // 
            // radhawaian
            // 
            radhawaian.AutoSize = true;
            radhawaian.Checked = true;
            radhawaian.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radhawaian.Location = new Point(6, 33);
            radhawaian.Name = "radhawaian";
            radhawaian.Size = new Size(107, 29);
            radhawaian.TabIndex = 0;
            radhawaian.TabStop = true;
            radhawaian.Text = "Hawaian";
            radhawaian.UseVisualStyleBackColor = true;
            radhawaian.CheckedChanged += radhawaian_CheckedChanged;
            // 
            // grpsize
            // 
            grpsize.BackColor = SystemColors.InactiveBorder;
            grpsize.Controls.Add(radextralarge);
            grpsize.Controls.Add(radlarge);
            grpsize.Controls.Add(radmedium);
            grpsize.Controls.Add(radsmall);
            grpsize.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpsize.Location = new Point(12, 125);
            grpsize.Name = "grpsize";
            grpsize.Size = new Size(534, 75);
            grpsize.TabIndex = 1;
            grpsize.TabStop = false;
            grpsize.Text = "Size:";
            // 
            // radextralarge
            // 
            radextralarge.AutoSize = true;
            radextralarge.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radextralarge.Location = new Point(403, 33);
            radextralarge.Name = "radextralarge";
            radextralarge.Size = new Size(125, 29);
            radextralarge.TabIndex = 6;
            radextralarge.Text = "Extra large";
            radextralarge.UseVisualStyleBackColor = true;
            radextralarge.CheckedChanged += radextralarge_CheckedChanged;
            // 
            // radlarge
            // 
            radlarge.AutoSize = true;
            radlarge.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radlarge.Location = new Point(270, 33);
            radlarge.Name = "radlarge";
            radlarge.Size = new Size(80, 29);
            radlarge.TabIndex = 5;
            radlarge.Text = "Large";
            radlarge.UseVisualStyleBackColor = true;
            radlarge.CheckedChanged += radlarge_CheckedChanged;
            // 
            // radmedium
            // 
            radmedium.AutoSize = true;
            radmedium.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radmedium.Location = new Point(119, 33);
            radmedium.Name = "radmedium";
            radmedium.Size = new Size(103, 29);
            radmedium.TabIndex = 4;
            radmedium.Text = "Medium";
            radmedium.UseVisualStyleBackColor = true;
            radmedium.CheckedChanged += radmedium_CheckedChanged;
            // 
            // radsmall
            // 
            radsmall.AutoSize = true;
            radsmall.Checked = true;
            radsmall.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radsmall.Location = new Point(6, 33);
            radsmall.Name = "radsmall";
            radsmall.Size = new Size(79, 29);
            radsmall.TabIndex = 4;
            radsmall.TabStop = true;
            radsmall.Text = "Small";
            radsmall.UseVisualStyleBackColor = true;
            radsmall.CheckedChanged += radsmall_CheckedChanged;
            // 
            // grpcrusttype
            // 
            grpcrusttype.BackColor = SystemColors.InactiveBorder;
            grpcrusttype.Controls.Add(radthick);
            grpcrusttype.Controls.Add(radthin);
            grpcrusttype.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpcrusttype.Location = new Point(12, 206);
            grpcrusttype.Name = "grpcrusttype";
            grpcrusttype.Size = new Size(534, 75);
            grpcrusttype.TabIndex = 2;
            grpcrusttype.TabStop = false;
            grpcrusttype.Text = "Crust Type:";
            // 
            // radthick
            // 
            radthick.AutoSize = true;
            radthick.Checked = true;
            radthick.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radthick.Location = new Point(119, 33);
            radthick.Name = "radthick";
            radthick.Size = new Size(79, 29);
            radthick.TabIndex = 2;
            radthick.TabStop = true;
            radthick.Text = "Thick";
            radthick.UseVisualStyleBackColor = true;
            radthick.CheckedChanged += radthick_CheckedChanged;
            // 
            // radthin
            // 
            radthin.AutoSize = true;
            radthin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radthin.Location = new Point(300, 33);
            radthin.Name = "radthin";
            radthin.Size = new Size(71, 29);
            radthin.TabIndex = 1;
            radthin.Text = "Thin";
            radthin.UseVisualStyleBackColor = true;
            radthin.CheckedChanged += radthin_CheckedChanged;
            // 
            // grpextratoppings
            // 
            grpextratoppings.BackColor = SystemColors.InactiveBorder;
            grpextratoppings.Controls.Add(chkpeppers);
            grpextratoppings.Controls.Add(chkpineapple);
            grpextratoppings.Controls.Add(chktomatoes);
            grpextratoppings.Controls.Add(chkonions);
            grpextratoppings.Controls.Add(chkmushrooms);
            grpextratoppings.Controls.Add(chkextracheese);
            grpextratoppings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grpextratoppings.Location = new Point(12, 287);
            grpextratoppings.Name = "grpextratoppings";
            grpextratoppings.Size = new Size(534, 113);
            grpextratoppings.TabIndex = 3;
            grpextratoppings.TabStop = false;
            grpextratoppings.Text = "Extra Toppings:";
            // 
            // chkpeppers
            // 
            chkpeppers.AutoSize = true;
            chkpeppers.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkpeppers.Location = new Point(403, 68);
            chkpeppers.Name = "chkpeppers";
            chkpeppers.Size = new Size(101, 29);
            chkpeppers.TabIndex = 8;
            chkpeppers.Text = "Peppers";
            chkpeppers.UseVisualStyleBackColor = true;
            chkpeppers.CheckedChanged += chkpeppers_CheckedChanged;
            // 
            // chkpineapple
            // 
            chkpineapple.AutoSize = true;
            chkpineapple.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkpineapple.Location = new Point(199, 68);
            chkpineapple.Name = "chkpineapple";
            chkpineapple.Size = new Size(118, 29);
            chkpineapple.TabIndex = 7;
            chkpineapple.Text = "Pineapple";
            chkpineapple.UseVisualStyleBackColor = true;
            chkpineapple.CheckedChanged += chkpineapple_CheckedChanged;
            // 
            // chktomatoes
            // 
            chktomatoes.AutoSize = true;
            chktomatoes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chktomatoes.Location = new Point(6, 68);
            chktomatoes.Name = "chktomatoes";
            chktomatoes.Size = new Size(116, 29);
            chktomatoes.TabIndex = 6;
            chktomatoes.Text = "Tomatoes";
            chktomatoes.UseVisualStyleBackColor = true;
            chktomatoes.CheckedChanged += chktomatoes_CheckedChanged;
            // 
            // chkonions
            // 
            chkonions.AutoSize = true;
            chkonions.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkonions.Location = new Point(403, 33);
            chkonions.Name = "chkonions";
            chkonions.Size = new Size(94, 29);
            chkonions.TabIndex = 5;
            chkonions.Text = "Onions";
            chkonions.UseVisualStyleBackColor = true;
            chkonions.CheckedChanged += chkonions_CheckedChanged;
            // 
            // chkmushrooms
            // 
            chkmushrooms.AutoSize = true;
            chkmushrooms.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkmushrooms.Location = new Point(199, 33);
            chkmushrooms.Name = "chkmushrooms";
            chkmushrooms.Size = new Size(134, 29);
            chkmushrooms.TabIndex = 4;
            chkmushrooms.Text = "Mushrooms";
            chkmushrooms.UseVisualStyleBackColor = true;
            chkmushrooms.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // chkextracheese
            // 
            chkextracheese.AutoSize = true;
            chkextracheese.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkextracheese.Location = new Point(6, 33);
            chkextracheese.Name = "chkextracheese";
            chkextracheese.Size = new Size(143, 29);
            chkextracheese.TabIndex = 0;
            chkextracheese.Text = "Extra Cheese";
            chkextracheese.UseVisualStyleBackColor = true;
            chkextracheese.CheckedChanged += chkextracheese_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(83, 406);
            button1.Name = "button1";
            button1.Size = new Size(172, 39);
            button1.TabIndex = 4;
            button1.Text = "PROCESS ORDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(282, 406);
            button2.Name = "button2";
            button2.Size = new Size(172, 39);
            button2.TabIndex = 5;
            button2.Text = "NEW ORDER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lbltoppings2);
            panel1.Controls.Add(lbltoppings1);
            panel1.Controls.Add(lblextra);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblcrustprice);
            panel1.Controls.Add(lblsizeprize);
            panel1.Controls.Add(lblcrustt);
            panel1.Controls.Add(lblsizee);
            panel1.Controls.Add(lblextratoppings);
            panel1.Controls.Add(lblsize);
            panel1.Controls.Add(lblpizza);
            panel1.Controls.Add(lblyourorder);
            panel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(552, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 412);
            panel1.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(lblamount);
            panel4.Controls.Add(lbltotalamount);
            panel4.Location = new Point(16, 362);
            panel4.Name = "panel4";
            panel4.Size = new Size(303, 36);
            panel4.TabIndex = 15;
            // 
            // lblamount
            // 
            lblamount.AutoSize = true;
            lblamount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblamount.Location = new Point(12, 7);
            lblamount.Name = "lblamount";
            lblamount.Size = new Size(115, 23);
            lblamount.TabIndex = 6;
            lblamount.Text = "Total amount:";
            // 
            // lbltotalamount
            // 
            lbltotalamount.AutoSize = true;
            lbltotalamount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbltotalamount.Location = new Point(215, 7);
            lbltotalamount.Name = "lbltotalamount";
            lbltotalamount.Size = new Size(19, 23);
            lbltotalamount.TabIndex = 14;
            lbltotalamount.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lbltoppstotal);
            panel3.Location = new Point(16, 308);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 36);
            panel3.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(12, 7);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 6;
            label2.Text = "Total toppings:";
            // 
            // lbltoppstotal
            // 
            lbltoppstotal.AutoSize = true;
            lbltoppstotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbltoppstotal.Location = new Point(215, 7);
            lbltoppstotal.Name = "lbltoppstotal";
            lbltoppstotal.Size = new Size(19, 23);
            lbltoppstotal.TabIndex = 14;
            lbltoppstotal.Text = "0";
            lbltoppstotal.Click += lbltoppstotal_Click;
            // 
            // lbltoppings2
            // 
            lbltoppings2.AutoSize = true;
            lbltoppings2.Location = new Point(26, 284);
            lbltoppings2.Name = "lbltoppings2";
            lbltoppings2.Size = new Size(0, 23);
            lbltoppings2.TabIndex = 13;
            // 
            // lbltoppings1
            // 
            lbltoppings1.AutoSize = true;
            lbltoppings1.Location = new Point(26, 252);
            lbltoppings1.Name = "lbltoppings1";
            lbltoppings1.Size = new Size(0, 23);
            lbltoppings1.TabIndex = 12;
            // 
            // lblextra
            // 
            lblextra.AutoSize = true;
            lblextra.Location = new Point(14, 219);
            lblextra.Name = "lblextra";
            lblextra.Size = new Size(125, 23);
            lblextra.TabIndex = 11;
            lblextra.Text = "Extra toppings:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(lbltotall);
            panel2.Controls.Add(lbltotal);
            panel2.Location = new Point(14, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 36);
            panel2.TabIndex = 10;
            // 
            // lbltotall
            // 
            lbltotall.AutoSize = true;
            lbltotall.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbltotall.Location = new Point(217, 7);
            lbltotall.Name = "lbltotall";
            lbltotall.Size = new Size(19, 23);
            lbltotall.TabIndex = 7;
            lbltotall.Text = "0";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lbltotal.Location = new Point(12, 7);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(49, 23);
            lbltotal.TabIndex = 6;
            lbltotal.Text = "total:";
            // 
            // lblcrustprice
            // 
            lblcrustprice.AutoSize = true;
            lblcrustprice.Location = new Point(231, 154);
            lblcrustprice.Name = "lblcrustprice";
            lblcrustprice.Size = new Size(19, 23);
            lblcrustprice.TabIndex = 9;
            lblcrustprice.Text = "0";
            lblcrustprice.Click += label1_Click;
            // 
            // lblsizeprize
            // 
            lblsizeprize.AutoSize = true;
            lblsizeprize.Location = new Point(231, 99);
            lblsizeprize.Name = "lblsizeprize";
            lblsizeprize.Size = new Size(19, 23);
            lblsizeprize.TabIndex = 8;
            lblsizeprize.Text = "0";
            lblsizeprize.Click += lblsizeprize_Click;
            // 
            // lblcrustt
            // 
            lblcrustt.AutoSize = true;
            lblcrustt.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcrustt.Location = new Point(42, 154);
            lblcrustt.Name = "lblcrustt";
            lblcrustt.Size = new Size(0, 20);
            lblcrustt.TabIndex = 5;
            // 
            // lblsizee
            // 
            lblsizee.AutoSize = true;
            lblsizee.Location = new Point(14, 76);
            lblsizee.Name = "lblsizee";
            lblsizee.Size = new Size(38, 23);
            lblsizee.TabIndex = 4;
            lblsizee.Text = "size";
            // 
            // lblextratoppings
            // 
            lblextratoppings.AutoSize = true;
            lblextratoppings.Location = new Point(16, 131);
            lblextratoppings.Name = "lblextratoppings";
            lblextratoppings.Size = new Size(51, 23);
            lblextratoppings.TabIndex = 3;
            lblextratoppings.Text = "crust:";
            // 
            // lblsize
            // 
            lblsize.AutoSize = true;
            lblsize.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsize.Location = new Point(42, 99);
            lblsize.Name = "lblsize";
            lblsize.Size = new Size(0, 20);
            lblsize.TabIndex = 2;
            // 
            // lblpizza
            // 
            lblpizza.AutoSize = true;
            lblpizza.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpizza.Location = new Point(42, 47);
            lblpizza.Name = "lblpizza";
            lblpizza.Size = new Size(0, 20);
            lblpizza.TabIndex = 1;
            lblpizza.Click += lblpizza_Click;
            // 
            // lblyourorder
            // 
            lblyourorder.AutoSize = true;
            lblyourorder.Location = new Point(16, 19);
            lblyourorder.Name = "lblyourorder";
            lblyourorder.Size = new Size(107, 23);
            lblyourorder.TabIndex = 0;
            lblyourorder.Text = "your order is";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(796, 462);
            button3.Name = "button3";
            button3.Size = new Size(101, 36);
            button3.TabIndex = 7;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(909, 510);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grpextratoppings);
            Controls.Add(grpcrusttype);
            Controls.Add(grpsize);
            Controls.Add(grppizza);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            grppizza.ResumeLayout(false);
            grppizza.PerformLayout();
            grpsize.ResumeLayout(false);
            grpsize.PerformLayout();
            grpcrusttype.ResumeLayout(false);
            grpcrusttype.PerformLayout();
            grpextratoppings.ResumeLayout(false);
            grpextratoppings.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grppizza;
        private RadioButton radveggie;
        private RadioButton radpepperoni;
        private RadioButton radhamandcheese;
        private RadioButton radhawaian;
        private GroupBox grpsize;
        private RadioButton radlarge;
        private RadioButton radmedium;
        private RadioButton radsmall;
        private GroupBox grpcrusttype;
        private GroupBox grpextratoppings;
        private RadioButton radextralarge;
        private RadioButton radthick;
        private RadioButton radthin;
        private CheckBox chkextracheese;
        private CheckBox chkmushrooms;
        private CheckBox chkonions;
        private CheckBox chkpineapple;
        private CheckBox chktomatoes;
        private Button button1;
        private Button button2;
        private CheckBox chkpeppers;
        private Panel panel1;
        private Label lblyourorder;
        private Label lblpizza;
        private Label lblsize;
        private Label lblextratoppings;
        private Label lblsizee;
        private Label lblcrustt;
        private Label lbltotal;
        private Label lbltotall;
        private Label lblsizeprize;
        private Label lblcrustprice;
        private Panel panel2;
        private Button button3;
        private Label lblextra;
        private Label lbltoppings2;
        private Label lbltoppings1;
        private Label lbltoppstotal;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label lblamount;
        private Label lbltotalamount;
    }
}