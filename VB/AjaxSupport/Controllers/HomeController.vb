Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports MVCxGridViewDataBinding.Models

Namespace AjaxSupport.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View(New MyModel(0))
		End Function
		<ValidateInput(False)> _
		Public Function CaptchaPartial() As ActionResult
			Return PartialView("_CaptchaPartial")
		End Function
        Public Function Index2(ByVal model As MyModel) As ActionResult
            If CaptchaExtension.GetIsValid("Captcha") AndAlso ModelState.IsValid Then
                ViewData("Key") = "Successfull"
                Return PartialView()
            End If
            Return PartialView("EditFormPartial", model)
        End Function
	End Class
End Namespace