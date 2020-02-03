<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontDesk
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
        Me.FrontDesk_Background = New System.Windows.Forms.Panel()
        Me.FrontDesk_Footer = New System.Windows.Forms.GroupBox()
        Me.test_UC = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.FrontDesk_Header = New System.Windows.Forms.Panel()
        Me.FrontDesk_Title = New System.Windows.Forms.Label()
        Me.FrontDesk_Logo = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FrontDesk_Background.SuspendLayout()
        Me.FrontDesk_Footer.SuspendLayout()
        Me.FrontDesk_Header.SuspendLayout()
        CType(Me.FrontDesk_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FrontDesk_Background
        '
        Me.FrontDesk_Background.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FrontDesk_Background.BackgroundImage = Global.Small_Office_Starter.My.Resources.Resources.frontdesk6
        Me.FrontDesk_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FrontDesk_Background.Controls.Add(Me.Label2)
        Me.FrontDesk_Background.Controls.Add(Me.Label1)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Footer)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Header)
        Me.FrontDesk_Background.Location = New System.Drawing.Point(12, 12)
        Me.FrontDesk_Background.Name = "FrontDesk_Background"
        Me.FrontDesk_Background.Size = New System.Drawing.Size(654, 519)
        Me.FrontDesk_Background.TabIndex = 1
        '
        'FrontDesk_Footer
        '
        Me.FrontDesk_Footer.Controls.Add(Me.Button3)
        Me.FrontDesk_Footer.Controls.Add(Me.Button2)
        Me.FrontDesk_Footer.Controls.Add(Me.Button1)
        Me.FrontDesk_Footer.Controls.Add(Me.test_UC)
        Me.FrontDesk_Footer.Controls.Add(Me.Exit_Button)
        Me.FrontDesk_Footer.Location = New System.Drawing.Point(3, 442)
        Me.FrontDesk_Footer.Name = "FrontDesk_Footer"
        Me.FrontDesk_Footer.Size = New System.Drawing.Size(648, 74)
        Me.FrontDesk_Footer.TabIndex = 3
        Me.FrontDesk_Footer.TabStop = False
        Me.FrontDesk_Footer.Text = "Settings"
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
        'Exit_Button
        '
        Me.Exit_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.Location = New System.Drawing.Point(547, 24)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(95, 42)
        Me.Exit_Button.TabIndex = 1
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'FrontDesk_Header
        '
        Me.FrontDesk_Header.BackgroundImage = Global.Small_Office_Starter.My.Resources.Resources.frontdesk6
        Me.FrontDesk_Header.Controls.Add(Me.FrontDesk_Title)
        Me.FrontDesk_Header.Controls.Add(Me.FrontDesk_Logo)
        Me.FrontDesk_Header.Location = New System.Drawing.Point(3, 3)
        Me.FrontDesk_Header.Name = "FrontDesk_Header"
        Me.FrontDesk_Header.Size = New System.Drawing.Size(648, 75)
        Me.FrontDesk_Header.TabIndex = 0
        '
        'FrontDesk_Title
        '
        Me.FrontDesk_Title.AutoSize = True
        Me.FrontDesk_Title.BackColor = System.Drawing.Color.Transparent
        Me.FrontDesk_Title.Font = New System.Drawing.Font("Viner Hand ITC", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrontDesk_Title.Location = New System.Drawing.Point(236, 17)
        Me.FrontDesk_Title.Name = "FrontDesk_Title"
        Me.FrontDesk_Title.Size = New System.Drawing.Size(299, 39)
        Me.FrontDesk_Title.TabIndex = 2
        Me.FrontDesk_Title.Text = "Welcome to Front Desk!"
        '
        'FrontDesk_Logo
        '
        Me.FrontDesk_Logo.Location = New System.Drawing.Point(3, 3)
        Me.FrontDesk_Logo.Name = "FrontDesk_Logo"
        Me.FrontDesk_Logo.Size = New System.Drawing.Size(149, 69)
        Me.FrontDesk_Logo.TabIndex = 0
        Me.FrontDesk_Logo.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(148, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 44)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Language"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(290, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 44)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Your Company Information"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(432, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 44)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "About Software"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'FrontDesk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 543)
        Me.Controls.Add(Me.FrontDesk_Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrontDesk"
        Me.Text = "Form1"
        Me.FrontDesk_Background.ResumeLayout(False)
        Me.FrontDesk_Background.PerformLayout()
        Me.FrontDesk_Footer.ResumeLayout(False)
        Me.FrontDesk_Header.ResumeLayout(False)
        Me.FrontDesk_Header.PerformLayout()
        CType(Me.FrontDesk_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FrontDesk_Background As Panel
    Friend WithEvents FrontDesk_Header As Panel
    Friend WithEvents FrontDesk_Title As Label
    Friend WithEvents Exit_Button As Button
    Friend WithEvents FrontDesk_Logo As PictureBox
    Friend WithEvents test_UC As Button
    Friend WithEvents FrontDesk_Footer As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
