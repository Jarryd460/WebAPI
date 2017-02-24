Public Class AgreementTypeModel

    Private c_idAgreementType As Guid
    Private c_strAgreementType As String

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

End Class
