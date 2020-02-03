<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        Me.Accounts_Background = New System.Windows.Forms.Panel()
        Me.Accounts_Footer = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.test_UC = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Accounts_Header = New System.Windows.Forms.Panel()
        Me.Accounts_Title = New System.Windows.Forms.Label()
        Me.Accounts_Logo = New System.Windows.Forms.PictureBox()
        Me.Accounts_Background.SuspendLayout()
        Me.Accounts_Footer.SuspendLayout()
        Me.Accounts_Header.SuspendLayout()
        CType(Me.Accounts_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Accounts_Background
        '
        Me.Accounts_Background.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Accounts_Background.BackgroundImage = Global.Small_Office_Starter.My.Resources.Resources.accounts1
        Me.Accounts_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Accounts_Background.Controls.Add(Me.Accounts_Footer)
        Me.Accounts_Background.Controls.Add(Me.Accounts_Header)
        Me.Accounts_Background.Location = New System.Drawing.Point(12, 12)
        Me.Accounts_Background.Name = "Accounts_Background"
        Me.Accounts_Background.Size = New System.Drawing.Size(654, 519)
        Me.Accounts_Background.TabIndex = 2
        '
        'Accounts_Footer
        '
        Me.Accounts_Footer.Controls.Add(Me.Button3)
        Me.Accounts_Footer.Controls.Add(Me.test_UC)
        Me.Accounts_Footer.Controls.Add(Me.Button2)
        Me.Accounts_Footer.Controls.Add(Me.Exit_Button)
        Me.Accounts_Footer.Controls.Add(Me.Button1)
        Me.Accounts_Footer.Location = New System.Drawing.Point(3, 442)
        Me.Accounts_Footer.Name = "Accounts_Footer"
        Me.Accounts_Footer.Size = New System.Drawing.Size(648, 74)
        Me.Accounts_Footer.TabIndex = 3
        Me.Accounts_Footer.TabStop = False
        Me.Accounts_Footer.Text = "Settings"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(432, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 44)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "About Software"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'test_UC
        '
        Me.test_UC.Location = New System.Drawing.Point(6, 24)
        Me.test_UC.Name = "test_UC"
        Me.test_UC.Size = New System.Drawing.Size(136, 44)
        Me.test_UC.TabIndex = 2
        Me.test_UC.Text = "Change Appearance"
        Me.test_UC.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(290, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 44)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Your Company Information"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.Location = New System.Drawing.Point(541, 24)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(101, 42)
        Me.Exit_Button.TabIndex = 1
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(148, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 44)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Language"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Accounts_Header
        '
        Me.Accounts_Header.BackgroundImage = Global.Small_Office_Starter.My.Resources.Resources.frontdesk6
        Me.Accounts_Header.Controls.Add(Me.Accounts_Title)
        Me.Accounts_Header.Controls.Add(Me.Accounts_Logo)
        Me.Accounts_Header.Location = New System.Drawing.Point(3, 3)
        Me.Accounts_Header.Name = "Accounts_Header"
        Me.Accounts_Header.Size = New System.Drawing.Size(648, 75)
        Me.Accounts_Header.TabIndex = 0
        '
        'Accounts_Title
        '
        Me.Accounts_Title.AutoSize = True
        Me.Accounts_Title.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accounts_Title.Location = New System.Drawing.Point(255, 23)
        Me.Accounts_Title.Name = "Accounts_Title"
        Me.Accounts_Title.Size = New System.Drawing.Size(230, 26)
        Me.Accounts_Title.TabIndex = 2
        Me.Accounts_Title.Text = "Welcome to Accounts"
        '
        'Accounts_Logo
        '
        Me.Accounts_Logo.Location = New System.Drawing.Point(3, 3)
        Me.Accounts_Logo.Name = "Accounts_Logo"
        Me.Accounts_Logo.Size = New System.Drawing.Size(149, 69)
        Me.Accounts_Logo.TabIndex = 0
        Me.Accounts_Logo.TabStop = False
        '
        'Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 543)
        Me.Controls.Add(Me.Accounts_Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Accounts"
        Me.Text = "Accounts"
        Me.Accounts_Background.ResumeLayout(False)
        Me.Accounts_Footer.ResumeLayout(False)
        Me.Accounts_Header.ResumeLayout(False)
        Me.Accounts_Header.PerformLayout()
        CType(Me.Accounts_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Accounts_Background As Panel
    Friend WithEvents Accounts_Footer As GroupBox
    Friend WithEvents test_UC As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Accounts_Header As Panel
    Friend WithEvents Accounts_Title As Label
    Friend WithEvents Accounts_Logo As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
