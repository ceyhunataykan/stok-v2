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

Partial Public Class Kategori
    Public Property Kategori_ID As Integer
    Public Property Kategori_Kodu As String
    Public Property Kategori_Adi As String

    Public Overridable Property Urun As ICollection(Of Urun) = New HashSet(Of Urun)

End Class
