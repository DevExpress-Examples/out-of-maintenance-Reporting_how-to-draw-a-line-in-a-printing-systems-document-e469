using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.XtraPrinting;
// ...


namespace LineBrickAndDrawLine {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            printControl1.PrintingSystem = ps;
        }

        private void btnDrawLine_Click(object sender, EventArgs e) {
            // Prepare for creating a document.
            ps.Begin();
            BrickGraphics gr = ps.Graph;
            gr.Modifier = BrickModifier.Detail;

            // Draw a line with the specified coordinates, foreground color and thickness.
            LineBrick brick = gr.DrawLine(new PointF(0, 0), new PointF(200, 200), Color.Red, 5);

            // Change the line style to dash-dot-dot.
            brick.LineStyle = DXDashStyle.DashDotDot;

            // Hide brick borders.
            brick.BorderWidth = 0;

            // Finish creating the document.
            ps.End();
        }

        private void btnDrawBrick_Click(object sender, EventArgs e) {
            // Prepare for creating a document.
            ps.Begin();
            BrickGraphics gr = ps.Graph;
            gr.Modifier = BrickModifier.Detail;

            // Create a new line brick.
            LineBrick brick = new LineBrick();

            // Specify its properties.
            brick.Rect = new RectangleF(0, 0, 200, 200);
            brick.LineDirection = DevExpress.XtraReports.UI.LineDirection.BackSlant;
            brick.ForeColor = Color.Red;
            brick.LineWidth = 5;
            brick.LineStyle = DXDashStyle.DashDotDot;
            brick.BorderWidth = 0;

            // Draw this brick.
            gr.DrawBrick(brick);

            // Finish creating the document.
            ps.End();
        }
    }
}