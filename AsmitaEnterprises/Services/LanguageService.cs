using System;
using System.Collections.Generic;

namespace AsmitaEnterprises.Services;

public class LanguageService
{
    public string CurrentLanguage { get; private set; } = "en"; // "en", "mr", "hi"

    public event Action? OnLanguageChanged;

    public void SetLanguage(string langCode)
    {
        if (langCode == "en" || langCode == "mr" || langCode == "hi")
        {
            if (CurrentLanguage != langCode)
            {
                CurrentLanguage = langCode;
                OnLanguageChanged?.Invoke();
            }
        }
    }

    public string GetText(string key)
    {
        if (_translations.TryGetValue(key, out var dict))
        {
            if (dict.TryGetValue(CurrentLanguage, out var text))
            {
                return text;
            }
            if (dict.TryGetValue("en", out var fallback))
            {
                return fallback;
            }
        }
        return key;
    }

    private readonly Dictionary<string, Dictionary<string, string>> _translations = new()
    {
        // Navigation & Header
        ["Nav_Home"] = new() { ["en"] = "Home", ["mr"] = "मुख्य पृष्ठ", ["hi"] = "होम" },
        ["Nav_Products"] = new() { ["en"] = "Products", ["mr"] = "उत्पादने", ["hi"] = "उत्पाद" },
        ["Nav_Services"] = new() { ["en"] = "Services", ["mr"] = "सेवा", ["hi"] = "सेवाएं" },
        ["Nav_WhyUs"] = new() { ["en"] = "Why Us", ["mr"] = "आम्हीच का", ["hi"] = "हम क्यों" },
        ["Nav_Reviews"] = new() { ["en"] = "Reviews", ["mr"] = "प्रतिक्रिया", ["hi"] = "समीक्षाएं" },
        ["Nav_Contact"] = new() { ["en"] = "Contact", ["mr"] = "संपर्क", ["hi"] = "संपर्क" },
        ["CTA_CallNow"] = new() { ["en"] = "Call Now", ["mr"] = "आत्ताच कॉल करा", ["hi"] = "अभी कॉल करें" },
        ["CTA_WhatsApp"] = new() { ["en"] = "WhatsApp", ["mr"] = "व्हाट्सॲप", ["hi"] = "व्हाट्सएप" },
        ["CTA_FreeDemo"] = new() { ["en"] = "Free Demo", ["mr"] = "मोफत डेमो", ["hi"] = "मुफ्त डेमो" },

        // Hero Section
        ["Hero_Title_Line1"] = new() { ["en"] = "PURE WATER.", ["mr"] = "शुद्ध पाणी.", ["hi"] = "शुद्ध पानी।" },
        ["Hero_Title_Line2"] = new() { ["en"] = "BETTER HEALTH.", ["mr"] = "उत्तम आरोग्य.", ["hi"] = "बेहतर स्वास्थ्य।" },
        ["Hero_Subtitle"] = new() { ["en"] = "Quality Water Filter Solutions at Your Budget", ["mr"] = "तुमच्या बजेटमध्ये दर्जेदार वॉटर फिल्टर सोल्यूशन्स", ["hi"] = "आपके बजट में गुणवत्तापूर्ण वॉटर फ़िल्टर समाधान" },
        ["Hero_Point1"] = new() { ["en"] = "We Assemble Any Type of Water Filters", ["mr"] = "आम्ही कोणत्याही प्रकारचे वॉटर फिल्टर असेंबल करतो", ["hi"] = "हम किसी भी प्रकार के वॉटर फ़िल्टर असेंबल करते हैं" },
        ["Hero_Point2"] = new() { ["en"] = "1 Year Warranty with Free Servicing", ["mr"] = "१ वर्षाची वॉरंटी आणि मोफत सर्व्हिसिंग", ["hi"] = "1 साल की वारंटी और मुफ्त सर्विसिंग" },
        ["Hero_Point3"] = new() { ["en"] = "Home Delivery in Pune Location", ["mr"] = "पुणे परिसरात होम डिलिव्हरी उपलब्ध", ["hi"] = "पुणे स्थान पर होम डिलीवरी उपलब्ध" },
        ["Hero_Point4"] = new() { ["en"] = "24/7 Customer Support Available", ["mr"] = "२४/७ ग्राहक सेवा उपलब्ध", ["hi"] = "24/7 ग्राहक सहायता उपलब्ध" },

        // Stats Strip
        ["Stat_ProductsDelivered"] = new() { ["en"] = "Products Delivered", ["mr"] = "उत्पादने वितरीत", ["hi"] = "उत्पाद डिलीवर किए" },
        ["Stat_GoogleRating"] = new() { ["en"] = "Google Rating", ["mr"] = "गूगल रेटिंग", ["hi"] = "गूगल रेटिंग" },
        ["Stat_CustomerSatisfaction"] = new() { ["en"] = "Customer Satisfaction", ["mr"] = "ग्राहक समाधान", ["hi"] = "ग्राहक संतुष्टि" },
        ["Stat_ServiceLocation"] = new() { ["en"] = "Serving Pune & Pimpri-Chinchwad", ["mr"] = "पुणे आणि पिंपरी-चिंचवडमध्ये सेवारत", ["hi"] = "पुणे और पिंपरी-चिंचवड़ में कार्यरत" },

        // Products Section
        ["Products_Heading"] = new() { ["en"] = "OUR PRODUCTS", ["mr"] = "आमची उत्पादने", ["hi"] = "हमारे उत्पाद" },
        ["Product_RO_Title"] = new() { ["en"] = "RO Water Purifier", ["mr"] = "आरओ वॉटर प्युरीफायर", ["hi"] = "आरओ वॉटर प्यूरीफायर" },
        ["Product_RO_Desc"] = new() { ["en"] = "Advanced RO technology to give you pure & safe drinking water.", ["mr"] = "तुम्हाला शुद्ध आणि सुरक्षित पिण्याचे पाणी देण्यासाठी प्रगत आरओ तंत्रज्ञान.", ["hi"] = "आपको शुद्ध और सुरक्षित पीने का पानी देने के लिए उन्नत आरओ तकनीक।" },
        
        ["Product_RO_UV_Title"] = new() { ["en"] = "RO + UV", ["mr"] = "आरओ + यूव्ही", ["hi"] = "आरओ + यूवी" },
        ["Product_RO_UV_Desc"] = new() { ["en"] = "RO + UV purification for extra protection and better health.", ["mr"] = "अतिरिक्त संरक्षण आणि चांगल्या आरोग्यासाठी RO + UV शुद्धीकरण.", ["hi"] = "अतिरिक्त सुरक्षा और बेहतर स्वास्थ्य के लिए RO + UV शुद्धीकरण।" },
        
        ["Product_RO_UV_UF_Title"] = new() { ["en"] = "RO + UV + UF", ["mr"] = "आरओ + यूव्ही + यूएफ", ["hi"] = "आरओ + यूवी + यूएफ" },
        ["Product_RO_UV_UF_Desc"] = new() { ["en"] = "Complete protection with RO + UV + UF for your family's health.", ["mr"] = "तुमच्या कुटुंबाच्या आरोग्यासाठी RO + UV + UF सह संपूर्ण संरक्षण.", ["hi"] = "आपके परिवार के स्वास्थ्य के लिए RO + UV + UF के साथ पूर्ण सुरक्षा।" },
        
        ["Product_Comm_Title"] = new() { ["en"] = "Commercial RO Systems", ["mr"] = "कमर्शियल आरओ सिस्टीम", ["hi"] = "कमर्शियल आरओ सिस्टम" },
        ["Product_Comm_Desc"] = new() { ["en"] = "High performance systems for offices, institutions & industries.", ["mr"] = "कार्यालये, संस्था आणि उद्योगांसाठी उच्च कार्यक्षमता प्रणाली.", ["hi"] = "कार्यालयों, संस्थानों और उद्योगों के लिए उच्च प्रदर्शन प्रणाली।" },
        
        ["Product_Custom_Title"] = new() { ["en"] = "Customized Water Filter Assembly", ["mr"] = "कस्टम वॉटर फिल्टर असेंब्ली", ["hi"] = "कस्टम वॉटर फ़िल्टर असेंबली" },
        ["Product_Custom_Desc"] = new() { ["en"] = "We assemble filters as per your requirement and budget.", ["mr"] = "आम्ही तुमच्या गरजेनुसार आणि बजेटनुसार फिल्टर असेंबल करतो.", ["hi"] = "हम आपकी आवश्यकता और बजट के अनुसार फ़िल्टर असेंबल करते हैं।" },
        ["CTA_EnquireNow"] = new() { ["en"] = "Enquire Now", ["mr"] = "चौकशी करा", ["hi"] = "पूछताछ करें" },

        // Services Section
        ["Services_Heading"] = new() { ["en"] = "OUR SERVICES", ["mr"] = "आमच्या सेवा", ["hi"] = "हमारी सेवाएं" },
        ["Svc_Install_Title"] = new() { ["en"] = "Installation", ["mr"] = "इन्स्टॉलेशन", ["hi"] = "इंस्टॉलेशन" },
        ["Svc_Install_Desc"] = new() { ["en"] = "Professional installation at your location.", ["mr"] = "तुमच्या ठिकाणी व्यावसायिक इन्स्टॉलेशन.", ["hi"] = "आपके स्थान पर पेशेवर इंस्टॉलेशन।" },

        ["Svc_Servicing_Title"] = new() { ["en"] = "Servicing", ["mr"] = "सर्व्हिसिंग", ["hi"] = "सर्विसिंग" },
        ["Svc_Servicing_Desc"] = new() { ["en"] = "Regular servicing for better performance.", ["mr"] = "उत्तम कामगिरीसाठी नियमित सर्व्हिसिंग.", ["hi"] = "बेहतर प्रदर्शन के लिए नियमित सर्विसिंग।" },

        ["Svc_Filter_Title"] = new() { ["en"] = "Filter Replacement", ["mr"] = "फिल्टर रिप्लेसमेंट", ["hi"] = "फ़िल्टर रिप्लेसमेंट" },
        ["Svc_Filter_Desc"] = new() { ["en"] = "Genuine filters with best quality.", ["mr"] = "सर्वोत्तम गुणवत्तेसह मूळ फिल्टर.", ["hi"] = "उत्कृष्ट गुणवत्ता के साथ असली फ़िल्टर।" },

        ["Svc_Repair_Title"] = new() { ["en"] = "Repair", ["mr"] = "रिपेअरिंग", ["hi"] = "रिपेयरिंग" },
        ["Svc_Repair_Desc"] = new() { ["en"] = "All types of repair services.", ["mr"] = "सर्व प्रकारच्या दुरुस्ती सेवा.", ["hi"] = "सभी प्रकार की मरम्मत सेवाएं।" },

        ["Svc_AMC_Title"] = new() { ["en"] = "AMC / Maintenance", ["mr"] = "एएमसी / देखभाल", ["hi"] = "एएमसी / रखरखाव" },
        ["Svc_AMC_Desc"] = new() { ["en"] = "Annual maintenance contracts available.", ["mr"] = "वार्षिक देखभाल करार उपलब्ध.", ["hi"] = "वार्षिक रखरखाव अनुबंध उपलब्ध।" },

        ["Svc_Assembly_Title"] = new() { ["en"] = "Custom Assembly", ["mr"] = "कस्टम असेंब्ली", ["hi"] = "कस्टम असेंबली" },
        ["Svc_Assembly_Desc"] = new() { ["en"] = "Assembly as per your water & budget.", ["mr"] = "तुमच्या पाण्यानुसार आणि बजेटनुसार असेंब्ली.", ["hi"] = "आपके पानी और बजट के अनुसार असेंबली।" },
        ["CTA_BookService"] = new() { ["en"] = "Book Service", ["mr"] = "सर्व्हिस बुक करा", ["hi"] = "सर्विस बुक करें" },

        // Demo Section
        ["Demo_Heading"] = new() { ["en"] = "FREE WATER FILTER DEMO", ["mr"] = "मोफत वॉटर फिल्टर डेमो", ["hi"] = "मुफ्त वॉटर फ़िल्टर डेमो" },
        ["Demo_Question"] = new() { ["en"] = "Confused about which water filter is right for your home?", ["mr"] = "तुमच्या घरासाठी कोणता वॉटर फिल्टर योग्य आहे याबद्दल गोंधळात आहात?", ["hi"] = "आपके घर के लिए कौन सा वॉटर फ़िल्टर सही है, इसे लेकर उलझन में हैं?" },
        ["Demo_Subtext1"] = new() { ["en"] = "Get a FREE demo at your place in Pune.", ["mr"] = "पुण्यात तुमच्या ठिकाणी मोफत प्रात्यक्षिक (डेमो) मिळवा.", ["hi"] = "पुणे में अपने स्थान पर मुफ्त डेमो प्राप्त करें।" },
        ["Demo_Subtext2"] = new() { ["en"] = "Let's decide your water filter according to your water, requirement and budget.", ["mr"] = "तुमचे पाणी, गरज आणि बजेटनुसार वॉटर फिल्टर ठरवूया.", ["hi"] = "आइए आपके पानी, आवश्यकता और बजट के अनुसार आपका वॉटर फ़िल्टर तय करें।" },
        ["CTA_BookFreeDemo"] = new() { ["en"] = "Book Free Demo", ["mr"] = "मोफत डेमो बुक करा", ["hi"] = "मुफ्त डेमो बुक करें" },

        // Service Area
        ["Area_Heading"] = new() { ["en"] = "SERVICE AREA", ["mr"] = "सेवा क्षेत्र", ["hi"] = "सेवा क्षेत्र" },
        ["Area_Local_Title"] = new() { ["en"] = "Pune & Pimpri-Chinchwad", ["mr"] = "पुणे आणि पिंपरी-चिंचवड", ["hi"] = "पुणे और पिंपरी-चिंचवड़" },
        ["Area_Local_Point1"] = new() { ["en"] = "Home Delivery Available", ["mr"] = "होम डिलिव्हरी उपलब्ध", ["hi"] = "होम डिलीवरी उपलब्ध" },
        ["Area_Local_Point2"] = new() { ["en"] = "Cash on Delivery", ["mr"] = "कॅश ऑन डिलिव्हरी उपलब्ध", ["hi"] = "कैश ऑन डिलीवरी उपलब्ध" },
        ["Area_Local_Point3"] = new() { ["en"] = "Installation & Servicing", ["mr"] = "इन्स्टॉलेशन आणि सर्व्हिसिंग", ["hi"] = "इंस्टॉलेशन और सर्विसिंग" },

        ["Area_Other_Title"] = new() { ["en"] = "Other Cities", ["mr"] = "इतर शहरे", ["hi"] = "अन्य शहर" },
        ["Area_Other_Point1"] = new() { ["en"] = "Products delivered through courier", ["mr"] = "कूरियरद्वारे उत्पादने वितरीत केली जातात", ["hi"] = "कोरियर के माध्यम से उत्पाद वितरित" },
        ["Area_Other_Point2"] = new() { ["en"] = "Online payment available", ["mr"] = "ऑनलाईन पेमेंट पर्याय उपलब्ध", ["hi"] = "ऑनलाइन भुगतान उपलब्ध" },

        // Reviews
        ["Reviews_Heading"] = new() { ["en"] = "WHAT OUR CUSTOMERS SAY", ["mr"] = "आमचे ग्राहक काय म्हणतात", ["hi"] = "हमारे ग्राहक क्या कहते हैं" },
        ["CTA_ViewAllReviews"] = new() { ["en"] = "View All Reviews", ["mr"] = "सर्व रिव्ह्यू पहा", ["hi"] = "सभी समीक्षाएं देखें" },

        // Contact Section
        ["Contact_Heading"] = new() { ["en"] = "CONTACT US", ["mr"] = "संपर्क करा", ["hi"] = "संपर्क करें" },
        ["Contact_OfficeHeading"] = new() { ["en"] = "OUR OFFICE", ["mr"] = "आमचे कार्यालय", ["hi"] = "हमारा कार्यालय" },
        ["Contact_OwnerLabel"] = new() { ["en"] = "Owner", ["mr"] = "मा मालक", ["hi"] = "मालिक" },
        ["CTA_GetDirections"] = new() { ["en"] = "View on Map", ["mr"] = "नकाशावर पहा", ["hi"] = "मानचित्र पर देखें" },

        // Footer
        ["Footer_FollowUs"] = new() { ["en"] = "FOLLOW US", ["mr"] = "फॉलो करा", ["hi"] = "फॉलो करें" },
        ["Footer_Badge_Delivery"] = new() { ["en"] = "Home Delivery in Pune", ["mr"] = "पुण्यात होम डिलिव्हरी", ["hi"] = "पुणे में होम डिलीवरी" },
        ["Footer_Badge_Online"] = new() { ["en"] = "Online Payment Accepted", ["mr"] = "ऑनलाइन पेमेंट स्विकारले जाते", ["hi"] = "ऑनलाइन भुगतान स्वीकार्य" },
        ["Footer_Badge_COD"] = new() { ["en"] = "Cash on Delivery in Pune", ["mr"] = "पुण्यात कॅश ऑन डिलिव्हरी", ["hi"] = "पुणे में कैश ऑन डिलीवरी" },
        ["Footer_Terms"] = new() { ["en"] = "Terms & Conditions", ["mr"] = "अटी आणि शर्ती", ["hi"] = "नियम और शर्तें" },
        ["Footer_Privacy"] = new() { ["en"] = "Privacy Policy", ["mr"] = "गोपनीयता धोरण", ["hi"] = "गोपनीयता नीति" },
        ["Footer_Copyright"] = new() { ["en"] = "© 2026 Asmita Enterprises. All Rights Reserved.", ["mr"] = "© २०२६ अस्मिता एंटरप्रायजेस. सर्व हक्क सुरक्षित.", ["hi"] = "© 2026 अस्मिता एंटरप्राइजेज। सर्वाधिकार सुरक्षित।" }
    };
}
