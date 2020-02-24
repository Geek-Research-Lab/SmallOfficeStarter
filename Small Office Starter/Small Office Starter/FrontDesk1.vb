Public Class FrontDesk1
    ' init
    Dim get_language As String = ""
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
        ' default type
        FrontDesk_Type.SelectedIndex = 0
        ' generate id
        FrontDesk_ID.Text = FrontDesk.RandomID()
        ' logo
        FrontDesk_Logo.BackgroundImage = FrontDesk.Load_Logo()
        Try
            get_language = FrontDesk.Lang_Get()
            If get_language.Equals("EN") Then
                ' header
                FrontDesk_Title.Text = FrontDesk.Home_EN_Title()
                ' main
                FrontDesk_Label_Type.Text = FrontDesk.Home_EN_Type()
                FrontDesk_Label_Name.Text = FrontDesk.Home_EN_Name()
                FrontDesk_Label_Email.Text = FrontDesk.Home_EN_Email()
                FrontDesk_Label_Phone.Text = FrontDesk.Home_EN_Phone()
                FrontDesk_Label_OtherContact.Text = FrontDesk.Home_EN_OtherContact()
                FrontDesk_Label_Description.Text = FrontDesk.Home_EN_Description()
                FrontDesk_Label_ID.Text = FrontDesk.Home_EN_ID()
                FrontDesk_Label_DateTime.Text = FrontDesk.Home_EN_DateTime()
                FrontDesk_Submit.Text = FrontDesk.Home_EN_Submit()
                ' get information
                FrontDesk_GetInfo.Text = FrontDesk.Home_EN_GetInfo()
                FrontDesk_GetInfo_Enquiry.Text = FrontDesk.Home_EN_Enquiry()
                FrontDesk_GetInfo_Visitors.Text = FrontDesk.Home_EN_Visitors()
                FrontDesk_GetInfo_Contacts.Text = FrontDesk.Home_EN_Contacts()
                FrontDesk_GetInfo_Report.Text = FrontDesk.Home_EN_Report()
                ' footer
                FrontDesk_Footer.Text = FrontDesk.Home_EN_Settings()
                FrontDesk_Footer_Appearance.Text = FrontDesk.Home_EN_Appearance()
                FrontDesk_Footer_Language.Text = FrontDesk.Home_EN_Lang()
                FrontDesk_Footer_CompanyInfo.Text = FrontDesk.Home_EN_CompanyInfo()
                FrontDesk_Footer_About.Text = FrontDesk.Home_EN_About()
                Exit_Button.Text = FrontDesk.Home_EN_Exit()
            ElseIf get_language.Equals("AR") Then
                ' header
                FrontDesk_Title.Text = FrontDesk.Home_AR_Title()
                ' main
                FrontDesk_Label_Type.Text = FrontDesk.Home_AR_Type()
                FrontDesk_Label_Name.Text = FrontDesk.Home_AR_Name()
                FrontDesk_Label_Email.Text = FrontDesk.Home_AR_Email()
                FrontDesk_Label_Phone.Text = FrontDesk.Home_AR_Phone()
                FrontDesk_Label_OtherContact.Text = FrontDesk.Home_AR_OtherContact()
                FrontDesk_Label_Description.Text = FrontDesk.Home_AR_Description()
                FrontDesk_Label_ID.Text = FrontDesk.Home_AR_ID()
                FrontDesk_Label_DateTime.Text = FrontDesk.Home_AR_DateTime()
                FrontDesk_Submit.Text = FrontDesk.Home_AR_Submit()
                ' get information
                FrontDesk_GetInfo.Text = FrontDesk.Home_AR_GetInfo()
                FrontDesk_GetInfo_Enquiry.Text = FrontDesk.Home_AR_Enquiry()
                FrontDesk_GetInfo_Visitors.Text = FrontDesk.Home_AR_Visitors()
                FrontDesk_GetInfo_Contacts.Text = FrontDesk.Home_AR_Contacts()
                FrontDesk_GetInfo_Report.Text = FrontDesk.Home_AR_Report()
                ' footer
                FrontDesk_Footer.Text = FrontDesk.Home_AR_Settings()
                FrontDesk_Footer_Appearance.Text = FrontDesk.Home_AR_Appearance()
                FrontDesk_Footer_Language.Text = FrontDesk.Home_AR_Lang()
                FrontDesk_Footer_CompanyInfo.Text = FrontDesk.Home_AR_CompanyInfo()
                FrontDesk_Footer_About.Text = FrontDesk.Home_AR_About()
                Exit_Button.Text = FrontDesk.Home_AR_Exit()
            ElseIf get_language.Equals("FR") Then
                ' header
                FrontDesk_Title.Text = ""
                ' main
                FrontDesk_Label_Type.Text = ""
                FrontDesk_Label_Name.Text = ""
                FrontDesk_Label_Email.Text = ""
                FrontDesk_Label_Phone.Text = ""
                FrontDesk_Label_OtherContact.Text = ""
                FrontDesk_Label_Description.Text = ""
                FrontDesk_Label_ID.Text = ""
                FrontDesk_Label_DateTime.Text = ""
                FrontDesk_Submit.Text = ""
                ' get information
                FrontDesk_GetInfo.Text = ""
                FrontDesk_GetInfo_Enquiry.Text = ""
                FrontDesk_GetInfo_Visitors.Text = ""
                FrontDesk_GetInfo_Contacts.Text = ""
                FrontDesk_GetInfo_Report.Text = ""
                ' footer
                FrontDesk_Footer.Text = ""
                FrontDesk_Footer_Appearance.Text = ""
                FrontDesk_Footer_Language.Text = ""
                FrontDesk_Footer_CompanyInfo.Text = ""
                FrontDesk_Footer_About.Text = ""
                Exit_Button.Text = ""
            ElseIf get_language.Equals("DE") Then
                ' header
                FrontDesk_Title.Text = ""
                ' main
                FrontDesk_Label_Type.Text = ""
                FrontDesk_Label_Name.Text = ""
                FrontDesk_Label_Email.Text = ""
                FrontDesk_Label_Phone.Text = ""
                FrontDesk_Label_OtherContact.Text = ""
                FrontDesk_Label_Description.Text = ""
                FrontDesk_Label_ID.Text = ""
                FrontDesk_Label_DateTime.Text = ""
                FrontDesk_Submit.Text = ""
                ' get information
                FrontDesk_GetInfo.Text = ""
                FrontDesk_GetInfo_Enquiry.Text = ""
                FrontDesk_GetInfo_Visitors.Text = ""
                FrontDesk_GetInfo_Contacts.Text = ""
                FrontDesk_GetInfo_Report.Text = ""
                ' footer
                FrontDesk_Footer.Text = ""
                FrontDesk_Footer_Appearance.Text = ""
                FrontDesk_Footer_Language.Text = ""
                FrontDesk_Footer_CompanyInfo.Text = ""
                FrontDesk_Footer_About.Text = ""
                Exit_Button.Text = ""
            ElseIf get_language.Equals("RU") Then
                ' header
                FrontDesk_Title.Text = ""
                ' main
                FrontDesk_Label_Type.Text = ""
                FrontDesk_Label_Name.Text = ""
                FrontDesk_Label_Email.Text = ""
                FrontDesk_Label_Phone.Text = ""
                FrontDesk_Label_OtherContact.Text = ""
                FrontDesk_Label_Description.Text = ""
                FrontDesk_Label_ID.Text = ""
                FrontDesk_Label_DateTime.Text = ""
                FrontDesk_Submit.Text = ""
                ' get information
                FrontDesk_GetInfo.Text = ""
                FrontDesk_GetInfo_Enquiry.Text = ""
                FrontDesk_GetInfo_Visitors.Text = ""
                FrontDesk_GetInfo_Contacts.Text = ""
                FrontDesk_GetInfo_Report.Text = ""
                ' footer
                FrontDesk_Footer.Text = ""
                FrontDesk_Footer_Appearance.Text = ""
                FrontDesk_Footer_Language.Text = ""
                FrontDesk_Footer_CompanyInfo.Text = ""
                FrontDesk_Footer_About.Text = ""
                Exit_Button.Text = ""
            Else
                ' header
                FrontDesk_Title.Text = FrontDesk.Home_EN_Title()
                ' main
                FrontDesk_Label_Type.Text = FrontDesk.Home_EN_Type()
                FrontDesk_Label_Name.Text = FrontDesk.Home_EN_Name()
                FrontDesk_Label_Email.Text = FrontDesk.Home_EN_Email()
                FrontDesk_Label_Phone.Text = FrontDesk.Home_EN_Phone()
                FrontDesk_Label_OtherContact.Text = FrontDesk.Home_EN_OtherContact()
                FrontDesk_Label_Description.Text = FrontDesk.Home_EN_Description()
                FrontDesk_Label_ID.Text = FrontDesk.Home_EN_ID()
                FrontDesk_Label_DateTime.Text = FrontDesk.Home_EN_DateTime()
                FrontDesk_Submit.Text = FrontDesk.Home_EN_Submit()
                ' get information
                FrontDesk_GetInfo.Text = FrontDesk.Home_EN_GetInfo()
                FrontDesk_GetInfo_Enquiry.Text = FrontDesk.Home_EN_Enquiry()
                FrontDesk_GetInfo_Visitors.Text = FrontDesk.Home_EN_Visitors()
                FrontDesk_GetInfo_Contacts.Text = FrontDesk.Home_EN_Contacts()
                FrontDesk_GetInfo_Report.Text = FrontDesk.Home_EN_Report()
                ' footer
                FrontDesk_Footer.Text = FrontDesk.Home_EN_Settings()
                FrontDesk_Footer_Appearance.Text = FrontDesk.Home_EN_Appearance()
                FrontDesk_Footer_Language.Text = FrontDesk.Home_EN_Lang()
                FrontDesk_Footer_CompanyInfo.Text = FrontDesk.Home_EN_CompanyInfo()
                FrontDesk_Footer_About.Text = FrontDesk.Home_EN_About()
                Exit_Button.Text = FrontDesk.Home_EN_Exit()
                MsgBox("Your language settings file is missing. Default language is set to 'English'")
            End If
        Catch ex As Exception
            ' header
            FrontDesk_Title.Text = FrontDesk.Home_EN_Title()
            ' main
            FrontDesk_Label_Type.Text = FrontDesk.Home_EN_Type()
            FrontDesk_Label_Name.Text = FrontDesk.Home_EN_Name()
            FrontDesk_Label_Email.Text = FrontDesk.Home_EN_Email()
            FrontDesk_Label_Phone.Text = FrontDesk.Home_EN_Phone()
            FrontDesk_Label_OtherContact.Text = FrontDesk.Home_EN_OtherContact()
            FrontDesk_Label_Description.Text = FrontDesk.Home_EN_Description()
            FrontDesk_Label_ID.Text = FrontDesk.Home_EN_ID()
            FrontDesk_Label_DateTime.Text = FrontDesk.Home_EN_DateTime()
            FrontDesk_Submit.Text = FrontDesk.Home_EN_Submit()
            ' get information
            FrontDesk_GetInfo.Text = FrontDesk.Home_EN_GetInfo()
            FrontDesk_GetInfo_Enquiry.Text = FrontDesk.Home_EN_Enquiry()
            FrontDesk_GetInfo_Visitors.Text = FrontDesk.Home_EN_Visitors()
            FrontDesk_GetInfo_Contacts.Text = FrontDesk.Home_EN_Contacts()
            FrontDesk_GetInfo_Report.Text = FrontDesk.Home_EN_Report()
            ' footer
            FrontDesk_Footer.Text = FrontDesk.Home_EN_Settings()
            FrontDesk_Footer_Appearance.Text = FrontDesk.Home_EN_Appearance()
            FrontDesk_Footer_Language.Text = FrontDesk.Home_EN_Lang()
            FrontDesk_Footer_CompanyInfo.Text = FrontDesk.Home_EN_CompanyInfo()
            FrontDesk_Footer_About.Text = FrontDesk.Home_EN_About()
            Exit_Button.Text = FrontDesk.Home_EN_Exit()
            MsgBox("Your language settings file is missing. Default language is set to 'English'")
        End Try
    End Sub
    ' submit
    Private Sub FrontDesk_Submit_Click(sender As Object, e As EventArgs) Handles FrontDesk_Submit.Click
        ' submit and get confirmation
        MsgBox(FrontDesk.SubmitDesk.FD_Submit(FrontDesk_DateTime.Text.ToString(), FrontDesk_ID.Text.ToString(), FrontDesk_Type.Text.ToString(),
FrontDesk_Name.Text.ToString(), FrontDesk_Email.Text.ToString(), FrontDesk_Phone.Text.ToString(), FrontDesk_OtherContact.Text.ToString(),
FrontDesk_Description.Text.ToString()))
        ' reset
        FrontDesk_DateTime.Refresh()
        FrontDesk_ID.Refresh()
        FrontDesk_Type.SelectedIndex = 0
        FrontDesk_Name.ResetText()
        FrontDesk_Email.ResetText()
        FrontDesk_Phone.ResetText()
        FrontDesk_OtherContact.ResetText()
        FrontDesk_Description.ResetText()
        FrontDesk_ID.ResetText()
        FrontDesk_ID.Text = FrontDesk.RandomID()
    End Sub
End Class
''
'' ashumeow
''