use lb_testdb;
use master;
create database lb_TestDB;
use master;

select *from emp_info_main
select *from bkborrowinginfo
truncate table bkborrowinginfo
select *from BKBorrowingInfo where BKAvailability = '1' and Date_Borrowed like '%2022-11%'
select *from [Member Data] where MemberEnd <= Convert(datetime, '2022-11-27')
select *from [Client Logbook] where Date <= '2022-11-27'

select *from BKINV_Availability
select *from BKINV_BKInfo where Availability = '3'
select *from BKBorrowingInfo 
drop table credentials;

SELECT table_name, table_schema FROM information_schema.tables
WHERE table_type = 'BASE TABLE' ORDER BY table_name ASC;

SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.VIEWS;

SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'member_info_main';

SELECT name FROM sys.columns 
WHERE OBJECT_ID = OBJECT_ID('clientlogbook')

update emp_info_main set ImgPath = 'C:\Users\User\Downloads\HIGALA_QRCODE_DELOSO__DANIEL_JOHN_AMPLAYO.jpg' where ID = '1'
select *from emp_info_main
select *from bkbr_notif
select *from bkreturns
select *from bkborrowinginfo
select *from [Book Borrowing]

create view [Client Logbook] as
select id, FirstName, MiddleName, LastName, Address, ContactNo, Date, Cast(time as varchar) as Time from clientlogbook
select *from [Book Inventory]
select *from BKReturns
truncate table BKReturns
select *from [Book Returns]

select *from clientlogbook where [time] like '%42:21%'

sp_rename 'clientlogbook.TimeInfo', 'TimeInfo', 'COLUMN';
select *from clientlogbook

select BookTitle from BKINV_BKInfo group by BookTitle having count(id) >1

select *from BKINV_BKInfo
select *from BKINV_Main
select *from ActiveStatus


create view [BKBR Book Information] as
select bk.AccessionNumber, bk.BookTitle, a.BookAuthor from BKINV_BKInfo bk 
inner join BKINV_AuthorInfo a on(bk.BookAuthor = a.id)
where Availability = '5'

select *from [BKBR Book Information]

create view [BKBR Staff Information] as
select FirstName + ' ' + LastName as Staff_Name, Username from emp_info_main

select *from [BKBR Staff Information]

select *from [Book Inventory]
select *from [Book Borrowing]
select *from [Book Returns]
select *from member_id_info

select COCPL_UID from member_id_info where MemberEnd = '2023-10-14'

select * from [BKBR Reference to Book Returns] 
select * from [BKBR Reference to Book Returns] where COCPL_UID = '' DueDate = '2022-11-19'

update BKReturns set ReturnedOn = '2022-11-25 05:17:42' 

select *from BKINV_BookshelfLvl
select *from BKINV_BKshelfNo
select *from BKINV_BookshelfNo
insert into BKINV_BookshelfLvl values ('N/A')

select id from member_id_info order by id desc
select *from member_id_info
select *from member_receipts
select id from member_id_info where id = (select max(id) from member_id_info)

create table BKReturnsRemarks(id int primary key identity(1,1), BKReturnsRemarks varchar(50))
insert into BKReturnsRemarks values ('RETURNED EARLY')
insert into BKReturnsRemarks values ('RETURNED ON TIME')
insert into BKReturnsRemarks values ('RETURNED LATE')
select *from BKReturnsRemarks
drop table BKReturnsRemarks

create table BKR_PaymentStatus (id int primary key identity(1,1), isPaid varchar(50))
insert into BKR_PaymentStatus values ('FINES PAID')
insert into BKR_PaymentStatus values ('FINES PENDING')
insert into BKR_PaymentStatus values ('NO FINES REQUIRED')
select *from BKR_PaymentStatus
DROP TABLE BKR_PaymentStatus

select *from BKReturns

SELECT table_name, table_schema FROM information_schema.tables
WHERE table_type = 'BASE TABLE' ORDER BY table_name ASC;

create table BKReturns (id int identity (1,1) primary key, COCPL_UID int, BookTitle int, AccessionNumber int, BookAuthor int, Date_Borrowed int, DueDate int, BookRemarksAndConditions varchar(1000), BKReturnsRemarks int, ImposedFines int, FinesPaymentStatus int, NotedBy int, EmpUsername int, ReturnedOn datetime)

select *from BKReturns
drop table BKReturns


create view [Book Returns] as 
select r.id, bb.COCPL_UID, bb.BookTitle, bb.AccessionNumber, bb.BookAuthor, bb.Date_Borrowed, bb.DueDate, r.BookRemarksAndConditions, bkr.BKReturnsRemarks, r.ImposedFines, p.isPaid as FinesPaymentStatus, e.FirstName + ' ' + e.LastName as NotedBy, e.Username as Staff_Username, r.ReturnedOn  from BKReturns r
inner join [Book Borrowing] bb on(r.COCPL_UID = bb.id)
inner join emp_info_main e on(r.EmpUsername = e.id)
inner join BKReturnsRemarks bkr on(r.BKReturnsRemarks = bkr.id)
inner join BKR_PaymentStatus p on (r.FinesPaymentStatus = p.id)

select *from [Book Borrowing]

select *from [Book Returns]
drop view [Book Returns]

create view [BKBR Reference to Book Returns] as
select id, COCPL_UID, BookTitle, AccessionNumber, BookAuthor, Date_Borrowed, DueDate from [Book Borrowing] where BookAvailability = 'BORROWED'

select *from [BKBR Reference to Book Returns] where DueDate like '%2022-11-19%'
drop view [BKBR Reference to Book Returns]

select *from [Member Data]
select *from [Book Returns]
select *from [Staff Data]
select *from emp_info_main
select *from member_id_info

SELECT name
FROM sys.columns 
WHERE OBJECT_ID = OBJECT_ID('Book Returns')

create table bkbr_notif(id int identity (1,1) primary key, NotificationMsg varchar(500), DatePosted datetime, AccessionNo int, COCPL_UID int, Source int);
drop table bkbr_notif


create view [Admin Info Data] as
SELECT emp.id, emp.FirstName, emp.MiddleName, emp.LastName, s.Suffix, ep.Position, er.EmpRoles, emp.EMailAddress, emp.ContactNo, emp.Username, emp.Password, emp.ImgPath, es.ActiveStatus FROM emp_info_main emp INNER JOIN name_suffix s ON(emp.Suffix = s.id) INNER JOIN EmpRoles er ON(emp.EmpRoles = er.id) INNER JOIN EmpPosition ep ON(emp.Position = ep.id) INNER JOIN EmpStatus es ON(emp.ActiveStatus = es.id) where emp.EmpRoles = 1
select *from [Admin Info Data]
drop view [Admin Info Data]

create view [Book Borrowing Notifications] as
select n.NotificationMsg, n.DatePosted, b.AccessionNumber as AccessionNo, m.COCPL_UID, s.Source from bkbr_notif n
inner join bkbr_notifsrc s on (n.Source = s.id)
inner join member_id_info m on (n.COCPL_UID = m.id)
inner join BKINV_BKInfo b on (n.AccessionNo = b.id)

select *from BKBorrowingInfo
select *from

drop table bkbr_notif;
drop view [Book Borrowing Notifications]
select *from [Book Borrowing Notifications]

select *from bkbr_notif

select *from BKBorrowingInfo where Date_Borrowed like '%2022-10-26%' and DueDate like '%2022-11-07%' and COCPL_UID = '4'

