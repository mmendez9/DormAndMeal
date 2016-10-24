namespace DormAndMeal
{
    partial class Total
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
            this.dormPlan = new System.Windows.Forms.Label();
            this.mealPlan = new System.Windows.Forms.Label();
            this.totalCharges = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dormPlan
            // 
            this.dormPlan.AutoSize = true;
            this.dormPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dormPlan.Location = new System.Drawing.Point(35, 59);
            this.dormPlan.Name = "dormPlan";
            this.dormPlan.Size = new System.Drawing.Size(45, 16);
            this.dormPlan.TabIndex = 0;
            this.dormPlan.Text = "label1";
            // 
            // mealPlan
            // 
            this.mealPlan.AutoSize = true;
            this.mealPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealPlan.Location = new System.Drawing.Point(35, 87);
            this.mealPlan.Name = "mealPlan";
            this.mealPlan.Size = new System.Drawing.Size(45, 16);
            this.mealPlan.TabIndex = 1;
            this.mealPlan.Text = "label2";
            // 
            // totalCharges
            // 
            this.totalCharges.AutoSize = true;
            this.totalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCharges.Location = new System.Drawing.Point(35, 158);
            this.totalCharges.Name = "totalCharges";
            this.totalCharges.Size = new System.Drawing.Size(45, 16);
            this.totalCharges.TabIndex = 2;
            this.totalCharges.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dormitory and Meal Plans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Charges";
            // 
            // Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalCharges);
            this.Controls.Add(this.mealPlan);
            this.Controls.Add(this.dormPlan);
            this.Name = "Total";
            this.Text = "Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label dormPlan;
        public System.Windows.Forms.Label mealPlan;
        public System.Windows.Forms.Label totalCharges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}