@ModelType MVCxGridViewDataBinding.Models.MyModel
@Html.DevExpress().LabelFor(Function(m) m.ModelID, Sub(settings)
                                                   End Sub).GetHtml()
@Html.DevExpress().TextBoxFor(Function(m) m.ModelID, Sub(settings)   
       settings.ShowModelErrors = true
       settings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.Text
   End Sub).GetHtml()
@Html.DevExpress().LabelFor(Function(m) m.ModelName, Sub(settings) 
    End Sub).GetHtml()
@Html.DevExpress().TextBoxFor(Function(m) m.ModelName, Sub(settings)   
       settings.ShowModelErrors = true
       settings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.Text
   End Sub).GetHtml()

  @Html.Action("CaptchaPartial")
@Html.DevExpress().Button(Sub(settings)

    settings.Name = "MyButton"
    settings.Text = "Post"
    settings.UseSubmitBehavior = false
    settings.ClientSideEvents.Click = "OnClick"
End Sub).GetHtml()

