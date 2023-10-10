<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.ComboBoxdegree = New System.Windows.Forms.ComboBox()
        Me.ComboBoxcourse = New System.Windows.Forms.ComboBox()
        Me.TextBoxyear = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxclassstrength = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(157, 31)
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
        Me.Label2.Location = New System.Drawing.Point(297, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "STUDENT DETAILS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(237, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Degree"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(237, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Course"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(237, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Year of study"
        '
        'ComboBoxdegree
        '
        Me.ComboBoxdegree.FormattingEnabled = True
        Me.ComboBoxdegree.Items.AddRange(New Object() {"UG", "PG"})
        Me.ComboBoxdegree.Location = New System.Drawing.Point(416, 157)
        Me.ComboBoxdegree.Name = "ComboBoxdegree"
        Me.ComboBoxdegree.Size = New System.Drawing.Size(151, 28)
        Me.ComboBoxdegree.TabIndex = 5
        '
        'ComboBoxcourse
        '
        Me.ComboBoxcourse.FormattingEnabled = True
        Me.ComboBoxcourse.Items.AddRange(New Object() {"BA(ENGLISH)", "BA(TAMIL)", "BA(MATHS)", "MA(ENGLISH)", "MA(TAMIL)", "MCA"})
        Me.ComboBoxcourse.Location = New System.Drawing.Point(416, 211)
        Me.ComboBoxcourse.Name = "ComboBoxcourse"
        Me.ComboBoxcourse.Size = New System.Drawing.Size(151, 28)
        Me.ComboBoxcourse.TabIndex = 6
        '
        'TextBoxyear
        '
        Me.TextBoxyear.Location = New System.Drawing.Point(417, 259)
        Me.TextBoxyear.Name = "TextBoxyear"
        Me.TextBoxyear.Size = New System.Drawing.Size(150, 27)
        Me.TextBoxyear.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(284, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(473, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(237, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "class strength"
        '
        'TextBoxclassstrength
        '
        Me.TextBoxclassstrength.Location = New System.Drawing.Point(416, 305)
        Me.TextBoxclassstrength.Name = "TextBoxclassstrength"
        Me.TextBoxclassstrength.Size = New System.Drawing.Size(151, 27)
        Me.TextBoxclassstrength.TabIndex = 11
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.coe.My.Resources.Resources.Untitled_design__3_1
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxclassstrength)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxyear)
        Me.Controls.Add(Me.ComboBoxcourse)
        Me.Controls.Add(Me.ComboBoxdegree)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxdegree As ComboBox
    Friend WithEvents ComboBoxcourse As ComboBox
    Friend WithEvents TextBoxyear As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxclassstrength As TextBox
End Class
