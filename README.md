# KhaiClient
Client for https://education.khai.edu to get schedule.

## How to use?

First of all, you must initialize the client:
```cs
var client = new KhaiClient();
```

After that you can get a schedule for a student, lecturer, or room as follow:
```cs
var studentSchedule  = await client.GetStudentWeekSheduleAsync("student-id");
var lecturerSchedule = await client.GetLecturerWeekSheduleAsync("lekturer-id");
var groupSchedule    = await client.GetGroupWeekSheduleAsync("group-id");
```

## How to get IDs?

When you select student/lecturer/room on the website, the URL is changed. The last part of the URL is the ID that you need.

![image](https://user-images.githubusercontent.com/37931581/200339392-c8d02596-3796-4c96-b85f-8299b4f5fe25.png)

![image](https://user-images.githubusercontent.com/37931581/200339916-450810be-7fcc-4eaa-a82f-803753a0d144.png)


