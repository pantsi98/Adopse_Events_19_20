#drop procedure enventDb.insertData;

Delimiter $$
create procedure InsertData ()
begin
	DECLARE JSON VARCHAR(20000);
	SELECT @JSON = BulkColumn
	FROM OPENROWSET(BULK 'C:\Users\James\Documents\GitHub\Adopse_Events_19_20\Data\Dataset\performingArts.json', SINGLE_CLOB)
	AS j
end; 
end$$

call InsertData();