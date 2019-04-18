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
    public class SuppliersController : ControllerBase
    {
        private readonly IIngredientSupplierService _ingredientSupplierService;

        public SuppliersController(IIngredientSupplierService ingredientSupplierService)
        {
            _ingredientSupplierService = ingredientSupplierService;
        }

        // GET api/suppliers/:supplierId/ingredientsSupplier
        [HttpGet("{supplierId}/ingredientsSupplier")]
        public ActionResult GetIngredientsBySupplierId(int supplierId)
        {

            // TODO: de verificat daca exista supplier-ul 
            return Ok(_ingredientSupplierService.GetIngredientSuppliersBySupplierId(supplierId));
        }

        // GET api/suppliers/:supplierId/ingredientsSupplier/:ingredientSupplierId
        [HttpGet("{supplierId}/ingredientsSupplier/{ingredientSupplierId}")]
        public ActionResult GetIngredientsSupplierById(int supplierId, int ingredientSupplierId)
        {
            return Ok(_ingredientSupplierService.GetIngredientSupplierById(ingredientSupplierId));
        }

        // POST api/suppliers/:supplierId/ingredientsSupplier
        [HttpPost("{supplierId}/ingredientsSupplier")]
        public ActionResult AddSupplierIngredient(int supplierId, [FromBody]
            IngredientSupplierViewModel ingredientSupplierViewModel)
        {
            if (ingredientSupplierViewModel == null)
            {
                return BadRequest("IngredientSupplier cannot be null.");
            }

            var ingredientSupplier = new IngredientSupplier()
            {
                IngredientId = ingredientSupplierViewModel.IngredientId,
                Price = ingredientSupplierViewModel.Price,
                SupplierId = ingredientSupplierViewModel.SupplierId,
                TotalAmount = ingredientSupplierViewModel.TotalAmount
            };


            _ingredientSupplierService.AddIngredientSupplier(ingredientSupplier);
            return StatusCode(201);
        }

        // PUT api/suppliers/:supplierId/ingredientsSupplier/:ingredientSupplierId
        [HttpPut("{supplierId}/ingredientsSupplier/{ingredientSupplierId}")]
        public ActionResult UpdateSupplierIngredient(int supplierId, [FromBody]
            IngredientSupplierViewModel ingredientSupplierViewModel,
            int ingredientSupplierId)
        {
            if (ingredientSupplierViewModel == null)
            {
                return BadRequest("IngredientSupplier cannot be null.");
            }

            var ingredientSupplier = _ingredientSupplierService.GetIngredientSupplierById(ingredientSupplierId);

            ingredientSupplier.IngredientId = ingredientSupplierViewModel.IngredientId;
            ingredientSupplier.Price = ingredientSupplierViewModel.Price;
            ingredientSupplier.SupplierId = ingredientSupplierViewModel.SupplierId;
            ingredientSupplier.TotalAmount = ingredientSupplierViewModel.TotalAmount;

            _ingredientSupplierService.UpdateIngredientSupplier(ingredientSupplier);
            return StatusCode(204);
        }

        // POST api/suppliers/:supplierId/orderIngredients
        [HttpPost("{supplierId}/orderIngredients")]
        public ActionResult PerformOrderSupplier(int supplierId, [FromBody]
            OrderSupplierViewModel orderSupplierViewModel)
        {
            if (orderSupplierViewModel == null)
            {
                return BadRequest("OrderSupplier cannot be null.");
            }

            try
            {
                var supplierBill = _ingredientSupplierService.OrderIngredientsFromSupplier(supplierId,
                    orderSupplierViewModel.IngredientSupplierId, orderSupplierViewModel.Amount);
                return Ok(supplierBill);
            }

            catch(ArgumentException e)
            {
                return BadRequest(e);
            }
            
        }
    }
}