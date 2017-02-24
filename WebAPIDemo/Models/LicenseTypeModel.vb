Public Class LicenseTypeModel

    Private c_idLicenseType As Guid
    Private c_strLicenseType As String

    Public Property ID() As Guid
        Get
            Return c_idLicenseType
        End Get
        Set(Value As Guid)
            c_idLicenseType = Value
        End Set
    End Property

    Public Property Type() As String
        Get
            Return c_strLicenseType
        End Get
        Set(Value As String)
            c_strLicenseType = Value
        End Set
    End Property

End Class
