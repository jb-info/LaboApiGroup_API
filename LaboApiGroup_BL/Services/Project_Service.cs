﻿using LaboApiGroup_BL.Interfaces;
using LaboApiGroup_BL.Mapper;
using LaboApiGroup_BL.Models;
using LaboApiGroup_Repo.Interfaces;
using LaboApiGroup_Repo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Services
{
    public class Project_Service : IProjectService
    {        
        private ProjectRepo _repository;
        public Project_Service()
        {
            _repository =  new ProjectRepo();
        }

        public bool Delete(Project_BLL entity)
        {
            return _repository.Delete(entity.ToBLL());
        }

        public Project_BLL Get(int id)
        {
            return _repository.Get(id).ToREPO();
        }
        public IEnumerable<Project_BLL> GetAll()
        {
            return _repository.GetAll().Select(x => x.ToREPO());
        }

        public int Insert(Project_BLL entity)
        {
            return _repository.Insert(entity.ToBLL());
        }

        public bool Update(Project_BLL data)
        {
            return _repository.Update(data.ToBLL());
        }
    }
}
