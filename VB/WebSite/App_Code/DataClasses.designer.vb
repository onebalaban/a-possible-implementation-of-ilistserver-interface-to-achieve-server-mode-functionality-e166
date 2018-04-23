﻿'#pragma warning disable 1591
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection



<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="AdventureWorks")> _
Partial Public Class DataClassesDataContext
    Inherits System.Data.Linq.DataContext

    Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()

  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertContact(ByVal instance As Contact)
  End Sub
  Partial Private Sub UpdateContact(ByVal instance As Contact)
  End Sub
  Partial Private Sub DeleteContact(ByVal instance As Contact)
  End Sub
  #End Region

    Public Sub New()
        MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("AdventureWorksConnectionString").ConnectionString, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As String)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As System.Data.IDbConnection)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public ReadOnly Property Contacts() As System.Data.Linq.Table(Of Contact)
        Get
            Return Me.GetTable(Of Contact)()
        End Get
    End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="Person.Contact")> _
Partial Public Class Contact
    Implements INotifyPropertyChanging, INotifyPropertyChanged

    Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

    Private _ContactID As Integer

    Private _NameStyle As Boolean

    Private _Title As String

    Private _FirstName As String

    Private _MiddleName As String

    Private _LastName As String

    Private _Suffix As String

    Private _EmailAddress As String

    Private _EmailPromotion As Integer

    Private _Phone As String

    Private _PasswordHash As String

    Private _PasswordSalt As String

    Private _AdditionalContactInfo As System.Xml.Linq.XElement

    Private _rowguid As System.Guid

    Private _ModifiedDate As Date

    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnContactIDChanging(ByVal value As Integer)
    End Sub
    Partial Private Sub OnContactIDChanged()
    End Sub
    Partial Private Sub OnNameStyleChanging(ByVal value As Boolean)
    End Sub
    Partial Private Sub OnNameStyleChanged()
    End Sub
    Partial Private Sub OnTitleChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnTitleChanged()
    End Sub
    Partial Private Sub OnFirstNameChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnFirstNameChanged()
    End Sub
    Partial Private Sub OnMiddleNameChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnMiddleNameChanged()
    End Sub
    Partial Private Sub OnLastNameChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnLastNameChanged()
    End Sub
    Partial Private Sub OnSuffixChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnSuffixChanged()
    End Sub
    Partial Private Sub OnEmailAddressChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnEmailAddressChanged()
    End Sub
    Partial Private Sub OnEmailPromotionChanging(ByVal value As Integer)
    End Sub
    Partial Private Sub OnEmailPromotionChanged()
    End Sub
    Partial Private Sub OnPhoneChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnPhoneChanged()
    End Sub
    Partial Private Sub OnPasswordHashChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnPasswordHashChanged()
    End Sub
    Partial Private Sub OnPasswordSaltChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnPasswordSaltChanged()
    End Sub
    Partial Private Sub OnAdditionalContactInfoChanging(ByVal value As System.Xml.Linq.XElement)
    End Sub
    Partial Private Sub OnAdditionalContactInfoChanged()
    End Sub
    Partial Private Sub OnrowguidChanging(ByVal value As System.Guid)
    End Sub
    Partial Private Sub OnrowguidChanged()
    End Sub
    Partial Private Sub OnModifiedDateChanging(ByVal value As Date)
    End Sub
    Partial Private Sub OnModifiedDateChanged()
    End Sub
    #End Region

    Public Sub New()
        OnCreated()
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)> _
    Public Property ContactID() As Integer
        Get
            Return Me._ContactID
        End Get
        Set(ByVal value As Integer)
            If (Me._ContactID <> value) Then
                Me.OnContactIDChanging(value)
                Me.SendPropertyChanging()
                Me._ContactID = value
                Me.SendPropertyChanged("ContactID")
                Me.OnContactIDChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NameStyle", DbType:="Bit NOT NULL")> _
    Public Property NameStyle() As Boolean
        Get
            Return Me._NameStyle
        End Get
        Set(ByVal value As Boolean)
            If (Me._NameStyle <> value) Then
                Me.OnNameStyleChanging(value)
                Me.SendPropertyChanging()
                Me._NameStyle = value
                Me.SendPropertyChanged("NameStyle")
                Me.OnNameStyleChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Title", DbType:="NVarChar(8)")> _
    Public Property Title() As String
        Get
            Return Me._Title
        End Get
        Set(ByVal value As String)
            If (Me._Title <> value) Then
                Me.OnTitleChanging(value)
                Me.SendPropertyChanging()
                Me._Title = value
                Me.SendPropertyChanged("Title")
                Me.OnTitleChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FirstName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=False)> _
    Public Property FirstName() As String
        Get
            Return Me._FirstName
        End Get
        Set(ByVal value As String)
            If (Me._FirstName <> value) Then
                Me.OnFirstNameChanging(value)
                Me.SendPropertyChanging()
                Me._FirstName = value
                Me.SendPropertyChanged("FirstName")
                Me.OnFirstNameChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MiddleName", DbType:="NVarChar(50)")> _
    Public Property MiddleName() As String
        Get
            Return Me._MiddleName
        End Get
        Set(ByVal value As String)
            If (Me._MiddleName <> value) Then
                Me.OnMiddleNameChanging(value)
                Me.SendPropertyChanging()
                Me._MiddleName = value
                Me.SendPropertyChanged("MiddleName")
                Me.OnMiddleNameChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastName", DbType:="NVarChar(50) NOT NULL", CanBeNull:=False)> _
    Public Property LastName() As String
        Get
            Return Me._LastName
        End Get
        Set(ByVal value As String)
            If (Me._LastName <> value) Then
                Me.OnLastNameChanging(value)
                Me.SendPropertyChanging()
                Me._LastName = value
                Me.SendPropertyChanged("LastName")
                Me.OnLastNameChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Suffix", DbType:="NVarChar(10)")> _
    Public Property Suffix() As String
        Get
            Return Me._Suffix
        End Get
        Set(ByVal value As String)
            If (Me._Suffix <> value) Then
                Me.OnSuffixChanging(value)
                Me.SendPropertyChanging()
                Me._Suffix = value
                Me.SendPropertyChanged("Suffix")
                Me.OnSuffixChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmailAddress", DbType:="NVarChar(50)")> _
    Public Property EmailAddress() As String
        Get
            Return Me._EmailAddress
        End Get
        Set(ByVal value As String)
            If (Me._EmailAddress <> value) Then
                Me.OnEmailAddressChanging(value)
                Me.SendPropertyChanging()
                Me._EmailAddress = value
                Me.SendPropertyChanged("EmailAddress")
                Me.OnEmailAddressChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmailPromotion", DbType:="Int NOT NULL")> _
    Public Property EmailPromotion() As Integer
        Get
            Return Me._EmailPromotion
        End Get
        Set(ByVal value As Integer)
            If (Me._EmailPromotion <> value) Then
                Me.OnEmailPromotionChanging(value)
                Me.SendPropertyChanging()
                Me._EmailPromotion = value
                Me.SendPropertyChanged("EmailPromotion")
                Me.OnEmailPromotionChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Phone", DbType:="NVarChar(25)")> _
    Public Property Phone() As String
        Get
            Return Me._Phone
        End Get
        Set(ByVal value As String)
            If (Me._Phone <> value) Then
                Me.OnPhoneChanging(value)
                Me.SendPropertyChanging()
                Me._Phone = value
                Me.SendPropertyChanged("Phone")
                Me.OnPhoneChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PasswordHash", DbType:="VarChar(40) NOT NULL", CanBeNull:=False)> _
    Private Property PasswordHash() As String
        Get
            Return Me._PasswordHash
        End Get
        Set(ByVal value As String)
            If (Me._PasswordHash <> value) Then
                Me.OnPasswordHashChanging(value)
                Me.SendPropertyChanging()
                Me._PasswordHash = value
                Me.SendPropertyChanged("PasswordHash")
                Me.OnPasswordHashChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PasswordSalt", DbType:="VarChar(10) NOT NULL", CanBeNull:=False)> _
    Private Property PasswordSalt() As String
        Get
            Return Me._PasswordSalt
        End Get
        Set(ByVal value As String)
            If (Me._PasswordSalt <> value) Then
                Me.OnPasswordSaltChanging(value)
                Me.SendPropertyChanging()
                Me._PasswordSalt = value
                Me.SendPropertyChanged("PasswordSalt")
                Me.OnPasswordSaltChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AdditionalContactInfo", DbType:="Xml", UpdateCheck:=UpdateCheck.Never)> _
    Private Property AdditionalContactInfo() As System.Xml.Linq.XElement
        Get
            Return Me._AdditionalContactInfo
        End Get
        Set(ByVal value As System.Xml.Linq.XElement)
            If (Not Me._AdditionalContactInfo.Equals(value)) Then
                Me.OnAdditionalContactInfoChanging(value)
                Me.SendPropertyChanging()
                Me._AdditionalContactInfo = value
                Me.SendPropertyChanged("AdditionalContactInfo")
                Me.OnAdditionalContactInfoChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_rowguid", DbType:="UniqueIdentifier NOT NULL")> _
    Private Property rowguid() As System.Guid
        Get
            Return Me._rowguid
        End Get
        Set(ByVal value As System.Guid)
            If (Me._rowguid <> value) Then
                Me.OnrowguidChanging(value)
                Me.SendPropertyChanging()
                Me._rowguid = value
                Me.SendPropertyChanged("rowguid")
                Me.OnrowguidChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ModifiedDate", DbType:="DateTime NOT NULL")> _
    Public Property ModifiedDate() As Date
        Get
            Return Me._ModifiedDate
        End Get
        Set(ByVal value As Date)
            If (Me._ModifiedDate <> value) Then
                Me.OnModifiedDateChanging(value)
                Me.SendPropertyChanging()
                Me._ModifiedDate = value
                Me.SendPropertyChanged("ModifiedDate")
                Me.OnModifiedDateChanged()
            End If
        End Set
    End Property

    Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub SendPropertyChanging()
        RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
    End Sub

    Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
'#pragma warning restore 1591