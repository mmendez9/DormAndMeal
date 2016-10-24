namespace DormAndMeal
{
    partial class DormAndMeal
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
            this.grbDorm = new System.Windows.Forms.GroupBox();
            this.grbMeal = new System.Windows.Forms.GroupBox();
            this.rbAllen = new System.Windows.Forms.RadioButton();
            this.rbPike = new System.Windows.Forms.RadioButton();
            this.rbFar = new System.Windows.Forms.RadioButton();
            this.rbSuit = new System.Windows.Forms.RadioButton();
            this.allenAmount = new System.Windows.Forms.Label();
            this.pikeAmount = new System.Windows.Forms.Label();
            this.farAmount = new System.Windows.Forms.Label();
            this.suitAmount = new System.Windows.Forms.Label();
            this.meals7 = new System.Windows.Forms.RadioButton();
            this.meals14 = new System.Windows.Forms.RadioButton();
            this.unlimited = new System.Windows.Forms.RadioButton();
            this.amount7 = new System.Windows.Forms.Label();
            this.amount14 = new System.Windows.Forms.Label();
            this.amountUn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbDorm.SuspendLayout();
            this.grbMeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDorm
            // 
            this.grbDorm.Controls.Add(this.suitAmount);
            this.grbDorm.Controls.Add(this.farAmount);
            this.grbDorm.Controls.Add(this.pikeAmount);
            this.grbDorm.Controls.Add(this.allenAmount);
            this.grbDorm.Controls.Add(this.rbSuit);
            this.grbDorm.Controls.Add(this.rbFar);
            this.grbDorm.Controls.Add(this.rbPike);
            this.grbDorm.Controls.Add(this.rbAllen);
            this.grbDorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDorm.Location = new System.Drawing.Point(12, 12);
            this.grbDorm.Name = "grbDorm";
            this.grbDorm.Size = new System.Drawing.Size(284, 120);
            this.grbDorm.TabIndex = 0;
            this.grbDorm.TabStop = false;
            this.grbDorm.Text = "Dormitories";
            // 
            // grbMeal
            // 
            this.grbMeal.Controls.Add(this.amountUn);
            this.grbMeal.Controls.Add(this.amount14);
            this.grbMeal.Controls.Add(this.amount7);
            this.grbMeal.Controls.Add(this.unlimited);
            this.grbMeal.Controls.Add(this.meals14);
            this.grbMeal.Controls.Add(this.meals7);
            this.grbMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMeal.Location = new System.Drawing.Point(12, 138);
            this.grbMeal.Name = "grbMeal";
            this.grbMeal.Size = new System.Drawing.Size(284, 100);
            this.grbMeal.TabIndex = 1;
            this.grbMeal.TabStop = false;
            this.grbMeal.Text = "Meal Plan";
            // 
            // rbAllen
            // 
            this.rbAllen.AutoSize = true;
            this.rbAllen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllen.Location = new System.Drawing.Point(7, 20);
            this.rbAllen.Name = "rbAllen";
            this.rbAllen.Size = new System.Drawing.Size(77, 19);
            this.rbAllen.TabIndex = 0;
            this.rbAllen.TabStop = true;
            this.rbAllen.Text = "Allen Hall";
            this.rbAllen.UseVisualStyleBackColor = true;
            // 
            // rbPike
            // 
            this.rbPike.AutoSize = true;
            this.rbPike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPike.Location = new System.Drawing.Point(6, 43);
            this.rbPike.Name = "rbPike";
            this.rbPike.Size = new System.Drawing.Size(74, 19);
            this.rbPike.TabIndex = 1;
            this.rbPike.TabStop = true;
            this.rbPike.Text = "Pike Hall";
            this.rbPike.UseVisualStyleBackColor = true;
            // 
            // rbFar
            // 
            this.rbFar.AutoSize = true;
            this.rbFar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFar.Location = new System.Drawing.Point(7, 66);
            this.rbFar.Name = "rbFar";
            this.rbFar.Size = new System.Drawing.Size(95, 19);
            this.rbFar.TabIndex = 2;
            this.rbFar.TabStop = true;
            this.rbFar.Text = "Farthing Hall";
            this.rbFar.UseVisualStyleBackColor = true;
            // 
            // rbSuit
            // 
            this.rbSuit.AutoSize = true;
            this.rbSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuit.Location = new System.Drawing.Point(6, 89);
            this.rbSuit.Name = "rbSuit";
            this.rbSuit.Size = new System.Drawing.Size(114, 19);
            this.rbSuit.TabIndex = 3;
            this.rbSuit.TabStop = true;
            this.rbSuit.Text = "University Suites";
            this.rbSuit.UseVisualStyleBackColor = true;
            // 
            // allenAmount
            // 
            this.allenAmount.AutoSize = true;
            this.allenAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allenAmount.Location = new System.Drawing.Point(149, 23);
            this.allenAmount.Name = "allenAmount";
            this.allenAmount.Size = new System.Drawing.Size(120, 15);
            this.allenAmount.TabIndex = 4;
            this.allenAmount.Text = "$1,500 per semester";
            // 
            // pikeAmount
            // 
            this.pikeAmount.AutoSize = true;
            this.pikeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pikeAmount.Location = new System.Drawing.Point(149, 47);
            this.pikeAmount.Name = "pikeAmount";
            this.pikeAmount.Size = new System.Drawing.Size(120, 15);
            this.pikeAmount.TabIndex = 5;
            this.pikeAmount.Text = "$1,600 per semester";
            // 
            // farAmount
            // 
            this.farAmount.AutoSize = true;
            this.farAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farAmount.Location = new System.Drawing.Point(149, 69);
            this.farAmount.Name = "farAmount";
            this.farAmount.Size = new System.Drawing.Size(120, 15);
            this.farAmount.TabIndex = 6;
            this.farAmount.Text = "$1,800 per semester";
            // 
            // suitAmount
            // 
            this.suitAmount.AutoSize = true;
            this.suitAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suitAmount.Location = new System.Drawing.Point(149, 90);
            this.suitAmount.Name = "suitAmount";
            this.suitAmount.Size = new System.Drawing.Size(120, 15);
            this.suitAmount.TabIndex = 7;
            this.suitAmount.Text = "$2,500 per semester";
            // 
            // meals7
            // 
            this.meals7.AutoSize = true;
            this.meals7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meals7.Location = new System.Drawing.Point(7, 22);
            this.meals7.Name = "meals7";
            this.meals7.Size = new System.Drawing.Size(122, 19);
            this.meals7.TabIndex = 0;
            this.meals7.TabStop = true;
            this.meals7.Text = "7 meals per week";
            this.meals7.UseVisualStyleBackColor = true;
            // 
            // meals14
            // 
            this.meals14.AutoSize = true;
            this.meals14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meals14.Location = new System.Drawing.Point(7, 44);
            this.meals14.Name = "meals14";
            this.meals14.Size = new System.Drawing.Size(129, 19);
            this.meals14.TabIndex = 1;
            this.meals14.TabStop = true;
            this.meals14.Text = "14 meals per week";
            this.meals14.UseVisualStyleBackColor = true;
            // 
            // unlimited
            // 
            this.unlimited.AutoSize = true;
            this.unlimited.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlimited.Location = new System.Drawing.Point(6, 65);
            this.unlimited.Name = "unlimited";
            this.unlimited.Size = new System.Drawing.Size(113, 19);
            this.unlimited.TabIndex = 2;
            this.unlimited.TabStop = true;
            this.unlimited.Text = "unlimited meals";
            this.unlimited.UseVisualStyleBackColor = true;
            // 
            // amount7
            // 
            this.amount7.AutoSize = true;
            this.amount7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount7.Location = new System.Drawing.Point(149, 24);
            this.amount7.Name = "amount7";
            this.amount7.Size = new System.Drawing.Size(110, 15);
            this.amount7.TabIndex = 3;
            this.amount7.Text = "$600 per semester";
            // 
            // amount14
            // 
            this.amount14.AutoSize = true;
            this.amount14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount14.Location = new System.Drawing.Point(149, 44);
            this.amount14.Name = "amount14";
            this.amount14.Size = new System.Drawing.Size(120, 15);
            this.amount14.TabIndex = 4;
            this.amount14.Text = "$1,200 per semester";
            // 
            // amountUn
            // 
            this.amountUn.AutoSize = true;
            this.amountUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountUn.Location = new System.Drawing.Point(149, 65);
            this.amountUn.Name = "amountUn";
            this.amountUn.Size = new System.Drawing.Size(120, 15);
            this.amountUn.TabIndex = 5;
            this.amountUn.Text = "$1,700 per semester";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DormAndMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbMeal);
            this.Controls.Add(this.grbDorm);
            this.Name = "DormAndMeal";
            this.Text = "Dormitory and Meal Plans";
            this.grbDorm.ResumeLayout(false);
            this.grbDorm.PerformLayout();
            this.grbMeal.ResumeLayout(false);
            this.grbMeal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDorm;
        private System.Windows.Forms.RadioButton rbPike;
        private System.Windows.Forms.RadioButton rbAllen;
        private System.Windows.Forms.GroupBox grbMeal;
        private System.Windows.Forms.RadioButton rbSuit;
        private System.Windows.Forms.RadioButton rbFar;
        private System.Windows.Forms.Label suitAmount;
        private System.Windows.Forms.Label farAmount;
        private System.Windows.Forms.Label pikeAmount;
        private System.Windows.Forms.Label allenAmount;
        private System.Windows.Forms.Label amountUn;
        private System.Windows.Forms.Label amount14;
        private System.Windows.Forms.Label amount7;
        private System.Windows.Forms.RadioButton unlimited;
        private System.Windows.Forms.RadioButton meals14;
        private System.Windows.Forms.RadioButton meals7;
        private System.Windows.Forms.Button button1;
    }
}

