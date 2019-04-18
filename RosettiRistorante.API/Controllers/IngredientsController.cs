using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RosettiRistorante.API.ViewModels;
using RosettiRistorante.BusinessLogic.IServices;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientsController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        // GET api/ingredients/
        [HttpGet]
        public ActionResult GetIngredients()
        {
            return Ok(_ingredientService.GetIngredients());
        }

        // GET api/ingredients/:ingredientId
        [HttpGet("{ingredientId}")]
        public ActionResult GetIngredients(int ingredientId)
        {
            return Ok(_ingredientService.GetIngredientById(ingredientId));
        }

        // POST api/ingredients
        [HttpPost]
        public ActionResult AddIngredient(IngredientViewModel ingredientViewModel)
        {
            if (ingredientViewModel == null)
            {
                return BadRequest("Ingredient cannot be null.");
            }

            var ingredient = new Ingredient
            {
                Name = ingredientViewModel.Name,
                Description = ingredientViewModel.Description
            };


            _ingredientService.AddIngredient(ingredient);
            return StatusCode(201);
        }

        // PUT api/ingredients/:ingredientId
        [HttpPut("{ingredientId}")]
        public ActionResult UpdateIngredient(int ingredientId, [FromBody] IngredientViewModel ingredientViewModel)
        {
            var ingredient = _ingredientService.GetIngredientById(ingredientId);
            if (ingredient == null)
            {
                return BadRequest("Invalid id.");
            }

            ingredient.Name = ingredientViewModel.Name;
            ingredient.Description = ingredientViewModel.Description;

            _ingredientService.UpdateIngredient(ingredient);

            return StatusCode(204);
        }

        // DELETE api/ingredients/:ingredientId
        [HttpDelete("{ingredientId}")]
        public ActionResult DeleteIngredient(int ingredientId)
        {
            var ingredient = _ingredientService.GetIngredientById(ingredientId);
            if (ingredient == null)
            {
                return BadRequest("Invalid id.");
            }

            _ingredientService.DeleteIngredient(ingredientId);

            return StatusCode(200);
        }
    }
}