Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text.Equals("") AndAlso PasswordTextBox.Text.Equals("") Then
            '' front desk
            Hide()
            Dim FrontDesk0 As FrontDesk = New FrontDesk()
            FrontDesk0.ShowDialog()
            Close()
        ElseIf UsernameTextBox.Text.Equals("") AndAlso PasswordTextBox.Text.Equals("") Then
            '' hr / payroll

        ElseIf UsernameTextBox.Text.Equals("") AndAlso PasswordTextBox.Text.Equals("") Then
            '' accounts

        Else
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

End Class
''
'' ashumeow
''