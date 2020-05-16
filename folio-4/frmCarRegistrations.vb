'Name: Justin Tain
'Start Date: 16/05/20
'Last Updated: 16/05/20
'Description: This program will search for car registrations through an encrypted text file.
Public Class frmCarRegistrations
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        dlgBrowseFiles.InitialDirectory = FileSystem.CurDir
        dlgBrowseFiles.FileName = "carRegistration.txt"

        Dim dlgResult = dlgBrowseFiles.ShowDialog()
        If dlgResult = DialogResult.OK Then
            Dim fileReader As System.IO.StreamReader
            lstCarReg.Items.Clear()
            fileReader = My.Computer.FileSystem.OpenTextFileReader(dlgBrowseFiles.FileName)
            Dim line As String
            Dim lineNumber As Int32 = 0
            While Not fileReader.EndOfStream
                line = fileReader.ReadLine()
                Dim row = line.Split(",")
                Dim carReg As Car = New Car
            End While
        End If
    End Sub


End Class
