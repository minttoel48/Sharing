using KN2021_SHARING.Common.ViewModel;
using KN2021_SHARING.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN2021_SHARING.BussLogic.Transaction
{
    public class clsTCartBussLogic
    {
        public List<clsCartViewModels> GetCartDetail(int id)
        {
            GVNMESEntities dObjContext = new GVNMESEntities();

            //select * from tcartheader a
            var data = (from a in dObjContext.tCartHeaders
                        join b in dObjContext.tCartDetails on a.intCartHeaderId equals b.intCartHeaderId
                        join c in dObjContext.mUsers on a.intUserId equals c.intUserId into leftJoinUser
                        from usr in leftJoinUser.DefaultIfEmpty()
                        join d in dObjContext.mItems on b.intItemId equals d.intItemId
                        where a.intCartHeaderId == id
                        select new clsCartViewModels
                        {
                            intCartDetailId = b.intCartDetailId,
                            intCartHeaderId = a.intCartHeaderId,
                            intItemId = b.intItemId,
                            intQty = b.intQty,
                            intUserId = a.intUserId,
                            txtCartNumber = a.txtCartNumber,
                            txtFullname = usr.txtFullname,
                            ItemName = d.txtItemName,
                            txtItemDescription = d.txtItemDescription
                        }).AsQueryable();
            

            var dtheader = (from a in dObjContext.tCartHeaders
                            select new { a.intCartHeaderId, a.txtCartNumber }).AsQueryable();

            var dtdetail = (from a in dObjContext.tCartDetails
                            select new { a.intCartHeaderId, a.intQty }).AsQueryable();

            var dataJoin = (from a in dtheader
                            join b in dtdetail on a.intCartHeaderId equals b.intCartHeaderId
                            select new clsCartViewModels
                            {

                            }).ToList();

            var dt1 = data.Where(x => x.ItemName == "").ToList();

            return dt1;
        }
    }
}
