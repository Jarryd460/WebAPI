Public Class LicenseStatusModel

    Private c_idLicenseStatus As Guid
    Private c_strLicenseStatus As String

    Public Property ID() As Guid
        Get
            Return c_idLicenseStatus
        End Get
        Set(Value As Guid)
            c_idLicenseStatus = Value
        End Set
    End Property

    Public Property Type() As String
        Get
            Return c_strLicenseStatus
        End Get
        Set(Value As String)
            c_strLicenseStatus = Value
        End Set
    End Property

End Class
