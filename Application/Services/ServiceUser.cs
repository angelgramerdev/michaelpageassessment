using Application.Interfaces;
using Domain;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ServiceUser : IServiceUser
    {
        readonly IBaseRepository<User> _repository;
        readonly ObjResponse _response;


        public ServiceUser(IBaseRepository<User> repository, ObjResponse response) 
        {
            _repository = repository;
            _response = response;
        }

       
        public async Task<ObjResponse> Add(User user)
        {
            try
            {
                if (user == null)
                    return await GetBadResponse();

                var response = _repository.Add(user);
                return response.Result;
            }
            catch (Exception e) 
            {
                return await GetBadResponse();
            }
        }

        public async Task<ObjResponse> Edit(User user) 
        {
            try 
            {
                var response = await _repository.Edit(user);
                if(response==null)
                    return await GetBadResponse();

                return response;
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
                ObjResponse response =await _repository.GetUser(id);
                if (response == null)
                    return await GetBadResponse();
               
                return response;    
                
            }
            catch (Exception e) 
            {
                return await GetBadResponse();
            }
        }
        public async Task<ObjResponse> GetUsers() 
        {
            try
            {
                var response =await _repository.GetUsers();
                return response;
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
                await _repository.Delete(id);
                return await GetGoodResponse();   
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
