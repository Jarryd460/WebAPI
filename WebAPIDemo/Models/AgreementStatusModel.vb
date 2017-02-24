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

End Class
