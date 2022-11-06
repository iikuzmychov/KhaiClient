using KhaiApiClient;

var client   = new KhaiClient();
var schedule = await client.GetStudentWeekSheduleAsync("kuzmichov-i-i");
