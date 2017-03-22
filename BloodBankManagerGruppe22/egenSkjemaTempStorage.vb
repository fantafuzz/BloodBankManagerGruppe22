Public Class egenSkjemaTempStorage
    Public svar(60) As Boolean
    Private Sub egenSkjemaTempStorage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each s In svar
            ListBox1.Items.Add(s)
        Next
    End Sub
End Class