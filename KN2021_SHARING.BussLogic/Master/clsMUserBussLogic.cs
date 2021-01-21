using KN2021_SHARING.Common.Entity;
using KN2021_SHARING.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KN2021_SHARING.BussLogic.Master
{
    public class clsMUserBussLogic
    {
        public mUser GetUser(int intUserId)
        {
            GVNMESEntities dObjContext = new GVNMESEntities();

            //Lin Q => select top 1 txtPassword, txtUsername from mUser
            var dataLinQ = (from a in dObjContext.mUsers
                            where a.intUserId == intUserId
                            select a).FirstOrDefault();

            //Lambda = select top 1 * from mUser
            var dataLambda = dObjContext.mUsers.FirstOrDefault();
            
            return dataLinQ;
        }

        public List<mUser> GetListUser()
        {
            GVNMESEntities dObjContext = new GVNMESEntities();

            //Lin Q => select * txtPassword, txtUsername from mUser
            var dataLinQ = (from a in dObjContext.mUsers
                            select a).ToList();

            //Lambda = select * from mUser
            var dataLambda = dObjContext.mUsers.ToList();

            return dataLambda;
        }

        public mUser InsertData(mUser data)
        {
            data.dtCreated = DateTime.Now.AddDays(1);
            data.dtUpdated = DateTime.Now;
            
            GVNMESEntities dObjContext = new GVNMESEntities();

            //cara 1
            dObjContext.mUsers.Add(data);
            dObjContext.SaveChanges();


            //cara 2
            mUser dtToInsert = new mUser();
            dtToInsert.txtUsername = data.txtUsername;
            dtToInsert.txtPassword = data.txtPassword;
            dtToInsert.txtFullname = "";
            dtToInsert.dtCreated = DateTime.Now;
            dtToInsert.dtUpdated = DateTime.Now;

            dObjContext.mUsers.Add(dtToInsert);
            dObjContext.SaveChanges();

            return dtToInsert;
        }

        public bool InsertDataBoolean(mUser data)
        {
            try
            {
                GVNMESEntities dObjContext = new GVNMESEntities();

                //cara 1
                dObjContext.mUsers.Add(data);
                dObjContext.SaveChanges();


                //cara 2
                mUser dtToInsert = new mUser();
                dtToInsert.txtUsername = data.txtUsername;
                dtToInsert.txtPassword = data.txtPassword;
                dtToInsert.txtFullname = "";

                dObjContext.mUsers.Add(dtToInsert);
                dObjContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public mUser UpdateData(mUser data)
        {
            GVNMESEntities dObjContext = new GVNMESEntities();

            //cara 1 
            dObjContext.Entry(data).State = EntityState.Modified;
            dObjContext.SaveChanges();

            //cara 2 
            mUser dtToUpdate = new mUser();
            dtToUpdate = dObjContext.mUsers.Where(x => x.intUserId == data.intUserId).FirstOrDefault(); //lambda
            dtToUpdate = (from a in dObjContext.mUsers
                          where a.intUserId == data.intUserId
                          select a).FirstOrDefault(); //LinQ

            dtToUpdate.txtUsername = data.txtUsername;
            dtToUpdate.txtPassword = data.txtPassword;
            dObjContext.Entry(data).State = EntityState.Modified;

            dObjContext.SaveChanges();

            return dtToUpdate;
        }
    }
}
