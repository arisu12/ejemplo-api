using System;
using System.Collections.Generic;
using System.Linq;
using Javi.Domain;
using Javi.DTO;
using Javi.Infraestructure;

namespace Javi.Application
{
    public class BusinessLogic
    {
        private readonly PizzeriaContext _context;
        public BusinessLogic(PizzeriaContext context)
        {
            this._context = context;
        }
        private ReadIngredientDTO _createReadIngredientDTO(Ingredient ingredient)
        {
            var dto = new ReadIngredientDTO();
            dto.Id = ingredient.Id;
            dto.Name = ingredient.Name;
            return dto;
        }
        private ReadPizzaDTO _createReadPizzaDTO(Pizza pizza)
        {
            // a partir de los PizzaIngredients sacar el Ingredient
            // y transformar ese ingredient a ReadIngredientDTO
        }
        private PizzaSummaryDTO _createPizzaSummaryDTO(Pizza pizza)
        {

        }
        public ICollection<ReadIngredientDTO> GetAllIngredients()
        {
            return _context.Ingredient.Select(ingredient => this._createReadIngredientDTO(ingredient)).ToList();
        }
        public ReadPizzaDTO GetPizzaById(Guid id)
        {
            // buscar la pizza con ese id
            // la transformo de Domain.Pizza a ReadPizzaDTO
        }
        public ICollection<PizzaSummaryDTO> GetAllPizzas()
        {
            // coger todas las pizzas
            // transformarlas a PizzaSummaryDTO
        }
        public ReadPizzaDTO CreatePizza(CreatePizzaDTO dto)
        {
            // crear una pizza con una list de ingredientes vacia
            // buscar cada ingrediente por su id
            // con cada Ingredient crear un PizzaIngredient que tenga la pizza
            // y el ingrediente y a pizza.pizzaIngredients se lo anadimos
        }
    }
}
