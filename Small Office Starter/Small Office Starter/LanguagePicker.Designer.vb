<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LanguagePicker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FrontDesk_Language_English = New System.Windows.Forms.Button()
        Me.FrontDesk_Language_Arabic = New System.Windows.Forms.Button()
        Me.FrontDesk_Language_French = New System.Windows.Forms.Button()
        Me.FrontDesk_Language_Russian = New System.Windows.Forms.Button()
        Me.FrontDesk_Language_German = New System.Windows.Forms.Button()
        Me.FrontDesk_Language_Title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FrontDesk_Language_English
        '
        Me.FrontDesk_Language_English.Location = New System.Drawing.Point(35, 77)
        Me.FrontDesk_Language_English.Name = "FrontDesk_Language_English"
        Me.FrontDesk_Language_English.Size = New System.Drawing.Size(141, 48)
        Me.FrontDesk_Language_English.TabIndex = 0
        Me.FrontDesk_Language_English.Text = "English (Default)"
        Me.FrontDesk_Language_English.UseVisualStyleBackColor = True
        '
        'FrontDesk_Language_Arabic
        '
        Me.FrontDesk_Language_Arabic.Location = New System.Drawing.Point(229, 77)
        Me.FrontDesk_Language_Arabic.Name = "FrontDesk_Language_Arabic"
        Me.FrontDesk_Language_Arabic.Size = New System.Drawing.Size(141, 48)
        Me.FrontDesk_Language_Arabic.TabIndex = 1
        Me.FrontDesk_Language_Arabic.Text = "Arabic"
        Me.FrontDesk_Language_Arabic.UseVisualStyleBackColor = True
        '
        'FrontDesk_Language_French
        '
        Me.FrontDesk_Language_French.Location = New System.Drawing.Point(422, 77)
        Me.FrontDesk_Language_French.Name = "FrontDesk_Language_French"
        Me.FrontDesk_Language_French.Size = New System.Drawing.Size(141, 48)
        Me.FrontDesk_Language_French.TabIndex = 2
        Me.FrontDesk_Language_French.Text = "French"
        Me.FrontDesk_Language_French.UseVisualStyleBackColor = True
        '
        'FrontDesk_Language_Russian
        '
        Me.FrontDesk_Language_Russian.Location = New System.Drawing.Point(424, 164)
        Me.FrontDesk_Language_Russian.Name = "FrontDesk_Language_Russian"
        Me.FrontDesk_Language_Russian.Size = New System.Drawing.Size(141, 48)
        Me.FrontDesk_Language_Russian.TabIndex = 5
        Me.FrontDesk_Language_Russian.Text = "Russian"
        Me.FrontDesk_Language_Russian.UseVisualStyleBackColor = True
        '
        'FrontDesk_Language_German
        '
        Me.FrontDesk_Language_German.Location = New System.Drawing.Point(37, 164)
        Me.FrontDesk_Language_German.Name = "FrontDesk_Language_German"
        Me.FrontDesk_Language_German.Size = New System.Drawing.Size(141, 48)
        Me.FrontDesk_Language_German.TabIndex = 3
        Me.FrontDesk_Language_German.Text = "German"
        Me.FrontDesk_Language_German.UseVisualStyleBackColor = True
        '
        'FrontDesk_Language_Title
        '
        Me.FrontDesk_Language_Title.AutoSize = True
        Me.FrontDesk_Language_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrontDesk_Language_Title.Location = New System.Drawing.Point(103, 18)
        Me.FrontDesk_Language_Title.Name = "FrontDesk_Language_Title"
        Me.FrontDesk_Language_Title.Size = New System.Drawing.Size(385, 20)
        Me.FrontDesk_Language_Title.TabIndex = 8
        Me.FrontDesk_Language_Title.Text = "Front Desk => Set Your Language Of Choice"
        '
        'LanguagePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Small_Office_Starter.My.Resources.Resources.backgroundimg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(603, 246)
        Me.Controls.Add(Me.FrontDesk_Language_Title)
        Me.Controls.Add(Me.FrontDesk_Language_Russian)
        Me.Controls.Add(Me.FrontDesk_Language_German)
        Me.Controls.Add(Me.FrontDesk_Language_French)
        Me.Controls.Add(Me.FrontDesk_Language_Arabic)
        Me.Controls.Add(Me.FrontDesk_Language_English)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LanguagePicker"
        Me.Text = "LanguagePicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FrontDesk_Language_English As Button
    Friend WithEvents FrontDesk_Language_Arabic As Button
    Friend WithEvents FrontDesk_Language_French As Button
    Friend WithEvents FrontDesk_Language_Russian As Button
    Friend WithEvents FrontDesk_Language_German As Button
    Friend WithEvents FrontDesk_Language_Title As Label
End Class
