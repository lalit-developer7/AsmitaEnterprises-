using System;
using System.Web;

namespace AsmitaEnterprises.Services;

public class WhatsAppService
{
    private const string PhoneRaw = "919834555868";

    public string FormatWhatsAppUrl(string message)
    {
        var encoded = Uri.EscapeDataString(message);
        return $"https://wa.me/{PhoneRaw}?text={encoded}";
    }

    public string GetFreeDemoUrl(string lang = "en")
    {
        string message = lang switch
        {
            "mr" => "नमस्कार अस्मिता एंटरप्रायजेस, मला मोफत वॉटर फिल्टर प्रात्यक्षिक (डेमो) बुक करायचे आहे. कृपया माझ्याशी संपर्क साधा.",
            "hi" => "नमस्ते अस्मिता एंटरप्राइजेज, मैं एक मुफ्त वॉटर फ़िल्टर डेमो बुक करना चाहता हूँ। कृपया मुझसे संपर्क करें।",
            _ => "Hello Asmita Enterprises, I would like to book a free water filter demo. Please contact me."
        };
        return FormatWhatsAppUrl(message);
    }

    public string GetProductEnquiryUrl(string productName, string lang = "en")
    {
        string message = lang switch
        {
            "mr" => $"नमस्कार अस्मिता एंटरप्रायजेस, मला तुमच्या {productName} मध्ये रस आहे. कृपया माहिती आणि किंमत सांगा.",
            "hi" => $"नमस्ते अस्मिता एंटरप्राइजेज, मुझे आपके {productName} में रुचि है। कृपया विवरण और मूल्य साझा करें।",
            _ => $"Hello Asmita Enterprises, I am interested in your {productName}. Please share the details and price."
        };
        return FormatWhatsAppUrl(message);
    }

    public string GetServiceEnquiryUrl(string serviceName, string lang = "en")
    {
        string message = lang switch
        {
            "mr" => $"नमस्कार अस्मिता एंटरप्रायजेस, मला वॉटर प्युरीफायर सेवा ({serviceName}) हवी आहे. कृपया माझ्याशी संपर्क साधा.",
            "hi" => $"नमस्ते अस्मिता एंटरप्राइजेज, मुझे वॉटर प्यूरीफायर सर्विस ({serviceName}) की आवश्यकता है। कृपया मुझसे संपर्क करें।",
            _ => $"Hello Asmita Enterprises, I need water purifier service ({serviceName}). Please contact me."
        };
        return FormatWhatsAppUrl(message);
    }

    public string GetGeneralEnquiryUrl(string lang = "en")
    {
        string message = lang switch
        {
            "mr" => "नमस्कार अस्मिता एंटरप्रायजेस, मला तुमच्या वॉटर फिल्टर सोल्यूशन्सबद्दल अधिक जाणून घ्यायचे आहे.",
            "hi" => "नमस्ते अस्मिता एंटरप्राइजेज, मैं आपके वॉटर फ़िल्टर समाधानों के बारे में अधिक जानना चाहता हूँ।",
            _ => "Hello Asmita Enterprises, I would like to know more about your water filter solutions."
        };
        return FormatWhatsAppUrl(message);
    }
}
