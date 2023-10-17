using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AstroApp.Backend.Services;
using AstroApp.Shared.Models;

namespace AstroApp.Backend.Controllers
{
    public class PhotoController : ControllerBase
    {
        private IPhotoService _photoService;
        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }
    }
}