//project.Lists["hcaptcha"].Clear(); // Очистка списка зенки. Если все будет в кубике то она не нужна


// Получаем Sitekey
string text = project.ExecuteMacro(instance.ActiveTab.DomText);
string sitekey ="";
var errorIfEmpty = false;
var regexGroups = Macros.TextProcessing.Regex(text, @"(?<=class=""h-captcha""\ data-sitekey="").*(?=""><iframe\ src="")", "0");
if (regexGroups.Count == 0)
{
    if (errorIfEmpty) throw new Exception();
}
else
{
    sitekey = regexGroups[0].FirstOrDefault();
}

//Запись трафика
instance.UseTrafficMonitoring = true;
var traffic = instance.ActiveTab.GetTraffic();

//клик по чекбоксу hcaptcha
HtmlElement he = instance.ActiveTab.FindElementById("checkbox");
if (he.IsVoid) return -1;

instance.WaitFieldEmulationDelay();
instance.ActiveTab.FullEmulationMouseMoveToHtmlElement(he);
instance.ActiveTab.FullEmulationMouseClick("left", "click");
Thread.Sleep(3000);

string hcaptchabody = "";
//получаем тело ответа от hcaptcha
foreach(var t in traffic)
    if (t.Url=="https://hcaptcha.com/getcaptcha/" + project.Variables["sitekey"].Value)
        hcaptchabody = System.Text.Encoding.UTF8.GetString(t.ResponseBody);
	
return "Ничего не нашли";

string hcaptchaQuest = "";
// Получение текста задания
var errorIfEmpty = true;
var regexGroups = Macros.TextProcessing.Regex(hcaptchabody, @"(?<=""requester_question"":\{""en"":"").*(?=""},""requester_question_example"":)", "0");
if (regexGroups.Count == 0)
{
    if (errorIfEmpty) throw new Exception();
}
else
{
    hcaptchaQuest = regexGroups[0].FirstOrDefault();
}

// Получаем изображения
//string text = project.ExecuteMacro(project.Variables["hcaptchaBody"].Value);
// Тут надо очистить список. Да и вообще было бы здорово всё в функцию загнать
var hcaptcha_base64_images = new List<string>(); 
var errorIfEmpty = false;
var regexGroups = Macros.TextProcessing.Regex(hcaptchaBody, @"(?<=datapoint_uri"":"").*?(?="")");
if (regexGroups.Count == 0)
{
    if (errorIfEmpty) throw new Exception();
}
else
{
    project.Lists["hcaptcha"].AddRange(regexGroups.Select(g => g.FirstOrDefault()));

    for (int i =0; i<words.Length; i++ )    
    {
        hcaptcha_base64_images.Add(words[i]);
    }

}

string[] words = Console.ReadLine().Replace(". ", " ").Replace(" .", " ").Replace(" ,", " ").Replace(", ", " ").Replace("  ", " ").Split(' ');
//var hcaptcha_base64_images = new List<string>(); 
// for (int i =0; i<words.Length; i++ ){
// hcaptcha_base64_images.Add(words[i]);
// }
for(int i=0;i<hcaptcha_base64_images.Count;i++)
{
Console.WriteLine(hcaptcha_base64_images[i]);
} 
hcaptcha_base64_images.Clear();
























/* Конвертируем ответ */
string text = project.Variables["respArray"].Value;
string[] array = text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
List<int> hcatpchaClicks = new List<int>();

foreach (var item in array.Select((value, i) => ( value, i )))
	if(item.value.Equals("true"))
		hcatpchaClicks.Add(item.i);

/* Конвертируем ответ */

/* */
int maxCount = hcatpchaClicks.Count();
instance.EmulationLevel = "Middle";
bool page2 = false;

HtmlElement he2 = instance.ActiveTab.FindElementByAttribute("div", "class", "button-submit\\ button", "regexp", 0);

for(int i = 0; i < maxCount; i++)
{
	int m = hcatpchaClicks[i];
	
	HtmlElement he = instance.ActiveTab.FindElementByAttribute("div", "class", "border-focus", "regexp", m);
	//he.RiseEvent("click", "Middle");
	instance.ActiveTab.FullEmulationMouseMoveToHtmlElement(he);
	instance.ActiveTab.FullEmulationMouseClick("left", "click");
	
	if (m > 8 && !page2)
	{
		//he2.RiseEvent("click", "None");
		instance.ActiveTab.FullEmulationMouseMoveToHtmlElement(he2);
	    instance.ActiveTab.FullEmulationMouseClick("left", "click");
		HtmlElement he4 = instance.ActiveTab.FindElementByAttribute("div", "class", "border-focus", "regexp", m-9);
		//he4.RiseEvent("click", "Middle");
		instance.ActiveTab.FullEmulationMouseMoveToHtmlElement(he4);
	    instance.ActiveTab.FullEmulationMouseClick("left", "click");
		page2 = true;
	}
	else if (m > 8 && page2)
	{
		HtmlElement he3 = instance.ActiveTab.FindElementByAttribute("div", "class", "border-focus", "regexp", m-9);
		//he3.RiseEvent("click", "Middle");
		instance.ActiveTab.FullEmulationMouseMoveToHtmlElement(he3);
	    instance.ActiveTab.FullEmulationMouseClick("left", "click");
	}	
}

//he2.RiseEvent("click", "None");
instance.ActiveTab.FullEmulationMouseMoveToHtmlElement(he2);
instance.ActiveTab.FullEmulationMouseClick("click", "None");
