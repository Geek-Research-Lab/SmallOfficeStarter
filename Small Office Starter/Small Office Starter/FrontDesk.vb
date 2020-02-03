Public Class FrontDesk
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        End
    End Sub

    Private Sub FrontDesk_Footer_About_Click(sender As Object, e As EventArgs) Handles FrontDesk_Footer_About.Click
        Dim FrontDesk_About As AboutBox1 = New AboutBox1()
        FrontDesk_About.Show()
    End Sub

    Private Sub FrontDesk_Footer_Appearance_Click(sender As Object, e As EventArgs) Handles FrontDesk_Footer_Appearance.Click
        Dim FrontDeskControl1 As FrontDesk_Appearance = New FrontDesk_Appearance()
        FrontDeskControl1.Show()
    End Sub
End Class
''
'' ashumeow
''