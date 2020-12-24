using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    /// <summary>
    /// 班级表数据访问类
    /// </summary>
    public class BanJiDAL
    {
        MydbEntities mydb = new MydbEntities();
        #region 查询所有
        public List<班级> GetAll()
        {
            return mydb.班级.ToList();
        }
        #endregion

        #region 查询单值
        public 班级 GetOne(string bjon)
        {
            return mydb.班级.Find(bjon);
        }
        #endregion

        #region 增加
        public int Add(班级 bj)
        {
            mydb.班级.Add(bj);
            return mydb.SaveChanges();
        }
        #endregion

        #region 删除
        public int Delete(string bjno)
        {
            var aobj = mydb.班级.Find(bjno);
            mydb.班级.Remove(aobj);
            
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             return mydb.SaveChanges();
        }
        #endregion

        #region 修改
        public int Update(班级 bj)
        {
            var aodj = mydb.班级.Find(bj.班级号);
            aodj.学院编号 = bj.学院编号;
            aodj.班级人数 = bj.班级人数;
            aodj.班级名称 = bj.班级名称;
            return mydb.SaveChanges();
        }
        #endregion
    }
}
