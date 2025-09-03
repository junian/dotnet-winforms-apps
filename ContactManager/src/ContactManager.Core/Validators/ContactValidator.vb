Imports System.Text.RegularExpressions
Imports FluentValidation

Public Class ContactValidator
    Inherits AbstractValidator(Of Contact)

    Public Sub New()
        RuleFor(Function(x) x.Name).NotEmpty()
        RuleFor(Function(x) x.Email).EmailAddress().
            When(Function(x) Not String.IsNullOrWhiteSpace(x.Email))
        RuleFor(Function(x) x.Phone).
            Must(AddressOf BeAValidPhoneNumber).
            When(Function(x) Not String.IsNullOrWhiteSpace(x.Phone)).
            WithMessage("Invalid phone number format")
    End Sub

    Private Function BeAValidPhoneNumber(phone As String) As Boolean
        ' Regex for phone number validation (adjust as needed)
        Dim phoneRegex As String = "^\+?[1-9]\d{1,14}$" ' E.164 format (international numbers)
        Return Regex.IsMatch(phone, phoneRegex)
    End Function

End Class
