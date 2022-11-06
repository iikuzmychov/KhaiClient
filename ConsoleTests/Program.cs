using Khai;
using System.Diagnostics;

var client = new KhaiClient();

var studentSchedule  = await client.GetStudentWeekSheduleAsync("kuzmichov-i-i");
var lecturerSchedule = await client.GetLecturerWeekSheduleAsync("abramov-k-d-504");
var groupSchedule    = await client.GetGroupWeekSheduleAsync("623p");

Debugger.Break();