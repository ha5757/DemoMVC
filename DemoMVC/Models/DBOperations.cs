using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class DBOperations
    {
        static DemoEntities D = new DemoEntities();


        public static string InsertEmp(EMPDATA A)
        {
            try {
                D.EMPDATAs.Add(A);
                D.SaveChanges();
            }
            catch (DbUpdateException E)
            {
                SqlException ex = E.GetBaseException() as SqlException;
                if (ex.Message.Contains("FK_EmpDept"))
                {
                    return "No Proper Deptno";
                }
                else if (ex.Message.Contains("EMP_PK"))
                {
                    return "Empno cannot be duplicate";
                }
                else
                    return "error occured";
            }
            return "1 row inserted";
        }
        public static List<EMPDATA> GetDept(int Deptno)
        {
            var LE = from L in D.EMPDATAs
                     where L.DEPTNO == Deptno
                     select L;
            return LE.ToList();
        }
        public static List<DEPTDATA> getDepts()
        {
            var dept = from D1 in D.DEPTDATAs
                       select D1;
            return dept.ToList();
        }
        public static List<EMPDATA> delDept()
        {
            var emp = from A in D.EMPDATAs
                      select A;

            return emp.ToList();
        }
        public static string DeleteEmp(int Eno)
        {
            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO == Eno
                    select E1;
            D.EMPDATAs.Remove(E.First());
            D.SaveChanges();
            return Eno + " Employee details are deleted";
        }
        public static EMPDATA Emp(int empno)
        {
            var Emp = from i in D.EMPDATAs
                      where i.EMPNO == empno
                      select i;
            EMPDATA E = Emp.First();
            return E;
        }

        public static string GetEmpnoData(int Empno, EMPDATA emp)
        {
            var LE = from L in D.EMPDATAs
                     where L.EMPNO == Empno
                     select L;
            foreach (var row in LE)
            {
                row.JOB = emp.JOB;
                row.MGR = emp.MGR;
                row.SAL = emp.SAL;
                row.COMM = emp.COMM;
                row.DEPTNO = emp.DEPTNO;
            }
            D.SaveChanges();
            return "1 Row Updated";
        }
        public static List<EMPDATA> GetDisplay(DateTime startdate, DateTime Enddate)
        {
         var L = from S in D.EMPDATAs
                 where S.HIREDATE >= startdate && S.HIREDATE <= Enddate
                 select S;
            return L.ToList();
        }
        public static List<EMPDATA> GetDepts()
        {
            var LE = from L in D.EMPDATAs
                     select L;
            return LE.ToList();
        }
        public static EMPDATA GetEmpupdate(int Empno)
        {
            var LE = from L in D.EMPDATAs
                     where L.EMPNO == Empno
                     select L;
            return LE.FirstOrDefault();

        }
        public static List<EMPDATA> GetEmpupdate1(int[] n)
        {
            var LE = from L in D.EMPDATAs
                     where n.Contains(L.EMPNO)==true
                     select L;
            return LE.ToList();

        }
    }
}