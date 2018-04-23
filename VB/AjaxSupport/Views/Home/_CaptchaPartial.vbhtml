@Html.DevExpress().Captcha(Sub(settings)
    settings.Name = "Captcha"
    settings.CallbackRouteValues = New With { .Controller = "Home", .Action = "CaptchaPartial" }
    settings.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
    settings.CodeLength = 5
    settings.TextBox.Position = DevExpress.Web.ASPxEditors.Captcha.ControlPosition.Bottom
End  Sub).GetHtml()