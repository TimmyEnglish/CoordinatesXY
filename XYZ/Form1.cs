using System.Windows.Forms;

namespace CoordinatesXY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xTextBox_Enter(object sender, EventArgs e)
        {
            if (xTextBox.Text == "���������� X")
            {
                xTextBox.Text = "";
                xTextBox.ForeColor = Color.Black;
            }
        }
        private void xTextBox_Leave(object sender, EventArgs e)
        {
            if (xTextBox.Text == "")
            {
                xTextBox.Text = "���������� X";
                xTextBox.ForeColor = Color.Silver;
            }
        }

        private void yTextBox_Enter(object sender, EventArgs e)
        {
            if (yTextBox.Text == "���������� Y")
            {
                yTextBox.Text = "";
                yTextBox.ForeColor = Color.Black;
            }
        }

        private void yTextBox_Leave(object sender, EventArgs e)
        {
            if (yTextBox.Text == "")
            {
                yTextBox.Text = "���������� Y";
                yTextBox.ForeColor = Color.Silver;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(xTextBox.Text);
                int y = int.Parse(yTextBox.Text);

                Point point = new Point(x, y);
                string quadrant = point.GetQuadrant();
                MessageBox.Show(quadrant);

                DrawPointOnGraph(x, y, scaleTrackBar.Value);
            }
            catch (FormatException)
            {
                MessageBox.Show("���� �����, ������ ������� �������� ���������.");
            }
        }
        private void DrawPointOnGraph(int x, int y, float scale = 1f)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White); 

            Pen axisPen = new Pen(Color.Black, 2);
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;

            g.DrawLine(axisPen, centerX, 0, centerX, pictureBox1.Height); 
            g.DrawLine(axisPen, 0, centerY, pictureBox1.Width, centerY); 

            int scaledX = (int)(x * scale);
            int scaledY = (int)(y * scale);

            SolidBrush pointBrush = new SolidBrush(Color.Red);
            g.FillEllipse(pointBrush, centerX + scaledX - 5, centerY - scaledY - 5, 10, 10); 
        }

        private void scaleTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(xTextBox.Text) || string.IsNullOrEmpty(yTextBox.Text))
            {
                MessageBox.Show("���� �����, ������ ���������� �����.");
                return;
            }

            try
            {
                int x = int.Parse(xTextBox.Text);
                int y = int.Parse(yTextBox.Text);
                float scale = scaleTrackBar.Value; 

                DrawPointOnGraph(x, y, scale);    
            }
            catch (FormatException)
            {
                MessageBox.Show("���� �����, ������ ������� �������� ���������.");
            }
        }
    }
}
