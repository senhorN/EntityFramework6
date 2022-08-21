<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbld = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txttelefone = New System.Windows.Forms.TextBox()
        Me.dgvPessoas = New System.Windows.Forms.DataGridView()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        CType(Me.dgvPessoas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbld
        '
        Me.lbld.AutoSize = True
        Me.lbld.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbld.Location = New System.Drawing.Point(61, 44)
        Me.lbld.Name = "lbld"
        Me.lbld.Size = New System.Drawing.Size(26, 20)
        Me.lbld.TabIndex = 0
        Me.lbld.Text = "ID"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(61, 83)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(53, 20)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.Location = New System.Drawing.Point(61, 122)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(73, 20)
        Me.lblTelefone.TabIndex = 2
        Me.lblTelefone.Text = "Telefone"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(140, 44)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(82, 22)
        Me.txtid.TabIndex = 3
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(140, 81)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(312, 22)
        Me.txtnome.TabIndex = 4
        '
        'txttelefone
        '
        Me.txttelefone.Location = New System.Drawing.Point(140, 122)
        Me.txttelefone.Name = "txttelefone"
        Me.txttelefone.Size = New System.Drawing.Size(312, 22)
        Me.txttelefone.TabIndex = 5
        '
        'dgvPessoas
        '
        Me.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPessoas.Location = New System.Drawing.Point(65, 253)
        Me.dgvPessoas.Name = "dgvPessoas"
        Me.dgvPessoas.RowHeadersWidth = 51
        Me.dgvPessoas.RowTemplate.Height = 24
        Me.dgvPessoas.Size = New System.Drawing.Size(666, 185)
        Me.dgvPessoas.TabIndex = 6
        '
        'btnIncluir
        '
        Me.btnIncluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIncluir.Location = New System.Drawing.Point(43, 190)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(116, 45)
        Me.btnIncluir.TabIndex = 7
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExcluir.Location = New System.Drawing.Point(205, 190)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(116, 45)
        Me.btnExcluir.TabIndex = 8
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlterar.Location = New System.Drawing.Point(360, 190)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(116, 45)
        Me.btnAlterar.TabIndex = 9
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSair.Location = New System.Drawing.Point(528, 190)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(116, 45)
        Me.btnSair.TabIndex = 10
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.dgvPessoas)
        Me.Controls.Add(Me.txttelefone)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lbld)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvPessoas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbld As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblTelefone As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txttelefone As TextBox
    Friend WithEvents dgvPessoas As DataGridView
    Friend WithEvents btnIncluir As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnSair As Button
End Class
