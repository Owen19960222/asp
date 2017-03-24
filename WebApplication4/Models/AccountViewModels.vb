Imports System.ComponentModel.DataAnnotations

Public Class ExternalLoginConfirmationViewModel
    <Required>
    <Display(Name:="使用者名稱")>
    Public Property UserName As String
End Class

Public Class ManageUserViewModel
    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="目前密碼")>
    Public Property OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage:="{0} 的長度至少必須為 {2} 個字元。", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="新密碼")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="確認新密碼")>
    <Compare("NewPassword", ErrorMessage:="新密碼與確認密碼不相符。")>
    Public Property ConfirmPassword As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:="使用者名稱")>
    Public Property UserName As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="密碼")>
    Public Property Password As String

    <Display(Name:="記住我?")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required>
    <Display(Name:="使用者名稱")>
    Public Property UserName As String

    <Required>
    <StringLength(100, ErrorMessage:="{0} 的長度至少必須為 {2} 個字元。", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="密碼")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="確認密碼")>
    <Compare("Password", ErrorMessage:="密碼和確認密碼不相符。")>
    Public Property ConfirmPassword As String
End Class
