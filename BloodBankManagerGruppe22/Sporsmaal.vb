Public Class Sporsmaal
    Private spmText As String
    Private spmNr As String
    Private spmIndex As Integer
    Private svar As Boolean
    Private evt As String
    Private labelSpmText As New Label
    Private panelWithRadio As New Panel
    Private radioYes As New RadioButton
    Private RadioNo As New RadioButton
    Private controls As List(Of Control) = New List(Of Control)

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


    Public Sub New(ByVal text As String, ByVal nr As String, ByVal index As Integer, ByVal startpoint As Point)
        spmText = text
        spmNr = nr
        spmIndex = index

        labelSpmText.Name = "LabelNewSpm" & index
        labelSpmText.Text = spmText
        labelSpmText.Size = New Size(642, 25)
        labelSpmText.Location = New Point(startpoint.X, (startpoint.Y + (labelSpmText.Size.Height * index)))
        labelSpmText.Tag = index
        Select Case labelSpmText.Tag Mod 2
            Case 1
                labelSpmText.BackColor = Color.WhiteSmoke
                panelWithRadio.BackColor = Color.WhiteSmoke
            Case 0
                labelSpmText.BackColor = Color.White
                panelWithRadio.BackColor = Color.White
        End Select
        If (controls Is Nothing) = True Then controls = New List(Of Control)
        controls.Add(labelSpmText)


    End Sub



End Class
