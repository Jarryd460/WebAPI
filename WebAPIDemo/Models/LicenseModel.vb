Imports FCClassLibrary
Imports FCClassLibrary.Security
Imports SpatialDimensionLibrary.Database

Public Class LicenseModel

    Private c_idLicense As Guid
    Private c_strName As String
    Private c_strCode As String
    Private c_guidType As Guid
    Private c_intStatus As Integer
    Private c_dteApplicationDate As Date
    Private c_intAgreementsCount As Integer
    Private c_lstAgreements As List(Of AgreementModel)

    Public Sub New(idLicense As Guid, strName As String, strCode As String, guidType As Guid, intStatus As Integer, dteApplicationDate As Date, intAgreementsCount As Integer)
        Me.c_idLicense = idLicense
        Me.c_strName = strName
        Me.c_strCode = strCode
        Me.c_guidType = guidType
        Me.c_intStatus = intStatus
        Me.c_dteApplicationDate = dteApplicationDate
        Me.c_intAgreementsCount = intAgreementsCount
        Me.c_lstAgreements = Nothing
    End Sub

    Public Property ID() As Guid
        Get
            Return c_idLicense
        End Get
        Set(Value As Guid)
            c_idLicense = Value
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

    Public Property Code() As String
        Get
            Return c_strCode
        End Get
        Set(Value As String)
            c_strCode = Value
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
            Return c_intStatus
        End Get
        Set(Value As Integer)
            c_intStatus = Value
        End Set
    End Property

    Public Property Application_Date() As Date
        Get
            Return c_dteApplicationDate
        End Get
        Set(Value As Date)
            c_dteApplicationDate = Value
        End Set
    End Property

    Public Property Agreements_Count() As Integer
        Get
            Return c_intAgreementsCount
        End Get
        Set(Value As Integer)
            c_intAgreementsCount = Value
        End Set
    End Property

    Public Property Agreements() As List(Of AgreementModel)
        Get
            Return c_lstAgreements
        End Get
        Set(Value As List(Of AgreementModel))
            c_lstAgreements = Value
        End Set
    End Property

    Public Shared Function ConvertFCClassLibraryLicenseToAPILicense(drLicense As DataRow) As LicenseModel
        Dim guidLicense As Guid
        Dim strName As String
        Dim strCode As String
        Dim guidType As Guid
        Dim intStatus As Integer
        Dim dteApplicationDate As Date
        Dim intAgreementsCount As Integer

        guidLicense = drLicense.Item(FieldName_License(enumTableField_License.ID))
        strName = drLicense.Item(FieldName_License(enumTableField_License.Name))
        strCode = drLicense.Item(FieldName_License(enumTableField_License.Code))
        guidType = drLicense.Item(FieldName_License(enumTableField_License.TypeID))
        intStatus = drLicense.Item(FieldName_License(enumTableField_License.StatusID))
        dteApplicationDate = drLicense.Item(FieldName_License(enumTableField_License.DateApplication))
        intAgreementsCount = drLicense.Item(FieldName_License(enumTableField_License.AgreementCount))

        'DBCon.LookupValue(FieldName_LicenseType(enumTableField_LicenseType.LicenseType), FieldName_LicenseType(enumTableField_LicenseType.LicenseTypeID), "tblLicenseType", )
        'DBCon.LookupValue(FieldName_LicenseStatus(enumTableField_LicenseStatus.LicenseStatus), FieldName_LicenseStatus(enumTableField_LicenseStatus.ID), "lutLicenseStatus", License.c_strLicenseStatus_ID)

        Return New LicenseModel(guidLicense, strName, strCode, guidType, intStatus, dteApplicationDate, intAgreementsCount)
    End Function

    Public Shared Function ConvertAPILicenseToFCClassLibraryLicense(ByVal licenseModel As LicenseModel) As FCClassLibrary.License
        Dim licenseFC As FCClassLibrary.License
        Dim objLookupManager As LookupManager
        Dim objAuthorisationController As AuthorisationController
        Dim objUser As User
        Dim DBCon As DBConnection

        DBCon = NewConnection()

        objUser = New User(DBCon)

        objLookupManager = New LookupManagerManager()

        objAuthorisationController = New AuthorisationController(DBCon, objLookupManager, objUser.User_guid, "English", False)

        licenseFC = New FCClassLibrary.License(DBCon, licenseModel.ID, objLookupManager, objAuthorisationController, Asset.enumLoadFlags.Licenses, False)

        licenseFC.LicenseName = licenseModel.Name
        licenseFC.LicenseCode = licenseModel.Code
        licenseFC.LicenseTypeID = licenseModel.Type
        licenseFC.LicenseStatus_ID = licenseModel.Status
        licenseFC.DateApplication = licenseModel.Application_Date

        Return licenseFC
    End Function

    Public Shared Function ConvertFCClassLibraryLicenseToAPILicense(ByVal licenseFC As FCClassLibrary.License) As LicenseModel
        Return New LicenseModel(licenseFC.ID,
                                licenseFC.LicenseName,
                                licenseFC.LicenseCode,
                                licenseFC.LicenseTypeID,
                                licenseFC.LicenseStatus_ID,
                                licenseFC.DateApplication,
                                licenseFC.Agreements.RowCount)
    End Function

End Class
