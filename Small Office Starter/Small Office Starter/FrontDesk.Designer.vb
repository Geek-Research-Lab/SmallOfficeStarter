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
        Me.FrontDesk_GetInfo = New System.Windows.Forms.GroupBox()
        Me.FrontDesk_GetInfo_Report = New System.Windows.Forms.Button()
        Me.FrontDesk_GetInfo_Contacts = New System.Windows.Forms.Button()
        Me.FrontDesk_GetInfo_Visitors = New System.Windows.Forms.Button()
        Me.FrontDesk_GetInfo_Enquiry = New System.Windows.Forms.Button()
        Me.FrontDesk_Submit = New System.Windows.Forms.Button()
        Me.FrontDesk_Type = New System.Windows.Forms.ComboBox()
        Me.FrontDesk_DateTime = New System.Windows.Forms.TextBox()
        Me.FrontDesk_ID = New System.Windows.Forms.TextBox()
        Me.FrontDesk_Description = New System.Windows.Forms.TextBox()
        Me.FrontDesk_OtherContact = New System.Windows.Forms.TextBox()
        Me.FrontDesk_Phone = New System.Windows.Forms.TextBox()
        Me.FrontDesk_Email = New System.Windows.Forms.TextBox()
        Me.FrontDesk_Name = New System.Windows.Forms.TextBox()
        Me.FrontDesk_Label_DateTime = New System.Windows.Forms.Label()
        Me.FrontDesk_Label_ID = New System.Windows.Forms.Label()
        Me.FrontDesk_Label_Description = New System.Windows.Forms.Label()
        Me.FrontDesk_Label_OtherContact = New System.Windows.Forms.Label()
        Me.FrontDesk_Label_Phone = New System.Windows.Forms.Label()
        Me.FrontDesk_Label_Email = New System.Windows.Forms.Label()
        Me.FrontDesk_Label_Name = New System.Windows.Forms.Label()
        Me.FrontDesk_Label_Type = New System.Windows.Forms.Label()
        Me.FrontDesk_Footer = New System.Windows.Forms.GroupBox()
        Me.FrontDesk_Footer_About = New System.Windows.Forms.Button()
        Me.FrontDesk_Footer_CompanyInfo = New System.Windows.Forms.Button()
        Me.FrontDesk_Footer_Language = New System.Windows.Forms.Button()
        Me.FrontDesk_Footer_Appearance = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.FrontDesk_Header = New System.Windows.Forms.Panel()
        Me.FrontDesk_Title = New System.Windows.Forms.Label()
        Me.FrontDesk_Logo = New System.Windows.Forms.PictureBox()
        Me.FrontDesk_Background.SuspendLayout()
        Me.FrontDesk_GetInfo.SuspendLayout()
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
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_GetInfo)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Submit)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Type)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_DateTime)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_ID)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Description)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_OtherContact)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Phone)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Email)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Name)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Label_DateTime)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Label_ID)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Label_Description)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Label_OtherContact)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Label_Phone)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Label_Email)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Label_Name)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Label_Type)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Footer)
        Me.FrontDesk_Background.Controls.Add(Me.FrontDesk_Header)
        Me.FrontDesk_Background.Location = New System.Drawing.Point(12, 12)
        Me.FrontDesk_Background.Name = "FrontDesk_Background"
        Me.FrontDesk_Background.Size = New System.Drawing.Size(654, 519)
        Me.FrontDesk_Background.TabIndex = 1
        '
        'FrontDesk_GetInfo
        '
        Me.FrontDesk_GetInfo.BackColor = System.Drawing.Color.Transparent
        Me.FrontDesk_GetInfo.Controls.Add(Me.FrontDesk_GetInfo_Report)
        Me.FrontDesk_GetInfo.Controls.Add(Me.FrontDesk_GetInfo_Contacts)
        Me.FrontDesk_GetInfo.Controls.Add(Me.FrontDesk_GetInfo_Visitors)
        Me.FrontDesk_GetInfo.Controls.Add(Me.FrontDesk_GetInfo_Enquiry)
        Me.FrontDesk_GetInfo.Location = New System.Drawing.Point(3, 354)
        Me.FrontDesk_GetInfo.Name = "FrontDesk_GetInfo"
        Me.FrontDesk_GetInfo.Size = New System.Drawing.Size(645, 69)
        Me.FrontDesk_GetInfo.TabIndex = 21
        Me.FrontDesk_GetInfo.TabStop = False
        Me.FrontDesk_GetInfo.Text = "Get Information"
        '
        'FrontDesk_GetInfo_Report
        '
        Me.FrontDesk_GetInfo_Report.Location = New System.Drawing.Point(432, 21)
        Me.FrontDesk_GetInfo_Report.Name = "FrontDesk_GetInfo_Report"
        Me.FrontDesk_GetInfo_Report.Size = New System.Drawing.Size(136, 44)
        Me.FrontDesk_GetInfo_Report.TabIndex = 22
        Me.FrontDesk_GetInfo_Report.Text = "Statistical Report"
        Me.FrontDesk_GetInfo_Report.UseVisualStyleBackColor = True
        '
        'FrontDesk_GetInfo_Contacts
        '
        Me.FrontDesk_GetInfo_Contacts.Location = New System.Drawing.Point(290, 21)
        Me.FrontDesk_GetInfo_Contacts.Name = "FrontDesk_GetInfo_Contacts"
        Me.FrontDesk_GetInfo_Contacts.Size = New System.Drawing.Size(136, 44)
        Me.FrontDesk_GetInfo_Contacts.TabIndex = 7
        Me.FrontDesk_GetInfo_Contacts.Text = "Contacts List"
        Me.FrontDesk_GetInfo_Contacts.UseVisualStyleBackColor = True
        '
        'FrontDesk_GetInfo_Visitors
        '
        Me.FrontDesk_GetInfo_Visitors.Location = New System.Drawing.Point(148, 21)
        Me.FrontDesk_GetInfo_Visitors.Name = "FrontDesk_GetInfo_Visitors"
        Me.FrontDesk_GetInfo_Visitors.Size = New System.Drawing.Size(136, 44)
        Me.FrontDesk_GetInfo_Visitors.TabIndex = 6
        Me.FrontDesk_GetInfo_Visitors.Text = "Visitors / Interviewees List"
        Me.FrontDesk_GetInfo_Visitors.UseVisualStyleBackColor = True
        '
        'FrontDesk_GetInfo_Enquiry
        '
        Me.FrontDesk_GetInfo_Enquiry.Location = New System.Drawing.Point(6, 21)
        Me.FrontDesk_GetInfo_Enquiry.Name = "FrontDesk_GetInfo_Enquiry"
        Me.FrontDesk_GetInfo_Enquiry.Size = New System.Drawing.Size(136, 44)
        Me.FrontDesk_GetInfo_Enquiry.TabIndex = 5
        Me.FrontDesk_GetInfo_Enquiry.Text = "Enquiry List"
        Me.FrontDesk_GetInfo_Enquiry.UseVisualStyleBackColor = True
        '
        'FrontDesk_Submit
        '
        Me.FrontDesk_Submit.Location = New System.Drawing.Point(246, 296)
        Me.FrontDesk_Submit.Name = "FrontDesk_Submit"
        Me.FrontDesk_Submit.Size = New System.Drawing.Size(150, 42)
        Me.FrontDesk_Submit.TabIndex = 20
        Me.FrontDesk_Submit.Text = "Submit"
        Me.FrontDesk_Submit.UseVisualStyleBackColor = True
        '
        'FrontDesk_Type
        '
        Me.FrontDesk_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FrontDesk_Type.FormattingEnabled = True
        Me.FrontDesk_Type.Items.AddRange(New Object() {"Enquiry", "New Visitor", "Interview", "New Contact"})
        Me.FrontDesk_Type.Location = New System.Drawing.Point(95, 93)
        Me.FrontDesk_Type.Name = "FrontDesk_Type"
        Me.FrontDesk_Type.Size = New System.Drawing.Size(175, 24)
        Me.FrontDesk_Type.TabIndex = 19
        '
        'FrontDesk_DateTime
        '
        Me.FrontDesk_DateTime.Location = New System.Drawing.Point(402, 78)
        Me.FrontDesk_DateTime.Name = "FrontDesk_DateTime"
        Me.FrontDesk_DateTime.ReadOnly = True
        Me.FrontDesk_DateTime.Size = New System.Drawing.Size(243, 22)
        Me.FrontDesk_DateTime.TabIndex = 18
        '
        'FrontDesk_ID
        '
        Me.FrontDesk_ID.Location = New System.Drawing.Point(503, 109)
        Me.FrontDesk_ID.Name = "FrontDesk_ID"
        Me.FrontDesk_ID.ReadOnly = True
        Me.FrontDesk_ID.Size = New System.Drawing.Size(143, 22)
        Me.FrontDesk_ID.TabIndex = 17
        '
        'FrontDesk_Description
        '
        Me.FrontDesk_Description.Location = New System.Drawing.Point(113, 255)
        Me.FrontDesk_Description.Name = "FrontDesk_Description"
        Me.FrontDesk_Description.Size = New System.Drawing.Size(519, 22)
        Me.FrontDesk_Description.TabIndex = 16
        '
        'FrontDesk_OtherContact
        '
        Me.FrontDesk_OtherContact.Location = New System.Drawing.Point(423, 217)
        Me.FrontDesk_OtherContact.Name = "FrontDesk_OtherContact"
        Me.FrontDesk_OtherContact.Size = New System.Drawing.Size(222, 22)
        Me.FrontDesk_OtherContact.TabIndex = 15
        '
        'FrontDesk_Phone
        '
        Me.FrontDesk_Phone.Location = New System.Drawing.Point(80, 217)
        Me.FrontDesk_Phone.Name = "FrontDesk_Phone"
        Me.FrontDesk_Phone.Size = New System.Drawing.Size(168, 22)
        Me.FrontDesk_Phone.TabIndex = 14
        '
        'FrontDesk_Email
        '
        Me.FrontDesk_Email.Location = New System.Drawing.Point(95, 177)
        Me.FrontDesk_Email.Name = "FrontDesk_Email"
        Me.FrontDesk_Email.Size = New System.Drawing.Size(495, 22)
        Me.FrontDesk_Email.TabIndex = 13
        '
        'FrontDesk_Name
        '
        Me.FrontDesk_Name.Location = New System.Drawing.Point(95, 140)
        Me.FrontDesk_Name.Name = "FrontDesk_Name"
        Me.FrontDesk_Name.Size = New System.Drawing.Size(254, 22)
        Me.FrontDesk_Name.TabIndex = 12
        '
        'FrontDesk_Label_DateTime
        '
        Me.FrontDesk_Label_DateTime.AutoSize = True
        Me.FrontDesk_Label_DateTime.Location = New System.Drawing.Point(315, 81)
        Me.FrontDesk_Label_DateTime.Name = "FrontDesk_Label_DateTime"
        Me.FrontDesk_Label_DateTime.Size = New System.Drawing.Size(81, 17)
        Me.FrontDesk_Label_DateTime.TabIndex = 11
        Me.FrontDesk_Label_DateTime.Text = "Date / Time"
        '
        'FrontDesk_Label_ID
        '
        Me.FrontDesk_Label_ID.AutoSize = True
        Me.FrontDesk_Label_ID.Location = New System.Drawing.Point(464, 112)
        Me.FrontDesk_Label_ID.Name = "FrontDesk_Label_ID"
        Me.FrontDesk_Label_ID.Size = New System.Drawing.Size(33, 17)
        Me.FrontDesk_Label_ID.TabIndex = 10
        Me.FrontDesk_Label_ID.Text = "ID #"
        '
        'FrontDesk_Label_Description
        '
        Me.FrontDesk_Label_Description.AutoSize = True
        Me.FrontDesk_Label_Description.Location = New System.Drawing.Point(19, 258)
        Me.FrontDesk_Label_Description.Name = "FrontDesk_Label_Description"
        Me.FrontDesk_Label_Description.Size = New System.Drawing.Size(79, 17)
        Me.FrontDesk_Label_Description.TabIndex = 9
        Me.FrontDesk_Label_Description.Text = "Description"
        '
        'FrontDesk_Label_OtherContact
        '
        Me.FrontDesk_Label_OtherContact.AutoSize = True
        Me.FrontDesk_Label_OtherContact.Location = New System.Drawing.Point(263, 220)
        Me.FrontDesk_Label_OtherContact.Name = "FrontDesk_Label_OtherContact"
        Me.FrontDesk_Label_OtherContact.Size = New System.Drawing.Size(143, 17)
        Me.FrontDesk_Label_OtherContact.TabIndex = 8
        Me.FrontDesk_Label_OtherContact.Text = "Other Contact Details"
        '
        'FrontDesk_Label_Phone
        '
        Me.FrontDesk_Label_Phone.AutoSize = True
        Me.FrontDesk_Label_Phone.Location = New System.Drawing.Point(19, 222)
        Me.FrontDesk_Label_Phone.Name = "FrontDesk_Label_Phone"
        Me.FrontDesk_Label_Phone.Size = New System.Drawing.Size(49, 17)
        Me.FrontDesk_Label_Phone.TabIndex = 7
        Me.FrontDesk_Label_Phone.Text = "Phone"
        '
        'FrontDesk_Label_Email
        '
        Me.FrontDesk_Label_Email.AutoSize = True
        Me.FrontDesk_Label_Email.Location = New System.Drawing.Point(19, 182)
        Me.FrontDesk_Label_Email.Name = "FrontDesk_Label_Email"
        Me.FrontDesk_Label_Email.Size = New System.Drawing.Size(42, 17)
        Me.FrontDesk_Label_Email.TabIndex = 6
        Me.FrontDesk_Label_Email.Text = "Email"
        '
        'FrontDesk_Label_Name
        '
        Me.FrontDesk_Label_Name.AutoSize = True
        Me.FrontDesk_Label_Name.Location = New System.Drawing.Point(19, 143)
        Me.FrontDesk_Label_Name.Name = "FrontDesk_Label_Name"
        Me.FrontDesk_Label_Name.Size = New System.Drawing.Size(45, 17)
        Me.FrontDesk_Label_Name.TabIndex = 5
        Me.FrontDesk_Label_Name.Text = "Name"
        '
        'FrontDesk_Label_Type
        '
        Me.FrontDesk_Label_Type.AutoSize = True
        Me.FrontDesk_Label_Type.Location = New System.Drawing.Point(19, 96)
        Me.FrontDesk_Label_Type.Name = "FrontDesk_Label_Type"
        Me.FrontDesk_Label_Type.Size = New System.Drawing.Size(40, 17)
        Me.FrontDesk_Label_Type.TabIndex = 4
        Me.FrontDesk_Label_Type.Text = "Type"
        '
        'FrontDesk_Footer
        '
        Me.FrontDesk_Footer.BackColor = System.Drawing.Color.Transparent
        Me.FrontDesk_Footer.Controls.Add(Me.FrontDesk_Footer_About)
        Me.FrontDesk_Footer.Controls.Add(Me.FrontDesk_Footer_CompanyInfo)
        Me.FrontDesk_Footer.Controls.Add(Me.FrontDesk_Footer_Language)
        Me.FrontDesk_Footer.Controls.Add(Me.FrontDesk_Footer_Appearance)
        Me.FrontDesk_Footer.Controls.Add(Me.Exit_Button)
        Me.FrontDesk_Footer.Location = New System.Drawing.Point(3, 442)
        Me.FrontDesk_Footer.Name = "FrontDesk_Footer"
        Me.FrontDesk_Footer.Size = New System.Drawing.Size(648, 74)
        Me.FrontDesk_Footer.TabIndex = 3
        Me.FrontDesk_Footer.TabStop = False
        Me.FrontDesk_Footer.Text = "Settings"
        '
        'FrontDesk_Footer_About
        '
        Me.FrontDesk_Footer_About.Location = New System.Drawing.Point(432, 25)
        Me.FrontDesk_Footer_About.Name = "FrontDesk_Footer_About"
        Me.FrontDesk_Footer_About.Size = New System.Drawing.Size(103, 44)
        Me.FrontDesk_Footer_About.TabIndex = 4
        Me.FrontDesk_Footer_About.Text = "About Software"
        Me.FrontDesk_Footer_About.UseVisualStyleBackColor = True
        '
        'FrontDesk_Footer_CompanyInfo
        '
        Me.FrontDesk_Footer_CompanyInfo.Location = New System.Drawing.Point(290, 25)
        Me.FrontDesk_Footer_CompanyInfo.Name = "FrontDesk_Footer_CompanyInfo"
        Me.FrontDesk_Footer_CompanyInfo.Size = New System.Drawing.Size(136, 44)
        Me.FrontDesk_Footer_CompanyInfo.TabIndex = 4
        Me.FrontDesk_Footer_CompanyInfo.Text = "Your Company Information"
        Me.FrontDesk_Footer_CompanyInfo.UseVisualStyleBackColor = True
        '
        'FrontDesk_Footer_Language
        '
        Me.FrontDesk_Footer_Language.Location = New System.Drawing.Point(148, 24)
        Me.FrontDesk_Footer_Language.Name = "FrontDesk_Footer_Language"
        Me.FrontDesk_Footer_Language.Size = New System.Drawing.Size(136, 44)
        Me.FrontDesk_Footer_Language.TabIndex = 3
        Me.FrontDesk_Footer_Language.Text = "Language"
        Me.FrontDesk_Footer_Language.UseVisualStyleBackColor = True
        '
        'FrontDesk_Footer_Appearance
        '
        Me.FrontDesk_Footer_Appearance.Location = New System.Drawing.Point(6, 24)
        Me.FrontDesk_Footer_Appearance.Name = "FrontDesk_Footer_Appearance"
        Me.FrontDesk_Footer_Appearance.Size = New System.Drawing.Size(136, 44)
        Me.FrontDesk_Footer_Appearance.TabIndex = 2
        Me.FrontDesk_Footer_Appearance.Text = "Change Appearance"
        Me.FrontDesk_Footer_Appearance.UseVisualStyleBackColor = True
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
        Me.FrontDesk_GetInfo.ResumeLayout(False)
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
    Friend WithEvents FrontDesk_Footer_Appearance As Button
    Friend WithEvents FrontDesk_Footer As GroupBox
    Friend WithEvents FrontDesk_Footer_About As Button
    Friend WithEvents FrontDesk_Footer_CompanyInfo As Button
    Friend WithEvents FrontDesk_Footer_Language As Button
    Friend WithEvents FrontDesk_Label_Name As Label
    Friend WithEvents FrontDesk_Label_Type As Label
    Friend WithEvents FrontDesk_Label_DateTime As Label
    Friend WithEvents FrontDesk_Label_ID As Label
    Friend WithEvents FrontDesk_Label_OtherContact As Label
    Friend WithEvents FrontDesk_Label_Phone As Label
    Friend WithEvents FrontDesk_Label_Email As Label
    Friend WithEvents FrontDesk_Type As ComboBox
    Friend WithEvents FrontDesk_DateTime As TextBox
    Friend WithEvents FrontDesk_ID As TextBox
    Friend WithEvents FrontDesk_Description As TextBox
    Friend WithEvents FrontDesk_OtherContact As TextBox
    Friend WithEvents FrontDesk_Phone As TextBox
    Friend WithEvents FrontDesk_Email As TextBox
    Friend WithEvents FrontDesk_Name As TextBox
    Friend WithEvents FrontDesk_Label_Description As Label
    Friend WithEvents FrontDesk_Submit As Button
    Friend WithEvents FrontDesk_GetInfo As GroupBox
    Friend WithEvents FrontDesk_GetInfo_Report As Button
    Friend WithEvents FrontDesk_GetInfo_Contacts As Button
    Friend WithEvents FrontDesk_GetInfo_Visitors As Button
    Friend WithEvents FrontDesk_GetInfo_Enquiry As Button
End Class
