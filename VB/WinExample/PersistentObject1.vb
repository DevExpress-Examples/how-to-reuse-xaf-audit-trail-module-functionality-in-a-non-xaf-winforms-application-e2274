Imports System
Imports DevExpress.Xpo

Namespace WinExample

	Public Class PersistentObject1
		Inherits XPObject

		Public Sub New()
			MyBase.New()
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here.
		End Sub

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here.
		End Sub

		Private _Property1 As String
		Public Property Property1() As String
			Get
				Return _Property1
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Property1", _Property1, value)
			End Set
		End Property

		Private _Property2 As String
		Public Property Property2() As String
			Get
				Return _Property2
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Property2", _Property2, value)
			End Set
		End Property
	End Class

End Namespace