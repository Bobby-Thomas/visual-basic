Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call ErrorCheck()
    End Sub
    Private Sub ErrorCheck()
        Dim TextBoxData As String

        TextBoxData = Trim(TextBox1.Text)

        If TextBoxData = "" Then
            MessageBox.Show("Please Enter your First Name")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call ErrorCheck()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim first As Integer
        Dim second As Integer


        first = Val(txtFirstNumber.Text)
        second = Val(txtSecondNumber.Text)

        Call AddNumbers(first, second)

    End Sub

    Private Sub AddNumbers(ByVal first2 As Integer, ByVal second2 As Integer)

        Dim answer As Integer

        answer = first2 + second2

        MessageBox.Show("The total is " & answer)
    End Sub

    Private Sub emailValid_Click(sender As Object, e As EventArgs) Handles emailValid.Click
        Dim email As String = emailAddress.Text
        Call validEmail(email)
    End Sub
    Private Sub validEmail(ByVal email2 As String)
        If email2.Contains("@") = True Then
            MessageBox.Show("Valid Email Address")
        Else
            MessageBox.Show("Invalid Email Address")
        End If

    End Sub

End Class
