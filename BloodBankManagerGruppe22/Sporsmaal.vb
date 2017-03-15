Public Class Sporsmaal

    Private spmtext As String
    Private spmnr As String
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
        Return spmtext
    End Function

    Public Function getNr() As String
        Return spmnr
    End Function

    Public Sub New(ByVal text As String, ByVal nr As String)
        spmtext = text
        spmnr = nr
    End Sub



End Class
