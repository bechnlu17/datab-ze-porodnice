Public Class Form2
    Private Sub Dítě__auto_BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Dítě__auto_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Dítě__auto_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Porodnice_databáze0203DataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Tento řádek načte data do tabulky 'Porodnice_databáze0203DataSet._Rodička__porodnice__Majitel__Servis_'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.Rodička__porodnice__Majitel__Servis_TableAdapter.Fill(Me.Porodnice_databáze0203DataSet._Rodička__porodnice__Majitel__Servis_)
        'TODO: Tento řádek načte data do tabulky 'Porodnice_databáze0203DataSet._Porodnice__Servis_'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.Porodnice__Servis_TableAdapter.Fill(Me.Porodnice_databáze0203DataSet._Porodnice__Servis_)
        'TODO: Tento řádek načte data do tabulky 'Porodnice_databáze0203DataSet._Rodička__majitel_'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.Rodička__majitel_TableAdapter.Fill(Me.Porodnice_databáze0203DataSet._Rodička__majitel_)
        'TODO: Tento řádek načte data do tabulky 'Porodnice_databáze0203DataSet._dítě__auto_'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.Dítě__auto_TableAdapter.Fill(Me.Porodnice_databáze0203DataSet._dítě__auto_)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Rodička__porodnice__Majitel__Servis_TableAdapter.Update(Me.Porodnice_databáze0203DataSet._Rodička__porodnice__Majitel__Servis_)
        '(Me.Porodnice_databáze0203DataSet._Rodička__porodnice__Majitel__Servis_)
    End Sub
End Class