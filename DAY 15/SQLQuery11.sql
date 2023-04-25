select * from BanTB;

select a.accotno as ACCTNO ,
a.acct_holder_name as AccotName,
a.balance as Balance,
a.Ref_acno as RefAcntNo,r.acct_holder_name as [Name of Reference]
from BanTB a right join BanTB r
on a.Ref_acno=r.accotNo;


select a.accotno as ACCTNO ,
a.acct_holder_name as AccotName,
a.balance as Balance,
a.Ref_acno as RefAcntNo,r.acct_holder_name as [Name of Reference]
from BanTB a left join BanTB r
on a.Ref_acno=r.accotNo;

