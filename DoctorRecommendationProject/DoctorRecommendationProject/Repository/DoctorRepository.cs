using Dapper;
using DoctorRecommendationProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DoctorRecommendationProject.Repository
{
    public class DoctorRepository
    {
        DBConnection db = new DBConnection();
        public void Add(DoctorModel obj)
        {
            try
            {
                db.connection();
                db.con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Doctor_Specialty_ID", obj.Doctor_Specialty_ID);
                param.Add("@Doctor_Name", obj.Doctor_Name);
                param.Add("@Doctor_Experience", obj.Doctor_Experience);
                param.Add("@Hospital_ID", obj.Hospital_ID);
                param.Add("@Doctor_Education", obj.Doctor_Education);
                param.Add("@Doctor_Phone", obj.Doctor_Phone);
                param.Add("@Doctor_Address", obj.Doctor_Address);
                param.Add("@Doctor_Email", obj.Doctor_Email);
                param.Add("@Doctor_Review", obj.Doctor_Review);
                param.Add("@Doctor_Comment_ID", obj.Doctor_Comment_ID);
                db.con.Execute("InsertDoctor", param, commandType: CommandType.StoredProcedure);
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

        public void Edit(DoctorModel obj)
        {
            try
            {
                db.connection();
                db.con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Doctor_ID", obj.Doctor_ID);
                param.Add("@Doctor_Specialty_ID", obj.Doctor_Specialty_ID);
                param.Add("@Doctor_Name", obj.Doctor_Name);
                param.Add("@Doctor_Experience", obj.Doctor_Experience);
                param.Add("@Hospital_ID", obj.Hospital_ID);
                param.Add("@Doctor_Education", obj.Doctor_Education);
                param.Add("@Doctor_Phone", obj.Doctor_Phone);
                param.Add("@Doctor_Address", obj.Doctor_Address);
                param.Add("@Doctor_Email", obj.Doctor_Email);
                param.Add("@Doctor_Review", obj.Doctor_Review);
                param.Add("@Doctor_Comment_ID", obj.Doctor_Comment_ID);
                db.con.Execute("UpdateDoctor", param, commandType: CommandType.StoredProcedure);
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
                param.Add("@Doctor_ID", id);
                db.con.Execute("DeleteDoctor", param, commandType: CommandType.StoredProcedure);
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

        public DoctorModel getbyUserID(int? id)
        {
            try
            {
                db.connection();
                db.con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Doctor_ID", id);
                var usrid = SqlMapper.Query<DoctorModel>(db.con, "GetByIdDoctor", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
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

        public List<DoctorModel> List()
        {
            db.connection();
            db.con.Open();
            try
            {
                var SidList = SqlMapper.Query<DoctorModel>(db.con, "GetAllDoctor").ToList();
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