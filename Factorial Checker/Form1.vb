Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = TextBox1.Text
        Dim result As String
        Dim err As String = ""

        If IsNumeric(input) Then
            Dim number As Integer = Integer.Parse(input)
            If number < 0 Then
                err = "Error: Factorial is not defined by negatives."
                result = "Err"
            Else
                result = CalculateFactorial(number).ToString()
            End If
        Else
            err = "Error: Factorial is not defined by alphabets."
            result = "Err"
        End If

        TextBox2.Text = result
        Label4.Text = err
    End Sub

    Private Function CalculateFactorial(number As Integer) As Long
        Dim factorial As Long = 1
        For i As Integer = 1 To number
            factorial *= i
        Next
        Return factorial
    End Function
End Class
