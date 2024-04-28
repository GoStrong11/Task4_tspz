using System;
using System.Drawing;
using System.Windows.Forms;

namespace AreaCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            double sideLength, radius;

            if (!double.TryParse(sideLengthTextBox.Text, out sideLength) || sideLength <= 0)
            {
                sideLengthTextBox.Text = "4";
                sideLengthTextBox.ForeColor = Color.Red;
                return;
            }

            if (!double.TryParse(radiusTextBox.Text, out radius) || radius <= 0)
            {
                radiusTextBox.Text = "4";
                radiusTextBox.ForeColor = Color.Red;
                return;
            }

            double squareArea = sideLength * sideLength;
            double circleArea = Math.PI * radius * radius;

            this.squareAreaLabel.Text = "Площа квадрата:";
            this.circleAreaLabel.Text = "Площа кола:";
            this.squareAreaTextBox.Text = $"{squareArea:F2}";
            this.circleAreaTextBox.Text = $"{circleArea:F2}";

            if (squareArea > circleArea)
            {
                this.largerAreaTextBox.Text = "КВАДРАТ";
            }
            else if (circleArea > squareArea)
            {
                this.largerAreaTextBox.Text = "КРУГ";
            }
            else
            {
                this.largerAreaTextBox.Text = "РІВНІ";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void sideLengthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sideLengthLabel_Click(object sender, EventArgs e)
        {

        }

        private void radiusLabel_Click(object sender, EventArgs e)
        {

        }

        private void radiusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void squareAreaLabel_Click(object sender, EventArgs e)
        {

        }

        private void circleAreaLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void squareAreaLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void squareAreaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void circleAreaLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen squarePen = new Pen(Color.Blue, 3); 
            Pen circlePen = new Pen(Color.Red, 3); 
            g.DrawRectangle(squarePen, 50, 50, 100, 100);
            g.DrawEllipse(circlePen, 95, 95, 100, 100);

            squarePen.Dispose();
            circlePen.Dispose();
        }

        private void squareTextLabel_Click(object sender, EventArgs e)
        {

        }
    }

    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            AddText();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(250, 100);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void AddText()
        {
            Label label = new Label();
            label.Text = "Порахувати площу квадрата і круга\n" +
                         "Визначити, площа якої з фігур більша\n" +
                         "Коба Костянтин Вячеславович, 2024";
            label.Location = new System.Drawing.Point(10, 10); 
            label.AutoSize = true;
            this.Controls.Add(label);

            Button closeButton = new Button();
            closeButton.Text = "OK";
            closeButton.Location = new System.Drawing.Point(110, 60); 
            closeButton.Click += CloseButton_Click;
            this.Controls.Add(closeButton);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(); 
        }
    }
}
