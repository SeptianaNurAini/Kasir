<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Menu
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
        Me.btnkasir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnkasir
        '
        Me.btnkasir.Location = New System.Drawing.Point(54, 142)
        Me.btnkasir.Name = "btnkasir"
        Me.btnkasir.Size = New System.Drawing.Size(75, 23)
        Me.btnkasir.TabIndex = 0
        Me.btnkasir.Text = "Kasir"
        Me.btnkasir.UseVisualStyleBackColor = True
        '
        'Form_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 453)
        Me.Controls.Add(Me.btnkasir)
        Me.Name = "Form_Menu"
        Me.Text = "Form_Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnkasir As System.Windows.Forms.Button
End Class
