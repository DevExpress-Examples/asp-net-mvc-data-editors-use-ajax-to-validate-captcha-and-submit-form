@ModelType MVCxGridViewDataBinding.Models.MyModel
<script id="dxss_script1" type="text/javascript">
    function OnClick(s, e) {
        if (!IsValidForm())
            return;
        var obj = $("#myForm").serialize();
        $.ajax({
            type: "POST",
            url: "@Url.Action("Index2")",
            data: obj,
            success: function (response) {
                $("#container").html(response);
            }
        });
    }
    function IsValidForm() {
        InitializeValidationRulesForForm();
        var validator = $.data($('#myForm')[0], 'validator');
        return validator.form();
    }
    function InitializeValidationRulesForForm() {
        var form = $('#myForm');
        if (form.executed)
            return;
        form.removeData("validator");
        $.validator.unobtrusive.parse(document);
        form.executed = true;
    }
</script>

@Using(Html.BeginForm("Index", "Home", FormMethod.Get, New With { .id = "myForm" }))

    ViewContext.Writer.Write("<div id='container' class='container'>")
    Html.RenderPartial("EditFormPartial")
  
ViewContext.Writer.Write("</div>")

End Using

