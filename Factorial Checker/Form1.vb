Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = TextBox1.Text
        Dim result As String

        If IsNumeric(input) Then
            Dim number As Integer = CInt(input)
            If number < 0 Then
                result = "Factorial is not defined by negatives."
            Else
                result = CalculateFactorial(number).ToString()
            End If

            TextBox2.Text = result
        End If
    End Sub

    Private Function CalculateFactorial(number As Integer) As Long
        Dim factorial As Long = 1
        For i As Integer = 1 To number
            factorial *= i
        Next
        Return factorial
    End Function
End Class
