Public Class AgreementModel

    Private c_idAgreement As Guid
    Private c_strName As String
    Private c_guidType As Guid
    Private c_guidStatus As Integer
    Private c_dteEndDate As Date

    Public Sub New(idAgreement As Guid, strName As String, guidType As Guid, guidStatus As Integer, dteEndDate As Date)
        Me.c_idLicense = idAgreement
        Me.c_strName = strName
        Me.c_guidType = guidType
        Me.c_guidStatus = guidStatus
        Me.c_dteEndDate = dteEndDate

    End Sub

End Class
