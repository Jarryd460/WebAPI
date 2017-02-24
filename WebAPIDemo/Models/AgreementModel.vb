Imports FCClassLibrary

Public Class AgreementModel

    Private c_idAgreement As Guid
    Private c_strName As String
    Private c_guidType As Guid
    Private c_guidStatus As Integer
    Private c_dteEndDate As Date

    Public Sub New(idAgreement As Guid, strName As String, guidType As Guid, guidStatus As Integer, dteEndDate As Date)
        Me.c_idAgreement = idAgreement
        Me.c_strName = strName
        Me.c_guidType = guidType
        Me.c_guidStatus = guidStatus
        Me.c_dteEndDate = dteEndDate
    End Sub

    Public Property ID() As Guid
        Get
            Return c_idAgreement
        End Get
        Set(Value As Guid)
            c_idAgreement = Value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return c_strName
        End Get
        Set(Value As String)
            c_strName = Value
        End Set
    End Property

    Public Property Type() As Guid
        Get
            Return c_guidType
        End Get
        Set(Value As Guid)
            c_guidType = Value
        End Set
    End Property

    Public Property Status() As Integer
        Get
            Return c_guidStatus
        End Get
        Set(Value As Integer)
            c_guidStatus = Value
        End Set
    End Property

    Public Property End_Date() As Date
        Get
            Return c_dteEndDate
        End Get
        Set(Value As Date)
            c_dteEndDate = Value
        End Set
    End Property

    Public Shared Function ConvertFCClassLibraryAgreementToAPIAgreement(drLicense As DataRow) As AgreementModel
        Dim guidAgreement As Guid
        Dim strName As String
        Dim guidType As Guid
        Dim guidStatus As Integer
        Dim dteEndDate As Date

        guidAgreement = drLicense.Item(FieldName_Agreement(enumTableField_Agreement.ID))
        strName = drLicense.Item(FieldName_Agreement(enumTableField_Agreement.Name))
        guidType = drLicense.Item(FieldName_Agreement(enumTableField_Agreement.AgreementTypeID))
        guidStatus = drLicense.Item(FieldName_Agreement(enumTableField_Agreement.AgreementStatusID))
        dteEndDate = drLicense.Item(FieldName_Agreement(enumTableField_Agreement.DateEnd))

        Return New AgreementModel(guidAgreement, strName, guidType, guidStatus, dteEndDate)
    End Function

End Class
