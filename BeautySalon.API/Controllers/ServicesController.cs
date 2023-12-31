﻿using BeautySalon.Application.Repositories;
using BeautySalon.Contracts.Dtos;
using BeautySalon.Infrastructure;
using MapsterMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BeautySalon.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepo;
        private readonly IMapper _mapper;

        public ServicesController(IServiceRepository serviceRepo, IMapper mapper)
        {
            _serviceRepo = serviceRepo;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAllServices")]
        [Authorize(Roles = "admin, client, employee")]
        public async Task<IEnumerable<ServiceDTO>> GetAllAsync()
        {
            var list = await _serviceRepo.GetAllAsync();
            return _mapper.Map<IEnumerable<ServiceDTO>>(list);
        }

        [HttpGet("{id:int}", Name = "GetServiceById")]
        [Authorize(Roles = "admin")]
        public async Task<ServiceDTO> GetByIdAsync(int id)
        {
            var entity = await _serviceRepo.GetByIdAsync(id);
            return _mapper.Map<ServiceDTO>(entity);
        }
        

        [HttpPost(Name = "AddService")]
        [Authorize(Roles = "admin")]
        public async Task AddAsync(ServiceDTO entity)
        {
            var obj = _mapper.Map<Services>(entity);
            await _serviceRepo.InsertAsync(obj);
        }
        [HttpPut(Name = "UpdateService")]
        [Authorize(Roles = "admin")]
        public async Task UpdateAsync(ServiceDTO employee)
        {
            var entity = _mapper.Map<Services>(employee);
            await _serviceRepo.UpdateAsync(entity);
        }
        [HttpDelete(Name = "DeleteService")]
        [Authorize(Roles = "admin")]
        public async Task DeleteAsync(int id)
        {
            await _serviceRepo.DeleteAsync(id);
        }
    }
}
