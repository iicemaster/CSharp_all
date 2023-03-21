// int count = 5;
// for (int i=0; i<count; i++)
//     Dictionary<string, string> dict = new Dictionary<string, string>
//     {
//         ["Hello"]= "Привет",
//         ["How are you?"] = "Как дела?",
//         ["Bye"] = "Пока",
//     };

// for (int i=0; i<dict.Count; i++)   
//     {Console.WriteLine(dict[i]);}

// var hcaptcha_base64_list = new List<string>();
// string testim = "govno, mocha, parasha";
// var result = Macros.TextProcessing.Regex(hcaptchaBody, @",");



// hcaptcha_base64.Add("January");
// hcaptcha_base64.Add("February");
// hcaptcha_base64.Add("March");
// hcaptcha_base64.Add("April");

// for(int i=0;i<hcaptcha_base64.Count;i++)
// {
// Console.WriteLine(hcaptcha_base64[i]);
// } 

// string[] words = Console.ReadLine().Replace(". ", " ").Replace(" .", " ").Replace(" ,", " ").Replace(", ", " ").Replace("  ", " ").Split(' '); 
// Console.WriteLine(words[2]);
// // в конечном итоге можно вводить элементы в удобном для пользователя варианте. в т.ч. даже если разделители будут разные
// // for (int i = 0; i<words.Length; i++)
// // {if (Convert.ToInt32(words[i]) > 0) {count += 1;}}

// Console.WriteLine(words[2]);
// Array.Clear(words, 0, words.Length);
// words = new string [];
// Console.WriteLine(words[2]);

string[] words = Console.ReadLine().Replace(". ", " ").Replace(" .", " ").Replace(" ,", " ").Replace(", ", " ").Replace("  ", " ").Split(' ');
var hcaptcha_base64_images = new List<string>(); 
for (int i =0; i<words.Length; i++ ){
hcaptcha_base64_images.Add(words[i]);
}
for(int i=0;i<hcaptcha_base64_images.Count;i++)
{
Console.WriteLine(hcaptcha_base64_images[i]);
} 
hcaptcha_base64_images.Clear(); // очистка списка, проверено работает. 
/*for(int i=0;i<hcaptcha_base64_images.Count;i++)
{
Console.WriteLine(hcaptcha_base64_images[i]);
} */


// for (int i=0; i<dict.Length; i++)   
//     {Console.WriteLine(dict[i]);}
// foreach (var Key in dict)
//     Console.WriteLine(dict[Key.Value]);
	//accessNumbers[phone.Value] = true;


// // Допустим используем словарь для хранения номеров, но помним, 
// // что ключ должен быть уникальным, иначе мы получим ошибку уникальных
// // значений.
// Dictionary<string, long> phones = new Dictionary<string, long> {
// 	{ "Вася", 81112223344 },
//   { "Петя", 82224445566 },
//   { "Стёпа", 83335556677 }
// };

// // Допустим у нас есть метод отправки смс по номеру
// void SendSMS(long phone, string msg)
// {
// 	// todo
// }

// // Допустим мы хотим стёпе отправить смс, получаем его номер по имени
// SendSMS(phones["Стёпа"], "Привет, как дела?");
// // Допустим мы получили ответное смс
// var sms = GetSMS(phones["Стёпа"], "Привет, всё ок, а у тебя?");
// // Воспользуемся методом, который позволит определить от кого смс и что пишет
// Console.WriteLine($"{WhoSendSMS(sms.phone)} - {sms.msg}" );
// Console.WriteLine();
// sms = GetSMS(81111111111, "Здравствуйте вам одобрена...");
// // Получим смс от кого-то ещё)
// Console.WriteLine($"{WhoSendSMS(sms.phone)} - {sms.msg}");
// Console.WriteLine();

// // Допустим нам не понравился этот номер и мы не хотим больше от него получать смс
// // создадим ещё один словарь, с помощью него будем блокировать номера телефонов
// // и добавим туда наш новый номер с флагом false
// Dictionary<long, bool> accessNumbers = new Dictionary<long, bool>
// {
// 	{ 81111111111, false }
// };

// // Также добавим туда все номера из нашей записной книжки с флагом true
// foreach (var phone in phones)
// 	accessNumbers[phone.Value] = true;
// // Попробуем снова получить СМС
// var newSms = GetSMSWithAccess(81111111111, "Здравствуйте вам одобрена...");
// // Поскольку теперь нам может прийти null нужно проверить есть ли действительно 
// // смс
// if (newSms != null)
// 	Console.WriteLine($"{WhoSendSMS(newSms.phone)} - {newSms.msg}");
// else
// 	Console.WriteLine($"Пришла СМС от заблокированного номера.");
// Console.WriteLine();
// // Ну и проверим сообщение от Васи например
// newSms = GetSMSWithAccess(phones["Вася"], "Привет");
// if (newSms != null)
// 	Console.WriteLine($"{WhoSendSMS(newSms.phone)} - {newSms.msg}");
// Console.WriteLine();
// // Допустим хотим посмотреть все номера в нашей записной книжке
// Console.WriteLine($"Всего номеров в записной книжке: {phones.Count}");
// foreach (var phone in phones)
// 	Console.WriteLine($"{phone.Key} - {phone.Value}");
// // Допустим мы видим, что у нас записан Петя, с которым давно
// // не общались и хотим удалить его номер
// Console.WriteLine();
// phones.Remove("Петя");
// Console.WriteLine($"Всего номеров в записной книжке: {phones.Count}");
// // Проверим снова телефонную книгу
// foreach (var phone in phones)
// 	Console.WriteLine($"{phone.Key} - {phone.Value}");
// Console.WriteLine();
// // Как насчёт информации о доступных номерах?
// Console.WriteLine($"Всего записей в коллекции с доступными номерами: {accessNumbers.Count}");
// foreach (var phone in accessNumbers)
//     Console.WriteLine($"От номера {phone.Key} получать смс {(phone.Value ? "можно" : "нельзя")}.");

// // Допустим есть метод, который возвращает нам текст сообщения и номер телефона
// SMSInfo GetSMS(long phone, string msg)
// {
// 	return new SMSInfo { phone = phone, msg = msg };
// }
// SMSInfo? GetSMSWithAccess(long phone, string msg)
// {
// 	if (accessNumbers[phone])
// 		return new SMSInfo { phone = phone, msg = msg };
// 	return null;
// }

// // А теперь попробуем найти обратно, кому же принадлежит номер
// string WhoSendSMS(long phone)
// {
// 	// Переберём все значения в словаре и найдём имя отправителя
// 	foreach (var phoneInfo in phones)
// 	{
// 		if (phoneInfo.Value == phone)
// 			return phoneInfo.Key;
// 	}
// 	return "Номер отсутствует в записной книжке!";
// }

// // Для следующего примера создадим специальный класс
// class SMSInfo
// {
// 	public long phone { get; set; }
// 	public string msg { get; set; }
// }