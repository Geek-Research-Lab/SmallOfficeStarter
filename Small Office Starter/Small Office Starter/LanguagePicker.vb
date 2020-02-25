Public Class LanguagePicker
    '' english
    Private Sub FrontDesk_Language_English_Click(sender As Object, e As EventArgs) Handles FrontDesk_Language_English.Click
        MsgBox(FrontDesk.Lang_GetUpdate.Lang_Update("EN"))
    End Sub
    '' arabic
    Private Sub FrontDesk_Language_Arabic_Click(sender As Object, e As EventArgs) Handles FrontDesk_Language_Arabic.Click
        MsgBox(FrontDesk.Lang_GetUpdate.Lang_Update("AR"))
    End Sub
    '' french
    Private Sub FrontDesk_Language_French_Click(sender As Object, e As EventArgs) Handles FrontDesk_Language_French.Click
        MsgBox("Not Available. Coming Soon!")
    End Sub
    '' german
    Private Sub FrontDesk_Language_German_Click(sender As Object, e As EventArgs) Handles FrontDesk_Language_German.Click
        MsgBox("Not Available. Coming Soon!")
    End Sub
    '' russian
    Private Sub FrontDesk_Language_Russian_Click(sender As Object, e As EventArgs) Handles FrontDesk_Language_Russian.Click
        MsgBox("Not Available. Coming Soon!")
    End Sub
End Class
''
'' ashumeow
''