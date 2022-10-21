using LaboApiGroup_DAL;
using LaboApiGroup_Repo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Repositories
{
    public class ProjectRepo : BasicRepository.BasicRepo<int , Project>
    {
        public ProjectRepo() : base("Project", "Id_Project")
        {
        }

        protected override Project Convert(IDataRecord dtr)
        {
            return new Project
            {
                Id = (int)dtr["Id_Project"],
                Start_Date = (DateTime)dtr["Start_Date"],
                End_Date = (DateTime)dtr["End_Date"],
                Description = dtr["Description"].ToString(),
                Title = dtr["Description"].ToString(),
                Financial_Targets = (int)dtr["Financial_Targets"],
                Earn_Money = (int)dtr["Earn_Money"]
            };
        }
        
        public override bool Delete(Project id)
        {
            Command cmd = new Command("P_Project_DELETE", true);
            cmd.AddParameter("@Id_Project", id.Id);            
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }

        public override int Insert(Project entity)
        {
            Command cmd = new Command("P_Project_Insert", true);
            cmd.AddParameter("@Start_Date", entity.Start_Date);
            cmd.AddParameter("@End_Date", entity.End_Date);
            cmd.AddParameter("@Description", entity.Description);
            cmd.AddParameter("@Tittle", entity.Title);
            cmd.AddParameter("@Financial_Targets", entity.Financial_Targets);
            cmd.AddParameter("@Earn_Money", entity.Earn_Money);
            return ConnectionString.ExecuteNonQuery(cmd);
        }

        public override bool Update(Project data)
        {
            Command cmd = new Command("P_Project_Update", true);
            cmd.AddParameter("@Id_Project", data.Id);
            cmd.AddParameter("@Start_Date", data.Start_Date);
            cmd.AddParameter("@End_Date", data.End_Date);
            cmd.AddParameter("@Description", data.Description);
            cmd.AddParameter("@Tittle", data.Title);
            cmd.AddParameter("@Financial_Targets", data.Financial_Targets);
            cmd.AddParameter("@Earn_Money", data.Earn_Money);            
            return ConnectionString.ExecuteNonQuery(cmd) == 1;
        }      
    }
}
