using AutoMapper;
using LvvlStarterNetApi.Core.Dtos;
using LvvlStarterNetApi.Core.Models;
using LvvlStarterNetApi.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LvvlStarterNetApi.Api.Controllers
{
    [Route("api/blog")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IBlogService _BlogService;

        public BlogController(
            IRepositoryManager repositoryManager,
            IBlogService BlogService
            )
        {
            _repositoryManager = repositoryManager;
            _BlogService = BlogService;
        }

        /// <summary>
        /// Retrieves all Blogs from the Db.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult Get()
        {
            return null;
        }

        /// <summary>
        /// Retrieves a single Blog by Id from the MongoDb.
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {
            return null;
        }

        /// <summary>
        /// Adds an Blog to the MongoDb.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult Post(Blog Blog)
        {
            return null;
        }


        /// <summary>
        /// Deletes an Blog to the MongoDb by a given Id.
        /// </summary>
        [HttpDelete]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult Delete(int id)
        {
            return null;
        }


    }
}