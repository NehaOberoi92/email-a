﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace com.cdyne.ws
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="evSoap", [Namespace]:="http://ws.cdyne.com/"),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(Object()))>  _
    Partial Public Class ev
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private VerifyEmailOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ReturnCodesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://ws.cdyne.com/emailverify/ev.asmx"
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event VerifyEmailCompleted As VerifyEmailCompletedEventHandler
        
        '''<remarks/>
        Public Event ReturnCodesCompleted As ReturnCodesCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ws.cdyne.com/VerifyEmail", RequestNamespace:="http://ws.cdyne.com/", ResponseNamespace:="http://ws.cdyne.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function VerifyEmail(ByVal email As String) As ReturnIndicator
            Dim results() As Object = Me.Invoke("VerifyEmail", New Object() {email})
            Return CType(results(0),ReturnIndicator)
        End Function
        
        '''<remarks/>
        Public Function BeginVerifyEmail(ByVal email As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("VerifyEmail", New Object() {email}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndVerifyEmail(ByVal asyncResult As System.IAsyncResult) As ReturnIndicator
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),ReturnIndicator)
        End Function
        
        '''<remarks/>
        Public Overloads Sub VerifyEmailAsync(ByVal email As String)
            Me.VerifyEmailAsync(email, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub VerifyEmailAsync(ByVal email As String, ByVal userState As Object)
            If (Me.VerifyEmailOperationCompleted Is Nothing) Then
                Me.VerifyEmailOperationCompleted = AddressOf Me.OnVerifyEmailOperationCompleted
            End If
            Me.InvokeAsync("VerifyEmail", New Object() {email}, Me.VerifyEmailOperationCompleted, userState)
        End Sub
        
        Private Sub OnVerifyEmailOperationCompleted(ByVal arg As Object)
            If (Not (Me.VerifyEmailCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent VerifyEmailCompleted(Me, New VerifyEmailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ws.cdyne.com/ReturnCodes", RequestNamespace:="http://ws.cdyne.com/", ResponseNamespace:="http://ws.cdyne.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ReturnCodes() As Object()
            Dim results() As Object = Me.Invoke("ReturnCodes", New Object(-1) {})
            Return CType(results(0),Object())
        End Function
        
        '''<remarks/>
        Public Function BeginReturnCodes(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ReturnCodes", New Object(-1) {}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndReturnCodes(ByVal asyncResult As System.IAsyncResult) As Object()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Object())
        End Function
        
        '''<remarks/>
        Public Overloads Sub ReturnCodesAsync()
            Me.ReturnCodesAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ReturnCodesAsync(ByVal userState As Object)
            If (Me.ReturnCodesOperationCompleted Is Nothing) Then
                Me.ReturnCodesOperationCompleted = AddressOf Me.OnReturnCodesOperationCompleted
            End If
            Me.InvokeAsync("ReturnCodes", New Object(-1) {}, Me.ReturnCodesOperationCompleted, userState)
        End Sub
        
        Private Sub OnReturnCodesOperationCompleted(ByVal arg As Object)
            If (Not (Me.ReturnCodesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ReturnCodesCompleted(Me, New ReturnCodesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://ws.cdyne.com/")>  _
    Partial Public Class ReturnIndicator
        
        Private responseTextField As String
        
        Private responseCodeField As Integer
        
        Private lastMailServerField As String
        
        '''<remarks/>
        Public Property ResponseText() As String
            Get
                Return Me.responseTextField
            End Get
            Set
                Me.responseTextField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ResponseCode() As Integer
            Get
                Return Me.responseCodeField
            End Get
            Set
                Me.responseCodeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property LastMailServer() As String
            Get
                Return Me.lastMailServerField
            End Get
            Set
                Me.lastMailServerField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")>  _
    Public Delegate Sub VerifyEmailCompletedEventHandler(ByVal sender As Object, ByVal e As VerifyEmailCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class VerifyEmailCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As ReturnIndicator
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),ReturnIndicator)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0")>  _
    Public Delegate Sub ReturnCodesCompletedEventHandler(ByVal sender As Object, ByVal e As ReturnCodesCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.81.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ReturnCodesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Object()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Object())
            End Get
        End Property
    End Class
End Namespace
