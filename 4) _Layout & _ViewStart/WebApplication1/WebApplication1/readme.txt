<!-- 🧩 ASP.NET Core MVC Layout System Overview -->

<!-- 📁 _Layout.cshtml -->
<!-- Common layout file jisme shared UI (header, footer, navbar etc.) hota hai -->
<!-- Is layout ke andar multiple child views render hote hain -->
@RenderBody()

<!-- ⚙️ _ViewStart.cshtml -->
<!-- Ye file har child view se pehle run hoti hai -->
<!-- Iska kaam layout ko child pages se connect karna hota hai -->
@{
    Layout = "_Layout.cshtml";
}

<!-- 🎯 Specific Child ke liye Different Layout -->
<!-- Agar kisi specific child view me different layout dikhana hai -->
@{
    Layout = "~/Views/Shared/_AnotherLayout.cshtml";
}

<!-- 🚫 Specific Child me Layout Disable Karna -->
<!-- Agar kisi page me layout bilkul nahi chahiye -->
@{
    Layout = null;
}

<!-- 🧠 Conditional Layout (Dynamic Layout Selection) -->
<!-- User role ke hisaab se alag layout render karne ke liye -->
In _ViewStart.cshtml

@{
    if (User.IsInRole("Admin"))
    {
        Layout = "_AdminLayout.cshtml";
    }
    else
    {
        Layout = "_UserLayout.cshtml";
    }
}
