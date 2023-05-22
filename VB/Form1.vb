Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting

' ...
Namespace LineBrickAndDrawLine

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            printControl1.PrintingSystem = ps
        End Sub

        Private Sub btnDrawLine_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Prepare for creating a document.
            ps.Begin()
            Dim gr As BrickGraphics = ps.Graph
            gr.Modifier = BrickModifier.Detail
            ' Draw a line with the specified coordinates, foreground color and thickness.
            Dim brick As LineBrick = gr.DrawLine(New PointF(0, 0), New PointF(200, 200), Color.Red, 5)
            ' Change the line style to dash-dot-dot.
            brick.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot
            ' Hide brick borders.
            brick.BorderWidth = 0
            ' Finish creating the document.
            ps.End()
        End Sub

        Private Sub btnDrawBrick_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Prepare for creating a document.
            ps.Begin()
            Dim gr As BrickGraphics = ps.Graph
            gr.Modifier = BrickModifier.Detail
            ' Create a new line brick.
            Dim brick As LineBrick = New LineBrick()
            ' Specify its properties.
            brick.Rect = New RectangleF(0, 0, 200, 200)
            brick.LineDirection = DevExpress.XtraReports.UI.LineDirection.BackSlant
            brick.ForeColor = Color.Red
            brick.LineWidth = 5
            brick.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot
            brick.BorderWidth = 0
            ' Draw this brick.
            gr.DrawBrick(brick)
            ' Finish creating the document.
            ps.End()
        End Sub
    End Class
End Namespace
