set nocount on

select distinct name into #tmpEnumRef from sys_EnumReference

declare @refName nvarchar(50), @enumValues nvarchar(max), @referenceList nvarchar(max)

set @referenceList = ''

print 'public enum ReferenceList'
print '{'
select @referenceList = @referenceList + name + ', ' from #tmpEnumRef
print @referenceList
print '}'
print ''
select top 1 @refName = name from #tmpEnumRef

while @refName is not null
begin
	print 'public enum ' + @refName
	print '{'
	
	set @enumValues = ''

	select @enumValues = @enumValues + (case when ISNUMERIC(SUBSTRING(LTRIM([description]), 1, 1)) = 1  then 
	
		'_'+ dbo.RemoveSpecialCharacters([description]) + ' = ' + cast(value as nvarchar)
		else
			dbo.RemoveSpecialCharacters([description]) + ' = ' + cast(value as nvarchar)
	end ) + ', ' from sys_EnumReference where name = @refName
	print @enumValues

	print '}'

	delete from #tmpEnumRef where name = @refName
	set @refName = null
	select top 1 @refName = name from #tmpEnumRef

end

drop table #tmpEnumRef
set nocount off