select *from BKINV_BKInfo
select *from BKBorrowingInfo

create table bkbr_notifsrc(id int identity (1,1) primary key, Source varchar(100));
insert into bkbr_notifsrc values ('STAFF PC');
insert into bkbr_notifsrc values ('KIOSK PC');
select *from bkbr_notifsrc

select bm.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id)

create table employee_user_profile (id int identity (1,1) primary key, FirstName varchar(100), MiddleName varchar(100), LastName varchar(100), Position varchar(100), HierarchyLvl varchar(100), EMailAddress varchar(100), ContactNo varchar(100), Username varchar(100), Password varchar(100), ImgPath varchar(1000));

create view [LIS Client] as 
select bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Availability a on(bm.Availability = a.id)

create view [Book Inventory] as 
select bi.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bp.Publisher, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_BKInfo bi inner join BKINV_Publisher bp on(bi.Publisher = bp.id) inner join BKINV_AuthorInfo ba on(bi.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bi.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bi.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bi.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bi.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bi.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bi.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bi.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bi.BookshelfLvl = bl.id) inner join BKINV_Source s on(bi.SpecificSource = s.id) inner join BKINV_Availability a on(bi.Availability = a.id)

drop view [Book Inventory]

select *from BKINV_DeweyDecimalRange

SELECT table_name, table_schema
FROM information_schema.tables
WHERE table_type = 'BASE TABLE'
ORDER BY table_name ASC;

select *from bkbr_notif

create table BKBorrowing_Main (id int identity (1,1) primary key, BookTitle int, AccessionNo int, BookAuthor int,  COCPL_UID int, Date_Borrowed int, DueDate int, ApprovedBy int, EmpUsername varchar(100), ApprovedOn int, PCSource int)
create table BKBorrowingInfo (id int identity (1,1) primary key, BookTitle int, AccessionNo int, BKAvailability int, BookAuthor int,   COCPL_UID int, Date_Borrowed date, DueDate date, ApprovedBy int, EmpUsername varchar(100), ApprovedOn datetime, PCSource int)
select *from BKBorrowing_Main
select *from BKBorrowingInfo
drop table BKBorrowing_Main
drop table BKBorrowingInfo


insert into BKBorrowingInfo values (1,1,1,1,1,'10/26/2022', '11/7/2022', 1, 1, CURRENT_TIMESTAMP, 1)
insert into BKBorrowingInfo values (2,2,1,2,2,'10/26/2022', '11/7/2022', 2, 2, CURRENT_TIMESTAMP, 1)
insert into BKBorrowingInfo values (6,6,1,6,4,'10/26/2022', '11/7/2022', 5, 5, CURRENT_TIMESTAMP, 1)
insert into BKBorrowingInfo values (7,7,1,7,3,'10/26/2022', '11/7/2022', 4, 4, CURRENT_TIMESTAMP, 1)

select *from BKINV_Availability
select *from BKBorrowingInfo
select *from BKBorrowing_Main

SELECT name FROM sys.columns WHERE OBJECT_ID = OBJECT_ID('approvedrequests')

SELECT COLUMN_NAME, DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'BKINV_BookSection'
select *from BKINV_BookSection

insert into BKINV_BookSection values ('Children''s Books')

select *from [Book Borrowing]
select *from [Book Ret]

select *from BKINV_Main
select *from BKINV_BKInfo
select *from bkbr_notifsrc

select *

create table approvedrequests(id int identity (1,1) primary key, NotificationMsg varchar(500), DatePosted datetime, DateApproved datetime, BookTitle int, COCPL_UID int, Source int);
create view [Approved Book Borrowing Notifications] as
select n.id, n.NotificationMsg, n.DatePosted, n.DateApproved, b.BookTitle, m.COCPL_UID, s.Source from approvedrequests n
inner join bkbr_notifsrc s on (n.Source = s.id)
inner join member_id_info m on (n.COCPL_UID = m.id)
inner join BKINV_BKInfo b on (n.BookTitle = b.id)
select *from [Approved Book Borrowing Notifications] 
select *from [Approved Book Borrowing Notifications] where DATEPART(HOUR, DatePosted) like '%9%'
drop view [Approved Book Borrowing Notifications]
drop table approvedrequests
select *from approvedrequests
select *from bkbr_notif

insert in
select *from member_id_info
select *from member_info_main

select FirstName + ' ' + LastName from emp_info_main where ActiveStatus = 2

create view [Book Borrowing Individual Member Records] as
select bki.id, bi.BookTitle, bi.AccessionNumber, ba.BookAuthor, m.COCPL_UID, bki.Date_Borrowed, bki.DueDate, e.FirstName +' '+e.LastName as ApprovedBy, bki.ApprovedOn from BKBorrowingInfo bki
inner join BKINV_AuthorInfo ba on(bki.BookAuthor = ba.id)
inner join BKINV_BKInfo bi on (bki.BookTitle = bi.id)
inner join emp_info_main e on (bki.ApprovedBy = e.id)
inner join member_id_info m  on (bki.COCPL_UID = m.id)
inner join name_suffix su on (m.Suffix = su.id)
select *from [Book Borrowing Individual Member Records]
drop view [Book Borrowing Individual Member Records]

create view [Book Borrowing]  as
select bki.id, bi.BookTitle, bi.AccessionNumber, ba.BookAuthor, a.Availability as BookAvailability, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, su.Suffix, bki.Date_Borrowed, bki.DueDate, e.FirstName +' '+e.LastName as ApprovedBy, e.Username as EmpUsername, bki.ApprovedOn, s.Source from BKBorrowingInfo bki
inner join BKINV_AuthorInfo ba on(bki.BookAuthor = ba.id)
inner join BKINV_BKInfo bi on (bki.BookTitle = bi.id)
inner join emp_info_main e on (bki.ApprovedBy = e.id)
inner join member_id_info m  on (bki.COCPL_UID = m.id)
inner join bkbr_notifsrc s on (bki.PCSource = s.id)
inner join bkinv_Availability a on (bki.BKAvailability = a.id)
inner join name_suffix su on (m.Suffix = su.id)
select *from [Book Borrowing]
select *from [Member Data] where MemberEnd like '%9%'
drop view [Book Borrowing]

create view [Book Borrowing]  as
select bki.id, bi.BookTitle, bi.AccessionNumber, ba.BookAuthor, a.Availability as BookAvailability, m.COCPL_UID, bki.Date_Borrowed, bki.DueDate, e.FirstName +' '+e.LastName as ApprovedBy, e.Username as EmpUsername, bki.ApprovedOn, s.Source from BKBorrowingInfo bki
inner join BKINV_AuthorInfo ba on(bki.BookAuthor = ba.id)
inner join BKINV_BKInfo bi on (bki.BookTitle = bi.id)
inner join emp_info_main e on (bki.ApprovedBy = e.id)
inner join member_id_info m  on (bki.COCPL_UID = m.id)
inner join bkbr_notifsrc s on (bki.PCSource = s.id)
inner join bkinv_Availability a on (bki.BKAvailability = a.id)
drop view [Book Borrowing]
select *from [Book Borrowing]
select *from BKBorrowingInfo

select *from BKINV_BKINFO
select *from BKINV_Main
update BKINV_BKInfo set Availability = 5 where id = 9
update BKINV_Main set Availability = 5 where id = 9

select *from BKINV_Availability
select *from emp_info_main
select *from BKBorrowingInfo
select *from BKBorrowing_Main

