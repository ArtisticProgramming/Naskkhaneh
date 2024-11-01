﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Domain.AggregatesModel.BookAggregate
{
    public enum BookSize
    {
        /// <summary>
        /// وزیری
        /// </summary>
        Vaziri,
        /// <summary>
        /// رقعی
        /// </summary>
        Roghei,
        /// <summary>
        /// جیبی
        /// </summary>
        Jibi, 
        /// <summary>
        /// رحلی
        /// </summary>
        Rahli, 
        /// <summary>
        /// خشتی
        /// </summary>
        Kheshti, 
        /// <summary>
        /// پالتویی
        /// </summary>
        Paltoi, 
        /// <summary>
        /// ربعی
        /// </summary>
        Robie, 
        /// <summary>
        /// سلطانی
        /// </summary>
        Soltani, 
        /// <summary>
        /// اروپایی
        /// </summary>
        Oropaie,
        /// <summary>
        /// بیاضی
        /// </summary>
        Baiazi, 
    }
}
//. قطع وزیری
//قطع وزیری رایج‌ترین قطع چاپ کتاب است که ابعادی در حدود ۲۴×۱۷ سانتی‌متر دارد. از این قطع برای چاپ انواع کتب دانشگاهی و علمی استفاده می‌شود. از دلایل محبوبیت این قطع می‌توان به اندازه مناسب، استفاده راحت و هزینه مقرون‌به‌صرفه اشاره کرد.

//۲. قطع رقعی
//قطع رقعی از قطع وزیری کوچکتر است، ابعاد این قطع ۲۱×۱۴ سانتی‌متر است. این ابعاد برای چاپ انواع کتاب با نسبت متن بیشتر به تصویر مناسب است.
//از طرف دیگر حمل کتاب در ابعاد قطع رقعی راحت است و می‌توان به‌آسانی کتاب‌های چاپ شده در این قطع را در دست گرفت و مورد مطالعه قرار داد.

//۳. قطع جیبی
//قطع جیبی همان‌طور که از نامش پیداست، برای چاپ کتاب‌هایی به کار می‌رود که سایز کوچکی دارند. کتاب‌های قطع جیبی حدود ۱۵×۱۱ سانتی‌متر هستند. بنابراین خواننده قادر است روزانه آن‌ها را با خود حمل نماید.
//صفحه‌بندی این کتاب‌ها با قلم ریزتر و فاصله خطوط کمتر انجام می‌شود. کتاب‌های جیبی درعین‌حال که دارای وزن سبک و حمل آسان می‌باشند، ظاهری کابردی و جذاب دارند.

//۴. قطع رحلی
//ممکن است نام رحلی کوچک، متوسط و بزرگ را شنیده باشید، زیرا این قطع، خود دارای سه سایز متنوع است.
//از این قطع بیشتر جهت چاپ مجله و برخی کتاب‌های آموزشی، پایان‌نامه و … استفاده می‌شود. متن کتاب‌ها در قطع رحلی، در ابعاد A4 تعریف شده و این کتاب‌ها معمولا با ابعاد ۲۹×۲۲ و ۲۹×۲۱ و ۲۸.۵×۲۱ سانتی‌متری صحافی و چاپ می‌شوند.

//۵. قطع خشتی
//قطع خشتی به کتاب‌های مربع شکل گفته می‌شود، که بنا به درخواست مشتری و امکانات چاپخانه‌ها، ابعاد متغیری دارد.
//معمولا از این نوع قطع کتاب، برای چاپ داستان کودکان و کتاب‌های هنری استفاده می‌شود. به‌طور کلی سایز کتاب خشتی بزرگ ۲۲×۲۲ بوده و سایز قطع خشتی کوچک ۱۹×۱۹ است.
// نکته قابل توجه این است که، به دلیل مربع بودن این نوع کتاب‌ها، ظرافت و تمیزی کار نهایی بسیار قابل توجه بوده و لازم است طراحی ابتدایی صفحات نیز به بهترین شکل ممکن انجام شود.

//۶. قطع پالتویی
//کتاب‌های پالتویی دارای دو قطع ۱۰×۱۹ سانتی‌متر یا ۲۲×۱۱.۵ سانتی‌متر هستند.
//همانطور که از اسم این نوع قطع پیداست، این کتاب‌ها برای حمل آسان طراحی شده‌اند تا بتوان آن‌ها را در جیب پالتو حمل کرد.
//بسیاری از سررسیدهای خاص و کتاب‌های داستانی در این قطع چاپ می‌شوند تا بتوانید در هر شرایطی کتابی برای مطالعه همراه داشته باشید.

//۷. قطع ربعی
//کتاب‌های قطع ربعی ابعادی حدود ۱۶.۵×۱۲ سانتی‌متر دارند. برای چاپ این نوع کتاب از کاغذهایی در ابعاد کاغذ B6 استفاده می‌کنند. بسیاری از دفترچه‌های یادداشت روزانه و یا کتاب‌های آموزشی مبتنی بر عکس برای کودکان در این قالب چاپ می‌شوند.

//۸. قطع سلطانی
//قطع سلطانی که به قطع تیموری نیز معروف است، حاصل دوبار تا زدن متوالی کاغذهای B است. کاغذ B ابعادی حدود ۱۰۰×۷۰ سانتیمتر دارد و با دو بار تا زدن این کاغذ به ابعادی حدود ۳۵×۵۰  سانتی‌متر می‌رسیم که در صحافی و با برش مناسب در نهایت کتاب با ابعاد ۴۹×۳۴ سانتی‌متر چاپ می‌شود.
//قطع سلطانی برای چاپ کتاب‌های بسیار نفیس، انواع قرآن، کتاب‌های کلکسیونی و … مورد استفاده قرار می‌گیرد.
//برای مثال شاهنامه نفیس بایسنقری در ابعاد سلطانی یا تیموری موجود است.

//۹. قطع اروپایی
//کتاب‌های قطع اروپایی در ابعاد ۱۲×۲۱ سانتی‌متر چاپ می‌شوند. این قطع علاوه بر چاپ کتاب، در چاپ سررسید نیز کاربرد دارد و به‌دلیل ابعاد مناسب و خوش‌دستی از محبوبیت بالایی برخوردار است.

//۱۰. قطع بیاضی
//صفحه‌‌آرایی و صحافی کتاب‌های قطع بیاضی با سایر کتاب‌ها متفاوت است. عطف کتاب در قطع بیاضی در بخش عرضی قرار گرفته است. ابعاد کتاب‌های قطع بیاضی حدود ۳۴×۲۴ سانتیمتر است.