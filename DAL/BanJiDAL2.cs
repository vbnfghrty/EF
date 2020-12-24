using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Models;
namespace DAL
{
   public class BanJiDAL2
    {
        MydbEntities mydb = new MydbEntities();

        #region 查询所有
        public List<班级> GetAll()
        {
            return mydb.Set<班级>().ToList();
        }
        #endregion

        #region 增加
        public int Add(班级 bj)
        {
            mydb.Set<班级>().Add(bj);
            return mydb.SaveChanges();
        }
        #endregion

        #region 删除
        public int Delete(班级 bjid)
        {
            var obj = mydb.Set<班级>().Find(bjid);
            mydb.Set<班级>().Remove(obj);
            return mydb.SaveChanges();
        }
        #endregion

        #region 查询一个对象
        public 班级 GetOne(班级 bjid)
        {
            var aobj = mydb.Set<班级>().Find(bjid);
            return aobj;
        }
        #endregion

        #region 修改
        public int Update(班级 bj)
        {
            mydb.Set<班级>().Attach(bj);
            mydb.Entry<班级>(bj).State = EntityState.Modified;
            return mydb.SaveChanges();
        }
        #endregion
   
    }
}
