using Dapper;
using DoctorRecommendationProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DoctorRecommendationProject.Repository
{
    public class HospitalRepository
    {
        DBConnection db = new DBConnection();
        public void Add(HospitalModel obj)
        {
            try
            {
                db.connection();
                db.con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Hospital_Name", obj.Hospital_Name);
                param.Add("@Hospital_Address", obj.Hospital_Address);
                param.Add("@Hospital_Phone", obj.Hospital_Phone);
                db.con.Execute("InsertHospital", param, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.con.Close();
            }
        }

        public void Edit(HospitalModel obj)
        {
            try
            {
                db.connection();
                db.con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Hospital_ID", obj.Hospital_ID);
                param.Add("@Hospital_Name", obj.Hospital_Name);
                param.Add("@Hospital_Address", obj.Hospital_Address);
                param.Add("@Hospital_Phone", obj.Hospital_Phone);
                db.con.Execute("UpdateHospital", param, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.con.Close();
            }
        }

        public void Delete(int? id)
        {
            try
            {
                db.connection();
                db.con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Hospital_ID", id);
                db.con.Execute("DeleteHospital", param, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.con.Close();
            }
        }

        public HospitalModel getbyUserID(int? id)
        {
            try
            {
                db.connection();
                db.con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Hospital_ID", id);
                var usrid = SqlMapper.Query<HospitalModel>(db.con, "GetByIdHospital", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return usrid;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.con.Close();
            }
        }

        public List<HospitalModel> List()
        {
            db.connection();
            db.con.Open();
            try
            {
                var SidList = SqlMapper.Query<HospitalModel>(db.con, "GetAllHospital").ToList();
                return SidList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.con.Close();
            }
        }
    }
}