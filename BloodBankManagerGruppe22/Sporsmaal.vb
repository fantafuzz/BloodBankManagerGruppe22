Public Class Sporsmaal

    Private spmtext As String
    Private spmnr As String
    Private svar As Boolean

    Public Function getSvar() As Boolean
        Return svar
    End Function
    Public Sub setSvar(ByVal sv As Boolean)
        svar = sv
    End Sub

    Public Sub New(ByVal text As String, ByVal nr As String)
        spmtext = text
        spmnr = nr
    End Sub



End Class
