@ViewData("Key")
<div>
    @Html.DevExpress().HyperLink(Sub(settings)
    settings.Name = "Button"
    settings.Properties.Text = "Back"
    settings.NavigateUrl = DevExpressHelper.GetUrl(New With { .Controller = "Home", .Action = "Index" })
End Sub).GetHtml()
</div>
