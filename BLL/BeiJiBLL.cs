using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class BeiJiBLL
    {
        BanJiDAL bd = new BanJiDAL();
        #region 查询所有
        public List<班级> GetAll()
        {
            return bd.GetAll();
        }
        #endregion

        #region 查询单值
        public 班级 GetOne(string bjon)
        {
            return bd.GetOne(bjon);
        }
        #endregion

        #region 增加
        public int Add(班级 bj)
        {
            return bd.Add(bj);
        }
        #endregion

        #region 删除
        public int Delete(string bjno)
        {
            return bd.Delete(bjno);
        }
        #endregion

        #region 修改
        public int Update(班级 bj)
        {
            return bd.Update(bj);
        }
        #endregion
    }
}
