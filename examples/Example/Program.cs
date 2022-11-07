using Khai;
using System.Diagnostics;

using var client = new KhaiClient();

// https://education.khai.edu/union/schedule/student/kuzmichov-i-i
var studentSchedule = await client.GetStudentWeekSheduleAsync("kuzmichov-i-i");

// https://education.khai.edu/union/schedule/lecturer/abramov-k-d-504
var lecturerSchedule = await client.GetLecturerWeekSheduleAsync("abramov-k-d-504");

// https://education.khai.edu/union/schedule/group/623p
var groupSchedule    = await client.GetGroupWeekSheduleAsync("623p");

Debugger.Break();
