Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim intSum As Double
        Dim i = 1
        Dim intNumber As Double
        Dim blnValidated As Boolean = True

        Call Get_Validate_Int_Input(intNumber, blnValidated)

        If blnValidated = True Then
            ' While the input number is greater than the sum, add to the sum
            Do While i <= txtNumber.Text
                intSum += i
                i += 1
            Loop
            MessageBox.Show("The sum is " + intSum.ToString())

        End If


    End Sub
    Private Sub Get_Validate_Int_Input(ByRef intNumber As String, ByRef blnValidated As Boolean)
        ' Validate the number input
        If Integer.TryParse(txtNumber.Text, intNumber) Then

            If intNumber < 1 Then
                MessageBox.Show("Number must be greater than 0")
                blnValidated = False
                txtNumber.Focus()

            End If
        Else
            ' Input is not a valid integer
            MessageBox.Show("Number must exist and be numeric")
            blnValidated = False
            txtNumber.Focus()
        End If

    End Sub
End Class
