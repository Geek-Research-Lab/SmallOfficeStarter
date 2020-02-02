<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HrPayroll
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
        Me.HrPayroll_Background = New System.Windows.Forms.Panel()
        Me.HrPayroll_Footer = New System.Windows.Forms.GroupBox()
        Me.test_UC = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.HrPayroll_Header = New System.Windows.Forms.Panel()
        Me.HrPayroll_Title = New System.Windows.Forms.Label()
        Me.HrPayroll_Logo = New System.Windows.Forms.PictureBox()
        Me.HrPayroll_Background.SuspendLayout()
        Me.HrPayroll_Footer.SuspendLayout()
        Me.HrPayroll_Header.SuspendLayout()
        CType(Me.HrPayroll_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HrPayroll_Background
        '
        Me.HrPayroll_Background.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.HrPayroll_Background.BackgroundImage = Global.Small_Office_Starter.My.Resources.Resources.hrpayroll1
        Me.HrPayroll_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HrPayroll_Background.Controls.Add(Me.HrPayroll_Footer)
        Me.HrPayroll_Background.Controls.Add(Me.HrPayroll_Header)
        Me.HrPayroll_Background.Location = New System.Drawing.Point(12, 9)
        Me.HrPayroll_Background.Name = "HrPayroll_Background"
        Me.HrPayroll_Background.Size = New System.Drawing.Size(654, 519)
        Me.HrPayroll_Background.TabIndex = 2
        '
        'HrPayroll_Footer
        '
        Me.HrPayroll_Footer.Controls.Add(Me.test_UC)
        Me.HrPayroll_Footer.Controls.Add(Me.Exit_Button)
        Me.HrPayroll_Footer.Location = New System.Drawing.Point(3, 442)
        Me.HrPayroll_Footer.Name = "HrPayroll_Footer"
        Me.HrPayroll_Footer.Size = New System.Drawing.Size(648, 74)
        Me.HrPayroll_Footer.TabIndex = 3
        Me.HrPayroll_Footer.TabStop = False
        Me.HrPayroll_Footer.Text = "Settings"
        '
        'test_UC
        '
        Me.test_UC.Location = New System.Drawing.Point(16, 24)
        Me.test_UC.Name = "test_UC"
        Me.test_UC.Size = New System.Drawing.Size(136, 44)
        Me.test_UC.TabIndex = 2
        Me.test_UC.Text = "Change Appearance"
        Me.test_UC.UseVisualStyleBackColor = True
        '
        'Exit_Button
        '
        Me.Exit_Button.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.Location = New System.Drawing.Point(529, 24)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(113, 42)
        Me.Exit_Button.TabIndex = 1
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'HrPayroll_Header
        '
        Me.HrPayroll_Header.BackgroundImage = Global.Small_Office_Starter.My.Resources.Resources.frontdesk6
        Me.HrPayroll_Header.Controls.Add(Me.HrPayroll_Title)
        Me.HrPayroll_Header.Controls.Add(Me.HrPayroll_Logo)
        Me.HrPayroll_Header.Location = New System.Drawing.Point(3, 3)
        Me.HrPayroll_Header.Name = "HrPayroll_Header"
        Me.HrPayroll_Header.Size = New System.Drawing.Size(648, 75)
        Me.HrPayroll_Header.TabIndex = 0
        '
        'HrPayroll_Title
        '
        Me.HrPayroll_Title.AutoSize = True
        Me.HrPayroll_Title.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HrPayroll_Title.Location = New System.Drawing.Point(198, 23)
        Me.HrPayroll_Title.Name = "HrPayroll_Title"
        Me.HrPayroll_Title.Size = New System.Drawing.Size(268, 26)
        Me.HrPayroll_Title.TabIndex = 2
        Me.HrPayroll_Title.Text = "Welcome to HR / Payroll"
        '
        'HrPayroll_Logo
        '
        Me.HrPayroll_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HrPayroll_Logo.Location = New System.Drawing.Point(3, 3)
        Me.HrPayroll_Logo.Name = "HrPayroll_Logo"
        Me.HrPayroll_Logo.Size = New System.Drawing.Size(149, 69)
        Me.HrPayroll_Logo.TabIndex = 0
        Me.HrPayroll_Logo.TabStop = False
        '
        'HrPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 540)
        Me.Controls.Add(Me.HrPayroll_Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HrPayroll"
        Me.Text = "HrPayroll"
        Me.HrPayroll_Background.ResumeLayout(False)
        Me.HrPayroll_Footer.ResumeLayout(False)
        Me.HrPayroll_Header.ResumeLayout(False)
        Me.HrPayroll_Header.PerformLayout()
        CType(Me.HrPayroll_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HrPayroll_Background As Panel
    Friend WithEvents HrPayroll_Footer As GroupBox
    Friend WithEvents test_UC As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents HrPayroll_Header As Panel
    Friend WithEvents HrPayroll_Title As Label
    Friend WithEvents HrPayroll_Logo As PictureBox
End Class
