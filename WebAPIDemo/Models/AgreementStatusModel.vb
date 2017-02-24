Public Class AgreementStatusModel

    Private c_agreementStatusID As Guid
    Private c_agreementStatus As String

    Public Property ID() As Guid
        Get
            Return c_agreementStatusID
        End Get
        Set(Value As Guid)
            c_agreementStatusID = Value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return c_agreementStatus
        End Get
        Set(Value As String)
            c_agreementStatus = Value
        End Set
    End Property

End Class
