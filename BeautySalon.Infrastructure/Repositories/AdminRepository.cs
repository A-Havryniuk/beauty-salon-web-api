﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySalon.Application.Repositories;
using BeautySalon.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace BeautySalon.Infrastructure.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly BeautySalonContext _context;

        public AdminRepository(BeautySalonContext context)
        {
            _context = context;
        }
        public async Task<IQueryable<Admins>> GetAllAsync()
        {
            return  _context.Admins;
        }

        public async Task<Admins> GetByIdAsync(int id)
        {
            return await _context.Admins.FirstOrDefaultAsync(a => a.Id == id) ?? throw new ArgumentNullException($"Admin with id {id} not found");
        }

        public async Task InsertAsync(Admins entity)
        {
            await _context.Admins.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Admins entity)
        {
            var obj = await GetByIdAsync(entity.Id);
            entity.PasswordHash = obj.PasswordHash;
            _context.Entry(obj).State = EntityState.Detached;
            _context.Admins.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Admins.FirstOrDefaultAsync(a => a.Id == id);
            if (entity is null)
                return false;
            _context.Admins.Remove(entity);
            await _context.SaveChangesAsync(); 
            return true;
        }

        public async Task<Admins> GetByEmailAsync(string email)
        {
            return await _context.Admins.FirstOrDefaultAsync(o => o.Email.Equals(email)) ?? throw new ArgumentNullException($"Admin with email {email} not found");
        }
    }
}
