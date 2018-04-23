Imports Microsoft.VisualBasic
Imports System
Namespace LineBrickAndDrawLine
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			Me.btnDrawBrick = New System.Windows.Forms.Button()
			Me.btnDrawLine = New System.Windows.Forms.Button()
			Me.printControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
			CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnDrawBrick
			' 
			Me.btnDrawBrick.Location = New System.Drawing.Point(100, 12)
			Me.btnDrawBrick.Name = "btnDrawBrick"
			Me.btnDrawBrick.Size = New System.Drawing.Size(82, 40)
			Me.btnDrawBrick.TabIndex = 5
			Me.btnDrawBrick.Text = "DrawBrick"
			Me.btnDrawBrick.UseVisualStyleBackColor = True
'			Me.btnDrawBrick.Click += New System.EventHandler(Me.btnDrawBrick_Click);
			' 
			' btnDrawLine
			' 
			Me.btnDrawLine.Location = New System.Drawing.Point(12, 12)
			Me.btnDrawLine.Name = "btnDrawLine"
			Me.btnDrawLine.Size = New System.Drawing.Size(82, 40)
			Me.btnDrawLine.TabIndex = 4
			Me.btnDrawLine.Text = "DrawLine"
			Me.btnDrawLine.UseVisualStyleBackColor = True
'			Me.btnDrawLine.Click += New System.EventHandler(Me.btnDrawLine_Click);
			' 
			' printControl1
			' 
			Me.printControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.printControl1.ForeColor = System.Drawing.Color.White
			Me.printControl1.IsMetric = False
			Me.printControl1.Location = New System.Drawing.Point(12, 74)
			Me.printControl1.Name = "printControl1"
			Me.printControl1.PrintingSystem = Me.ps
			Me.printControl1.Size = New System.Drawing.Size(669, 379)
			Me.printControl1.TabIndex = 6
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(693, 465)
			Me.Controls.Add(Me.printControl1)
			Me.Controls.Add(Me.btnDrawBrick)
			Me.Controls.Add(Me.btnDrawLine)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ps As DevExpress.XtraPrinting.PrintingSystem
		Private WithEvents btnDrawBrick As System.Windows.Forms.Button
		Private WithEvents btnDrawLine As System.Windows.Forms.Button
		Private printControl1 As DevExpress.XtraPrinting.Control.PrintControl
	End Class
End Namespace

