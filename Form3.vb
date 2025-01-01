Public Class Form3
    Private Sub Dítě__auto_BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Dítě__auto_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Dítě__auto_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Porodnice_databáze0203DataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Tento řádek načte data do tabulky 'Porodnice_databáze0203DataSet._dítě__Rodička__auto__Majitel_'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.Dítě__Rodička__auto__Majitel_TableAdapter.Fill(Me.Porodnice_databáze0203DataSet._dítě__Rodička__auto__Majitel_)
        'TODO: Tento řádek načte data do tabulky 'Porodnice_databáze0203DataSet._Rodička__majitel_'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.Rodička__majitel_TableAdapter.Fill(Me.Porodnice_databáze0203DataSet._Rodička__majitel_)
        'TODO: Tento řádek načte data do tabulky 'Porodnice_databáze0203DataSet._dítě__auto_'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.Dítě__auto_TableAdapter.Fill(Me.Porodnice_databáze0203DataSet._dítě__auto_)

    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        Dim rodickaId As Integer = ComboBox11.Text
        Dim diteId As Integer = ComboBox21.Text


        Me.Dítě__Rodička__auto__Majitel_TableAdapter.Insert(rodickaId, diteId)


        Me.Dítě__Rodička__auto__Majitel_TableAdapter.Fill(Me.Porodnice_databáze0203DataSet._dítě__Rodička__auto__Majitel_)
    End Sub
End Class