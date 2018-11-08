namespace Command.Pattern.WForm
{
    using System.Windows.Forms;

    public partial class MainForm: Form
    {
        private Panel panel1;
        private FlowLayoutPanel headerContainer;
        private Button squareButton;
        private Button rectangleButton;
        private Button triangleButton;
        private Button undoButton;
        private Panel bodyContainer;

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.squareButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.bodyContainer = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.headerContainer.SuspendLayout();
            this.bodyContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.headerContainer);
            this.panel1.Controls.Add(this.bodyContainer);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 681);
            this.panel1.TabIndex = 0;
            // 
            // headerContainer
            // 
            this.headerContainer.Controls.Add(this.squareButton);
            this.headerContainer.Controls.Add(this.rectangleButton);
            this.headerContainer.Controls.Add(this.triangleButton);
            this.headerContainer.Controls.Add(this.undoButton);
            this.headerContainer.Location = new System.Drawing.Point(3, 3);
            this.headerContainer.Name = "headerContainer";
            this.headerContainer.Size = new System.Drawing.Size(796, 107);
            this.headerContainer.TabIndex = 4;
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(3, 3);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(105, 83);
            this.squareButton.TabIndex = 0;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(114, 3);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(105, 83);
            this.rectangleButton.TabIndex = 1;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(225, 3);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(105, 83);
            this.triangleButton.TabIndex = 2;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.Color.Red;
            this.undoButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.undoButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.undoButton.Location = new System.Drawing.Point(336, 3);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(105, 83);
            this.undoButton.TabIndex = 3;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // bodyContainer
            // 
            this.bodyContainer.BackColor = System.Drawing.Color.White;
            this.bodyContainer.Controls.Add(this.canvas);
            this.bodyContainer.Location = new System.Drawing.Point(3, 116);
            this.bodyContainer.Name = "bodyContainer";
            this.bodyContainer.Size = new System.Drawing.Size(796, 562);
            this.bodyContainer.TabIndex = 3;
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(3, 4);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(790, 558);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 705);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Command pattern";
            this.panel1.ResumeLayout(false);
            this.headerContainer.ResumeLayout(false);
            this.bodyContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        private PictureBox canvas;
    }
}
