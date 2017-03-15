Public Class Sporsmaal

    Private spmtext As String
    Private spmnr As String
    Private svar As Boolean

    Public Function getSvar() As Boolean
        Return svar
    End Function

    Public Sub New(ByVal text As String)
        spmtext = text
    End Sub

    Public Sub New(ByVal nr As Double)
        nr = spmnr
    End Sub


End Class
