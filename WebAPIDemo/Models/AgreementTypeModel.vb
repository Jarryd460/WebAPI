Imports FCClassLibrary
Imports FCClassLibrary.Security
Imports SpatialDimensionLibrary.Database

Public Class AgreementTypeModel

    Private c_idAgreementType As Guid
    Private c_strAgreementType As String

    Public Sub New(idAgreementType As Guid, strAgreementType As String)
        c_idAgreementType = idAgreementType
        c_strAgreementType = strAgreementType
    End Sub

    Public Property ID() As Guid
        Get
            Return c_idAgreementType
        End Get
        Set(Value As Guid)
            c_idAgreementType = Value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return c_strAgreementType
        End Get
        Set(Value As String)
            c_strAgreementType = Value
        End Set
    End Property

    ':REVIEW:

    Public Shared Function ConvertFCClassLibraryAgreementTypeToAPIAgreementType(drAgreementType As DataRow) As AgreementTypeModel
        Dim guidAgreementType As Guid
        Dim strType As String

        guidAgreementType = drAgreementType.Item(FieldName_AgreementType(enumTableField_AgreementType.ID))
        strType = drAgreementType.Item(FieldName_AgreementType(enumTableField_AgreementType.AgreementType))

        Return New AgreementTypeModel(guidAgreementType, strType)

    End Function

    'Public Shared Function ConvertFCClassLibraryLicenseToAPILicense(drLicense As DataRow) As LicenseModel
    '    Dim guidLicense As Guid
    '    Dim strName As String
    '    Dim strCode As String
    '    Dim guidType As Guid
    '    Dim intStatus As Integer
    '    Dim dteApplicationDate As Date
    '    Dim intAgreementsCount As Integer

    '    guidLicense = drLicense.Item(FieldName_License(enumTableField_License.ID))
    '    strName = drLicense.Item(FieldName_License(enumTableField_License.Name))
    '    strCode = drLicense.Item(FieldName_License(enumTableField_License.Code))
    '    guidType = drLicense.Item(FieldName_License(enumTableField_License.TypeID))
    '    intStatus = drLicense.Item(FieldName_License(enumTableField_License.StatusID))
    '    dteApplicationDate = drLicense.Item(FieldName_License(enumTableField_License.DateApplication))
    '    intAgreementsCount = drLicense.Item(FieldName_License(enumTableField_License.AgreementCount))

    '    'DBCon.LookupValue(FieldName_LicenseType(enumTableField_LicenseType.LicenseType), FieldName_LicenseType(enumTableField_LicenseType.LicenseTypeID), "tblLicenseType", )
    '    'DBCon.LookupValue(FieldName_LicenseStatus(enumTableField_LicenseStatus.LicenseStatus), FieldName_LicenseStatus(enumTableField_LicenseStatus.ID), "lutLicenseStatus", License.c_strLicenseStatus_ID)

    '    Return New LicenseModel(guidLicense, strName, strCode, guidType, intStatus, dteApplicationDate, intAgreementsCount)
    'End Function

End Class
