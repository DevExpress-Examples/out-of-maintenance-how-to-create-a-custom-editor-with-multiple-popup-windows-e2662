﻿Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1.Custom_editor
	Partial Public Class CustomFormDesigner
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.SuspendLayout()
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.simpleButton1.Location = New System.Drawing.Point(20, 20)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(414, 200)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Test"
			' 
			' CustomFormDesigner
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.simpleButton1)
			Me.Name = "CustomFormDesigner"
			Me.Padding = New System.Windows.Forms.Padding(20)
			Me.Size = New System.Drawing.Size(454, 240)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace
