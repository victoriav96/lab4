'Name: Victoria Valdron
'File name: Victoria_Lab4
'Student #: 1004548556
'Date: 15-03-2019
'Description: Car Inventory - This application is supposed to allow users to input car information to
'search up different models/makes and file them into a list view box.

Option Strict On
Public Class frmInventory

    Private carList As New SortedList
    Private currentCustomerIdentificationNumber As String = String.Empty
    Private editMode As Boolean = False

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car
        Dim carItem As ListViewItem


        If IsValidInput() = True Then


            editMode = True





            If currentCustomerIdentificationNumber.Trim.Length = 0 Then


                car = New Car(cmbMake.Text, cmbYear.Text, txtModel.Text, txtPrice.Text, chkNew.Checked)


                carList.Add(car.IdentificationNumber.ToString(), car)

            Else

                car = CType(carList.Item(currentCustomerIdentificationNumber), Car)

                car.VeryImportantPersonStatus = chkNew.Checked
                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = cmbYear.Text
                car.Price = txtPrice.Text

            End If


            lvwInventory.Items.Clear()

            'loop for each entry of car information
            For Each carEntry As DictionaryEntry In carList


                carItem = New ListViewItem()

                car = CType(carEntry.Value, Car)


                carItem.Checked = car.VeryImportantPersonStatus
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Year)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Price)







                lvwInventory.Items.Add(carItem)

            Next carEntry


            Reset()


            editMode = False

        End If

    End Sub



    'exit the application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub
    'reset button to clear data for future entry
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        lvwInventory.Items.Clear()



    End Sub
    'validation function
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty


        If cmbMake.SelectedIndex = -1 Then


            outputMessage += "Please select a car make." & vbCrLf


            returnValue = False

        End If


        If cmbYear.Text.Trim.Length = -1 Then


            outputMessage += "Please select a year." & vbCrLf


            returnValue = False

        End If

        If txtPrice.Text.Trim.Length = 0 Then


            outputMessage += "Please enter the price of the vehicle." & vbCrLf


            returnValue = False

        End If


        If txtModel.Text.Trim.Length = 0 Then


            outputMessage += "Please enter a car model." & vbCrLf


            returnValue = False

        End If


        If returnValue = False Then


            lblOutput.Text = "ERRORS" & vbCrLf & outputMessage

        End If


        Return returnValue

    End Function

End Class
