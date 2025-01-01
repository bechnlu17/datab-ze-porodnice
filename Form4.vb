Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Tento řádek načte data do tabulky 'Porodnice_databáze0203DataSet.DataTable1'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.DataTable1TableAdapter.Fill(Me.Porodnice_databáze0203DataSet.DataTable1)

    End Sub
End Class