' Author:   Christian Shank-Martel
' Date:     2020-03-12
' Description:
'       this program is ment to make a list of cars bassed on user input
'

Option Strict On

Public Class frmCarListing

#Region "variables"

    Dim selectedCar As Car          ' Delacre and instance of the 
    Dim isCarSelected As Boolean = False
    Dim isAddingToListView As Boolean = False
    Dim carList As New List(Of Car)
    Dim testDecimal As Decimal = 0.0D

#End Region

#Region "event handelers"

    ''' <summary>
    ''' me close form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Calls the SetDefaults Sub to reset the form to its default state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaluts()
    End Sub

    ''' <summary>
    ''' Try to add the new car to the list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Check to see if input is valid
        If ValidateInput() = True Then
            ' if a car isn't Selected
            If Not isCarSelected Then

                ' Create a new Car and adds to the list
                selectedCar = New Car(cobManufacturers.SelectedItem.ToString, txtModel.Text, CInt(updYear.Value), CDec(txtPrice.Text), chkNew.Checked)
                carList.Add(selectedCar)


            ElseIf selectedCar.ID > 0 Then

                ' Update the current information of the selectedCar
                selectedCar.Make = CType(cobManufacturers.SelectedItem, String)
                selectedCar.Model = txtModel.Text
                selectedCar.Year = CType(updYear.Value, Integer)
                selectedCar.Price = CDec(txtPrice.Text)
                selectedCar.IsNew = chkNew.Checked

            End If

        End If

        SetDefaluts()

    End Sub

    ''' <summary>
    '''  this Fires when the user clicks on a car within ther listView
    ''' </summary>
    Private Sub lvwCarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCarList.SelectedIndexChanged

        ' if the a car is selected
        If lvwCarList.SelectedIndices.Count = 1 Then

            selectedCar = carList(lvwCarList.SelectedIndices(0))
            isCarSelected = True

            ' Make the values modefiable
            cobManufacturers.SelectedItem = selectedCar.Make
            txtModel.Text = selectedCar.Model
            updYear.Value = selectedCar.Year
            txtPrice.Text = CType(selectedCar.Price, String)
            chkNew.Checked = selectedCar.IsNew

        Else
            'No Car is selected
            isCarSelected = False

        End If

    End Sub

    ''' <summary>
    ''' Stops the user from chekcing or un-checking the Box when the Car is not selected
    ''' </summary>
    Private Sub lvwCarList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCarList.ItemCheck

        If Not isAddingToListView Then

            ' Maintain the old checkbox value
            e.NewValue = e.CurrentValue

        End If

    End Sub

#End Region

#Region "Procedures and functions"

    ''' <summary>
    ''' Resetd the form as well as any required class-level variables to their default state
    ''' </summary>
    Private Sub SetDefaluts()

        ' Reset the UI interface variables
        cobManufacturers.SelectedIndex = 0
        txtModel.Clear()
        updYear.Value = 1970    ' Minimum possible number of the upDown
        txtPrice.Clear()
        chkNew.Checked = False

        ' Populate the list if input was added
        PopulateList()

        ' No Car is selcted at this time
        isCarSelected = False

        ' Set the first element of the UI to focus
        cobManufacturers.Focus()

        ' Clear the error box
        lblError.Text = ""

    End Sub

    ''' <summary>
    ''' To Check for Valid input
    ''' </summary>
    ''' <returns></returns>
    Private Function ValidateInput() As Boolean

        'Make boolean to return and String fro making Error Text
        Dim isValid = True
        Dim ErrorText As String = String.Empty

        ' check to see if the car model is entered
        If txtModel.Text.Trim.Length = 0 Then      ' .Text.Trim = 0 checks to see if the input is empty

            'add error to String
            ErrorText += "Please enter the Model of the Car." & vbCrLf

            'Set isValid to false
            isValid = False

        End If

        ' check to see if the entered year is within the Range
        If updYear.Value > updYear.Maximum Or updYear.Value < updYear.Minimum Then

            'add error to String
            ErrorText += "Sorry, the Program can only support cars from the years 1970-2020." & vbCrLf

            'Set isValid to false
            isValid = False

        End If

        ' check to see if the entered price is actully a deciaml
        If Decimal.TryParse(txtPrice.Text, testDecimal) Then

            'If number is less then 0
            If testDecimal < 0 Then
                'add error to String
                ErrorText += "The Price must be Greater then o." & vbCrLf

                'Set isValid to false
                isValid = False
            End If

        Else

            'add error to String
            ErrorText += "The Price must be a numerical value." & vbCrLf

            'Set isValid to false
            isValid = False

        End If

        ' Print the Error Messeges to the Proper TextBox
        If isValid = False Then

            lblError.Text = "ERROR:" & vbCrLf & ErrorText

        End If

        Return isValid

    End Function

    ''' <summary>
    ''' Clears and re-populates the listview Controls
    ''' </summary>
    Sub PopulateList()

        ' Clear the item from the listview control
        lvwCarList.Items.Clear()

        ' for loop to re-populate the list
        For i As Integer = 0 To carList.Count - 1

            ' Make a new ListViewIteam
            Dim carItem As New ListViewItem()

            ' Assign the values to the check control and the SubItems
            carItem.SubItems.Add(carList(i).ID.ToString)
            carItem.SubItems.Add(carList(i).Make)
            carItem.SubItems.Add(carList(i).Model)
            carItem.SubItems.Add(carList(i).Year.ToString)
            carItem.SubItems.Add(carList(i).Price.ToString("c"))
            carItem.Checked = carList(i).IsNew


            ' Make sure the Adding to list boolean is true
            isAddingToListView = True

            ' Add the new carItem to the list view
            lvwCarList.Items.Add(carItem)

            'Show that we are done adding the new carItem   
            isAddingToListView = False

        Next

    End Sub

#End Region
End Class
