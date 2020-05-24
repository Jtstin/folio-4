<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCarRegistrations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.dlgBrowseFiles = New System.Windows.Forms.OpenFileDialog()
        Me.lstCarReg = New System.Windows.Forms.ListView()
        Me.Registration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Make = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Year = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Odometer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtReg = New System.Windows.Forms.TextBox()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtOdo = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblCarsFound = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFileFullName = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(416, 15)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 21)
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
        Me.lstCarReg.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Registration, Me.Make, Me.Model, Me.Year, Me.Odometer, Me.Cost})
        Me.lstCarReg.GridLines = True
        Me.lstCarReg.HideSelection = False
        Me.lstCarReg.Location = New System.Drawing.Point(30, 42)
        Me.lstCarReg.Margin = New System.Windows.Forms.Padding(2)
        Me.lstCarReg.Name = "lstCarReg"
        Me.lstCarReg.Size = New System.Drawing.Size(461, 183)
        Me.lstCarReg.TabIndex = 1
        Me.lstCarReg.UseCompatibleStateImageBehavior = False
        Me.lstCarReg.View = System.Windows.Forms.View.Details
        '
        'Registration
        '
        Me.Registration.Text = "Registration"
        Me.Registration.Width = 100
        '
        'Make
        '
        Me.Make.Text = "Make"
        '
        'Model
        '
        Me.Model.Text = "Model"
        '
        'Year
        '
        Me.Year.Text = "Year"
        Me.Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Odometer
        '
        Me.Odometer.Text = "Odometer"
        Me.Odometer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Odometer.Width = 100
        '
        'Cost
        '
        Me.Cost.Text = "Cost"
        '
        'txtReg
        '
        Me.txtReg.Location = New System.Drawing.Point(91, 296)
        Me.txtReg.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReg.Name = "txtReg"
        Me.txtReg.Size = New System.Drawing.Size(68, 20)
        Me.txtReg.TabIndex = 2
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(247, 297)
        Me.txtMake.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(68, 20)
        Me.txtMake.TabIndex = 3
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(91, 344)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(2)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(68, 20)
        Me.txtYear.TabIndex = 4
        '
        'txtOdo
        '
        Me.txtOdo.Location = New System.Drawing.Point(247, 341)
        Me.txtOdo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOdo.Name = "txtOdo"
        Me.txtOdo.Size = New System.Drawing.Size(68, 20)
        Me.txtOdo.TabIndex = 5
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(423, 341)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(68, 20)
        Me.txtCost.TabIndex = 6
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(423, 300)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(68, 20)
        Me.txtModel.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 348)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Odometer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 299)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Make"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(373, 348)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cost"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(416, 399)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(68, 23)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblCarsFound
        '
        Me.lblCarsFound.AutoSize = True
        Me.lblCarsFound.Location = New System.Drawing.Point(50, 227)
        Me.lblCarsFound.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCarsFound.Name = "lblCarsFound"
        Me.lblCarsFound.Size = New System.Drawing.Size(0, 13)
        Me.lblCarsFound.TabIndex = 15
        Me.lblCarsFound.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 348)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 300)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Registration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(373, 300)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Model"
        '
        'lblFileFullName
        '
        Me.lblFileFullName.AutoSize = True
        Me.lblFileFullName.Location = New System.Drawing.Point(120, 19)
        Me.lblFileFullName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFileFullName.Name = "lblFileFullName"
        Me.lblFileFullName.Size = New System.Drawing.Size(0, 13)
        Me.lblFileFullName.TabIndex = 16
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(334, 399)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(416, 243)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmCarRegistrations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 444)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblFileFullName)
        Me.Controls.Add(Me.lblCarsFound)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtOdo)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.txtReg)
        Me.Controls.Add(Me.lstCarReg)
        Me.Controls.Add(Me.btnLoad)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCarRegistrations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shiny Cars"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoad As Button
    Friend WithEvents dlgBrowseFiles As OpenFileDialog
    Friend WithEvents lstCarReg As ListView
    Friend WithEvents Registration As ColumnHeader
    Friend WithEvents Make As ColumnHeader
    Friend WithEvents Model As ColumnHeader
    Friend WithEvents Year As ColumnHeader
    Friend WithEvents Odometer As ColumnHeader
    Friend WithEvents Cost As ColumnHeader
    Friend WithEvents txtReg As TextBox
    Friend WithEvents txtMake As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtOdo As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblCarsFound As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFileFullName As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dlgSave As SaveFileDialog
End Class
