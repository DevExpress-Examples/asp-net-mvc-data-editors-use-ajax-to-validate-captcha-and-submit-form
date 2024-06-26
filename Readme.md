<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549322/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T121585)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Data Editors for ASP.NET MVC - How to use AJAX callbacks to validate a Captcha code and submit a form

This example demonstrates how to use callbacks to validate model data and [Captcha](https://docs.devexpress.com/AspNetMvc/15164/components/data-editors-extensions/captcha) code.

![Validate Model Values](image.png)

Call the jQuery library's [serialize](https://api.jquery.com/serialize/) method to collect values from all editors displayed in a form. Send these values in an AJAX callback to the Controller.

## Files to Review

* [Index.cshtml](./CS/AjaxSupport/Views/Home/Index.cshtml)
* [Index2.cshtml](./CS/AjaxSupport/Views/Home/Index2.cshtml)
* [HomeController.cs](./CS/AjaxSupport/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/AjaxSupport/Controllers/HomeController.vb))
* [MyModel.cs](./CS/AjaxSupport/Models/MyModel.cs) (VB: [MyModel.vb](./VB/AjaxSupport/Models/MyModel.vb))
* [_CaptchaPartial.cshtml](./CS/AjaxSupport/Views/Home/_CaptchaPartial.cshtml)
* [EditFormPartial.cshtml](./CS/AjaxSupport/Views/Home/EditFormPartial.cshtml)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-data-editors-use-ajax-to-validate-captcha-and-submit-form&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-data-editors-use-ajax-to-validate-captcha-and-submit-form&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