select * from [Book Borrowing]
select * from [Book Borrowing] where ApprovedOn like '%2022%'
select * from [Book Borrowing] where DATEPART(YYYY, ApprovedOn) like '%{inp}%' OR DATEPART(MM, ApprovedOn) like '%{inp}%' OR DATEPART(dd, ApprovedOn) like '%{inp}%' OR DATEPART(HH, ApprovedOn) like '%{inp}%' OR DATEPART(MINUTE, ApprovedOn) like '%{inp}%' OR DATEPART(ss, ApprovedOn) like '%{inp}%'

SELECT *from [Book Borrowing] where DATEPART(YYYY, ApprovedOn) like '%{inp}%' OR DATEPART(MM, ApprovedOn) like '%{inp}%' OR DATEPART(dd, ApprovedOn) like '%{inp}%' OR DATEPART(HH, ApprovedOn) like '%{inp}%' OR DATEPART(MINUTE, ApprovedOn) like '%{inp}%' OR DATEPART(ss, ApprovedOn) like '%{inp}%' OR ApprovedOn like select * from [Book Borrowing] where DATEPART(YYYY, ApprovedOn) like '%13%' OR DATEPART(MM, ApprovedOn) like '%13%' OR DATEPART(dd, ApprovedOn) like '%13%' OR DATEPART(HH, ApprovedOn) like '%13%' OR DATEPART(MINUTE, ApprovedOn) like '%13%' OR DATEPART(ss, ApprovedOn) like '%13%' OR ApprovedOn like '%13%'

select *from BKINV_BKInfo

drop table BKBorrowingInfo
drop table BKBorrowing_Main

select *from bkinv_bkinfo
select id from bkinv_bkinfo where BookTitle = 'aqweqew'

select *from BKBorrowingInfo
select *from member_info_main

create table tstdtadd (id int primary key identity(1,1), DateNow date, Date1Wk date)
insert into tstdtadd values (CURRENT_TIMESTAMP, DATEADD(DAY, 7, CURRENT_TIMESTAMP))
select *from tstdtadd
drop table tstdtadd
select DATEADD(YEAR, 1, '2000/1/1') as DateAdd;

create view [Member Data] as
select m.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, s.Suffix, o.SchoolOrOrganization, m.Address, m.EMailAddress, m.ContactNo, m.MemberStart, m.MemberEnd, m.ImgPath from member_info_main mn inner join member_id_info m on(mn.COCPL_UID = m.id) inner join name_suffix s on(mn.Suffix = s.id) inner join memb_SchoolOrOrg o on(mn.SchoolOrOrganization = o.id) 
select *from [Member Data]
select *from [Book Inventory]

create view [Staff Data] as
SELECT emp.id, emp.FirstName, emp.MiddleName, emp.LastName, s.Suffix, ep.Position, er.EmpRoles, emp.EMailAddress, emp.ContactNo, emp.Username, emp.Password, emp.ImgPath, es.ActiveStatus FROM emp_info_main emp INNER JOIN name_suffix s ON(emp.Suffix = s.id) INNER JOIN EmpRoles er ON(emp.EmpRoles = er.id) INNER JOIN EmpPosition ep ON(emp.Position = ep.id) INNER JOIN EmpStatus es ON(emp.ActiveStatus = es.id) where er.EmpRoles = 'Staff'
select *from [Staff Data]
drop view [Staff Data]

  SELECT name FROM sys.columns WHERE OBJECT_ID = OBJECT_ID('BKBorrowingInfo')
    SELECT name FROM sys.columns WHERE OBJECT_ID = OBJECT_ID('LIS Client')

	select *from [book_inventory_data1]

select *from [LIS Client]
select *from member_id_info

select *from name_suffix
select *from emp_info_main
select *from EmpStatus

SELECT emp.id, emp.FirstName, emp.MiddleName, emp.LastName, s.Suffix, ep.Position, er.EmpRoles, emp.EMailAddress, emp.ContactNo, emp.Username, emp.Password, emp.ImgPath, es.ActiveStatus FROM emp_info_main emp INNER JOIN name_suffix s ON(emp.Suffix = s.id) INNER JOIN EmpRoles er ON(emp.EmpRoles = er.id) INNER JOIN EmpPosition ep ON(emp.Position = ep.id) INNER JOIN EmpStatus es ON(emp.ActiveStatus = es.id) where es.ActiveStatus like '%ina%' and emp.EmpRoles = '2'
SELECT emp.id, emp.FirstName, emp.MiddleName, emp.LastName, s.Suffix, ep.Position, er.EmpRoles, emp.EMailAddress, emp.ContactNo, emp.Username, emp.Password, emp.ImgPath, es.ActiveStatus FROM emp_info_main emp INNER JOIN name_suffix s ON(emp.Suffix = s.id) INNER JOIN EmpRoles er ON(emp.EmpRoles = er.id) INNER JOIN EmpPosition ep ON(emp.Position = ep.id) INNER JOIN EmpStatus es ON(emp.ActiveStatus = es.id) where ep.Position like '%lib%' and emp.EmpRoles = '1'

select m.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, s.Suffix, o.SchoolOrOrganization, m.Address, m.EMailAddress, m.ContactNo, m.MemberStart, m.MemberEnd, m.ImgPath from member_info_main mn inner join member_id_info m on(mn.COCPL_UID = m.id) m inner join name_suffix s on(m.Suffix = s.id) inner join memb_SchoolOrOrg o on(m.SchoolOrOrganization = o.id) where (DATEPART(YYYY, m.MemberStart) like '%1%' OR DATEPART(MM, m.MemberStart) like '%1%' OR DATEPART(dd, m.MemberStart) like '%1%' OR DATEPART(HH, m.MemberStart) like '%1%' OR DATEPART(MINUTE, m.MemberStart) like '%1%' OR DATEPART(ss, m.MemberStart) like '%1%')
select m.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, s.Suffix, o.SchoolOrOrganization, m.Address, m.EMailAddress, m.ContactNo, m.MemberStart, m.MemberEnd, m.ImgPath from member_info_main mn inner join member_id_info m on(mn.COCPL_UID = m.id) inner join name_suffix s on(m.Suffix = s.id) inner join memb_SchoolOrOrg o on(m.SchoolOrOrganization = o.id) where (DATEPART(YYYY, m.MemberEnd) like '%{keyword}%' OR DATEPART(MM, m.MemberEnd) like '%{keyword}%' OR DATEPART(dd, m.MemberEnd) like '%{keyword}%' OR DATEPART(HH, m.MemberEnd) like '%{keyword}%' OR DATEPART(MINUTE, m.MemberEnd) like '%{keyword}%' OR DATEPART(ss, m.MemberEnd) like '%{keyword}%')

select *from member_id_info
select *from BKINV_AuthorInfo

delete from clientlogbook where id = 2
select id, FirstName, MiddleName, LastName, Address, ContactNo, Date, Cast(time as varchar) as Time from clientlogbook
select *from clientlogbook where Time like '%10:07:12%'
select *from clientlogbook
update clientlogbook set TimeInfo = '10:08:12.0000000' where id = 2

select *from BkINV_AuthorInfo
select *from BkINV_AuthorInfo = 'Mark Twain'
select *from BKINV_Source

SELECT Col2, Col1 FROM (SELECT * FROM tblEmployees WHERE Empid = 200) a
UNPIVOT(Col1 FOR Col2 IN (EmpID, Name, Sex)) AS unp

