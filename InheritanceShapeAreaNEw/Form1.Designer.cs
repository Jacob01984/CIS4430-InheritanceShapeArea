namespace InheritanceShapeAreaNEw
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numBase = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.numSide = new System.Windows.Forms.NumericUpDown();
            this.lblSide = new System.Windows.Forms.Label();
            this.btnShape = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnTrap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSide)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(515, 77);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(242, 249);
            this.txtOutput.TabIndex = 0;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(227, 77);
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(120, 23);
            this.numHeight.TabIndex = 1;
            // 
            // numBase
            // 
            this.numBase.Location = new System.Drawing.Point(227, 115);
            this.numBase.Name = "numBase";
            this.numBase.Size = new System.Drawing.Size(120, 23);
            this.numBase.TabIndex = 2;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(153, 77);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(43, 15);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height";
            this.lblHeight.Click += new System.EventHandler(this.lblHeight_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(153, 115);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 15);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Base";
            // 
            // numSide
            // 
            this.numSide.Location = new System.Drawing.Point(227, 154);
            this.numSide.Name = "numSide";
            this.numSide.Size = new System.Drawing.Size(120, 23);
            this.numSide.TabIndex = 5;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(153, 154);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(29, 15);
            this.lblSide.TabIndex = 6;
            this.lblSide.Text = "Side";
            // 
            // btnShape
            // 
            this.btnShape.Location = new System.Drawing.Point(153, 219);
            this.btnShape.Name = "btnShape";
            this.btnShape.Size = new System.Drawing.Size(75, 23);
            this.btnShape.TabIndex = 7;
            this.btnShape.Text = "Shape";
            this.btnShape.UseVisualStyleBackColor = true;
            this.btnShape.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(248, 219);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(75, 23);
            this.btnSquare.TabIndex = 8;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(153, 262);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnTriangle.TabIndex = 9;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnTrap
            // 
            this.btnTrap.Location = new System.Drawing.Point(248, 262);
            this.btnTrap.Name = "btnTrap";
            this.btnTrap.Size = new System.Drawing.Size(75, 23);
            this.btnTrap.TabIndex = 10;
            this.btnTrap.Text = "Trapazoid";
            this.btnTrap.UseVisualStyleBackColor = true;
            this.btnTrap.Click += new System.EventHandler(this.btnTrap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrap);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnShape);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.numSide);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.numBase);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtOutput;
        private NumericUpDown numHeight;
        private NumericUpDown numBase;
        private Label lblHeight;
        private Label lblBase;
        private NumericUpDown numSide;
        private Label lblSide;
        private Button btnShape;
        private Button btnSquare;
        private Button btnTriangle;
        private Button btnTrap;
    }
}