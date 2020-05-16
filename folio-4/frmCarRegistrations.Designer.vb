<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarRegistrations
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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.dlgBrowseFiles = New System.Windows.Forms.OpenFileDialog()
        Me.lstCarReg = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(327, 29)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(102, 32)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'dlgBrowseFiles
        '
        Me.dlgBrowseFiles.FileName = "OpenFileDialog1"
        '
        'lstCarReg
        '
        Me.lstCarReg.HideSelection = False
        Me.lstCarReg.Location = New System.Drawing.Point(318, 81)
        Me.lstCarReg.Name = "lstCarReg"
        Me.lstCarReg.Size = New System.Drawing.Size(121, 97)
        Me.lstCarReg.TabIndex = 1
        Me.lstCarReg.UseCompatibleStateImageBehavior = False
        '
        'frmCarRegistrations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 472)
        Me.Controls.Add(Me.lstCarReg)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "frmCarRegistrations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Registration"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLoad As Button
    Friend WithEvents dlgBrowseFiles As OpenFileDialog
    Friend WithEvents lstCarReg As ListView
End Class