update BKINV_AuthorInfo set AuthorNo = 'T9356', BookAuthor = 'Mark Twain' where id = 1;
delete from BKINV_Publisher where id = 4

drop table book_inventory_data

insert into memb_exp_notifs values ('The following account with the COCPL UID  will expire on ',CURRENT_TIMESTAMP)
drop table memb_exp_notifs
select *from memb_exp_notifs
select *from member_id_info
select *from member_info_main
select *from emp_info_main

drop table BKINV_BKInfo
drop table BKINV_Main

SELECT 'Column Name'=name
FROM sys.columns
WHERE OBJECT_ID = OBJECT_ID('BKINV_BKInfo')

SELECT 'Column Name'=name
FROM sys.columns
WHERE OBJECT_ID = OBJECT_ID('BKBorrowing_Main')

select *from BKINV_BKinfo
select *from BKINV_Main

SELECT name
FROM sys.columns 
WHERE OBJECT_ID = OBJECT_ID('BKINV_Main')


SELECT name
FROM sys.columns 
WHERE OBJECT_ID = OBJECT_ID('emp_info_main')


SELECT name
FROM sys.columns 
WHERE OBJECT_ID = OBJECT_ID('member_id_info')

select bi.BookTitle, ba.BookAuthor,  bp.Publisher, bn.BookshelfNo,
bl.BookshelfLvl, a.Availability, bi.ISBN, ba.AuthorNo, bi.AccessionNumber,
bi.Copyright, bi.TotalPages, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + 
d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary,
il.IncludesIllustrations, inc.IncludesIndex from BKINV_Main bm inner join BKINV_BKInfo
bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id)
inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id)
inner join BKINV_BookSection bs on(bm.BookSection = bs.id) 
inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) 
inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) 
inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id)
inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id)
inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) 
inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) 
inner join BKINV_Availability a on(bm.Availability = a.id) as srctbl
unpivot(RowValue for ColumnName in (BookTitle, BookAuthor, Publisher, BookshelfNo, BookshelfLvl, 
Availability, ISBN, AuthorNo, AccessionNumber, Copyright, TotalPages, DeweyDecimalRange,
IncludesBiblio, IncludesGlossary, IncludesIllustrations, IncludesIndex)) as unpv

select ColumnName, RowValue
from (select bm.id, convert(varchar(max), bi.BookTitle) as BookTitle, convert(varchar(max), ba.BookAuthor) as BookAuthor ,  convert(varchar(max), bp.Publisher) as Publisher, convert(varchar(max), bn.BookshelfNo) as BookshelfNo,
convert(varchar(max), bl.BookshelfLvl) as BookshelfLvl, convert(varchar(max), a.Availability) as Availability, convert(varchar(max), bi.ISBN) as ISBN, convert(varchar(max), ba.AuthorNo) as AuthorNo, convert(varchar(max), bi.AccessionNumber) as AccessionNumber,
convert(varchar(max), bi.Copyright) as Copyright, convert(varchar(max), bi.TotalPages) as TotalPages, convert(varchar(max), bi.DateAcquired) as DateAcquired, convert(varchar(max), bi.RetailPrice) as RetailPrice, convert(varchar(max), bs.BookSection) as BookSection, convert(varchar(max), d.DeweyDecimalRange + ' ' + 
d.DeweyDecimalGroup) as DeweyDecimalRange, convert(varchar(max), ib.IncludesBiblio) as IncludesBiblio, convert(varchar(max), ig.IncludesGlossary) as IncludesGlossary,
convert(varchar(max), il.IncludesIllustrations) as IncludesIllustrations, convert(varchar(max), inc.IncludesIndex) as IncludesIndex from BKINV_Main bm inner join BKINV_BKInfo
bi on (bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on (bm.Publisher = bp.id)
inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id)
inner join BKINV_BookSection bs on(bm.BookSection = bs.id) 
inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) 
inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) 
inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id)
inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id)
inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) 
inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) 
inner join BKINV_Availability a on (bm.Availability = a.id) where bm.id = 2) as sourcetable
unpivot(RowValue for ColumnName in(BookTitle, BookAuthor, Publisher, BookshelfNo, BookshelfLvl, 
Availability, ISBN, AuthorNo, AccessionNumber, Copyright, TotalPages, DateAcquired, BookSection, DeweyDecimalRange,
IncludesBiblio, IncludesGlossary, IncludesIllustrations, IncludesIndex)) as unpvt

("Anna Karenina (Bantam Classics) c1 c1
","Leo Tolstoy
","Grolier
","Bookshelf 5
","Top Level
","OPEN FOR BORROWING
","ISBN 978-0-553-21346-1
","T657869
","abc123
","1960
","10/18/2022  12:00:00 AM","Fiction
","800–899 Literature and Rhetoric 
","NO
","NO
","NO
","NO
")


select bi.id, bi.BookTitle, ba.BookAuthor,  bp.Publisher, bn.BookshelfNo,
bl.BookshelfLvl, a.Availability, bi.ISBN, ba.AuthorNo, bi.AccessionNumber,
bi.Copyright, bi.TotalPages, bi.DateAcquired, bi.RetailPrice, bs.BookSection, d.DeweyDecimalRange + ' ' + 
d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary,
il.IncludesIllustrations, inc.IncludesIndex from BKINV_Main bm inner join BKINV_BKInfo
bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id)
inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id)
inner join BKINV_BookSection bs on(bm.BookSection = bs.id) 
inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) 
inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) 
inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id)
inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id)
inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) 
inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) 
inner join BKINV_Availability a on(bm.Availability = a.id) where bm.id = 2

select bi.id, bi.BookTitle, ba.BookAuthor,  bp.Publisher, bn.BookshelfNo,
bl.BookshelfLvl, a.Availability, bi.ISBN, ba.AuthorNo, bi.AccessionNumber,
bi.Copyright, bi.TotalPages, bi.DateAcquired, bi.RetailPrice, bs.BookSection, d.DeweyDecimalRange + ' ' + 
d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary,
il.IncludesIllustrations, inc.IncludesIndex from BKINV_Main bm inner join BKINV_BKInfo
bi on(bm.AccessionNumber = bi.id) inner join BKINV_Publisher bp on(bm.Publisher = bp.id)
inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id)
inner join BKINV_BookSection bs on(bm.BookSection = bs.id) 
inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) 
inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) 
inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id)
inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id)
inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) 
inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) 
inner join BKINV_Availability a on(bm.Availability = a.id) where bm.id = 2

select deweydecimalgroup from BKINV_DeweyDecimalClassification


select deweydecimalrange + ' ' + deweydecimalgroup as DeweyDecimalRange from BKINV_DeweyDecimalClassification 
select BookshelfNo from BKINV_BKshelfNo
select BookshelfLvl from BKINV_BookshelfLvl
select IncludesBiblio from BKINV_IncludesBiblio
select IncludesGlossary from BKINV_IncludesGlossary
select IncludesIndex from BKINV_IncludesIndex
select IncludesIllustrations from BKINV_IncludesIllustrations
select Availability from BKINV_Availability
select BookSection from BKINV_BookSection

insert into BKINV_BKInfo values ('xyz12345','The Adventures of Tom Sawyer (Unabridged. Complete with all original illustrations) c1','ISBN 978-1-78943-105-6','2020','250','500','10/17/2022',1,1,4,2,9,2,2,1,1,3,3,1,5)
insert into BKINV_Main values (1,1,1,1,1,1,1,1,1,4,2,9,2,2,1,1,3,3,1,5)

