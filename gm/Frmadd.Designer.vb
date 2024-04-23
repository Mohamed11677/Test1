<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmadd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lbCancel = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btninsert
        '
        Me.btninsert.BackColor = System.Drawing.Color.Green
        Me.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btninsert.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.btninsert.Location = New System.Drawing.Point(79, 137)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(231, 30)
        Me.btninsert.TabIndex = 1
        Me.btninsert.Text = "الحفظ"
        Me.btninsert.UseVisualStyleBackColor = False
        '
        'tb1
        '
        Me.tb1.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.tb1.Location = New System.Drawing.Point(79, 91)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(231, 30)
        Me.tb1.TabIndex = 3
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(383, 249)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 69
        Me.LineShape1.X2 = 308
        Me.LineShape1.Y1 = 185
        Me.LineShape1.Y2 = 185
        '
        'lbCancel
        '
        Me.lbCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbCancel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Underline)
        Me.lbCancel.Location = New System.Drawing.Point(122, 211)
        Me.lbCancel.Name = "lbCancel"
        Me.lbCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbCancel.Size = New System.Drawing.Size(100, 23)
        Me.lbCancel.TabIndex = 5
        Me.lbCancel.Text = "إلغاء"
        Me.lbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbTitle
        '
        Me.lbTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbTitle.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.lbTitle.Location = New System.Drawing.Point(118, 49)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(151, 23)
        Me.lbTitle.TabIndex = 6
        Me.lbTitle.Text = "عنوان"
        Me.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frmadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 249)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.lbCancel)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frmadd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmadd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbCancel As System.Windows.Forms.Label
    Friend WithEvents lbTitle As System.Windows.Forms.Label
End Class
