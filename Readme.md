<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/AjaxSupport/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/AjaxSupport/Controllers/HomeController.vb))
* [MyModel.cs](./CS/AjaxSupport/Models/MyModel.cs) (VB: [MyModel.vb](./VB/AjaxSupport/Models/MyModel.vb))
* [_CaptchaPartial.cshtml](./CS/AjaxSupport/Views/Home/_CaptchaPartial.cshtml)
* [EditFormPartial.cshtml](./CS/AjaxSupport/Views/Home/EditFormPartial.cshtml)
* **[Index.cshtml](./CS/AjaxSupport/Views/Home/Index.cshtml)**
* [Index2.cshtml](./CS/AjaxSupport/Views/Home/Index2.cshtml)
<!-- default file list end -->
# How to validate Captcha and submit model values using $.ajax
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t121585)**
<!-- run online end -->


This example demonstrates how to implement Model and Captcha validation using $.ajax.The main idea is to use the jQuery <a href="http://api.jquery.com/serialize/">serialize</a> function to manually collect values from all inputs inside form. Then pass them to the Controller using $.ajax.

<br/>