insert into BKINV_BKInfo values ('abc123','Anna Karenina (Bantam Classics) c1','ISBN 978-0-553-21346-1','1960','1001','350','10/18/2022',2,2,3,2,9,2,2,2,2,5,1,3,5)
insert into BKINV_Main values (2,2,2,2,2,2,2,2,2,3,2,9,2,2,2,2,5,1,3,5)



insert into BKINV_AuthorInfo values ('T657869','Leo Tolstoy')
insert into BKINV_Publisher values ('MacMillan Publishers')
select *from BKINV_Publisher
insert into BKINV_Source values ('Book Sale')

select bm.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id) where bm.id = 4

delete from BKINV_Main where id = 2
delete from BKINV_BKInfo where id = 2

select *from BKINV_BKInfo
select *from BKINV_Main

select *from member_info_main
select *from [Book Inventory]

drop table BKINV_BKInfo
drop table BKINV_Main

create table BKINV_Main (id int identity(1,1) primary key, AccessionNumber int, BookTitle int, BookAuthor int, AuthorNo int, Publisher int, ISBN int, Copyright int, TotalPages int, RetailPrice int, DateAcquired int, BookSection int, DeweyDecimalRange int, IncludesBiblio int, IncludesGlossary int, IncludesIndex int, IncludesIllustrations int, BookshelfNo int, BookshelfLvl int, SpecificSource int, Availability int)
create table BKINV_BKInfo (id int identity (1,1) primary key, AccessionNumber varchar(50), BookTitle varchar(500), ISBN varchar(100), Copyright varchar(4), TotalPages varchar(50), RetailPrice varchar(20), DateAcquired datetime, BookAuthor int, AuthorNo int, Publisher int, BookSection int, DeweyDecimalRange int, IncludesBiblio int, IncludesGlossary int, IncludesIndex int, IncludesIllustrations int, BookshelfNo int, BookshelfLvl int, SpecificSource int, Availability int)

SELECT table_name, table_schema
FROM information_schema.tables
WHERE table_type = 'BASE TABLE'
ORDER BY table_name ASC;

select *from BKINV_BKInfo
select *from BKINV_BKInfo where Availability != 1 and Availability != 4

select *from BKBorrowingInfo
select *from BKINV_Availability
select *from emp_info_main
select *from BKINV_BKInfo
select *from member_id_info

select *from BKINV_DeweyDecimalClassification
select *from BKINV_IncludesBiblio
drop table BKINV_AuthorInfo 

select *from member_id_info
select id from name_suffix where suffix like '%j%'

delete from BKINV_BKInfo where id between 3 and 5


select *from BKBorrowingInfo
select *from BKINV_AuthorInfo 
select *from BKINV_Availability
select *from BKINV_BKInfo
select *from BKINV_BkShelfNo
select *from BKINV_BookSection
select *from BKINV_DeweyDecimalClassification
select *from BKINV_Source
select *from BKINV_BookshelfLvl
select *from BKINV_Publisher
select *from BKINV_Main

select id from BKINV_Main where id = 'asdasdsa'

delete from bkinv_publisher where id =9

drop table bkinv_bkinfo

create table BKINV_IncludesBiblio(id int identity(1,1) primary key, IncludesBiblio varchar(3))
create table BKINV_IncludesGlossary(id int identity(1,1) primary key, IncludesGlossary varchar(3))
create table BKINV_IncludesIndex(id int identity(1,1) primary key, IncludesIndex varchar(3))
create table BKINV_IncludesIllustrations(id int identity(1,1) primary key, IncludesIllustrations varchar(3))
insert into BKINV_IncludesBiblio values ('YES')
insert into BKINV_IncludesBiblio values ('NO')
insert into BKINV_IncludesGlossary values ('YES')
insert into BKINV_IncludesGlossary values ('NO')
insert into BKINV_IncludesIndex values ('YES')
insert into BKINV_IncludesIndex values ('NO')
insert into BKINV_IncludesIllustrations values ('YES')
insert into BKINV_IncludesIllustrations values ('NO')
select *from BKINV_IncludesBiblio;
select *from BKINV_IncludesGlossary;
select *from BKINV_IncludesIllustrations;
select *from BKINV_IncludesIndex

create table BKINV_Publisher (id int identity(1,1) primary key, Publisher varchar(500))

select bm.id, bi.AccessionNumber, bi.BookTitle, ba.BookAuthor, ba.AuthorNo, bi.ISBN, bi.Copyright, bi.TotalPages, bi.RetailPrice, bi.DateAcquired, bs.BookSection, d.DeweyDecimalRange + ' ' + d.DeweyDecimalGroup as DeweyDecimalRange, ib.IncludesBiblio, ig.IncludesGlossary, il.IncludesIllustrations, inc.IncludesIndex, bn.BookshelfNo, bl.BookshelfLvl, s.SpecificSource, a.Availability from BKINV_Main bm inner join BKINV_BKInfo bi on(bm.AccessionNumber = bi.id) inner join BKINV_AuthorInfo ba on(bm.AuthorNo = ba.id) inner join BKINV_BookSection bs on(bm.BookSection = bs.id) inner join BKINV_DeweyDecimalClassification d on(bm.DeweyDecimalRange = d.id) inner join BKINV_IncludesBiblio ib on(bm.IncludesBiblio = ib.id) inner join BKINV_IncludesGlossary ig on(bm.IncludesGlossary = ig.id) inner join BKINV_IncludesIndex inc on(bm.IncludesIllustrations = inc.id) inner join BKINV_IncludesIllustrations il on(bm.IncludesIllustrations = il.id) inner join BKINV_BkshelfNo bn on(bm.BookshelfNo = bn.id) inner join BKINV_BookshelfLvl bl on(bm.BookshelfLvl = bl.id) inner join BKINV_Source s on(bm.SpecificSource = s.id) inner join BKINV_Availability a on(bm.Availability = a.id)

insert into BKINV_BKInfo values ('','','','','','','')

create table BKINV_BookSection (id int identity(1,1) primary key, BookSection varchar(100))
insert into BKINV_BookSection values ('Circulation')
insert into BKINV_BookSection values ('Fiction')
insert into BKINV_BookSection values ('Filipiniana')
insert into BKINV_BookSection values ('Reference')
insert into BKINV_BookSection values ('Reserved')
insert into BKINV_BookSection values ('Technical')
select *from BKINV_BookSection

create table BKINV_BookshelfLvl (id int identity(1,1) primary key, BookshelfLvl varchar(100))
insert into BKINV_BookshelfLvl values ('Top Level')
insert into BKINV_BookshelfLvl values ('Middle Level')
insert into BKINV_BookshelfLvl values ('Bottom Level')
select *from BKINV_BookshelfLvl

create table BKINV_AuthorInfo (id int identity(1,1) primary key, AuthorNo varchar(100), BookAuthor varchar(1000));
create table BKINV_BkShelfNo (id int identity(1,1) primary key, BookshelfNo varchar(50))
insert into BKINV_BkShelfNo values ('Bookshelf 1')
insert into BKINV_BkShelfNo values ('Bookshelf 2')
insert into BKINV_BkShelfNo values ('Bookshelf 3')
insert into BKINV_BkShelfNo values ('Bookshelf 4')
insert into BKINV_BkShelfNo values ('Bookshelf 5')
insert into BKINV_BkShelfNo values ('Bookshelf 6')
insert into BKINV_BkShelfNo values ('Bookshelf 7')
insert into BKINV_BkShelfNo values ('Unshelved')
select *from BKINV_BkShelfNo

