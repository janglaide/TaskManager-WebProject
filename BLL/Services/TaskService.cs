using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class TaskService : ITaskService
    {
        private IUnitOfWork _uow;
        public TaskService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
        public TaskDTO Get(int id)
        {
            var mapper = new MapperConfiguration(x => x.CreateMap<Task, TaskDTO>()).CreateMapper();
            throw new NotImplementedException();
            //return mapper.Map<Task, TaskDTO>()
        }

        public IEnumerable<TaskDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
