Public Class Form1

    'Para exibir as informações no DataGridView vamos usar e evento Load que ocorre quando o formulário form1.vb é carregado e incluir nele o código abaixo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregaGrid()
    End Sub

    'O código esta criando uma nova instância do nosso contexto usando a cláusula Using
    Private Sub CarregaGrid()
        Using db = New Fundamentos
            Dim _pessoas = From p In db.Pessoas Order By p.Nome Ascending
                           Select p
            dgvPessoas.DataSource = _pessoas.ToList()
            formataGridPessoas()
        End Using
    End Sub

    'A seguir atribuímos o resultado da consulta ao controle DataGridView e chamamos a rotina para formatar o controle
    Private Sub formataGridPessoas()
        With dgvPessoas
            'não gera as colunas de forma automática
            .AutoGenerateColumns = False
            .RowHeadersVisible = False
            'não exibe o nome dos cabeçalhos e define a borda como simples
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            'altera a cor das linhas alternadas no grid
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.YellowGreen
            'altera o nome das colunas
            .Columns(0).HeaderText = "Id"
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "Telefone"
            'largura colunas
            .Columns(0).Width = 60
            .Columns(1).Width = 160
            .Columns(2).Width = 160
            'seleciona a linha inteira
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            'não permite seleção de multiplas linhas
            .MultiSelect = False
            ' exibe nulos formatados
            .DefaultCellStyle.NullValue = " - "
            'permite que o texto maior que célula não seja truncado
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    'No evento Click do botão - Incluir - temos o código que permite incluir informações de nome e telefone das caixas de texto no
    'modelo de entidades usando o método Add e em seguida persistir essas informações no banco de dados usando o método SaveChanges()
    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        Dim pessoa As New Pessoa
        If String.IsNullOrEmpty(txtnome.Text) Or String.IsNullOrEmpty(txttelefone.Text) Then
            MessageBox.Show("Informe o nome e o telefone")
            txtnome.Focus()
            Return
        Else
            pessoa.Nome = txtnome.Text
            pessoa.Telefone = txttelefone.Text
        End If
        Try
            Using db = New Fundamentos
                db.Pessoas.Add(pessoa)
                db.SaveChanges()
                MessageBox.Show("Dados incluídos.")
            End Using
            CarregaGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'vento Click do botão - Excluir - temos o código que permite excluir informações de uma pessoa.
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim codigo As Integer
        If String.IsNullOrEmpty(txtid.Text) Then
            MessageBox.Show("Informe código")
            txtid.Focus()
            Return
        Else
            codigo = Convert.ToInt32(txtid.Text)
        End If
        Try
            Using db = New Fundamentos
                Dim pessoa = (From p In db.Pessoas Where p.Id = codigo).SingleOrDefault
                db.Pessoas.Remove(pessoa)
                db.SaveChanges()
                MessageBox.Show("Dados excluídos.")
            End Using
            CarregaGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'o código que permite excluir informações do modelo de entidades.


    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim codigo As Integer
        If String.IsNullOrEmpty(txtid.Text) Then
            MessageBox.Show("Informe código")
            txtid.Focus()
            Return
        Else
            codigo = Convert.ToInt32(txtid.Text)
        End If
        If String.IsNullOrEmpty(txtnome.Text) Then
            MessageBox.Show("Informe o nome", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Try
            Using ctx As New Fundamentos
                Dim pessoa = (From p In ctx.Pessoas Where p.Id = codigo).SingleOrDefault
                If IsNothing(pessoa) Then
                    MessageBox.Show("Pessoa não localizada", "Localizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
                pessoa.Nome = txtnome.Text
                pessoa.Telefone = txttelefone.Text
                ctx.SaveChanges()
                MessageBox.Show("Dados alterados.")
            End Using
            CarregaGrid()
        Catch ex As Exception
            MessageBox.Show("Erro " + ex.Message, "Erro::Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click



    End Sub
End Class
