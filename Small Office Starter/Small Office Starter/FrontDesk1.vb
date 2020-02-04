Public Class FrontDesk1
    ' exit
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        End
    End Sub
    ' about
    Private Sub FrontDesk_Footer_About_Click(sender As Object, e As EventArgs) Handles FrontDesk_Footer_About.Click
        Dim FrontDesk_About As AboutBox1 = New AboutBox1()
        FrontDesk_About.Show()
    End Sub
    ' appearance
    Private Sub FrontDesk_Footer_Appearance_Click(sender As Object, e As EventArgs) Handles FrontDesk_Footer_Appearance.Click
        Dim FrontDeskControl1 As FrontDesk_Appearance = New FrontDesk_Appearance()
        FrontDeskControl1.Show()
    End Sub
    ' company info
    Private Sub FrontDesk_Footer_CompanyInfo_Click(sender As Object, e As EventArgs) Handles FrontDesk_Footer_CompanyInfo.Click
        Dim FrontDeskControl2 As CompanyInfo = New CompanyInfo()
        FrontDeskControl2.Show()
    End Sub
    ' language
    Private Sub FrontDesk_Footer_Language_Click_1(sender As Object, e As EventArgs) Handles FrontDesk_Footer_Language.Click
        Dim FrontDeskControl3 As LanguagePicker = New LanguagePicker()
        FrontDeskControl3.Show()
    End Sub
    ' init load
    Private Sub FrontDesk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
''
'' ashumeow
''