Imports FCClassLibrary
Imports FCClassLibrary.Security
Imports SpatialDimensionLibrary.Database

Public Class AgreementStatusModel

    Private c_idAgreementStatus As Guid
    Private c_strAgreementStatus As String

    Public Property ID() As Guid
        Get
            Return c_idAgreementStatus
        End Get
        Set(Value As Guid)
            c_idAgreementStatus = Value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return c_strAgreementStatus
        End Get
        Set(Value As String)
            c_strAgreementStatus = Value
        End Set
    End Property

    'Public Shared Function ConvertFCClassLibraryAgreementStatusToAPIAgreementStatus(ByVal agreementStatusModel As AgreementStatusModel) As FCClassLibrary.AgreementStatus
    '    Dim agreementStatusFC As FCClassLibrary.AgreementStatus
    '    Dim objLookupManager As LookupManager
    '    Dim objAuthorisationController As AuthorisationController
    '    Dim objUser As User
    '    Dim DBCon As DBConnection

    '    DBCon = NewConnection()

    '    objUser = New User(DBCon)

    '    objLookupManager = New LookupManagerManager()

    '    objAuthorisationController = New AuthorisationController(DBCon, objLookupManager, objUser.User_guid, "English", False)

    '    agreementStatusFC = New FCClassLibrary.

    'End Function

End Class
