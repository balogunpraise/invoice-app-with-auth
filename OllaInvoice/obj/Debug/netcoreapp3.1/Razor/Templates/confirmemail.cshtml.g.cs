#pragma checksum "C:\Users\David\Desktop\InvoiceWithAuth\OllaInvoice\OllaInvoice\Templates\confirmemail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8d0120099989842041b184b202593e17f8474f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_confirmemail), @"mvc.1.0.view", @"/Templates/confirmemail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d0120099989842041b184b202593e17f8474f0", @"/Templates/confirmemail.cshtml")]
    public class Templates_confirmemail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OllaInvoice.AuthModels.ConfirmEmailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 0; padding: 0 !important; mso-line-height-rule: exactly; background-color: #FFFFFF;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\" xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:o=\"urn:schemas-microsoft-com:office:office\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8d0120099989842041b184b202593e17f8474f04552", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8""> <!-- utf-8 works for most cases -->
    <meta name=""viewport"" content=""width=device-width""> <!-- Forcing initial-scale shouldn't be necessary -->
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge""> <!-- Use the latest (edge) version of IE rendering engine -->
    <meta name=""x-apple-disable-message-reformatting"">  <!-- Disable auto-scale in iOS 10 Mail entirely -->
    <title></title> <!-- The title tag shows in email notifications, like Android 4.4. -->
    <link href=""https://fonts.googleapis.com/css?family=Playfair+Display:400,400i,700,700i"" rel=""stylesheet"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b8d0120099989842041b184b202593e17f8474f05437", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8d0120099989842041b184b202593e17f8474f07319", async() => {
                WriteLiteral(@"
    <center style=""width: 100%; background-color: #f1f1f1;"">
        <div style=""display: none; font-size: 1px;max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden; mso-hide: all; font-family: sans-serif;"">
            &zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;&zwnj;&nbsp;
        </div>
        <div style=""max-width: 600px; margin: 0 auto;"" class=""email-container"">
            <!-- BEGIN BODY -->
            <table align=""center"" role=""presentation"" cellspacing=""0"" cellpadding=""0"" border=""0"" width=""100%"" style=""margin: auto;"">
                <tr>
                    <td valign=""middle"" class=""hero bg_light"" style=""background-image: url(images/rectangle.svg); background-size: contain; background-repeat: no-repeat;"">
                        <table>
                            <tr>
                                <td>
          ");
                WriteLiteral(@"                          <div style=""text-align: center; margin-bottom: 10px;"">
                                        <svg width=""191"" height=""33"" viewBox=""0 0 191 33"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
                                            <path d=""M5.778 31H9.842L14.482 14.328L18.994 31H23.25L28.978 8.12H25.01L20.914 25.016L16.37 8.12H12.85L8.402 24.92L4.434 8.12H0.082L5.778 31ZM38.039 31.32C42.327 31.32 45.175 29.4 45.719 25.88H41.975C41.687 27.512 40.471 28.44 38.135 28.44C35.255 28.44 33.655 26.648 33.527 23.48H45.783V22.36C45.783 16.376 42.039 13.912 37.879 13.912C33.111 13.912 29.559 17.368 29.559 22.552V22.808C29.559 28.088 33.111 31.32 38.039 31.32ZM33.591 20.888C33.975 18.296 35.543 16.728 37.879 16.728C40.279 16.728 41.751 18.008 41.943 20.888H33.591ZM49.3375 31H53.2095V6.52H49.3375V31ZM65.257 31.32C69.801 31.32 72.713 28.6 73.001 24.76H69.449C69.225 27.128 67.465 28.344 65.417 28.344C62.569 28.344 60.777 26.424 60.777 22.776V22.52C");
                WriteLiteral(@"60.777 19.064 62.665 17.016 65.321 17.016C67.369 17.016 68.841 17.944 69.161 20.184H72.905C72.457 15.576 68.969 13.912 65.257 13.912C60.585 13.912 56.809 17.272 56.809 22.584V22.84C56.809 28.184 60.457 31.32 65.257 31.32ZM83.8233 28.312C80.8793 28.312 79.1833 26.168 79.1833 22.744V22.488C79.1833 19.032 80.9433 16.952 83.8233 16.952C86.7033 16.952 88.4313 19.064 88.4313 22.52V22.744C88.4313 26.168 86.7033 28.312 83.8233 28.312ZM83.7913 31.32C88.7193 31.32 92.3993 27.928 92.3993 22.712V22.456C92.3993 17.336 88.7193 13.912 83.8233 13.912C78.8953 13.912 75.2153 17.368 75.2153 22.552V22.808C75.2153 27.896 78.8633 31.32 83.7913 31.32ZM95.8978 31H99.7698V20.984C99.7698 18.424 101.53 17.144 103.45 17.144C105.338 17.144 106.426 18.2 106.426 20.664V31H110.298V20.984C110.298 18.424 112.058 17.144 113.978 17.144C115.898 17.144 116.954 18.2 116.954 20.664V31H120.826V20.408C120.826 15.8 118.33 13.912 115.258 13.912C113.178 13.912 110.874 14.84 109.594 16.92C108.762 14.84 107.034 13.912 104.858 13.912C102.394 13.912 100.57 ");
                WriteLiteral(@"15.256 99.7698 16.824V14.264H95.8978V31ZM132.633 31.32C136.921 31.32 139.769 29.4 140.313 25.88H136.569C136.281 27.512 135.065 28.44 132.729 28.44C129.849 28.44 128.249 26.648 128.121 23.48H140.377V22.36C140.377 16.376 136.633 13.912 132.473 13.912C127.705 13.912 124.153 17.368 124.153 22.552V22.808C124.153 28.088 127.705 31.32 132.633 31.32ZM128.185 20.888C128.569 18.296 130.137 16.728 132.473 16.728C134.873 16.728 136.345 18.008 136.537 20.888H128.185ZM146.239 31.224C147.679 31.224 148.831 30.136 148.831 28.76C148.831 27.352 147.679 26.264 146.239 26.264C144.831 26.264 143.679 27.352 143.679 28.76C143.679 30.136 144.831 31.224 146.239 31.224ZM144.703 24.12H147.839L148.447 8.12H144.127L144.703 24.12Z"" fill=""white"" />
                                            <path d=""M158.75 32.44H190.75V0.440001H158.75V32.44Z"" fill=""url(#pattern0)"" />
                                            <defs>
                                                <pattern id=""pattern0"" patternContentUnits=""objectBoundingBox"" width=""1");
                WriteLiteral(@""" height=""1"">
                                                    <use xlink:href=""#image0_473_1573"" transform=""scale(0.015625)"" />
                                                </pattern>
                                                <image id=""image0_473_1573"" width=""64"" height=""64"" xlink:href=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAEAAAABACAYAAACqaXHeAAAa90lEQVR4AczWA3RkWRrA8f/VUzGViprDtW3btm2Pbds21rbHtmd61IzKfLr7Nr3oM+xenf2dfKmkXJ9uCf4PffKTn5zodDqf9TxvfyDkv0h89KMf5f9NmqYfbDQaZzuOc1mhUHg/cC//JVoIwf8bIcQNxphboih6XqvVuqRYLL4buJj/As1/2cFvuXhr1UuelBqvkSKuBlo8uhu/+fNnvqDf758YhuF7ms3mL8vl8luBP/IfJj7+8Y/z33LQa377SVOeOkr7jp/GMcN296ZwvvUF4EIeYOdLXlXp9XqfCILgUCD92yiIrAuOzfbB56SUzVKp9FLgev6DxMc+9jH+G3Z/zi+e54+OXlBZvthoR5MmEWG3TWe+GbdnGh8BzmMDu1z0qje22+2fuY7zp0Kx+PG/zT2u6+p6vX5u1g3vNsbcVqlUngc0+Q/RjuOwqfZ5/QUmiZLNtEhMkoj7gQ4P0K31vyCkMoIUSJACXN+Fiq+jbu+sdm3QAX7K33ied1lW7QMHg8G2abN5QfZB3wFcFWey9v94kiRbZ+PwtGwnnAy8m/8Q8b73vW/TZvrVV22ZG/OPlsZ5dRqHIh7074zjdC/gHDZQu2f6t+WlE68aXb4YNxeASCGNs58hvUaduftqDduNXwdcz");
                WriteLiteral(@"ga2v+yVn8qScJLWemZ0dPSVwE2s98T5+fmr0jT1slH4JHDq//wYPOj9P1yWzFT/VN5syeZO4GPTkKjXYtBs0Z8bnBxMhZ8DEjK3/bl98OiS4JvjWywhP1ZFKglpvPCYOOzTmZ2ntrpzTTTsvgqos4F9r3/Xp7LFd5LjOHeMjY09G2iRyXbEl7Lrj1JKzWbJeSxQ598kPvOZz7CxvvHYb283umxq/9KiSYzngBBgI+JBh/bMbPahGicDnyZzz+3h0/IFrpjcompGlkzhFXIIUmwakSYhw172mOkGrTXDk4DP8AC7XfOao7rd7pfy+fxZwEfIZJX35ubmroii6MnZsjwc+Dr/JvGBD3yAjbXrs362z8iiyR1LU2MYz0UahwU2JOo1aKyZIWx1dwL2JbPi1uEPqlPO28eXj1Gaqq5Pmo1J44g4GjLotGmv7TDfjR/Y0hxz87v8Wq12aRzHT832wVuBn5AR8Opavf4boD0yMvI4YA3/Bu15Hhur30jvcfwmftFDCItRCiEVoDBejny1RDOJ9ohXhrcD33fd5EvN2eGzXL++VLuaQrWM1AJrLUIIHN8nqCbYsL//Wju4DLiFv/nUU8/vH3/1Oz83P1+7NFt8h46MlH8BxFqbPxhjLsn2xAuy2B74yv+sAz44/t2p8aJ77eKtRyaKY6M4+QLG8wALNiKNenSbDVpr6/1hkr4KuOS+qzuvy1f1T8eXF3RlUZWgHIAAmySQieOI3nz2mOnBr+/MN98MRGzg1F++45zsCPxAsVj8DHASGa3167Pu+IVSajrbBVsCXf5F4tOf/jSb4kP+WdtVFnv7T24xSlAu4+ZyKPO3BWdjkmhIt/HXJLRW1Qv9FwH3Tf852b06qXYbW15iZGoUvxgglSJDmsQMe13a67LHNPt7Abuygf2ueccT5ufmbjbG3J6NwhOAVAiRm8uui6JoeXZEPuKJsNfr7hjpOKufMx7FT0kJ3KGnbir01KXANBl94MsuYlP84Y/2mGg6fIvjNV4gpUAKiwhcp");
                WriteLiteral(@"AJsilQar5AniZIlYp5zVTR49dhT9O633xI9WzmdNxjXYPwAx/XBghRDHD/Fr4TEg2SnuWZyDfAj/kZJeavjOBeEYfji4XD4LOAKoOu57qnZ/3tki/LrD5WAfV/wR+UE+sNO4u651BlZqis5pBLE/YjQxrNJsvKrwHk6dmbZFC95baFz79G1j6wW6W+VZnOwQA4n8EBYrE3R2pAbKYHlBd2Z9ATgw5bwQ62Z8BLHaz3OCfJIt4B2DGCRKsYJAryRoSxFg0M9+lcBq8js9Yzz7LaXvuPwbN5fksXOwFvIBEFwehbLgAYPsMcLL/Ckled4peI7youncHIFEBJsgnIGCN0d6zQmz2jOObO6Pr+MTVV6/7IV0zdc/+7pe7q/kYoKCyzaMwghFrrANd5Cm1trP9Su9+/Y/Kmlve65qfnF2trhz1x/ztdeQG60gpQShEJpjVfMEQ3jzdvrvOOBN/E3WusLpJSnRVGYfTmqSiAF7s+OxU/xEJQITwkq5XeUpqZwC2UQijQFi8BKF6FC4mFivMLq54r7z5lgY5TGqEb1YiU1dg6okbn6R/e+prRI/WRys5xbGi+TK+dxfA+hfVAe2JioO09z7Ry9Zu+DwLkrrutsn6+Y/RZtNcLIkkUEpRzYkDQeEkchg26XzkyHuXq8C7A3m0iHwy8H5cKR1c2WZgmugnJIE0uaJtg0zSJi0Giw7q6ZdhTXn6Ob030eyfLrYyd+49KdSPNfcssUon63Fg0GZ6o/Ng56tp//zVW14aeU6J6ltEIbg/aKKOkCEqSHyVUojCckSXqGqLfmnvhEZ/+bbomfNbuy+U7tGLRROL6Chc5RuH6AHU0h7u403x9eCvyejdSLum4+9T6fJQC3UEQohyRJSOJw4cOnNothn9Z0k+mZ9vdA36ZrNc0jKb3R361cKOwY/LVdhSUJ3Yl+o7ZN6yXeO20nftcT0WffeHlzxHidI43roN0Crg5QRgEWhMEJilkSYt2KkrN77fCl2aB/NNsHT3T9+uOMayhOjKKNR");
                WriteLiteral(@"iBRyqwfndR64Vp7THMQvhSYZiPopvNqVRCPdwMf5XhYIE0WuiuLCJtE9Ottamsa3bBnDyWjsz94OI/dKi6qbvA+VdUoYUEptFcgX1VIo7boJvO/vKfeeXPlqe5R9dviCe00d1LaILJwCyWkSiGNENLg5Yok48lYktS+Ozblv2i6O/j4/LrBr92gXjS+R75aRXgOWIvRPQKbkoTxY5kR5/XdzmuAmEdhZsJnSROgXQchFWkakyZZRAOSv8YwpDnTptuKfhwYbiKjA8PDSlZFk3aLeMpGQ9LYRQoXkAjlERTLgJ1YZu0Pw759HU9l5xU3NBdrU/+YVBIhUtychxBkJFIZ/GKBJE6eqNLWt0efbF57402dr82t6Z3q5uqYfBXPKwMRIDBegj8SEYf1lye1woHAN3gUXTWbc5VEKAWk2CTGxgsdsFD9YWdAc3ZAlAxO4G909g8Pp7vCrBPV3ppCp76lNhInJxBag00XquoXitjJdHF7bf1XrUbyCunbT86tHCySuvYaIUBQwQ1yIOKF5aOUJj9SRlhe06q1T3jc0wqfvffCxrOm3cYXnGAG6VVwAh9UjEgdXC8gGY1JotbX+634euAMHkEqMUqphVElHcBC6/cWXjuNE3rNIVn1L5Y4F/A3WlqHh1NbTsudjn/ZyrW+tL6tBMYPEFJCRkpnfRJSuzi1tV8sitwXT6+M3rPunv5FUH+SkAIhBMaTkBFSo4MCBeOSIj4zXFmvBWPyq/W14dONWfN843vIyWVoI0AYlHHwghxpNcGmnWMGvXQFcBEPx8pJ5WiklgsJyD58FkOwliRK6LUihoNow6WKzq7gkcSOPnnmvsFHjNcoyoUPBMZzQShAoLQhKBYAuyVp49dVq1648p7ea2bu612hlFgipMiqXsD4PqggizzSlCiNC2ppun2lF60Qzd6H5tb1rvLzK0eMq5GVUaTQIB20k+AXClhLjtnO+cqqlwB38wCrVkxLx9fZAgyQxgUbQZqFTQBBEqUM+2kaefyQDejsikcUE");
                WriteLiteral(@"V+f9MznWNE5XSCcggWBXVg0CAGkC5XKlSuAfLK18z+fCN1Xz66O3j59X+/XUsvKQls6RZTrg3Sz8JA5ych4TNQZHOfL4duG09GHZu7v/CxXnhbG8zC5ACEdhE0wxhKUimQW92abPxOd9tuAO9hAry8+XJrwn+KXy0jjIZKQ9SxpmhKFcRbpzcW7whvYgM6u4NGF53ULgjU0T5+yOGBxbQ7lGKSSIByk65CvSLDpi21S/42Q9lUz94fvz74t/lRp5UingO+UUH/bIUgflRtnZFFPDzu97/Xd9ru63eTc1lzvg6WJ3t86RoN1EEbgaAcpFZA+vjEcXhw2Ol/uR/xW3c9wUBUvLVW8A4rjFdziKFJqSMXfCsTCERgNQkSSrDSPz6VsQGdXsDEMnLeyO/C4s3WyBVkCXJFD6jxIA8JBmAJBOSZN0pfESfrDQtl90903dr40fW/7RO2sAxPgKw9lDCQRoPFK44xvEXvac7/7l/KtAcqSXWt/O0nhuD281rNt2+/avs+2bdujZ9u2bd6Z6Yu57dMHVZVK8lKVnDW1pvv69/+ttVdWp7m/7STdXcizIA5BXMAQgcABBsCQFQURGhtO4wWJU725pQ9hvj+fHEZJox5vHp9ps9aGLeC1MYBlrlq5TOyaoFwDjC7DARBghKuKzVFt2/L8UBq2uosJDiYCsMCAcwbAlMLDOpqTBkab+y/sXt5x6HWbZ1z45/4h+y5cfjbjs6UV43YbjBvvCXXUJzcjarZqU6muGQQIG01nbSJ/d6MAnQMGECJEvTNWdoytmXRK5QZBVCvLKI8nwYRwX0sMBAIrVlaswGpC6RoC7CauFhr19/cWV9v7/tl9qxC8jNOAAogITiGwkoTWlIEx5vT5C1eWDz668fi9f+ttIZovewRgUzkyj84EwBvgVmneFAA0oF3icqRq/3MtyH2+VCqMIELX8FDQBoJxN38U0G7A8lWoJJMLDql1uIYAu4mrCxk03rY8168zsfzqTURoAiDTAg+FPx1i4EENrekJW");
                WriteLiteral(@"Dxu/sLl+YOOapy196/9Jg/mjmWisMjG8kSp8CSQmxuseGWHgE691TO/Gk9I1WAEYq5agFwYwiiAmBPmhIqVM0y1+eY1BNhNXDO0X2OPtdtEi8/dYAyapuj8mp4EC+LlXNDZwKG1edFl/1jqhgInzF+UfDcIF27PhXAtc6MJ8AhgNaeIlv60WXkSpFccfjVOIaMdGSx0OYiHvjSbYvUhUAhc/xIxMMEO7S3qoHrsJgZdXGXc6C6bGkbn00qmXTcSt5/32+9d3NB66UmbDICShKI6hADnZXwz0cDYJoLKsjfINE0WLtUPvGzP4MdRbfHoIK5DxAVpkVMCGLm8I8Dk/mPlFKuAiLmQ4LEjDwIO5IlwlidyezxgCGvs0DoNDgfwF3iIOiW4KjjiroceK4LopaDoYDMw3WRp8YPD3uBVhxwlnjz71yzgbOmxgCk9NW4XXVzkLEsBeJ0wsTVDnsl3ZMlKf3lOP3T+ksFPm5P9RjRuwCGcy2pZbWA8Efla1yfhrR9YCZ0Qg4VfuSdhfylkjBCFFC2G0U1RJWAQRrgyXO/6Y6eIuP7+uDNWZvw4b8Qipifoi/UpepCeeNgxweP+9te0BrZy7gbGywORULQgxCgcIoj6FKYP0wDxHSRWd+Y5LWjDGsS4i2+dOcV1Wung1ot75j/2BFAhHA7kF+bFhwC5MAhDBhmb6x/QCRpcGaRRxzUEhyhJNRBBjNbUNHhA0yuz81+cmx+cN3VIcN7cnixmfPlUxgXA4nJq5KFwyrAIQWMGG4+MWK3dPTMZGIxtnnYdJVJAqf0eAAWYkeK+MoC8dRm8SX2sC79XBfk+oBDynFDZUE2I8GBUIOwGrgzD1SGv9boIY160vY5ZClBvjQFbKSKa2zm4rNdpHkSn7d2d1okWHjZDHGACUasJzskpRBFYbRrjB0/BGFefgRxQI5c3XnntLe8tWfUCgidDVIRhDYi87OdOBATimEAFgjiuFN2l3g9EaB4QhIS41YKr5e52p95qgx3EgIC/ebC314lic");
                WriteLiteral(@"+ylFyafBOYeMmMIZDYgajbdhFaCAyIurFOJ9UqZM2qt14P5WK6IV9zHuhOHNV/rfQCMM/CAtVCBsBu4MiR9tW3x4v45Ipw7UusccaNeKkRls8HKmX9iS/HDxUukWJkG2EMvuXD4kTy/9PgZmaMxNYPaWBtcjAYo5pprRp4EPbK8EyL3eejK13uMFHXTols9HHOokOSVNxUvENRBBcJuoIqX/vxuZC8bjmJEM+PjEz/0AbjvpPauJ5t/9T6hlRJmpuOsynVJAOcCUWMck1trEEI8fn7P0kyjwU7fd2HKZTL38JnUncfVJybdRDiynNG+/BlAabeiavVCsJ6FK/mA1lG+skWFGB+CBpxRu5frmuu2ADHUBlUEQcCtvDZJkgdkMhtdO2HHwgmfvSD52PmXqME7jdJBcdIbNhoIwhCGuZaY15o2sXEwwU8C5se0Sk9duCQ1Kl861mhdDjn1yQiMH+jOvKKQ9itVXXkdK6PSLldhKjlEwxhjpZoWaFKy4ThGBLzl9/c5ut8fHF6r1eYA/AIweavVelGWZQ+wnvA8e/n4odEX71CnbTt+ceciVPJBpXW9Na1BncK1A1fGiINFY2jPAMbQfY2e/4xR8qTufJbzoHtiWF8sj6tZ2PCKGi8+xo0brR1orY7Vr68qS6WpK3vKiyfAr6506k4raW0aXasLpfS5g8HgqVrrv1plb+DbxJ9ZQnbY/TN6vd7Lqg8R3oeHfeY8/omH6gvTj0J3O4wYCgkIYN6lWRCjs2GqYPsOoPkv6X2Ds/or8hhbTW4Klbhaz6rJS7vkyMgptMbS5gCfrsJ3ij6bO8VlKUYrK6aUEmRgCKirdLL6SOoNQohzrcWPtgo/GcArYGG94Bl277527/H2BvYLAL4Ojx3dk756lvzQAy/V2SeMWZ4u2K1pXZ7kMs5BPAQLGhjbGEKEwQ2i5uI3uwsS9U4MzgGozCss9ivGgsokaCrK6MtXfmRpwH+d7xx1WopWsnIjpAFjQNogCcIWPOhPr9mCV/zuHufap");
                WriteLiteral(@"6nv5pwvWy+4+ejMLc/z+9h7+C8xxubsa4zbAvgHKjghfv9N2232mektwUHtmSZq7Wb56EGEkXNzXgd0ApX0IDONIAp93x9bidwAA7Y2jnXuXXm0wq3Q1ZzgvIhCT15lgFIDQK4iTwdIhwNkSQqlDNRQYnne2D19fwBfdBcjuUQcx9ujKDotTdM72UdI2ycmJ+4MwHDBv9xut59j915i5fPWE+4B4CJ4fDQ97VfHz++4l0nxUZ13b6iVgjEAYwyMZ75WB+C1DnidKp1tJcF5K1dDws8FFe+vtsSeGGN8zlCeKOwnIO9D5WlhwFJ0rkpRMrdCMDqch4ewH+CRh3whf4u6z/n2GdpvpJR3tHH/fAAvGFXGZrO5tXitab3kW/ZG9p4AdsPjI+b0Pz/ujx+48yWR/oIxvdu622HmyiPtn8yc0qIyvsYVa2vA+M/D7C9zRq/N8Dr3BChPlqh4igLUsLwFymUxfKVQUkKpvFQ+T6TdD/elxP8OD5H65HHeEV/7y9vkXS4oPKDf6z/XWvu3AD4Ji7AePhqAtFXhsfbV5k8ajca5AD4Pj9dMH7d05uBj95ubpZ1arT7QaFd3o4YB48L15Myf77HAuT9CpzgbNT/cCeD3i4V8TvatNLQnoaIwUkCRo8co/wBLFspbyaBKUdAFARJQOvhbALkID/rlSzejitf+8a6vsdZ+MmNsYK39oOrtrE2Kj7RJ8c1aa25D5pNhGD7LH0+bksTOpwMR5u8am6Ezx7cUj6bGUJ7Tc2GFuU4waAFizErTeYbJ18Y2qm3xKLn5YUkncJVEwpjcZ3ntSp3WhbVLxWVBQJohTzIXAplGrxdgOKi/FsBTKiHAUIW17lOVUhuSJDm12+1+ul6vHwfgy0AZ22+373S+b/ffkKbpw/Jc3qbTGTty1CdsHxwnL6BdZ8/tE/ty2Xu6ksqSIBE3m+XVeQHOUoBlfkJ0o+zakkdudecBbiUNB+X3JIwy7vJTK7v6OPceUCgv0xQqy4FcI0uAJOGJyNkOVEC/e");
                WriteLiteral(@"f7aFyJv3HsPYb1gl1XyRMZYZnNAEQLvQQVSyvsBuDWA52MdnD/56Sd2xvRrJ7ZE1JpplUNUEEcIwhgUjgHhOMBbjoD1UfGCfD8ZalDGOfJVKJm6+M5zH+s+BFLplC+sLxVMbtDrx+gOap8AcCwqoB88dyPWw7v33ie0BLx1OBye6x8zv8XK05y1rxpOb3zwpEbTvGdik6i3N7ZRH+sgrtchogYQeQJ4c91xdv3EJwHVL0kwcnWU5NyqnBfkaQqZeNfPJIw0SDKBpZVmV6/yOx343F7oZayLc1pfztDCee9cusfvrDe8zhLxGGv1uwohXmO7xJ0ANK4EO/snf+g08+HZPM8/kcvlaa00iMhVCCaAEXgNoOCKSUAO6MTngQzGK6zykeV97BfKD53rm0whzRiWezHSJXoloJ3yFQiZX7EeZ7e++qbt7D4/sQS80ibBO1sStmmt7wLgTFwFvKP/wO9dMP3pu8/Nqk+rbPnwcijaAMSMwEYurjN/uGmFWOU0CN7ymXN7lZQeoPMhlJKF63uRPuE5AnRaWF4hTRlWujH6S+ZLs/WlV2Ad0LYnBrgq+N7KacKScKKVF0dR9LUizHE1cGrj4xubNfrYxAzuMH34GMY2TSOs1cFFBIia7w5DVyKJV6Y67VpnnbgGRw4xKnUyTVy2TzJHwLBw+7wseUnC0O1GWFkO/izSrOhdZtcl4Gtn1HB1sEM9/JZCCAng17iaODH8YD3gZufYlHn4xqPG0dk4gahWA2MCJELQqEliYn/tN7kTlUDJzGf5zLl7Ge+OAJUWli+SoUYyBJaXInRX+axW5r7ufw7WB33urAb+qxHy7C2dSTx64xENjG92r0IY52DMCZg7zDTGAK6+u3hXeWl5JZ3FC+VlqbyEyfKy4RkMCIuLIfqr/G/GmIcD+B3WhyfgzDr+O8C4fFyraV654dAoHj+og7hRA+cC5JUnXxn0AQSU/XwmCw9wlk+KeM8hU43eKrPZPkQvZT8W0hzr5pYrBn3+v4UAB2LqvnGkd");
                WriteLiteral(@"k5tZlMTWxuodWpgQoBVyqKBgVYVEjwBulhTu2YKyUCjuyIsAQGSOb19akE/GsAAVwH0o7uE+O/E4hHsaEZ629iYvt3kZo7aeIwgCkDck2AMtG93R1Odkc7d5VCh1wVWugGyhM/tSVXRp2zH1QC967QI/92YEjqIIvP8KKcnjk3oemOCEDU4eOjCAaYgwHmClgp5otHvE1ZWOIZDkeWp/jD15DMAXIKrCfrcQxn+p+DiaX6dDS16cnvV3DeKzZYgNuChcbfccJdHwxRIUg45YLM1RV/7dabeeG3+mZLeeHKA/2lYvli1D93KbtMO2e2jnK4HYLJnwIzEakuLv/ZX5bfCSfkdAKu4lqDPnEr4/4x/A+GHjYuRFdySAAAAAElFTkSuQmCC"" />
                                            </defs>
                                        </svg>
                                    </div>
                                    <div class=""text main_msg"" style=""text-align: left; color: #FFFFFF;"">
                                        <p style=""margin: 0; margin-bottom: 10px; font-family: 'Graphik-thin';"">Hi, ");
#nullable restore
#line 39 "C:\Users\David\Desktop\InvoiceWithAuth\OllaInvoice\OllaInvoice\Templates\confirmemail.cshtml"
                                                                                                               Write(Model.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral(@",</p>
                                        <p style=""margin: 0; font-family: 'Graphik-thin';"">
                                            How do you plan to kick off this new month? What will you like to achieve?
                                            I have an idea! A great way you can start this month is to apply for our March 2022 cohort as applications are still open!
                                        </p>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr><!-- end tr -->
                <tr style=""position: relative;"">
                    <td class=""bg_light"" style=""text-align:center; color: #000000; position: absolute; width: 100%; top: -55px;"">
                        <table>
                            <tr>
                                <td style=""padding: 0 15px;"">
                                    <p>
                     ");
                WriteLiteral("                   <a");
                BeginWriteAttribute("href", " href=", 16141, "", 16157, 1);
#nullable restore
#line 56 "C:\Users\David\Desktop\InvoiceWithAuth\OllaInvoice\OllaInvoice\Templates\confirmemail.cshtml"
WriteAttributeValue("", 16147, Model.Url, 16147, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-primary"">Verify Email</a>
                                    </p>
                                    <p style=""margin: 0; padding-top: 30px; font-size: 18px;"">
                                        or copy and paste this link into your browser:
                                    </p>
                                    <p style=""margin: 0; font-size: 18px; color: #2C4A97; text-decoration: underline; font-family: 'Graphik';"">
                                        https://ollasystems.com
                                    </p>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr><!-- end: tr -->
                <tr>
                    <td valign=""middle"" class=""bg_light footer email-section"">
                        <table>
                            <tr>
                                <td valign=""top"" width=""33.333%"">
                                    <table role=""pr");
                WriteLiteral(@"esentation"" cellspacing=""0"" cellpadding=""0"" border=""0"" width=""100%"">
                                        <tr>
                                            <td style=""text-align: left; padding-right: 10px; color: #000000;"">
                                                <p style=""margin: 0;"">Love,</p>
                                                <p style=""margin: 0; font-family: 'Graphik';"">The Olla Systems Team</p>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td valign=""top"" width=""33.333%"">
                                    <table role=""presentation"" cellspacing=""0"" cellpadding=""0"" border=""0"" width=""100%"">
                                        <tr>
                                            <td style=""text-align: right; padding-left: 5px; padding-right: 5px;"">
                                                <img src=""./");
                WriteLiteral(@"images/Logo-main.png"" alt=""company logo"" style=""margin-top: 6px;"">
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr><!-- end tr -->
            </table>
        </div>
    </center>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OllaInvoice.AuthModels.ConfirmEmailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
