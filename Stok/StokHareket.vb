﻿Imports System.Data.Entity.Core.Objects
Imports System.Data.Entity.SqlServer

Public Class StokHareket
    Dim db As StokEntities = New StokEntities()

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        StokGiris.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        StokCikis.ShowDialog()
    End Sub

    Private Sub StokHareket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepo.DisplayMember = "Depo_Adi"
        cmbDepo.ValueMember = "Depo_ID"
        cmbDepo.DataSource = db.Depo.ToList()
        cmbDepo.SelectedIndex = -1
        cmbDepo.SelectedText = "Seçiniz"

        cmbBolum.DisplayMember = "Bolum_Adi"
        cmbBolum.ValueMember = "Bolum_ID"
        cmbBolum.DataSource = db.Bolum.ToList()
        cmbBolum.SelectedIndex = -1
        cmbBolum.SelectedText = "Seçiniz"

        listele()
    End Sub

    Private Sub listele()
        Dim fisListe = (From f In db.Fis
                        Select
                            fisID = f.Fis_ID,
                            fisNo = f.Fis_No,
                            fisTur = f.Fis_Türü,
                            fisTarih = f.Fis_Tarih,
                            fisDepo = f.Depo.Depo_Adi,
                            fisBolum = f.Bolum.Bolum_Adi).ToList()
        dgFisListe.DataSource = fisListe
        dgFisListe.Columns("fisID").Visible = False
        dgFisListe.Columns("fisNo").HeaderText = "Fiş No"
        dgFisListe.Columns("fisTur").HeaderText = "Fiş Türü"
        dgFisListe.Columns("fisTarih").HeaderText = "Tarih"
        dgFisListe.Columns("fisDepo").HeaderText = "Depo"
        dgFisListe.Columns("fisBolum").HeaderText = "Bölüm"
    End Sub

    Private Sub btnDuzenle_Click(sender As Object, e As EventArgs) Handles btnDuzenle.Click
        If dgFisListe.SelectedRows.Count = 0 Then
            MsgBox("Düzenlemek için bir kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        Dim fID As Integer = Convert.ToInt32(dgFisListe.CurrentRow.Cells("fisID").Value)
        Dim fisSec = (From f In db.Fis
                      Where f.Fis_ID = fID
                      Select
                          fisID = f.Fis_ID,
                          fisNo = f.Fis_No,
                          fisTarih = f.Fis_Tarih,
                          fisDepo = f.Depo_ID,
                          fisBolum = f.Bolum_ID,
                          fisAciklama = f.Aciklama).FirstOrDefault()
        Dim fisDetay = (From f In db.Fis_Detay
                        Where f.Fis_ID = fID
                        Select
                            detayID = f.Detay_ID,
                            fisID = f.Fis_ID,
                            urunID = f.Urun.Urun_ID,
                            stokKodu = f.Urun.Stok_Kodu,
                            stokAdi = f.Urun.Stok_Adi,
                            stokMiktar = f.Miktar,
                            stokFiyat = f.Fiyat,
                            stokTutar = f.Tutar).ToList()

        If dgFisListe.CurrentRow.Cells("fisTur").Value = "Stok Giriş" Then
            StokGirisDuzenle.Show()
            StokGirisDuzenle.dgFisListe.DataSource = fisDetay
            StokGirisDuzenle.dgFisListe.Columns("detayID").Visible = False
            StokGirisDuzenle.dgFisListe.Columns("urunID").Visible = False
            StokGirisDuzenle.dgFisListe.Columns("fisID").Visible = False
            StokGirisDuzenle.dgFisListe.Columns("stokKodu").HeaderText = "Stok Kodu"
            StokGirisDuzenle.dgFisListe.Columns("stokAdi").HeaderText = "Stok Adı"
            StokGirisDuzenle.dgFisListe.Columns("stokMiktar").HeaderText = "Miktar"
            StokGirisDuzenle.dgFisListe.Columns("stokFiyat").HeaderText = "Fiyat"
            StokGirisDuzenle.dgFisListe.Columns("stokTutar").HeaderText = "Tutar"

            StokGirisDuzenle.txtFisNo.Text = fisSec.fisNo
            StokGirisDuzenle.lblFisId.Text = fisSec.fisID
            StokGirisDuzenle.txtAciklama.Text = fisSec.fisAciklama
            StokGirisDuzenle.cmbDepo.SelectedValue = fisSec.fisDepo
            StokGirisDuzenle.cmbBolum.SelectedValue = fisSec.fisBolum

            Dim toplamMiktar = db.Fis_Detay.Where(Function(m) m.Fis_ID = fisSec.fisID).Sum(Function(m) m.Miktar)
            Dim toplamTutar = db.Fis_Detay.Where(Function(t) t.Fis_ID = fisSec.fisID).Sum(Function(t) t.Tutar)
            StokGirisDuzenle.txtTopBirim.Text = toplamMiktar.ToString()
            StokGirisDuzenle.txtTopTutar.Text = toplamTutar.ToString()

        ElseIf dgFisListe.CurrentRow.Cells("fisTur").Value = "Stok Çıkış" Then
            StokCikisDuzenle.Show()

            StokCikisDuzenle.dgFisListe.DataSource = fisDetay
            StokCikisDuzenle.dgFisListe.Columns("detayID").Visible = False
            StokCikisDuzenle.dgFisListe.Columns("urunID").Visible = False
            StokCikisDuzenle.dgFisListe.Columns("fisID").Visible = False
            StokCikisDuzenle.dgFisListe.Columns("stokKodu").HeaderText = "Stok Kodu"
            StokCikisDuzenle.dgFisListe.Columns("stokAdi").HeaderText = "Stok Adı"
            StokCikisDuzenle.dgFisListe.Columns("stokMiktar").HeaderText = "Miktar"
            StokCikisDuzenle.dgFisListe.Columns("stokFiyat").HeaderText = "Fiyat"
            StokCikisDuzenle.dgFisListe.Columns("stokTutar").HeaderText = "Tutar"

            StokCikisDuzenle.txtFisNo.Text = fisSec.fisNo
            StokCikisDuzenle.lblFisId.Text = fisSec.fisID
            StokCikisDuzenle.txtAciklama.Text = fisSec.fisAciklama
            StokCikisDuzenle.cmbDepo.SelectedValue = fisSec.fisDepo
            StokCikisDuzenle.cmbBolum.SelectedValue = fisSec.fisBolum

            Dim toplamMiktar = db.Fis_Detay.Where(Function(m) m.Fis_ID = fisSec.fisID).Sum(Function(m) m.Miktar)
            Dim toplamTutar = db.Fis_Detay.Where(Function(t) t.Fis_ID = fisSec.fisID).Sum(Function(t) t.Tutar)
            StokCikisDuzenle.txtTopBirim.Text = toplamMiktar.ToString()
            StokCikisDuzenle.txtTopTutar.Text = toplamTutar.ToString()
        End If
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If lblId.Text = "" Then
            MsgBox("Silme işlemi yapabilmek için kayıt seçiniz", MsgBoxStyle.Exclamation, "Uyarı")
            Return
        End If
        If MsgBox("Kaydı silmek istiyor musunuz?", MsgBoxStyle.YesNo, "Uyarı") = MsgBoxResult.No Then
            Return
        End If
        Try
            If dgFisListe.Rows.Count > 0 Then
                Dim fID As Integer = Convert.ToInt32(dgFisListe.CurrentRow.Cells("fisID").Value)
                db.Fis_Detay.RemoveRange(db.Fis_Detay.Where(Function(f) f.Fis_ID = fID))
                db.SaveChanges()

                Dim silFis = db.Fis.Where(Function(f) f.Fis_ID = fID).FirstOrDefault()
                db.Fis.Remove(silFis)
                db.SaveChanges()
            End If
        Catch

        End Try
        listele()
    End Sub

    Private Sub cmbDepo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepo.SelectedIndexChanged
        Dim id As Integer = Convert.ToInt32(cmbDepo.SelectedValue)
        Dim fisListe = (From f In db.Fis
                        Where f.Depo_ID = id
                        Select
                            fisID = f.Fis_ID,
                            fisNo = f.Fis_No,
                            fisTur = f.Fis_Türü,
                            fisTarih = f.Fis_Tarih,
                            fisDepo = f.Depo.Depo_Adi,
                            fisBolum = f.Bolum.Bolum_Adi).ToList()
        dgFisListe.DataSource = fisListe
        dgFisListe.Columns("fisID").Visible = False
        dgFisListe.Columns("fisNo").HeaderText = "Fiş No"
        dgFisListe.Columns("fisTur").HeaderText = "Fiş Türü"
        dgFisListe.Columns("fisTarih").HeaderText = "Tarih"
        dgFisListe.Columns("fisDepo").HeaderText = "Depo"
        dgFisListe.Columns("fisBolum").HeaderText = "Bölüm"
    End Sub
    Private Sub cmbBolum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBolum.SelectedIndexChanged
        Dim id As Integer = Convert.ToInt32(cmbBolum.SelectedValue)
        Dim fisListe = (From f In db.Fis
                        Where f.Bolum_ID = id
                        Select
                            fisID = f.Fis_ID,
                            fisNo = f.Fis_No,
                            fisTur = f.Fis_Türü,
                            fisTarih = f.Fis_Tarih,
                            fisDepo = f.Depo.Depo_Adi,
                            fisBolum = f.Bolum.Bolum_Adi).ToList()
        dgFisListe.DataSource = fisListe
        dgFisListe.Columns("fisID").Visible = False
        dgFisListe.Columns("fisNo").HeaderText = "Fiş No"
        dgFisListe.Columns("fisTur").HeaderText = "Fiş Türü"
        dgFisListe.Columns("fisTarih").HeaderText = "Tarih"
        dgFisListe.Columns("fisDepo").HeaderText = "Depo"
        dgFisListe.Columns("fisBolum").HeaderText = "Bölüm"
    End Sub
    Private Sub btnTum_Click(sender As Object, e As EventArgs) Handles btnTum.Click
        listele()
    End Sub
    Private Sub txtAra_TextChanged(sender As Object, e As EventArgs) Handles txtAra.TextChanged
        Try
            Dim kod As Integer = Convert.ToInt32(txtAra.Text)
            Dim fisListe = (From f In db.Fis
                            Where SqlFunctions.StringConvert(f.Fis_No).Contains(kod.ToString())
                            Select
                                fisID = f.Fis_ID,
                                fisNo = f.Fis_No,
                                fisTur = f.Fis_Türü,
                                fisTarih = f.Fis_Tarih,
                                fisDepo = f.Depo.Depo_Adi,
                                fisBolum = f.Bolum.Bolum_Adi).ToList()
            dgFisListe.DataSource = fisListe
            dgFisListe.Columns("fisID").Visible = False
            dgFisListe.Columns("fisNo").HeaderText = "Fiş No"
            dgFisListe.Columns("fisTur").HeaderText = "Fiş Türü"
            dgFisListe.Columns("fisTarih").HeaderText = "Tarih"
            dgFisListe.Columns("fisDepo").HeaderText = "Depo"
            dgFisListe.Columns("fisBolum").HeaderText = "Bölüm"
        Catch
            listele()
        End Try
    End Sub

    Private Sub dtpTarih_ValueChanged(sender As Object, e As EventArgs) Handles dtpTarih.ValueChanged
        Dim dt As DateTime = Convert.ToDateTime(dtpTarih.Value)
        Dim fisListe = (From f In db.Fis
                        Where EntityFunctions.TruncateTime(f.Fis_Tarih) = dt.Date
                        Select
                            fisID = f.Fis_ID,
                            fisNo = f.Fis_No,
                            fisTur = f.Fis_Türü,
                            fisTarih = f.Fis_Tarih,
                            fisDepo = f.Depo.Depo_Adi,
                            fisBolum = f.Bolum.Bolum_Adi).ToList()
        dgFisListe.DataSource = fisListe
        dgFisListe.Columns("fisID").Visible = False
        dgFisListe.Columns("fisNo").HeaderText = "Fiş No"
        dgFisListe.Columns("fisTur").HeaderText = "Fiş Türü"
        dgFisListe.Columns("fisTarih").HeaderText = "Tarih"
        dgFisListe.Columns("fisDepo").HeaderText = "Depo"
        dgFisListe.Columns("fisBolum").HeaderText = "Bölüm"
    End Sub

    Private Sub txtAra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAra.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgFisListe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFisListe.CellClick
        lblId.Text = dgFisListe.CurrentRow.Cells("fisID").Value
    End Sub

    Private Sub StokHareket_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class