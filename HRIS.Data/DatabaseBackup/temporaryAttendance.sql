declare @i int

set @i = 1;

while (@i <> 100)
BEGIN

	insert into ta_EmployeeAttendance (employeeId, deviceAttendanceId, workDate ,badgeNo, timeLogType, timeLog, remarks, updatedBy, updatedDate, deleted)
	SELECT        employeeId, deviceAttendanceId, CONVERT(date, timeLog+@i), badgeNo, timeLogType, timeLog+@i, remarks, updatedBy, GETDATE(), deleted
	FROM            ta_EmployeeAttendance
	WHERE        (id IN (1,2))
	set @i = @i + 1;


END

