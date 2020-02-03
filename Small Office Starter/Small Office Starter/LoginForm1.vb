

Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text.Equals(UserCredentials.FrontDeskUser()) AndAlso PasswordTextBox.Text.Equals(UserCredentials.FrontDeskPwd()) Then
            '' front desk
            Hide()
            Dim FrontDesk0 As FrontDesk = New FrontDesk()
            FrontDesk0.ShowDialog()
            Close()
        ElseIf UsernameTextBox.Text.Equals(UserCredentials.HrPayrollUser()) AndAlso PasswordTextBox.Text.Equals(UserCredentials.HrPayrollPwd()) Then
            '' hr / payroll
            Hide()
            Dim HrPayroll0 As HrPayroll = New HrPayroll()
            HrPayroll0.ShowDialog()
            Close()
        ElseIf UsernameTextBox.Text.Equals(UserCredentials.AccountsUser()) AndAlso PasswordTextBox.Text.Equals(UserCredentials.AccountsPwd()) Then
            '' accounts
            Hide()
            Dim Accounts0 As Accounts = New Accounts()
            Accounts0.ShowDialog()
            Close()
        Else
            '' error
            MsgBox("Invalid Credentials. Please Try Again!")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

End Class
''
'' ashumeow
''