create table BKINV_Availability (id int identity(1,1) primary key, Availability varchar(50))
insert into BKINV_Availability values ('BORROWED')
insert into BKINV_Availability values ('DISCARDED')
insert into BKINV_Availability values ('FOR INSIDE READING ONLY')
insert into BKINV_Availability values ('MISSING')
insert into BKINV_Availability values ('OPEN FOR BORROWING')
select *from BKINV_Availability
create table BKINV_Source (id int identity(1,1) primary key, SpecificSource varchar(500))


create table book_inventory_data (id int identity(1,1) primary key, 
AccessionNo varchar(50), 
BookTitle varchar(100),
AuthorNo varchar(10), 
BookAuthor varchar(500),
ClassificationNo varchar(100),
BookSection varchar(50),
Publisher varchar(100), 
PlaceOfPublication varchar(100),
CopyrightDate date,
BookSource varchar(50), 
SpecificSource varchar (100), 
Availability varchar(50), 
Price varchar(50), 
DateAcquired date, 
ISBN varchar(100), 
Height decimal,
Width decimal,
RomanNumPages varchar (50),
HinduArabPagesTotal int,
IncludesBiblio varchar (3),
IncludesGloss varchar (3),
IncludesIndex varchar (3),
BookShelfNo int, 
BookShelfLevel int);
select *from book_inventory_data
drop table book_inventory_data;

create table book_inventory_data (id int identity(1,1) primary key, 
BookTitle varchar(100),
AccessionNo varchar(50), 
ISBN varchar(100), 
TotalPages int,
BookSize decimal,
AuthorNo varchar(10), 
BookAuthor varchar(500),
Publisher varchar(100), 
PlaceOfPublication varchar(100),
CopyrightDate date,
BookSection varchar(50),
ClassificationNo varchar(100),
BookShelfNo varchar(10), 
BookShelfLevel int,
IncludesBiblio varchar (3),
IncludesGloss varchar (3),
IncludesIllus varchar (3),
IncludesIndex varchar (3),
BookSource varchar(50), 
SpecificSource varchar (100), 
Availability varchar(50), 
Price varchar(50), 
DateAcquired date)
select *from book_inventory_data;
insert into book_inventory_data(AuthorNo, BookAuthor) values ('1','1')
drop table book_inventory_data;

select *from employee_user_profile
update employee_user_profile set ImgPath = 'C:\Users\User\source\repos\Capstone\Images\ProfPics\Member\person-icon.png' where id=3;
update employee_user_profile set Password = 'matt123' where id=3;
alter table employee_user_profile alter column ImgPath varchar(1000)

create table eup_name_info(id int identity(1,1) primary key, FirstName varchar(30), MiddleName varchar(30), LastName varchar(30))		
create table eup_personalinfo(id int identity(1,1) primary key, Position varchar(30), EMailAddress varchar(30), ContactNo varchar(30))		
create table eup_credentials(id int identity(1,1) primary key, Username varchar(50), Password varchar(50), HierarchyLvl varchar(30))
insert into eup_name_info values ('Ryan', 'Eclair', 'Withers');
insert into eup_personalinfo values ('Librarian IV','r.withers@gmail.com','09556688445');
insert into eup_credentials values ('r.withers','rw123','Administrator');

select column_name, data_type from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'member_receipts'

select *from employee_user_profile;

update  COCPLM00000001AllenJonathan set MemberEnd = '10/3/2023 12:00:00 AM' where id = 1;

drop table COCPLM00000001AllenJonathan


select *from member_id_info;
select *from member_receipts;
select *from eup_name_info;
select *from eup_credentials;
select *from eup_personalinfo;
delete from member_id_info where id between 3 and 7
drop table member_id_info
drop table member_receipts
drop table member_info_main
drop table memb_schoolororg
select *from member_receipts
select *from book_inventory_data;
select *from name_suffix
select *from memb_SchoolOrOrg

SELECT mr.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, m.MemberStart, m.MemberEnd, mr.ORNumber, mr.ORReceivedDate FROM member_receipts mr INNER JOIN member_id_info m ON(mr.FirstName = m.id) where m.FirstName like '%a%'
select *from member_receipts

create table member_id_info (id int identity(1,1) primary key, COCPL_UID varchar(100), FirstName varchar(100), MiddleName varchar(100), LastName varchar(100), Suffix int, SchoolOrOrganization int, Address varchar(100), EMailAddress varchar(100), ContactNo varchar(100), MemberStart datetime, MemberEnd datetime, ImgPath varchar (100));
create table clientlogbook (id int identity(1,1) primary key, FirstName varchar(100), MiddleName varchar(100), LastName varchar(100), Address varchar(100), ContactNo varchar(100), Date date, Time time);
insert into member_id_info values ('COCPLM00000001', 'Allen', 'Roberts', 'Sullivan', 1, 1, 'Blk 1 Lt 4, Lapasan, Cagayan de Oro City, Misamis Oriental', 'a.sullivan@gmail.com', '09558744681', '9/27/2022', '9/27/2023', 'C:\Users\User\source\repos\Capstone\ProfPics\Member\image.jfif');
insert into member_id_info values ('COCPLM00000002',	'James',	'Young',	'Smith',	1, 3,	'Blk 31, Lapasan, Cagayan De Oro City',	'asdsa@gmail.com',	'09478947848',	'10/14/2022',	'10/13/2029',	'E:\shrok.jpg')
insert into employee_user_profile values ('John', 'Smith', 'Lockheed', 'Librarian IV', 'Administrator', 'johnsmith.l@gmail.com','09123456789','johnsmith','admin123','C:\Users\User\source\repos\Capstone\Images\ProfPics\Admin\man-person-icon.png');
insert into employee_user_profile values ('Adam', 'Bob', 'Giuseppe', 'Librarian IV', 'Administrator', 'testadmin@gmail.com','09987654321','admin','admin123', 'C:\Users\User\source\repos\Capstone\ProfPics\Admin\img_166744.png');
insert into employee_user_profile values ('Test', 'Test', 'Test', 'Test', 'Administrator', 'testadmin@gmail.com','09987654321','admin','admin123');
insert into employee_user_profile values ('Joseph', 'Gantt', 'Shepherd', 'Librarian II', 'Staff', 'joseph.g.shepherd@gmail.com','09561400909','staff_joseph','joseph123');
insert into employee_user_profile values ('Matt', 'Stone', 'Roberts', 'Librarian II', 'Staff', 'mattstone@gmail.com','09564578915','mattstone','matt123', 'C:\Users\User\source\repos\Capstone\ProfPics\Staff\testpic1.jpg');
select * from employee_user_profile where Username = 'johnsmith' and Password = 'admin123' and HierarchyLvl = 'Administrator';
select *from member_id_info
select *from member_receipts
delete from member_receipts where id = 1004
select *from memb_schoolororg
delete from memb_schoolororg where id = 1002
select id, id, id from member_id_info where id = 1
insert into member_receipts (ORNumber, ORReceivedDate) values ('12312312', CURRENT_TIMESTAMP) select id, id, id, id, suffix from member_id_info

select top 1 id from member_id_info order by id desc
select *from clientlogbook;

