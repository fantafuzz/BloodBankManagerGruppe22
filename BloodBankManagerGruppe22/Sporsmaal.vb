Public Class Sporsmaal
    Private spmText As String
    Private spmNr As String
    Private spmIndex As Integer
    Private svar As Boolean
    Private evt As String

    Public Function getSvar() As Boolean
        Return svar
    End Function
    Public Sub setSvar(ByVal sv As Boolean)
        svar = sv
    End Sub

    Public Function getEvt() As String
        Return evt
    End Function

    Public Function getText() As String
        Return spmText
    End Function

    Public Function getNr() As String
        Return spmNr
    End Function
    Public Sub New(ByVal text As String, ByVal nr As String)
        spmText = text
        spmNr = nr
    End Sub
End Class
