<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuiz
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmdSair = New System.Windows.Forms.Button()
        Me.CmdJogar = New System.Windows.Forms.Button()
        Me.CmdRegras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmdSair
        '
        Me.CmdSair.Location = New System.Drawing.Point(722, 462)
        Me.CmdSair.Name = "CmdSair"
        Me.CmdSair.Size = New System.Drawing.Size(75, 23)
        Me.CmdSair.TabIndex = 0
        Me.CmdSair.Text = "Sair"
        Me.CmdSair.UseVisualStyleBackColor = True
        '
        'CmdJogar
        '
        Me.CmdJogar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdJogar.Location = New System.Drawing.Point(12, 325)
        Me.CmdJogar.Name = "CmdJogar"
        Me.CmdJogar.Size = New System.Drawing.Size(120, 59)
        Me.CmdJogar.TabIndex = 1
        Me.CmdJogar.Text = "Jogar"
        Me.CmdJogar.UseVisualStyleBackColor = True
        '
        'CmdRegras
        '
        Me.CmdRegras.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdRegras.Location = New System.Drawing.Point(12, 426)
        Me.CmdRegras.Name = "CmdRegras"
        Me.CmdRegras.Size = New System.Drawing.Size(120, 59)
        Me.CmdRegras.TabIndex = 2
        Me.CmdRegras.Text = "Regras"
        Me.CmdRegras.UseVisualStyleBackColor = True
        '
        'FrmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 497)
        Me.Controls.Add(Me.CmdRegras)
        Me.Controls.Add(Me.CmdJogar)
        Me.Controls.Add(Me.CmdSair)
        Me.Name = "FrmQuiz"
        Me.Text = "Quiz"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmdSair As Button
    Friend WithEvents CmdJogar As Button
    Friend WithEvents CmdRegras As Button
End Class
