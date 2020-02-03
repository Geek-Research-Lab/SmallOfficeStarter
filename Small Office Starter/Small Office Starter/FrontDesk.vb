Public Class FrontDesk
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        End
    End Sub

    Private Sub test_UC_Click(sender As Object, e As EventArgs) Handles test_UC.Click
        Dim FrontDeskControl1 As FrontDesk_Appearance = New FrontDesk_Appearance()
        FrontDeskControl1.Show()
    End Sub
End Class
''
'' ashumeow
''