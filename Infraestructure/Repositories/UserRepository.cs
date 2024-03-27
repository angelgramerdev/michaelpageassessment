using Domain;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class UserRepository : IBaseRepository<User>
    {

        private readonly UserContext _context;
        private readonly ObjResponse _response;

        public UserRepository(UserContext context, ObjResponse response) 
        { 
            _context= context;
            _response = response;
        }

        public async Task<ObjResponse> Add(User entity)
        {

            try 
            {
                await _context.Users.AddAsync(entity);
                await _context.SaveChangesAsync();
                return await GetGoodResponse();
            }
            catch(Exception e) 
            {
                return await GetBadResponse();
            }   
        }

        public async Task<ObjResponse> Edit(User entity)
        {

            try 
            {
                var objUser =await _context.Users.FindAsync(entity.Id);
                objUser.Name = entity.Name;
                objUser.Password = entity.Password;
                objUser.Email = entity.Email;   
                await _context.SaveChangesAsync();
                return await GetGoodResponse();
            }
            catch(Exception e) 
            {
                return await GetBadResponse();
            } 
            
        }

        public async Task<ObjResponse> Delete(int id) 
        {
            try
            {
                var objUser = await _context.Users.FindAsync(id);
                _context.Users.Remove(objUser);
                 await _context.SaveChangesAsync();    
                return await GetGoodResponse();
            }
            catch (Exception e)
            {
                return await GetBadResponse();
            }

        }

        public async Task<ObjResponse> GetUser(int id) 
        {
            try 
            {
                var user =await _context.Users.FindAsync(id);
                if (user == null)
                    return await GetBadResponse();

                var response =await GetGoodResponse();
                response.user = user;
                return response;    

            }
            catch(Exception e) 
            {
                return await GetBadResponse();
            }
        }

        public async Task<ObjResponse> GetUsers()
        {
            try 
            {
                var users = await _context.Users.ToListAsync();
                var goodResponse =await GetGoodResponse();
                goodResponse.Users = users;
                return goodResponse;
            }
            catch (Exception e) 
            {
                return await GetBadResponse();
            }
           
        }

        public async Task<ObjResponse> GetBadResponse() 
        {
            _response.Message = "Bad Request";
            _response.StatusCode = HttpStatusCode.BadRequest;
            _response.Code = 400;
            return await Task.FromResult(_response);
        }

        public async Task<ObjResponse> GetGoodResponse() 
        {
            _response.StatusCode = HttpStatusCode.OK;
            _response.Code = 200;
            return await Task.FromResult(_response);   
        }
    }
}
