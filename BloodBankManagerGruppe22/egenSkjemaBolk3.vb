﻿Public Class egenSkjemaBolk3
    'Bolk 3: Har du i løpet av de siste seks måneder
    'Public legeUndersøkelseEllerBehandlingForSykdom As Boolean = CheckBox1.Text
    'Public behandlingMedSprøyter As Boolean = CheckBox2.Text
    'Public kjønnsykdomEllerfåttBehandlingForKjønnsykdom As Boolean = CheckBox3.Text
    'Public kjønnsykdomSeksuellKontaktHivHepatittBEllerC = CheckBox4.Text
    'Public kjønnsykdomSeksuellKontaktDopingmidlerNarkotiskemidler As Boolean = CheckBox5.Text
    'Public hattSeksuellKontaktMedProstituerteEllerTidligereProstituerte As Boolean = CheckBox10.Text
    'Public tattHullIØretFåttPiercing As Boolean = CheckBox9.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim spm12 As New Sporsmaal("vært til legeundersøkelse eller på sykehus, eller fått behandling for noen sykdom?", "3_1")
        Dim spm13 As New Sporsmaal("fått behandling med sprøyter? ", "3_2")
        Dim spm14 As New Sporsmaal("hatt kjønnssykdom, eller fått behandling for kjønnssykdom?", "3_3")
        Dim spm15 As New Sporsmaal("hatt seksuell kontakt med person med HIV-infeksjon eller hepatitt B eller hepatitt C, eller med person som har hatt positiv test for en av disse sykdommene?", "3_4")
        Dim spm16 As New Sporsmaal("hatt seksuell kontakt med person som bruker eller har brukt dopingmidler eller narkotiske midler som sprøyter eller ved sniffing?", "3_5")
        Dim spm17 As New Sporsmaal("hatt seksuell kontakt med prostituerte eller tidligere prostituerte?", "3_6")
        Dim spm18 As New Sporsmaal("blitt tatovert, fått piercing eller tatt hull i ørene? ", "3_7")


        Me.Close()
        egenSkjemaBolk4.Show()
    End Sub
End Class