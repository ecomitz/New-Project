<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Story
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageText = New System.Windows.Forms.Label()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.OptionA = New System.Windows.Forms.Button()
        Me.OptionB = New System.Windows.Forms.Button()
        Me.OptionC = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._294px_PylonTest2
        Me.PictureBox1.InitialImage = Global.WindowsApplication1.My.Resources.Resources._294px_PylonTest2
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(760, 315)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ImageText
        '
        Me.ImageText.AutoSize = True
        Me.ImageText.Location = New System.Drawing.Point(13, 320)
        Me.ImageText.Name = "ImageText"
        Me.ImageText.Size = New System.Drawing.Size(111, 13)
        Me.ImageText.TabIndex = 1
        Me.ImageText.Text = "Isn't this a nice pylon?"
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(13, 395)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.PreviousButton.TabIndex = 2
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(685, 395)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 3
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'OptionA
        '
        Me.OptionA.Enabled = False
        Me.OptionA.Location = New System.Drawing.Point(201, 395)
        Me.OptionA.Name = "OptionA"
        Me.OptionA.Size = New System.Drawing.Size(75, 23)
        Me.OptionA.TabIndex = 4
        Me.OptionA.Text = "A"
        Me.OptionA.UseVisualStyleBackColor = True
        Me.OptionA.Visible = False
        '
        'OptionB
        '
        Me.OptionB.Enabled = False
        Me.OptionB.Location = New System.Drawing.Point(283, 395)
        Me.OptionB.Name = "OptionB"
        Me.OptionB.Size = New System.Drawing.Size(75, 23)
        Me.OptionB.TabIndex = 5
        Me.OptionB.Text = "B"
        Me.OptionB.UseVisualStyleBackColor = True
        Me.OptionB.Visible = False
        '
        'OptionC
        '
        Me.OptionC.Enabled = False
        Me.OptionC.Location = New System.Drawing.Point(365, 395)
        Me.OptionC.Name = "OptionC"
        Me.OptionC.Size = New System.Drawing.Size(75, 23)
        Me.OptionC.TabIndex = 6
        Me.OptionC.Text = "C"
        Me.OptionC.UseVisualStyleBackColor = True
        Me.OptionC.Visible = False
        '
        'Story
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 430)
        Me.Controls.Add(Me.OptionC)
        Me.Controls.Add(Me.OptionB)
        Me.Controls.Add(Me.OptionA)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.ImageText)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Story"
        Me.Text = "Story"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImageText As Label
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents OptionA As Button
    Friend WithEvents OptionB As Button
    Friend WithEvents OptionC As Button
End Class
