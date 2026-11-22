namespace BicycleMushroomApp
{
    partial class ChooseForm
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
            this.btnBicycle = new System.Windows.Forms.Button();
            this.btnMushroom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBicycle
            // 
            this.btnBicycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBicycle.Location = new System.Drawing.Point(118, 254);
            this.btnBicycle.Name = "btnBicycle";
            this.btnBicycle.Size = new System.Drawing.Size(192, 52);
            this.btnBicycle.TabIndex = 0;
            this.btnBicycle.Text = "Bicycle";
            this.btnBicycle.UseVisualStyleBackColor = true;
            this.btnBicycle.Click += new System.EventHandler(this.btnBicycle_Click_1);
            // 
            // btnMushroom
            // 
            this.btnMushroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMushroom.Location = new System.Drawing.Point(486, 254);
            this.btnMushroom.Name = "btnMushroom";
            this.btnMushroom.Size = new System.Drawing.Size(192, 52);
            this.btnMushroom.TabIndex = 1;
            this.btnMushroom.Text = "Mushroom";
            this.btnMushroom.UseVisualStyleBackColor = true;
            this.btnMushroom.Click += new System.EventHandler(this.btnMushroom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose App";
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMushroom);
            this.Controls.Add(this.btnBicycle);
            this.Name = "ChooseForm";
            this.Text = "ChooseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBicycle;
        private System.Windows.Forms.Button btnMushroom;
        private System.Windows.Forms.Label label1;
    }
}