Create database codeChangeRef
drop table codeChange
Create table codeChange(
	InputCode nvarchar(10) not null,
	OrdTypeCode nvarchar(10) not null,
	DeptCode nvarchar(10) not null,
	StorageCode nvarchar(10) not null
)


Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('BWTX','B224','B01-1','B02')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('BMH','B224','B01-1','B02')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('BVR','B225','B01-2','B03')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('BFF','B225','B01-2','B03')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('BTB','B225','B01-2','B03')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('BTC','B225','B01-2','B03')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('BCB','B225','B01-2','B03')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('JMH','J222','J01-1','B02')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('AYM','Y222','Y01','Y04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('CYM','Y222','Y01','Y04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('BRJ','Y222','Y01','Y04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('PTL','Y222','Y01','Y04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('BY','Y222','Y01','Y04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('PE','Y222','Y01','Y04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('AI','Y222','Y01','Y04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('CI','Y222','Y01','Y04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('AM','Y222','Y01','Y04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('JC','P222','J01-2','P04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('A','A222','A01','A04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('C','C222','A01','A04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('E','A222','A01','A04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('P','P222','J01-2','P04')
Insert into codeChange (InputCode,OrdTypeCode,DeptCode,StorageCode) values ('Y','Y222','Y01','Y04')

select OrdTypeCode from codeChange where InputCode = 'P' or InputCode = 'P' or InputCode = 'P'
SELECT TOP 1(OrdTypeCode)
FROM  codeChange
WHERE InputCode = 'BTBA' or InputCode = 'BTB' or InputCode = 'BT' or InputCode = 'B'

