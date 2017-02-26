namespace CodeChalenge
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComputeCost = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.weight = new System.Windows.Forms.TextBox();
            this.depth = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height (cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width (cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depth (cm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Weight (kg)";
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(86, 179);
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Size = new System.Drawing.Size(100, 20);
            this.category.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Category:";
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(86, 205);
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Size = new System.Drawing.Size(100, 20);
            this.cost.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cost ($) :";
            // 
            // ComputeCost
            // 
            this.ComputeCost.Location = new System.Drawing.Point(86, 133);
            this.ComputeCost.Name = "ComputeCost";
            this.ComputeCost.Size = new System.Drawing.Size(100, 23);
            this.ComputeCost.TabIndex = 5;
            this.ComputeCost.Text = "Compute Cost";
            this.ComputeCost.UseVisualStyleBackColor = true;
            this.ComputeCost.Click += new System.EventHandler(this.ComputeCost_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(86, 231);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(100, 23);
            this.close.TabIndex = 8;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(86, 32);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 20);
            this.weight.TabIndex = 1;
            this.weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_KeyPress);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(86, 107);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(100, 20);
            this.depth.TabIndex = 4;
            this.depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depth_KeyPress);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(86, 81);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 20);
            this.width.TabIndex = 3;
            this.width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.width_KeyPress);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(85, 58);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 20);
            this.height.TabIndex = 2;
            this.height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_KeyPress);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.close);
            this.Controls.Add(this.ComputeCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Text = "Cost Delivery Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ComputeCost;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

