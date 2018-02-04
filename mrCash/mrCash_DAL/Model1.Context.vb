﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class MRCashEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New(Variabili.ContextConnectionString)
        'MyBase.New
        'MyBase.Database.Connection.ConnectionString = Variabili.ExcelConnectionString
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Acquisti() As DbSet(Of Acquisti)
    Public Overridable Property Fornitori() As DbSet(Of Fornitori)
    Public Overridable Property Oggetti() As DbSet(Of Oggetti)
    Public Overridable Property Vendite() As DbSet(Of Vendite)
    Public Overridable Property V_AcquistiGiornalieri() As DbSet(Of V_AcquistiGiornalieri)
    Public Overridable Property V_Giornalieri() As DbSet(Of V_Giornalieri)

    Public Overridable Function Totali_Giornalieri() As ObjectResult(Of Oggetti)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Oggetti)("Totali_Giornalieri")
    End Function

    Public Overridable Function Totali_Giornalieri(mergeOption As MergeOption) As ObjectResult(Of Oggetti)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Oggetti)("Totali_Giornalieri", mergeOption)
    End Function

End Class