delete from member_id_info where id = 1002;
select EMailAddress from employee_user_profile where Username = 'admin' and Password = 'admin123' and HierarchyLvl = 'Administrator';
select *from employee_user_profile where LastName = 'Giuseppe';
select *from employee_user_profile;
select *from book_inventory_data;

select *from clientlogbook;
exec sp_rename 'COCPLM00000002JohnClaypool', 'COCPLM00000002JohnRoberts'
select *from employee_user_profile where FirstName = 'Joseph' and HierarchyLvl = 'Staff';
select FirstName, MiddleName, LastName, Position, HierarchyLvl, EMailAddress, ContactNo, Username from employee_user_profile where hierarchylvl = 'Administrator'
select *from employee_user_profile where FirstName = 'Jimmy';
delete from employee_user_profile where FirstName = 'Jimmy';
update employee_user_profile set Password = 'johnsmith123' where username = 'johnsmith';
update employee_user_profile set id = 2 where username = 'admin';
create table logbook_entries (id int identity (1,1) primary key, Name varchar(100), ContactNo varchar(100), Address varchar(100), Month int, Day int, Year int, Time time);

--
use lb_TestDB

select *from employee_user_profile

create database testdb
use testdb
SELECT
  *FROM
  lb_testdb.INFORMATION_SCHEMA.TABLES
WHERE
  TABLE_TYPE = 'BASE TABLE';
GO

drop table emp_info_main
drop table EmpRoles
drop table EmpStatus
drop table EmpPosition

