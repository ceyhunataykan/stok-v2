'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Fis
    Public Property Fis_ID As Integer
    Public Property Fis_No As Nullable(Of Integer)
    Public Property Fis_Tarih As Nullable(Of Date)
    Public Property Fis_Türü As String
    Public Property Stok_Urun_ID As String
    Public Property Stok_Kodu As String
    Public Property Stok_Adi As String
    Public Property Stok_Miktar As String
    Public Property Birim As String
    Public Property Birim_Fiyat As String
    Public Property Tutar As String
    Public Property Depo_ID As Nullable(Of Integer)
    Public Property Bolum_ID As Nullable(Of Integer)
    Public Property Aciklama As String

    Public Overridable Property Bolum As Bolum
    Public Overridable Property Depo As Depo

End Class
