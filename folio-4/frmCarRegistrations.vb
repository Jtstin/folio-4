'Name: Justin Tain
'Start Date: 16/05/20
'Last Updated: 16/05/20
'Description: This program will search for car registrations through an encrypted text file.
Public Class frmCarRegistrations
    Private _cars As List(Of Car) = New List(Of Car)

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        dlgBrowseFiles.InitialDirectory = FileSystem.CurDir
        dlgBrowseFiles.FileName = "carRegistration.txt"

        Dim dlgResult = dlgBrowseFiles.ShowDialog()
        If dlgResult = DialogResult.OK Then
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(dlgBrowseFiles.FileName)
            Dim line As String
            Dim cars = New List(Of Car) 'A list to collect all cars from file
            Dim encryptedFileContent = fileReader.ReadToEnd()
            fileReader.Close()
            Dim decryptedFileContent As String = toggleEncryption(encryptedFileContent)

            Dim lines = decryptedFileContent.Split(vbCrLf)
            For Each line In lines
                Dim row = line.Split(",")
                Dim car As Car = New Car
                car.Registration = row(0).Trim()
                car.Make = row(1).Trim()
                car.Model = row(2).Trim()
                car.Year = row(3).Trim()
                car.Odometer = row(4).Trim()
                car.Cost = row(5).Trim()
                cars.Add(car)
            Next
            Text = "Shiny cars : " + dlgBrowseFiles.FileName
            _cars = cars
            displayCars(cars)
        End If
    End Sub

    Private Sub displayCars(cars As List(Of Car))

        lstCarReg.Items.Clear()
        Dim itemIndex As Int32 = 0
        For Each car As Car In cars
            lstCarReg.Items.Add(car.Registration)
            lstCarReg.Items(itemIndex).SubItems.Add(car.Make)
            lstCarReg.Items(itemIndex).SubItems.Add(car.Model)
            lstCarReg.Items(itemIndex).SubItems.Add(car.Year)
            lstCarReg.Items(itemIndex).SubItems.Add(car.Odometer)
            lstCarReg.Items(itemIndex).SubItems.Add(car.Cost)
            itemIndex = itemIndex + 1
        Next
    End Sub

    Private Function satisfyFilters(car As Car, searchFilters As Dictionary(Of String, String)) As Boolean
        For Each filter As KeyValuePair(Of String, String) In searchFilters
            Select Case filter.Key
                Case "Registration"
                    If Not car.Registration.Contains(filter.Value) Then
                        Return False
                    End If

                Case "Make"
                    If Not car.Make.Contains(filter.Value) Then
                        Return False
                    End If

                Case "Model"
                    If Not car.Model.Contains(filter.Value) Then
                        Return False
                    End If

                Case "Year"
                    If Not satisfyNumberFilter(car.Year, filter) Then
                        Return False
                    End If

                Case "Odometer"
                    If Not satisfyNumberFilter(car.Odometer, filter) Then
                        Return False
                    End If

                Case "Cost"
                    If Not satisfyNumberFilter(car.Cost, filter) Then
                        Return False
                    End If
            End Select
        Next
        Return True
    End Function

    Private Function satisfyNumberFilter(baseValue As Int32, filter As KeyValuePair(Of String, String))
        If filter.Value.StartsWith(">") Then
            Dim value As Int32 = filter.Value.Replace(">", "").Trim()
            If Not baseValue > value Then
                Return False
            End If
        ElseIf filter.Value.StartsWith("<") Then
            Dim value As Int32 = filter.Value.Replace("<", "").Trim()
            If Not baseValue < value Then
                Return False
            End If
        ElseIf Not baseValue = filter.Value Then
            Return False
        End If
        Return True
    End Function

    Private Function filterCars(cars As List(Of Car), searchFilters As Dictionary(Of String, String)) As List(Of Car)
        Dim filteredCars = New List(Of Car)
        For Each car As Car In cars
            If satisfyFilters(car, searchFilters) Then
                filteredCars.Add(car)
            End If
        Next
        Return filteredCars
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If _cars.Count = 0 Then
            Return
        End If
        Dim searchFilters As Dictionary(Of String, String) = getNonEmptyFilters()
        Dim filteredCars = filterCars(_cars, searchFilters)
        displayCars(filteredCars)
        If filteredCars.Count = 0 Then
            lblCarsFound.Text = "No cars found."
        Else
            lblCarsFound.Text = filteredCars.Count.ToString() + " cars found"
        End If
    End Sub

    Private Function getNonEmptyFilters() As Dictionary(Of String, String)
        Dim searchFilters = New Dictionary(Of String, String)
        If Not String.IsNullOrEmpty(txtReg.Text) Then
            searchFilters.Add("Registration", txtReg.Text)
        End If

        If Not String.IsNullOrEmpty(txtMake.Text) Then
            searchFilters.Add("Make", txtMake.Text)
        End If

        If Not String.IsNullOrEmpty(txtModel.Text) Then
            searchFilters.Add("Model", txtModel.Text)
        End If

        If Not String.IsNullOrEmpty(txtYear.Text) Then
            searchFilters.Add("Year", txtYear.Text)
        End If

        If Not String.IsNullOrEmpty(txtOdo.Text) Then
            searchFilters.Add("Odometer", txtOdo.Text)
        End If

        If Not String.IsNullOrEmpty(txtCost.Text) Then
            searchFilters.Add("Cost", txtCost.Text)
        End If

        Return searchFilters
    End Function



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim car As Car = New Car
        If String.IsNullOrEmpty(txtReg.Text) Or String.IsNullOrEmpty(txtMake.Text) Or String.IsNullOrEmpty(txtModel.Text) Or String.IsNullOrEmpty(txtYear.Text) Or String.IsNullOrEmpty(txtOdo.Text) Or String.IsNullOrEmpty(txtCost.Text) Then
            MessageBox.Show("All boxes must be filled")
            Return
        End If
        Dim year As Integer
        Dim odometer As Integer
        Dim cost As Integer
        If Not Integer.TryParse(txtYear.Text, year) Or Not Integer.TryParse(txtOdo.Text, odometer) Or Not Integer.TryParse(txtCost.Text, cost) Then
            MessageBox.Show("year, odometer, cost must be a number")
            Return
        End If
        car.Registration = txtReg.Text
        car.Make = txtMake.Text
        car.Model = txtModel.Text
        car.Year = txtYear.Text
        car.Odometer = txtOdo.Text
        car.Cost = txtCost.Text
        _cars.Add(car)
        displayCars(_cars)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dlgSave.InitialDirectory = FileSystem.CurDir
        dlgSave.FileName = "carRegistration.txt"
        Dim dlgResult = dlgSave.ShowDialog()
        If dlgResult = DialogResult.OK Then
            Dim newFileContent As String = ""
            For Each car As Car In _cars
                Dim line As String
                line = car.Registration + "," + car.Make + "," + car.Model + "," + Convert.ToString(car.Year) + "," + Convert.ToString(car.Odometer) + "," + Convert.ToString(car.Cost)
                If Not String.IsNullOrEmpty(newFileContent) Then
                    newFileContent = newFileContent + vbCrLf
                End If
                newFileContent = newFileContent + line
            Next
            Dim fileWriter As System.IO.StreamWriter
            fileWriter = My.Computer.FileSystem.OpenTextFileWriter(dlgSave.FileName, False)
            fileWriter.Write((toggleEncryption(newFileContent)))
            fileWriter.Close()
        End If
    End Sub

    Private Function toggleEncryption(text As String) As String
        Dim processedText As String = ""
        Dim key As Integer = 67 ' must be within 0-255
        For index As Integer = 0 To text.Length - 1
            Dim character As Char = text.Chars(index)
            If character <> " " Then
                Dim asciiNumber As Integer = Asc(character)
                Dim xoredNumber As Integer = asciiNumber Xor key
                character = Chr(xoredNumber)
            End If
            processedText = processedText + character
        Next
        Return processedText
    End Function
End Class

