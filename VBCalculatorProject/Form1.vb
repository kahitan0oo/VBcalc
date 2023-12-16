Public Class Form1

    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim operation As Integer
    Dim Operator_selector As Boolean = False
    Dim int As Integer = 0
    Dim doub As Double = 0

    Private Sub Number0_Click(sender As Object, e As EventArgs) Handles Number0.Click
        If Label.Text <> "0" Then
            Label.Text += "0"
        End If
    End Sub

    Private Sub Point_Click(sender As Object, e As EventArgs) Handles Point.Click
        If Not (Label.Text.Contains(".")) Then
            Label.Text += "."
        End If
    End Sub

    Private Sub Equal_Click(sender As Object, e As EventArgs) Handles Equal.Click

        If Operator_selector = True Then
            num2 = Label.Text

            If operation = 1 Then
                Label.Text = num1 + num2
            ElseIf operation = 2 Then
                Label.Text = num1 - num2
            ElseIf operation = 3 Then
                Label.Text = num1 * num2
            Else
                If num2 = 0 Then
                    Label.Text = "Error"
                Else
                    Label.Text = num1 / num2
                End If
            End If
            Operator_selector = False
        End If
    End Sub

    Private Sub Number1_Click(sender As Object, e As EventArgs) Handles Number1.Click
        If Label.Text <> "0" Then
            Label.Text += "1"
        Else
            Label.Text = "1"

        End If

    End Sub

    Private Sub Number2_Click(sender As Object, e As EventArgs) Handles Number2.Click
        If Label.Text <> "0" Then
            Label.Text += "2"
        Else
            Label.Text = "2"

        End If
    End Sub

    Private Sub Number3_Click(sender As Object, e As EventArgs) Handles Number3.Click
        If Label.Text <> "0" Then
            Label.Text += "3"
        Else
            Label.Text = "3"

        End If
    End Sub

    Private Sub Number4_Click(sender As Object, e As EventArgs) Handles Number4.Click
        If Label.Text <> "0" Then
            Label.Text += "4"
        Else
            Label.Text = "4"

        End If
    End Sub

    Private Sub Number5_Click(sender As Object, e As EventArgs) Handles Number5.Click
        If Label.Text <> "0" Then
            Label.Text += "5"
        Else
            Label.Text = "5"

        End If
    End Sub

    Private Sub Number6_Click(sender As Object, e As EventArgs) Handles Number6.Click
        If Label.Text <> "0" Then
            Label.Text += "6"
        Else
            Label.Text = "6"

        End If
    End Sub

    Private Sub Number7_Click(sender As Object, e As EventArgs) Handles Number7.Click
        If Label.Text <> "0" Then
            Label.Text += "7"
        Else
            Label.Text = "7"

        End If
    End Sub

    Private Sub Number8_Click(sender As Object, e As EventArgs) Handles Number8.Click
        If Label.Text <> "0" Then
            Label.Text += "8"
        Else
            Label.Text = "8"

        End If
    End Sub

    Private Sub Number9_Click(sender As Object, e As EventArgs) Handles Number9.Click
        If Label.Text <> "0" Then
            Label.Text += "9"
        Else
            Label.Text = "9"

        End If
    End Sub

    Private Sub Addition_Click(sender As Object, e As EventArgs) Handles Addition.Click
        num1 = Label.Text
        Label.Text = "0"
        Operator_selector = True
        operation = 1 ' = +
    End Sub

    Private Sub Subtraction_Click(sender As Object, e As EventArgs) Handles Subtraction.Click
        num1 = Label.Text
        Label.Text = "0"
        Operator_selector = True
        operation = 2 ' = -
    End Sub

    Private Sub Multiplication_Click(sender As Object, e As EventArgs) Handles Multiplication.Click
        num1 = Label.Text
        Label.Text = "0"
        Operator_selector = True
        operation = 3 ' = x
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click
        num1 = Label.Text
        Label.Text = "0"
        Operator_selector = True
        operation = 4 ' = ÷
    End Sub

    Private Sub Erasebutton_Click(sender As Object, e As EventArgs) Handles Erasebutton.Click
        Dim _input As String = Label.Text
        If _input = "" Then

        Else
            Dim _output As String = _input.Remove(_input.Length - 1, 1)
            Label.Text = _output

        End If
    End Sub

    Private Sub cancel1_Click(sender As Object, e As EventArgs) Handles cancel1.Click
        Label.Text = ""
        Label.Text = ""
        int = 0
        doub = 0
    End Sub

End Class
