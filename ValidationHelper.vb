Imports System.Text.RegularExpressions

''' <summary>
''' Shared input validation for S &amp; N Tyre Center application.
''' Rules mirror database constraints documented in README.md.
''' </summary>
Public Module ValidationHelper

    Public Enum ValidationResultKind
        Ok = 0
        Warning = 1
        [Error] = 2
    End Enum

    Public Structure ValidationOutcome
        Public IsValid As Boolean
        Public Message As String
        Public Kind As ValidationResultKind
    End Structure

    Private ReadOnly PhonePattern As New Regex("^[0-9]{10}$", RegexOptions.Compiled)
    Private ReadOnly EmailPattern As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled)
    Private ReadOnly ItemCodePattern As New Regex("^[A-Za-z0-9\-]{3,30}$", RegexOptions.Compiled)

    Public Function OkOptional() As ValidationOutcome
        Return New ValidationOutcome With {.IsValid = True, .Message = "", .Kind = ValidationResultKind.Ok}
    End Function

    Public Function Fail(message As String, Optional kind As ValidationResultKind = ValidationResultKind.Error) As ValidationOutcome
        Return New ValidationOutcome With {.IsValid = False, .Message = message, .Kind = kind}
    End Function

    Public Function RequireText(value As String, fieldLabel As String, Optional maxLen As Integer = 0) As ValidationOutcome
        If String.IsNullOrWhiteSpace(value) Then
            Return Fail($"{fieldLabel} is required.")
        End If
        If maxLen > 0 AndAlso value.Trim().Length > maxLen Then
            Return Fail($"{fieldLabel} must be at most {maxLen} characters.")
        End If
        Return OkOptional()
    End Function

    Public Function ValidatePhone(phone As String, Optional fieldLabel As String = "Phone number") As ValidationOutcome
        Dim p = If(phone, "").Trim()
        If p.Length = 0 Then Return Fail($"{fieldLabel} is required.")
        If Not PhonePattern.IsMatch(p) Then
            Return Fail($"{fieldLabel} must be exactly 10 digits (e.g. 0712345678).")
        End If
        Return OkOptional()
    End Function

    Public Function ValidateEmail(email As String, Optional required As Boolean = False) As ValidationOutcome
        Dim e = If(email, "").Trim()
        If e.Length = 0 Then
            If required Then Return Fail("Email is required.")
            Return OkOptional()
        End If
        If e.Length > 150 Then Return Fail("Email must be at most 150 characters.")
        If Not EmailPattern.IsMatch(e) Then Return Fail("Please enter a valid email address.")
        Return OkOptional()
    End Function

    Public Function ValidatePrice(price As Decimal, fieldLabel As String, Optional allowZero As Boolean = True) As ValidationOutcome
        If Not allowZero AndAlso price <= 0 Then
            Return Fail($"{fieldLabel} must be greater than zero.")
        End If
        If price < 0 Then Return Fail($"{fieldLabel} cannot be negative.")
        If price > 9999999.99D Then Return Fail($"{fieldLabel} is too large.")
        Return OkOptional()
    End Function

    Public Function ValidateQuantity(qty As Integer, Optional allowZero As Boolean = True) As ValidationOutcome
        If qty < 0 Then Return Fail("Quantity cannot be negative.")
        If Not allowZero AndAlso qty = 0 Then Return Fail("Quantity must be greater than zero.")
        Return OkOptional()
    End Function

    Public Function ValidateDiscountPercent(pct As Decimal) As ValidationOutcome
        If pct < 0 OrElse pct > 100 Then Return Fail("Discount must be between 0 and 100 percent.")
        Return OkOptional()
    End Function

    Public Function ValidateLogin(username As String, password As String) As ValidationOutcome
        Dim r = RequireText(username, "Username", 50)
        If Not r.IsValid Then Return r
        r = RequireText(password, "Password", 100)
        If Not r.IsValid Then Return r
        If password.Length < 4 Then Return Fail("Password must be at least 4 characters.")
        Return OkOptional()
    End Function

    Public Function ValidateCustomer(name As String, phone As String, email As String, address As String, priceCategory As String) As ValidationOutcome
        Dim r = RequireText(name, "Customer name", 100)
        If Not r.IsValid Then Return r
        r = ValidatePhone(phone)
        If Not r.IsValid Then Return r
        r = ValidateEmail(email, required:=False)
        If Not r.IsValid Then Return r
        r = RequireText(address, "Address", 400)
        If Not r.IsValid Then Return r
        If Not IsValidPriceCategory(priceCategory) Then
            Return Fail("Select a valid customer price category (Retail, Wholesale, or Distributor).")
        End If
        Return OkOptional()
    End Function

    Public Function IsValidPriceCategory(category As String) As Boolean
        Select Case If(category, "").Trim()
            Case "Retail", "Wholesale", "Distributor"
                Return True
            Case Else
                Return False
        End Select
    End Function

    Public Function ValidateItemCode(code As String) As ValidationOutcome
        Dim c = If(code, "").Trim()
        If c.Length = 0 Then Return Fail("Item code is required.")
        If Not ItemCodePattern.IsMatch(c) Then
            Return Fail("Item code: 3–30 characters, letters, numbers, and hyphens only.")
        End If
        Return OkOptional()
    End Function

    Public Function ValidateItem(
        itemName As String,
        itemType As String,
        retailPrice As Decimal,
        wholesalePrice As Decimal,
        quantity As Integer,
        reorderLevel As Integer) As ValidationOutcome

        Dim r = RequireText(itemName, "Item name", 150)
        If Not r.IsValid Then Return r

        Select Case If(itemType, "").Trim()
            Case "Tyre", "Tube", "Service", "Accessory"
            Case Else
                Return Fail("Select a valid item type.")
        End Select

        r = ValidatePrice(retailPrice, "Retail price", allowZero:=False)
        If Not r.IsValid Then Return r
        r = ValidatePrice(wholesalePrice, "Wholesale price")
        If Not r.IsValid Then Return r
        If wholesalePrice > retailPrice AndAlso wholesalePrice > 0 Then
            Return Fail("Wholesale price cannot exceed retail price.")
        End If
        r = ValidateQuantity(quantity)
        If Not r.IsValid Then Return r
        r = ValidateQuantity(reorderLevel)
        If Not r.IsValid Then Return r

        If itemType = "Service" AndAlso quantity <> 0 Then
            Return Fail("Services do not hold stock quantity; set quantity to 0.")
        End If

        Return OkOptional()
    End Function

    Public Function ValidateSaleLine(qty As Integer, unitPrice As Decimal, availableStock As Integer, tracksStock As Boolean) As ValidationOutcome
        If qty <= 0 Then Return Fail("Sale quantity must be at least 1.")
        Dim r = ValidatePrice(unitPrice, "Unit price", allowZero:=False)
        If Not r.IsValid Then Return r
        If tracksStock AndAlso qty > availableStock Then
            Return Fail($"Insufficient stock. Available: {availableStock}.")
        End If
        Return OkOptional()
    End Function

    Public Function ShowIfInvalid(outcome As ValidationOutcome, Optional title As String = "Validation") As Boolean
        If outcome.IsValid Then Return True
        Dim icon = If(outcome.Kind = ValidationResultKind.Warning,
                      MessageBoxIcon.Warning,
                      MessageBoxIcon.Error)
        MessageBox.Show(outcome.Message, title, MessageBoxButtons.OK, icon)
        Return False
    End Function

End Module
