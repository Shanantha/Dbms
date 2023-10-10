<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxdate = New System.Windows.Forms.TextBox()
        Me.TextBoxtime = New System.Windows.Forms.TextBox()
        Me.ComboBoxdepartmentID = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBoxcoursecode = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxyear = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(188, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(542, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DOMS COLLEGE OF ARTS AND SCIENCE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(300, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TIME TABLE ENTRY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(259, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(259, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(259, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Department ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(259, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Course Code"
        '
        'TextBoxdate
        '
        Me.TextBoxdate.Location = New System.Drawing.Point(440, 128)
        Me.TextBoxdate.Name = "TextBoxdate"
        Me.TextBoxdate.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxdate.TabIndex = 6
        '
        'TextBoxtime
        '
        Me.TextBoxtime.Location = New System.Drawing.Point(440, 174)
        Me.TextBoxtime.Name = "TextBoxtime"
        Me.TextBoxtime.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxtime.TabIndex = 7
        '
        'ComboBoxdepartmentID
        '
        Me.ComboBoxdepartmentID.FormattingEnabled = True
        Me.ComboBoxdepartmentID.Items.AddRange(New Object() {"1102", "1103", "1104", "1005", "1006"})
        Me.ComboBoxdepartmentID.Location = New System.Drawing.Point(440, 226)
        Me.ComboBoxdepartmentID.Name = "ComboBoxdepartmentID"
        Me.ComboBoxdepartmentID.Size = New System.Drawing.Size(151, 28)
        Me.ComboBoxdepartmentID.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(259, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(440, 393)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBoxcoursecode
        '
        Me.ComboBoxcoursecode.FormattingEnabled = True
        Me.ComboBoxcoursecode.Items.AddRange(New Object() {"BA.eng10023", "BA.tam10022", "mca20011", "MA.eng10032", "MA.tam10033"})
        Me.ComboBoxcoursecode.Location = New System.Drawing.Point(463, 283)
        Me.ComboBoxcoursecode.Name = "ComboBoxcoursecode"
        Me.ComboBoxcoursecode.Size = New System.Drawing.Size(151, 28)
        Me.ComboBoxcoursecode.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(269, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "year"
        '
        'TextBoxyear
        '
        Me.TextBoxyear.Location = New System.Drawing.Point(446, 203)
        Me.TextBoxyear.Name = "TextBoxyear"
        Me.TextBoxyear.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxyear.TabIndex = 14
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.coe.My.Resources.Resources.Untitled_design__4_1
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxyear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBoxcoursecode)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxdepartmentID)
        Me.Controls.Add(Me.TextBoxtime)
        Me.Controls.Add(Me.TextBoxdate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxdate As TextBox
    Friend WithEvents TextBoxtime As TextBox
    Friend WithEvents ComboBoxdepartmentID As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBoxcoursecode As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxyear As TextBox
End Class
