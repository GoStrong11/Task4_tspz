using System.Drawing;
using System.Windows.Forms;

namespace AreaCalculator
{
    partial class MainForm
    {
        private Label sideLengthLabel;
        private Label radiusLabel;
        private TextBox sideLengthTextBox;
        private TextBox radiusTextBox;
        private Label squareAreaLabel;
        private Label circleAreaLabel;
        private Label resultLabel;
        private Button runButton;
        private Button exitButton;
        private Button aboutButton;
        private TextBox squareAreaTextBox;
        private TextBox circleAreaTextBox;
        private TextBox largerAreaTextBox;
        private Label resultLable;

        private void InitializeComponent()
        {
            this.sideLengthLabel = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.sideLengthTextBox = new System.Windows.Forms.TextBox();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.squareAreaLabel = new System.Windows.Forms.Label();
            this.circleAreaLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.squareAreaTextBox = new System.Windows.Forms.TextBox();
            this.circleAreaTextBox = new System.Windows.Forms.TextBox();
            this.squareTextLabel = new System.Windows.Forms.Label();
            this.circleTextLabel = new System.Windows.Forms.Label();
            this.largerAreaLabel = new System.Windows.Forms.Label();
            this.largerAreaTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
 
            this.sideLengthLabel.AutoSize = true;
            this.sideLengthLabel.Location = new System.Drawing.Point(282, 80);
            this.sideLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sideLengthLabel.Name = "sideLengthLabel";
            this.sideLengthLabel.Size = new System.Drawing.Size(52, 13);
            this.sideLengthLabel.TabIndex = 0;
            this.sideLengthLabel.Text = "Сторона:";
            this.sideLengthLabel.Click += new System.EventHandler(this.sideLengthLabel_Click);

            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(282, 161);
            this.radiusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(42, 13);
            this.radiusLabel.TabIndex = 1;
            this.radiusLabel.Text = "Радіус:";
            this.radiusLabel.Click += new System.EventHandler(this.radiusLabel_Click);

            this.sideLengthTextBox.Location = new System.Drawing.Point(285, 95);
            this.sideLengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sideLengthTextBox.Name = "sideLengthTextBox";
            this.sideLengthTextBox.Size = new System.Drawing.Size(97, 20);
            this.sideLengthTextBox.TabIndex = 2;
            this.sideLengthTextBox.TextChanged += new System.EventHandler(this.sideLengthTextBox_TextChanged);

            this.radiusTextBox.Location = new System.Drawing.Point(285, 176);
            this.radiusTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(97, 20);
            this.radiusTextBox.TabIndex = 3;
            this.radiusTextBox.TextChanged += new System.EventHandler(this.radiusTextBox_TextChanged);

            this.squareAreaLabel.AutoSize = true;
            this.squareAreaLabel.Location = new System.Drawing.Point(395, 80);
            this.squareAreaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.squareAreaLabel.Name = "squareAreaLabel";
            this.squareAreaLabel.Size = new System.Drawing.Size(45, 13);
            this.squareAreaLabel.TabIndex = 4;
            this.squareAreaLabel.Text = "Площа:";
            this.squareAreaLabel.Click += new System.EventHandler(this.squareAreaLabel_Click_1);

            this.circleAreaLabel.AutoSize = true;
            this.circleAreaLabel.Location = new System.Drawing.Point(395, 160);
            this.circleAreaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.circleAreaLabel.Name = "circleAreaLabel";
            this.circleAreaLabel.Size = new System.Drawing.Size(45, 13);
            this.circleAreaLabel.TabIndex = 5;
            this.circleAreaLabel.Text = "Площа:";
            this.circleAreaLabel.Click += new System.EventHandler(this.circleAreaLabel_Click_1);
 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(287, 231);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(95, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "БІЛЬША ПЛОЩА:";

            this.runButton.Location = new System.Drawing.Point(12, 282);
            this.runButton.Margin = new System.Windows.Forms.Padding(2);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(92, 20);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButton_Click);

            this.exitButton.Location = new System.Drawing.Point(416, 282);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 20);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);

            this.aboutButton.Location = new System.Drawing.Point(416, 27);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(82, 20);
            this.aboutButton.TabIndex = 9;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);

            this.squareAreaTextBox.Location = new System.Drawing.Point(398, 96);
            this.squareAreaTextBox.Name = "squareAreaTextBox";
            this.squareAreaTextBox.ReadOnly = true;
            this.squareAreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.squareAreaTextBox.TabIndex = 0;
            this.squareAreaTextBox.TextChanged += new System.EventHandler(this.squareAreaTextBox_TextChanged);

            this.circleAreaTextBox.Location = new System.Drawing.Point(398, 176);
            this.circleAreaTextBox.Name = "circleAreaTextBox";
            this.circleAreaTextBox.ReadOnly = true;
            this.circleAreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.circleAreaTextBox.TabIndex = 1;

            this.squareTextLabel.AutoSize = true;
            this.squareTextLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.squareTextLabel.Location = new System.Drawing.Point(282, 53);
            this.squareTextLabel.Name = "squareTextLabel";
            this.squareTextLabel.Size = new System.Drawing.Size(52, 13);
            this.squareTextLabel.TabIndex = 0;
            this.squareTextLabel.Text = "Квадрат:";
            this.squareTextLabel.Click += new System.EventHandler(this.squareTextLabel_Click);

            this.circleTextLabel.AutoSize = true;
            this.circleTextLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.circleTextLabel.Location = new System.Drawing.Point(282, 131);
            this.circleTextLabel.Name = "circleTextLabel";
            this.circleTextLabel.Size = new System.Drawing.Size(33, 13);
            this.circleTextLabel.TabIndex = 1;
            this.circleTextLabel.Text = "Круг:";

            this.largerAreaLabel.Location = new System.Drawing.Point(0, 0);
            this.largerAreaLabel.Name = "largerAreaLabel";
            this.largerAreaLabel.Size = new System.Drawing.Size(100, 23);
            this.largerAreaLabel.TabIndex = 0;

            this.largerAreaTextBox.Location = new System.Drawing.Point(398, 228);
            this.largerAreaTextBox.Name = "largerAreaTextBox";
            this.largerAreaTextBox.ReadOnly = true;
            this.largerAreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.largerAreaTextBox.TabIndex = 0;
            this.largerAreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 221);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint_1);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.largerAreaTextBox);
            this.Controls.Add(this.squareTextLabel);
            this.Controls.Add(this.circleTextLabel);
            this.Controls.Add(this.squareAreaTextBox);
            this.Controls.Add(this.circleAreaTextBox);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.circleAreaLabel);
            this.Controls.Add(this.squareAreaLabel);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.sideLengthTextBox);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.sideLengthLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Area Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label squareTextLabel;
        private Label circleTextLabel;
        private Label largerAreaLabel;
        private PictureBox pictureBox1;
    }
}
