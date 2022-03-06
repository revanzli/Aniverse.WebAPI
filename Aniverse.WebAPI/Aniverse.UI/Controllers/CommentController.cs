﻿using Aniverse.Business.DTO_s.Comment;
using Aniverse.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aniverse.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CommentController : Controller
    {
        private readonly IUnitOfWorkService _unitOfWorkService;
        public CommentController(IUnitOfWorkService unitOfWorkService)
        {
            _unitOfWorkService = unitOfWorkService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<CommentGetDto>>> GetAllAsync(int id)
        {
            return await _unitOfWorkService.CommentService.GetAllAsync(id);
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CommentCreateDto commentCreate)
        {
            try
            {
                var user = HttpContext.User;
                await _unitOfWorkService.CommentService.CreateAsync(commentCreate, user);
                return StatusCode(StatusCodes.Status204NoContent, new { Status = "Successs", Message = "Story successfully posted" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status502BadGateway, new { Status = "Error", Message = ex.ToString() });
            }
        }
    }
}