create table emp_info_main (id int identity (1,1) primary key, FirstName varchar(100), MiddleName varchar(100), LastName varchar(100), Suffix int, Position int, EmpRoles int, EMailAddress varchar(100), ContactNo varchar(11), username varchar(100), password varchar(100), ImgPath varchar(500), ActiveStatus varchar(10))
insert into emp_info_main values ('Admin',	'Admin',	'Admin', 1,	4,	1,'testadmin@gmail.com',	'09987654321',	'admin',	'123',	'C:\',2)
insert into emp_info_main values ('John',	'Smith',	'Lockheed', 1,	3,	1, 	'johnsmith.l@gmail.com',	'09123456789',	'johnsmith',	'johnsmith123',	'C:\',2);
insert into emp_info_main values ('Joseph',	'Mann',	'Shepherd', 2,	1, 2,	'joseph.g.shepherd@gmail.com',	'09561400909',	'joemann',	'joe123',	'C:\',2)
insert into emp_info_main values ('Matt',	'Stone',	'Roberts', 1,	2,	2,	'mattstone@gmail.com',	'09564578915',	'mattstone',	'matt123',	'C:\',2)
insert into emp_info_main values ('Tommy',	'Hank',	'Ford', 1,	4,	1,	't.ford@gmail.com',	'09866755488',	'tford',	'ford123',	'C:\',2)
insert into emp_info_main values ('Ramone',	'Paul',	'Simmons', 3,	1,	2,	's.simmons@gmail.com',	'09684475826',	'steve.s',	'steve123',	'C:\',2)
select *from emp_info_main
select username from emp_info_main where id != 1 and username = 'mattstone'
drop table name_suffix;

create table EmpRoles (id int identity (1,1) primary key, EmpRoles varchar(50))
insert into EmpRoles values('Administrator')
insert into EmpRoles values('Staff')
select *from EmpRoles


create table EmpStatus(id int identity (1,1) primary key, ActiveStatus varchar(50))
insert into EmpStatus values('Active')
insert into EmpStatus values('Inactive')
select *from EmpStatus


create table EmpPosition (id int identity (1,1) primary key, Position varchar(50))
insert into EmpPosition values('Librarian I')
insert into EmpPosition values('Librarian II')
insert into EmpPosition values('Librarian III')
insert into EmpPosition values('Librarian IV')
select *from EmpPosition

create table Test(id int identity (0,1), test varchar(10));
insert into test values('1')
insert into test values('2')
select *from Test;
drop table Test;



--create and insert suffix
create table name_suffix(id int identity (1,1), Suffix varchar(10));
insert into name_suffix values('N/A')
insert into name_suffix values('Sr.')
insert into name_suffix values('Jr.')
select *from name_suffix;



--select all administrator
SELECT 'Employee ID'=emp.id, 'First Name'=emp.FirstName, 'Middle Name'=emp.MiddleName, 'Last Name'=emp.LastName, ep.Position, 'Employee Roles'=er.EmpRoles, 'E-mail Address'=emp.EMailAddress, 'Contact Number'=emp.ContactNo, emp.Username, emp.Password, 'Image Path'=emp.ImgPath
FROM emp_info_main emp
INNER JOIN EmpRoles er
 ON(emp.EmpRoles = er.id)
 INNER JOIN EmpPosition ep
 ON(emp.Position = ep.id)
 where emp.EmpRoles = '1'

--select specific admin
 SELECT emp.id, emp.FirstName, emp.MiddleName, emp.LastName, ep.Position, er.EmpRoles, emp.EMailAddress, emp.ContactNo, emp.Username, emp.Password, emp.ImgPath
FROM emp_info_main emp
INNER JOIN EmpRoles er
 ON(emp.EmpRoles = er.id)
 INNER JOIN EmpPosition ep
 ON(emp.Position = ep.id)
 where emp.EmpRoles = '1' and emp.username = 'admin' and emp.password = 'admin123'

--select all staff
SELECT emp.id, emp.FirstName, emp.MiddleName, emp.LastName, ep.Position, er.EmpRoles, emp.EMailAddress, emp.ContactNo, emp.Username, emp.Password, emp.ImgPath
FROM emp_info_main emp
INNER JOIN EmpRoles er
 ON(emp.EmpRoles = er.id)
 INNER JOIN EmpPosition ep
 ON(emp.Position = ep.id)
 where emp.EmpRoles = '2'

--select  inactive status
SELECT emp.id ,emp.FirstName, emp.MiddleName, emp.LastName, ep.Position, er.EmpRoles, emp.EMailAddress, emp.ContactNo, emp.Username, emp.Password, emp.ImgPath, es.ActiveStatus
FROM emp_info_main emp
INNER JOIN EmpRoles er
 ON(emp.EmpRoles = er.id)
INNER JOIN EmpPosition ep
 ON(emp.Position = ep.id)
INNER JOIN EmpStatus es
 ON(emp.ActiveStatus = es.id)
 where emp.ActiveStatus = '2'

--select  active status
SELECT emp.id ,emp.FirstName, emp.MiddleName, emp.LastName, ep.Position, er.EmpRoles, emp.EMailAddress, emp.ContactNo, emp.Username, emp.Password, emp.ImgPath, es.ActiveStatus
FROM emp_info_main emp
INNER JOIN EmpRoles er
 ON(emp.EmpRoles = er.id)
INNER JOIN EmpPosition ep
 ON(emp.Position = ep.id)
INNER JOIN EmpStatus es
 ON(emp.ActiveStatus = es.id)
 where emp.ActiveStatus = '1'
 select *from emp_info_main

 --select  member receipt history
SELECT m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, m.MemberStart, m.MemberEnd, mr.ORNumber, mr.ORReceivedDate
FROM member_receipts mr
INNER JOIN member_id_info m
 ON(mr.FirstName = m.id)
INNER JOIN EmpPosition ep
 ON(emp.Position = ep.id)
INNER JOIN EmpStatus es
 ON(emp.ActiveStatus = es.id)
 where emp.ActiveStatus = '2'

--create and insert dewey decimal table
create table BKINV_DeweyDecimalClassification(id int identity (1,1) primary key,  DeweyDecimalRange varchar(500), DeweyDecimalGroup varchar(100))
insert into BKINV_DeweyDecimalClassification values ('000-099', 'General Works');
insert into BKINV_DeweyDecimalClassification values ('100–199', 'Philosophy and Psychology');
insert into BKINV_DeweyDecimalClassification values ('200–299', 'Religion');
insert into BKINV_DeweyDecimalClassification values ('300–399', 'Social Sciences');
insert into BKINV_DeweyDecimalClassification values ('400–499', 'Language');
insert into BKINV_DeweyDecimalClassification values ('500–599', 'Natural Sciences and Mathematics');
insert into BKINV_DeweyDecimalClassification values ('600–699', 'Technology');
insert into BKINV_DeweyDecimalClassification values ('700–799', 'Arts');
insert into BKINV_DeweyDecimalClassification values ('800–899', 'Literature and Rhetoric ');
insert into BKINV_DeweyDecimalClassification values ('900–999', 'History, Biography, and Geography');
select *from BKINV_DeweyDecimalClassification
drop table BKINV_DeweyDecimalClassification

--create table bk_inv notes
create table BKINV_NotesInc (id int identity(1,1) primary key, BookNotes varchar(100))
insert into BKINV_NotesInc values ('YES')
insert into BKINV_NotesInc values ('NO')
select *from BKINV_NotesInc


create table member_info_main (id int identity (1,1) primary key, FirstName int, MiddleName int, LastName int, Suffix int, SchoolOrOrganization int, Address int, EMailAddress int, ContactNo int, MemberStart int, MemberEnd int, ImgPath int);

--create and insert schoolorg
create table memb_SchoolOrOrg (id int identity (1,1) primary key, SchoolOrOrganization varchar(100))
insert into memb_SchoolOrOrg values('City Central School')
insert into memb_SchoolOrOrg values('MOGCHS')
insert into memb_SchoolOrOrg values('USTP')
insert into memb_SchoolOrOrg values('Xavier University')
insert into memb_SchoolOrOrg values('Lapasan National High School')
insert into memb_SchoolOrOrg values('Corpus Christi Grade School')
select *from memb_SchoolOrOrg
drop table memb_SchoolOrOrg

select *from member_id_info
Select id from memb_SchoolOrOrg where SchoolOrOrganization = 'ustp'
select m.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, s.Suffix, o.SchoolOrOrganization, m.Address, m.EMailAddress, m.ContactNo, m.MemberStart, m.MemberEnd, m.ImgPath from member_id_info m inner join name_suffix s on(m.Suffix = s.id) inner join memb_SchoolOrOrg o on(m.SchoolOrOrganization = o.id)

--compare and select same values
select *from memb_SchoolOrOrg where SchoolOrOrganization = '{searchinp}'

--if select *from memb_SchoolOrOrg =  false
insert into memb_SchoolOrOrg values ('{searchinp}');

drop table member_receipts;
create table member_receipts (id int identity (1,1) primary key, COCPL_UID varchar(10), FirstName varchar(10), MiddleName varchar(10),
LastName varchar(10),
ORNumber varchar(8), ORReceivedDate datetime)

select *from member_id_info
select *from member_info_main
select *from member_receipts
delete from member_receipts where id = '8' 

SELECT mr.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, m.MemberStart, m.MemberEnd, mr.ORNumber, mr.ORReceivedDate 
                                     FROM member_receipts mr 
                                     INNER JOIN member_id_info m 
                                     ON(mr.FirstName = m.id)
									 delete from member_receipts where id = 2

select id, position from emp_info_main

create table BKINV_Notes (id int identity (1,1) primary key, AccessionNumber varchar(100), IncBiblio varchar(1), IncGlossary varchar(1), IncIllus varchar(1), IncIndex varchar(1))
select *from BKINV_Notes
drop table bkinv_notes
insert into BKINV_Notes (AccessionNumber, IncBiblio, IncGlossary, IncIllus, IncIndex) values ('asdasd','2','2','2','2');
select n.id, n.AccessionNumber, b.IncBiblio, g.IncGlossary, il.IncIllus, ind.IncIndex from BKINV_Notes n
inner join BKINV_IncBiblio b
on (n.IncBiblio = b.id)
inner join BKINV_IncGlossary g
on (n.IncGlossary = g.id)
inner join BKINV_IncIllus il
on (n.IncIllus = il.id)
inner join BKINV_IncIndex ind
on (n.IncIndex = ind.id)

--create and insert BKINV_IncBiblio table
create table BKINV_IncBiblio(id int identity (1,1) primary key,  IncBiblio varchar(3))
insert into BKINV_IncBiblio values ('YES')
insert into BKINV_IncBiblio values ('NO')
select *from BKINV_IncBiblio

--create and insert BKINV_IncGlossary table
create table BKINV_IncGlossary(id int identity (1,1) primary key,  IncGlossary varchar(3))
insert into BKINV_IncGlossary values ('YES')
insert into BKINV_IncGlossary values ('NO')
select *from BKINV_IncGlossary

--create and insert BKINV_IncIndex table
create table BKINV_IncIndex(id int identity (1,1) primary key,  IncIndex varchar(3))
insert into BKINV_IncIndex values ('YES')
insert into BKINV_IncIndex values ('NO')
select *from BKINV_IncIndex

--create and insert BKINV_IncIllus table
create table BKINV_IncIllus(id int identity (1,1) primary key,  IncIllus varchar(3))
insert into BKINV_IncIllus values ('YES')
insert into BKINV_IncIllus values ('NO')
select *from BKINV_IncIllus

SELECT mr.id, m.COCPL_UID, m.FirstName, m.MiddleName, m.LastName, mr.ORNumber, mr.ORReceivedDate FROM member_receipts mr INNER JOIN member_id_info m ON(mr.FirstName = m.id) where mr.ORNumber = '12312312'
select *from member_receipts where ORReceivedDate like '%17%'
select *from member_receipts

select *from member_receipts

drop table BKINV_IncIllus, BKINV_IncIndex, BKINV_IncGlossary, BKINV_IncBiblio


SELECT * FROM member_receipts
SELECT * FROM member_receipts
WHERE  (DATEPART(YYYY, ORReceivedDate) = 1950
OR DATEPART(MM, ORReceivedDate) = '00'
OR DATEPART(DD, ORReceivedDate) = '10'
OR DATEPART(HH, ORReceivedDate) = '10'
OR DATEPART(MINUTE, ORReceivedDate) = '00'
OR DATEPART(ss, ORReceivedDate) = '52'
)

select id from member_id_info where lastname = 'asdaasdd'
select *from member_id_info
select *from member_receipts

create table memb_exp_notifs(id int identity (1,1) primary key, NotificationMsg varchar(500), DatePosted datetime)
insert into memb_exp_notifs values ('asdads',CURRENT_TIMESTAMP);
insert into memb_exp_notifs values ('asdads',CURRENT_TIMESTAMP);
insert into memb_exp_notifs values ('asdads',CURRENT_TIMESTAMP);
insert into memb_exp_notifs values ('asdads',CURRENT_TIMESTAMP);
drop table memb_exp_notifs
select *from memb_exp_notifs;

select a.AuthorNumber, a.Author from book_inventory_data bi
INNER JOIN author a ON (bi.BookAuthor = a.id and bi.AuthorNo = a.id)

truncate table bkreturns
