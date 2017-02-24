Imports FCClassLibrary
Imports FCClassLibrary.Security
Imports SpatialDimensionLibrary.Database

Public Class AgreementModel

    Private c_idAgreement As Guid
    Private c_strName As String
    Private c_guidType As Guid
    Private c_guidStatus As Guid
    Private c_dteEndDate As Date

    Public Sub New(idAgreement As Guid, strName As String, guidType As Guid, guidStatus As Guid, dteEndDate As Date)
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

    Public Property Status() As Guid
        Get
            Return c_guidStatus
        End Get
        Set(Value As Guid)
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

    Public Shared Function ConvertFCClassLibraryAgreementToAPIAgreement(drAgreement As DataRow) As AgreementModel
        Dim guidAgreement As Guid
        Dim strName As String
        Dim guidType As Guid
        Dim guidStatus As Guid
        Dim dteEndDate As Date

        guidAgreement = drAgreement.Item(FieldName_Agreement(enumTableField_Agreement.ID))
        strName = drAgreement.Item(FieldName_Agreement(enumTableField_Agreement.Name))
        guidType = drAgreement.Item(FieldName_Agreement(enumTableField_Agreement.AgreementTypeID))
        guidStatus = drAgreement.Item(FieldName_Agreement(enumTableField_Agreement.AgreementStatusID))
        dteEndDate = drAgreement.Item(FieldName_Agreement(enumTableField_Agreement.DateEnd))

        Return New AgreementModel(guidAgreement, strName, guidType, guidStatus, dteEndDate)
    End Function

    Public Shared Function ConvertAPIAgreementToFCClassLibraryAgreement(ByVal agreementModel As AgreementModel) As FCClassLibrary.Agreement
        Dim agreementFC As FCClassLibrary.Agreement
        Dim objLookupManager As LookupManager
        Dim objAuthorisationController As AuthorisationController
        Dim objUser As User
        Dim DBCon As DBConnection

        DBCon = NewConnection()

        objUser = New User(DBCon)

        objLookupManager = New LookupManagerManager()

        objAuthorisationController = New AuthorisationController(DBCon, objLookupManager, objUser.User_guid, "English", False)

        agreementFC = New FCClassLibrary.Agreement(DBCon, agreementModel.ID, objLookupManager, objAuthorisationController, Asset.enumLoadFlags.Licenses, False)

        agreementFC.Name = agreementModel.Name
        agreementFC.AgreementType = agreementModel.Type
        agreementFC.AgreementStatus = agreementModel.Status
        agreementFC.EndDate = agreementModel.End_Date

        Return agreementFC
    End Function

End Class
