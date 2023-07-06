<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.rtbAnswer = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(382, 13)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(113, 102)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtQuestion
        '
        Me.txtQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.Location = New System.Drawing.Point(13, 13)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(363, 102)
        Me.txtQuestion.TabIndex = 2
        '
        'rtbAnswer
        '
        Me.rtbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbAnswer.Location = New System.Drawing.Point(13, 121)
        Me.rtbAnswer.Name = "rtbAnswer"
        Me.rtbAnswer.Size = New System.Drawing.Size(482, 306)
        Me.rtbAnswer.TabIndex = 3
        Me.rtbAnswer.Text = ""
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 437)
        Me.Controls.Add(Me.rtbAnswer)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.btnSend)
        Me.Name = "mainform"
        Me.Text = "ChatBot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSend As Button
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents rtbAnswer As RichTextBox
End Class
