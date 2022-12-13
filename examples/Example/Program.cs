using Khai;
using System.Diagnostics;

using var client = new KhaiClient();

// https://education.khai.edu/union/schedule/student/kuzmichov-i-i
var studentSchedule = await client.GetStudentWeekScheduleAsync("kuzmichov-i-i");

// https://education.khai.edu/union/schedule/lecturer/abramov-k-d-504
var lecturerSchedule = await client.GetLecturerWeekScheduleAsync("abramov-k-d-504");

// https://education.khai.edu/union/schedule/group/525v
var groupSchedule = await client.GetGroupWeekScheduleAsync("525v");

Debugger.Break();
