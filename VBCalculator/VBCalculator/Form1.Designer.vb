<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pUserpanel1 = New System.Windows.Forms.Panel()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.bMathComma = New System.Windows.Forms.Button()
        Me.bMathNumber9 = New System.Windows.Forms.Button()
        Me.bMathNumber8 = New System.Windows.Forms.Button()
        Me.bMathNumber7 = New System.Windows.Forms.Button()
        Me.bMathNumber6 = New System.Windows.Forms.Button()
        Me.bMathNumber5 = New System.Windows.Forms.Button()
        Me.bMathNumber4 = New System.Windows.Forms.Button()
        Me.bMathNumber3 = New System.Windows.Forms.Button()
        Me.bMathNumber2 = New System.Windows.Forms.Button()
        Me.bMathNumber0 = New System.Windows.Forms.Button()
        Me.bMathNumber1 = New System.Windows.Forms.Button()
        Me.pSystempanel1 = New System.Windows.Forms.Panel()
        Me.Ergebnisverlauf = New System.Windows.Forms.Label()
        Me.llGithub = New System.Windows.Forms.LinkLabel()
        Me.llHomepage1 = New System.Windows.Forms.LinkLabel()
        Me.llRickroll = New System.Windows.Forms.LinkLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pUserpanel1.SuspendLayout()
        Me.pSystempanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pUserpanel1
        '
        Me.pUserpanel1.BackColor = System.Drawing.Color.Black
        Me.pUserpanel1.Controls.Add(Me.Button1)
        Me.pUserpanel1.Controls.Add(Me.Button13)
        Me.pUserpanel1.Controls.Add(Me.Button12)
        Me.pUserpanel1.Controls.Add(Me.Button11)
        Me.pUserpanel1.Controls.Add(Me.Button10)
        Me.pUserpanel1.Controls.Add(Me.bMathComma)
        Me.pUserpanel1.Controls.Add(Me.bMathNumber9)
        Me.pUserpanel1.Controls.Add(Me.bMathNumber8)
        Me.pUserpanel1.Controls.Add(Me.bMathNumber7)
        Me.pUserpanel1.Controls.Add(Me.bMathNumber6)
        Me.pUserpanel1.Controls.Add(Me.bMathNumber5)
        Me.pUserpanel1.Controls.Add(Me.bMathNumber4)
        Me.pUserpanel1.Controls.Add(Me.bMathNumber3)
        Me.pUserpanel1.Controls.Add(Me.bMathNumber2)
        Me.pUserpanel1.Controls.Add(Me.bMathNumber0)
        Me.pUserpanel1.Controls.Add(Me.bMathNumber1)
        Me.pUserpanel1.Location = New System.Drawing.Point(12, 93)
        Me.pUserpanel1.Name = "pUserpanel1"
        Me.pUserpanel1.Size = New System.Drawing.Size(753, 280)
        Me.pUserpanel1.TabIndex = 0
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(256, 205)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 57)
        Me.Button13.TabIndex = 40
        Me.Button13.Tag = "MathNumber"
        Me.Button13.Text = "/"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(256, 142)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 57)
        Me.Button12.TabIndex = 39
        Me.Button12.Tag = "MathNumber"
        Me.Button12.Text = "*"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(256, 79)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 57)
        Me.Button11.TabIndex = 38
        Me.Button11.Tag = "MathNumber"
        Me.Button11.Text = "-"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(256, 16)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 57)
        Me.Button10.TabIndex = 37
        Me.Button10.Tag = "MathNumber"
        Me.Button10.Text = "+"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'bMathComma
        '
        Me.bMathComma.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMathComma.Location = New System.Drawing.Point(175, 205)
        Me.bMathComma.Name = "bMathComma"
        Me.bMathComma.Size = New System.Drawing.Size(75, 57)
        Me.bMathComma.TabIndex = 36
        Me.bMathComma.Tag = "MathNumber"
        Me.bMathComma.Text = ","
        Me.bMathComma.UseVisualStyleBackColor = True
        '
        'bMathNumber9
        '
        Me.bMathNumber9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMathNumber9.Location = New System.Drawing.Point(175, 142)
        Me.bMathNumber9.Name = "bMathNumber9"
        Me.bMathNumber9.Size = New System.Drawing.Size(75, 57)
        Me.bMathNumber9.TabIndex = 35
        Me.bMathNumber9.Tag = "MathNumber"
        Me.bMathNumber9.Text = "9"
        Me.bMathNumber9.UseVisualStyleBackColor = True
        '
        'bMathNumber8
        '
        Me.bMathNumber8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMathNumber8.Location = New System.Drawing.Point(94, 142)
        Me.bMathNumber8.Name = "bMathNumber8"
        Me.bMathNumber8.Size = New System.Drawing.Size(75, 57)
        Me.bMathNumber8.TabIndex = 34
        Me.bMathNumber8.Tag = "MathNumber"
        Me.bMathNumber8.Text = "8"
        Me.bMathNumber8.UseVisualStyleBackColor = True
        '
        'bMathNumber7
        '
        Me.bMathNumber7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMathNumber7.Location = New System.Drawing.Point(13, 142)
        Me.bMathNumber7.Name = "bMathNumber7"
        Me.bMathNumber7.Size = New System.Drawing.Size(75, 57)
        Me.bMathNumber7.TabIndex = 33
        Me.bMathNumber7.Tag = "MathNumber"
        Me.bMathNumber7.Text = "7"
        Me.bMathNumber7.UseVisualStyleBackColor = True
        '
        'bMathNumber6
        '
        Me.bMathNumber6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMathNumber6.Location = New System.Drawing.Point(175, 79)
        Me.bMathNumber6.Name = "bMathNumber6"
        Me.bMathNumber6.Size = New System.Drawing.Size(75, 57)
        Me.bMathNumber6.TabIndex = 32
        Me.bMathNumber6.Tag = "MathNumber"
        Me.bMathNumber6.Text = "6"
        Me.bMathNumber6.UseVisualStyleBackColor = True
        '
        'bMathNumber5
        '
        Me.bMathNumber5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMathNumber5.Location = New System.Drawing.Point(94, 79)
        Me.bMathNumber5.Name = "bMathNumber5"
        Me.bMathNumber5.Size = New System.Drawing.Size(75, 57)
        Me.bMathNumber5.TabIndex = 31
        Me.bMathNumber5.Tag = "MathNumber"
        Me.bMathNumber5.Text = "5"
        Me.bMathNumber5.UseVisualStyleBackColor = True
        '
        'bMathNumber4
        '
        Me.bMathNumber4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMathNumber4.Location = New System.Drawing.Point(13, 79)
        Me.bMathNumber4.Name = "bMathNumber4"
        Me.bMathNumber4.Size = New System.Drawing.Size(75, 57)
        Me.bMathNumber4.TabIndex = 30
        Me.bMathNumber4.Tag = "MathNumber"
        Me.bMathNumber4.Text = "4"
        Me.bMathNumber4.UseVisualStyleBackColor = True
        '
        'bMathNumber3
        '
        Me.bMathNumber3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMathNumber3.Location = New System.Drawing.Point(175, 16)
        Me.bMathNumber3.Name = "bMathNumber3"
        Me.bMathNumber3.Size = New System.Drawing.Size(75, 57)
        Me.bMathNumber3.TabIndex = 29
        Me.bMathNumber3.Tag = "MathNumber"
        Me.bMathNumber3.Text = "3"
        Me.bMathNumber3.UseVisualStyleBackColor = True
        '
        'bMathNumber2
        '
        Me.bMathNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMathNumber2.Location = New System.Drawing.Point(94, 16)
        Me.bMathNumber2.Name = "bMathNumber2"
        Me.bMathNumber2.Size = New System.Drawing.Size(75, 57)
        Me.bMathNumber2.TabIndex = 28
        Me.bMathNumber2.Tag = "MathNumber"
        Me.bMathNumber2.Text = "2"
        Me.bMathNumber2.UseVisualStyleBackColor = True
        '
        'bMathNumber0
        '
        Me.bMathNumber0.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMathNumber0.Location = New System.Drawing.Point(13, 205)
        Me.bMathNumber0.Name = "bMathNumber0"
        Me.bMathNumber0.Size = New System.Drawing.Size(156, 57)
        Me.bMathNumber0.TabIndex = 27
        Me.bMathNumber0.Tag = "MathNumber"
        Me.bMathNumber0.Text = "0"
        Me.bMathNumber0.UseVisualStyleBackColor = True
        '
        'bMathNumber1
        '
        Me.bMathNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMathNumber1.Location = New System.Drawing.Point(13, 16)
        Me.bMathNumber1.Name = "bMathNumber1"
        Me.bMathNumber1.Size = New System.Drawing.Size(75, 57)
        Me.bMathNumber1.TabIndex = 13
        Me.bMathNumber1.Tag = "MathNumber"
        Me.bMathNumber1.Text = "1"
        Me.bMathNumber1.UseVisualStyleBackColor = True
        '
        'pSystempanel1
        '
        Me.pSystempanel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.pSystempanel1.Controls.Add(Me.Ergebnisverlauf)
        Me.pSystempanel1.Location = New System.Drawing.Point(12, 12)
        Me.pSystempanel1.Name = "pSystempanel1"
        Me.pSystempanel1.Size = New System.Drawing.Size(753, 75)
        Me.pSystempanel1.TabIndex = 1
        '
        'Ergebnisverlauf
        '
        Me.Ergebnisverlauf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ergebnisverlauf.Location = New System.Drawing.Point(0, 0)
        Me.Ergebnisverlauf.Margin = New System.Windows.Forms.Padding(0)
        Me.Ergebnisverlauf.Name = "Ergebnisverlauf"
        Me.Ergebnisverlauf.Padding = New System.Windows.Forms.Padding(3)
        Me.Ergebnisverlauf.Size = New System.Drawing.Size(753, 75)
        Me.Ergebnisverlauf.TabIndex = 0
        Me.Ergebnisverlauf.Text = "Start"
        Me.Ergebnisverlauf.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'llGithub
        '
        Me.llGithub.AccessibleDescription = "GitHubLink"
        Me.llGithub.AccessibleName = "GitHubLink"
        Me.llGithub.AutoSize = True
        Me.llGithub.LinkColor = System.Drawing.Color.Black
        Me.llGithub.Location = New System.Drawing.Point(668, 376)
        Me.llGithub.Name = "llGithub"
        Me.llGithub.Size = New System.Drawing.Size(40, 13)
        Me.llGithub.TabIndex = 10
        Me.llGithub.TabStop = True
        Me.llGithub.Text = "GitHub"
        '
        'llHomepage1
        '
        Me.llHomepage1.AccessibleDescription = "HomepageLink"
        Me.llHomepage1.AccessibleName = "HomepageLink"
        Me.llHomepage1.AutoSize = True
        Me.llHomepage1.LinkColor = System.Drawing.Color.Black
        Me.llHomepage1.Location = New System.Drawing.Point(622, 376)
        Me.llHomepage1.Name = "llHomepage1"
        Me.llHomepage1.Size = New System.Drawing.Size(41, 13)
        Me.llHomepage1.TabIndex = 11
        Me.llHomepage1.TabStop = True
        Me.llHomepage1.Text = "Creator"
        '
        'llRickroll
        '
        Me.llRickroll.AccessibleDescription = "RickRollLink"
        Me.llRickroll.AccessibleName = "RickRollLink"
        Me.llRickroll.AutoSize = True
        Me.llRickroll.LinkColor = System.Drawing.Color.Black
        Me.llRickroll.Location = New System.Drawing.Point(714, 376)
        Me.llRickroll.Name = "llRickroll"
        Me.llRickroll.Size = New System.Drawing.Size(51, 13)
        Me.llRickroll.TabIndex = 12
        Me.llRickroll.TabStop = True
        Me.llRickroll.Text = "Important"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(337, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 246)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 400)
        Me.Controls.Add(Me.llRickroll)
        Me.Controls.Add(Me.llHomepage1)
        Me.Controls.Add(Me.llGithub)
        Me.Controls.Add(Me.pSystempanel1)
        Me.Controls.Add(Me.pUserpanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pUserpanel1.ResumeLayout(False)
        Me.pSystempanel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pUserpanel1 As Panel
    Friend WithEvents pSystempanel1 As Panel
    Friend WithEvents llGithub As LinkLabel
    Friend WithEvents llHomepage1 As LinkLabel
    Friend WithEvents llRickroll As LinkLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents bMathNumber0 As Button
    Friend WithEvents bMathNumber1 As Button
    Friend WithEvents Ergebnisverlauf As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents bMathComma As Button
    Friend WithEvents bMathNumber9 As Button
    Friend WithEvents bMathNumber8 As Button
    Friend WithEvents bMathNumber7 As Button
    Friend WithEvents bMathNumber6 As Button
    Friend WithEvents bMathNumber5 As Button
    Friend WithEvents bMathNumber4 As Button
    Friend WithEvents bMathNumber3 As Button
    Friend WithEvents bMathNumber2 As Button
    Friend WithEvents Button1 As Button
End Class
