Public Class FrontDesk_Appearance
    ' init labels
    Dim get_language_theme As String = ""
    ' theme 1
    Private Sub FrontDesk_Theme_1_Click(sender As Object, e As EventArgs) Handles FrontDesk_Theme_1.Click
        ''
        '' todo : add more code
        ''
    End Sub
    ' theme 2
    Private Sub FrontDesk_Theme_2_Click(sender As Object, e As EventArgs) Handles FrontDesk_Theme_2.Click
        ''
        '' todo : add more code
        ''
    End Sub
    ' theme 3
    Private Sub FrontDesk_Theme_3_Click(sender As Object, e As EventArgs) Handles FrontDesk_Theme_3.Click
        ''
        '' todo : add more code
        ''
    End Sub
    ' theme 4
    Private Sub FrontDesk_Theme_4_Click(sender As Object, e As EventArgs) Handles FrontDesk_Theme_4.Click
        ''
        '' todo : add more code
        ''
    End Sub
    ' theme 5
    Private Sub FrontDesk_Theme_5_Click(sender As Object, e As EventArgs) Handles FrontDesk_Theme_5.Click
        ''
        '' todo : add more code
        ''
    End Sub
    ' theme 6
    Private Sub FrontDesk_Theme_6_Click(sender As Object, e As EventArgs) Handles FrontDesk_Theme_6.Click
        ''
        '' todo : add more code
        ''
    End Sub
    ' update / close
    Private Sub FrontDesk_Theme_UpdateClose_Click(sender As Object, e As EventArgs) Handles FrontDesk_Theme_UpdateClose.Click
        ''
        '' todo : add more code
        ''
        MsgBox("Coming Soon!")
        Close()
    End Sub
    ' init
    Private Sub FrontDesk_Appearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            get_language_theme = FrontDesk.Lang_Get()
            If get_language_theme.Equals("EN") Then
                ' header
                FrontDesk_Theme_Title.Text = ""
                ' body
                FrontDesk_Theme_1.Text = ""
                FrontDesk_Theme_2.Text = ""
                FrontDesk_Theme_3.Text = ""
                FrontDesk_Theme_4.Text = ""
                FrontDesk_Theme_5.Text = ""
                FrontDesk_Theme_6.Text = ""
                ' footer
                FrontDesk_Theme_UpdateClose.Text = ""
            ElseIf get_language_theme.Equals("AR") Then
                ' header
                FrontDesk_Theme_Title.Text = ""
                ' body
                FrontDesk_Theme_1.Text = ""
                FrontDesk_Theme_2.Text = ""
                FrontDesk_Theme_3.Text = ""
                FrontDesk_Theme_4.Text = ""
                FrontDesk_Theme_5.Text = ""
                FrontDesk_Theme_6.Text = ""
                ' footer
                FrontDesk_Theme_UpdateClose.Text = ""
            ElseIf get_language_theme.Equals("FR") Then
                ' header
                FrontDesk_Theme_Title.Text = ""
                ' body
                FrontDesk_Theme_1.Text = ""
                FrontDesk_Theme_2.Text = ""
                FrontDesk_Theme_3.Text = ""
                FrontDesk_Theme_4.Text = ""
                FrontDesk_Theme_5.Text = ""
                FrontDesk_Theme_6.Text = ""
                ' footer
                FrontDesk_Theme_UpdateClose.Text = ""
            ElseIf get_language_theme.Equals("DE") Then
                ' header
                FrontDesk_Theme_Title.Text = ""
                ' body
                FrontDesk_Theme_1.Text = ""
                FrontDesk_Theme_2.Text = ""
                FrontDesk_Theme_3.Text = ""
                FrontDesk_Theme_4.Text = ""
                FrontDesk_Theme_5.Text = ""
                FrontDesk_Theme_6.Text = ""
                ' footer
                FrontDesk_Theme_UpdateClose.Text = ""
            ElseIf get_language_theme.Equals("RU") Then
                ' header
                FrontDesk_Theme_Title.Text = ""
                ' body
                FrontDesk_Theme_1.Text = ""
                FrontDesk_Theme_2.Text = ""
                FrontDesk_Theme_3.Text = ""
                FrontDesk_Theme_4.Text = ""
                FrontDesk_Theme_5.Text = ""
                FrontDesk_Theme_6.Text = ""
                ' footer
                FrontDesk_Theme_UpdateClose.Text = ""
            Else
                ' header
                FrontDesk_Theme_Title.Text = ""
                ' body
                FrontDesk_Theme_1.Text = ""
                FrontDesk_Theme_2.Text = ""
                FrontDesk_Theme_3.Text = ""
                FrontDesk_Theme_4.Text = ""
                FrontDesk_Theme_5.Text = ""
                FrontDesk_Theme_6.Text = ""
                ' footer
                FrontDesk_Theme_UpdateClose.Text = ""
                MsgBox("Your language settings file is missing. Default language is set to 'English'")
            End If
        Catch ex As Exception
            ' header
            FrontDesk_Theme_Title.Text = ""
            ' body
            FrontDesk_Theme_1.Text = ""
            FrontDesk_Theme_2.Text = ""
            FrontDesk_Theme_3.Text = ""
            FrontDesk_Theme_4.Text = ""
            FrontDesk_Theme_5.Text = ""
            FrontDesk_Theme_6.Text = ""
            ' footer
            FrontDesk_Theme_UpdateClose.Text = ""
            MsgBox("Your language settings file is missing. Default language is set to 'English'")
        End Try
    End Sub
End Class
''
'' ashumeow
''