' **************************************************
' Greg Pina
'.Net Programming IT 101-401
' Assignment 10 - Conditional Code Program
' <10/13/2017>
' This program shows ElseIf and Select Case examples
' **************************************************

Option Strict On

Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear the controls
        txtNumber.Clear()
        lblResult.ResetText()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' closes the program
        Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' create local variable
        Dim intNumber As Integer
        Dim strResult As String

        txtNumber.BackColor = Color.White

        Try
            ' validate input is numeric
            If Not Integer.TryParse(txtNumber.Text, intNumber) Then
                MessageBox.Show("Please enter numbers only.")
                txtNumber.Focus()
                txtNumber.BackColor = Color.Yellow
                Exit Sub
            End If

            If intNumber < 1 Or intNumber > 5 Then
                MessageBox.Show("Please enter numbers 1 to 5 only.")
                txtNumber.Focus()
                txtNumber.BackColor = Color.Yellow
                Exit Sub
            End If

            ' assign alpha value of number to variable using ElseIf




            ' assign alpha value of number to variable using Select Case


            ' display variable
            lblResult.Text = strResult

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
